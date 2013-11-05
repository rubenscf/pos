Imports Oracle.DataAccess.Client

Public Class ctrlNuevoAbono
    Dim idcliente, credito As Decimal
    Dim existeCDPI As Boolean
    Dim query As String
    Dim tipo_abono As String = "1" ' 0 = enganche      1 = abono
    Dim mora, abono As Double
    Dim eng_X2, estadoCredito, clugar As String

    Sub verificaDPI(ByRef existe As Boolean, ByVal sDpi As String, ByVal v As Integer)
        Dim query As String = "select nombre ||' '||apellido as nombre, direccion,   cl_nivel, idcliente  from cliente where dpi ='" & sDpi & "'"
        Try
            frmMain._cnn.Open()

            frmMain._cmd = New OracleCommand(query, frmMain._cnn)
            Dim r As OracleDataReader = frmMain._cmd.ExecuteReader()
            Dim f As Decimal = 0

            If r.HasRows Then
                If v = 0 Then
                    While r.Read
                        lbCTipo.Text = r.GetString(2)
                        txCNombre.Text = r.GetString(0)
                        txCDireccion.Text = r.GetString(1)
                        idcliente = r.GetDecimal(3)
                    End While
                    r.Close()

                End If

                existe = True
            Else
                existe = False
                _ESTADO("Numero de DPI no existe en la base de datos", frmMain.lbEstado)
            End If
        Catch ex As Exception
            _ESTADO(ex.Message.ToString, frmMain.lbEstado)
        Finally
            frmMain._cnn.Close()
        End Try
    End Sub

    Private Sub txCDPI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txCDPI.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txCDPI_LostFocus(sender As Object, e As EventArgs) Handles txCDPI.LostFocus

        txCDPI.Text = txCDPI.Text.ToUpper
        If txCDPI.Text <> "" Then
            Dim sDpi As String = txCDPI.Text
            verificaDPI(existeCDPI, sDpi, 0)
            If existeCDPI Then
                query = "SELECT cr.idlugar, cr.idve_credito, cr.fecha as FECHA,  lu.NOMBRE as TIENDA, 'Q.'||cr.total as TOTAL, cr.estado, cr.eng_x2 from ve_credito cr INNER JOIN LUGAR lu ON lu.idlugar = cr.idlugar where cliente = '" & idcliente & "' and (ESTADO = 'CVI' or ESTADO = 'CAC')"
                Try
                    frmMain._cnn.Open()
                    _SET_DG("credito_abono", query, dg)
                    If dg.RowCount > 0 Then
                        dg.Columns.Item(0).Visible = False
                        dg.Columns.Item(1).Visible = False
                        dg.Columns.Item(5).Visible = False 'estadoo de creidoto
                        dg.Columns.Item(6).Visible = False  ' si es doble enganche
                    Else
                        _ESTADO("El cliente no tiene creditos activos", frmMain.lbEstado)

                    End If
                Catch ex As Exception
                    _ESTADO(ex.Message, frmMain.lbEstado)
                Finally
                    frmMain._cnn.Close()
                End Try

                
            Else
                txCDPI.Focus()
                txCDPI.SelectAll()
                _ESTADO("Error: No existe el DPI en la base de datos", frmMain.lbEstado)
            End If
        End If
    End Sub

    Private Sub dg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellClick
        If dgPV.Rows.Count > 0 Then
            dgPV.Rows.Clear()
        End If
        lbSt.Text = "0.0"
        lbTotal.Text = "0.0"
        txCorrelativo.Text = ""
        lbSaldoA.Text = "0.0"
        lbSaldoP.Text = "0.0"
        txMora.Value = 0
        btCobrar.Enabled = False
        calcular()
        Try
            frmMain._cnn.Open()
            query = "SELECT ma.nombre as MARCA, mo.nombre as MODELO, det.NO_SERIE as SERIE from ve_cr_detalle det INNER JOIN PR_MODELO mo ON det.idpr_modelo = mo.idpr_modelo INNER JOIN PR_MARCA ma ON det.idpr_marca = ma.idmarca where det.idlugar = '" & dg.CurrentRow.Cells(0).Value & "' and det.idve_credito = '" & dg.CurrentRow.Cells(1).Value & "' "
            _SET_DG("detalle_credito_abono", query, dgD)
            clugar = dg.CurrentRow.Cells(0).Value
            credito = CDec(dg.CurrentRow.Cells(1).Value)
            Dim r As OracleDataReader
            If dg.CurrentRow.Cells(5).Value = "CAC" Then 'si no se ha pagado nada de ese credito
                chEnganche.Checked = True
                tipo_abono = "2"

                query = " select total from ve_credito where idlugar ='" & dg.CurrentRow.Cells(0).Value & "' and idve_credito = '" & dg.CurrentRow.Cells(1).Value & "'"
                r = _CONSULTAR_orcl(query)
                While (r.Read)
                    lbSaldoP.Text = Replace(r.GetDecimal(0).ToString, ",", ".")
                End While
                r.Close()

                If dg.CurrentRow.Cells(6).Value.ToString = "1" Then
                    query = "SELECT cantidad, idve_letra as No, FECHA_VENCE as FECHA, 'Q.'||CANTIDAD as CUOTA from VE_LETRA where idlugar = '" & dg.CurrentRow.Cells(0).Value & "' and idve_credito = '" & dg.CurrentRow.Cells(1).Value & "' and ROWNUM < 3 and ESTADO = 'LPE'"
                Else
                    query = "SELECT cantidad, idve_letra as No, FECHA_VENCE as FECHA, 'Q.'||CANTIDAD as CUOTA from VE_LETRA where idlugar = '" & dg.CurrentRow.Cells(0).Value & "' and idve_credito = '" & dg.CurrentRow.Cells(1).Value & "' and ROWNUM = 1 and ESTADO = 'LPE'"
                End If
            ElseIf dg.CurrentRow.Cells(5).Value = "CVI" Then
                query = " SELECT		ab.SALDO_FIN " &
                " FROM AGENCIA.VE_ABONO ab " &
                " INNER JOIN AGENCIA.VE_LETRA le ON le.AB_SERIE = ab.IDLUGAR AND le.AB_CORRELATIVO = ab.IDVE_ABONO " &
                " WHERE le.idlugar = '" & dg.CurrentRow.Cells(0).Value & "' AND le.idve_credito = '" & dg.CurrentRow.Cells(1).Value & "'  AND le.estado = 'LCA' AND ROWNUM = 1 " &
                " ORDER BY	LE.IDVE_LETRA DESC"
                r = _CONSULTAR_orcl(query)
                While (r.Read)
                    lbSaldoA.Text = r.GetDecimal(0)
                    lbSaldoP.Text = Val(lbSaldoP.Text) - Val(lbTotal.Text)
                End While
                r.Close()

                query = "SELECT cantidad, idve_letra as No, FECHA_VENCE as FECHA, 'Q.'||CANTIDAD as CUOTA from VE_LETRA where idlugar = '" & dg.CurrentRow.Cells(0).Value & "' and idve_credito = '" & dg.CurrentRow.Cells(1).Value & "' and ESTADO = 'LPE'"
                chEnganche.Checked = False
                tipo_abono = "1"
            End If

            _SET_DG("letras_credito_abono", query, dgP)
            dgP.Columns.Item(0).Visible = False
        Catch ex As Exception
            _ESTADO(ex.Message, frmMain.lbEstado)
        Finally
            frmMain._cnn.Close()
        End Try

    End Sub

   
 
    Private Sub btAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click
        If dgP.Rows.Count > 0 Then
            Try
                Dim filtro As String = dgP.SelectedCells(1).Value
                Dim existe As Boolean = False
                Dim rowCodigo As String = String.Empty
                For Each row As DataGridViewRow In dgPV.Rows
                    rowCodigo = row.Cells("No").Value
                    ' MsgBox(filtro)
                    ' MsgBox(rowCodigo)
                    If filtro = rowCodigo Then
                        existe = True
                        Exit For
                    End If
                Next
                If existe Then
                    _ESTADO("Esta letra ya existe en el listado a cancelar", frmMain.lbEstado)
                Else
                    dgPV.Rows.Add(dgP.SelectedCells(0).Value, dgP.SelectedCells(1).Value, dgP.SelectedCells(2).Value, dgP.SelectedCells(3).Value)
                End If
            Catch ex As Exception
                _ESTADO(ex.Message, frmMain.lbEstado)
            End Try
        End If
        txCorrelativo.Enabled = True
        calcular()
    End Sub

  

    Private Sub txCDPI_TextChanged(sender As Object, e As EventArgs) Handles txCDPI.TextChanged
        reinicio()
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles btRemove.Click
        If dgPV.RowCount > 0 Then
            Dim resp As Integer
            resp = MsgBox("Esta seguro de quitar esta letra de credito de la lista? ", MsgBoxStyle.YesNo)
            If resp = vbYes Then
                dgPV.Rows.Remove(dgPV.CurrentRow)
            End If
        End If
        If dgPV.RowCount = 0 Then
            txCorrelativo.Enabled = False

        End If
        calcular()
    End Sub

    
    Private Sub ctrlNuevoAbono_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbSerie.Text = frmMain.serie
    End Sub
    Sub reinicio()
        If dg.Rows.Count > 0 Then
            dg.DataSource = vbNull
            dg.Refresh()
        End If
        If dgD.Rows.Count > 0 Then
            dgD.DataSource = vbNull
            dgD.Refresh()
        End If
        If dgP.Rows.Count > 0 Then
            dgP.DataSource = vbNull
            dgP.Refresh()
        End If
        If dgPV.Rows.Count > 0 Then
            dgPV.Rows.Clear()
        End If
        lbSt.Text = "0.0"
        lbTotal.Text = "0.0"
        txCorrelativo.Text = ""
        lbSaldoA.Text = "0.0"
        lbSaldoP.Text = "0.0"
        txMora.Value = 0
        btCobrar.Enabled = False
    End Sub

    Sub calcular()
        If dgPV.RowCount = 0 Then
            _ESTADO("Ingrese una letra para abonar", frmMain.lbEstado)
        Else

            Dim total As Double = 0
            mora = CDbl(txMora.Value) / 100
            For Each f As DataGridViewRow In dgPV.Rows
                total += CDbl(f.Cells(0).Value)
            Next
            lbSt.Text = total
            mora = mora * CDbl(lbSt.Text)
            abono = CDbl(lbSt.Text)
            lbTotal.Text = mora + CDbl(lbSt.Text)
            lbSaldoP.Text = CDbl(lbSaldoA.Text) - CDbl(lbTotal.Text)
        End If

        btCobrar.Enabled = True
    End Sub

    Private Sub txMora_ValueChanged(sender As Object, e As EventArgs) Handles txMora.ValueChanged
        calcular()
    End Sub

    Private Sub btCobrar_Click(sender As Object, e As EventArgs) Handles btCobrar.Click
        If dgPV.RowCount = 0 Then
            _ESTADO("Seleccione las letras que se cancelaran ", frmMain.lbEstado)
            btCobrar.Enabled = False
        ElseIf txCorrelativo.Text = "" Then
            _ESTADO("Ingrese un numero de documento (RECIBO) ", frmMain.lbEstado)
            txCorrelativo.Focus()
            btCobrar.Enabled = False
        Else
            Dim resp As Integer = MsgBox("Esta segur@ que desea Cobrar esta transaccion? ", MsgBoxStyle.YesNo)
            If resp = vbYes Then
                frmMain._cmd = New OracleCommand()
                Dim lugarActual As String = frmMain.serie
                Dim estado As Decimal
                Dim dbms As New DBMSOutput(frmMain._cnn)
                Try
                    frmMain._cnn.Open()

                    dbms.Enable()

                    '''''GENERA EL REGISTRO DEL ABONO
                    With frmMain._cmd
                        .Connection = frmMain._cnn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "SP_COBRAR_ABONO"
                        .Parameters.Add(New OracleParameter("v_lugar", OracleDbType.Varchar2)).Value = frmMain.serie
                        .Parameters.Add(New OracleParameter("v_idve_abono", OracleDbType.Varchar2)).Value = txCorrelativo.Text
                        .Parameters.Add(New OracleParameter("v_cliente", OracleDbType.Varchar2)).Value = idcliente.ToString
                        .Parameters.Add(New OracleParameter("v_tipoAbono", OracleDbType.Varchar2)).Value = tipo_abono
                        .Parameters.Add(New OracleParameter("v_abono", OracleDbType.Varchar2)).Value = abono.ToString
                        .Parameters.Add(New OracleParameter("v_mora", OracleDbType.Varchar2)).Value = mora.ToString
                        .Parameters.Add(New OracleParameter("v_total", OracleDbType.Varchar2)).Value = lbTotal.Text
                        .Parameters.Add(New OracleParameter("v_empleado", OracleDbType.Varchar2)).Value = frmMain.idempleado
                        .Parameters.Add(New OracleParameter("v_clugar", OracleDbType.Varchar2)).Value = dg.CurrentRow.Cells(0).Value
                        .Parameters.Add(New OracleParameter("v_credito", OracleDbType.Varchar2)).Value = dg.CurrentRow.Cells(1).Value
                        .Parameters.Add(New OracleParameter("v_idabono", OracleDbType.Int32, ParameterDirection.Output))
                        .Parameters.Add(New OracleParameter("v_estado", OracleDbType.Int32, ParameterDirection.Output))
                    End With
                    frmMain._cmd.ExecuteNonQuery()

                    estado = CDec(frmMain._cmd.Parameters("v_estado").Value.ToString)
                    dbms.Show(frmMain.lbEstado)
                Catch ex As Exception
                    MsgBox(ex.Message, vbExclamation)
                Finally
                    frmMain._cnn.Close()
                End Try


                Try
                    frmMain._cnn.Open()

                    If estado > 0 Then


                        dbms.Enable()
                        For Each f As DataGridViewRow In dgPV.Rows
                            frmMain._cmd = New OracleCommand
                            With frmMain._cmd
                                .Connection = frmMain._cnn
                                .CommandType = CommandType.StoredProcedure
                                .CommandText = "SP_EDITAR_LETRA"
                                .Parameters.Add(New OracleParameter("v_clugar", OracleDbType.Varchar2)).Value = CStr(clugar)
                                .Parameters.Add(New OracleParameter("v_credito", OracleDbType.Decimal)).Value = CDec(credito)
                                .Parameters.Add(New OracleParameter("v_letra", OracleDbType.Decimal)).Value = CDec(f.Cells(1).Value.ToString)
                                .Parameters.Add(New OracleParameter("v_serie", OracleDbType.Varchar2)).Value = CStr(lugarActual)
                                .Parameters.Add(New OracleParameter("v_correlativo", OracleDbType.Decimal)).Value = CDec(txCorrelativo.Text)
                                .Parameters.Add(New OracleParameter("v_estado", OracleDbType.Int32, ParameterDirection.Output))
                            End With
                            frmMain._cmd.ExecuteNonQuery()


                        Next
                        dbms.Show()
                    ElseIf frmMain._cmd.Parameters("v_estado").Value < 0 Then
                        _ESTADO("ERROR: NO SE GUARDO LA TRANSACCION... CONTACTESE CON EL ADMINISTRADOR", frmMain.lbEstado)
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    frmMain._cnn.Close()
                End Try

            End If 'fin respuesta msgbox 
        End If
        reinicio()

    End Sub

    Private Sub chEnganche_CheckedChanged(sender As Object, e As EventArgs) Handles chEnganche.CheckedChanged
        If chEnganche.Checked Then
            tipo_abono = "2"
        Else
            tipo_abono = "1"
        End If
    End Sub

   

   
    Private Sub txCorrelativo_LostFocus(sender As Object, e As EventArgs) Handles txCorrelativo.LostFocus
       
        Try
            frmMain._cnn.Open()
            Dim query As String = "select idlugar from ve_abono where idlugar ='" & frmMain.serie & "' and idve_abono = '" & txCorrelativo.Text & "'"
            Dim r As OracleDataReader = _CONSULTAR_orcl(query)
            If r.HasRows Then
                btCobrar.Enabled = False
                _ESTADO("Este numero de documento ya fue registrado... verifique", frmMain.lbEstado)
                txCorrelativo.Focus()
                txCorrelativo.SelectAll()
            Else
                btCobrar.Enabled = True
            End If
        Catch ex As Exception
            _ESTADO(ex.Message.ToString, frmMain.lbEstado)
        Finally
            frmMain._cnn.Close()
        End Try
    End Sub

    
End Class

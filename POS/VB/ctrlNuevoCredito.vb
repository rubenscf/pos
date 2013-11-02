Imports Oracle.DataAccess.Client
Imports DevComponents.DotNetBar

Public Class ctrlNuevoCredito

    Dim _Bs As BindingSource
    Dim dg As DataGridView
    Dim vmarca, vmodelo, vdetalle As String
    Dim ExisteCDPI As Boolean = False
    Dim ExisteFDPI As Boolean = False
    Dim cnivel As String
    Dim precio, idcl_plan As Decimal
    Dim idcliente, idfiador As Decimal
    Dim idpr_categoria As Decimal = 1
    Dim descuento As Double




    Private Sub txCDPI_LostFocus(sender As Object, e As EventArgs) Handles txCDPI.LostFocus
        txCDPI.Text = txCDPI.Text.ToUpper
        If txCDPI.Text <> "" Then
            Dim sDpi As String = txCDPI.Text

            verificaDPI(ExisteCDPI, sDpi, 0)
            If ExisteCDPI Then

                Container.Panel2.Enabled = True
                If dgD.RowCount > 0 Then
                    btGuardar.Enabled = True
                    btCalcula.Enabled = True
                End If

            Else

                Container.Panel2.Enabled = False
                btGuardar.Enabled = False
                btCalcula.Enabled = False
            End If
        Else
            txCDPI.Focus()
            txCDPI.SelectAll()
            _ESTADO("Error: Ingrese DPI", frmMain.lbEstado)
        End If

    End Sub
    Private Sub txFDPI_LostFocus(sender As Object, e As EventArgs) Handles txFDPI.LostFocus
        txFDPI.Text = txFDPI.Text.ToUpper
        If txFDPI.Text <> "" Then
            Dim sDpi As String = txFDPI.Text

            verificaDPI(ExisteFDPI, sDpi, 1)
            If ExisteFDPI Then

                Container.Panel2.Enabled = True
                If dgD.RowCount > 0 Then
                    btGuardar.Enabled = True
                    btCalcula.Enabled = True
                End If

            Else

                Container.Panel2.Enabled = False
                btGuardar.Enabled = False
                btCalcula.Enabled = False
            End If
        Else
            txFDPI.Focus()
            txFDPI.SelectAll()
            _ESTADO("Error: Ingrese DPI", frmMain.lbEstado)
        End If

    End Sub



    Sub verificaDPI(ByRef existe As Boolean, ByVal sDpi As String, ByVal v As Integer)
        Dim query As String = "select nombre ||' '||apellido as nombre, direccion,   cl_nivel, idcliente, telefono, nit  from cliente where dpi ='" & sDpi & "'"
        Try
            frmMain._cnn.Open()

            frmMain._cmd = New OracleCommand(query, frmMain._cnn)
            Dim r As OracleDataReader = frmMain._cmd.ExecuteReader()
            Dim f As Decimal = 0

            If r.HasRows Then
                If v = 0 Then
                    While r.Read
                        cnivel = r.GetString(2)
                        lbCTipo.Text = r.GetString(2)
                        txCNombre.Text = r.GetString(0)
                        txCDireccion.Text = r.GetString(1)
                        txCTel.Text = r.GetString(4)
                        txCNIT.Text = r.GetString(5)
                        txCDireccion.Text = r.GetString(1)
                        idcliente = r.GetDecimal(3)
                    End While
                    r.Close()
                Else
                    While r.Read
                        txFnombre.Text = r.GetString(0)
                        txFDireccion.Text = r.GetString(1)
                        txFTel.Text = r.GetString(4)
                        txFNIT.Text = r.GetString(5)
                        txFDireccion.Text = r.GetString(1)
                        idfiador = r.GetDecimal(3)
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

    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBStock.Click
        Dim ind As Integer = -1
        Dim clave As String = "Stock"
        If frmMain.htp.ContainsKey(clave) Then
            frmMain.tpMain.SelectedTabIndex = frmMain.htp.Item(clave)
        Else
            Dim newTab As TabItem = frmMain.tpMain.CreateTab(clave, -1)
            Dim panel As TabControlPanel = DirectCast(newTab.AttachedControl, TabControlPanel)
            ind = frmMain.tpMain.Tabs.Count - 1
            frmMain.tpMain.SelectedTabIndex = ind
            Dim control As New ctrlStokVer            'cambiar control
            control.Dock = DockStyle.Fill
            panel.Controls.Add(control)
            frmMain.htp.Add(clave, ind)
            '            MsgBox(ind.ToString)
        End If
    End Sub

   



    Public Sub txtSearch()


        If txMa.Text = "" Or txMo.Text = "" Then
            _ESTADO("Ingrese el codigo del producto", frmMain.lbEstado)
        Else
            Dim query As String = "SELECT MO.IDPR_MARCA, MO.IDPR_MODELO, MO.IDPR_MARCA || '-' || MO.IDPR_MODELO AS CODIGO, CA.NOMBRE AS CATEGORIA, MA.NOMBRE AS MARCA,  " &
                          "      MO.NOMBRE AS MODELO, MO.DETALLE AS DETALLE, INV.NUEVA AS NUEVOS, mo.preciov, MO.idpr_categoria  " &
                         "FROM AGENCIA.PR_INVENTARIO INV   " &
                         "     INNER JOIN AGENCIA.PR_MODELO MO ON INV.IDPR_MODELO = MO.IDPR_MODELO AND INV.IDPR_MARCA = MO.IDPR_MARCA   " &
                          "    INNER JOIN AGENCIA.PR_MARCA MA ON MO.IDPR_MARCA = MA.IDMARCA   " &
                          "    INNER JOIN AGENCIA.PR_TIPO TI ON MO.IDPR_TIPO = TI.IDPR_TIPO AND MO.IDPR_CATEGORIA = TI.IDPR_CATEGORIA " &
                          "    INNER JOIN AGENCIA.PR_CATEGORIA CA ON TI.IDPR_CATEGORIA = CA.IDPR_CATEGORIA   " &
                          "    INNER JOIN AGENCIA.LUGAR LU ON INV.IDLUGAR = LU.IDLUGAR   " &
                          "    WHERE LU.IDLU_TIPO = '" & frmMain.idtipolugar & "' AND LU.IDLUGAR = '" & frmMain.serie & "' AND mo.idpr_marca='" & txMa.Text & "' and mo.idpr_modelo = '" & txMo.Text & "' "

            Dim da As New OracleDataAdapter

            Try
                frmMain._cnn.Open()
                Dim dbms As New DBMSOutput(frmMain._cnn)

                dbms.Enable()
                frmMain._cmd = New OracleCommand(query, frmMain._cnn)
                frmMain._cmd.Connection = frmMain._cnn
                da.SelectCommand = frmMain._cmd
                Dim r As OracleDataReader = frmMain._cmd.ExecuteReader()
                If r.HasRows Then

                    While (r.Read)
                        vmarca = CInt(r.GetDecimal(0))
                        vmodelo = CInt(r.GetDecimal(1))
                        lbCodigo.Text = r.GetString(2)
                        vdetalle = r.GetString(6)
                        lbMarca.Text = r.GetString(4)
                        lbModelo.Text = r.GetString(5)
                        lbStock.Text = r.GetDecimal(7)
                        precio = r.GetDecimal(8)
                        idpr_categoria = r.GetDecimal(9)

                    End While
                    r.Close()
                    btAgregarLista.Enabled = True
                Else
                    _ESTADO("No se encontro el producto revise el stok en tienda", frmMain.lbEstado)

                    btAgregarLista.Enabled = False
                    lbCodigo.Text = ""
                    lbMarca.Text = ""
                    lbModelo.Text = ""
                    lbStock.Text = ""
                    precio = 0
                    txMo.SelectAll()

                End If




            Catch ex As Exception
                _ESTADO(ex.Message, frmMain.lbEstado)
            Finally
                frmMain._cnn.Close()
            End Try
        End If

    End Sub

    Private Sub ButtonX3_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        txtSearch()
    End Sub

  

    

    Private Sub txMo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txMo.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txMa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txMa.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
        End If
    End Sub

 

    Private Sub btAgregarLista_Click(sender As Object, e As EventArgs) Handles btAgregarLista.Click
        Try
            Dim filtro As String = lbCodigo.Text
            Dim existe As Boolean = False
            Dim rowCodigo As String = String.Empty
            Dim cant As Integer = 0
            For Each row As DataGridViewRow In dgD.Rows
                rowCodigo = row.Cells("CODIGO").Value
                ' MsgBox(filtro)
                ' MsgBox(rowCodigo)
                If filtro = rowCodigo Then
                    cant += 1
                End If
            Next
            If cant >= Val(lbStock.Text) Then
                _ESTADO("No puede sobrepasar la cantidad en stock", frmMain.lbEstado)
            Else
                dgD.Rows.Add(vmarca, vmodelo, idpr_categoria, lbCodigo.Text, lbMarca.Text, lbModelo.Text, vdetalle, precio, "")
                btGuardar.Enabled = True
                btAgregarLista.Enabled = False
                lbCodigo.Text = ""
                lbMarca.Text = ""
                lbModelo.Text = ""
                lbStock.Text = ""

                txMo.SelectAll()

                txMa.Text = ""
                txMo.Text = ""
                lbNarticulo.Text = dgD.Rows.Count
                btCalcula.Enabled = True
            End If
        Catch ex As Exception
            _ESTADO(ex.Message, frmMain.lbEstado)
        End Try
    End Sub
   
    Private Sub btQuitarLista_Click(sender As Object, e As EventArgs) Handles btQuitarLista.Click
        If dgD.RowCount > 0 Then
            Dim resp As Integer
            resp = MsgBox("Esta seguro de quitar este producto de la lista? ", MsgBoxStyle.YesNo)
            If resp = vbYes Then
                dgD.Rows.Remove(dgD.CurrentRow)
                lbNarticulo.Text = dgD.RowCount
                If dgD.RowCount < 1 Then
                    btGuardar.Enabled = False
                    btCalcula.Enabled = False
                End If
            End If


        End If
    End Sub

   



    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click

        
        Dim v As Boolean = True
        If dgD.Rows.Count > 0 Then

            If txFDPI.Text <> "" And txCDPI.Text <> "" Then

             

                If v = True Then

                    Dim resp As Integer
                    resp = MsgBox("Esta segur@ que desea enviar para aprobacion este contrato de credito? ", MsgBoxStyle.YesNo)
                    If resp = vbYes Then
                        frmMain._cmd = New OracleCommand()
                        Dim trans As OracleTransaction


                        Dim lugarActual As String = frmMain.serie
                        Dim query As String
                        Dim s As OracleDataReader
                        frmMain._cnn.Open()
                        trans = frmMain._cnn.BeginTransaction(IsolationLevel.ReadCommitted)
                        frmMain._cmd.Transaction = trans
                        frmMain._cmd.Connection = frmMain._cnn

                        Try

                            query = "INSERT INTO VE_CREDITO(idlugar, idve_credito, cliente, idempleado, fiador, idcl_plan, fecha, enganche, no_cuota, valor_cuota, ultima_cuota, descuento, total, observaciones, estado ) VALUES('" &
                                frmMain.serie & "', SEQ_" & frmMain.serie & "_IDVE_CREDITO.nextval, '" & idcliente & "', '" & frmMain.idempleado & "','" & idfiador & "', '" & idcl_plan & "', sysdate, '" & txEnganche.Text & "', '" & nPago.Value & "','" & lbCuotas.Text & "', '" & lbUCuota.Text & "','" & descuento & "', '" & lbTotal.Text & "','" & txObservaciones.Text & "','CSO')"
                            MsgBox(query)
                            txObservaciones.Text = query
                            frmMain._cmd.CommandText = query
                            frmMain._cmd.ExecuteNonQuery()

                            frmMain._cmd.CommandText = "select SEQ_" & frmMain.serie & "_IDVE_CREDITO.currval from dual"
                            s = frmMain._cmd.ExecuteReader()
                            Dim idce As Decimal
                            While s.Read
                                idce = s.GetDecimal(0)
                            End While
                            s.Close()

                            For Each f As DataGridViewRow In dgD.Rows
                                query = " INSERT INTO VE_CR_DETALLE(idlugar, idve_credito, idpr_marca, idpr_modelo, cantidad, subtotal)" &
                                                      "VALUES('" & frmMain.serie & "', '" & idce & "','" & f.Cells(0).Value & "','" & f.Cells(1).Value & "',  '1', '" & f.Cells(8).Value & "')"
                                frmMain._cmd.CommandText = query
                                frmMain._cmd.ExecuteNonQuery()

                                'query = "UPDATE  PR_INVENTARIO SET nueva=nueva-1 where idlugar = '" & frmMain.serie & "' and idpr_marca = '" & f.Cells(0).Value & "' and idpr_modelo = '" & f.Cells(1).Value & "'"
                                'frmMain._cmd.CommandText = query
                                'frmMain._cmd.ExecuteNonQuery()
                            Next

                            trans.Commit()
                            dgD.Rows.Clear()
                            txCDPI.Text = ""
                            lbTotal.Text = "0.0"
                            lbCuotas.Text = "0"
                            nPago.Value = "6"
                            lbUCuota.Text = "0"
                            lbNarticulo.Text = "0"
                            txDescuento.Value = "0"
                            txEnganche.Text = ""

                            txCDPI.Text = ""
                            txCNIT.Text = ""
                            txCNombre.Text = ""
                            txCDireccion.Text = ""
                            txCTel.Text = ""

                            txFDPI.Text = ""
                            txFNIT.Text = ""
                            txFnombre.Text = ""
                            txFDireccion.Text = ""
                            txFTel.Text = ""

                            _ESTADO("Contrato Enviado... ", frmMain.lbEstado)
                        Catch ex As Exception
                            trans.Rollback()
                            _ESTADO(ex.Message, frmMain.lbEstado)
                        Finally
                            frmMain._cnn.Close()
                        End Try
                    End If
                End If
            Else
                _ESTADO("Ingrese un numero de DPI...", frmMain.lbEstado)

            End If
        Else
            _ESTADO("No hay productos que adjuntar al contrato...", frmMain.lbEstado)
        End If


    End Sub

    


    Private Sub btCalcula_Click(sender As Object, e As EventArgs) Handles btCalcula.Click
        If txEnganche.Text = "" Then
            _ESTADO("Ingrese una cantidad para el pago inicial del contrato", frmMain.lbEstado)
        Else

            Dim query As String
            Dim cuota As Double = (nPago.Value - 1)
            Dim porciento, Pagos, ultimoPago As Double
            Dim total As Double = 0
            Dim factor As Double
            descuento = txDescuento.Value
            descuento = (descuento / 100)
            query = "SELECT PORCENTAJE, idcl_plan FROM CL_PLAN  WHERE IDPR_CATEGORIA = '1' AND IDCL_NIVEL = '" & cnivel & "' AND MES_MIN <= '" & cuota & "' AND MES_MAX >= '" & cuota & "'"

            Dim motriz As Boolean = False
            For Each f As DataGridViewRow In dgD.Rows           ' as
                If f.Cells(2).Value = 2 Then
                    motriz = True
                    query = "SELECT PORCENTAJE, idcl_plan FROM CL_PLAN  WHERE IDPR_CATEGORIA = '2' AND IDCL_NIVEL = '" & cnivel & "' AND MES_MIN <='" & cuota & "' AND MES_MAX >= '" & cuota & "'"
                End If
            Next
            Try
                frmMain._cnn.Open()
                frmMain._cmd = New OracleCommand(query, frmMain._cnn)
                Dim r As OracleDataReader = frmMain._cmd.ExecuteReader()

                While (r.Read)
                    porciento = r.GetDecimal(0)
                    idcl_plan = r.GetDecimal(1)
                End While
                r.Close()

            Catch ex As Exception
                _ESTADO(ex.Message, frmMain.lbEstado)
            Finally
                frmMain._cnn.Close()
            End Try
            For Each f As DataGridViewRow In dgD.Rows
                factor = CDbl((porciento / 100) + 1)
                f.Cells(8).Value = Val(f.Cells(7).Value) * factor
                total += Val(f.Cells(8).Value)
                '_ESTADO("Porfavor ingrese el numero de serie para el producto en lista de compra", frmMain.lbEstado)
            Next
            dgD.Refresh()
            descuento = total * descuento
            total = total - descuento
            lbTotal.Text = total
            Pagos = (total - CDbl(txEnganche.Text)) / cuota
            Pagos = Math.Round(Pagos)
            lbPorc.Text = porciento & " %"
            lbCuotas.Text = Pagos
            ultimoPago = (total - CDbl(txEnganche.Text)) - (Pagos * (cuota - 1))
            lbUCuota.Text = ultimoPago
        End If
    End Sub

    Private Sub nPago_ValueChanged(sender As Object, e As EventArgs) Handles nPago.ValueChanged
        If nPago.Value > 24 Then
            nPago.Value = 24
        ElseIf nPago.Value < 2 Then
            nPago.Value = 2

        End If
    End Sub

    Private Sub txEnganche_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txEnganche.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
        End If
    End Sub

   
End Class
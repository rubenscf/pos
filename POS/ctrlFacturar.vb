Imports Oracle.DataAccess.Client
Imports DevComponents.DotNetBar

Public Class ctrlFacturar

    Dim _Bs As BindingSource
    Dim dg As DataGridView
    Dim vmarca, vmodelo, vdetalle As String
    Dim ExisteNit As Boolean = False
    Dim cnivel As String
    Dim idcliente As Decimal

    Private Sub ctrlFacturar_Load(sender As Object, e As EventArgs) Handles Me.Load
        lbSerie.Text = frmMain.serie
       
    End Sub



    Private Sub txNit_LostFocus(sender As Object, e As EventArgs) Handles txNit.LostFocus
        txNit.Text = txNit.Text.ToUpper
        If (_NITvalido(txNit.Text)) Then
            verificaNIT()
            If ExisteNit Then

                Container.Panel2.Enabled = True
                If dgD.RowCount > 0 Then
                    btGuardar.Enabled = True
                End If


                'btCBuscar
                'btImprimir.Enabled = True
            Else

                Container.Panel2.Enabled = False
                btGuardar.Enabled = False
            End If
        Else
            txNit.Focus()
            txNit.SelectAll()
            _ESTADO("Error: Nit Inválido", frmMain.lbEstado)
        End If

    End Sub



    Sub verificaNIT()
        Dim query As String = "select nombre, direccion,cl_nivel, idcliente from cliente where nit ='" & CStr(txNit.Text.ToUpper) & "'"
        Try
            frmMain._cnn.Open()

            frmMain._cmd = New OracleCommand(query, frmMain._cnn)
            Dim r As OracleDataReader = frmMain._cmd.ExecuteReader()
            Dim f As Decimal = 0

            If r.HasRows Then
                ExisteNit = True
                btCGuardar.Enabled = False
                txNombre.Enabled = False
                txDireccion.Enabled = False
            Else
                txNombre.Enabled = True
                txDireccion.Enabled = True
                ExisteNit = False
                btCGuardar.Enabled = True
                _ESTADO("Haga click en el boton de agregar cliente para guardar información a la base de datos", frmMain.lbEstado)
            End If

            While r.Read
                cnivel = r.GetString(2)
                lbTipo.Text = r.GetString(2)
                txNombre.Text = r.GetString(0)
                txDireccion.Text = r.GetString(1)
                idcliente = r.GetDecimal(3)
            End While
            r.Close()
        Catch ex As Exception
            _ESTADO(ex.Message.ToString, frmMain.lbEstado)
        Finally
            frmMain._cnn.Close()
        End Try
    End Sub

    Private Sub txNit_TextChanged(sender As Object, e As EventArgs) Handles txNit.TextChanged

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

    Private Sub btCGuardar_Click(sender As Object, e As EventArgs) Handles btCGuardar.Click
        If txNit.Text = "" Or txDireccion.Text = "" Or txNombre.Text = "" Then

            _ESTADO("No pueden existir campos vacios en detalle de cliente", frmMain.lbEstado)
        Else
            Try
                frmMain._cnn.Open()
                Dim dbms As New DBMSOutput(frmMain._cnn)
                dbms.Enable()
                frmMain._cmd = New OracleCommand()
                frmMain._cmd.Connection = frmMain._cnn
                With frmMain._cmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "SP_NUEVO_FA_CLIENTE"
                    .Parameters.Add(New OracleParameter("v_nombre", OracleDbType.Varchar2)).Value = txNombre.Text
                    .Parameters.Add(New OracleParameter("v_nit", OracleDbType.Varchar2)).Value = txNit.Text
                    .Parameters.Add(New OracleParameter("v_direccino", OracleDbType.Varchar2)).Value = txDireccion.Text
                    .Parameters.Add(New OracleParameter("v_estado", OracleDbType.Int32, ParameterDirection.Output))
                End With
                frmMain._cmd.ExecuteNonQuery()

                If frmMain._cmd.Parameters("v_estado").Value > 0 Then

                    frmMain._cmd.CommandText = "select SEQ_GL_IDCLIENTE.currval from dual"
                    Dim s As OracleDataReader = frmMain._cmd.ExecuteReader()

                    While s.Read
                        idcliente = s.GetDecimal(0)
                    End While
                    s.Close()
                    MsgBox(idcliente)
                    dbms.Show(frmMain.lbEstado)
                    
                ElseIf frmMain._cmd.Parameters("v_estado").Value = 0 Then
                    dbms.Show(frmMain.lbEstado)
                    txNit.Focus()
                    txNit.SelectAll()
                Else
                    dbms.Show()
                End If
                btCGuardar.Enabled = False
                txNombre.Enabled = False
                txDireccion.Enabled = False
            Catch ex As Exception
                _ESTADO(ex.Message, frmMain.lbEstado)
            Finally
                frmMain._cnn.Close()
            End Try
        End If

    End Sub

   

    Public Sub txtSearch()


        If txMa.Text = "" Or txMo.Text = "" Then
            _ESTADO("Ingrese el codigo del producto", frmMain.lbEstado)
        Else
            Dim query As String = "SELECT MO.IDPR_MARCA, MO.IDPR_MODELO, MO.IDPR_MARCA || '-' || MO.IDPR_MODELO AS CODIGO, CA.NOMBRE AS CATEGORIA, MA.NOMBRE AS MARCA,  " &
                          "      MO.NOMBRE AS MODELO, MO.DETALLE AS DETALLE, INV.NUEVA AS NUEVOS, mo.preciov  " &
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
                        LbPrecioU.Text = r.GetDecimal(8)
                        txCantidad.Maximum = r.GetDecimal(7)
                    End While
                    lbSubtotal.Text = txCantidad.Value * Val(LbPrecioU.Text)
                    txCantidad.Enabled = True
                    r.Close()
                    btAgregarLista.Enabled = True
                Else
                    _ESTADO("No se encontro el producto revise el stok en tienda", frmMain.lbEstado)
                    txCantidad.Value = 1
                    btAgregarLista.Enabled = False
                    lbCodigo.Text = ""
                    lbMarca.Text = ""
                    lbModelo.Text = ""
                    lbStock.Text = ""
                    LbPrecioU.Text = ""
                    lbSubtotal.Text = ""
                    txMo.SelectAll()
                    txCantidad.Enabled = False
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

    Private Sub txCantidad_LostFocus1(sender As Object, e As EventArgs) Handles txCantidad.LostFocus
        If (Val(txCantidad.Text) > Val(lbStock.Text)) Then
            txCantidad.Value = lbStock.Text
            txCantidad.Focus()

        End If
    End Sub

    Private Sub txCantidad_ValueChanged(sender As Object, e As EventArgs) Handles txCantidad.ValueChanged
        lbSubtotal.Text = txCantidad.Value * Val(LbPrecioU.Text)
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

    Private Sub txEfectivo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txEfectivo.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." Then
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
                dgD.Rows.Add(vmarca, vmodelo, lbCodigo.Text, lbMarca.Text, lbModelo.Text, vdetalle, LbPrecioU.Text, txCantidad.Value, lbSubtotal.Text)
                btGuardar.Enabled = True
                txCantidad.Value = 1
                btAgregarLista.Enabled = False
                lbCodigo.Text = ""
                lbMarca.Text = ""
                lbModelo.Text = ""
                lbStock.Text = ""
                LbPrecioU.Text = ""
                txMo.SelectAll()
                txCantidad.Enabled = False
                txMa.Text = ""
                txMo.Text = ""
                lbSubtotal.Text = ""
                resumen()
            End If
        Catch ex As Exception
            _ESTADO(ex.Message, frmMain.lbEstado)
        End Try
    End Sub
    Sub resumen()
        Dim t As Double = 0
        Dim c As Integer = 0
        For Each row As DataGridViewRow In dgD.Rows
            t += CDbl(row.Cells(8).Value)
            c += CInt(row.Cells(7).Value)
        Next
        lbTotal.Text = t
        lbNarticulo.Text = c
    End Sub
    Private Sub btQuitarLista_Click(sender As Object, e As EventArgs) Handles btQuitarLista.Click
        If dgD.RowCount > 0 Then
            Dim resp As Integer
            resp = MsgBox("Esta seguro de quitar este producto de la lista? ", MsgBoxStyle.YesNo)
            If resp = vbYes Then
                dgD.Rows.Remove(dgD.CurrentRow)
                resumen()
                If dgD.RowCount < 1 Then
                    btGuardar.Enabled = False
                End If
            End If


        End If
    End Sub

    Private Sub txEfectivo_LostFocus(sender As Object, e As EventArgs) Handles txEfectivo.LostFocus
        Dim t As Double
        t = Val(txEfectivo.Text) - Val(lbTotal.Text)
        If t < 0 Then
            lbCambio.ForeColor = Color.Red
        Else
            lbCambio.ForeColor = Color.Green
        End If
        lbCambio.Text = t
    End Sub



    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        
            If txfactura.Text = "" Then
                _ESTADO("Ingrese un numero de documento valido...", frmMain.lbEstado)
                txfactura.Focus()
            Else
                Dim v As Boolean = True
                If dgD.Rows.Count > 0 Then

                    If Val(txEfectivo.Text) >= Val(lbTotal.Text) And txNit.Text <> "" Then

                        For Each f As DataGridViewRow In dgD.Rows
                            If f.Cells(9).Value = "" Then
                                _ESTADO("Porfavor ingrese el numero de serie para el producto en lista de compra", frmMain.lbEstado)
                                f.Selected = True
                                v = False
                                Exit For
                            End If
                        Next

                        If v = True Then

                        Dim resp As Integer
                        resp = MsgBox("Esta segur@ que desea guardar el registro de factura de esta venta? ", MsgBoxStyle.YesNo)
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

                                frmMain._cmd.CommandText = "INSERT INTO VE_FACTURA(idlugar, idfactura, idcliente, idempleado, fecha, total, estado ) VALUES('" &
                                    frmMain.serie & "','" & txfactura.Text & "','" & idcliente & "', '" & frmMain.idempleado & "', sysdate, '" & lbTotal.Text & "', 'FCA')"
                                frmMain._cmd.ExecuteNonQuery()

                                'frmMain._cmd.CommandText = "select SEQ_" & frmMain.serie & "_IDENVIO.currval from dual"
                                's = frmMain._cmd.ExecuteReader()

                                'While s.Read
                                '    iden = s.GetDecimal(0)
                                'End While
                                's.Close()

                                For Each f As DataGridViewRow In dgD.Rows
                                    query = " INSERT INTO VE_FA_DETALLE(idlugar, idfactura, idpr_marca, idpr_modelo, no_serie, cantidad, subtotal)" &
                                                          "VALUES('" & frmMain.serie & "', '" & txfactura.Text & "','" & f.Cells(0).Value & "','" & f.Cells(1).Value & "', '" & f.Cells(9).Value & "', '1', '" & f.Cells(8).Value & "')"
                                    frmMain._cmd.CommandText = query
                                    frmMain._cmd.ExecuteNonQuery()

                                    query = "UPDATE  PR_INVENTARIO SET nueva=nueva-1 where idlugar = '" & frmMain.serie & "' and idpr_marca = '" & f.Cells(0).Value & "' and idpr_modelo = '" & f.Cells(1).Value & "'"
                                    frmMain._cmd.CommandText = query
                                    frmMain._cmd.ExecuteNonQuery()


                                Next

                                trans.Commit()

                                dgD.Rows.Clear()
                                txNit.Text = "c/f"
                                lbTotal.Text = "0.0"
                                txfactura.Text = ""
                                lbNarticulo.Text = "0"
                                txEfectivo.Text = "0.0"
                                lbCambio.Text = "0.0"

                                _ESTADO("Transacion Guardada... ", frmMain.lbEstado)
                            Catch ex As Exception
                                trans.Rollback()
                                _ESTADO(ex.Message, frmMain.lbEstado)
                            Finally
                                frmMain._cnn.Close()
                            End Try
                        End If
                    End If
                Else
                    _ESTADO("El efectivo no puede ser menor que el valor total de la factura...", frmMain.lbEstado)
                    txEfectivo.Focus()
                    txEfectivo.SelectAll()
                End If
            Else
                _ESTADO("No hay productos que facturar...", frmMain.lbEstado)
            End If
            End If

    End Sub

    Private Sub txfactura_LostFocus(sender As Object, e As EventArgs) Handles txfactura.LostFocus
        Try
            frmMain._cnn.Open()
            Dim query As String = "select idfactura from ve_factura where idlugar = '" & frmMain.serie & "' and idfactura= '" & txfactura.Text & "'"
            frmMain._cmd = New OracleCommand(query, frmMain._cnn)
            Dim r As OracleDataReader = frmMain._cmd.ExecuteReader()

            If r.HasRows Then
                _ESTADO("Este numero de factura ya fue creado con anterioridad verifique su informacion.", frmMain.lbEstado)
                txfactura.Focus()
                txfactura.SelectAll()
            Else
                _ESTADO("Correcto", frmMain.lbEstado)
            End If
        Catch ex As Exception
            _ESTADO(ex.Message.ToString, frmMain.lbEstado)
        Finally
            frmMain._cnn.Close()
        End Try
    End Sub

   
End Class
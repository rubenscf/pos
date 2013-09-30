Imports Oracle.DataAccess.Client

Public Class ctrlEmpleados

    Private Sub ctrlEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _LLENAR_CMB("Select idlu_tipo as id, nombre from lu_tipo", cbArea)
        _LLENAR_CMB("select idempleado as id, nombre || ' ' || apellido || ' - ' || idlugar as nombre from empleado", cbEmpleado)
    End Sub

    Private Sub swBt_ValueChanged(sender As Object, e As EventArgs)
        'If swBt.Value = False Then
        '    cb_BuscaEmpleado.Visible = True
        '    imgBuscar.Visible = True
        'Else
        '    cb_BuscaEmpleado.Visible = False
        '    imgBuscar.Visible = False
        'End If
    End Sub
    Private Sub cbArea_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbArea.LostFocus
        _LLENAR_CMB("SELECT idlugar as id, nombre || '-' || direccion as nombre from lugar where idlu_tipo = " & cbArea.SelectedValue.ToString, cbLugar)
        _LLENAR_CMB("Select idlu_puesto as id, detalle as nombre from lu_puesto where idlu_tipo=" & cbArea.SelectedValue.ToString, cbPuesto)
    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        Dim pass As String
        pass = txPass.Text
        If txNombre.Text = "" Or txApellido.Text = "" Or txDPI.Text = "" Or txDireccion.Text = "" Or txUsuario.Text = "" Or txPass.Text = "" Then
            _ESTADO("No pueden existir campos vacios", frmMain.lbEstado)
        Else
            Try
                frmMain._cnn.Open()
                Dim dbms As New DBMSOutput(frmMain._cnn)
                If swBt.Value Then
                    dbms.Enable()
                    frmMain._cmd = New OracleCommand()
                    frmMain._cmd.Connection = frmMain._cnn
                    With frmMain._cmd
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "SP_NUEVO_EMPLEADO"
                        .Parameters.Add(New OracleParameter("v_idlugar", OracleDbType.Varchar2)).Value = CStr(cbLugar.SelectedValue)
                        .Parameters.Add(New OracleParameter("v_idlu_puesto", OracleDbType.Int32)).Value = CInt(cbPuesto.SelectedValue)
                        .Parameters.Add(New OracleParameter("v_dpi", OracleDbType.Varchar2)).Value = CStr(txDPI.Text)
                        .Parameters.Add(New OracleParameter("v_nombre", OracleDbType.Varchar2)).Value = CStr(txNombre.Text)
                        .Parameters.Add(New OracleParameter("v_apellido", OracleDbType.Varchar2)).Value = CStr(txApellido.Text)
                        .Parameters.Add(New OracleParameter("v_extendida", OracleDbType.Varchar2)).Value = CStr(txExtendido.Text)
                        .Parameters.Add(New OracleParameter("v_nit", OracleDbType.Varchar2)).Value = CStr(txNit.Text)
                        .Parameters.Add(New OracleParameter("v_sexo", OracleDbType.Varchar2)).Value = CStr(cbSexo.Text)
                        .Parameters.Add(New OracleParameter("v_direccion", OracleDbType.Varchar2)).Value = CStr(txDireccion.Text)
                        .Parameters.Add(New OracleParameter("v_telefono", OracleDbType.Varchar2)).Value = CStr(txTel.Text)
                        .Parameters.Add(New OracleParameter("v_conyuge", OracleDbType.Varchar2)).Value = CStr(txConyugue.Text)
                        .Parameters.Add(New OracleParameter("v_fechanac", OracleDbType.Date)).Value = CDate(txfechanac.Value)
                        .Parameters.Add(New OracleParameter("v_usuario", OracleDbType.Varchar2)).Value = CStr(txUsuario.Text)
                        .Parameters.Add(New OracleParameter("v_pass", OracleDbType.Varchar2)).Value = CStr(pass)
                        .Parameters.Add(New OracleParameter("v_sueldo_base", OracleDbType.Int32)).Value = CInt(txSueldo.Text)
                        .Parameters.Add(New OracleParameter("v_estado", OracleDbType.Int32, ParameterDirection.Output))
                    End With
                    frmMain._cmd.ExecuteNonQuery()

                    If frmMain._cmd.Parameters("v_estado").Value > 0 Then

                        dbms.Show(frmMain.lbEstado)
                        txNombre.Text = ""
                        txApellido.Text = ""
                        txDPI.Text = ""
                        txNit.Text = ""
                        txExtendido.Text = ""
                        txUsuario.Text = ""
                        txPass.Text = ""
                        txDireccion.Text = ""
                        txTel.Text = ""
                        cbSexo.SelectedIndex = 0
                        txConyugue.Text = ""
                    ElseIf frmMain._cmd.Parameters("v_estado").Value = 0 Then
                        dbms.Show(frmMain.lbEstado)
                        txDPI.Focus()
                    Else
                        dbms.Show()
                    End If
                ElseIf swBt.Value = False Then
                    'dbms.Enable()
                    'frmMain._cmd = New OracleCommand()
                    'frmMain._cmd.Connection = frmMain._cnn
                    'With frmMain._cmd
                    '    .CommandType = CommandType.StoredProcedure
                    '    .CommandText = "SP_EDITAR_ESTADO_LUGAR"
                    '    .Parameters.Add(New OracleParameter("v_idlugar", OracleDbType.Varchar2)).Value = CStr(txSerie.Text)
                    '    .Parameters.Add(New OracleParameter("v_nombre", OracleDbType.Varchar2)).Value = CStr(txNombre.Text)
                    '    .Parameters.Add(New OracleParameter("v_direccion", OracleDbType.Varchar2)).Value = CStr(txDireccion.Text)
                    '    .Parameters.Add(New OracleParameter("v_tel1", OracleDbType.Varchar2)).Value = CStr(txTel1.Text)
                    '    .Parameters.Add(New OracleParameter("v_tel2", OracleDbType.Varchar2)).Value = CStr(txTel2.Text)
                    '    .Parameters.Add(New OracleParameter("v_estado", OracleDbType.Int32, ParameterDirection.Output))
                    'End With
                    'frmMain._cmd.ExecuteNonQuery()

                    'If frmMain._cmd.Parameters("v_estado").Value > 0 Then

                    '    dbms.Show(frmMain.lbEstado)
                    '    dbms.Disable()
                    '    txSerie.Text = ""
                    '    txDireccion.Text = ""
                    '    txNombre.Text = ""
                    '    txTel1.Text = ""
                    '    txTel2.Text = ""

                    'Else
                    '    dbms.Show()
                End If


                _LLENAR_CMB("select idempleado as id, nombre || ' ' || apellido || ' - ' || idlugar as nombre from empleado", cbEmpleado)

            Catch ex As Exception
                _ESTADO(ex.Message, frmMain.lbEstado)
            Finally
                frmMain._cnn.Close()
            End Try
        End If

    End Sub

    Private Sub txNit_TextChanged(sender As Object, e As EventArgs) Handles txNit.LostFocus
        If txNit.Text = "" Then

        Else
            If _NITvalido(txNit.Text) = False Then
                txNit.Focus()
                txNit.SelectAll()
                _ESTADO("Nit Inválido", frmMain.lbEstado)
            End If
        End If
    End Sub
End Class

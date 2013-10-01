Imports Oracle.DataAccess.Client

Public Class ctrlEmpleados
    Private idempleado As Integer
    Dim query As String
    Dim valido As Boolean = False
    Private Sub ctrlEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            _LLENAR_CMB("Select idlu_tipo as id, nombre from lu_tipo", cbArea)

            _LLENAR_CMB("select id, detalle as nombre from estado where seccion = 'EMPLEADO'", cbEstado)
        Catch ex As Exception
            _ESTADO(ex.Message, frmMain.lbEstado)
        End Try
        
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
                If valido Then
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
                        .Parameters.Add(New OracleParameter("v_usuario", OracleDbType.Varchar2)).Value = CStr(txUsuario.Text.ToLower)
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
                Else
                    _ESTADO("Tiene datos no validos verifique la informacion", frmMain.lbEstado)
                    'dbms.Enable()
                    'frmMain._cmd = New OracleCommand()
                    'frmMain._cmd.Connection = frmMain._cnn
                    'With frmMain._cmd
                    '    .CommandType = CommandType.StoredProcedure
                    '    .CommandText = "SP_EDITAR_EMPLEADO"
                    '    .Parameters.Add(New OracleParameter("v_idempleado", OracleDbType.Varchar2)).Value = idempleado
                    '    .Parameters.Add(New OracleParameter("v_idlu_puesto", OracleDbType.Int32)).Value = CInt(cbPuesto.SelectedValue)
                    '    .Parameters.Add(New OracleParameter("v_idlugar", OracleDbType.Varchar2)).Value = CStr(cbLugar.SelectedValue)
                    '    .Parameters.Add(New OracleParameter("v_dpi", OracleDbType.Varchar2)).Value = CStr(txDPI.Text)
                    '    .Parameters.Add(New OracleParameter("v_nombre", OracleDbType.Varchar2)).Value = CStr(txNombre.Text)
                    '    .Parameters.Add(New OracleParameter("v_apellido", OracleDbType.Varchar2)).Value = CStr(txApellido.Text)
                    '    .Parameters.Add(New OracleParameter("v_extendida", OracleDbType.Varchar2)).Value = CStr(txExtendido.Text)
                    '    .Parameters.Add(New OracleParameter("v_nit", OracleDbType.Varchar2)).Value = CStr(txNit.Text)
                    '    .Parameters.Add(New OracleParameter("v_sexo", OracleDbType.Varchar2)).Value = CStr(cbSexo.Text)
                    '    .Parameters.Add(New OracleParameter("v_direccion", OracleDbType.Varchar2)).Value = CStr(txDireccion.Text)
                    '    .Parameters.Add(New OracleParameter("v_telefono", OracleDbType.Varchar2)).Value = CStr(txTel.Text)
                    '    .Parameters.Add(New OracleParameter("v_conyuge", OracleDbType.Varchar2)).Value = CStr(txConyugue.Text)
                    '    .Parameters.Add(New OracleParameter("v_fechanac", OracleDbType.Date)).Value = CDate(txfechanac.Value)
                    '    .Parameters.Add(New OracleParameter("v_sueldo_base", OracleDbType.Int32)).Value = CInt(txSueldo.Text)
                    '    .Parameters.Add(New OracleParameter("v_estado_e", OracleDbType.Varchar2)).Value = CStr(cbLugar.SelectedValue)
                    '    .Parameters.Add(New OracleParameter("v_estado", OracleDbType.Int32, ParameterDirection.Output))
                    'End With
                    'frmMain._cmd.ExecuteNonQuery()

                    'If frmMain._cmd.Parameters("v_estado").Value > 0 Then

                    '    dbms.Show(frmMain.lbEstado)
                    '    txNombre.Text = ""
                    '    txApellido.Text = ""
                    '    txDPI.Text = ""
                    '    txNit.Text = ""
                    '    txExtendido.Text = ""
                    '    txUsuario.Text = ""
                    '    txPass.Text = ""
                    '    txDireccion.Text = ""
                    '    txTel.Text = ""
                    '    cbSexo.SelectedIndex = 0
                    '    txConyugue.Text = ""
                    'Else
                    '    dbms.Show()
                    'End If


                    '_LLENAR_CMB("select idempleado as id, nombre || ' ' || apellido || ' - ' || idlugar as nombre from empleado", cbEmpleado)
                End If
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

   


    Private Sub txUsuario_TextChanged(sender As Object, e As EventArgs) Handles txUsuario.LostFocus
        MsgBox(txUsuario.Text.ToLower)
        query = "select count(idempleado) as id from empleado where usuario ='" & CStr(txUsuario.Text.ToLower) & "'"
        Try
            frmMain._cnn.Open()
            MsgBox(query)
            frmMain._cmd = New OracleCommand(query, frmMain._cnn)
            Dim r As OracleDataReader = frmMain._cmd.ExecuteReader()
            Dim f As Decimal = 0
            While r.Read
                f = r.GetDecimal(0)
            End While
            r.Close()
            If f > 0 Then
                txUsuario.Focus()
                txUsuario.SelectAll()
                _ESTADO("Este nombre de usuario se encuentra en uso...", frmMain.lbEstado)
            Else
                valido = True
                _ESTADO("Nombre de usuario disponible", frmMain.lbEstado)
            End If

        Catch ex As Exception
            _ESTADO(ex.Message.ToString, frmMain.lbEstado)
        Finally
            frmMain._cnn.Close()
        End Try

    End Sub

    'Private Sub cbEmpleado_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    Try
    '        frmMain._cnn.Open()
    '        If swBt.Value = False Then
    '            query = "SELECT idlugar, idlu_puesto, dpi, nombre, apellido, extendida, nit, sexo, direccion, telefono, conyugue, fechanac, estado, sueldo_base " &
    '                    "from EMPLEADO where idempleado = '" & cbEmpleado.SelectedValue.ToString & "'"
    '            frmMain._cmd = New OracleCommand(query, frmMain._cnn)
    '            Dim c As OracleDataReader = frmMain._cmd.ExecuteReader()
    '            While c.Read()
    '                'cbLugar.SelectedValue = CStr(c.GetString(0))
    '                'cbPuesto.SelectedValue = CStr(c.GetString(1))
    '                idempleado = cbEmpleado.SelectedValue
    '                txDPI.Text = CStr(c.GetString(2))
    '                txNombre.Text = CStr(c.GetString(3))
    '                txApellido.Text = CStr(c.GetString(4))
    '                txExtendido.Text = CStr(c.GetString(5))
    '                txNit.Text = CStr(c.GetString(6))
    '                cbSexo.SelectedValue = CStr(c.GetString(7))
    '                txDireccion.Text = CStr(c.GetString(8))
    '                txTel.Text = CStr(c.GetString(9))
    '                txConyugue.Text = CStr(c.GetString(10))
    '                txfechanac.Text = CStr(c.GetDateTime(11))
    '                cbEstado.SelectedValue = CStr(c.GetString(12))
    '                txSueldo.Text = CStr(c.GetString(13))
    '            End While
    '            c.Close()
    '        End If
    '    Catch ex As Exception
    '        _ESTADO(ex.Message, frmMain.lbEstado)
    '    Finally
    '        frmMain._cnn.Close()
    '    End Try
    'End Sub
End Class

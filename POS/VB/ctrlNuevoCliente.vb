Imports Oracle.DataAccess.Client

Public Class ctrlNuevoCliente
    Private idempleado As Integer
    Dim query As String
    Dim valido As Boolean = False
    Private Sub ctrlEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            _LLENAR_CMB("Select idcl_empresa as id, nombre from cl_empresa", cbEmpresa)
            cbSexo.SelectedIndex = 0
            '     _LLENAR_CMB("select id, detalle as nombre from estado where seccion = 'EMPLEADO'", cbEstado)
        Catch ex As Exception
            _ESTADO(ex.Message, frmMain.lbEstado)
        End Try

    End Sub

 

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        Dim empresa As String = cbEmpresa.SelectedValue
        If txNombre.Text = "" Or txApellido.Text = "" Or txDPI.Text = "" Or txDireccion.Text = "" Or txExtendido.Text = "" Or txTel.Text = "" Then
            _ESTADO("No pueden existir campos vacios", frmMain.lbEstado)
        Else
            Try
                frmMain._cnn.Open()
                Dim dbms As New DBMSOutput(frmMain._cnn)

                dbms.Enable()
                frmMain._cmd = New OracleCommand()
                frmMain._cmd.Connection = frmMain._cnn
                If empresa = "" Then
                    empresa = 0
                End If
                With frmMain._cmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "SP_NUEVO_CLIENTE"
                    .Parameters.Add(New OracleParameter("v_cl_nivel", OracleDbType.Varchar2)).Value = CStr("N")
                    .Parameters.Add(New OracleParameter("v_dpi", OracleDbType.Varchar2)).Value = CStr(txDPI.Text)
                    .Parameters.Add(New OracleParameter("v_cedula", OracleDbType.Varchar2)).Value = "INVALIDO"
                    .Parameters.Add(New OracleParameter("v_nombre", OracleDbType.Varchar2)).Value = CStr(txNombre.Text)
                    .Parameters.Add(New OracleParameter("v_apellido", OracleDbType.Varchar2)).Value = CStr(txApellido.Text)
                    .Parameters.Add(New OracleParameter("v_extendida", OracleDbType.Varchar2)).Value = CStr(txExtendido.Text)
                    .Parameters.Add(New OracleParameter("v_bienes", OracleDbType.Varchar2)).Value = CStr(txBienes.Text)
                    .Parameters.Add(New OracleParameter("v_nit", OracleDbType.Varchar2)).Value = CStr(txNit.Text.ToUpper)
                    .Parameters.Add(New OracleParameter("v_sexo", OracleDbType.Varchar2)).Value = CStr(cbSexo.Text)
                    .Parameters.Add(New OracleParameter("v_nacional", OracleDbType.Varchar2)).Value = CStr(txNacional.Text)
                    .Parameters.Add(New OracleParameter("v_direccion", OracleDbType.Varchar2)).Value = CStr(txDireccion.Text)
                    .Parameters.Add(New OracleParameter("v_telefono", OracleDbType.Varchar2)).Value = CStr(txTel.Text)
                    .Parameters.Add(New OracleParameter("v_telefono1", OracleDbType.Varchar2)).Value = CStr(txTel1.Text)
                    .Parameters.Add(New OracleParameter("v_telefono2", OracleDbType.Varchar2)).Value = CStr(txTel2.Text)
                    .Parameters.Add(New OracleParameter("v_conyuge", OracleDbType.Varchar2)).Value = CStr(txConyugue.Text)
                    .Parameters.Add(New OracleParameter("v_fechanac", OracleDbType.Date)).Value = CDate(txfechanac.Value)
                    .Parameters.Add(New OracleParameter("v_ingreso", OracleDbType.Varchar2)).Value = CStr(txIngreso.Text)
                    .Parameters.Add(New OracleParameter("v_pueso", OracleDbType.Varchar2)).Value = CStr(txPuesto.Text)
                    .Parameters.Add(New OracleParameter("v_idcl_empresa", OracleDbType.Int32)).Value = CStr(empresa)
                    .Parameters.Add(New OracleParameter("v_e_nombre", OracleDbType.Varchar2)).Value = CStr(cbEmpresa.Text)
                    .Parameters.Add(New OracleParameter("v_e_direccion", OracleDbType.Varchar2)).Value = CStr(txEDire.Text)
                    .Parameters.Add(New OracleParameter("v_e_tel", OracleDbType.Varchar2)).Value = CStr(txETel.Text)
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
                        txDireccion.Text = ""
                    txTel.Text = ""
                    cbSexo.SelectedIndex = 0
                    txConyugue.Text = ""
                    txNacional.Text = "Guatemalteco"
                    txBienes.Text = ""
                    _LLENAR_CMB("Select idcl_empresa as id, nombre from cl_empresa", cbEmpresa)
                    txETel.Text = ""
                    txEDire.Text = ""
                    txIngreso.Text = ""
                    txPuesto.Text = ""
                    txTel1.Text = ""
                    txTel2.Text = ""
                ElseIf frmMain._cmd.Parameters("v_estado").Value = 0 Then
                    dbms.Show(frmMain.lbEstado)
                    txDPI.Focus()
                Else
                    dbms.Show()
                End If
               
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
    Private Sub txETel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txETel.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
            ' ElseIf e.KeyChar = "," Then
            '   e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txIngreso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txIngreso.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "," Then
            e.Handled = False
        Else
            e.Handled = True
        End If
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

    Private Sub cbEmpresa_LostFocus(sender As Object, e As EventArgs) Handles cbEmpresa.LostFocus
        Dim v As String = cbEmpresa.SelectedValue
        If v <> "" Then
            Try
                frmMain._cnn.Open()
                Dim query As String


                query = "Select direccion, telefono from cl_empresa where idcl_empresa = '" & cbEmpresa.SelectedValue & "'"
                frmMain._cmd = New OracleCommand(query, frmMain._cnn)
                Dim c As OracleDataReader = frmMain._cmd.ExecuteReader()
                While c.Read()
                    txEDire.Text = c.GetString(0)
                    txETel.Text = c.GetString(1)
                End While
                c.Close()

            Catch ex As Exception
                _ESTADO(ex.Message, frmMain.lbEstado)
            Finally
                frmMain._cnn.Close()
            End Try

        End If

    End Sub

    Private Sub txfechanac_Click(sender As Object, e As EventArgs) Handles txfechanac.Click

    End Sub

    Private Sub txIngreso_TextChanged(sender As Object, e As EventArgs) Handles txIngreso.TextChanged

    End Sub
End Class

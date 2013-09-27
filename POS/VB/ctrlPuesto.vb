Imports Oracle.DataAccess.Client

Public Class ctrlPuesto

    Private Sub ctrlPuesto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            frmMain._cnn.Open()
            Dim query As String = "Select idlu_tipo as id, nombre from lu_tipo"
            _LLENAR_CMB(query, cbTipo)
        Catch ex As Exception
            _ESTADO(ex.Message, frmMain.lbEstado)
        Finally
            frmMain._cnn.Close()
        End Try
    End Sub
    Private Sub bt_guarda_Click(sender As Object, e As EventArgs) Handles bt_guarda.Click
        Try
            frmMain._cnn.Open()
            Dim dbms As New DBMSOutput(frmMain._cnn)
            If txNombre.Text = "" Then
                _ESTADO("No Pueden existir Campos Vacios", frmMain.lbEstado)
            Else
                dbms.Enable()
                frmMain._cmd = New OracleCommand()
                frmMain._cmd.Connection = frmMain._cnn
                With frmMain._cmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "SP_NUEVO_LU_PUESTO"
                    .Parameters.Add(New OracleParameter("v_idlugar", OracleDbType.Int32)).Value = CStr(cbTipo.SelectedValue)
                    .Parameters.Add(New OracleParameter("v_nombre", OracleDbType.Varchar2)).Value = CStr(txNombre.Text)
                    .Parameters.Add(New OracleParameter("v_estado", OracleDbType.Int32, ParameterDirection.Output))
                End With
                frmMain._cmd.ExecuteNonQuery()

                If frmMain._cmd.Parameters("v_estado").Value > 0 Then

                    dbms.Show(frmMain.lbEstado)
                    dbms.Disable()
                    txNombre.Text = ""
                ElseIf frmMain._cmd.Parameters("v_estado").Value = 0 Then
                    dbms.Show(frmMain.lbEstado)
                    txNombre.Focus()
                Else
                    dbms.Show()
                    Dim query As String = "Select idlu_puesto as CODIGO, detalle as NOMBRE_DE_PUESTO from lu_puesto where idlu_tipo = " & cbTipo.SelectedValue.ToString
                    _SET_DG("tipos", query, dg)
                End If
            End If
        Catch ex As Exception
            _ESTADO(ex.Message, frmMain.lbEstado)
        Finally
            frmMain._cnn.Close()
        End Try
    End Sub

    Private Sub cbTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTipo.LostFocus
        Try
            frmMain._cnn.Open()
            Dim query As String = "Select idlu_puesto as CODIGO, detalle as NOMBRE_DE_PUESTO from lu_puesto where idlu_tipo = " & cbTipo.SelectedValue.ToString
            _SET_DG("tipos", query, dg)
        Catch ex As Exception
            _ESTADO(ex.Message, frmMain.lbEstado)
        Finally
            frmMain._cnn.Close()
        End Try

    End Sub
End Class

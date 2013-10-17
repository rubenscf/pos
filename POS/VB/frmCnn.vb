Imports Oracle.DataAccess.Client



Public Class frmCnn

    Private Sub bt_probar_Click(sender As Object, e As EventArgs) Handles bt_probar.Click
        Dim cadena As String = "DATA SOURCE=" + txIp.Text + ":" + txPuerto.Text + "/" + txSID.Text + "; PERSIST SECURITY INFO=True;USER ID=" + txUsuario.Text + ";PASSWORD=" + txPass.Text + ";"
        ' MsgBox(cadena)
        Dim conexion As New OracleConnection(cadena)
        Try

            conexion.Open()
            lbEstado.Text = "Conexion Establecida"

        Catch ex As Exception
            lbEstado.Text = ex.Message
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub bt_guardar_Click(sender As Object, e As EventArgs) Handles bt_guardar.Click
        Try
            ' frmMain._strcnn = "DATA SOURCE=" + txIp.Text + ":" + txPuerto.Text + "/" + txSID.Text + "; PERSIST SECURITY INFO=True;USER ID=" + txUsuario.Text + ";PASSWORD=" + txPass.Text + ";"
            ' frmMain._cnn = New OracleConnection(frmMain._strcnn)
            ' frmMain._cnn.Open()
            ' lbEstado.Text = "Conexion Guardada"
        Catch ex As Exception
            ' lbEstado.Text = ex.Message
        Finally
            'frmMain._cnn.Close()
        End Try





    End Sub

   
End Class
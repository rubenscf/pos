Imports Oracle.DataAccess.Client

Public Class ctrlDeposito

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        If txfecha.Text = "" Or txBanco.Text = "" Or txboleta.Text = "" Or txCantidad.Text = "" Then
            _ESTADO("No pueden existir campos vacios", frmMain.lbEstado)
        Else
            Try
                frmMain._cnn.Open()
                Dim dbms As New DBMSOutput(frmMain._cnn)

                dbms.Enable()
                frmMain._cmd = New OracleCommand()
                frmMain._cmd.Connection = frmMain._cnn
                With frmMain._cmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "SP_NUEVO_LU_DEPOSITO"
                    .Parameters.Add(New OracleParameter("v_idlugar", OracleDbType.Varchar2)).Value = frmMain.serie
                    .Parameters.Add(New OracleParameter("v_boleta", OracleDbType.Varchar2)).Value = CStr(txboleta.Text)
                    .Parameters.Add(New OracleParameter("v_total", OracleDbType.Varchar2)).Value = CStr(txCantidad.Text)
                    .Parameters.Add(New OracleParameter("v_banco", OracleDbType.Varchar2)).Value = CStr(txBanco.Text)
                    .Parameters.Add(New OracleParameter("v_fecha", OracleDbType.Date)).Value = txfecha.Value
                    .Parameters.Add(New OracleParameter("v_estado", OracleDbType.Int32, ParameterDirection.Output))
                End With
                frmMain._cmd.ExecuteNonQuery()

                If frmMain._cmd.Parameters("v_estado").Value > 0 Then

                    dbms.Show(frmMain.lbEstado)
                    txboleta.Text = ""
                    txBanco.Text = ""
                    txCantidad.Text = ""
                ElseIf frmMain._cmd.Parameters("v_estado").Value = 0 Then
                    dbms.Show(frmMain.lbEstado)
                Else
                    dbms.Show()
                End If


            Catch ex As Exception
                _ESTADO(ex.Message, frmMain.lbEstado)
            Finally
                frmMain._cnn.Close()
            End Try
        End If
    End Sub

    Private Sub txCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txCantidad.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class

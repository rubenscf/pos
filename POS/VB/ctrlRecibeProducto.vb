Imports Oracle.DataAccess.Client

Public Class ctrlRecibeProducto
    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        Try
            Me.RecepcionProductoTableAdapter.Fill(Me._DS.RecepcionProducto, txSerie.Text, CType(txCorrelativo.Text, Decimal), frmMain.serie)
            If (SERIELabel2.Text = "") Then
                _ESTADO("Sin resultados, verifique los parametros de búsqueda... ", frmMain.lbEstado)
            End If
        Catch ex As System.Exception
            _ESTADO(ex.Message, frmMain.lbEstado)
        End Try
    End Sub


    Private Sub btAceptar_Click(sender As Object, e As EventArgs) Handles btAceptar.Click
        Try

            frmMain._cnn.Open()
            If txSerie.Text = "" Or txCorrelativo.Text = "" Then
                _ESTADO("INGRESE PARAMETROS DE BUSQUEDA", frmMain.lbEstado)
            Else
                Dim dbms As New DBMSOutput(frmMain._cnn)
                dbms.Enable()
                frmMain._cmd = New OracleCommand()
                frmMain._cmd.Connection = frmMain._cnn
                With frmMain._cmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "SP_RECIBE_ENVIO"
                    .Parameters.Add(New OracleParameter("v_sale", OracleDbType.Varchar2)).Value = txSerie.Text
                    .Parameters.Add(New OracleParameter("v_idenvio", OracleDbType.Int32)).Value = txCorrelativo.Text
                    .Parameters.Add(New OracleParameter("v_estado", OracleDbType.Int32, ParameterDirection.Output))
                End With
                frmMain._cmd.ExecuteNonQuery()
                If frmMain._cmd.Parameters("v_estado").Value > 0 Then
                    dbms.Show(frmMain.lbEstado)
                    dbms.Disable()
                ElseIf frmMain._cmd.Parameters("v_estado").Value = 0 Then
                    dbms.Show()
                Else
                    dbms.Show()
                End If
                Dim a As Object
                Me.btBuscar_Click(a, EventArgs.Empty)
                txCorrelativo.Text = ""
                txSerie.Text = ""
            End If
        Catch ex As Exception
            _ESTADO(ex.Message, frmMain.lbEstado)
        Finally
            frmMain._cnn.Close()
        End Try
    End Sub
End Class

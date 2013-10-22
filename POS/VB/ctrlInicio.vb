Public Class ctrlInicio

    Private Sub MetroTileItem4_Click(sender As Object, e As EventArgs)
        
    End Sub

    Private Sub ctrlInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txNombre.Text = frmMain.nombre
        txPuesto.Text = frmMain.puesto
        txLugar.Text = frmMain.tipolugar & " " & frmMain.lugar
    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        frmMain.cerrarSesion()
        Me.Dispose()
    End Sub
End Class

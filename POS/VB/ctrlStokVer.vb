Imports Oracle.DataAccess.Client

Public Class ctrlStokVer

    Dim query As String
    Dim marca As String
    Dim modelo As String
    Private Sub ctrlStokAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ReflectionLabel2.Text = "<font size='+6'>Stock <font color='#32b8ff'> " & frmMain.lugar & "</font></font>"
            frmMain._cnn.Open()
            frmMain._Bs = New BindingSource
            setBSInventario(frmMain._Bs, dgP, cbF)
        Catch ex As Exception
            _ESTADO(ex.Message, frmMain.lbEstado)
        Finally
            frmMain._cnn.Close()
        End Try
    End Sub


    Private Sub txB_TextChanged(sender As Object, e As EventArgs) Handles txB.TextChanged
        Try
            Dim ret As Integer = Filtrar_tabla(cbF.Text, txB.Text.Trim, frmMain._Bs, dgP)
            If ret = 0 Then
                txB.BackColor = Color.Red
            Else
                txB.BackColor = Color.White
            End If
        Catch ex As Exception
            _ESTADO(ex.Message, frmMain.lbEstado)
        End Try

    End Sub
  



End Class

Imports Oracle.DataAccess.Client

Public Class ctrlPRModelo
    Dim editar As Boolean = False

 

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        Try
            frmMain._cnn.Open()
            Dim dbms As New DBMSOutput(frmMain._cnn)
            If txNombre.Text = "" Or txDetalle.Text = "" Or txCompra.Text = "" Or txVenta.Text = "" Or cbTCategoria.SelectedValue <> "0" Then
                _ESTADO("No Pueden existir Campos Vacios", frmMain.lbEstado)
            ElseIf swBt.Value = True Then
                dbms.Enable()
                frmMain._cmd = New OracleCommand()
                frmMain._cmd.Connection = frmMain._cnn
                With frmMain._cmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "SP_NUEVO_PR_MODELO"
                    .Parameters.Add(New OracleParameter("v_idpr_marca", OracleDbType.Varchar2)).Value = CStr(cbMarca.SelectedText)
                    .Parameters.Add(New OracleParameter("v_nombre", OracleDbType.Varchar2)).Value = CStr(txNombre.Text)
                    .Parameters.Add(New OracleParameter("v_detalle", OracleDbType.Varchar2)).Value = CStr(txDetalle.Text)
                    .Parameters.Add(New OracleParameter("v_idpr_categoria", OracleDbType.Varchar2)).Value = CStr(cbCategoria.SelectedValue)
                    .Parameters.Add(New OracleParameter("v_idpr_tipo", OracleDbType.Varchar2)).Value = CStr(cbTCategoria.SelectedValue)
                    .Parameters.Add(New OracleParameter("v_precioc", OracleDbType.Varchar2)).Value = CStr(txCompra.Text)
                    .Parameters.Add(New OracleParameter("v_preciov", OracleDbType.Varchar2)).Value = CStr(txVenta.Text)
                    .Parameters.Add(New OracleParameter("v_estado", OracleDbType.Int32, ParameterDirection.Output))
                End With
                frmMain._cmd.ExecuteNonQuery()
                If frmMain._cmd.Parameters("v_estado").Value > 0 Then
                    dbms.Show(frmMain.lbEstado)
                    txNombre.Text = ""
                    txCompra.Text = ""
                    txDetalle.Text = ""
                    txVenta.Text = ""

                ElseIf frmMain._cmd.Parameters("v_estado").Value = 0 Then
                    dbms.Show(frmMain.lbEstado)
                    txNombre.Focus()
                    txNombre.SelectAll()
                Else
                    dbms.Show()
                End If
            ElseIf swBt.Value = False Then
                dbms.Enable()
                frmMain._cmd = New OracleCommand()
                frmMain._cmd.Connection = frmMain._cnn
                With frmMain._cmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "SP_EDITAR_ESTADO_MODELO"
                    .Parameters.Add(New OracleParameter("v_idpr_marca", OracleDbType.Varchar2)).Value = CStr(cbMarca.SelectedText)
                    .Parameters.Add(New OracleParameter("v_nombre", OracleDbType.Varchar2)).Value = CStr(txNombre.Text)
                    .Parameters.Add(New OracleParameter("v_detalle", OracleDbType.Varchar2)).Value = CStr(txDetalle.Text)
                    .Parameters.Add(New OracleParameter("v_idpr_categoria", OracleDbType.Varchar2)).Value = CStr(cbCategoria.SelectedValue)
                    .Parameters.Add(New OracleParameter("v_idpr_tipo", OracleDbType.Varchar2)).Value = CStr(cbTCategoria.SelectedValue)
                    .Parameters.Add(New OracleParameter("v_precioc", OracleDbType.Varchar2)).Value = CStr(txCompra.Text)
                    .Parameters.Add(New OracleParameter("v_preciov", OracleDbType.Varchar2)).Value = CStr(txVenta.Text)
                    .Parameters.Add(New OracleParameter("v_estado1", OracleDbType.Varchar2)).Value = CStr("MAC")
                    .Parameters.Add(New OracleParameter("v_estado", OracleDbType.Int32, ParameterDirection.Output))
                End With
                frmMain._cmd.ExecuteNonQuery()

                If frmMain._cmd.Parameters("v_estado").Value > 0 Then

                    dbms.Show(frmMain.lbEstado)

                    txNombre.Text = ""
                    txCompra.Text = ""
                    txDetalle.Text = ""
                    txVenta.Text = ""


                Else
                    dbms.Show()
                End If
            End If
         
        Catch ex As Exception
            _ESTADO(ex.Message, frmMain.lbEstado)
        Finally
            frmMain._cnn.Close()
        End Try
    End Sub

    Private Sub ctrlPRModelo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _LLENAR_CMB("select idmarca as id, nombre from pr_marca", cbMarca)
        _LLENAR_CMB("select idpr_categoria as id, nombre from pr_categoria", cbCategoria)
    End Sub



    Private Sub swBt_ValueChanged(sender As Object, e As EventArgs) Handles swBt.ValueChanged
        If swBt.Value = False Then
            cbModelo.Visible = True
            lbbM.Visible = True
        Else
            cbModelo.Visible = False
            lbbM.Visible = False
        End If
    End Sub

    Private Sub cbMarca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMarca.LostFocus
        _LLENAR_CMB("select idpr_modelo as id, nombre from pr_modelo where idpr_marca = " & cbMarca.SelectedValue.ToString, cbModelo)
    End Sub

    Private Sub cbCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCategoria.LostFocus
        _LLENAR_CMB("select idpr_tipo as id, nombre from pr_tipo where idpr_categoria = " & cbCategoria.SelectedValue.ToString, cbTCategoria)

    End Sub
End Class

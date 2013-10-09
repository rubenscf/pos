Imports Oracle.DataAccess.Client

Public Class ctrlPRModelo
    Dim editar As Boolean = False
    


    Private Sub ctrlPRModelo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        _LLENAR_CMB("select idpr_categoria as id, nombre from pr_categoria", cbCategoria)
    End Sub



    Private Sub swBt_ValueChanged(sender As Object, e As EventArgs) Handles swBt.ValueChanged
        If swBt.Value = False Then
            cbModelo.Visible = True
            lbbM.Visible = True
            cbTCategoria.Enabled = False
            cbMarca.Enabled = False
            cbModelo.Enabled = False
        Else
            cbTCategoria.Enabled = True
            cbMarca.Enabled = True
            cbModelo.Visible = False
            lbbM.Visible = False
        End If
    End Sub

  

    Private Sub btGuarda_Click(sender As Object, e As EventArgs) Handles btGuarda.Click
        Try
            frmMain._cnn.Open()
            Dim dbms As New DBMSOutput(frmMain._cnn)
            If txNombre.Text = "" Or txDetalle.Text = "" Or txCompra.Text = "" Or txVenta.Text = "" Then
                _ESTADO("No Pueden existir Campos Vacios", frmMain.lbEstado)
            ElseIf swBt.Value = True Then
                dbms.Enable()
                frmMain._cmd = New OracleCommand()
                frmMain._cmd.Connection = frmMain._cnn
                With frmMain._cmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "SP_NUEVO_PR_MODELO"
                    .Parameters.Add(New OracleParameter("v_idpr_marca", OracleDbType.Int32)).Value = CStr(cbMarca.SelectedValue)
                    .Parameters.Add(New OracleParameter("v_nombre", OracleDbType.Varchar2)).Value = CStr(txNombre.Text)
                    .Parameters.Add(New OracleParameter("v_detalle", OracleDbType.Varchar2)).Value = CStr(txDetalle.Text)
                    .Parameters.Add(New OracleParameter("v_idpr_categoria", OracleDbType.Int32)).Value = CStr(cbCategoria.SelectedValue)
                    .Parameters.Add(New OracleParameter("v_idpr_tipo", OracleDbType.Int32)).Value = CStr(cbTCategoria.SelectedValue)
                    .Parameters.Add(New OracleParameter("v_precioc", OracleDbType.BinaryFloat)).Value = CStr(txCompra.Text)
                    .Parameters.Add(New OracleParameter("v_preciov", OracleDbType.BinaryFloat)).Value = CStr(txVenta.Text)
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
                MsgBox(cbCategoria.SelectedValue)
                MsgBox(cbTCategoria.SelectedValue)
                MsgBox(cbMarca.SelectedValue)
                MsgBox(cbModelo.SelectedValue)
                MsgBox(txCompra.Text)
                MsgBox(txVenta.Text)
                frmMain._cmd = New OracleCommand()
                frmMain._cmd.Connection = frmMain._cnn
                With frmMain._cmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "SP_EDITAR_ESTADO_MODELO"
                    .Parameters.Add(New OracleParameter("v_idpr_marca", OracleDbType.Int32)).Value = CStr(cbMarca.SelectedValue)
                    .Parameters.Add(New OracleParameter("v_idpr_modelo", OracleDbType.Int32)).Value = CStr(cbModelo.SelectedValue)
                    .Parameters.Add(New OracleParameter("v_idpr_tipo", OracleDbType.Int32)).Value = CStr(cbTCategoria.SelectedValue)
                    .Parameters.Add(New OracleParameter("v_nombre", OracleDbType.Varchar2)).Value = CStr(txNombre.Text)
                    .Parameters.Add(New OracleParameter("v_detalle", OracleDbType.Varchar2)).Value = CStr(txDetalle.Text)
                    .Parameters.Add(New OracleParameter("v_precioc", OracleDbType.Double)).Value = CStr(txCompra.Text)
                    .Parameters.Add(New OracleParameter("v_preciov", OracleDbType.Double)).Value = CStr(txVenta.Text)
                    .Parameters.Add(New OracleParameter("v_estado1", OracleDbType.Varchar2)).Value = "MAC"
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

    Private Sub cbModelo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbModelo.LostFocus
        Try
            frmMain._cnn.Open()
            Dim query As String
            query = "Select nombre, detalle, precioc, preciov from pr_modelo where idpr_marca = '" & cbMarca.SelectedValue.ToString & "' and idpr_modelo = '" & cbModelo.SelectedValue & "' and idpr_tipo = '" & cbTCategoria.SelectedValue & "' and idpr_categoria = '" & cbCategoria.SelectedValue & "'"
            frmMain._cmd = New OracleCommand(query, frmMain._cnn)
            Dim c As OracleDataReader = frmMain._cmd.ExecuteReader()
            While c.Read()
                txNombre.Text = c.GetString(0)
                txDetalle.Text = c.GetString(1)
                txCompra.Text = c.GetDecimal(2)
                txVenta.Text = c.GetDecimal(3)
            End While
            c.Close()
        Catch ex As Exception
            _ESTADO(ex.Message, frmMain.lbEstado)
        Finally
            frmMain._cnn.Close()
        End Try
        
    End Sub

    Private Sub cbCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCategoria.LostFocus
        _LLENAR_CMB("select idpr_tipo as id, nombre from pr_tipo where idpr_categoria = '" & cbCategoria.SelectedValue.ToString & "'", cbTCategoria)
        If swBt.Value = False Then
            cbTCategoria.Enabled = True
        End If
    End Sub
    Private Sub cbTCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTCategoria.LostFocus
        If swBt.Value = False Then
            cbMarca.Text = ""
            Dim QUERY As String = "SELECT ma.IDMARCA as id, ma.NOMBRE as nombre FROM AGENCIA.PR_MARCA ma INNER JOIN AGENCIA.PR_MODELO mo ON ma.IDMARCA = mo.IDPR_MARCA INNER JOIN AGENCIA.PR_TIPO ti ON ti.IDPR_CATEGORIA = mo.IDPR_CATEGORIA AND ti.IDPR_TIPO = mo.IDPR_TIPO WHERE ti.IDPR_CATEGORIA = '" & cbCategoria.SelectedValue.ToString & "' AND ti.IDPR_TIPO = '" & cbTCategoria.SelectedValue.ToString & "'"
            _LLENAR_CMB(QUERY, cbMarca)
            cbMarca.Enabled = True
            If cbMarca.Text = "" Then
                cbMarca.Enabled = False
                cbModelo.Text = ""
                cbModelo.Enabled = False
            End If
        Else
            _LLENAR_CMB("select idmarca as id, nombre from pr_marca", cbMarca)
        End If
    End Sub
    Private Sub cbMarca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMarca.LostFocus
        If swBt.Value = False And cbMarca.Text <> "" Then
            cbModelo.Text = ""
            _LLENAR_CMB("select idpr_modelo as id, nombre from pr_modelo where idpr_marca = '" & cbMarca.SelectedValue.ToString & "' and idpr_tipo = '" & cbTCategoria.SelectedValue & "' and idpr_categoria = '" & cbCategoria.SelectedValue & "'", cbModelo)
            cbModelo.Enabled = True
        ElseIf cbMarca.Text = "" Then
            cbModelo.Text = ""
            cbMarca.Enabled = False
            cbModelo.Enabled = False
        End If
    End Sub

    Private Sub txCompra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txCompra.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "," Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txVenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txVenta.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "," Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    
   
End Class

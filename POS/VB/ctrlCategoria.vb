Imports Oracle.DataAccess.Client

Public Class ctrlCategoria
    Dim idT, idC As String
    Dim ec As Boolean = False
    Dim et As Boolean = False
    Private Sub ctrlCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial()
    End Sub
    Sub inicial()
        _LLENAR_CMB("SELECT idpr_categoria as id, nombre from pr_categoria", cbCategoria)
        _SET_DG("CCategorias", "select idpr_categoria as CODIGO, NOMBRE from pr_categoria", dgC)
    End Sub
    Sub gCategoria()
        Try
            frmMain._cnn.Open()
            Dim dbms As New DBMSOutput(frmMain._cnn)
            dbms.Enable()
            frmMain._cmd = New OracleCommand()
            frmMain._cmd.Connection = frmMain._cnn
            With frmMain._cmd
                .CommandType = CommandType.StoredProcedure
                .CommandText = "SP_NUEVO_PR_CATEGORIA"
                .Parameters.Add(New OracleParameter("v_nombre", OracleDbType.Varchar2)).Value = CStr(txCategoria.Text)
                .Parameters.Add(New OracleParameter("v_estado", OracleDbType.Int32, ParameterDirection.Output))
            End With
            frmMain._cmd.ExecuteNonQuery()
            If frmMain._cmd.Parameters("v_estado").Value > 0 Then
                dbms.Show(frmMain.lbEstado)
                dbms.Disable()
                txCategoria.Text = ""
                idC = ""
            ElseIf frmMain._cmd.Parameters("v_estado").Value = 0 Then
                dbms.Show(frmMain.lbEstado)
                txCategoria.Focus()
                txCategoria.SelectAll()
            Else
                dbms.Show()
            End If
        Catch ex As Exception
            _ESTADO(ex.Message, frmMain.lbEstado)
        Finally
            frmMain._cnn.Close()
        End Try
        inicial()
    End Sub
    Sub gTipo()
        Try
            frmMain._cnn.Open()
            Dim dbms As New DBMSOutput(frmMain._cnn)
            dbms.Enable()
            frmMain._cmd = New OracleCommand()
            frmMain._cmd.Connection = frmMain._cnn
            With frmMain._cmd
                .CommandType = CommandType.StoredProcedure
                .CommandText = "SP_NUEVO_PR_TIPO"
                .Parameters.Add(New OracleParameter("v_idpr_categoria", OracleDbType.Varchar2)).Value = CStr(cbCategoria.SelectedValue.ToString)
                .Parameters.Add(New OracleParameter("v_nombre", OracleDbType.Varchar2)).Value = CStr(txTipo.Text)
                .Parameters.Add(New OracleParameter("v_estado", OracleDbType.Int32, ParameterDirection.Output))
            End With
            frmMain._cmd.ExecuteNonQuery()
            If frmMain._cmd.Parameters("v_estado").Value > 0 Then
                dbms.Show(frmMain.lbEstado)
                dbms.Disable()
                txTipo.Text = ""
                idT = ""
            ElseIf frmMain._cmd.Parameters("v_estado").Value = 0 Then
                dbms.Show(frmMain.lbEstado)
                txTipo.Focus()
                txTipo.SelectAll()
            Else
                dbms.Show()
            End If
        Catch ex As Exception
            _ESTADO(ex.Message, frmMain.lbEstado)
        Finally
            frmMain._cnn.Close()
        End Try
        inicial()
    End Sub
    Sub eTipo()

        Try
            frmMain._cnn.Open()
            Dim dbms As New DBMSOutput(frmMain._cnn)
            dbms.Enable()
            frmMain._cmd = New OracleCommand()
            frmMain._cmd.Connection = frmMain._cnn
            With frmMain._cmd
                .CommandType = CommandType.StoredProcedure
                .CommandText = "SP_EDITAR_ESTADO_TIPO_PRODUCTO"
                .Parameters.Add(New OracleParameter("v_idpr_categoria", OracleDbType.Varchar2)).Value = CStr(cbCategoria.SelectedValue.ToString)
                .Parameters.Add(New OracleParameter("v_idpr_tipo", OracleDbType.Varchar2)).Value = idT
                .Parameters.Add(New OracleParameter("v_nombre", OracleDbType.Varchar2)).Value = CStr(txTipo.Text)
                .Parameters.Add(New OracleParameter("v_estado", OracleDbType.Int32, ParameterDirection.Output))
            End With
            frmMain._cmd.ExecuteNonQuery()
            If frmMain._cmd.Parameters("v_estado").Value > 0 Then
                dbms.Show(frmMain.lbEstado)
                dbms.Disable()
                txTipo.Text = ""
                idT = ""
                et = False
            ElseIf frmMain._cmd.Parameters("v_estado").Value = 0 Then
                dbms.Show(frmMain.lbEstado)
                txTipo.Focus()
                txTipo.SelectAll()
            Else
                dbms.Show()
            End If
        Catch ex As Exception
            _ESTADO(ex.Message, frmMain.lbEstado)
        Finally
            frmMain._cnn.Close()
        End Try
        inicial()
        _SET_DG("TTipos", "select idpr_tipo as CODIGO, NOMBRE from pr_tipo where idpr_categoria = " & cbCategoria.SelectedValue.ToString, dgT)
    End Sub

    Sub eCategoria()
        Try
            frmMain._cnn.Open()
            Dim dbms As New DBMSOutput(frmMain._cnn)
            dbms.Enable()
            frmMain._cmd = New OracleCommand()
            frmMain._cmd.Connection = frmMain._cnn
            With frmMain._cmd
                .CommandType = CommandType.StoredProcedure
                .CommandText = "SP_EDITAR_ESTADO_CATEGORIA"
                .Parameters.Add(New OracleParameter("v_idpr_categoria", OracleDbType.Varchar2)).Value = idC
                .Parameters.Add(New OracleParameter("v_nombre", OracleDbType.Varchar2)).Value = CStr(txCategoria.Text)
                .Parameters.Add(New OracleParameter("v_estado", OracleDbType.Int32, ParameterDirection.Output))
            End With
            frmMain._cmd.ExecuteNonQuery()
            If frmMain._cmd.Parameters("v_estado").Value > 0 Then
                dbms.Show(frmMain.lbEstado)
                dbms.Disable()
                txCategoria.Text = ""
                idC = ""
                ec = False
            ElseIf frmMain._cmd.Parameters("v_estado").Value = 0 Then
                dbms.Show(frmMain.lbEstado)
                txCategoria.Focus()
                txCategoria.SelectAll()
            Else
                dbms.Show()
            End If
        Catch ex As Exception
            _ESTADO(ex.Message, frmMain.lbEstado)
        Finally
            frmMain._cnn.Close()
        End Try
        inicial()
    End Sub

    Private Sub cbCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCategoria.LostFocus
        If swBt.Value = False Then
            _SET_DG("TTipos", "select idpr_tipo as CODIGO, NOMBRE from pr_tipo where idpr_categoria = " & cbCategoria.SelectedValue.ToString, dgT)
        End If

    End Sub

    Private Sub swBt_ValueChanged(sender As Object, e As EventArgs) Handles swBt.ValueChanged
        If swBt.Value = False Then
            gbC.Enabled = True
            gbT.Enabled = True
        Else
            gbC.Enabled = False
            gbT.Enabled = False
            idT = ""
            idC = ""
            et = False
            ec = False
        End If
    End Sub


    Private Sub btGuarda_Click(sender As Object, e As EventArgs) Handles btGuarda.Click
        If swBt.Value = True Then
            If txCategoria.Text = "" And txTipo.Text = "" Then
                _ESTADO("No pueden existir campos vacios", frmMain.lbEstado)
            ElseIf txTipo.Text = "" And txCategoria.Text <> "" Then
                gCategoria()
            ElseIf txTipo.Text <> "" And txCategoria.Text = "" Then
                gTipo()
            Else
                gCategoria()
                gTipo()
            End If
        Else
            If ec = True And et = False And txCategoria.Text <> "" Then
                eCategoria()
            ElseIf et = True And ec = False And txTipo.Text <> "" Then
                eTipo()
            ElseIf et And ec And txTipo.Text <> "" And txCategoria.Text <> "" Then
                eCategoria()
                eTipo()
            Else
                _ESTADO("No hay Ediciones", frmMain.lbEstado)
            End If
        End If
    End Sub

    Private Sub dgT_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgT.CellClick
        Try
            idT = dgT.SelectedCells(0).Value.ToString
            MsgBox(idT)
            txTipo.Text = dgT.SelectedCells(1).Value.ToString
            et = True
        Catch ex As Exception
            _ESTADO(ex.Message, frmMain.lbEstado)
        End Try

    End Sub

    Private Sub dgC_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgC.CellClick
        idC = dgC.SelectedCells(0).Value.ToString
        MsgBox(idC)
        txCategoria.Text = dgC.SelectedCells(1).Value.ToString
        ec = True
    End Sub
End Class

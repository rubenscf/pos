Imports Oracle.DataAccess.Client

Public Class ctrlMarca
    Dim editar As Boolean = False
    Dim id As String
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellClick
        id = dg.SelectedCells(0).Value.ToString
        MsgBox(id)
        txMarca.Text = dg.SelectedCells(1).Value.ToString
        editar = True
        swBt.Value = False
    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        Try
            frmMain._cnn.Open()
            Dim dbms As New DBMSOutput(frmMain._cnn)
            If txMarca.Text = "" Then
                _ESTADO("No Pueden existir Campos Vacios", frmMain.lbEstado)
            ElseIf swBt.Value = True Then
                dbms.Enable()
                frmMain._cmd = New OracleCommand()
                frmMain._cmd.Connection = frmMain._cnn
                With frmMain._cmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "SP_NUEVO_PR_MARCA"
                    .Parameters.Add(New OracleParameter("v_nombre", OracleDbType.Varchar2)).Value = CStr(txMarca.Text)
                    .Parameters.Add(New OracleParameter("v_estado", OracleDbType.Int32, ParameterDirection.Output))
                End With
                frmMain._cmd.ExecuteNonQuery()
                If frmMain._cmd.Parameters("v_estado").Value > 0 Then
                    dbms.Show(frmMain.lbEstado)
                    dbms.Disable()
                    txMarca.Text = ""
                    id = ""
                ElseIf frmMain._cmd.Parameters("v_estado").Value = 0 Then
                    dbms.Show(frmMain.lbEstado)
                    txMarca.Focus()
                    txMarca.SelectAll()
                Else
                    dbms.Show()
                End If
            ElseIf swBt.Value = False Then
                dbms.Enable()
                frmMain._cmd = New OracleCommand()
                frmMain._cmd.Connection = frmMain._cnn
                With frmMain._cmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "SP_EDITAR_ESTADO_MARCA"
                    .Parameters.Add(New OracleParameter("v_idpr_marca", OracleDbType.Int32)).Value = CInt(id)
                    .Parameters.Add(New OracleParameter("v_nombre", OracleDbType.Varchar2)).Value = CStr(txMarca.Text)
                    .Parameters.Add(New OracleParameter("v_estado", OracleDbType.Int32, ParameterDirection.Output))
                End With
                frmMain._cmd.ExecuteNonQuery()

                If frmMain._cmd.Parameters("v_estado").Value > 0 Then

                    dbms.Show(frmMain.lbEstado)

                    txMarca.Text = ""
                    id = ""

                Else
                    dbms.Show()
                End If
                editar = False
                swBt.Value = False
            End If
            _SET_DG("MARCA", "select idmarca as CODIGO, nombre as NOMBRE from pr_marca", dg)
            
        Catch ex As Exception
            _ESTADO(ex.Message, frmMain.lbEstado)
        Finally
            frmMain._cnn.Close()
        End Try
    End Sub

    Private Sub ctrlMarca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _SET_DG("MARCA", "select idmarca as CODIGO, nombre as NOMBRE from pr_marca", dg)

    End Sub

   

    Private Sub swBt_ValueChanged(sender As Object, e As EventArgs) Handles swBt.ValueChanged
        If swBt.Value = False And id = "" Then
            editar = True

        Else
            _ESTADO("Doble click sobre una marca para editar", frmMain.lbEstado)
            editar = False
        End If
    End Sub

   
   
End Class

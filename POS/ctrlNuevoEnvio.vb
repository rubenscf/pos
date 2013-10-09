Imports Oracle.DataAccess.Client

Public Class ctrlNuevoEnvio


    Private Sub swBt_ValueChanged(sender As Object, e As EventArgs) Handles swBt.ValueChanged
        If swBt.Value = False Then
            _LLENAR_CMB("SELECT idlugar as id, nombre||' '||direccion as nombre from lugar where idlu_tipo = '3'", cbVerTienda)
        Else
            _LLENAR_CMB("SELECT idlugar as id, nombre||' '||direccion as nombre from lugar where idlu_tipo = '2'", cbVerTienda)
        End If
    End Sub

    Sub CargaStock(ByVal envio As Boolean, ByVal ti As String)
        Try
            frmMain._cnn.Open()
            frmMain._Bs = New BindingSource
            setBSInventario(envio, cbVerTienda.SelectedValue, frmMain._Bs, dg, cbF)
            If frmMain._Bs.Count > 0 Then
                toolStrpAdd.Enabled = True
            Else
                toolStrpAdd.Enabled = False
            End If
        Catch ex As Exception
            _ESTADO(ex.Message, frmMain.lbEstado)
        Finally
            frmMain._cnn.Close()
        End Try
    End Sub


    Private Sub ctrlNuevoEnvio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _LLENAR_CMB("SELECT idlugar as id, nombre||' '||direccion as nombre from lugar where idlu_tipo = '2'", cbVerTienda)
        With (cbF)
            .Items.Add("CODIGO")
            .Items.Add("CATEGORIA")
            .Items.Add("TIPO")
            .Items.Add("MARCA")
            .Items.Add("MODELO")
            .Items.Add("DETALLE")
            .DropDownStyle = ComboBoxStyle.DropDownList
            .SelectedIndex = 3
        End With
    End Sub
    Private Sub txB_TextChanged(sender As Object, e As EventArgs) Handles txB.TextChanged
        Try
            Dim ret As Integer = Filtrar_tabla(cbF.Text, txB.Text.Trim, frmMain._Bs, dg)
            If ret = 0 Then
                txB.BackColor = Color.Red
            Else
                txB.BackColor = Color.White
            End If
        Catch ex As Exception
            _ESTADO(ex.Message, frmMain.lbEstado)
        End Try
    End Sub

    Private Sub cbVerTienda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbVerTienda.LostFocus
        CargaStock(swBt.Value, cbVerTienda.SelectedValue)


    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles toolStrpAdd.Click
        Try
            Dim filtro As String = dg.SelectedCells(2).Value
            Dim existe As Boolean = False
            Dim rowCodigo As String = String.Empty
            For Each row As DataGridViewRow In dgL.Rows
                rowCodigo = row.Cells("CODIGO").Value
                ' MsgBox(filtro)
                ' MsgBox(rowCodigo)
                If filtro = rowCodigo Then
                    existe = True
                    Exit For
                End If
            Next
            If existe Then
                _ESTADO("Este producto ya existe en la lista de envios", frmMain.lbEstado)
            Else
                dgL.Rows.Add(dg.SelectedCells(0).Value, dg.SelectedCells(1).Value, dg.SelectedCells(2).Value, dg.SelectedCells(5).Value, dg.SelectedCells(6).Value, 0, 0)
            End If
        Catch ex As Exception
            _ESTADO(ex.Message, frmMain.lbEstado)
        End Try

    End Sub



    Private Sub dgL_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgL.CellEndEdit
        If dgL.CurrentCell.ColumnIndex <> 7 Then
            Dim filtro As String = dgL.CurrentRow.Cells(2).Value
            'MsgBox(filtro)
            Dim quiere As Int16 = dgL.CurrentCell.Value
            Dim hay As Int16 = dgL.CurrentCell.Value
            Dim rowCodigo As String = String.Empty
            'dg.Focus()
            For Each row As DataGridViewRow In dg.Rows
                rowCodigo = row.Cells("CODIGO").Value
                If filtro = rowCodigo Then
                    '    MsgBox(row.Cells("CODIGO").Value)
                    '   MsgBox(row.Cells("NUEVOS").Value)
                    hay = row.Cells("NUEVOS").Value
                    If quiere > hay Then
                        MsgBox("La cantidad escrita es mayor de la existente en la otra tienda o bodega", vbCritical)
                        '   dgL.CurrentCell.Selected = True
                        'dgL.BeginEdit(True)
                    End If
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub btBorrarL_Click(sender As Object, e As EventArgs) Handles btBorrarL.Click
        If dgL.RowCount > 0 Then
            Dim resp As Integer
            resp = MsgBox("Esta seguro de quitar este producto de la lista? ", MsgBoxStyle.YesNo)
            If resp = vbYes Then
                dgL.Rows.Remove(dgL.CurrentRow)
            End If
        End If

    End Sub


    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        If dgL.RowCount > 0 Then
            Try
                Dim identipo As Integer
                If swBt.Value = True Then
                    identipo = 1
                Else
                    identipo = 2
                End If
                frmMain._cnn.Open()
                Dim dbms As New DBMSOutput(frmMain._cnn)
                dbms.Enable()
                MsgBox(dgL.Columns(0))
                frmMain._cmd = New OracleCommand()
                frmMain._cmd.Connection = frmMain._cnn
                With frmMain._cmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "SP_NUEVO_ENVIO"
                    .Parameters.Add(New OracleParameter("v_SALE", OracleDbType.Varchar2)).Value = cbVerTienda.SelectedValue
                    .Parameters.Add(New OracleParameter("v_iden_tipo", OracleDbType.Int32)).Value = identipo
                    .Parameters.Add(New OracleParameter("v_destino", OracleDbType.Varchar2)).Value = CStr("LOC")
                    .Parameters.Add(New OracleParameter("v_marca", OracleDbType.Array)).Value = dgL.Columns(0)
                    .Parameters.Add(New OracleParameter("v_modelo", OracleDbType.Array)).Value = dgL.Columns(1)
                    .Parameters.Add(New OracleParameter("v_nueva", OracleDbType.Array)).Value = dgL.Columns(6)
                    .Parameters.Add(New OracleParameter("v_segunda", OracleDbType.Array)).Value = dgL.Columns(6)
                    .Parameters.Add(New OracleParameter("v_detalle", OracleDbType.Array)).Value = dgL.Columns(7)
                    .Parameters.Add(New OracleParameter("v_estado", OracleDbType.Int32, ParameterDirection.Output))
                End With
                frmMain._cmd.ExecuteNonQuery()
                If frmMain._cmd.Parameters("v_estado").Value > 0 Then
                    dbms.Show(frmMain.lbEstado)
                    dgL.Rows.Clear()

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
End Class

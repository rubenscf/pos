Imports Oracle.DataAccess.Client
Imports Oracle.DataAccess.Types

Public Class ctrlNuevoEnvio


    Private Sub swBt_ValueChanged(sender As Object, e As EventArgs) Handles swBt.ValueChanged

        If swBt.Value = True Then
            _LLENAR_CMB("SELECT idlugar as id, nombre||' '||direccion as nombre from lugar where idlu_tipo = '2' AND idlugar <> '" & frmMain.serie & "'", cbVerTienda)
        Else
            _LLENAR_CMB("SELECT idlugar as id, nombre||' '||direccion as nombre from lugar where idlu_tipo = '3' AND idlugar <> '" & frmMain.serie & "'", cbVerTienda)
        End If
    End Sub

    Sub CargaStock()
        Try
            frmMain._cnn.Open()
            frmMain._Bs = New BindingSource
            setBSInventario(swBt.Value, cbVerTienda.SelectedValue, frmMain._Bs, dg, cbF)
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
        If frmMain.idtipolugar = 2 Then
            swBt.Enabled = False
            swBt.Value = False
            _LLENAR_CMB("SELECT idlugar as id, nombre||' '||direccion as nombre from lugar where idlu_tipo = '3' AND idlugar <> '" & frmMain.serie & "'", cbVerTienda)
        Else
            swBt.Value = False
            _LLENAR_CMB("SELECT idlugar as id, nombre||' '||direccion as nombre from lugar where idlu_tipo = '2' AND idlugar <> '" & frmMain.serie & "'", cbVerTienda)
        End If

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
        CargaStock()


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
            frmMain._cmd = New OracleCommand()
            Dim trans As OracleTransaction
            Dim iden As Integer

            Dim lugarActual As String = frmMain.serie
            Dim query As String
            Dim s As OracleDataReader
            frmMain._cnn.Open()
            trans = frmMain._cnn.BeginTransaction(IsolationLevel.ReadCommitted)
            frmMain._cmd.Transaction = trans
            frmMain._cmd.Connection = frmMain._cnn
            Try
                Dim identipo As Integer
                If swBt.Value = True Then
                    identipo = 1
                Else
                    identipo = 2
                End If
                frmMain._cmd.CommandText = "INSERT INTO ENVIO(sale, iden_tipo, idenvio, destino, fecha_salida, estado) VALUES('" & cbVerTienda.SelectedValue & "', " & identipo & ", SEQ_" & cbVerTienda.SelectedValue & "_IDENVIO.NEXTVAL, '" & lugarActual & "', sysdate, 'ESO')"
                frmMain._cmd.ExecuteNonQuery()

                frmMain._cmd.CommandText = "select SEQ_" & cbVerTienda.SelectedValue.ToString & "_IDENVIO.currval from dual"
                s = frmMain._cmd.ExecuteReader()

                While s.Read
                    iden = s.GetDecimal(0)
                End While
                s.Close()

                For Each f As DataGridViewRow In dgL.Rows
                    query = " INSERT INTO EN_DETALLE(sale, iden_tipo, idenvio, idpr_marca, idpr_modelo, nueva, segunda,  detalle)" &
                                          "VALUES('" & cbVerTienda.SelectedValue & "', '" & identipo & "','" & iden & "', '" & f.Cells(0).Value & "','" & f.Cells(1).Value & "', '" & f.Cells(5).Value & "', '" & f.Cells(6).Value & "', '" & f.Cells(7).Value & "')"
                    frmMain._cmd.CommandText = query
                    frmMain._cmd.ExecuteNonQuery()

                   
                Next

                trans.Commit()
                dgL.Rows.Clear()
                CargaStock()

                _ESTADO("Envio Realizado espere apobacion de la otra parte... ", frmMain.lbEstado)
            Catch ex As Exception
                trans.Rollback()
                _ESTADO(ex.Message, frmMain.lbEstado)
            Finally
                frmMain._cnn.Close()
            End Try
        End If
    End Sub
End Class

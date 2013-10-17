Imports Oracle.DataAccess.Client

Public Class ctrlPedidos
    Dim query As String
    Sub cargaPedido()
        query = "SELECT sa.IDLUGAR AS cdestino, ti.IDEN_TIPO AS ctipo, en.idenvio, sa.NOMBRE AS lugar, en.FECHA_SALIDA AS fecha, ti.DETALLE AS tipo, es.DETALLE AS estado FROM AGENCIA.ENVIO en INNER JOIN AGENCIA.LUGAR sa ON en.DESTINO = sa.IDLUGAR INNER JOIN AGENCIA.ESTADO es ON en.ESTADO = es. ID INNER JOIN AGENCIA.EN_TIPO ti ON en.IDEN_TIPO = ti.IDEN_TIPO WHERE en.ESTADO = 'EEN' AND en.SALE = '" & frmMain.serie & "'"
        _SET_DG("Pedidos", query, dg)
        dg.Columns(0).Visible = False
        dg.Columns(1).Visible = False
        dg.Columns(2).Visible = False
    End Sub


    Private Sub ctrlPedidos_Load(sender As Object, e As EventArgs) Handles Me.Load
        cargaPedido()
    End Sub
    Private Sub ReflectionLabel2_Click(sender As Object, e As EventArgs) Handles ReflectionLabel2.Click

    End Sub

    Private Sub dg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellClick
        Try
            query = "SELECT ma.NOMBRE as MARCA, mo.NOMBRE as MODELO,  mo.DETALLE, de.NUEVA, de.SEGUNDA, de.DETALLE as DESCRIPCION FROM AGENCIA.EN_DETALLE de INNER JOIN AGENCIA.PR_MARCA ma ON de.IDPR_MARCA = ma.IDMARCA INNER JOIN AGENCIA.PR_MODELO mo ON de.IDPR_MODELO = mo.IDPR_MODELO WHERE de.SALE =  '" & frmMain.serie & "' AND de.IDEN_TIPO = " & dg.SelectedCells(1).Value & " AND de.IDENVIO = " & dg.SelectedCells(2).Value
            _SET_DG("detalle_pedido", query, dgD)
        Catch ex As Exception
            _ESTADO(ex.Message, frmMain.lbEstado)
        End Try
        
    End Sub


    Private Sub btAceptar_Click(sender As Object, e As EventArgs) Handles btAceptar.Click

        'For Each f As DataGridViewRow In dgD.Rows
        '    query = "UPDATE pr_inventario set nueva = nueva - " & f.Cells(5).Value & ", segunda = segunda - " & f.Cells(6).Value & " where idlugar= '" & cbVerTienda.SelectedValue & "' and idpr_marca = " & f.Cells(0).Value & " and idpr_modelo = " & f.Cells(1).Value
        '    frmMain._cmd.CommandText = query
        '    frmMain._cmd.ExecuteNonQuery()

        '    query = "SELECT nueva, segunda from pr_inventario where idlugar = '" & cbVerTienda.SelectedValue & "' and idpr_marca = " & f.Cells(0).Value & " and idpr_modelo = " & f.Cells(1).Value
        '    frmMain._cmd.CommandText = query
        '    r = frmMain._cmd.ExecuteReader()
        '    While r.Read
        '        nueva = r.GetDecimal(0)
        '        segunda = r.GetDecimal(1)
        '    End While
        '    r.Close()
        '    If nueva < f.Cells(5).Value Or segunda < f.Cells(6).Value Then
        '        _ESTADO("No hay cantidad de producto requerido... actualize nuevamente la ventana ", frmMain.lbEstado)
        '        Exit Try
        '    End If
        'Next
    End Sub

    Private Sub btAnular_Click(sender As Object, e As EventArgs) Handles btAnular.Click
        Dim resp As Integer = MsgBox("Esta Seguro Que Desea Anular El Pedido Seleccionado", MsgBoxStyle.YesNo)
        If resp = vbYes Then
            query = "UPDATE envio set estado = 'EAN' WHERE sale = '" & frmMain.serie & "' and idenvio = " & dg.SelectedCells(2).Value
            Try
                frmMain._cmd = New OracleCommand
                frmMain._cnn.Open()
                frmMain._cmd.CommandText = query
                frmMain._cmd.Connection = frmMain._cnn
                frmMain._cmd.ExecuteNonQuery()
                cargaPedido()
                _ESTADO("Pedido Anulado Exitosamente", frmMain.lbEstado)
            Catch ex As Exception
                _ESTADO(ex.Message, frmMain.lbEstado)
            Finally
                frmMain._cnn.Close()
            End Try
        End If
    End Sub
    Private Sub btPrint_Click(sender As Object, e As EventArgs) Handles btPrint.Click
        Dim frm As New frmImprimir
        frm.EnvioTraslado(frmMain.serie, dg.SelectedCells(2).Value, frmMain.idtipolugar)
        frm.Show()
    End Sub
End Class

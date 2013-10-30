Imports Oracle.DataAccess.Client

Public Class ctrlPedidos
    Dim query As String
    Dim impreso As Boolean = False
    Sub cargaPedido()

        query = "SELECT sa.IDLUGAR AS cdestino, ti.IDEN_TIPO AS ctipo, en.idenvio, sa.NOMBRE AS lugar, en.FECHA_SALIDA AS fecha, ti.DETALLE AS tipo, es.DETALLE AS estado FROM AGENCIA.ENVIO en INNER JOIN AGENCIA.LUGAR sa ON en.DESTINO = sa.IDLUGAR INNER JOIN AGENCIA.ESTADO es ON en.ESTADO = es. ID INNER JOIN AGENCIA.EN_TIPO ti ON en.IDEN_TIPO = ti.IDEN_TIPO WHERE en.ESTADO = 'ESO' AND en.SALE = '" & frmMain.serie & "'"
        _SET_DG("Pedidos", query, dg)
        dg.Columns(0).Visible = False
        dg.Columns(1).Visible = False
        dg.Columns(2).Visible = False
    End Sub


    Private Sub ctrlPedidos_Load(sender As Object, e As EventArgs) Handles Me.Load
        cargaPedido()
        dgD.Rows.Clear()
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

        Try

            frmMain._cnn.Open()
            If impreso Then
                Dim dbms As New DBMSOutput(frmMain._cnn)
                If dg.RowCount < 1 Then
                    _ESTADO("No hay elementos seleccionados", frmMain.lbEstado)
                Else
                    dbms.Enable()
                    frmMain._cmd = New OracleCommand()
                    frmMain._cmd.Connection = frmMain._cnn
                    With frmMain._cmd
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "SP_ACEPTAR_ENVIO"
                        .Parameters.Add(New OracleParameter("v_sale", OracleDbType.Varchar2)).Value = frmMain.serie
                        .Parameters.Add(New OracleParameter("v_idenvio", OracleDbType.Int32)).Value = CInt(dg.SelectedCells(2).Value)
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
                    cargaPedido()
                    impreso = False
                End If
            Else
                _ESTADO("Primero debe Imprimir el formato de envio", frmMain.lbEstado)
            End If

        Catch ex As Exception
            _ESTADO(ex.Message, frmMain.lbEstado)
        Finally
            frmMain._cnn.Close()
        End Try


    End Sub

    Private Sub btAnular_Click(sender As Object, e As EventArgs) Handles btAnular.Click
        If dg.RowCount > 0 Then
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
        End If
    End Sub
    Private Sub btPrint_Click(sender As Object, e As EventArgs) Handles btPrint.Click
        If dg.RowCount > 0 Then
            Dim frm As New frmImprimir
            frm.EnvioTraslado(frmMain.serie, dg.SelectedCells(2).Value, frmMain.idtipolugar)
            frm.Show()
            impreso = True
        End If

    End Sub
End Class

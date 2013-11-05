Imports Oracle.DataAccess.Client

Public Class ctrlContratoACliente
    Dim query As String
    Dim vcantidad As Decimal
    Dim r As OracleDataReader
    Sub cargarDatos()
        query = "SELECT CR.CLIENTE, CR.FIADOR, CR.IDLUGAR, CR.IDVE_CREDITO, CR.FECHA, CR.IDLUGAR || '-' || CR.IDVE_CREDITO AS CORRELATIVO, CLIENTE.DPI, CLIENTE.NOMBRE AS CLIENTE, ESTADO.DETALLE FROM VE_CREDITO CR INNER JOIN ESTADO ON CR.ESTADO = ESTADO. ID INNER JOIN CLIENTE ON CLIENTE.IDCLIENTE = CR.CLIENTE WHERE CR.ESTADO = 'CAC'"
        _SET_DG("creditos_listos", query, dg)
        dg.Columns.Item(0).Visible = False
        dg.Columns.Item(1).Visible = False
        dg.Columns.Item(2).Visible = False
        dg.Columns.Item(3).Visible = False

    End Sub

    Private Sub ctrlContratoACliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
    End Sub

    Private Sub dg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellClick


        Dim lugar As String = dg.CurrentRow.Cells(2).Value.ToString
        Dim correlativo = dg.CurrentRow.Cells(3).Value.ToString
        Try
            query = "SELECT ma.NOMBRE as MARCA, mo.NOMBRE as MODELO, crd.IDLUGAR, crd.SUBTOTAL FROM  AGENCIA.VE_CR_DETALLE crd" &
" INNER JOIN AGENCIA.PR_MODELO mo ON crd.IDPR_MARCA = mo.IDPR_MARCA AND crd.IDPR_MODELO = mo.IDPR_MODELO " &
" INNER JOIN AGENCIA.PR_MARCA ma ON mo.IDPR_MARCA = ma.IDMARCA " &
" WHERE CRD.IDLUGAR = '" & lugar & "' and CRD.IDVE_CREDITO = '" & correlativo & "'"
            _SET_DG("detalle_credito", query, dgD)

            query = "SELECT CL_NIVEL, DPI, NOMBRE, APELLIDO, NIT FROM CLIENTE WHERE IDCLIENTE = " & dg.CurrentRow.Cells(0).Value
            frmMain._cnn.Open()

            r = _CONSULTAR_orcl(query)
            While (r.Read)
                lbCtipo.Text = r.GetOracleString(0).ToString
                lbCdpi.Text = r.GetString(1).ToString
                lbcNombre.Text = r.GetString(2).ToString
                lbCApellido.Text = r.GetString(3).ToString
                lbCNit.Text = r.GetString(4).ToString

            End While
            r.Close()
            query = "SELECT  CL_NIVEL, DPI, NOMBRE, APELLIDO, NIT FROM CLIENTE WHERE IDCLIENTE = " & dg.CurrentRow.Cells(1).Value

            r = _CONSULTAR_orcl(query)
            While (r.Read)
                lbFTipo.Text = r.GetOracleString(0).ToString
                lbFDPI.Text = r.GetString(1).ToString
                lbFNombre.Text = r.GetString(2).ToString
                lbFApellido.Text = r.GetString(3).ToString

                lbFnit.Text = r.GetString(4).ToString

            End While
            r.Close()
            dgD.Refresh()

            query = "SELECT FECHA, NO_CUOTA, ENGANCHE, VALOR_CUOTA, ULTIMA_CUOTA, DESCUENTO, TOTAL, OBSERVACIONES FROM VE_CREDITO WHERE IDLUGAR = '" & lugar & "' AND IDVE_CREDITO = '" & correlativo & "'"
            r = _CONSULTAR_orcl(query)
            While (r.Read)
                lbpfecha.Text = r.GetOracleDate(0)
                vcantidad = r.GetDecimal(1)
                lbpcant.Text = (CInt(r.GetDecimal(1)) - 2).ToString & " Pasgos de:"
                lbpinicial.Text = "Q." & r.GetDecimal(2)
                lbppago.Text = "Q." & r.GetDecimal(3)
                lbpultimo.Text = "Q" & r.GetDecimal(4)
                lbpdescto.Text = "Q" & r.GetDecimal(5)
                lbptotal.Text = "Q." & r.GetDecimal(6)
                lbpobserv.Text = r.GetString(7)
            End While
            r.Close()

            If dgP.Rows.Count > 0 Then
                dgP.Rows.Clear()
            End If
            query = "SELECT LT.IDVE_LETRA, LT.FECHA_VENCE, LT.CANTIDAD, CR.ENG_X2 FROM AGENCIA.VE_LETRA LT INNER JOIN AGENCIA.VE_CREDITO CR ON LT.IDLUGAR = CR.IDLUGAR AND LT.IDVE_CREDITO = CR.IDVE_CREDITO  WHERE LT.IDLUGAR = '" & lugar & "' AND LT.IDVE_CREDITO = '" & correlativo & "'"
            r = _CONSULTAR_orcl(query)
            Dim nmes As Int16 = 0
            Dim c As Int16 = 0
            While (r.Read)
                If r.GetString(3) = "1" And dgP.RowCount <= 2 Then
                    dgP.Rows.Add(r.GetDecimal(0), Date.Now.AddDays(c).ToShortDateString, "Q." & r.GetDecimal(2).ToString)
                    c += 14
                    If c > 14 Then
                        nmes += 1
                    End If
                ElseIf r.GetString(3) = "1" And dgP.RowCount > 2 Then
                    dgP.Rows.Add(r.GetDecimal(0), Date.Now.AddMonths(nmes).ToShortDateString, "Q." & r.GetDecimal(2).ToString)
                    nmes += 1
                End If
                If r.GetString(3) = "0" Then
                    dgP.Rows.Add(r.GetDecimal(0), Date.Now.AddMonths(nmes).ToShortDateString, "Q." & r.GetDecimal(2).ToString)
                    nmes += 1
                End If
            End While
            r.Close()

        Catch ex As System.Exception

            _ESTADO(ex.Message, frmMain.lbEstado)
        Finally
            frmMain._cnn.Close()
        End Try



    End Sub
    Private Sub txNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txNumero.KeyPress

    End Sub
End Class

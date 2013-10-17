Imports Microsoft.Reporting.WinForms

Public Class frmImprimir


    Sub EnvioTraslado(ByVal lugar As String, ByVal envio As Decimal, ByVal tipoLugar As Int16)
        Try
            Dim parametro As List(Of ReportParameter) = New List(Of ReportParameter)()
            If tipoLugar = 2 Then
                parametro.Add(New ReportParameter("TIPO", "ENVIO"))
            ElseIf tipoLugar = 3 Then
                parametro.Add(New ReportParameter("TIPO", "TRASLADO"))
            End If
            rpt.LocalReport.ReportEmbeddedResource = "POS.FormaEnvio.rdlc"
            rpt.LocalReport.SetParameters(parametro)
            rpt.SetDisplayMode(Microsoft.Reporting.WinForms.ZoomMode.PageWidth)
            'TODO: esta línea de código carga datos en la tabla '_DS.Pedido' Puede moverla o quitarla según sea necesario.
            Me.PedidoTableAdapter.Fill(Me._DS.Pedido, lugar, envio)
            rpt.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            rpt.RefreshReport()
        Catch ex As Exception
            _ESTADO(ex.Message, frmMain.lbEstado)
        End Try
    End Sub
End Class
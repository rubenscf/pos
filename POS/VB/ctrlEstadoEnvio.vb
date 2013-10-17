Imports Oracle.DataAccess.Client

Public Class ctrlEstadoEnvio
    Dim query As String
    Private Sub ctrlEstadoEnvio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        query = "SELECT en.IDENVIO, en.FECHA_SALIDA, es.DETALLE FROM AGENCIA.ESTADO es INNER JOIN AGENCIA.ENVIO en ON en.ESTADO = es. ID WHERE es.SECCION = 'ENVIO' AND en.DESTINO = '" & frmMain.serie & "' AND en.ESTADO <> 'ERE'"
        'frmMain._cmd New OracleCommand
        Try
            _SET_DG("estado", query, dg)

        Catch ex As Exception
            _ESTADO(ex.Message, frmMain.lbEstado)
        End Try


    End Sub

   
End Class

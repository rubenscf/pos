Imports System.Security.Cryptography
Imports Oracle.DataAccess.Client


Public Class ctrlLogin
    Dim query As String
    Private Sub btEntrar_Click(sender As Object, e As EventArgs) Handles btEntrar.Click

        Using md5Hash As MD5 = MD5.Create()
            Dim hash As String = _ObtieneMd5Hash(md5Hash, txPass.Text)
            query = "SELECT emp.IDEMPLEADO, emp.NOMBRE || ' ' || emp.APELLIDO AS NOMBRE, pue.DETALLE AS puesto,lug.IDLUGAR AS serie, lug.NOMBRE AS lugar, pue.IDLU_PUESTO AS idpuesto,  tip.NOMBRE AS tipoLugar, tip.IDLU_TIPO AS idtipolugar FROM AGENCIA.EMPLEADO emp INNER JOIN AGENCIA.LUGAR lug ON emp.IDLUGAR = lug.IDLUGAR INNER JOIN AGENCIA.LU_PUESTO pue ON emp.IDLU_PUESTO = pue.IDLU_PUESTO INNER JOIN AGENCIA.LU_TIPO tip ON lug.IDLU_TIPO = tip.IDLU_TIPO AND pue.IDLU_TIPO = tip.IDLU_TIPO WHERE emp.USUARIO = '" & txUsuario.Text & "' AND emp.pass = '" & hash & "'"
        End Using
        MsgBox(query)
        Try
            frmMain._cmd = New OracleCommand
            frmMain._cnn.Open()
            frmMain._cmd.CommandText = query
            frmMain._cmd.Connection = frmMain._cnn
            Dim r As OracleDataReader = frmMain._cmd.ExecuteReader()
            If r.HasRows Then
                While r.Read
                    frmMain.idempleado = r.GetDecimal(0)
                    frmMain.nombre = r.GetString(1)
                    frmMain.puesto = r.GetString(2)
                    frmMain.serie = r.GetString(3)
                    frmMain.lugar = r.GetString(4)
                    frmMain.idpuesto = r.GetDecimal(5)
                    frmMain.tipolugar = r.GetString(6)
                    frmMain.idtipolugar = r.GetDecimal(7)
                End While
                r.Close()
                _ESTADO("Sesion iniciada", frmMain.lbEstado)
                frmMain.iniciarSesion()
                Me.Dispose()
            Else
                Beep()
                _ESTADO("Combinacion de usuario y contraseña incorrecta.... ", frmMain.lbEstado)
            End If
            
        Catch ex As Exception
            _ESTADO(ex.Message, frmMain.lbEstado)
        Finally
            frmMain._cnn.Close()
        End Try

        '   Me.Dispose()
    End Sub

    Private Sub ctrlLogin_Load(sender As Object, e As EventArgs) Handles Me.Load


    End Sub
End Class

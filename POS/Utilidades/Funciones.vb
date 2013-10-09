Imports Oracle.DataAccess.Client
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls

Module Funciones

    Public Sub _LLENAR_CMB(ByVal sql As String, ByRef _cmb As ComboBox)
        Dim Dt As DataTable
        Dim Da As New OracleDataAdapter
        With frmMain._cmd
            .CommandType = CommandType.Text
            .CommandText = sql
            .Connection = frmMain._cnn
        End With
        Da.SelectCommand = frmMain._cmd
        Dt = New DataTable
        Da.Fill(Dt)
        With _cmb
            .DataSource = Dt
            .DisplayMember = "nombre"
            .ValueMember = "id"
        End With
    End Sub

    Public Sub _LLENAR_CMB(ByVal sql As String, ByRef _cmb As ComboBoxEx)
        Dim Dt As DataTable
        Dim Da As New OracleDataAdapter
        With frmMain._cmd
            .CommandType = CommandType.Text
            .CommandText = sql
            .Connection = frmMain._cnn
        End With
        Da.SelectCommand = frmMain._cmd
        Dt = New DataTable
        Da.Fill(Dt)
        With _cmb
            .DataSource = Dt
            .DisplayMember = "nombre"
            .ValueMember = "id"
        End With
    End Sub
 
    
    Public Sub _SET_DG(ByVal nombreTabla As String, ByVal query As String, ByRef dg As DataGridView)
        Dim ds = New DataSet
        Dim da = New OracleDataAdapter(query, frmMain._cnn)
        da.Fill(ds, nombreTabla)
        dg.DataSource = ds.Tables(nombreTabla)
    End Sub

    Public Sub _ESTADO(ByVal texto As String, ByRef _lbl As LabelItem)
        '_lbl.Text = texto
        frmMain.lb = _lbl
        frmMain.lb.Text = texto
        frmMain.bEstado = True
    End Sub
  
   

    Public Function _NITvalido(ByVal Nit As String) As Boolean
        If Nit = "c/f" Then
            Return True
        Else
            Try
                Dim pos As Integer = Nit.IndexOf("-")
                Dim Correlativo As String = Nit.Substring(0, pos)
                Dim DigitoVerificador As String = Nit.Substring(pos + 1)
                Dim Factor As Integer = Correlativo.Length + 1
                Dim Suma As Integer = 0
                Dim Valor As Integer = 0
                For x As Integer = 0 To Nit.IndexOf("-") - 1
                    Valor = CInt(Nit.Substring(x, 1))
                    Suma = Suma + (Valor * Factor)
                    Factor = Factor - 1
                Next

                Dim xMOd11 As Double
                xMOd11 = (11 - (Suma Mod 11)) Mod 11
                Dim s As String = Str(xMOd11)

                If (xMOd11 = 10 And DigitoVerificador = "K") Or (s.Trim = DigitoVerificador) Then

                    Return True
                End If
                Return False
            Catch ex As Exception
                Return False
            End Try
        End If
    End Function


    Function Filtrar_tabla( _
        ByVal Col As String, _
        ByVal tx As String, _
        ByRef Bs As BindingSource, _
        ByRef Dgv As DataGridView) As Integer
        If Bs.DataSource Is Nothing Then

            Return 0

        End If
        Try
            Dim filtro As String = String.Empty
            ' Seleccionar la opción 
            ' If tx.Trim <> "" Then
            If Col = "" Then
                filtro = " = " & CInt(tx.Trim) & ""
            Else
                filtro = " like '%" & tx.Trim & "%'"
            End If
            ' armar el sql
            If filtro <> String.Empty Then
                filtro = Col & filtro
            End If
            ' asigar el criterio a la propiedad Filter del BindingSource
            Bs.Filter = filtro
            '   End If
            ' enlzar el datagridview al BindingSource
            Dgv.DataSource = Bs.DataSource
            ' retornar la cantidad de registros encontrados
            Return Bs.Count
            ' errores
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try

        Return 0

    End Function
End Module

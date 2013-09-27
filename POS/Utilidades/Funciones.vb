Imports Oracle.DataAccess.Client
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls

Module Funciones

    Sub _LLENAR_CMB(ByVal sql As String, ByRef _cmb As ComboBox)
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

    Sub _ESTADO(ByVal texto As String, ByRef _lbl As LabelItem)
        '_lbl.Text = texto
        frmMain.lb = _lbl
        frmMain.lb.Text = texto
        frmMain.bEstado = True
    End Sub
End Module

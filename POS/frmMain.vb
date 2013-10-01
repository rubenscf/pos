Imports Oracle.DataAccess.Client
Imports System.Configuration
Imports DevComponents.DotNetBar

Public Class frmMain
    'declaracion de variables para la conexion a la base de datos
    Public _strcnn As String = "DATA SOURCE=localhost:1521/XE; PERSIST SECURITY INFO=True;USER ID=agencia;PASSWORD=sistemas;"
    '_strcnn =  "DATA SOURCE=;PERSIST SECURITY INFO=True;USER ID=taller;Password=sistemas;"
    Public _cnn As New OracleConnection(_strcnn)
    ' Public _cnn As New OracleConnection
    Public _cmd As New OracleCommand
    'variables de contenedoras
    Private con As Long
    Public lb As LabelItem
    Public htp As New Hashtable()
    Public bEstado As Boolean

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' frmCnn.Show() 'Mostrar la ventana de conexion
        Timer.Interval = 1000
        ' Timer.Start()
        bEstado = False

    End Sub


    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        lbTitulo.Text = Date.Now.ToString
        If bEstado Then
            con += 1
            If con = 7 Then
                lb.Text = ""
                StatusBar.Refresh()

                con = 0
                bEstado = False
            End If
        End If
    End Sub
    'Sub _ESTADsO(ByVal texto As String, ByRef _lbl As LabelItem)
    '    _lbl.Text = texto

    'End Sub

    Private Sub bt_puesto_Click(sender As Object, e As EventArgs) Handles bt_puesto.Click
        Dim ind As Integer = -1
        Dim clave As String = "Puestos"  'cambiar valor
        If htp.ContainsKey(clave) Then
            tpMain.SelectedTabIndex = htp.Item(clave)
        Else
            Dim newTab As TabItem = tpMain.CreateTab(clave, -1)
            Dim panel As TabControlPanel = DirectCast(newTab.AttachedControl, TabControlPanel)
            ind = tpMain.Tabs.Count - 1
            tpMain.SelectedTabIndex = ind
            Dim control As New ctrlPuesto 'cambiar control
            control.Dock = DockStyle.Fill
            panel.Controls.Add(control)
            htp.Add(clave, ind)
            '            MsgBox(ind.ToString)
        End If
    End Sub

    Private Sub btNuevoLugar_Click(sender As Object, e As EventArgs) Handles btNuevoLugar.Click
        Dim ind As Integer = -1
        Dim clave As String = "Tienda" 'cambiar valor
        If htp.ContainsKey(clave) Then
            tpMain.SelectedTabIndex = htp.Item(clave)
        Else
            Dim newTab As TabItem = tpMain.CreateTab(clave, -1)
            Dim panel As TabControlPanel = DirectCast(newTab.AttachedControl, TabControlPanel)
            ind = tpMain.Tabs.Count - 1
            tpMain.SelectedTabIndex = ind
            Dim control As New ctrlTienda 'cambiar control
            control.Dock = DockStyle.Fill
            panel.Controls.Add(control)
            htp.Add(clave, ind)
            '            MsgBox(ind.ToString)
        End If
    End Sub


    Private Sub tpMain_Click(sender As Object, e As TabStripActionEventArgs) Handles tpMain.TabItemClose
        Dim itemToRemove As TabItem = tpMain.SelectedTab
        If itemToRemove.Text.Equals("INICIO") Then
            e.Cancel = True
            'MsgBox(itemToRemove.Text)
        Else
            ' MsgBox(itemToRemove.Text)
            htp.Remove(itemToRemove.Text)
        End If
    End Sub


    Private Sub bt_Click(sender As Object, e As EventArgs) Handles bt.Click
        Dim ind As Integer = -1
        Dim clave As String = "Empleados" 'cambiar valor
        If htp.ContainsKey(clave) Then
            tpMain.SelectedTabIndex = htp.Item(clave)
        Else
            Dim newTab As TabItem = tpMain.CreateTab(clave, -1)
            Dim panel As TabControlPanel = DirectCast(newTab.AttachedControl, TabControlPanel)
            ind = tpMain.Tabs.Count - 1
            tpMain.SelectedTabIndex = ind
            Dim control As New ctrlEmpleados 'cambiar control
            control.Dock = DockStyle.Fill
            panel.Controls.Add(control)
            htp.Add(clave, ind)
        End If
    End Sub

    Private Sub mnuPRMarca_Click(sender As Object, e As EventArgs) Handles mnuPRMarca.Click
        Dim ind As Integer = -1
        Dim clave As String = "PR. Marcas" 'cambiar valor
        If htp.ContainsKey(clave) Then
            tpMain.SelectedTabIndex = htp.Item(clave)
        Else
            Dim newTab As TabItem = tpMain.CreateTab(clave, -1)
            Dim panel As TabControlPanel = DirectCast(newTab.AttachedControl, TabControlPanel)
            ind = tpMain.Tabs.Count - 1
            tpMain.SelectedTabIndex = ind
            Dim control As New ctrlMarca 'cambiar control
            control.Dock = DockStyle.Fill
            panel.Controls.Add(control)
            htp.Add(clave, ind)
            '            MsgBox(ind.ToString)
        End If
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Dim ind As Integer = -1
        Dim clave As String = "PR. Modelos" 'cambiar valor
        If htp.ContainsKey(clave) Then
            tpMain.SelectedTabIndex = htp.Item(clave)
        Else
            Dim newTab As TabItem = tpMain.CreateTab(clave, -1)
            Dim panel As TabControlPanel = DirectCast(newTab.AttachedControl, TabControlPanel)
            ind = tpMain.Tabs.Count - 1
            tpMain.SelectedTabIndex = ind
            Dim control As New ctrlPRModelo 'cambiar control
            control.Dock = DockStyle.Fill
            panel.Controls.Add(control)
            htp.Add(clave, ind)
            '            MsgBox(ind.ToString)
        End If
    End Sub
End Class

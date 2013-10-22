Imports Oracle.DataAccess.Client
Imports System.Configuration
Imports DevComponents.DotNetBar


Public Class frmMain
    ' Protected conf As New OracleConnectionStringBuilder("OracleCnn")
    'declaracion de variables para la conexion a la base de datos

    'Public _strcnn As String = "DATA SOURCE=192.168.1.6:1521/XE; PERSIST SECURITY INFO=True;USER ID=agencia;PASSWORD=sistemas;"
    Public _strcnn As String = ConfigurationManager.ConnectionStrings("POS.My.MySettings.ConnectionString").ConnectionString
    '_strcnn =  ConfigurationManager.ConnectionStrings("POS.My.MySettings.ConnectionString").ConnectionString

    Public _cnn As New OracleConnection(_strcnn)
    ' Public _cnn As New OracleConnection
    Public _cmd As New OracleCommand
    Public _Bs As BindingSource
    'variables de contenedoras
    Private con As Long
    Public lb As LabelItem
    Public htp As New Hashtable()
    Public bEstado As Boolean

    'variables de sesion
    Public nombre, puesto, lugar, serie, tipolugar As String
    Public idempleado, idpuesto, idtipolugar As Decimal

    Public Sub verPedidos()
        Dim ind As Integer = -1
        Dim clave As String = "Gestor De Pedidos" 'cambiar valor
        If htp.ContainsKey(clave) Then
            tpMain.SelectedTabIndex = htp.Item(clave)
        Else
            Dim newTab As TabItem = tpMain.CreateTab(clave, -1)
            Dim panel As TabControlPanel = DirectCast(newTab.AttachedControl, TabControlPanel)
            ind = tpMain.Tabs.Count - 1
            tpMain.SelectedTabIndex = ind
            Dim control As New ctrlPedidos            'cambiar control
            control.Dock = DockStyle.Fill
            panel.Controls.Add(control)
            htp.Add(clave, ind)
            '            MsgBox(ind.ToString)
        End If
    End Sub
    Sub verNuevoEnvio()
        Dim ind As Integer = -1
        Dim clave As String = "Nuevo Envio" 'cambiar valor
        If htp.ContainsKey(clave) Then
            tpMain.SelectedTabIndex = htp.Item(clave)
        Else
            Dim newTab As TabItem = tpMain.CreateTab(clave, -1)
            Dim panel As TabControlPanel = DirectCast(newTab.AttachedControl, TabControlPanel)
            ind = tpMain.Tabs.Count - 1
            tpMain.SelectedTabIndex = ind
            Dim control As New ctrlNuevoEnvio            'cambiar control
            control.Dock = DockStyle.Fill
            panel.Controls.Add(control)
            htp.Add(clave, ind)
            '            MsgBox(ind.ToString)
        End If
    End Sub
    Sub addStock()
        Dim ind As Integer = -1
        Dim clave As String = "Nuevo producto a inventario" 'cambiar valor
        If htp.ContainsKey(clave) Then
            tpMain.SelectedTabIndex = htp.Item(clave)
        Else
            Dim newTab As TabItem = tpMain.CreateTab(clave, -1)
            Dim panel As TabControlPanel = DirectCast(newTab.AttachedControl, TabControlPanel)
            ind = tpMain.Tabs.Count - 1
            tpMain.SelectedTabIndex = ind
            Dim control As New ctrlStokAdd 'cambiar control
            control.Dock = DockStyle.Fill
            panel.Controls.Add(control)
            htp.Add(clave, ind)
            '            MsgBox(ind.ToString)
        End If
    End Sub
    Public Sub iniciarSesion()
        menuMetro.Visible = True
        If idtipolugar = 2 Then
            mnuBodega.Visible = True
            mnuTABBODEGA.Visible = True
            mnuTienda.Visible = False
            mnuTABTIENDA.Visible = False

            mnuSistema.Visible = False
            mnuTABSISTEMA.Visible = False
            mnuBodega.Select()
        ElseIf idtipolugar = 3 Then

            mnuTienda.Visible = True
            mnuTABTIENDA.Visible = True
            mnuBodega.Visible = False
            mnuTABBODEGA.Visible = False
            mnuSistema.Visible = False
            mnuTABSISTEMA.Visible = False
            ' 7 encargado de tienda - 8 secretaria - 9 cajero -10 vendedor - 11 cobrador 
            If idpuesto = 7 Then
                rbTieCaja.Visible = False
            ElseIf idpuesto = 8 Then
                rbTieCaja.Visible = False
            ElseIf idpuesto = 9 Then
                rbTieClientes.Visible = False
                rbTieTraslado.Visible = False
                rbtieVentas.Visible = False
            ElseIf idpuesto = 10 Or idpuesto = 11 Then
                rbTieCaja.Visible = False
                rbTieTraslado.Visible = False
            End If
            mnuTienda.Select()
        End If
        Dim cinicio As New ctrlInicio
        cinicio.Dock = DockStyle.Fill
        tcpMain.Controls.Add(cinicio)
    End Sub
    Sub verEstadoEnvio()
        Dim ind As Integer = -1
        Dim clave As String = "Estado De Envios" 'cambiar valor
        If htp.ContainsKey(clave) Then
            tpMain.SelectedTabIndex = htp.Item(clave)
        Else
            Dim newTab As TabItem = tpMain.CreateTab(clave, -1)
            Dim panel As TabControlPanel = DirectCast(newTab.AttachedControl, TabControlPanel)
            ind = tpMain.Tabs.Count - 1
            tpMain.SelectedTabIndex = ind
            Dim control As New ctrlEstadoEnvio            'cambiar control
            control.Dock = DockStyle.Fill
            panel.Controls.Add(control)
            htp.Add(clave, ind)
            '            MsgBox(ind.ToString)
        End If
    End Sub
    Public Sub cerrarSesion()
        menuMetro.Visible = False
        If idtipolugar = 2 Then
            mnuTienda.Visible = False
            mnuTABTIENDA.Visible = False
            mnuSistema.Visible = False
            mnuTABSISTEMA.Visible = False
        ElseIf idtipolugar = 3 Then
            mnuBodega.Enabled = True
            mnuSistema.Enabled = True
            ' 7 encargado de tienda - 8 secretaria - 9 cajero -10 vendedor - 11 cobrador 
            If idpuesto = 7 Then
                rbTieCaja.Visible = True
            ElseIf idpuesto = 8 Then
                rbTieCaja.Visible = True
            ElseIf idpuesto = 9 Then
                rbTieClientes.Visible = False
                rbTieTraslado.Visible = True
                rbtieVentas.Visible = False
            ElseIf idpuesto = 10 Or idpuesto = 11 Then
                rbTieCaja.Visible = True
                rbTieTraslado.Visible = True
            End If
        End If
        htp.Clear()
        Dim cinicio As New ctrlLogin
        cinicio.Dock = DockStyle.Fill
        tcpMain.Controls.Add(cinicio)
    End Sub
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '   _strcnn = ConfigurationManager.ConnectionStrings("POS.My.MySettings.ConnectionString").ConnectionString
        ' MsgBox(_strcnn)
        ' frmCnn.Show() 'Mostrar la ventana de conexion
        Timer.Interval = 1000
        'Timer.Start()
        bEstado = False
        Dim clogin As New ctrlLogin
        clogin.Dock = DockStyle.Fill
        tcpMain.Controls.Add(clogin)

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


    Private Sub tpMain_Click(sender As Object, e As TabStripActionEventArgs) Handles tpMain.TabItemClose, tpMain.Click
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


    Private Sub mnuPRCategoria_Click(sender As Object, e As EventArgs) Handles mnuPRCategoria.Click
        Dim ind As Integer = -1
        Dim clave As String = "PR. Categorias" 'cambiar valor
        If htp.ContainsKey(clave) Then
            tpMain.SelectedTabIndex = htp.Item(clave)
        Else
            Dim newTab As TabItem = tpMain.CreateTab(clave, -1)
            Dim panel As TabControlPanel = DirectCast(newTab.AttachedControl, TabControlPanel)
            ind = tpMain.Tabs.Count - 1
            tpMain.SelectedTabIndex = ind
            Dim control As New ctrlCategoria 'cambiar control
            control.Dock = DockStyle.Fill
            panel.Controls.Add(control)
            htp.Add(clave, ind)
            '            MsgBox(ind.ToString)
        End If
    End Sub

    Private Sub btNInvetario_Click(sender As Object, e As EventArgs) Handles btNInvetario.Click
        addStock()
    End Sub


    Private Sub btNuevoCliente_Click(sender As Object, e As EventArgs) Handles btNuevoCliente.Click
        Dim ind As Integer = -1
        Dim clave As String = "Nuevo Cliente" 'cambiar valor
        If htp.ContainsKey(clave) Then
            tpMain.SelectedTabIndex = htp.Item(clave)
        Else
            Dim newTab As TabItem = tpMain.CreateTab(clave, -1)
            Dim panel As TabControlPanel = DirectCast(newTab.AttachedControl, TabControlPanel)
            ind = tpMain.Tabs.Count - 1
            tpMain.SelectedTabIndex = ind
            Dim control As New ctrlNuevoCliente 'cambiar control
            control.Dock = DockStyle.Fill
            panel.Controls.Add(control)
            htp.Add(clave, ind)
            '            MsgBox(ind.ToString)
        End If
    End Sub

    Private Sub btEnvios_Click(sender As Object, e As EventArgs)
        verNuevoEnvio()
    End Sub

    Private Sub btEstados_Click(sender As Object, e As EventArgs) Handles btEstados.Click
        verEstadoEnvio()
    End Sub

    Private Sub btVerPedidos_Click(sender As Object, e As EventArgs)
        verPedidos()
    End Sub


    Private Sub btRecibir_Click(sender As Object, e As EventArgs) Handles btRecibir.Click
        Dim ind As Integer = -1
        Dim clave As String = "Recepcion de Productos" 'cambiar valor
        If htp.ContainsKey(clave) Then
            tpMain.SelectedTabIndex = htp.Item(clave)
        Else
            Dim newTab As TabItem = tpMain.CreateTab(clave, -1)
            Dim panel As TabControlPanel = DirectCast(newTab.AttachedControl, TabControlPanel)
            ind = tpMain.Tabs.Count - 1
            tpMain.SelectedTabIndex = ind
            Dim control As New ctrlRecibeProducto            'cambiar control
            control.Dock = DockStyle.Fill
            panel.Controls.Add(control)
            htp.Add(clave, ind)
            '            MsgBox(ind.ToString)
        End If
    End Sub

    
    Private Sub btPedidos_Click(sender As Object, e As EventArgs) Handles btPedidos.Click
        verPedidos()
    End Sub

    Private Sub btNuevoEnvio_Click(sender As Object, e As EventArgs) Handles btNuevoEnvio.Click
        verNuevoEnvio()
    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles btEstadoEnvio.Click
        verEstadoEnvio()
    End Sub
End Class

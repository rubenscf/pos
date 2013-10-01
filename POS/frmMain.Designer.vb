<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits DevComponents.DotNetBar.Metro.MetroAppForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MetroShell1 = New DevComponents.DotNetBar.Metro.MetroShell()
        Me.MetroTabPanel3 = New DevComponents.DotNetBar.Metro.MetroTabPanel()
        Me.MetroTabPanel2 = New DevComponents.DotNetBar.Metro.MetroTabPanel()
        Me.MetroTabPanel1 = New DevComponents.DotNetBar.Metro.MetroTabPanel()
        Me.mnuVer = New DevComponents.DotNetBar.Metro.MetroTabItem()
        Me.mnuAdmon = New DevComponents.DotNetBar.Metro.MetroTabItem()
        Me.mnuSistema = New DevComponents.DotNetBar.Metro.MetroTabItem()
        Me.lbTitulo = New DevComponents.DotNetBar.LabelItem()
        Me.QatCustomizeItem1 = New DevComponents.DotNetBar.QatCustomizeItem()
        Me.StatusBar = New DevComponents.DotNetBar.Metro.MetroStatusBar()
        Me.lbEstado = New DevComponents.DotNetBar.LabelItem()
        Me.MicroChartItem1 = New DevComponents.DotNetBar.MicroChartItem()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.ButtonItem3 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem4 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem5 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem6 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem2 = New DevComponents.DotNetBar.ButtonItem()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.mnuINICIO = New DevComponents.DotNetBar.Metro.MetroAppButton()
        Me.mnuProducto = New DevComponents.DotNetBar.Metro.MetroTabItem()
        Me.MetroTabPanel4 = New DevComponents.DotNetBar.Metro.MetroTabPanel()
        Me.tpMain = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.INICIO = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.mnuPRMarca = New DevComponents.DotNetBar.ButtonX()
        Me.bt = New DevComponents.DotNetBar.ButtonX()
        Me.bt_puesto = New DevComponents.DotNetBar.ButtonX()
        Me.btNuevoLugar = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.MetroShell1.SuspendLayout()
        Me.MetroTabPanel3.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.MetroTabPanel4.SuspendLayout()
        CType(Me.tpMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroShell1
        '
        Me.MetroShell1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.MetroShell1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroShell1.CaptionVisible = True
        Me.MetroShell1.Controls.Add(Me.MetroTabPanel4)
        Me.MetroShell1.Controls.Add(Me.MetroTabPanel3)
        Me.MetroShell1.Controls.Add(Me.MetroTabPanel2)
        Me.MetroShell1.Controls.Add(Me.MetroTabPanel1)
        Me.MetroShell1.Dock = System.Windows.Forms.DockStyle.Top
        Me.MetroShell1.ForeColor = System.Drawing.Color.Black
        Me.MetroShell1.HelpButtonText = Nothing
        Me.MetroShell1.HelpButtonVisible = False
        Me.MetroShell1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.mnuVer, Me.mnuAdmon, Me.mnuProducto, Me.mnuSistema})
        Me.MetroShell1.KeyTipsFont = New System.Drawing.Font("Tahoma", 7.0!)
        Me.MetroShell1.Location = New System.Drawing.Point(0, 1)
        Me.MetroShell1.Name = "MetroShell1"
        Me.MetroShell1.QuickToolbarItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.lbTitulo, Me.QatCustomizeItem1})
        Me.MetroShell1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MetroShell1.SettingsButtonText = "OPCIONES"
        Me.MetroShell1.SettingsButtonVisible = False
        Me.MetroShell1.Size = New System.Drawing.Size(687, 126)
        Me.MetroShell1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon"
        Me.MetroShell1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon"
        Me.MetroShell1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar"
        Me.MetroShell1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>"
        Me.MetroShell1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar..."
        Me.MetroShell1.SystemText.QatDialogAddButton = "&Add >>"
        Me.MetroShell1.SystemText.QatDialogCancelButton = "Cancel"
        Me.MetroShell1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar"
        Me.MetroShell1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:"
        Me.MetroShell1.SystemText.QatDialogOkButton = "OK"
        Me.MetroShell1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon"
        Me.MetroShell1.SystemText.QatDialogRemoveButton = "&Remove"
        Me.MetroShell1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon"
        Me.MetroShell1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon"
        Me.MetroShell1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar"
        Me.MetroShell1.TabIndex = 0
        Me.MetroShell1.TabStripFont = New System.Drawing.Font("Segoe UI", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetroShell1.Text = "MetroShell1"
        '
        'MetroTabPanel3
        '
        Me.MetroTabPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.MetroTabPanel3.Controls.Add(Me.bt)
        Me.MetroTabPanel3.Controls.Add(Me.bt_puesto)
        Me.MetroTabPanel3.Controls.Add(Me.btNuevoLugar)
        Me.MetroTabPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTabPanel3.Location = New System.Drawing.Point(0, 51)
        Me.MetroTabPanel3.Name = "MetroTabPanel3"
        Me.MetroTabPanel3.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.MetroTabPanel3.Size = New System.Drawing.Size(687, 75)
        '
        '
        '
        Me.MetroTabPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.MetroTabPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.MetroTabPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTabPanel3.TabIndex = 4
        Me.MetroTabPanel3.ThemeAware = True
        Me.MetroTabPanel3.Visible = False
        '
        'MetroTabPanel2
        '
        Me.MetroTabPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.MetroTabPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTabPanel2.Location = New System.Drawing.Point(0, 51)
        Me.MetroTabPanel2.Name = "MetroTabPanel2"
        Me.MetroTabPanel2.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.MetroTabPanel2.Size = New System.Drawing.Size(687, 69)
        '
        '
        '
        Me.MetroTabPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.MetroTabPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.MetroTabPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTabPanel2.TabIndex = 2
        Me.MetroTabPanel2.ThemeAware = True
        Me.MetroTabPanel2.Visible = False
        '
        'MetroTabPanel1
        '
        Me.MetroTabPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.MetroTabPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTabPanel1.Location = New System.Drawing.Point(0, 57)
        Me.MetroTabPanel1.Name = "MetroTabPanel1"
        Me.MetroTabPanel1.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.MetroTabPanel1.Size = New System.Drawing.Size(973, 63)
        '
        '
        '
        Me.MetroTabPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.MetroTabPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.MetroTabPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTabPanel1.TabIndex = 3
        Me.MetroTabPanel1.Visible = False
        '
        'mnuVer
        '
        Me.mnuVer.Name = "mnuVer"
        Me.mnuVer.Panel = Me.MetroTabPanel2
        Me.mnuVer.Text = "&CONSULTAR"
        '
        'mnuAdmon
        '
        Me.mnuAdmon.Name = "mnuAdmon"
        Me.mnuAdmon.Panel = Me.MetroTabPanel1
        '
        'mnuSistema
        '
        Me.mnuSistema.Name = "mnuSistema"
        Me.mnuSistema.Panel = Me.MetroTabPanel3
        Me.mnuSistema.Text = "SISTEMA"
        '
        'lbTitulo
        '
        Me.lbTitulo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitulo.Name = "lbTitulo"
        Me.lbTitulo.Width = 120
        '
        'QatCustomizeItem1
        '
        Me.QatCustomizeItem1.BeginGroup = True
        Me.QatCustomizeItem1.Name = "QatCustomizeItem1"
        '
        'StatusBar
        '
        Me.StatusBar.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.StatusBar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.StatusBar.ContainerControlProcessDialogKey = True
        Me.StatusBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.StatusBar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusBar.ForeColor = System.Drawing.Color.Black
        Me.StatusBar.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.lbEstado})
        Me.StatusBar.Location = New System.Drawing.Point(0, 424)
        Me.StatusBar.Name = "StatusBar"
        Me.StatusBar.Size = New System.Drawing.Size(687, 30)
        Me.StatusBar.TabIndex = 1
        Me.StatusBar.Text = "MetroStatusBar1"
        '
        'lbEstado
        '
        Me.lbEstado.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEstado.Name = "lbEstado"
        Me.lbEstado.Text = "Listo"
        '
        'MicroChartItem1
        '
        Me.MicroChartItem1.Name = "MicroChartItem1"
        '
        'Timer
        '
        '
        'ButtonItem3
        '
        Me.ButtonItem3.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem3.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue
        Me.ButtonItem3.ImagePaddingHorizontal = 18
        Me.ButtonItem3.ImagePaddingVertical = 10
        Me.ButtonItem3.KeyTips = "O"
        Me.ButtonItem3.Name = "ButtonItem3"
        Me.ButtonItem3.Stretch = True
        Me.ButtonItem3.Text = "Open"
        '
        'ButtonItem4
        '
        Me.ButtonItem4.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem4.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue
        Me.ButtonItem4.ImagePaddingHorizontal = 18
        Me.ButtonItem4.ImagePaddingVertical = 10
        Me.ButtonItem4.KeyTips = "C"
        Me.ButtonItem4.Name = "ButtonItem4"
        Me.ButtonItem4.Stretch = True
        Me.ButtonItem4.Text = "Close"
        '
        'ButtonItem5
        '
        Me.ButtonItem5.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem5.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue
        Me.ButtonItem5.ImagePaddingHorizontal = 18
        Me.ButtonItem5.ImagePaddingVertical = 10
        Me.ButtonItem5.KeyTips = "T"
        Me.ButtonItem5.Name = "ButtonItem5"
        Me.ButtonItem5.Stretch = True
        Me.ButtonItem5.Text = "Options"
        '
        'ButtonItem6
        '
        Me.ButtonItem6.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem6.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue
        Me.ButtonItem6.ImagePaddingHorizontal = 18
        Me.ButtonItem6.ImagePaddingVertical = 10
        Me.ButtonItem6.KeyTips = "X"
        Me.ButtonItem6.Name = "ButtonItem6"
        Me.ButtonItem6.Stretch = True
        Me.ButtonItem6.Text = "Exit"
        '
        'ButtonItem2
        '
        Me.ButtonItem2.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem2.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue
        Me.ButtonItem2.ImagePaddingHorizontal = 18
        Me.ButtonItem2.ImagePaddingVertical = 10
        Me.ButtonItem2.KeyTips = "S"
        Me.ButtonItem2.Name = "ButtonItem2"
        Me.ButtonItem2.Stretch = True
        Me.ButtonItem2.Text = "Save"
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.BottomToolStripPanel
        '
        Me.ToolStripContainer1.BottomToolStripPanel.BackColor = System.Drawing.Color.White
        Me.ToolStripContainer1.BottomToolStripPanel.ForeColor = System.Drawing.Color.Black
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.tpMain)
        Me.ToolStripContainer1.ContentPanel.ForeColor = System.Drawing.Color.Black
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(687, 297)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        '
        'ToolStripContainer1.LeftToolStripPanel
        '
        Me.ToolStripContainer1.LeftToolStripPanel.BackColor = System.Drawing.Color.White
        Me.ToolStripContainer1.LeftToolStripPanel.ForeColor = System.Drawing.Color.Black
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 127)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        '
        'ToolStripContainer1.RightToolStripPanel
        '
        Me.ToolStripContainer1.RightToolStripPanel.BackColor = System.Drawing.Color.White
        Me.ToolStripContainer1.RightToolStripPanel.ForeColor = System.Drawing.Color.Black
        Me.ToolStripContainer1.Size = New System.Drawing.Size(687, 297)
        Me.ToolStripContainer1.TabIndex = 2
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.BackColor = System.Drawing.Color.White
        Me.ToolStripContainer1.TopToolStripPanel.ForeColor = System.Drawing.Color.Black
        '
        'mnuINICIO
        '
        Me.mnuINICIO.AutoExpandOnClick = True
        Me.mnuINICIO.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.mnuINICIO.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.mnuINICIO.ImagePaddingHorizontal = 0
        Me.mnuINICIO.ImagePaddingVertical = 0
        Me.mnuINICIO.Name = "mnuINICIO"
        Me.mnuINICIO.PopupWidth = 300
        Me.mnuINICIO.ShowSubItems = False
        Me.mnuINICIO.Text = "&INICIO"
        '
        'mnuProducto
        '
        Me.mnuProducto.Checked = True
        Me.mnuProducto.Name = "mnuProducto"
        Me.mnuProducto.Panel = Me.MetroTabPanel4
        Me.mnuProducto.Text = "PRODUCTOS"
        '
        'MetroTabPanel4
        '
        Me.MetroTabPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.MetroTabPanel4.Controls.Add(Me.ButtonX2)
        Me.MetroTabPanel4.Controls.Add(Me.ButtonX1)
        Me.MetroTabPanel4.Controls.Add(Me.mnuPRMarca)
        Me.MetroTabPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTabPanel4.Location = New System.Drawing.Point(0, 51)
        Me.MetroTabPanel4.Name = "MetroTabPanel4"
        Me.MetroTabPanel4.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.MetroTabPanel4.Size = New System.Drawing.Size(687, 75)
        '
        '
        '
        Me.MetroTabPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.MetroTabPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.MetroTabPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTabPanel4.TabIndex = 5
        Me.MetroTabPanel4.ThemeAware = True
        '
        'tpMain
        '
        Me.tpMain.AutoCloseTabs = True
        Me.tpMain.BackColor = System.Drawing.Color.White
        Me.tpMain.CanReorderTabs = True
        Me.tpMain.CloseButtonOnTabsVisible = True
        Me.tpMain.CloseButtonPosition = DevComponents.DotNetBar.eTabCloseButtonPosition.Right
        Me.tpMain.CloseButtonVisible = True
        Me.tpMain.Controls.Add(Me.TabControlPanel1)
        Me.tpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tpMain.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tpMain.ForeColor = System.Drawing.Color.Black
        Me.tpMain.Location = New System.Drawing.Point(0, 0)
        Me.tpMain.Name = "tpMain"
        Me.tpMain.SelectedTabFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tpMain.SelectedTabIndex = 0
        Me.tpMain.Size = New System.Drawing.Size(687, 297)
        Me.tpMain.Style = DevComponents.DotNetBar.eTabStripStyle.Metro
        Me.tpMain.TabCloseButtonHot = Global.POS.My.Resources.Resources.close16
        Me.tpMain.TabCloseButtonNormal = Global.POS.My.Resources.Resources.close16
        Me.tpMain.TabIndex = 0
        Me.tpMain.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.tpMain.Tabs.Add(Me.INICIO)
        Me.tpMain.Text = "INICIO"
        Me.tpMain.ThemeAware = True
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 33)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(687, 264)
        Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.White
        Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel1.Style.GradientAngle = 90
        Me.TabControlPanel1.TabIndex = 1
        Me.TabControlPanel1.TabItem = Me.INICIO
        '
        'INICIO
        '
        Me.INICIO.AttachedControl = Me.TabControlPanel1
        Me.INICIO.Name = "INICIO"
        Me.INICIO.Text = "INICIO"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.ButtonX1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.Image = Global.POS.My.Resources.Resources.boxes
        Me.ButtonX1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonX1.Location = New System.Drawing.Point(90, 3)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(75, 66)
        Me.ButtonX1.TabIndex = 5
        Me.ButtonX1.Text = "Modelos"
        '
        'mnuPRMarca
        '
        Me.mnuPRMarca.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.mnuPRMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.mnuPRMarca.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.mnuPRMarca.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuPRMarca.Image = Global.POS.My.Resources.Resources.box
        Me.mnuPRMarca.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.mnuPRMarca.Location = New System.Drawing.Point(9, 3)
        Me.mnuPRMarca.Name = "mnuPRMarca"
        Me.mnuPRMarca.Size = New System.Drawing.Size(75, 66)
        Me.mnuPRMarca.TabIndex = 4
        Me.mnuPRMarca.Text = "Marcas"
        '
        'bt
        '
        Me.bt.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bt.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.bt.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt.Image = Global.POS.My.Resources.Resources.management1
        Me.bt.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.bt.Location = New System.Drawing.Point(168, 3)
        Me.bt.Name = "bt"
        Me.bt.Size = New System.Drawing.Size(75, 66)
        Me.bt.TabIndex = 3
        Me.bt.Text = "Empleados"
        '
        'bt_puesto
        '
        Me.bt_puesto.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown
        Me.bt_puesto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bt_puesto.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.bt_puesto.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_puesto.Image = Global.POS.My.Resources.Resources.briefcase
        Me.bt_puesto.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.bt_puesto.Location = New System.Drawing.Point(87, 3)
        Me.bt_puesto.Name = "bt_puesto"
        Me.bt_puesto.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2)
        Me.bt_puesto.Size = New System.Drawing.Size(75, 66)
        Me.bt_puesto.TabIndex = 2
        Me.bt_puesto.Text = "Puestos"
        '
        'btNuevoLugar
        '
        Me.btNuevoLugar.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown
        Me.btNuevoLugar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btNuevoLugar.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btNuevoLugar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btNuevoLugar.Image = Global.POS.My.Resources.Resources.home
        Me.btNuevoLugar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btNuevoLugar.Location = New System.Drawing.Point(6, 3)
        Me.btNuevoLugar.Name = "btNuevoLugar"
        Me.btNuevoLugar.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2)
        Me.btNuevoLugar.Size = New System.Drawing.Size(75, 66)
        Me.btNuevoLugar.TabIndex = 1
        Me.btNuevoLugar.Text = "Lugares"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.ButtonX2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX2.Image = Global.POS.My.Resources.Resources.boxes
        Me.ButtonX2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonX2.Location = New System.Drawing.Point(171, 3)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(75, 66)
        Me.ButtonX2.TabIndex = 6
        Me.ButtonX2.Text = "Categoria"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(688, 455)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Controls.Add(Me.StatusBar)
        Me.Controls.Add(Me.MetroShell1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Punto de venta :: AGENCIAS EL ANGEL"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MetroShell1.ResumeLayout(False)
        Me.MetroShell1.PerformLayout()
        Me.MetroTabPanel3.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.MetroTabPanel4.ResumeLayout(False)
        CType(Me.tpMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MetroShell1 As DevComponents.DotNetBar.Metro.MetroShell
    Friend WithEvents MetroTabPanel2 As DevComponents.DotNetBar.Metro.MetroTabPanel
    Friend WithEvents mnuVer As DevComponents.DotNetBar.Metro.MetroTabItem
    Friend WithEvents QatCustomizeItem1 As DevComponents.DotNetBar.QatCustomizeItem
    Friend WithEvents StatusBar As DevComponents.DotNetBar.Metro.MetroStatusBar
    Friend WithEvents lbEstado As DevComponents.DotNetBar.LabelItem
    Friend WithEvents MicroChartItem1 As DevComponents.DotNetBar.MicroChartItem
    Friend WithEvents MetroTabPanel1 As DevComponents.DotNetBar.Metro.MetroTabPanel
    Friend WithEvents mnuAdmon As DevComponents.DotNetBar.Metro.MetroTabItem
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents lbTitulo As DevComponents.DotNetBar.LabelItem
    Friend WithEvents ButtonItem3 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem4 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem5 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem6 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents MetroTabPanel3 As DevComponents.DotNetBar.Metro.MetroTabPanel
    Friend WithEvents mnuSistema As DevComponents.DotNetBar.Metro.MetroTabItem
    Friend WithEvents btNuevoLugar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents bt_puesto As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents tpMain As DevComponents.DotNetBar.TabControl
    Friend WithEvents mnuINICIO As DevComponents.DotNetBar.Metro.MetroAppButton
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents INICIO As DevComponents.DotNetBar.TabItem
    Friend WithEvents bt As DevComponents.DotNetBar.ButtonX
    Friend WithEvents MetroTabPanel4 As DevComponents.DotNetBar.Metro.MetroTabPanel
    Friend WithEvents mnuProducto As DevComponents.DotNetBar.Metro.MetroTabItem
    Friend WithEvents mnuPRMarca As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX

End Class

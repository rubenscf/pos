<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlNuevoCliente
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txTel2 = New DevComponents.DotNetBar.Controls.MaskedTextBoxAdv()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txTel1 = New DevComponents.DotNetBar.Controls.MaskedTextBoxAdv()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txTel = New DevComponents.DotNetBar.Controls.MaskedTextBoxAdv()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txNacional = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txDireccion = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txNit = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txExtendido = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cbSexo = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txfechanac = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txApellido = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txNombre = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txDPI = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txBienes = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txConyugue = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ReflectionLabel1 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txEDire = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txETel = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txIngreso = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txPuesto = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbEmpresa = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Contacto = New System.Windows.Forms.GroupBox()
        Me.btGuardar = New DevComponents.DotNetBar.ButtonX()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txfechanac, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Contacto.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txTel2)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txTel1)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txTel)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txNacional)
        Me.GroupBox1.Controls.Add(Me.txDireccion)
        Me.GroupBox1.Controls.Add(Me.txNit)
        Me.GroupBox1.Controls.Add(Me.txExtendido)
        Me.GroupBox1.Controls.Add(Me.cbSexo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txfechanac)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txApellido)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txNombre)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txDPI)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(424, 367)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos personales"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(8, 292)
        Me.Label16.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(77, 21)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "Telefonos"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txTel2
        '
        '
        '
        '
        Me.txTel2.BackgroundStyle.Class = "TextBoxBorder"
        Me.txTel2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txTel2.ButtonClear.Visible = True
        Me.txTel2.Location = New System.Drawing.Point(256, 318)
        Me.txTel2.Mask = "00000000"
        Me.txTel2.Name = "txTel2"
        Me.txTel2.Size = New System.Drawing.Size(116, 28)
        Me.txTel2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.txTel2.TabIndex = 11
        Me.txTel2.Text = ""
        Me.txTel2.WatermarkText = "Telefono"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(8, 226)
        Me.Label15.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 21)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Domicilio"
        '
        'txTel1
        '
        '
        '
        '
        Me.txTel1.BackgroundStyle.Class = "TextBoxBorder"
        Me.txTel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txTel1.ButtonClear.Visible = True
        Me.txTel1.Location = New System.Drawing.Point(134, 318)
        Me.txTel1.Mask = "00000000"
        Me.txTel1.Name = "txTel1"
        Me.txTel1.Size = New System.Drawing.Size(116, 28)
        Me.txTel1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.txTel1.TabIndex = 10
        Me.txTel1.Text = ""
        Me.txTel1.WatermarkText = "Telefono"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(280, 28)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(34, 21)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "NIT"
        '
        'txTel
        '
        '
        '
        '
        Me.txTel.BackgroundStyle.Class = "TextBoxBorder"
        Me.txTel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txTel.ButtonClear.Visible = True
        Me.txTel.Location = New System.Drawing.Point(12, 318)
        Me.txTel.Mask = "00000000"
        Me.txTel.Name = "txTel"
        Me.txTel.Size = New System.Drawing.Size(116, 28)
        Me.txTel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.txTel.TabIndex = 9
        Me.txTel.Text = ""
        Me.txTel.WatermarkText = "Telefono"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(286, 161)
        Me.Label12.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(101, 21)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Nacionalidad"
        '
        'txNacional
        '
        Me.txNacional.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txNacional.Border.Class = "TextBoxBorder"
        Me.txNacional.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txNacional.ForeColor = System.Drawing.Color.Black
        Me.txNacional.Location = New System.Drawing.Point(284, 185)
        Me.txNacional.Name = "txNacional"
        Me.txNacional.Size = New System.Drawing.Size(122, 29)
        Me.txNacional.TabIndex = 7
        Me.txNacional.Text = "Guatemalteco"
        Me.txNacional.WatermarkText = "Nacionalidad"
        '
        'txDireccion
        '
        Me.txDireccion.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txDireccion.Border.Class = "TextBoxBorder"
        Me.txDireccion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txDireccion.ForeColor = System.Drawing.Color.Black
        Me.txDireccion.Location = New System.Drawing.Point(11, 250)
        Me.txDireccion.Name = "txDireccion"
        Me.txDireccion.Size = New System.Drawing.Size(395, 29)
        Me.txDireccion.TabIndex = 8
        Me.txDireccion.WatermarkText = "Dirección"
        '
        'txNit
        '
        Me.txNit.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txNit.Border.Class = "TextBoxBorder"
        Me.txNit.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txNit.ForeColor = System.Drawing.Color.Black
        Me.txNit.Location = New System.Drawing.Point(285, 52)
        Me.txNit.Name = "txNit"
        Me.txNit.Size = New System.Drawing.Size(121, 29)
        Me.txNit.TabIndex = 2
        Me.txNit.WatermarkText = "Nit"
        '
        'txExtendido
        '
        Me.txExtendido.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txExtendido.Border.Class = "TextBoxBorder"
        Me.txExtendido.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txExtendido.ForeColor = System.Drawing.Color.Black
        Me.txExtendido.Location = New System.Drawing.Point(138, 52)
        Me.txExtendido.Name = "txExtendido"
        Me.txExtendido.Size = New System.Drawing.Size(141, 29)
        Me.txExtendido.TabIndex = 1
        Me.txExtendido.WatermarkText = "Extendido"
        '
        'cbSexo
        '
        Me.cbSexo.DisplayMember = "Text"
        Me.cbSexo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbSexo.FormattingEnabled = True
        Me.cbSexo.ItemHeight = 23
        Me.cbSexo.Items.AddRange(New Object() {Me.ComboItem2, Me.ComboItem3})
        Me.cbSexo.Location = New System.Drawing.Point(167, 185)
        Me.cbSexo.Name = "cbSexo"
        Me.cbSexo.Size = New System.Drawing.Size(111, 29)
        Me.cbSexo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbSexo.TabIndex = 6
        Me.cbSexo.WatermarkText = "Seleccione Sexo"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "M"
        Me.ComboItem2.Value = "M"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "F"
        Me.ComboItem3.Value = "F"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(167, 161)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 21)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Sexo"
        '
        'txfechanac
        '
        '
        '
        '
        Me.txfechanac.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txfechanac.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txfechanac.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.txfechanac.ButtonDropDown.Visible = True
        Me.txfechanac.IsPopupCalendarOpen = False
        Me.txfechanac.Location = New System.Drawing.Point(11, 185)
        Me.txfechanac.MinDate = New Date(1940, 1, 1, 0, 0, 0, 0)
        '
        '
        '
        Me.txfechanac.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.txfechanac.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txfechanac.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.txfechanac.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.txfechanac.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.txfechanac.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.txfechanac.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.txfechanac.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txfechanac.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.txfechanac.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.txfechanac.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txfechanac.MonthCalendar.DisplayMonth = New Date(2013, 9, 1, 0, 0, 0, 0)
        Me.txfechanac.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.txfechanac.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.txfechanac.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.txfechanac.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.txfechanac.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.txfechanac.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.txfechanac.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txfechanac.MonthCalendar.TodayButtonVisible = True
        Me.txfechanac.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.txfechanac.Name = "txfechanac"
        Me.txfechanac.Size = New System.Drawing.Size(150, 29)
        Me.txfechanac.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.txfechanac.TabIndex = 5
        Me.txfechanac.WatermarkText = "Fecha nacimiento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 161)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 21)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Fecha de Nacimiento"
        '
        'txApellido
        '
        Me.txApellido.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txApellido.Border.Class = "TextBoxBorder"
        Me.txApellido.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txApellido.ForeColor = System.Drawing.Color.Black
        Me.txApellido.Location = New System.Drawing.Point(211, 118)
        Me.txApellido.Name = "txApellido"
        Me.txApellido.Size = New System.Drawing.Size(195, 29)
        Me.txApellido.TabIndex = 4
        Me.txApellido.WatermarkText = "Apellido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 94)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 21)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Nombre"
        '
        'txNombre
        '
        Me.txNombre.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txNombre.Border.Class = "TextBoxBorder"
        Me.txNombre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txNombre.ForeColor = System.Drawing.Color.Black
        Me.txNombre.Location = New System.Drawing.Point(11, 119)
        Me.txNombre.Name = "txNombre"
        Me.txNombre.Size = New System.Drawing.Size(193, 29)
        Me.txNombre.TabIndex = 3
        Me.txNombre.WatermarkText = "Nombre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 21)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Identificacion:"
        '
        'txDPI
        '
        Me.txDPI.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txDPI.Border.Class = "TextBoxBorder"
        Me.txDPI.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txDPI.ForeColor = System.Drawing.Color.Black
        Me.txDPI.Location = New System.Drawing.Point(11, 52)
        Me.txDPI.Name = "txDPI"
        Me.txDPI.Size = New System.Drawing.Size(121, 29)
        Me.txDPI.TabIndex = 0
        Me.txDPI.WatermarkText = "DPI"
        '
        'txBienes
        '
        Me.txBienes.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txBienes.Border.Class = "TextBoxBorder"
        Me.txBienes.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txBienes.ForeColor = System.Drawing.Color.Black
        Me.txBienes.Location = New System.Drawing.Point(17, 86)
        Me.txBienes.Name = "txBienes"
        Me.txBienes.Size = New System.Drawing.Size(289, 29)
        Me.txBienes.TabIndex = 1
        Me.txBienes.WatermarkText = "Bienes"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 62)
        Me.Label9.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 21)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Bienes Propios:"
        '
        'txConyugue
        '
        Me.txConyugue.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txConyugue.Border.Class = "TextBoxBorder"
        Me.txConyugue.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txConyugue.ForeColor = System.Drawing.Color.Black
        Me.txConyugue.Location = New System.Drawing.Point(17, 28)
        Me.txConyugue.Name = "txConyugue"
        Me.txConyugue.Size = New System.Drawing.Size(289, 29)
        Me.txConyugue.TabIndex = 0
        Me.txConyugue.WatermarkText = "Conyugue"
        '
        'ReflectionLabel1
        '
        '
        '
        '
        Me.ReflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel1.Font = New System.Drawing.Font("Segoe UI Light", 16.25!)
        Me.ReflectionLabel1.Location = New System.Drawing.Point(15, 5)
        Me.ReflectionLabel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ReflectionLabel1.Name = "ReflectionLabel1"
        Me.ReflectionLabel1.ReflectionEnabled = False
        Me.ReflectionLabel1.Size = New System.Drawing.Size(306, 44)
        Me.ReflectionLabel1.TabIndex = 27
        Me.ReflectionLabel1.Text = "<font size=""+6"">Ingresar <font color=""#32b8ff""> cliente</font></font>"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txEDire)
        Me.GroupBox2.Controls.Add(Me.txETel)
        Me.GroupBox2.Controls.Add(Me.txIngreso)
        Me.GroupBox2.Controls.Add(Me.txPuesto)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.cbEmpresa)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(463, 57)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(320, 225)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Laborales"
        '
        'txEDire
        '
        Me.txEDire.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txEDire.Border.Class = "TextBoxBorder"
        Me.txEDire.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txEDire.ForeColor = System.Drawing.Color.Black
        Me.txEDire.Location = New System.Drawing.Point(104, 119)
        Me.txEDire.Name = "txEDire"
        Me.txEDire.Size = New System.Drawing.Size(202, 29)
        Me.txEDire.TabIndex = 2
        Me.txEDire.WatermarkText = "Dirección"
        '
        'txETel
        '
        Me.txETel.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txETel.Border.Class = "TextBoxBorder"
        Me.txETel.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txETel.ForeColor = System.Drawing.Color.Black
        Me.txETel.Location = New System.Drawing.Point(17, 118)
        Me.txETel.MaxLength = 8
        Me.txETel.Name = "txETel"
        Me.txETel.Size = New System.Drawing.Size(83, 29)
        Me.txETel.TabIndex = 1
        Me.txETel.WatermarkText = "Telefono"
        '
        'txIngreso
        '
        Me.txIngreso.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txIngreso.Border.Class = "TextBoxBorder"
        Me.txIngreso.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txIngreso.ForeColor = System.Drawing.Color.Black
        Me.txIngreso.Location = New System.Drawing.Point(17, 185)
        Me.txIngreso.Name = "txIngreso"
        Me.txIngreso.Size = New System.Drawing.Size(80, 29)
        Me.txIngreso.TabIndex = 3
        Me.txIngreso.WatermarkText = "Salario"
        '
        'txPuesto
        '
        Me.txPuesto.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txPuesto.Border.Class = "TextBoxBorder"
        Me.txPuesto.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txPuesto.ForeColor = System.Drawing.Color.Black
        Me.txPuesto.Location = New System.Drawing.Point(104, 185)
        Me.txPuesto.Name = "txPuesto"
        Me.txPuesto.Size = New System.Drawing.Size(202, 29)
        Me.txPuesto.TabIndex = 4
        Me.txPuesto.WatermarkText = "Puesto que desempeña"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(100, 161)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 21)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Puesto:"
        '
        'cbEmpresa
        '
        Me.cbEmpresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbEmpresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbEmpresa.DisplayMember = "Text"
        Me.cbEmpresa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbEmpresa.FormattingEnabled = True
        Me.cbEmpresa.ItemHeight = 23
        Me.cbEmpresa.Location = New System.Drawing.Point(17, 52)
        Me.cbEmpresa.Name = "cbEmpresa"
        Me.cbEmpresa.Size = New System.Drawing.Size(289, 29)
        Me.cbEmpresa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbEmpresa.TabIndex = 0
        Me.cbEmpresa.WatermarkText = "Seleccione Area"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(135, 21)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Nombre Empresa:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 161)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 21)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Ingresos:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 21)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Telefono:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(100, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 21)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Direccion:"
        '
        'Contacto
        '
        Me.Contacto.Controls.Add(Me.txBienes)
        Me.Contacto.Controls.Add(Me.Label9)
        Me.Contacto.Controls.Add(Me.txConyugue)
        Me.Contacto.Location = New System.Drawing.Point(463, 288)
        Me.Contacto.Name = "Contacto"
        Me.Contacto.Size = New System.Drawing.Size(320, 136)
        Me.Contacto.TabIndex = 2
        Me.Contacto.TabStop = False
        Me.Contacto.Text = "Conyugue"
        '
        'btGuardar
        '
        Me.btGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btGuardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btGuardar.Image = Global.POS.My.Resources.Resources.diskette
        Me.btGuardar.Location = New System.Drawing.Point(666, 436)
        Me.btGuardar.Name = "btGuardar"
        Me.btGuardar.Size = New System.Drawing.Size(117, 38)
        Me.btGuardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btGuardar.TabIndex = 2
        Me.btGuardar.Text = "Guardar"
        '
        'ctrlNuevoCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.Controls.Add(Me.Contacto)
        Me.Controls.Add(Me.btGuardar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ReflectionLabel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ctrlNuevoCliente"
        Me.Size = New System.Drawing.Size(811, 493)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txfechanac, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Contacto.ResumeLayout(False)
        Me.Contacto.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txApellido As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txNombre As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txDPI As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ReflectionLabel1 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txConyugue As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txTel As DevComponents.DotNetBar.Controls.MaskedTextBoxAdv
    Friend WithEvents txDireccion As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txfechanac As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents txNit As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txExtendido As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cbSexo As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btGuardar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cbEmpresa As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txETel As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txIngreso As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txPuesto As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txNacional As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txEDire As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txBienes As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Contacto As System.Windows.Forms.GroupBox
    Friend WithEvents txTel2 As DevComponents.DotNetBar.Controls.MaskedTextBoxAdv
    Friend WithEvents txTel1 As DevComponents.DotNetBar.Controls.MaskedTextBoxAdv
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label

End Class

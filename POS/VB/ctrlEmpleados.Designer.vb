<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlEmpleados
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
        Me.txNit = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txExtendido = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cbSexo = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txfechanac = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txConyugue = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txTel = New DevComponents.DotNetBar.Controls.MaskedTextBoxAdv()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txDireccion = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txApellido = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txNombre = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txDPI = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ReflectionLabel1 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbArea = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txSueldo = New DevComponents.DotNetBar.Controls.MaskedTextBoxAdv()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbPuesto = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cbLugar = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Sistema = New System.Windows.Forms.GroupBox()
        Me.txPass = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txUsuario = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btGuardar = New DevComponents.DotNetBar.ButtonX()
        Me.imgBuscar = New System.Windows.Forms.PictureBox()
        Me.cbEmpleado = New System.Windows.Forms.ComboBox()
        Me.swBt = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txfechanac, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Sistema.SuspendLayout()
        CType(Me.imgBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txNit)
        Me.GroupBox1.Controls.Add(Me.txExtendido)
        Me.GroupBox1.Controls.Add(Me.cbSexo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txfechanac)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txConyugue)
        Me.GroupBox1.Controls.Add(Me.txTel)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txDireccion)
        Me.GroupBox1.Controls.Add(Me.txApellido)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txNombre)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txDPI)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(424, 367)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos personales"
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
        Me.txNit.TabIndex = 18
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
        Me.txExtendido.TabIndex = 17
        Me.txExtendido.WatermarkText = "Extendido"
        '
        'cbSexo
        '
        Me.cbSexo.DisplayMember = "Text"
        Me.cbSexo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbSexo.FormattingEnabled = True
        Me.cbSexo.ItemHeight = 23
        Me.cbSexo.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2, Me.ComboItem3})
        Me.cbSexo.Location = New System.Drawing.Point(214, 119)
        Me.cbSexo.Name = "cbSexo"
        Me.cbSexo.Size = New System.Drawing.Size(192, 29)
        Me.cbSexo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbSexo.TabIndex = 16
        Me.cbSexo.WatermarkText = "Seleccione Sexo"
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "Seleccione"
        Me.ComboItem1.Value = "n"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "Masculino"
        Me.ComboItem2.Value = "M"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "Femenino"
        Me.ComboItem3.Value = "F"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(210, 94)
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
        Me.txfechanac.Location = New System.Drawing.Point(12, 118)
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
        Me.txfechanac.Size = New System.Drawing.Size(192, 29)
        Me.txfechanac.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.txfechanac.TabIndex = 14
        Me.txfechanac.WatermarkText = "Fecha de nacimiento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 94)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 21)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Fecha de Nacimiento"
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
        Me.txConyugue.Location = New System.Drawing.Point(12, 219)
        Me.txConyugue.Name = "txConyugue"
        Me.txConyugue.Size = New System.Drawing.Size(394, 29)
        Me.txConyugue.TabIndex = 12
        Me.txConyugue.WatermarkText = "Conyugue"
        '
        'txTel
        '
        '
        '
        '
        Me.txTel.BackgroundStyle.Class = "TextBoxBorder"
        Me.txTel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txTel.ButtonClear.Visible = True
        Me.txTel.Location = New System.Drawing.Point(12, 320)
        Me.txTel.Mask = "00000000"
        Me.txTel.Name = "txTel"
        Me.txTel.Size = New System.Drawing.Size(195, 28)
        Me.txTel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.txTel.TabIndex = 11
        Me.txTel.Text = ""
        Me.txTel.WatermarkText = "Telefono"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 261)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 21)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Contacto"
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
        Me.txDireccion.Location = New System.Drawing.Point(12, 285)
        Me.txDireccion.Name = "txDireccion"
        Me.txDireccion.Size = New System.Drawing.Size(395, 29)
        Me.txDireccion.TabIndex = 8
        Me.txDireccion.WatermarkText = "Dirección"
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
        Me.txApellido.Location = New System.Drawing.Point(213, 184)
        Me.txApellido.Name = "txApellido"
        Me.txApellido.Size = New System.Drawing.Size(193, 29)
        Me.txApellido.TabIndex = 7
        Me.txApellido.WatermarkText = "Apellido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 160)
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
        Me.txNombre.Location = New System.Drawing.Point(11, 184)
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
        Me.txDPI.TabIndex = 1
        Me.txDPI.WatermarkText = "DPI"
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
        Me.ReflectionLabel1.Text = "<font size=""+6"">Crear o editar<font color=""#32b8ff""> empleado</font></font>"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbArea)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txSueldo)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.cbPuesto)
        Me.GroupBox2.Controls.Add(Me.cbLugar)
        Me.GroupBox2.Location = New System.Drawing.Point(463, 57)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(320, 225)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de la empresa"
        '
        'cbArea
        '
        Me.cbArea.DisplayMember = "Text"
        Me.cbArea.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbArea.FormattingEnabled = True
        Me.cbArea.ItemHeight = 23
        Me.cbArea.Location = New System.Drawing.Point(17, 52)
        Me.cbArea.Name = "cbArea"
        Me.cbArea.Size = New System.Drawing.Size(289, 29)
        Me.cbArea.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbArea.TabIndex = 24
        Me.cbArea.WatermarkText = "Seleccione Area"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 21)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Area:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(177, 160)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 21)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Sueldo Base:"
        '
        'txSueldo
        '
        '
        '
        '
        Me.txSueldo.BackgroundStyle.Class = "TextBoxBorder"
        Me.txSueldo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txSueldo.ButtonClear.Visible = True
        Me.txSueldo.Location = New System.Drawing.Point(181, 184)
        Me.txSueldo.Mask = "0000000,00"
        Me.txSueldo.Name = "txSueldo"
        Me.txSueldo.Size = New System.Drawing.Size(125, 28)
        Me.txSueldo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.txSueldo.TabIndex = 21
        Me.txSueldo.Text = ""
        Me.txSueldo.WatermarkText = "Sueldo Base"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 21)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Puesto:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 21)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Ubicacion:"
        '
        'cbPuesto
        '
        Me.cbPuesto.DisplayMember = "Text"
        Me.cbPuesto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbPuesto.FormattingEnabled = True
        Me.cbPuesto.ItemHeight = 23
        Me.cbPuesto.Location = New System.Drawing.Point(17, 184)
        Me.cbPuesto.Name = "cbPuesto"
        Me.cbPuesto.Size = New System.Drawing.Size(153, 29)
        Me.cbPuesto.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbPuesto.TabIndex = 1
        Me.cbPuesto.WatermarkText = "Seleccione Puesto"
        '
        'cbLugar
        '
        Me.cbLugar.DisplayMember = "Text"
        Me.cbLugar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbLugar.FormattingEnabled = True
        Me.cbLugar.ItemHeight = 23
        Me.cbLugar.Location = New System.Drawing.Point(17, 119)
        Me.cbLugar.Name = "cbLugar"
        Me.cbLugar.Size = New System.Drawing.Size(289, 29)
        Me.cbLugar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbLugar.TabIndex = 0
        Me.cbLugar.WatermarkText = "Seleccione Lugar"
        '
        'Sistema
        '
        Me.Sistema.Controls.Add(Me.txPass)
        Me.Sistema.Controls.Add(Me.txUsuario)
        Me.Sistema.Controls.Add(Me.Label9)
        Me.Sistema.Location = New System.Drawing.Point(463, 289)
        Me.Sistema.Name = "Sistema"
        Me.Sistema.Size = New System.Drawing.Size(320, 135)
        Me.Sistema.TabIndex = 30
        Me.Sistema.TabStop = False
        Me.Sistema.Text = "Sistema"
        '
        'txPass
        '
        Me.txPass.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txPass.Border.Class = "TextBoxBorder"
        Me.txPass.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txPass.ForeColor = System.Drawing.Color.Black
        Me.txPass.Location = New System.Drawing.Point(17, 87)
        Me.txPass.Name = "txPass"
        Me.txPass.Size = New System.Drawing.Size(289, 29)
        Me.txPass.TabIndex = 21
        Me.txPass.WatermarkText = "Contraseña"
        '
        'txUsuario
        '
        Me.txUsuario.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txUsuario.Border.Class = "TextBoxBorder"
        Me.txUsuario.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txUsuario.ForeColor = System.Drawing.Color.Black
        Me.txUsuario.Location = New System.Drawing.Point(17, 53)
        Me.txUsuario.Name = "txUsuario"
        Me.txUsuario.Size = New System.Drawing.Size(289, 29)
        Me.txUsuario.TabIndex = 20
        Me.txUsuario.WatermarkText = "Usuario"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 29)
        Me.Label9.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 21)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Credenciales"
        '
        'btGuardar
        '
        Me.btGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btGuardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btGuardar.Image = Global.POS.My.Resources.Resources.diskette
        Me.btGuardar.Location = New System.Drawing.Point(666, 430)
        Me.btGuardar.Name = "btGuardar"
        Me.btGuardar.Size = New System.Drawing.Size(117, 38)
        Me.btGuardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btGuardar.TabIndex = 32
        Me.btGuardar.Text = "Guardar"
        '
        'imgBuscar
        '
        Me.imgBuscar.Image = Global.POS.My.Resources.Resources.zoom
        Me.imgBuscar.Location = New System.Drawing.Point(463, 20)
        Me.imgBuscar.Name = "imgBuscar"
        Me.imgBuscar.Size = New System.Drawing.Size(32, 29)
        Me.imgBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgBuscar.TabIndex = 35
        Me.imgBuscar.TabStop = False
        Me.imgBuscar.Visible = False
        '
        'cbEmpleado
        '
        Me.cbEmpleado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbEmpleado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbEmpleado.FormattingEnabled = True
        Me.cbEmpleado.Location = New System.Drawing.Point(501, 20)
        Me.cbEmpleado.Name = "cbEmpleado"
        Me.cbEmpleado.Size = New System.Drawing.Size(197, 29)
        Me.cbEmpleado.TabIndex = 34
        Me.cbEmpleado.Visible = False
        '
        'swBt
        '
        '
        '
        '
        Me.swBt.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.swBt.Location = New System.Drawing.Point(704, 20)
        Me.swBt.Name = "swBt"
        Me.swBt.OffText = "Editar"
        Me.swBt.OnText = "Crear"
        Me.swBt.Size = New System.Drawing.Size(80, 29)
        Me.swBt.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.swBt.TabIndex = 33
        Me.swBt.Value = True
        Me.swBt.ValueObject = "Y"
        '
        'ctrlEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.Controls.Add(Me.imgBuscar)
        Me.Controls.Add(Me.cbEmpleado)
        Me.Controls.Add(Me.swBt)
        Me.Controls.Add(Me.btGuardar)
        Me.Controls.Add(Me.Sistema)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ReflectionLabel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ctrlEmpleados"
        Me.Size = New System.Drawing.Size(810, 487)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txfechanac, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Sistema.ResumeLayout(False)
        Me.Sistema.PerformLayout()
        CType(Me.imgBuscar, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txDireccion As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txfechanac As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents txNit As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txExtendido As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cbSexo As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbLugar As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txSueldo As DevComponents.DotNetBar.Controls.MaskedTextBoxAdv
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbPuesto As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Sistema As System.Windows.Forms.GroupBox
    Friend WithEvents txPass As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txUsuario As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btGuardar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cbArea As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents imgBuscar As System.Windows.Forms.PictureBox
    Friend WithEvents cbEmpleado As System.Windows.Forms.ComboBox
    Friend WithEvents swBt As DevComponents.DotNetBar.Controls.SwitchButton

End Class

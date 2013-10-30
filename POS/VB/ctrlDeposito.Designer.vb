<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlDeposito
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
        Me.ReflectionLabel2 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.txboleta = New System.Windows.Forms.TextBox()
        Me.txCantidad = New System.Windows.Forms.TextBox()
        Me.txBanco = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txfecha = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.btGuardar = New DevComponents.DotNetBar.ButtonX()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txfecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReflectionLabel2
        '
        Me.ReflectionLabel2.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.ReflectionLabel2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel2.Font = New System.Drawing.Font("Segoe UI Light", 16.25!)
        Me.ReflectionLabel2.Location = New System.Drawing.Point(23, 26)
        Me.ReflectionLabel2.Margin = New System.Windows.Forms.Padding(23, 26, 23, 26)
        Me.ReflectionLabel2.Name = "ReflectionLabel2"
        Me.ReflectionLabel2.ReflectionEnabled = False
        Me.ReflectionLabel2.Size = New System.Drawing.Size(297, 52)
        Me.ReflectionLabel2.TabIndex = 14
        Me.ReflectionLabel2.Text = "<font size=""+6"">Registrar<font color=""#32b8ff""> Depósitos</font></font>"
        '
        'txboleta
        '
        Me.txboleta.Location = New System.Drawing.Point(128, 92)
        Me.txboleta.Name = "txboleta"
        Me.txboleta.Size = New System.Drawing.Size(200, 25)
        Me.txboleta.TabIndex = 1
        '
        'txCantidad
        '
        Me.txCantidad.Location = New System.Drawing.Point(128, 175)
        Me.txCantidad.Name = "txCantidad"
        Me.txCantidad.Size = New System.Drawing.Size(200, 25)
        Me.txCantidad.TabIndex = 3
        '
        'txBanco
        '
        Me.txBanco.Location = New System.Drawing.Point(128, 134)
        Me.txBanco.Name = "txBanco"
        Me.txBanco.Size = New System.Drawing.Size(200, 25)
        Me.txBanco.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txfecha)
        Me.GroupBox1.Controls.Add(Me.btGuardar)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txboleta)
        Me.GroupBox1.Controls.Add(Me.txBanco)
        Me.GroupBox1.Controls.Add(Me.txCantidad)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 83)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(742, 300)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informacion del Depósito"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(41, 280)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(348, 17)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Verifique que los datos sean correctos antes de guardar..."
        '
        'txfecha
        '
        '
        '
        '
        Me.txfecha.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txfecha.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txfecha.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.txfecha.ButtonDropDown.Visible = True
        Me.txfecha.IsPopupCalendarOpen = False
        Me.txfecha.Location = New System.Drawing.Point(128, 47)
        Me.txfecha.MinDate = New Date(1940, 1, 1, 0, 0, 0, 0)
        '
        '
        '
        Me.txfecha.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.txfecha.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txfecha.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.txfecha.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.txfecha.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.txfecha.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.txfecha.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.txfecha.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txfecha.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.txfecha.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.txfecha.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txfecha.MonthCalendar.DisplayMonth = New Date(2013, 9, 1, 0, 0, 0, 0)
        Me.txfecha.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.txfecha.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.txfecha.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.txfecha.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.txfecha.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.txfecha.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.txfecha.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txfecha.MonthCalendar.TodayButtonVisible = True
        Me.txfecha.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.txfecha.Name = "txfecha"
        Me.txfecha.Size = New System.Drawing.Size(200, 25)
        Me.txfecha.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.txfecha.TabIndex = 0
        '
        'btGuardar
        '
        Me.btGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btGuardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btGuardar.Image = Global.POS.My.Resources.Resources.diskette
        Me.btGuardar.Location = New System.Drawing.Point(211, 218)
        Me.btGuardar.Name = "btGuardar"
        Me.btGuardar.Size = New System.Drawing.Size(117, 38)
        Me.btGuardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btGuardar.TabIndex = 4
        Me.btGuardar.Text = "Guardar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 17)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Fecha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 17)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Banco"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 17)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Cantidad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 17)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "No. Boleta"
        '
        'ctrlDeposito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ReflectionLabel2)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ctrlDeposito"
        Me.Size = New System.Drawing.Size(778, 399)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txfecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReflectionLabel2 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents txboleta As System.Windows.Forms.TextBox
    Friend WithEvents txCantidad As System.Windows.Forms.TextBox
    Friend WithEvents txBanco As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btGuardar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txfecha As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class

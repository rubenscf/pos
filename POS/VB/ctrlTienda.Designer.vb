<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlTienda
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
        Me.cbLugar = New System.Windows.Forms.ComboBox()
        Me.swBt = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.btGuardar = New DevComponents.DotNetBar.ButtonX()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txNombre = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txSerie = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.txTel2 = New DevComponents.DotNetBar.Controls.MaskedTextBoxAdv()
        Me.txTel1 = New DevComponents.DotNetBar.Controls.MaskedTextBoxAdv()
        Me.txDireccion = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.cbTipo = New System.Windows.Forms.ComboBox()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.ReflectionLabel1 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbLugar
        '
        Me.cbLugar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbLugar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbLugar.FormattingEnabled = True
        Me.cbLugar.Location = New System.Drawing.Point(306, 33)
        Me.cbLugar.Name = "cbLugar"
        Me.cbLugar.Size = New System.Drawing.Size(235, 29)
        Me.cbLugar.TabIndex = 11
        Me.cbLugar.Visible = False
        '
        'swBt
        '
        '
        '
        '
        Me.swBt.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.swBt.Location = New System.Drawing.Point(547, 33)
        Me.swBt.Name = "swBt"
        Me.swBt.OffText = "Editar"
        Me.swBt.OnText = "Crear"
        Me.swBt.Size = New System.Drawing.Size(80, 29)
        Me.swBt.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.swBt.TabIndex = 10
        Me.swBt.Value = True
        Me.swBt.ValueObject = "Y"
        '
        'btGuardar
        '
        Me.btGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btGuardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btGuardar.Image = Global.POS.My.Resources.Resources.save_26
        Me.btGuardar.Location = New System.Drawing.Point(510, 260)
        Me.btGuardar.Name = "btGuardar"
        Me.btGuardar.Size = New System.Drawing.Size(117, 38)
        Me.btGuardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btGuardar.TabIndex = 8
        Me.btGuardar.Text = "Guardar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txNombre)
        Me.GroupBox1.Controls.Add(Me.txSerie)
        Me.GroupBox1.Controls.Add(Me.LabelX6)
        Me.GroupBox1.Controls.Add(Me.LabelX5)
        Me.GroupBox1.Controls.Add(Me.LabelX4)
        Me.GroupBox1.Controls.Add(Me.txTel2)
        Me.GroupBox1.Controls.Add(Me.txTel1)
        Me.GroupBox1.Controls.Add(Me.txDireccion)
        Me.GroupBox1.Controls.Add(Me.LabelX3)
        Me.GroupBox1.Controls.Add(Me.LabelX2)
        Me.GroupBox1.Controls.Add(Me.cbTipo)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(598, 186)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
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
        Me.txNombre.Location = New System.Drawing.Point(323, 58)
        Me.txNombre.Name = "txNombre"
        Me.txNombre.Size = New System.Drawing.Size(257, 29)
        Me.txNombre.TabIndex = 3
        '
        'txSerie
        '
        Me.txSerie.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txSerie.Border.Class = "TextBoxBorder"
        Me.txSerie.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txSerie.ForeColor = System.Drawing.Color.Black
        Me.txSerie.Location = New System.Drawing.Point(200, 58)
        Me.txSerie.MaxLength = 3
        Me.txSerie.Name = "txSerie"
        Me.txSerie.Size = New System.Drawing.Size(100, 29)
        Me.txSerie.TabIndex = 2
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Location = New System.Drawing.Point(461, 105)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(86, 23)
        Me.LabelX6.TabIndex = 0
        Me.LabelX6.Text = "Telefono 2:"
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(323, 105)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(86, 23)
        Me.LabelX5.TabIndex = 11
        Me.LabelX5.Text = "Telefono 1:"
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(21, 105)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(75, 23)
        Me.LabelX4.TabIndex = 7
        Me.LabelX4.Text = "Direccion:"
        '
        'txTel2
        '
        '
        '
        '
        Me.txTel2.BackgroundStyle.Class = "TextBoxBorder"
        Me.txTel2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txTel2.ButtonClear.Visible = True
        Me.txTel2.Location = New System.Drawing.Point(461, 134)
        Me.txTel2.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
        Me.txTel2.Mask = "00000000"
        Me.txTel2.Name = "txTel2"
        Me.txTel2.Size = New System.Drawing.Size(119, 28)
        Me.txTel2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.txTel2.TabIndex = 6
        Me.txTel2.Text = ""
        '
        'txTel1
        '
        '
        '
        '
        Me.txTel1.BackgroundStyle.Class = "TextBoxBorder"
        Me.txTel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txTel1.ButtonClear.Visible = True
        Me.txTel1.Location = New System.Drawing.Point(323, 134)
        Me.txTel1.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
        Me.txTel1.Mask = "00000000"
        Me.txTel1.Name = "txTel1"
        Me.txTel1.Size = New System.Drawing.Size(119, 28)
        Me.txTel1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.txTel1.TabIndex = 5
        Me.txTel1.Text = ""
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
        Me.txDireccion.Location = New System.Drawing.Point(21, 134)
        Me.txDireccion.Name = "txDireccion"
        Me.txDireccion.Size = New System.Drawing.Size(289, 29)
        Me.txDireccion.TabIndex = 4
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(323, 29)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(110, 23)
        Me.LabelX3.TabIndex = 10
        Me.LabelX3.Text = "Nombre:"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(200, 29)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(110, 23)
        Me.LabelX2.TabIndex = 9
        Me.LabelX2.Text = "Serie:"
        '
        'cbTipo
        '
        Me.cbTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbTipo.FormattingEnabled = True
        Me.cbTipo.Location = New System.Drawing.Point(21, 58)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(168, 29)
        Me.cbTipo.TabIndex = 1
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(21, 28)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(102, 23)
        Me.LabelX1.TabIndex = 8
        Me.LabelX1.Text = "Tipo de lugar:"
        '
        'ReflectionLabel1
        '
        '
        '
        '
        Me.ReflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel1.Font = New System.Drawing.Font("Segoe UI Light", 16.25!)
        Me.ReflectionLabel1.Location = New System.Drawing.Point(29, 22)
        Me.ReflectionLabel1.Name = "ReflectionLabel1"
        Me.ReflectionLabel1.ReflectionEnabled = False
        Me.ReflectionLabel1.Size = New System.Drawing.Size(286, 40)
        Me.ReflectionLabel1.TabIndex = 9
        Me.ReflectionLabel1.Text = "<font size=""+6"">Crear o editar<font color=""#32b8ff""> lugar</font></font>"
        '
        'ctrlTienda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.Controls.Add(Me.cbLugar)
        Me.Controls.Add(Me.swBt)
        Me.Controls.Add(Me.btGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ReflectionLabel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ctrlTienda"
        Me.Size = New System.Drawing.Size(663, 328)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cbLugar As System.Windows.Forms.ComboBox
    Friend WithEvents swBt As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents btGuardar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txNombre As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txSerie As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txTel2 As DevComponents.DotNetBar.Controls.MaskedTextBoxAdv
    Friend WithEvents txTel1 As DevComponents.DotNetBar.Controls.MaskedTextBoxAdv
    Friend WithEvents txDireccion As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ReflectionLabel1 As DevComponents.DotNetBar.Controls.ReflectionLabel

End Class

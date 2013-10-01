<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlPRModelo
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
        Me.ReflectionLabel1 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbbM = New DevComponents.DotNetBar.LabelX()
        Me.cbModelo = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.cbTCategoria = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cbCategoria = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cbMarca = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.btGuardar = New DevComponents.DotNetBar.ButtonX()
        Me.txNombre = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.swBt = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txDetalle = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txCompra = New DevComponents.DotNetBar.Controls.MaskedTextBoxAdv()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txVenta = New DevComponents.DotNetBar.Controls.MaskedTextBoxAdv()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ReflectionLabel1
        '
        Me.ReflectionLabel1.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.ReflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel1.Font = New System.Drawing.Font("Segoe UI Light", 16.25!)
        Me.ReflectionLabel1.Location = New System.Drawing.Point(18, 19)
        Me.ReflectionLabel1.Name = "ReflectionLabel1"
        Me.ReflectionLabel1.ReflectionEnabled = False
        Me.ReflectionLabel1.Size = New System.Drawing.Size(286, 40)
        Me.ReflectionLabel1.TabIndex = 10
        Me.ReflectionLabel1.Text = "<font size=""+6"">Crear o editar<font color=""#32b8ff""> Modelo</font></font>"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbbM)
        Me.GroupBox1.Controls.Add(Me.cbModelo)
        Me.GroupBox1.Controls.Add(Me.LabelX3)
        Me.GroupBox1.Controls.Add(Me.LabelX2)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Controls.Add(Me.cbTCategoria)
        Me.GroupBox1.Controls.Add(Me.cbCategoria)
        Me.GroupBox1.Controls.Add(Me.cbMarca)
        Me.GroupBox1.Controls.Add(Me.btGuardar)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(256, 279)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Ubicacion"
        '
        'lbbM
        '
        '
        '
        '
        Me.lbbM.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbbM.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbbM.Location = New System.Drawing.Point(23, 202)
        Me.lbbM.Name = "lbbM"
        Me.lbbM.Size = New System.Drawing.Size(145, 23)
        Me.lbbM.TabIndex = 22
        Me.lbbM.Text = "Busque el modelo:"
        Me.lbbM.Visible = False
        '
        'cbModelo
        '
        Me.cbModelo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbModelo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbModelo.DisplayMember = "Text"
        Me.cbModelo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbModelo.FormattingEnabled = True
        Me.cbModelo.ItemHeight = 19
        Me.cbModelo.Location = New System.Drawing.Point(23, 227)
        Me.cbModelo.Name = "cbModelo"
        Me.cbModelo.Size = New System.Drawing.Size(209, 25)
        Me.cbModelo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbModelo.TabIndex = 21
        Me.cbModelo.Visible = False
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(23, 142)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(75, 23)
        Me.LabelX3.TabIndex = 20
        Me.LabelX3.Text = "Marca"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(23, 84)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(75, 23)
        Me.LabelX2.TabIndex = 19
        Me.LabelX2.Text = "Tipo"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(23, 24)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(75, 23)
        Me.LabelX1.TabIndex = 18
        Me.LabelX1.Text = "Categoria"
        '
        'cbTCategoria
        '
        Me.cbTCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbTCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbTCategoria.DisplayMember = "Text"
        Me.cbTCategoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbTCategoria.FormattingEnabled = True
        Me.cbTCategoria.ItemHeight = 19
        Me.cbTCategoria.Location = New System.Drawing.Point(23, 113)
        Me.cbTCategoria.Name = "cbTCategoria"
        Me.cbTCategoria.Size = New System.Drawing.Size(209, 25)
        Me.cbTCategoria.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbTCategoria.TabIndex = 17
        '
        'cbCategoria
        '
        Me.cbCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbCategoria.DisplayMember = "Text"
        Me.cbCategoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbCategoria.FormattingEnabled = True
        Me.cbCategoria.ItemHeight = 19
        Me.cbCategoria.Location = New System.Drawing.Point(23, 53)
        Me.cbCategoria.Name = "cbCategoria"
        Me.cbCategoria.Size = New System.Drawing.Size(209, 25)
        Me.cbCategoria.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbCategoria.TabIndex = 16
        '
        'cbMarca
        '
        Me.cbMarca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbMarca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbMarca.DisplayMember = "Text"
        Me.cbMarca.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbMarca.FormattingEnabled = True
        Me.cbMarca.ItemHeight = 19
        Me.cbMarca.Location = New System.Drawing.Point(23, 171)
        Me.cbMarca.Name = "cbMarca"
        Me.cbMarca.Size = New System.Drawing.Size(209, 25)
        Me.cbMarca.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbMarca.TabIndex = 15
        '
        'btGuardar
        '
        Me.btGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btGuardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btGuardar.Image = Global.POS.My.Resources.Resources.diskette
        Me.btGuardar.Location = New System.Drawing.Point(522, 164)
        Me.btGuardar.Name = "btGuardar"
        Me.btGuardar.Size = New System.Drawing.Size(37, 32)
        Me.btGuardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btGuardar.TabIndex = 13
        '
        'txNombre
        '
        Me.txNombre.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txNombre.Border.Class = "TextBoxBorder"
        Me.txNombre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txNombre.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txNombre.ForeColor = System.Drawing.Color.Black
        Me.txNombre.Location = New System.Drawing.Point(15, 24)
        Me.txNombre.Name = "txNombre"
        Me.txNombre.Size = New System.Drawing.Size(209, 25)
        Me.txNombre.TabIndex = 12
        Me.txNombre.WatermarkText = "Nombre"
        '
        'swBt
        '
        '
        '
        '
        Me.swBt.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.swBt.Location = New System.Drawing.Point(460, 39)
        Me.swBt.Name = "swBt"
        Me.swBt.OffText = "Editar"
        Me.swBt.OnText = "Crear"
        Me.swBt.Size = New System.Drawing.Size(80, 29)
        Me.swBt.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.swBt.TabIndex = 12
        Me.swBt.Value = True
        Me.swBt.ValueObject = "Y"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txDetalle)
        Me.GroupBox2.Controls.Add(Me.txNombre)
        Me.GroupBox2.Location = New System.Drawing.Point(295, 74)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(245, 107)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informacion del modelo"
        '
        'txDetalle
        '
        Me.txDetalle.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txDetalle.Border.Class = "TextBoxBorder"
        Me.txDetalle.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txDetalle.ForeColor = System.Drawing.Color.Black
        Me.txDetalle.Location = New System.Drawing.Point(15, 55)
        Me.txDetalle.Name = "txDetalle"
        Me.txDetalle.Size = New System.Drawing.Size(209, 25)
        Me.txDetalle.TabIndex = 13
        Me.txDetalle.WatermarkText = "Detalle"
        '
        'txCompra
        '
        '
        '
        '
        Me.txCompra.BackgroundStyle.Class = "TextBoxBorder"
        Me.txCompra.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txCompra.ButtonClear.Visible = True
        Me.txCompra.Location = New System.Drawing.Point(15, 24)
        Me.txCompra.Mask = "999999,99"
        Me.txCompra.Name = "txCompra"
        Me.txCompra.Size = New System.Drawing.Size(209, 24)
        Me.txCompra.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.txCompra.TabIndex = 14
        Me.txCompra.Text = ""
        Me.txCompra.WatermarkText = "Compra"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txVenta)
        Me.GroupBox3.Controls.Add(Me.txCompra)
        Me.GroupBox3.Location = New System.Drawing.Point(295, 187)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(245, 105)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Precio"
        '
        'txVenta
        '
        '
        '
        '
        Me.txVenta.BackgroundStyle.Class = "TextBoxBorder"
        Me.txVenta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txVenta.ButtonClear.Visible = True
        Me.txVenta.Location = New System.Drawing.Point(15, 54)
        Me.txVenta.Mask = "999999,99"
        Me.txVenta.Name = "txVenta"
        Me.txVenta.Size = New System.Drawing.Size(209, 24)
        Me.txVenta.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.txVenta.TabIndex = 15
        Me.txVenta.Text = ""
        Me.txVenta.WatermarkText = "Compra"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Image = Global.POS.My.Resources.Resources.diskette
        Me.ButtonX1.Location = New System.Drawing.Point(437, 314)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(103, 39)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 17
        Me.ButtonX1.Text = "Guardar"
        '
        'ctrlPRModelo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.swBt)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ReflectionLabel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ctrlPRModelo"
        Me.Size = New System.Drawing.Size(570, 395)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReflectionLabel1 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txNombre As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btGuardar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents swBt As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents cbMarca As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cbTCategoria As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cbCategoria As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txDetalle As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txCompra As DevComponents.DotNetBar.Controls.MaskedTextBoxAdv
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txVenta As DevComponents.DotNetBar.Controls.MaskedTextBoxAdv
    Friend WithEvents lbbM As DevComponents.DotNetBar.LabelX
    Friend WithEvents cbModelo As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX

End Class

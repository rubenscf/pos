<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlCategoria
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txCategoria = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.cbCategoria = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.txTipo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.gbC = New System.Windows.Forms.GroupBox()
        Me.dgC = New System.Windows.Forms.DataGridView()
        Me.gbT = New System.Windows.Forms.GroupBox()
        Me.dgT = New System.Windows.Forms.DataGridView()
        Me.swBt = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.btGuarda = New DevComponents.DotNetBar.ButtonX()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gbC.SuspendLayout()
        CType(Me.dgC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbT.SuspendLayout()
        CType(Me.dgT, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ReflectionLabel2.Location = New System.Drawing.Point(20, 20)
        Me.ReflectionLabel2.Margin = New System.Windows.Forms.Padding(20)
        Me.ReflectionLabel2.Name = "ReflectionLabel2"
        Me.ReflectionLabel2.ReflectionEnabled = False
        Me.ReflectionLabel2.Size = New System.Drawing.Size(410, 40)
        Me.ReflectionLabel2.TabIndex = 12
        Me.ReflectionLabel2.Text = "<font size=""+6"">Crear o editar<font color=""#32b8ff""> categorias y tipos</font></f" & _
    "ont>"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txCategoria)
        Me.GroupBox1.Location = New System.Drawing.Point(363, 83)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(295, 73)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Categorias de productos"
        '
        'txCategoria
        '
        Me.txCategoria.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txCategoria.Border.Class = "TextBoxBorder"
        Me.txCategoria.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txCategoria.ForeColor = System.Drawing.Color.Black
        Me.txCategoria.Location = New System.Drawing.Point(16, 24)
        Me.txCategoria.Name = "txCategoria"
        Me.txCategoria.Size = New System.Drawing.Size(204, 25)
        Me.txCategoria.TabIndex = 0
        Me.txCategoria.WatermarkText = "Nombre"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LabelX1)
        Me.GroupBox2.Controls.Add(Me.cbCategoria)
        Me.GroupBox2.Controls.Add(Me.txTipo)
        Me.GroupBox2.Location = New System.Drawing.Point(363, 162)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(295, 148)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipos de productos"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(16, 24)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(75, 23)
        Me.LabelX1.TabIndex = 2
        Me.LabelX1.Text = "Categoria"
        '
        'cbCategoria
        '
        Me.cbCategoria.DisplayMember = "Text"
        Me.cbCategoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbCategoria.FormattingEnabled = True
        Me.cbCategoria.ItemHeight = 19
        Me.cbCategoria.Location = New System.Drawing.Point(16, 53)
        Me.cbCategoria.Name = "cbCategoria"
        Me.cbCategoria.Size = New System.Drawing.Size(204, 25)
        Me.cbCategoria.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbCategoria.TabIndex = 1
        '
        'txTipo
        '
        Me.txTipo.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txTipo.Border.Class = "TextBoxBorder"
        Me.txTipo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txTipo.ForeColor = System.Drawing.Color.Black
        Me.txTipo.Location = New System.Drawing.Point(16, 97)
        Me.txTipo.Name = "txTipo"
        Me.txTipo.Size = New System.Drawing.Size(204, 25)
        Me.txTipo.TabIndex = 0
        Me.txTipo.WatermarkText = "Nombre"
        '
        'gbC
        '
        Me.gbC.Controls.Add(Me.dgC)
        Me.gbC.Enabled = False
        Me.gbC.Location = New System.Drawing.Point(20, 83)
        Me.gbC.Name = "gbC"
        Me.gbC.Size = New System.Drawing.Size(325, 139)
        Me.gbC.TabIndex = 20
        Me.gbC.TabStop = False
        Me.gbC.Text = "Categorias Existentes"
        '
        'dgC
        '
        Me.dgC.AllowUserToAddRows = False
        Me.dgC.AllowUserToDeleteRows = False
        Me.dgC.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgC.Location = New System.Drawing.Point(3, 21)
        Me.dgC.Name = "dgC"
        Me.dgC.ReadOnly = True
        Me.dgC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgC.Size = New System.Drawing.Size(319, 115)
        Me.dgC.TabIndex = 0
        '
        'gbT
        '
        Me.gbT.Controls.Add(Me.dgT)
        Me.gbT.Enabled = False
        Me.gbT.Location = New System.Drawing.Point(20, 228)
        Me.gbT.Name = "gbT"
        Me.gbT.Size = New System.Drawing.Size(322, 154)
        Me.gbT.TabIndex = 21
        Me.gbT.TabStop = False
        Me.gbT.Text = "Tipos existentes"
        '
        'dgT
        '
        Me.dgT.AllowUserToAddRows = False
        Me.dgT.AllowUserToDeleteRows = False
        Me.dgT.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgT.Location = New System.Drawing.Point(3, 21)
        Me.dgT.Name = "dgT"
        Me.dgT.ReadOnly = True
        Me.dgT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgT.Size = New System.Drawing.Size(316, 130)
        Me.dgT.TabIndex = 1
        '
        'swBt
        '
        '
        '
        '
        Me.swBt.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.swBt.Location = New System.Drawing.Point(568, 31)
        Me.swBt.Name = "swBt"
        Me.swBt.OffText = "Editar"
        Me.swBt.OnText = "Crear"
        Me.swBt.Size = New System.Drawing.Size(80, 29)
        Me.swBt.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.swBt.TabIndex = 22
        Me.swBt.Value = True
        Me.swBt.ValueObject = "Y"
        '
        'btGuarda
        '
        Me.btGuarda.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btGuarda.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btGuarda.Image = Global.POS.My.Resources.Resources.diskette
        Me.btGuarda.Location = New System.Drawing.Point(555, 342)
        Me.btGuarda.Name = "btGuarda"
        Me.btGuarda.Size = New System.Drawing.Size(103, 37)
        Me.btGuarda.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btGuarda.TabIndex = 18
        Me.btGuarda.Text = "Guardar"
        '
        'ctrlCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.Controls.Add(Me.swBt)
        Me.Controls.Add(Me.gbT)
        Me.Controls.Add(Me.gbC)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btGuarda)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ReflectionLabel2)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "ctrlCategoria"
        Me.Size = New System.Drawing.Size(685, 402)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.gbC.ResumeLayout(False)
        CType(Me.dgC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbT.ResumeLayout(False)
        CType(Me.dgT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReflectionLabel2 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txCategoria As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txTipo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btGuarda As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cbCategoria As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents gbC As System.Windows.Forms.GroupBox
    Friend WithEvents dgC As System.Windows.Forms.DataGridView
    Friend WithEvents gbT As System.Windows.Forms.GroupBox
    Friend WithEvents dgT As System.Windows.Forms.DataGridView
    Friend WithEvents swBt As DevComponents.DotNetBar.Controls.SwitchButton

End Class

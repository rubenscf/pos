<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlStokAdd
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ReflectionLabel2 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txB = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cbF = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgP = New System.Windows.Forms.DataGridView()
        Me.txCantidad = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txDetalle = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txSegunda = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btGuarda = New DevComponents.DotNetBar.ButtonX()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbCodigo = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
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
        Me.ReflectionLabel2.Size = New System.Drawing.Size(461, 40)
        Me.ReflectionLabel2.TabIndex = 13
        Me.ReflectionLabel2.Text = "<font size=""+6"">Agregar nuevo producto a<font color=""#32b8ff""> inventario</font><" & _
    "/font>"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txB)
        Me.GroupBox1.Controls.Add(Me.cbF)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dgP)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 83)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(722, 295)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Modelos Existentes "
        '
        'txB
        '
        Me.txB.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txB.Border.Class = "TextBoxBorder"
        Me.txB.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txB.ForeColor = System.Drawing.Color.Black
        Me.txB.Location = New System.Drawing.Point(500, 16)
        Me.txB.Name = "txB"
        Me.txB.Size = New System.Drawing.Size(163, 25)
        Me.txB.TabIndex = 3
        '
        'cbF
        '
        Me.cbF.DisplayMember = "Text"
        Me.cbF.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbF.FormattingEnabled = True
        Me.cbF.ItemHeight = 19
        Me.cbF.Location = New System.Drawing.Point(363, 16)
        Me.cbF.Name = "cbF"
        Me.cbF.Size = New System.Drawing.Size(121, 25)
        Me.cbF.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbF.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Image = Global.POS.My.Resources.Resources.zoom
        Me.Label4.Location = New System.Drawing.Point(679, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 27)
        Me.Label4.TabIndex = 1
        '
        'dgP
        '
        Me.dgP.AllowUserToAddRows = False
        Me.dgP.AllowUserToDeleteRows = False
        Me.dgP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgP.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgP.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgP.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgP.Location = New System.Drawing.Point(3, 47)
        Me.dgP.Name = "dgP"
        Me.dgP.ReadOnly = True
        Me.dgP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgP.Size = New System.Drawing.Size(716, 245)
        Me.dgP.TabIndex = 0
        '
        'txCantidad
        '
        Me.txCantidad.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txCantidad.Border.Class = "TextBoxBorder"
        Me.txCantidad.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txCantidad.ForeColor = System.Drawing.Color.Black
        Me.txCantidad.Location = New System.Drawing.Point(15, 41)
        Me.txCantidad.Name = "txCantidad"
        Me.txCantidad.Size = New System.Drawing.Size(158, 25)
        Me.txCantidad.TabIndex = 15
        Me.txCantidad.Text = "0"
        Me.txCantidad.WatermarkText = "Cantidad"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txDetalle)
        Me.GroupBox2.Controls.Add(Me.txSegunda)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txCantidad)
        Me.GroupBox2.Location = New System.Drawing.Point(749, 83)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(188, 233)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cantidades"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 17)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Descripcion"
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
        Me.txDetalle.Location = New System.Drawing.Point(15, 137)
        Me.txDetalle.Multiline = True
        Me.txDetalle.Name = "txDetalle"
        Me.txDetalle.Size = New System.Drawing.Size(158, 69)
        Me.txDetalle.TabIndex = 19
        '
        'txSegunda
        '
        Me.txSegunda.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txSegunda.Border.Class = "TextBoxBorder"
        Me.txSegunda.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txSegunda.ForeColor = System.Drawing.Color.Black
        Me.txSegunda.Location = New System.Drawing.Point(15, 89)
        Me.txSegunda.Name = "txSegunda"
        Me.txSegunda.Size = New System.Drawing.Size(158, 25)
        Me.txSegunda.TabIndex = 18
        Me.txSegunda.Text = "0"
        Me.txSegunda.WatermarkText = "Usados"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 17)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "De Segunda"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 17)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Nuevos"
        '
        'btGuarda
        '
        Me.btGuarda.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btGuarda.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btGuarda.Image = Global.POS.My.Resources.Resources.inventaryAdd
        Me.btGuarda.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.btGuarda.Location = New System.Drawing.Point(749, 322)
        Me.btGuarda.Name = "btGuarda"
        Me.btGuarda.Size = New System.Drawing.Size(188, 53)
        Me.btGuarda.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btGuarda.TabIndex = 19
        Me.btGuarda.Text = "Agregar al Inventario"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(621, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 17)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "AGREGAR CODIGO:"
        '
        'lbCodigo
        '
        Me.lbCodigo.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCodigo.ForeColor = System.Drawing.Color.SteelBlue
        Me.lbCodigo.Location = New System.Drawing.Point(759, 33)
        Me.lbCodigo.Name = "lbCodigo"
        Me.lbCodigo.Size = New System.Drawing.Size(178, 40)
        Me.lbCodigo.TabIndex = 21
        Me.lbCodigo.Text = "00"
        '
        'ctrlStokAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.Controls.Add(Me.lbCodigo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btGuarda)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ReflectionLabel2)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ctrlStokAdd"
        Me.Size = New System.Drawing.Size(946, 395)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReflectionLabel2 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgP As System.Windows.Forms.DataGridView
    Friend WithEvents txCantidad As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btGuarda As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txSegunda As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txDetalle As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txB As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cbF As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbCodigo As System.Windows.Forms.Label

End Class

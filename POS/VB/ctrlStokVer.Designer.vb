<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlStokVer
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
        Me.dgP = New System.Windows.Forms.DataGridView()
        Me.txB = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cbF = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgP, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ReflectionLabel2.Text = "<font size=""+6"">Stock<font color=""#32b8ff""> existente</font></font>"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.dgP)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 83)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(917, 295)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Stock Existente"
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
        Me.dgP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgP.Location = New System.Drawing.Point(3, 21)
        Me.dgP.Name = "dgP"
        Me.dgP.ReadOnly = True
        Me.dgP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgP.Size = New System.Drawing.Size(911, 271)
        Me.dgP.TabIndex = 0
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
        Me.txB.Location = New System.Drawing.Point(715, 48)
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
        Me.cbF.Location = New System.Drawing.Point(578, 48)
        Me.cbF.Name = "cbF"
        Me.cbF.Size = New System.Drawing.Size(121, 25)
        Me.cbF.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbF.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Image = Global.POS.My.Resources.Resources.zoom
        Me.Label4.Location = New System.Drawing.Point(900, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 27)
        Me.Label4.TabIndex = 1
        '
        'ctrlStokVer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.Controls.Add(Me.cbF)
        Me.Controls.Add(Me.txB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ReflectionLabel2)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ctrlStokVer"
        Me.Size = New System.Drawing.Size(946, 395)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReflectionLabel2 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgP As System.Windows.Forms.DataGridView
    Friend WithEvents txB As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cbF As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class

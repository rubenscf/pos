<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlPuesto
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
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.cbTipo = New System.Windows.Forms.ComboBox()
        Me.bt_guarda = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txNombre = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ReflectionLabel1 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.GridColor = System.Drawing.SystemColors.Window
        Me.dg.Location = New System.Drawing.Point(101, 131)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dg.Size = New System.Drawing.Size(352, 201)
        Me.dg.TabIndex = 20
        '
        'cbTipo
        '
        Me.cbTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbTipo.FormattingEnabled = True
        Me.cbTipo.Location = New System.Drawing.Point(101, 96)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(135, 29)
        Me.cbTipo.TabIndex = 19
        '
        'bt_guarda
        '
        Me.bt_guarda.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.bt_guarda.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.bt_guarda.Image = Global.POS.My.Resources.Resources.plus_26
        Me.bt_guarda.Location = New System.Drawing.Point(413, 96)
        Me.bt_guarda.Name = "bt_guarda"
        Me.bt_guarda.Size = New System.Drawing.Size(40, 29)
        Me.bt_guarda.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.bt_guarda.TabIndex = 18
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(252, 71)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(155, 23)
        Me.LabelX1.TabIndex = 17
        Me.LabelX1.Text = "Nombre del puesto:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(97, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 21)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Tipo de sucursal"
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
        Me.txNombre.Location = New System.Drawing.Point(252, 96)
        Me.txNombre.Name = "txNombre"
        Me.txNombre.Size = New System.Drawing.Size(155, 29)
        Me.txNombre.TabIndex = 15
        '
        'ReflectionLabel1
        '
        '
        '
        '
        Me.ReflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel1.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReflectionLabel1.Location = New System.Drawing.Point(36, 31)
        Me.ReflectionLabel1.Name = "ReflectionLabel1"
        Me.ReflectionLabel1.ReflectionEnabled = False
        Me.ReflectionLabel1.Size = New System.Drawing.Size(353, 40)
        Me.ReflectionLabel1.TabIndex = 14
        Me.ReflectionLabel1.Text = "<font size=""+6"">Crear nuevo<font color=""#32b8ff""> puesto de trabajo</font></font>" & _
    ""
        '
        'ctrlPuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.cbTipo)
        Me.Controls.Add(Me.bt_guarda)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txNombre)
        Me.Controls.Add(Me.ReflectionLabel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ctrlPuesto"
        Me.Size = New System.Drawing.Size(579, 369)
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents cbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents bt_guarda As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txNombre As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ReflectionLabel1 As DevComponents.DotNetBar.Controls.ReflectionLabel

End Class

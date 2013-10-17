<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlPedidos
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgD = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.btPrint = New DevComponents.DotNetBar.ButtonX()
        Me.btAceptar = New DevComponents.DotNetBar.ButtonX()
        Me.btAnular = New DevComponents.DotNetBar.ButtonX()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ReflectionLabel2.Size = New System.Drawing.Size(330, 42)
        Me.ReflectionLabel2.TabIndex = 15
        Me.ReflectionLabel2.Text = "<font size=""+6"">Administrador De <font color=""#32b8ff"">Pedidos</font></font>"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ReflectionLabel2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.btPrint)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgD)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btAceptar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btAnular)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.dg)
        Me.SplitContainer1.Size = New System.Drawing.Size(1127, 492)
        Me.SplitContainer1.SplitterDistance = 63
        Me.SplitContainer1.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(548, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Detalle Del Pedido"
        '
        'dgD
        '
        Me.dgD.AllowUserToAddRows = False
        Me.dgD.AllowUserToDeleteRows = False
        Me.dgD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgD.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgD.Location = New System.Drawing.Point(553, 68)
        Me.dgD.Name = "dgD"
        Me.dgD.ReadOnly = True
        Me.dgD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgD.Size = New System.Drawing.Size(552, 278)
        Me.dgD.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Seleccione El Pedido"
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dg.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(19, 68)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(528, 278)
        Me.dg.TabIndex = 1
        '
        'btPrint
        '
        Me.btPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btPrint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btPrint.Image = Global.POS.My.Resources.Resources._11710
        Me.btPrint.Location = New System.Drawing.Point(1037, 5)
        Me.btPrint.Name = "btPrint"
        Me.btPrint.Size = New System.Drawing.Size(68, 60)
        Me.btPrint.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btPrint.TabIndex = 8
        '
        'btAceptar
        '
        Me.btAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btAceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btAceptar.Image = Global.POS.My.Resources.Resources.ProductsAcept
        Me.btAceptar.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.btAceptar.Location = New System.Drawing.Point(952, 361)
        Me.btAceptar.Name = "btAceptar"
        Me.btAceptar.Size = New System.Drawing.Size(153, 45)
        Me.btAceptar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btAceptar.TabIndex = 5
        Me.btAceptar.Text = "Aceptar Pedido"
        '
        'btAnular
        '
        Me.btAnular.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btAnular.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btAnular.Image = Global.POS.My.Resources.Resources.ProductsCancel
        Me.btAnular.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.btAnular.Location = New System.Drawing.Point(780, 361)
        Me.btAnular.Name = "btAnular"
        Me.btAnular.Size = New System.Drawing.Size(153, 45)
        Me.btAnular.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btAnular.TabIndex = 4
        Me.btAnular.Text = "Anular Pedido"
        '
        'ctrlPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ctrlPedidos"
        Me.Size = New System.Drawing.Size(1127, 492)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReflectionLabel2 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents btAceptar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btAnular As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgD As System.Windows.Forms.DataGridView
    Friend WithEvents btPrint As DevComponents.DotNetBar.ButtonX

End Class

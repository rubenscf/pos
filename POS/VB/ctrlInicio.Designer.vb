<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlInicio
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
        Dim MetroTileFrame1 As DevComponents.DotNetBar.Metro.MetroTileFrame
        Me.btSalir = New DevComponents.DotNetBar.ButtonX()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txNombre = New System.Windows.Forms.Label()
        Me.txPuesto = New System.Windows.Forms.Label()
        Me.txLugar = New System.Windows.Forms.Label()
        MetroTileFrame1 = New DevComponents.DotNetBar.Metro.MetroTileFrame()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroTileFrame1
        '
        MetroTileFrame1.Image = Global.POS.My.Resources.Resources.boxes
        MetroTileFrame1.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        '
        '
        '
        MetroTileFrame1.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'btSalir
        '
        Me.btSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btSalir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btSalir.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSalir.Image = Global.POS.My.Resources.Resources._4170
        Me.btSalir.Location = New System.Drawing.Point(342, 157)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Size = New System.Drawing.Size(189, 66)
        Me.btSalir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btSalir.TabIndex = 21
        Me.btSalir.Text = "Desconectar"
        Me.btSalir.TextColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.txLugar)
        Me.Panel1.Controls.Add(Me.btSalir)
        Me.Panel1.Controls.Add(Me.txPuesto)
        Me.Panel1.Controls.Add(Me.txNombre)
        Me.Panel1.Location = New System.Drawing.Point(167, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(548, 259)
        Me.Panel1.TabIndex = 22
        '
        'txNombre
        '
        Me.txNombre.Font = New System.Drawing.Font("Segoe UI", 22.0!)
        Me.txNombre.ForeColor = System.Drawing.Color.Azure
        Me.txNombre.Location = New System.Drawing.Point(20, 20)
        Me.txNombre.Margin = New System.Windows.Forms.Padding(20)
        Me.txNombre.Name = "txNombre"
        Me.txNombre.Size = New System.Drawing.Size(511, 43)
        Me.txNombre.TabIndex = 22
        Me.txNombre.Text = "txNombre"
        Me.txNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txPuesto
        '
        Me.txPuesto.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.txPuesto.ForeColor = System.Drawing.Color.White
        Me.txPuesto.Location = New System.Drawing.Point(190, 71)
        Me.txPuesto.Name = "txPuesto"
        Me.txPuesto.Size = New System.Drawing.Size(341, 37)
        Me.txPuesto.TabIndex = 23
        Me.txPuesto.Text = "txPuesto"
        Me.txPuesto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txLugar
        '
        Me.txLugar.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txLugar.ForeColor = System.Drawing.Color.Gold
        Me.txLugar.Location = New System.Drawing.Point(176, 108)
        Me.txLugar.Name = "txLugar"
        Me.txLugar.Size = New System.Drawing.Size(355, 37)
        Me.txLugar.TabIndex = 24
        Me.txLugar.Text = "txLugar"
        Me.txLugar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ctrlInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = Global.POS.My.Resources.Resources.cloudbg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ctrlInicio"
        Me.Size = New System.Drawing.Size(718, 361)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btSalir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txLugar As System.Windows.Forms.Label
    Friend WithEvents txPuesto As System.Windows.Forms.Label
    Friend WithEvents txNombre As System.Windows.Forms.Label

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlLogin
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
        Me.spltC = New System.Windows.Forms.SplitContainer()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btEntrar = New DevComponents.DotNetBar.ButtonX()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txPass = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txUsuario = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ReflectionLabel2 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        CType(Me.spltC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spltC.Panel1.SuspendLayout()
        Me.spltC.Panel2.SuspendLayout()
        Me.spltC.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'spltC
        '
        Me.spltC.BackColor = System.Drawing.Color.Transparent
        Me.spltC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spltC.IsSplitterFixed = True
        Me.spltC.Location = New System.Drawing.Point(0, 0)
        Me.spltC.Name = "spltC"
        '
        'spltC.Panel1
        '
        Me.spltC.Panel1.Controls.Add(Me.PictureBox1)
        '
        'spltC.Panel2
        '
        Me.spltC.Panel2.Controls.Add(Me.PictureBox3)
        Me.spltC.Panel2.Controls.Add(Me.btEntrar)
        Me.spltC.Panel2.Controls.Add(Me.Label3)
        Me.spltC.Panel2.Controls.Add(Me.txPass)
        Me.spltC.Panel2.Controls.Add(Me.Label2)
        Me.spltC.Panel2.Controls.Add(Me.txUsuario)
        Me.spltC.Panel2.Controls.Add(Me.ReflectionLabel2)
        Me.spltC.Panel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.spltC.Size = New System.Drawing.Size(935, 443)
        Me.spltC.SplitterDistance = 429
        Me.spltC.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.POS.My.Resources.Resources.Logo_ANGELs
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(429, 443)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.POS.My.Resources.Resources._13210
        Me.PictureBox3.Location = New System.Drawing.Point(51, 37)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(52, 52)
        Me.PictureBox3.TabIndex = 24
        Me.PictureBox3.TabStop = False
        '
        'btEntrar
        '
        Me.btEntrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btEntrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btEntrar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btEntrar.Image = Global.POS.My.Resources.Resources.key
        Me.btEntrar.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.btEntrar.Location = New System.Drawing.Point(247, 298)
        Me.btEntrar.Name = "btEntrar"
        Me.btEntrar.Size = New System.Drawing.Size(137, 47)
        Me.btEntrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.btEntrar.TabIndex = 3
        Me.btEntrar.Text = "   Entrar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(46, 223)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 25)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Contraseña:"
        '
        'txPass
        '
        Me.txPass.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txPass.Border.Class = "TextBoxBorder"
        Me.txPass.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txPass.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txPass.ForeColor = System.Drawing.Color.Black
        Me.txPass.Location = New System.Drawing.Point(178, 221)
        Me.txPass.Name = "txPass"
        Me.txPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txPass.Size = New System.Drawing.Size(206, 33)
        Me.txPass.TabIndex = 2
        Me.txPass.WatermarkText = "Contraseña"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(46, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 25)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Usuario"
        '
        'txUsuario
        '
        Me.txUsuario.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txUsuario.Border.Class = "TextBoxBorder"
        Me.txUsuario.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txUsuario.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txUsuario.ForeColor = System.Drawing.Color.Black
        Me.txUsuario.Location = New System.Drawing.Point(178, 154)
        Me.txUsuario.Name = "txUsuario"
        Me.txUsuario.Size = New System.Drawing.Size(206, 33)
        Me.txUsuario.TabIndex = 1
        Me.txUsuario.WatermarkText = "Usuario"
        '
        'ReflectionLabel2
        '
        Me.ReflectionLabel2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.ReflectionLabel2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel2.Font = New System.Drawing.Font("Segoe UI", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReflectionLabel2.Location = New System.Drawing.Point(115, 37)
        Me.ReflectionLabel2.Margin = New System.Windows.Forms.Padding(20)
        Me.ReflectionLabel2.Name = "ReflectionLabel2"
        Me.ReflectionLabel2.ReflectionEnabled = False
        Me.ReflectionLabel2.Size = New System.Drawing.Size(307, 52)
        Me.ReflectionLabel2.TabIndex = 16
        Me.ReflectionLabel2.Text = "<font size=""+6"">Ingresar al <font color=""#ffffff"">Sistema</font></font>"
        '
        'ctrlLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = Global.POS.My.Resources.Resources.cloudbg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Controls.Add(Me.spltC)
        Me.Name = "ctrlLogin"
        Me.Size = New System.Drawing.Size(935, 443)
        Me.spltC.Panel1.ResumeLayout(False)
        Me.spltC.Panel2.ResumeLayout(False)
        Me.spltC.Panel2.PerformLayout()
        CType(Me.spltC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spltC.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents spltC As System.Windows.Forms.SplitContainer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btEntrar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txPass As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txUsuario As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ReflectionLabel2 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox

End Class

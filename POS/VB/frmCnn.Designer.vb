<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCnn
    Inherits DevComponents.DotNetBar.Metro.MetroForm

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCnn))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txPuerto = New System.Windows.Forms.TextBox()
        Me.txUsuario = New System.Windows.Forms.TextBox()
        Me.txPass = New System.Windows.Forms.TextBox()
        Me.bt_guardar = New DevComponents.DotNetBar.ButtonX()
        Me.bt_probar = New DevComponents.DotNetBar.ButtonX()
        Me.statusbar = New DevComponents.DotNetBar.Metro.MetroStatusBar()
        Me.lbEstado = New DevComponents.DotNetBar.LabelItem()
        Me.txIp = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txSID = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(71, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Parametros de conexion al servidor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(38, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Direccion IP:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(66, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Usuario:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(290, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Puerto:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(41, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Contraseña:"
        '
        'txPuerto
        '
        Me.txPuerto.BackColor = System.Drawing.Color.White
        Me.txPuerto.ForeColor = System.Drawing.Color.Black
        Me.txPuerto.Location = New System.Drawing.Point(350, 55)
        Me.txPuerto.Margin = New System.Windows.Forms.Padding(8)
        Me.txPuerto.Name = "txPuerto"
        Me.txPuerto.Size = New System.Drawing.Size(65, 29)
        Me.txPuerto.TabIndex = 7
        '
        'txUsuario
        '
        Me.txUsuario.BackColor = System.Drawing.Color.White
        Me.txUsuario.ForeColor = System.Drawing.Color.Black
        Me.txUsuario.Location = New System.Drawing.Point(136, 145)
        Me.txUsuario.Margin = New System.Windows.Forms.Padding(8)
        Me.txUsuario.Name = "txUsuario"
        Me.txUsuario.Size = New System.Drawing.Size(143, 29)
        Me.txUsuario.TabIndex = 8
        '
        'txPass
        '
        Me.txPass.BackColor = System.Drawing.Color.White
        Me.txPass.ForeColor = System.Drawing.Color.Black
        Me.txPass.Location = New System.Drawing.Point(136, 190)
        Me.txPass.Margin = New System.Windows.Forms.Padding(8)
        Me.txPass.Name = "txPass"
        Me.txPass.Size = New System.Drawing.Size(143, 29)
        Me.txPass.TabIndex = 9
        '
        'bt_guardar
        '
        Me.bt_guardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.bt_guardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.bt_guardar.Location = New System.Drawing.Point(294, 230)
        Me.bt_guardar.Name = "bt_guardar"
        Me.bt_guardar.Size = New System.Drawing.Size(96, 32)
        Me.bt_guardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.bt_guardar.TabIndex = 11
        Me.bt_guardar.Text = "&Guardar"
        '
        'bt_probar
        '
        Me.bt_probar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.bt_probar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.bt_probar.Location = New System.Drawing.Point(183, 230)
        Me.bt_probar.Name = "bt_probar"
        Me.bt_probar.Size = New System.Drawing.Size(96, 32)
        Me.bt_probar.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.bt_probar.TabIndex = 12
        Me.bt_probar.Text = "&Probar"
        '
        'statusbar
        '
        '
        '
        '
        Me.statusbar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.statusbar.ContainerControlProcessDialogKey = True
        Me.statusbar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.statusbar.Font = New System.Drawing.Font("Segoe UI", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statusbar.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.lbEstado})
        Me.statusbar.Location = New System.Drawing.Point(0, 278)
        Me.statusbar.Name = "statusbar"
        Me.statusbar.Size = New System.Drawing.Size(451, 22)
        Me.statusbar.TabIndex = 13
        Me.statusbar.Text = "asdf"
        '
        'lbEstado
        '
        Me.lbEstado.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEstado.Name = "lbEstado"
        Me.lbEstado.Text = "Listo"
        '
        'txIp
        '
        Me.txIp.Location = New System.Drawing.Point(136, 55)
        Me.txIp.Margin = New System.Windows.Forms.Padding(8)
        Me.txIp.Name = "txIp"
        Me.txIp.Size = New System.Drawing.Size(143, 29)
        Me.txIp.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(96, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 21)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "SID:"
        '
        'txSID
        '
        Me.txSID.BackColor = System.Drawing.Color.White
        Me.txSID.ForeColor = System.Drawing.Color.Black
        Me.txSID.Location = New System.Drawing.Point(136, 100)
        Me.txSID.Margin = New System.Windows.Forms.Padding(8)
        Me.txSID.Name = "txSID"
        Me.txSID.Size = New System.Drawing.Size(143, 29)
        Me.txSID.TabIndex = 16
        '
        'frmCnn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 300)
        Me.Controls.Add(Me.txSID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txIp)
        Me.Controls.Add(Me.statusbar)
        Me.Controls.Add(Me.bt_probar)
        Me.Controls.Add(Me.bt_guardar)
        Me.Controls.Add(Me.txPass)
        Me.Controls.Add(Me.txUsuario)
        Me.Controls.Add(Me.txPuerto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmCnn"
        Me.Text = "Conectar al servidor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txPuerto As System.Windows.Forms.TextBox
    Friend WithEvents txUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txPass As System.Windows.Forms.TextBox
    Friend WithEvents bt_guardar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents bt_probar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents statusbar As DevComponents.DotNetBar.Metro.MetroStatusBar
    Friend WithEvents lbEstado As DevComponents.DotNetBar.LabelItem
    Friend WithEvents txIp As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txSID As System.Windows.Forms.TextBox
End Class

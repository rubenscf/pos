<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlNuevoEnvio
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
        Me.splcMain = New System.Windows.Forms.SplitContainer()
        Me.lalber1 = New System.Windows.Forms.Label()
        Me.swBt = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.cbVerTienda = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ReflectionLabel2 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.splCBody = New System.Windows.Forms.SplitContainer()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txB = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cbF = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ReflectionLabel1 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.dgL = New System.Windows.Forms.DataGridView()
        Me.btGuardar = New DevComponents.DotNetBar.ButtonX()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.toolStrpAdd = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btBorrarL = New System.Windows.Forms.ToolStripButton()
        Me.idpr_modelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idpr_marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MARCA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MODELO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUEVO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USADOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.detalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.splcMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splcMain.Panel1.SuspendLayout()
        Me.splcMain.Panel2.SuspendLayout()
        Me.splcMain.SuspendLayout()
        CType(Me.splCBody, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splCBody.Panel1.SuspendLayout()
        Me.splCBody.Panel2.SuspendLayout()
        Me.splCBody.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.LeftToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'splcMain
        '
        Me.splcMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splcMain.Location = New System.Drawing.Point(0, 0)
        Me.splcMain.Name = "splcMain"
        Me.splcMain.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splcMain.Panel1
        '
        Me.splcMain.Panel1.Controls.Add(Me.lalber1)
        Me.splcMain.Panel1.Controls.Add(Me.swBt)
        Me.splcMain.Panel1.Controls.Add(Me.cbVerTienda)
        Me.splcMain.Panel1.Controls.Add(Me.ReflectionLabel2)
        '
        'splcMain.Panel2
        '
        Me.splcMain.Panel2.Controls.Add(Me.splCBody)
        Me.splcMain.Size = New System.Drawing.Size(1149, 499)
        Me.splcMain.SplitterDistance = 66
        Me.splcMain.TabIndex = 0
        '
        'lalber1
        '
        Me.lalber1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lalber1.AutoSize = True
        Me.lalber1.Location = New System.Drawing.Point(704, 13)
        Me.lalber1.Name = "lalber1"
        Me.lalber1.Size = New System.Drawing.Size(40, 15)
        Me.lalber1.TabIndex = 24
        Me.lalber1.Text = "Lugar:"
        '
        'swBt
        '
        Me.swBt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.swBt.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.swBt.Location = New System.Drawing.Point(1056, 25)
        Me.swBt.Name = "swBt"
        Me.swBt.OffText = "Traslado"
        Me.swBt.OnText = "Envio"
        Me.swBt.Size = New System.Drawing.Size(80, 29)
        Me.swBt.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.swBt.TabIndex = 23
        Me.swBt.Value = True
        Me.swBt.ValueObject = "Y"
        '
        'cbVerTienda
        '
        Me.cbVerTienda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbVerTienda.DisplayMember = "Text"
        Me.cbVerTienda.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbVerTienda.FormattingEnabled = True
        Me.cbVerTienda.ItemHeight = 17
        Me.cbVerTienda.Location = New System.Drawing.Point(707, 31)
        Me.cbVerTienda.Name = "cbVerTienda"
        Me.cbVerTienda.Size = New System.Drawing.Size(343, 23)
        Me.cbVerTienda.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbVerTienda.TabIndex = 14
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
        Me.ReflectionLabel2.Size = New System.Drawing.Size(295, 42)
        Me.ReflectionLabel2.TabIndex = 13
        Me.ReflectionLabel2.Text = "<font size=""+6"">Nuevo<font color=""#32b8ff""> envio o traslado</font></font>"
        '
        'splCBody
        '
        Me.splCBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splCBody.Location = New System.Drawing.Point(0, 0)
        Me.splCBody.Name = "splCBody"
        '
        'splCBody.Panel1
        '
        Me.splCBody.Panel1.Controls.Add(Me.Label4)
        Me.splCBody.Panel1.Controls.Add(Me.txB)
        Me.splCBody.Panel1.Controls.Add(Me.cbF)
        Me.splCBody.Panel1.Controls.Add(Me.Label1)
        Me.splCBody.Panel1.Controls.Add(Me.dg)
        Me.splCBody.Panel1.Controls.Add(Me.Splitter1)
        '
        'splCBody.Panel2
        '
        Me.splCBody.Panel2.Controls.Add(Me.ToolStripContainer1)
        Me.splCBody.Size = New System.Drawing.Size(1149, 429)
        Me.splCBody.SplitterDistance = 639
        Me.splCBody.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.Image = Global.POS.My.Resources.Resources.zoom
        Me.Label4.Location = New System.Drawing.Point(484, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 27)
        Me.Label4.TabIndex = 4
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
        Me.txB.Location = New System.Drawing.Point(279, 15)
        Me.txB.Name = "txB"
        Me.txB.Size = New System.Drawing.Size(199, 23)
        Me.txB.TabIndex = 3
        '
        'cbF
        '
        Me.cbF.DisplayMember = "Text"
        Me.cbF.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbF.FormattingEnabled = True
        Me.cbF.ItemHeight = 17
        Me.cbF.Location = New System.Drawing.Point(152, 15)
        Me.cbF.Name = "cbF"
        Me.cbF.Size = New System.Drawing.Size(121, 23)
        Me.cbF.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbF.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(80, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Buscar Por:"
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dg.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg.GridColor = System.Drawing.SystemColors.Window
        Me.dg.Location = New System.Drawing.Point(0, 50)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(639, 379)
        Me.dg.TabIndex = 0
        '
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(639, 50)
        Me.Splitter1.TabIndex = 0
        Me.Splitter1.TabStop = False
        '
        'ToolStripContainer1
        '
        Me.ToolStripContainer1.BottomToolStripPanelVisible = False
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.TableLayoutPanel1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(470, 429)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        '
        'ToolStripContainer1.LeftToolStripPanel
        '
        Me.ToolStripContainer1.LeftToolStripPanel.Controls.Add(Me.ToolStrip1)
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(506, 429)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        Me.ToolStripContainer1.TopToolStripPanelVisible = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ReflectionLabel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.dgL, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btGuardar, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.2964!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.7036!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(470, 429)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'ReflectionLabel1
        '
        Me.ReflectionLabel1.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.ReflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReflectionLabel1.Location = New System.Drawing.Point(5, 5)
        Me.ReflectionLabel1.Margin = New System.Windows.Forms.Padding(5)
        Me.ReflectionLabel1.Name = "ReflectionLabel1"
        Me.ReflectionLabel1.ReflectionEnabled = False
        Me.ReflectionLabel1.Size = New System.Drawing.Size(286, 28)
        Me.ReflectionLabel1.TabIndex = 14
        Me.ReflectionLabel1.Text = "<font size=""+6"">Listado de<font color=""#32b8ff""> productos</font></font>"
        '
        'dgL
        '
        Me.dgL.AllowUserToAddRows = False
        Me.dgL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgL.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgL.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgL.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idpr_modelo, Me.idpr_marca, Me.codigo, Me.MARCA, Me.MODELO, Me.NUEVO, Me.USADOS, Me.detalle})
        Me.dgL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgL.GridColor = System.Drawing.SystemColors.Window
        Me.dgL.Location = New System.Drawing.Point(3, 51)
        Me.dgL.Name = "dgL"
        Me.dgL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgL.Size = New System.Drawing.Size(464, 307)
        Me.dgL.TabIndex = 1
        '
        'btGuardar
        '
        Me.btGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btGuardar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btGuardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btGuardar.Image = Global.POS.My.Resources.Resources.ListSend
        Me.btGuardar.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.btGuardar.Location = New System.Drawing.Point(329, 375)
        Me.btGuardar.Margin = New System.Windows.Forms.Padding(3, 3, 20, 3)
        Me.btGuardar.Name = "btGuardar"
        Me.btGuardar.Size = New System.Drawing.Size(121, 40)
        Me.btGuardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btGuardar.TabIndex = 15
        Me.btGuardar.Text = "Enviar Listado"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStrpAdd, Me.ToolStripSeparator1, Me.btBorrarL})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 78)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(36, 85)
        Me.ToolStrip1.TabIndex = 0
        '
        'toolStrpAdd
        '
        Me.toolStrpAdd.AutoSize = False
        Me.toolStrpAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolStrpAdd.Enabled = False
        Me.toolStrpAdd.Image = Global.POS.My.Resources.Resources.right_32
        Me.toolStrpAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.toolStrpAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.toolStrpAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStrpAdd.Margin = New System.Windows.Forms.Padding(0, 1, 0, 3)
        Me.toolStrpAdd.Name = "toolStrpAdd"
        Me.toolStrpAdd.Size = New System.Drawing.Size(35, 35)
        Me.toolStrpAdd.Text = "Agregar"
        Me.toolStrpAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.toolStrpAdd.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90
        Me.toolStrpAdd.ToolTipText = "Agregar a la Lista"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(34, 6)
        '
        'btBorrarL
        '
        Me.btBorrarL.AutoSize = False
        Me.btBorrarL.Image = Global.POS.My.Resources.Resources.delete_32
        Me.btBorrarL.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btBorrarL.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btBorrarL.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btBorrarL.Name = "btBorrarL"
        Me.btBorrarL.Size = New System.Drawing.Size(35, 35)
        Me.btBorrarL.ToolTipText = "Eliminar de la lista"
        '
        'idpr_modelo
        '
        Me.idpr_modelo.HeaderText = "idpr_modelo"
        Me.idpr_modelo.Name = "idpr_modelo"
        Me.idpr_modelo.Visible = False
        Me.idpr_modelo.Width = 99
        '
        'idpr_marca
        '
        Me.idpr_marca.HeaderText = "idpr_marca"
        Me.idpr_marca.Name = "idpr_marca"
        Me.idpr_marca.Visible = False
        Me.idpr_marca.Width = 91
        '
        'codigo
        '
        Me.codigo.HeaderText = "CODIGO"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        Me.codigo.Width = 77
        '
        'MARCA
        '
        Me.MARCA.HeaderText = "MARCA"
        Me.MARCA.Name = "MARCA"
        Me.MARCA.ReadOnly = True
        Me.MARCA.Width = 74
        '
        'MODELO
        '
        Me.MODELO.HeaderText = "MODELO"
        Me.MODELO.Name = "MODELO"
        Me.MODELO.ReadOnly = True
        Me.MODELO.Width = 81
        '
        'NUEVO
        '
        Me.NUEVO.HeaderText = "NUEVOS"
        Me.NUEVO.Name = "NUEVO"
        Me.NUEVO.Width = 77
        '
        'USADOS
        '
        Me.USADOS.HeaderText = "USADOS"
        Me.USADOS.Name = "USADOS"
        Me.USADOS.Width = 77
        '
        'detalle
        '
        Me.detalle.HeaderText = "DESCRIPCION"
        Me.detalle.Name = "detalle"
        Me.detalle.Width = 106
        '
        'ctrlNuevoEnvio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.Controls.Add(Me.splcMain)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ctrlNuevoEnvio"
        Me.Size = New System.Drawing.Size(1149, 499)
        Me.splcMain.Panel1.ResumeLayout(False)
        Me.splcMain.Panel1.PerformLayout()
        Me.splcMain.Panel2.ResumeLayout(False)
        CType(Me.splcMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splcMain.ResumeLayout(False)
        Me.splCBody.Panel1.ResumeLayout(False)
        Me.splCBody.Panel1.PerformLayout()
        Me.splCBody.Panel2.ResumeLayout(False)
        CType(Me.splCBody, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splCBody.ResumeLayout(False)
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.LeftToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.LeftToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents splcMain As System.Windows.Forms.SplitContainer
    Friend WithEvents ReflectionLabel2 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents splCBody As System.Windows.Forms.SplitContainer
    Friend WithEvents cbVerTienda As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lalber1 As System.Windows.Forms.Label
    Friend WithEvents swBt As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents txB As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cbF As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ReflectionLabel1 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents dgL As System.Windows.Forms.DataGridView
    Friend WithEvents btGuardar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents toolStrpAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btBorrarL As System.Windows.Forms.ToolStripButton
    Friend WithEvents idpr_modelo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idpr_marca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MARCA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MODELO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NUEVO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents USADOS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents detalle As System.Windows.Forms.DataGridViewTextBoxColumn

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlFacturar
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
        Me.Container = New System.Windows.Forms.SplitContainer()
        Me.gb3 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbSt = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txDescuento = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbTotal = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbDscto = New System.Windows.Forms.Label()
        Me.lbNarticulo = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbTipo = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txDireccion = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txNombre = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txCantidad = New System.Windows.Forms.NumericUpDown()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txMo = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.lbStock = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lbSubtotal = New System.Windows.Forms.Label()
        Me.LbPrecioU = New System.Windows.Forms.Label()
        Me.lbModelo = New System.Windows.Forms.Label()
        Me.lbMarca = New System.Windows.Forms.Label()
        Me.lbCodigo = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txMa = New System.Windows.Forms.TextBox()
        Me.dgD = New System.Windows.Forms.DataGridView()
        Me.marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.modelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NMARCA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NMODELO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DETALLE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUBTOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serrie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.btImprimir = New DevComponents.DotNetBar.ButtonX()
        Me.btGuardar = New DevComponents.DotNetBar.ButtonX()
        Me.btCGuardar = New DevComponents.DotNetBar.ButtonX()
        Me.txNit = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btBuscar = New DevComponents.DotNetBar.ButtonX()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btQuitarLista = New DevComponents.DotNetBar.ButtonX()
        Me.btAgregarLista = New DevComponents.DotNetBar.ButtonX()
        Me.btBStock = New DevComponents.DotNetBar.ButtonX()
        CType(Me.Container, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Container.Panel1.SuspendLayout()
        Me.Container.Panel2.SuspendLayout()
        Me.Container.SuspendLayout()
        Me.gb3.SuspendLayout()
        CType(Me.txDescuento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.txCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Container
        '
        Me.Container.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Container.Location = New System.Drawing.Point(0, 0)
        Me.Container.Name = "Container"
        Me.Container.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'Container.Panel1
        '
        Me.Container.Panel1.Controls.Add(Me.gb3)
        Me.Container.Panel1.Controls.Add(Me.btImprimir)
        Me.Container.Panel1.Controls.Add(Me.btGuardar)
        Me.Container.Panel1.Controls.Add(Me.GroupBox1)
        '
        'Container.Panel2
        '
        Me.Container.Panel2.Controls.Add(Me.GroupBox4)
        Me.Container.Panel2.Controls.Add(Me.dgD)
        Me.Container.Panel2.Controls.Add(Me.Splitter1)
        Me.Container.Panel2.Enabled = False
        Me.Container.Size = New System.Drawing.Size(1251, 537)
        Me.Container.SplitterDistance = 157
        Me.Container.TabIndex = 29
        '
        'gb3
        '
        Me.gb3.Controls.Add(Me.Label9)
        Me.gb3.Controls.Add(Me.lbSt)
        Me.gb3.Controls.Add(Me.Label23)
        Me.gb3.Controls.Add(Me.txDescuento)
        Me.gb3.Controls.Add(Me.Label7)
        Me.gb3.Controls.Add(Me.Label8)
        Me.gb3.Controls.Add(Me.Label13)
        Me.gb3.Controls.Add(Me.lbTotal)
        Me.gb3.Controls.Add(Me.Label11)
        Me.gb3.Controls.Add(Me.lbDscto)
        Me.gb3.Controls.Add(Me.lbNarticulo)
        Me.gb3.Controls.Add(Me.Label6)
        Me.gb3.Controls.Add(Me.Label5)
        Me.gb3.Controls.Add(Me.Label4)
        Me.gb3.Location = New System.Drawing.Point(437, 16)
        Me.gb3.Name = "gb3"
        Me.gb3.Size = New System.Drawing.Size(597, 130)
        Me.gb3.TabIndex = 4
        Me.gb3.TabStop = False
        Me.gb3.Text = "Resumen"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(199, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 24)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Q."
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbSt
        '
        Me.lbSt.AutoSize = True
        Me.lbSt.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbSt.Location = New System.Drawing.Point(225, 68)
        Me.lbSt.Name = "lbSt"
        Me.lbSt.Size = New System.Drawing.Size(59, 24)
        Me.lbSt.TabIndex = 29
        Me.lbSt.Text = "00.00"
        Me.lbSt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(216, 35)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(56, 17)
        Me.Label23.TabIndex = 28
        Me.Label23.Text = "Subtotal"
        '
        'txDescuento
        '
        Me.txDescuento.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txDescuento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txDescuento.Location = New System.Drawing.Point(97, 66)
        Me.txDescuento.Name = "txDescuento"
        Me.txDescuento.Size = New System.Drawing.Size(57, 32)
        Me.txDescuento.TabIndex = 27
        Me.txDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(151, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 22)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "%"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(94, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 17)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Descuento"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(450, 68)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 24)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Q."
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbTotal
        '
        Me.lbTotal.AutoSize = True
        Me.lbTotal.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbTotal.Location = New System.Drawing.Point(476, 68)
        Me.lbTotal.Name = "lbTotal"
        Me.lbTotal.Size = New System.Drawing.Size(59, 24)
        Me.lbTotal.TabIndex = 11
        Me.lbTotal.Text = "00.00"
        Me.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Goldenrod
        Me.Label11.Location = New System.Drawing.Point(329, 68)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 24)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Q."
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbDscto
        '
        Me.lbDscto.AutoSize = True
        Me.lbDscto.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDscto.ForeColor = System.Drawing.Color.Goldenrod
        Me.lbDscto.Location = New System.Drawing.Point(355, 68)
        Me.lbDscto.Name = "lbDscto"
        Me.lbDscto.Size = New System.Drawing.Size(37, 24)
        Me.lbDscto.TabIndex = 9
        Me.lbDscto.Text = "0.0"
        Me.lbDscto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbNarticulo
        '
        Me.lbNarticulo.AutoSize = True
        Me.lbNarticulo.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNarticulo.ForeColor = System.Drawing.Color.SteelBlue
        Me.lbNarticulo.Location = New System.Drawing.Point(28, 68)
        Me.lbNarticulo.Name = "lbNarticulo"
        Me.lbNarticulo.Size = New System.Drawing.Size(21, 24)
        Me.lbNarticulo.TabIndex = 8
        Me.lbNarticulo.Text = "0"
        Me.lbNarticulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(467, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Total a pagar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(345, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 17)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Descuento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "# Articulos"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbTipo)
        Me.GroupBox1.Controls.Add(Me.btCGuardar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txDireccion)
        Me.GroupBox1.Controls.Add(Me.txNombre)
        Me.GroupBox1.Controls.Add(Me.txNit)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(408, 130)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del cliente"
        '
        'lbTipo
        '
        Me.lbTipo.AutoSize = True
        Me.lbTipo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTipo.Location = New System.Drawing.Point(378, 21)
        Me.lbTipo.Name = "lbTipo"
        Me.lbTipo.Size = New System.Drawing.Size(18, 17)
        Me.lbTipo.TabIndex = 17
        Me.lbTipo.Text = "N"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Dirección"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(149, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "NIT"
        '
        'txDireccion
        '
        Me.txDireccion.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txDireccion.Border.Class = "TextBoxBorder"
        Me.txDireccion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txDireccion.ForeColor = System.Drawing.Color.Black
        Me.txDireccion.Location = New System.Drawing.Point(9, 89)
        Me.txDireccion.MaxLength = 250
        Me.txDireccion.Name = "txDireccion"
        Me.txDireccion.Size = New System.Drawing.Size(320, 25)
        Me.txDireccion.TabIndex = 3
        Me.txDireccion.WatermarkText = "Dirección"
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
        Me.txNombre.Location = New System.Drawing.Point(152, 41)
        Me.txNombre.MaxLength = 250
        Me.txNombre.Name = "txNombre"
        Me.txNombre.Size = New System.Drawing.Size(244, 25)
        Me.txNombre.TabIndex = 2
        Me.txNombre.WatermarkText = "Nombre"
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.txCantidad)
        Me.GroupBox4.Controls.Add(Me.btBuscar)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.txMo)
        Me.GroupBox4.Controls.Add(Me.PictureBox1)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Controls.Add(Me.lbStock)
        Me.GroupBox4.Controls.Add(Me.btQuitarLista)
        Me.GroupBox4.Controls.Add(Me.btAgregarLista)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.btBStock)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.lbSubtotal)
        Me.GroupBox4.Controls.Add(Me.LbPrecioU)
        Me.GroupBox4.Controls.Add(Me.lbModelo)
        Me.GroupBox4.Controls.Add(Me.lbMarca)
        Me.GroupBox4.Controls.Add(Me.lbCodigo)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.txMa)
        Me.GroupBox4.Location = New System.Drawing.Point(14, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(329, 363)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Buscar Producto"
        '
        'txCantidad
        '
        Me.txCantidad.Location = New System.Drawing.Point(91, 225)
        Me.txCantidad.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txCantidad.Name = "txCantidad"
        Me.txCantidad.ReadOnly = True
        Me.txCantidad.Size = New System.Drawing.Size(120, 25)
        Me.txCantidad.TabIndex = 29
        Me.txCantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(88, 68)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(18, 17)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "__"
        '
        'txMo
        '
        Me.txMo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txMo.Location = New System.Drawing.Point(112, 71)
        Me.txMo.Name = "txMo"
        Me.txMo.Size = New System.Drawing.Size(94, 25)
        Me.txMo.TabIndex = 1
        Me.txMo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(13, 293)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(42, 17)
        Me.Label24.TabIndex = 25
        Me.Label24.Text = "Stock:"
        '
        'lbStock
        '
        Me.lbStock.AutoSize = True
        Me.lbStock.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbStock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbStock.Location = New System.Drawing.Point(88, 287)
        Me.lbStock.Name = "lbStock"
        Me.lbStock.Size = New System.Drawing.Size(23, 25)
        Me.lbStock.TabIndex = 24
        Me.lbStock.Text = "0"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(13, 257)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(59, 17)
        Me.Label22.TabIndex = 21
        Me.Label22.Text = "Subtotal:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(13, 227)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(63, 17)
        Me.Label19.TabIndex = 20
        Me.Label19.Text = "Cantidad:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(13, 199)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(60, 17)
        Me.Label18.TabIndex = 19
        Me.Label18.Text = "Precio U:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(13, 168)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(57, 17)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "Modelo:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(13, 137)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(48, 17)
        Me.Label16.TabIndex = 17
        Me.Label16.Text = "Marca:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(13, 106)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 17)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Codigo:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(89, 199)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(22, 17)
        Me.Label21.TabIndex = 14
        Me.Label21.Text = "Q."
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(89, 257)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(22, 17)
        Me.Label20.TabIndex = 13
        Me.Label20.Text = "Q."
        '
        'lbSubtotal
        '
        Me.lbSubtotal.AutoSize = True
        Me.lbSubtotal.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSubtotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbSubtotal.Location = New System.Drawing.Point(109, 257)
        Me.lbSubtotal.Name = "lbSubtotal"
        Me.lbSubtotal.Size = New System.Drawing.Size(40, 17)
        Me.lbSubtotal.TabIndex = 12
        Me.lbSubtotal.Text = "00.00"
        '
        'LbPrecioU
        '
        Me.LbPrecioU.AutoSize = True
        Me.LbPrecioU.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPrecioU.Location = New System.Drawing.Point(109, 199)
        Me.LbPrecioU.Name = "LbPrecioU"
        Me.LbPrecioU.Size = New System.Drawing.Size(40, 17)
        Me.LbPrecioU.TabIndex = 7
        Me.LbPrecioU.Text = "00.00"
        '
        'lbModelo
        '
        Me.lbModelo.AutoSize = True
        Me.lbModelo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbModelo.Location = New System.Drawing.Point(89, 168)
        Me.lbModelo.Name = "lbModelo"
        Me.lbModelo.Size = New System.Drawing.Size(0, 17)
        Me.lbModelo.TabIndex = 6
        '
        'lbMarca
        '
        Me.lbMarca.AutoSize = True
        Me.lbMarca.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMarca.Location = New System.Drawing.Point(89, 137)
        Me.lbMarca.Name = "lbMarca"
        Me.lbMarca.Size = New System.Drawing.Size(0, 17)
        Me.lbMarca.TabIndex = 5
        '
        'lbCodigo
        '
        Me.lbCodigo.AutoSize = True
        Me.lbCodigo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCodigo.Location = New System.Drawing.Point(89, 106)
        Me.lbCodigo.Name = "lbCodigo"
        Me.lbCodigo.Size = New System.Drawing.Size(0, 17)
        Me.lbCodigo.TabIndex = 4
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(56, 30)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(159, 25)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Codigo Producto:"
        '
        'txMa
        '
        Me.txMa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txMa.Location = New System.Drawing.Point(16, 71)
        Me.txMa.Name = "txMa"
        Me.txMa.Size = New System.Drawing.Size(67, 25)
        Me.txMa.TabIndex = 0
        Me.txMa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgD
        '
        Me.dgD.AllowUserToAddRows = False
        Me.dgD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgD.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgD.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.marca, Me.modelo, Me.CODIGO, Me.NMARCA, Me.NMODELO, Me.DETALLE, Me.SUBTOTAL, Me.serrie})
        Me.dgD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgD.Location = New System.Drawing.Point(356, 0)
        Me.dgD.Name = "dgD"
        Me.dgD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgD.Size = New System.Drawing.Size(895, 376)
        Me.dgD.TabIndex = 1
        '
        'marca
        '
        Me.marca.HeaderText = "marca"
        Me.marca.Name = "marca"
        Me.marca.ReadOnly = True
        Me.marca.Visible = False
        Me.marca.Width = 61
        '
        'modelo
        '
        Me.modelo.HeaderText = "modelo"
        Me.modelo.Name = "modelo"
        Me.modelo.ReadOnly = True
        Me.modelo.Visible = False
        Me.modelo.Width = 66
        '
        'CODIGO
        '
        Me.CODIGO.HeaderText = "CODIGO"
        Me.CODIGO.Name = "CODIGO"
        Me.CODIGO.ReadOnly = True
        Me.CODIGO.Width = 82
        '
        'NMARCA
        '
        Me.NMARCA.HeaderText = "MARCA"
        Me.NMARCA.Name = "NMARCA"
        Me.NMARCA.ReadOnly = True
        Me.NMARCA.Width = 77
        '
        'NMODELO
        '
        Me.NMODELO.HeaderText = "MODELO"
        Me.NMODELO.Name = "NMODELO"
        Me.NMODELO.ReadOnly = True
        Me.NMODELO.Width = 87
        '
        'DETALLE
        '
        Me.DETALLE.HeaderText = "DETALLE"
        Me.DETALLE.Name = "DETALLE"
        Me.DETALLE.ReadOnly = True
        Me.DETALLE.Width = 83
        '
        'SUBTOTAL
        '
        Me.SUBTOTAL.HeaderText = "SUBTOTAL (Q)"
        Me.SUBTOTAL.Name = "SUBTOTAL"
        Me.SUBTOTAL.ReadOnly = True
        Me.SUBTOTAL.Width = 106
        '
        'serrie
        '
        Me.serrie.HeaderText = "NUMERO DE SERIE"
        Me.serrie.MaxInputLength = 500
        Me.serrie.Name = "serrie"
        Me.serrie.Width = 104
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(356, 376)
        Me.Splitter1.TabIndex = 0
        Me.Splitter1.TabStop = False
        '
        'btImprimir
        '
        Me.btImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btImprimir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btImprimir.Image = Global.POS.My.Resources.Resources.cart__24_
        Me.btImprimir.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btImprimir.Location = New System.Drawing.Point(1147, 25)
        Me.btImprimir.Name = "btImprimir"
        Me.btImprimir.Size = New System.Drawing.Size(91, 121)
        Me.btImprimir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btImprimir.TabIndex = 1
        Me.btImprimir.Text = "Nueva Venta"
        '
        'btGuardar
        '
        Me.btGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btGuardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btGuardar.Enabled = False
        Me.btGuardar.Image = Global.POS.My.Resources.Resources.sales__3_
        Me.btGuardar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btGuardar.Location = New System.Drawing.Point(1046, 25)
        Me.btGuardar.Name = "btGuardar"
        Me.btGuardar.Size = New System.Drawing.Size(91, 121)
        Me.btGuardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btGuardar.TabIndex = 0
        Me.btGuardar.Text = "Enviar a Caja"
        '
        'btCGuardar
        '
        Me.btCGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btCGuardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btCGuardar.Enabled = False
        Me.btCGuardar.Image = Global.POS.My.Resources.Resources._8430
        Me.btCGuardar.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.btCGuardar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btCGuardar.Location = New System.Drawing.Point(339, 72)
        Me.btCGuardar.Name = "btCGuardar"
        Me.btCGuardar.Size = New System.Drawing.Size(57, 42)
        Me.btCGuardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btCGuardar.TabIndex = 1
        '
        'txNit
        '
        Me.txNit.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txNit.Border.Class = "TextBoxBorder"
        Me.txNit.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txNit.ForeColor = System.Drawing.Color.Black
        Me.txNit.Location = New System.Drawing.Point(9, 41)
        Me.txNit.Name = "txNit"
        Me.txNit.Size = New System.Drawing.Size(137, 25)
        Me.txNit.TabIndex = 0
        Me.txNit.Text = "C/F"
        Me.txNit.WatermarkImage = Global.POS.My.Resources.Resources.zoom
        Me.txNit.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'btBuscar
        '
        Me.btBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btBuscar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btBuscar.Image = Global.POS.My.Resources.Resources.zoom
        Me.btBuscar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btBuscar.Location = New System.Drawing.Point(241, 44)
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(58, 55)
        Me.btBuscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btBuscar.TabIndex = 2
        Me.btBuscar.Text = "Buscar"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.POS.My.Resources.Resources.barcode__29_
        Me.PictureBox1.Location = New System.Drawing.Point(16, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 43)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'btQuitarLista
        '
        Me.btQuitarLista.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btQuitarLista.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btQuitarLista.Image = Global.POS.My.Resources.Resources.cart__14_
        Me.btQuitarLista.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.btQuitarLista.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btQuitarLista.Location = New System.Drawing.Point(241, 236)
        Me.btQuitarLista.Name = "btQuitarLista"
        Me.btQuitarLista.Size = New System.Drawing.Size(57, 55)
        Me.btQuitarLista.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btQuitarLista.TabIndex = 6
        Me.btQuitarLista.Text = "Remover"
        '
        'btAgregarLista
        '
        Me.btAgregarLista.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btAgregarLista.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btAgregarLista.Enabled = False
        Me.btAgregarLista.Image = Global.POS.My.Resources.Resources.cart__4_
        Me.btAgregarLista.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.btAgregarLista.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btAgregarLista.Location = New System.Drawing.Point(241, 172)
        Me.btAgregarLista.Name = "btAgregarLista"
        Me.btAgregarLista.Size = New System.Drawing.Size(58, 55)
        Me.btAgregarLista.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btAgregarLista.TabIndex = 5
        Me.btAgregarLista.Text = "Agregar"
        '
        'btBStock
        '
        Me.btBStock.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btBStock.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btBStock.Image = Global.POS.My.Resources.Resources.inventary__26_
        Me.btBStock.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.btBStock.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btBStock.Location = New System.Drawing.Point(242, 108)
        Me.btBStock.Name = "btBStock"
        Me.btBStock.Size = New System.Drawing.Size(57, 55)
        Me.btBStock.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btBStock.TabIndex = 4
        Me.btBStock.Text = "Stock"
        '
        'ctrlFacturar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.Controls.Add(Me.Container)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ctrlFacturar"
        Me.Size = New System.Drawing.Size(1251, 537)
        Me.Container.Panel1.ResumeLayout(False)
        Me.Container.Panel2.ResumeLayout(False)
        CType(Me.Container, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Container.ResumeLayout(False)
        Me.gb3.ResumeLayout(False)
        Me.gb3.PerformLayout()
        CType(Me.txDescuento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.txCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Container As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txDireccion As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txNombre As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txNit As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btImprimir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btGuardar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents gb3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lbTotal As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lbDscto As System.Windows.Forms.Label
    Friend WithEvents lbNarticulo As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dgD As System.Windows.Forms.DataGridView
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txMa As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btBStock As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lbSubtotal As System.Windows.Forms.Label
    Friend WithEvents LbPrecioU As System.Windows.Forms.Label
    Friend WithEvents lbModelo As System.Windows.Forms.Label
    Friend WithEvents lbMarca As System.Windows.Forms.Label
    Friend WithEvents lbCodigo As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btAgregarLista As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btQuitarLista As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btCGuardar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents lbStock As System.Windows.Forms.Label
    Friend WithEvents lbTipo As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txMo As System.Windows.Forms.TextBox
    Friend WithEvents btBuscar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txCantidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents txDescuento As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents marca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents modelo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CODIGO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NMARCA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NMODELO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DETALLE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SUBTOTAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents serrie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbSt As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label

End Class

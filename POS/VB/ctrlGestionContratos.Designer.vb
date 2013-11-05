<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlGestionContratos
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
        Me.components = New System.ComponentModel.Container()
        Me.ReflectionLabel2 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btUpdate = New DevComponents.DotNetBar.ButtonX()
        Me.dgD = New System.Windows.Forms.DataGridView()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CREDITOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._DS = New POS._DS()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbFTelefono = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbFDireccion = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lbFbienes = New System.Windows.Forms.Label()
        Me.lbFTipo = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lbFingreso = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lbFnit = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lbFDPI = New System.Windows.Forms.Label()
        Me.lbFApellido = New System.Windows.Forms.Label()
        Me.lbFNombre = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbCTelefono = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbCDireccion = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbCBienes = New System.Windows.Forms.Label()
        Me.lbCtipo = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbCIngreso = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbCNit = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbCdpi = New System.Windows.Forms.Label()
        Me.lbCApellido = New System.Windows.Forms.Label()
        Me.lbcNombre = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btAceptar = New DevComponents.DotNetBar.ButtonX()
        Me.btAnular = New DevComponents.DotNetBar.ButtonX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CREDITOSTableAdapter = New POS._DSTableAdapters.CREDITOSTableAdapter()
        Me.TableAdapterManager = New POS._DSTableAdapters.TableAdapterManager()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CREDITOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._DS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
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
        Me.ReflectionLabel2.Location = New System.Drawing.Point(20, 7)
        Me.ReflectionLabel2.Margin = New System.Windows.Forms.Padding(20)
        Me.ReflectionLabel2.Name = "ReflectionLabel2"
        Me.ReflectionLabel2.ReflectionEnabled = False
        Me.ReflectionLabel2.Size = New System.Drawing.Size(567, 42)
        Me.ReflectionLabel2.TabIndex = 15
        Me.ReflectionLabel2.Text = "<font size=""+6"">Administrador de Solicitudes de<font color=""#32b8ff""> Contratos</" & _
    "font></font>"
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.btUpdate)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ReflectionLabel2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgD)
        Me.SplitContainer1.Panel2.Controls.Add(Me.dg)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btAceptar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btAnular)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1245, 547)
        Me.SplitContainer1.SplitterDistance = 54
        Me.SplitContainer1.TabIndex = 16
        '
        'btUpdate
        '
        Me.btUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btUpdate.Image = Global.POS.My.Resources.Resources._12130
        Me.btUpdate.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.btUpdate.Location = New System.Drawing.Point(1189, 7)
        Me.btUpdate.Name = "btUpdate"
        Me.btUpdate.Size = New System.Drawing.Size(46, 42)
        Me.btUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btUpdate.TabIndex = 17
        '
        'dgD
        '
        Me.dgD.AllowUserToAddRows = False
        Me.dgD.AllowUserToDeleteRows = False
        Me.dgD.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgD.Location = New System.Drawing.Point(20, 231)
        Me.dgD.Name = "dgD"
        Me.dgD.ReadOnly = True
        Me.dgD.Size = New System.Drawing.Size(552, 220)
        Me.dgD.TabIndex = 16
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.AutoGenerateColumns = False
        Me.dg.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15})
        Me.dg.DataSource = Me.CREDITOSBindingSource
        Me.dg.Location = New System.Drawing.Point(20, 39)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(552, 161)
        Me.dg.TabIndex = 16
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CLIENTE"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CLIENTE"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FIADOR"
        Me.DataGridViewTextBoxColumn2.HeaderText = "FIADOR"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ESTADO"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ESTADO"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "FECHA"
        Me.DataGridViewTextBoxColumn4.HeaderText = "FECHA"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "SERIE"
        Me.DataGridViewTextBoxColumn5.HeaderText = "SERIE"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "NUMERO"
        Me.DataGridViewTextBoxColumn6.HeaderText = "NUMERO"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "TIENDA"
        Me.DataGridViewTextBoxColumn7.HeaderText = "TIENDA"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ENGANCHE"
        Me.DataGridViewTextBoxColumn8.HeaderText = "ENGANCHE"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "NO_CUOTA"
        Me.DataGridViewTextBoxColumn9.HeaderText = "NO_CUOTA"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "VALOR_CUOTA"
        Me.DataGridViewTextBoxColumn10.HeaderText = "VALOR_CUOTA"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "ULTIMA_CUOTA"
        Me.DataGridViewTextBoxColumn11.HeaderText = "ULTIMA_CUOTA"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "DESCUENTO"
        Me.DataGridViewTextBoxColumn12.HeaderText = "DESCUENTO"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "TOTAL"
        Me.DataGridViewTextBoxColumn13.HeaderText = "TOTAL"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "OBSERVACIONES"
        Me.DataGridViewTextBoxColumn14.HeaderText = "OBSERVACIONES"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "DETALLE"
        Me.DataGridViewTextBoxColumn15.HeaderText = "DETALLE"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Visible = False
        '
        'CREDITOSBindingSource
        '
        Me.CREDITOSBindingSource.DataMember = "CREDITOS"
        Me.CREDITOSBindingSource.DataSource = Me._DS
        '
        '_DS
        '
        Me._DS.DataSetName = "_DS"
        Me._DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.lbFTelefono)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.lbFDireccion)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.lbFbienes)
        Me.GroupBox2.Controls.Add(Me.lbFTipo)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.lbFingreso)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.lbFnit)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.lbFDPI)
        Me.GroupBox2.Controls.Add(Me.lbFApellido)
        Me.GroupBox2.Controls.Add(Me.lbFNombre)
        Me.GroupBox2.Location = New System.Drawing.Point(910, 29)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(325, 377)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Cliente Fiador"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 312)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 20)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "TELEFONO:"
        '
        'lbFTelefono
        '
        Me.lbFTelefono.AutoSize = True
        Me.lbFTelefono.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.lbFTelefono.Location = New System.Drawing.Point(51, 331)
        Me.lbFTelefono.Name = "lbFTelefono"
        Me.lbFTelefono.Size = New System.Drawing.Size(43, 19)
        Me.lbFTelefono.TabIndex = 14
        Me.lbFTelefono.Text = "CASA"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 263)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 20)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "DIRECCION:"
        '
        'lbFDireccion
        '
        Me.lbFDireccion.AutoSize = True
        Me.lbFDireccion.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.lbFDireccion.Location = New System.Drawing.Point(51, 282)
        Me.lbFDireccion.Name = "lbFDireccion"
        Me.lbFDireccion.Size = New System.Drawing.Size(43, 19)
        Me.lbFDireccion.TabIndex = 12
        Me.lbFDireccion.Text = "CASA"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(6, 212)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(62, 20)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "BIENES:"
        '
        'lbFbienes
        '
        Me.lbFbienes.AutoSize = True
        Me.lbFbienes.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.lbFbienes.Location = New System.Drawing.Point(51, 231)
        Me.lbFbienes.Name = "lbFbienes"
        Me.lbFbienes.Size = New System.Drawing.Size(43, 19)
        Me.lbFbienes.TabIndex = 10
        Me.lbFbienes.Text = "CASA"
        '
        'lbFTipo
        '
        Me.lbFTipo.AutoSize = True
        Me.lbFTipo.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.lbFTipo.Location = New System.Drawing.Point(51, 21)
        Me.lbFTipo.Name = "lbFTipo"
        Me.lbFTipo.Size = New System.Drawing.Size(19, 19)
        Me.lbFTipo.TabIndex = 9
        Me.lbFTipo.Text = "N"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(6, 21)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(41, 20)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "TIPO"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(6, 161)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(98, 20)
        Me.Label19.TabIndex = 7
        Me.Label19.Text = "INGRESOS Q:"
        '
        'lbFingreso
        '
        Me.lbFingreso.AutoSize = True
        Me.lbFingreso.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.lbFingreso.Location = New System.Drawing.Point(51, 180)
        Me.lbFingreso.Name = "lbFingreso"
        Me.lbFingreso.Size = New System.Drawing.Size(58, 19)
        Me.lbFingreso.TabIndex = 6
        Me.lbFingreso.Text = "Q.00.00"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(6, 130)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(33, 20)
        Me.Label21.TabIndex = 5
        Me.Label21.Text = "NIT"
        '
        'lbFnit
        '
        Me.lbFnit.AutoSize = True
        Me.lbFnit.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.lbFnit.Location = New System.Drawing.Point(52, 130)
        Me.lbFnit.Name = "lbFnit"
        Me.lbFnit.Size = New System.Drawing.Size(30, 19)
        Me.lbFnit.TabIndex = 4
        Me.lbFnit.Text = "NIT"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(6, 46)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(33, 20)
        Me.Label23.TabIndex = 3
        Me.Label23.Text = "DPI"
        '
        'lbFDPI
        '
        Me.lbFDPI.AutoSize = True
        Me.lbFDPI.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.lbFDPI.Location = New System.Drawing.Point(51, 46)
        Me.lbFDPI.Name = "lbFDPI"
        Me.lbFDPI.Size = New System.Drawing.Size(31, 19)
        Me.lbFDPI.TabIndex = 2
        Me.lbFDPI.Text = "DPI"
        '
        'lbFApellido
        '
        Me.lbFApellido.AutoSize = True
        Me.lbFApellido.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.lbFApellido.Location = New System.Drawing.Point(51, 97)
        Me.lbFApellido.Name = "lbFApellido"
        Me.lbFApellido.Size = New System.Drawing.Size(123, 19)
        Me.lbFApellido.TabIndex = 1
        Me.lbFApellido.Text = "Nombre Completo"
        '
        'lbFNombre
        '
        Me.lbFNombre.AutoSize = True
        Me.lbFNombre.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.lbFNombre.Location = New System.Drawing.Point(51, 78)
        Me.lbFNombre.Name = "lbFNombre"
        Me.lbFNombre.Size = New System.Drawing.Size(123, 19)
        Me.lbFNombre.TabIndex = 0
        Me.lbFNombre.Text = "Nombre Completo"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.lbCTelefono)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.lbCDireccion)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lbCBienes)
        Me.GroupBox1.Controls.Add(Me.lbCtipo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lbCIngreso)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lbCNit)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lbCdpi)
        Me.GroupBox1.Controls.Add(Me.lbCApellido)
        Me.GroupBox1.Controls.Add(Me.lbcNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(579, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(325, 377)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Cliente Titular"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 312)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 20)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "TELEFONO:"
        '
        'lbCTelefono
        '
        Me.lbCTelefono.AutoSize = True
        Me.lbCTelefono.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.lbCTelefono.Location = New System.Drawing.Point(51, 331)
        Me.lbCTelefono.Name = "lbCTelefono"
        Me.lbCTelefono.Size = New System.Drawing.Size(43, 19)
        Me.lbCTelefono.TabIndex = 14
        Me.lbCTelefono.Text = "CASA"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 263)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 20)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "DIRECCION:"
        '
        'lbCDireccion
        '
        Me.lbCDireccion.AutoSize = True
        Me.lbCDireccion.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.lbCDireccion.Location = New System.Drawing.Point(51, 282)
        Me.lbCDireccion.Name = "lbCDireccion"
        Me.lbCDireccion.Size = New System.Drawing.Size(43, 19)
        Me.lbCDireccion.TabIndex = 12
        Me.lbCDireccion.Text = "CASA"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 212)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 20)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "BIENES:"
        '
        'lbCBienes
        '
        Me.lbCBienes.AutoSize = True
        Me.lbCBienes.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.lbCBienes.Location = New System.Drawing.Point(51, 231)
        Me.lbCBienes.Name = "lbCBienes"
        Me.lbCBienes.Size = New System.Drawing.Size(43, 19)
        Me.lbCBienes.TabIndex = 10
        Me.lbCBienes.Text = "CASA"
        '
        'lbCtipo
        '
        Me.lbCtipo.AutoSize = True
        Me.lbCtipo.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.lbCtipo.Location = New System.Drawing.Point(51, 21)
        Me.lbCtipo.Name = "lbCtipo"
        Me.lbCtipo.Size = New System.Drawing.Size(19, 19)
        Me.lbCtipo.TabIndex = 9
        Me.lbCtipo.Text = "N"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "TIPO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 161)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 20)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "INGRESOS Q:"
        '
        'lbCIngreso
        '
        Me.lbCIngreso.AutoSize = True
        Me.lbCIngreso.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.lbCIngreso.Location = New System.Drawing.Point(51, 180)
        Me.lbCIngreso.Name = "lbCIngreso"
        Me.lbCIngreso.Size = New System.Drawing.Size(58, 19)
        Me.lbCIngreso.TabIndex = 6
        Me.lbCIngreso.Text = "Q.00.00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "NIT"
        '
        'lbCNit
        '
        Me.lbCNit.AutoSize = True
        Me.lbCNit.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.lbCNit.Location = New System.Drawing.Point(52, 130)
        Me.lbCNit.Name = "lbCNit"
        Me.lbCNit.Size = New System.Drawing.Size(30, 19)
        Me.lbCNit.TabIndex = 4
        Me.lbCNit.Text = "NIT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "DPI"
        '
        'lbCdpi
        '
        Me.lbCdpi.AutoSize = True
        Me.lbCdpi.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.lbCdpi.Location = New System.Drawing.Point(51, 46)
        Me.lbCdpi.Name = "lbCdpi"
        Me.lbCdpi.Size = New System.Drawing.Size(31, 19)
        Me.lbCdpi.TabIndex = 2
        Me.lbCdpi.Text = "DPI"
        '
        'lbCApellido
        '
        Me.lbCApellido.AutoSize = True
        Me.lbCApellido.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.lbCApellido.Location = New System.Drawing.Point(51, 97)
        Me.lbCApellido.Name = "lbCApellido"
        Me.lbCApellido.Size = New System.Drawing.Size(123, 19)
        Me.lbCApellido.TabIndex = 1
        Me.lbCApellido.Text = "Nombre Completo"
        '
        'lbcNombre
        '
        Me.lbcNombre.AutoSize = True
        Me.lbcNombre.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.lbcNombre.Location = New System.Drawing.Point(51, 78)
        Me.lbcNombre.Name = "lbcNombre"
        Me.lbcNombre.Size = New System.Drawing.Size(123, 19)
        Me.lbcNombre.TabIndex = 0
        Me.lbcNombre.Text = "Nombre Completo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Detalle Del Pedido"
        '
        'btAceptar
        '
        Me.btAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btAceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btAceptar.Image = Global.POS.My.Resources.Resources.contrat__27_
        Me.btAceptar.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.btAceptar.Location = New System.Drawing.Point(1082, 412)
        Me.btAceptar.Name = "btAceptar"
        Me.btAceptar.Size = New System.Drawing.Size(153, 45)
        Me.btAceptar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btAceptar.TabIndex = 5
        Me.btAceptar.Text = "Aceptar Contrato"
        '
        'btAnular
        '
        Me.btAnular.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btAnular.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btAnular.Image = Global.POS.My.Resources.Resources.contrat__14_
        Me.btAnular.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.btAnular.Location = New System.Drawing.Point(923, 412)
        Me.btAnular.Name = "btAnular"
        Me.btAnular.Size = New System.Drawing.Size(153, 45)
        Me.btAnular.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btAnular.TabIndex = 4
        Me.btAnular.Text = "Anular Contrato"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Seleccione el Contrato"
        '
        'CREDITOSTableAdapter
        '
        Me.CREDITOSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CL_PLANTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = POS._DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ctrlGestionContratos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ctrlGestionContratos"
        Me.Size = New System.Drawing.Size(1245, 547)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CREDITOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._DS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReflectionLabel2 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents btAceptar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btAnular As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbCApellido As System.Windows.Forms.Label
    Friend WithEvents lbcNombre As System.Windows.Forms.Label
    Friend WithEvents lbCtipo As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbCIngreso As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbCNit As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbCdpi As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lbFTelefono As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lbFDireccion As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lbFbienes As System.Windows.Forms.Label
    Friend WithEvents lbFTipo As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents lbFingreso As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents lbFnit As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents lbFDPI As System.Windows.Forms.Label
    Friend WithEvents lbFApellido As System.Windows.Forms.Label
    Friend WithEvents lbFNombre As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lbCTelefono As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbCDireccion As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lbCBienes As System.Windows.Forms.Label
    Friend WithEvents _DS As POS._DS
    Friend WithEvents CREDITOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CREDITOSTableAdapter As POS._DSTableAdapters.CREDITOSTableAdapter
    Friend WithEvents TableAdapterManager As POS._DSTableAdapters.TableAdapterManager
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgD As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btUpdate As DevComponents.DotNetBar.ButtonX

End Class

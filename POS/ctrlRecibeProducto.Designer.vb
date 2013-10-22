<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlRecibeProducto
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
        Dim FECHA_SALIDALabel As System.Windows.Forms.Label
        Dim SERIELabel As System.Windows.Forms.Label
        Dim SALELabel As System.Windows.Forms.Label
        Dim DESTINOLabel As System.Windows.Forms.Label
        Dim DIRECCIONLabel As System.Windows.Forms.Label
        Me.ReflectionLabel1 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btBuscar = New DevComponents.DotNetBar.ButtonX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.label_ = New System.Windows.Forms.Label()
        Me.txCorrelativo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txSerie = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.PedidoDataGridView = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btAceptar = New DevComponents.DotNetBar.ButtonX()
        Me.CANTIDADDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MARCADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MODELODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCRIPCIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USADOSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecepcionProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._DS = New POS._DS()
        Me.RecepcionProductoTableAdapter = New POS._DSTableAdapters.RecepcionProductoTableAdapter()
        Me.TableAdapterManager = New POS._DSTableAdapters.TableAdapterManager()
        Me.SERIELabel2 = New System.Windows.Forms.Label()
        Me.CORRELATIVOLabel1 = New System.Windows.Forms.Label()
        Me.FECHA_SALIDALabel2 = New System.Windows.Forms.Label()
        Me.DESTINOLabel2 = New System.Windows.Forms.Label()
        Me.DIRECCIONLabel2 = New System.Windows.Forms.Label()
        Me.SALELabel2 = New System.Windows.Forms.Label()
        FECHA_SALIDALabel = New System.Windows.Forms.Label()
        SERIELabel = New System.Windows.Forms.Label()
        SALELabel = New System.Windows.Forms.Label()
        DESTINOLabel = New System.Windows.Forms.Label()
        DIRECCIONLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PedidoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.RecepcionProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._DS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReflectionLabel1
        '
        Me.ReflectionLabel1.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.ReflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel1.Font = New System.Drawing.Font("Segoe UI Light", 16.25!)
        Me.ReflectionLabel1.Location = New System.Drawing.Point(23, 26)
        Me.ReflectionLabel1.Margin = New System.Windows.Forms.Padding(23, 26, 23, 26)
        Me.ReflectionLabel1.Name = "ReflectionLabel1"
        Me.ReflectionLabel1.ReflectionEnabled = False
        Me.ReflectionLabel1.Size = New System.Drawing.Size(334, 52)
        Me.ReflectionLabel1.TabIndex = 11
        Me.ReflectionLabel1.Text = "<font size=""+6"">Recepcion de <font color=""#32b8ff""> Producto</font></font>"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btBuscar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.label_)
        Me.GroupBox1.Controls.Add(Me.txCorrelativo)
        Me.GroupBox1.Controls.Add(Me.txSerie)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 87)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(352, 79)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar"
        '
        'btBuscar
        '
        Me.btBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btBuscar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btBuscar.Image = Global.POS.My.Resources.Resources.zoom
        Me.btBuscar.Location = New System.Drawing.Point(214, 25)
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(52, 40)
        Me.btBuscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btBuscar.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 17)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Serie"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(96, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Correlativo"
        '
        'label_
        '
        Me.label_.AutoSize = True
        Me.label_.Location = New System.Drawing.Point(78, 40)
        Me.label_.Name = "label_"
        Me.label_.Size = New System.Drawing.Size(18, 17)
        Me.label_.TabIndex = 2
        Me.label_.Text = "__"
        '
        'txCorrelativo
        '
        Me.txCorrelativo.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txCorrelativo.Border.Class = "TextBoxBorder"
        Me.txCorrelativo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txCorrelativo.ForeColor = System.Drawing.Color.Black
        Me.txCorrelativo.Location = New System.Drawing.Point(99, 40)
        Me.txCorrelativo.Name = "txCorrelativo"
        Me.txCorrelativo.Size = New System.Drawing.Size(100, 25)
        Me.txCorrelativo.TabIndex = 1
        '
        'txSerie
        '
        Me.txSerie.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txSerie.Border.Class = "TextBoxBorder"
        Me.txSerie.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txSerie.ForeColor = System.Drawing.Color.Black
        Me.txSerie.Location = New System.Drawing.Point(18, 40)
        Me.txSerie.MaxLength = 3
        Me.txSerie.Name = "txSerie"
        Me.txSerie.Size = New System.Drawing.Size(58, 25)
        Me.txSerie.TabIndex = 0
        '
        'PedidoDataGridView
        '
        Me.PedidoDataGridView.AllowUserToAddRows = False
        Me.PedidoDataGridView.AllowUserToDeleteRows = False
        Me.PedidoDataGridView.AutoGenerateColumns = False
        Me.PedidoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.PedidoDataGridView.BackgroundColor = System.Drawing.SystemColors.Window
        Me.PedidoDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PedidoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PedidoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CANTIDADDataGridViewTextBoxColumn, Me.MARCADataGridViewTextBoxColumn, Me.MODELODataGridViewTextBoxColumn, Me.DESCRIPCIONDataGridViewTextBoxColumn, Me.USADOSDataGridViewTextBoxColumn})
        Me.PedidoDataGridView.DataSource = Me.RecepcionProductoBindingSource
        Me.PedidoDataGridView.Location = New System.Drawing.Point(372, 99)
        Me.PedidoDataGridView.Name = "PedidoDataGridView"
        Me.PedidoDataGridView.ReadOnly = True
        Me.PedidoDataGridView.Size = New System.Drawing.Size(615, 317)
        Me.PedidoDataGridView.TabIndex = 12
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.SALELabel2)
        Me.GroupBox2.Controls.Add(Me.DIRECCIONLabel2)
        Me.GroupBox2.Controls.Add(Me.DESTINOLabel2)
        Me.GroupBox2.Controls.Add(Me.FECHA_SALIDALabel2)
        Me.GroupBox2.Controls.Add(Me.CORRELATIVOLabel1)
        Me.GroupBox2.Controls.Add(Me.SERIELabel2)
        Me.GroupBox2.Controls.Add(Me.btAceptar)
        Me.GroupBox2.Controls.Add(DIRECCIONLabel)
        Me.GroupBox2.Controls.Add(DESTINOLabel)
        Me.GroupBox2.Controls.Add(SALELabel)
        Me.GroupBox2.Controls.Add(SERIELabel)
        Me.GroupBox2.Controls.Add(FECHA_SALIDALabel)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 173)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(352, 243)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informacion del Movimiento"
        '
        'FECHA_SALIDALabel
        '
        FECHA_SALIDALabel.AutoSize = True
        FECHA_SALIDALabel.Location = New System.Drawing.Point(12, 48)
        FECHA_SALIDALabel.Name = "FECHA_SALIDALabel"
        FECHA_SALIDALabel.Size = New System.Drawing.Size(94, 17)
        FECHA_SALIDALabel.TabIndex = 0
        FECHA_SALIDALabel.Text = "FECHA SALIDA:"
        '
        'SERIELabel
        '
        SERIELabel.AutoSize = True
        SERIELabel.Location = New System.Drawing.Point(12, 25)
        SERIELabel.Name = "SERIELabel"
        SERIELabel.Size = New System.Drawing.Size(60, 17)
        SERIELabel.TabIndex = 2
        SERIELabel.Text = "CODIGO:"
        '
        'SALELabel
        '
        SALELabel.AutoSize = True
        SALELabel.Location = New System.Drawing.Point(12, 74)
        SALELabel.Name = "SALELabel"
        SALELabel.Size = New System.Drawing.Size(39, 17)
        SALELabel.TabIndex = 5
        SALELabel.Text = "SALE:"
        '
        'DESTINOLabel
        '
        DESTINOLabel.AutoSize = True
        DESTINOLabel.Location = New System.Drawing.Point(12, 101)
        DESTINOLabel.Name = "DESTINOLabel"
        DESTINOLabel.Size = New System.Drawing.Size(64, 17)
        DESTINOLabel.TabIndex = 7
        DESTINOLabel.Text = "DESTINO:"
        '
        'DIRECCIONLabel
        '
        DIRECCIONLabel.AutoSize = True
        DIRECCIONLabel.Location = New System.Drawing.Point(15, 128)
        DIRECCIONLabel.Name = "DIRECCIONLabel"
        DIRECCIONLabel.Size = New System.Drawing.Size(77, 17)
        DIRECCIONLabel.TabIndex = 9
        DIRECCIONLabel.Text = "DIRECCION:"
        '
        'btAceptar
        '
        Me.btAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btAceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btAceptar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAceptar.Image = Global.POS.My.Resources.Resources.ProductsAcept
        Me.btAceptar.Location = New System.Drawing.Point(18, 163)
        Me.btAceptar.Name = "btAceptar"
        Me.btAceptar.Size = New System.Drawing.Size(319, 63)
        Me.btAceptar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btAceptar.TabIndex = 11
        Me.btAceptar.Text = "    Aceptar Producto (s)"
        '
        'CANTIDADDataGridViewTextBoxColumn
        '
        Me.CANTIDADDataGridViewTextBoxColumn.DataPropertyName = "CANTIDAD"
        Me.CANTIDADDataGridViewTextBoxColumn.HeaderText = "CANTIDAD"
        Me.CANTIDADDataGridViewTextBoxColumn.Name = "CANTIDADDataGridViewTextBoxColumn"
        Me.CANTIDADDataGridViewTextBoxColumn.ReadOnly = True
        Me.CANTIDADDataGridViewTextBoxColumn.Width = 95
        '
        'MARCADataGridViewTextBoxColumn
        '
        Me.MARCADataGridViewTextBoxColumn.DataPropertyName = "MARCA"
        Me.MARCADataGridViewTextBoxColumn.HeaderText = "MARCA"
        Me.MARCADataGridViewTextBoxColumn.Name = "MARCADataGridViewTextBoxColumn"
        Me.MARCADataGridViewTextBoxColumn.ReadOnly = True
        Me.MARCADataGridViewTextBoxColumn.Width = 77
        '
        'MODELODataGridViewTextBoxColumn
        '
        Me.MODELODataGridViewTextBoxColumn.DataPropertyName = "MODELO"
        Me.MODELODataGridViewTextBoxColumn.HeaderText = "MODELO"
        Me.MODELODataGridViewTextBoxColumn.Name = "MODELODataGridViewTextBoxColumn"
        Me.MODELODataGridViewTextBoxColumn.ReadOnly = True
        Me.MODELODataGridViewTextBoxColumn.Width = 87
        '
        'DESCRIPCIONDataGridViewTextBoxColumn
        '
        Me.DESCRIPCIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPCION"
        Me.DESCRIPCIONDataGridViewTextBoxColumn.HeaderText = "DESCRIPCION"
        Me.DESCRIPCIONDataGridViewTextBoxColumn.Name = "DESCRIPCIONDataGridViewTextBoxColumn"
        Me.DESCRIPCIONDataGridViewTextBoxColumn.ReadOnly = True
        Me.DESCRIPCIONDataGridViewTextBoxColumn.Width = 113
        '
        'USADOSDataGridViewTextBoxColumn
        '
        Me.USADOSDataGridViewTextBoxColumn.DataPropertyName = "USADOS"
        Me.USADOSDataGridViewTextBoxColumn.HeaderText = "USADOS"
        Me.USADOSDataGridViewTextBoxColumn.Name = "USADOSDataGridViewTextBoxColumn"
        Me.USADOSDataGridViewTextBoxColumn.ReadOnly = True
        Me.USADOSDataGridViewTextBoxColumn.Width = 83
        '
        'RecepcionProductoBindingSource
        '
        Me.RecepcionProductoBindingSource.DataMember = "RecepcionProducto"
        Me.RecepcionProductoBindingSource.DataSource = Me._DS
        '
        '_DS
        '
        Me._DS.DataSetName = "_DS"
        Me._DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RecepcionProductoTableAdapter
        '
        Me.RecepcionProductoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = POS._DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SERIELabel2
        '
        Me.SERIELabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecepcionProductoBindingSource, "SERIE", True))
        Me.SERIELabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SERIELabel2.ForeColor = System.Drawing.Color.Maroon
        Me.SERIELabel2.Location = New System.Drawing.Point(112, 25)
        Me.SERIELabel2.Name = "SERIELabel2"
        Me.SERIELabel2.Size = New System.Drawing.Size(47, 23)
        Me.SERIELabel2.TabIndex = 12
        '
        'CORRELATIVOLabel1
        '
        Me.CORRELATIVOLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecepcionProductoBindingSource, "CORRELATIVO", True))
        Me.CORRELATIVOLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CORRELATIVOLabel1.ForeColor = System.Drawing.Color.Maroon
        Me.CORRELATIVOLabel1.Location = New System.Drawing.Point(156, 25)
        Me.CORRELATIVOLabel1.Name = "CORRELATIVOLabel1"
        Me.CORRELATIVOLabel1.Size = New System.Drawing.Size(100, 23)
        Me.CORRELATIVOLabel1.TabIndex = 13
        '
        'FECHA_SALIDALabel2
        '
        Me.FECHA_SALIDALabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecepcionProductoBindingSource, "FECHA_SALIDA", True))
        Me.FECHA_SALIDALabel2.Location = New System.Drawing.Point(112, 48)
        Me.FECHA_SALIDALabel2.Name = "FECHA_SALIDALabel2"
        Me.FECHA_SALIDALabel2.Size = New System.Drawing.Size(154, 23)
        Me.FECHA_SALIDALabel2.TabIndex = 14
        '
        'DESTINOLabel2
        '
        Me.DESTINOLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecepcionProductoBindingSource, "DESTINO", True))
        Me.DESTINOLabel2.Location = New System.Drawing.Point(112, 101)
        Me.DESTINOLabel2.Name = "DESTINOLabel2"
        Me.DESTINOLabel2.Size = New System.Drawing.Size(154, 23)
        Me.DESTINOLabel2.TabIndex = 15
        '
        'DIRECCIONLabel2
        '
        Me.DIRECCIONLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecepcionProductoBindingSource, "DIRECCION", True))
        Me.DIRECCIONLabel2.Location = New System.Drawing.Point(112, 128)
        Me.DIRECCIONLabel2.Name = "DIRECCIONLabel2"
        Me.DIRECCIONLabel2.Size = New System.Drawing.Size(100, 23)
        Me.DIRECCIONLabel2.TabIndex = 16
        '
        'SALELabel2
        '
        Me.SALELabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecepcionProductoBindingSource, "SALE", True))
        Me.SALELabel2.Location = New System.Drawing.Point(112, 74)
        Me.SALELabel2.Name = "SALELabel2"
        Me.SALELabel2.Size = New System.Drawing.Size(100, 23)
        Me.SALELabel2.TabIndex = 17
        '
        'ctrlRecibeProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PedidoDataGridView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ReflectionLabel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ctrlRecibeProducto"
        Me.Size = New System.Drawing.Size(994, 442)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PedidoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.RecepcionProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._DS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReflectionLabel1 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents label_ As System.Windows.Forms.Label
    Friend WithEvents txCorrelativo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txSerie As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btBuscar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PedidoDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btAceptar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents _DS As POS._DS
    Friend WithEvents RecepcionProductoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RecepcionProductoTableAdapter As POS._DSTableAdapters.RecepcionProductoTableAdapter
    Friend WithEvents TableAdapterManager As POS._DSTableAdapters.TableAdapterManager
    Friend WithEvents CANTIDADDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MARCADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MODELODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESCRIPCIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents USADOSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SALELabel2 As System.Windows.Forms.Label
    Friend WithEvents DIRECCIONLabel2 As System.Windows.Forms.Label
    Friend WithEvents DESTINOLabel2 As System.Windows.Forms.Label
    Friend WithEvents FECHA_SALIDALabel2 As System.Windows.Forms.Label
    Friend WithEvents CORRELATIVOLabel1 As System.Windows.Forms.Label
    Friend WithEvents SERIELabel2 As System.Windows.Forms.Label

End Class

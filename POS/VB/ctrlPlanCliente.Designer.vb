<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlPlanCliente
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
        Me.ReflectionLabel1 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbCategoria = New System.Windows.Forms.ComboBox()
        Me.cbPlan = New System.Windows.Forms.ComboBox()
        Me._DS = New POS._DS()
        Me.CL_PLANBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CL_PLANTableAdapter = New POS._DSTableAdapters.CL_PLANTableAdapter()
        Me.TableAdapterManager = New POS._DSTableAdapters.TableAdapterManager()
        Me.CL_PLANDataGridView = New System.Windows.Forms.DataGridView()
        Me.btGuarda = New DevComponents.DotNetBar.ButtonX()
        Me.btBuscar = New DevComponents.DotNetBar.ButtonX()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me._DS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CL_PLANBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CL_PLANDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReflectionLabel1
        '
        '
        '
        '
        Me.ReflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel1.Font = New System.Drawing.Font("Segoe UI Light", 16.25!)
        Me.ReflectionLabel1.Location = New System.Drawing.Point(23, 26)
        Me.ReflectionLabel1.Margin = New System.Windows.Forms.Padding(23, 26, 23, 26)
        Me.ReflectionLabel1.Name = "ReflectionLabel1"
        Me.ReflectionLabel1.ReflectionEnabled = False
        Me.ReflectionLabel1.Size = New System.Drawing.Size(357, 58)
        Me.ReflectionLabel1.TabIndex = 28
        Me.ReflectionLabel1.Text = "<font size=""+6"">Planes de credito<font color=""#32b8ff""> Cliente</font></font>"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btGuarda)
        Me.GroupBox1.Controls.Add(Me.btBuscar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbCategoria)
        Me.GroupBox1.Controls.Add(Me.cbPlan)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 72)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(862, 83)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de Clientes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(180, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Categoria Producto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tipo Cliente"
        '
        'cbCategoria
        '
        Me.cbCategoria.FormattingEnabled = True
        Me.cbCategoria.Location = New System.Drawing.Point(183, 48)
        Me.cbCategoria.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbCategoria.Name = "cbCategoria"
        Me.cbCategoria.Size = New System.Drawing.Size(140, 25)
        Me.cbCategoria.TabIndex = 1
        '
        'cbPlan
        '
        Me.cbPlan.FormattingEnabled = True
        Me.cbPlan.Location = New System.Drawing.Point(19, 48)
        Me.cbPlan.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbPlan.Name = "cbPlan"
        Me.cbPlan.Size = New System.Drawing.Size(140, 25)
        Me.cbPlan.TabIndex = 0
        '
        '_DS
        '
        Me._DS.DataSetName = "_DS"
        Me._DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CL_PLANBindingSource
        '
        Me.CL_PLANBindingSource.DataMember = "CL_PLAN"
        Me.CL_PLANBindingSource.DataSource = Me._DS
        '
        'CL_PLANTableAdapter
        '
        Me.CL_PLANTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CL_PLANTableAdapter = Me.CL_PLANTableAdapter
        Me.TableAdapterManager.UpdateOrder = POS._DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CL_PLANDataGridView
        '
        Me.CL_PLANDataGridView.AutoGenerateColumns = False
        Me.CL_PLANDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.CL_PLANDataGridView.BackgroundColor = System.Drawing.SystemColors.Window
        Me.CL_PLANDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CL_PLANDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.CL_PLANDataGridView.DataSource = Me.CL_PLANBindingSource
        Me.CL_PLANDataGridView.Location = New System.Drawing.Point(23, 176)
        Me.CL_PLANDataGridView.Name = "CL_PLANDataGridView"
        Me.CL_PLANDataGridView.Size = New System.Drawing.Size(862, 233)
        Me.CL_PLANDataGridView.TabIndex = 31
        '
        'btGuarda
        '
        Me.btGuarda.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btGuarda.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btGuarda.Image = Global.POS.My.Resources.Resources.diskette
        Me.btGuarda.Location = New System.Drawing.Point(411, 28)
        Me.btGuarda.Name = "btGuarda"
        Me.btGuarda.Size = New System.Drawing.Size(52, 45)
        Me.btGuarda.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btGuarda.TabIndex = 33
        '
        'btBuscar
        '
        Me.btBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btBuscar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btBuscar.Image = Global.POS.My.Resources.Resources.zoom
        Me.btBuscar.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.btBuscar.Location = New System.Drawing.Point(338, 28)
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(52, 45)
        Me.btBuscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btBuscar.TabIndex = 32
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IDCL_NIVEL"
        Me.DataGridViewTextBoxColumn1.HeaderText = "NIVEL CLIENTE"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn1.Width = 119
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "IDPR_CATEGORIA"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ID CATEGORIA"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.Width = 117
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "IDCL_PLAN"
        Me.DataGridViewTextBoxColumn3.HeaderText = "CORRELATIVO"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 116
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "MES_MIN"
        Me.DataGridViewTextBoxColumn4.HeaderText = "MES MINIMO"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 113
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "MES_MAX"
        Me.DataGridViewTextBoxColumn5.HeaderText = "MES MAXIMO"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 116
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "PORCENTAJE"
        Me.DataGridViewTextBoxColumn6.HeaderText = "PORCENTAJE"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 110
        '
        'ctrlPlanCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.Controls.Add(Me.CL_PLANDataGridView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ReflectionLabel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ctrlPlanCliente"
        Me.Size = New System.Drawing.Size(902, 430)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me._DS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CL_PLANBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CL_PLANDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReflectionLabel1 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbPlan As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents _DS As POS._DS
    Friend WithEvents CL_PLANBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CL_PLANTableAdapter As POS._DSTableAdapters.CL_PLANTableAdapter
    Friend WithEvents TableAdapterManager As POS._DSTableAdapters.TableAdapterManager
    Friend WithEvents CL_PLANDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents btBuscar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btGuarda As DevComponents.DotNetBar.ButtonX
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class

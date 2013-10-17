<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImprimir
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImprimir))
        Me.PedidoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._DS = New POS._DS()
        Me.PedidoTableAdapter = New POS._DSTableAdapters.PedidoTableAdapter()
        Me.rpt = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.PedidoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._DS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PedidoBindingSource
        '
        Me.PedidoBindingSource.DataMember = "Pedido"
        Me.PedidoBindingSource.DataSource = Me._DS
        '
        '_DS
        '
        Me._DS.DataSetName = "_DS"
        Me._DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PedidoTableAdapter
        '
        Me.PedidoTableAdapter.ClearBeforeFill = True
        '
        'rpt
        '
        Me.rpt.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DSEnvios"
        ReportDataSource1.Value = Me.PedidoBindingSource
        Me.rpt.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rpt.Location = New System.Drawing.Point(0, 0)
        Me.rpt.Name = "rpt"
        Me.rpt.Size = New System.Drawing.Size(653, 436)
        Me.rpt.TabIndex = 0
        '
        'frmImprimir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 436)
        Me.Controls.Add(Me.rpt)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmImprimir"
        Me.Text = "VISTA DE FORMATOS"
        CType(Me.PedidoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._DS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PedidoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents _DS As POS._DS
    Friend WithEvents PedidoTableAdapter As POS._DSTableAdapters.PedidoTableAdapter
    Friend WithEvents rpt As Microsoft.Reporting.WinForms.ReportViewer
End Class

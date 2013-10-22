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
        Me.ReflectionLabel1 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.SuspendLayout()
        '
        'ReflectionLabel1
        '
        '
        '
        '
        Me.ReflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel1.Font = New System.Drawing.Font("Segoe UI Light", 16.25!)
        Me.ReflectionLabel1.Location = New System.Drawing.Point(20, 20)
        Me.ReflectionLabel1.Margin = New System.Windows.Forms.Padding(20)
        Me.ReflectionLabel1.Name = "ReflectionLabel1"
        Me.ReflectionLabel1.ReflectionEnabled = False
        Me.ReflectionLabel1.Size = New System.Drawing.Size(306, 44)
        Me.ReflectionLabel1.TabIndex = 28
        Me.ReflectionLabel1.Text = "<font size=""+6"">Planes de credito<font color=""#32b8ff""> Cliente</font></font>"
        '
        'ctrlPlanCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.Controls.Add(Me.ReflectionLabel1)
        Me.Name = "ctrlPlanCliente"
        Me.Size = New System.Drawing.Size(578, 364)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReflectionLabel1 As DevComponents.DotNetBar.Controls.ReflectionLabel

End Class

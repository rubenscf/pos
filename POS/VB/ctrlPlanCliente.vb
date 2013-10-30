Public Class ctrlPlanCliente

    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        Try
            Me.CL_PLANTableAdapter.Fill(Me._DS.CL_PLAN, cbPlan.SelectedValue, CType(cbCategoria.SelectedValue, Decimal))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btGuarda_Click(sender As Object, e As EventArgs) Handles btGuarda.Click
        Me.Validate()
        Me.CL_PLANBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._DS)
    End Sub

    Private Sub ctrlPlanCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim q As String
        q = "select idcl_nivel as id, nombre from cl_nivel"
        _LLENAR_CMB(q, cbPlan)
        q = "select idpr_categoria as id, nombre from pr_categoria"
        _LLENAR_CMB(q, cbCategoria)
    End Sub
End Class

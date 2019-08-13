Public Class TotalSalesPerSuburbForm
    Private Sub CustomerBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CustomerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Group16DataSet)

    End Sub

    Private Sub TotalSalesPerSuburbForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group16DataSet.Customer_Quote' table. You can move, or remove it, as needed.
        Me.Customer_QuoteTableAdapter.Fill(Me.Group16DataSet.Customer_Quote)
        'TODO: This line of code loads data into the 'Group16DataSet.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.Group16DataSet.Customer)

        totalSalesPerSuburb1.SetDataSource(Group16DataSet)

    End Sub
End Class
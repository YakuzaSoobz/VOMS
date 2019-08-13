Public Class TotalSupplierCostPerSupplierForm
    Private Sub Supplier_QuoteBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Supplier_QuoteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Group16DataSet)

    End Sub

    Private Sub TotalSupplierCostPerSupplierForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group16DataSet.Supplier' table. You can move, or remove it, as needed.
        Me.SupplierTableAdapter.Fill(Me.Group16DataSet.Supplier)
        'TODO: This line of code loads data into the 'Group16DataSet.Supplier_Quote' table. You can move, or remove it, as needed.
        Me.Supplier_QuoteTableAdapter.Fill(Me.Group16DataSet.Supplier_Quote)

        totalSupplierCostPerSupplier1.SetDataSource(Group16DataSet)
    End Sub
End Class
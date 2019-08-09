Public Class TotalProductSalesForm
    Private Sub TotalProductSalesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Customer_QuoteTableAdapter1.Fill(Group16DataSet1.Customer_Quote)
        Customer_Quote_Line_ItemTableAdapter1.Fill(Group16DataSet1.Customer_Quote_Line_Item)
        ProductTableAdapter1.Fill(Group16DataSet1.Product)
        totalProductSales1.SetDataSource(Group16DataSet1)
    End Sub
End Class
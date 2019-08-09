Public Class TotalValueOfSalesPerItemForSelectMonthForm
    Private Sub TotalValueOfSalesPerItemForSelectMonthForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProductTableAdapter1.Fill(Group16DataSet1.Product)
        Customer_QuoteTableAdapter1.Fill(Group16DataSet1.Customer_Quote)
        Customer_Quote_Line_ItemTableAdapter1.Fill(Group16DataSet1.Customer_Quote_Line_Item)
        totalValueOfSalesPerItemForSelectMonth1.SetDataSource(Group16DataSet1)
    End Sub
End Class
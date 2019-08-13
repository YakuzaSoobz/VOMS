Public Class ProductSoldPerMonthReportForm
	Private Sub Product_Sales_Montly_ReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		ProductTableAdapter1.Fill(Group16DataSet1.Product)
		Customer_QuoteTableAdapter1.Fill(Group16DataSet1.Customer_Quote)
		Customer_Quote_Line_ItemTableAdapter1.Fill(Group16DataSet1.Customer_Quote_Line_Item)
		amountOfProductsSoldMonthlyPastYear1.SetDataSource(Group16DataSet1)

	End Sub
End Class
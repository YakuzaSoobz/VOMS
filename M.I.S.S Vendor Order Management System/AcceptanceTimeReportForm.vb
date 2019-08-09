Public Class AcceptanceTimeReportForm
    Private Sub AcceptanceTimeReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Customer_QuoteTableAdapter1.Fill(Group16DataSet1.Customer_Quote)
        CustomerTableAdapter1.Fill(Group16DataSet1.Customer)
        acceptanceTimeReport1.SetDataSource(Group16DataSet1)

    End Sub
End Class
Public Class CustomerIncomeForm
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        Me.Customer_QuoteTableAdapter1.Fill(Me.Group16DataSet1.Customer_Quote)
        Me.CustomerTableAdapter1.Fill(Me.Group16DataSet1.Customer)
        CustomerIncome1.SetDataSource(Group16DataSet1)

    End Sub
End Class
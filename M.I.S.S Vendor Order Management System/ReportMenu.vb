Public Class ReportMenu
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ReportMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ViewReportButton_Click(sender As Object, e As EventArgs) Handles ViewReportButton.Click
        If ReportComboBox.SelectedIndex = 0 Then

            AcceptanceTimeReportForm.Show()

        End If
        If ReportComboBox.SelectedIndex = 1 Then

            EmployeeSalesPerProductForm.Show()

        End If
        If ReportComboBox.SelectedIndex = 2 Then

            TotalProductSalesForm.Show()

        End If
        If ReportComboBox.SelectedIndex = 3 Then

            TotalValueOfSalesPerItemForSelectMonthForm.Show()

        End If
        If ReportComboBox.SelectedIndex = 4 Then

            TotalSupplierCostPerSupplierForm.Show()

        End If
        If ReportComboBox.SelectedIndex = 5 Then

            TotalSalesPerSuburbForm.Show()

        End If
        If ReportComboBox.SelectedIndex = 6 Then

            AmountOfProductSalesPerEmployeeLastYear.Show()

        End If
        If ReportComboBox.SelectedIndex = 7 Then

            AmountOfProductsSoldPerMonthForLastYear.Show()

        End If
        If ReportComboBox.SelectedIndex = 8 Then

            QuotationsPerMonth.Show()

        End If
        If ReportComboBox.SelectedIndex = 9 Then

            CustomerIncomeForm.Show()

        End If

    End Sub

    Private Sub ReportComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ReportComboBox.SelectedIndexChanged
        If ReportComboBox.SelectedIndex = 0 Then
            ReportDesc.Text = " How long it takes customers to accept a quote"
        End If
        If ReportComboBox.SelectedIndex = 1 Then
            ReportDesc.Text = "How much employees have sold per product"
        End If
        If ReportComboBox.SelectedIndex = 2 Then
            ReportDesc.Text = "Total Sales per product"
        End If
        If ReportComboBox.SelectedIndex = 3 Then
            ReportDesc.Text = "Total sales per item for a select month"
        End If
        If ReportComboBox.SelectedIndex = 4 Then
            ReportDesc.Text = "The total cost per supplier"
        End If
        If ReportComboBox.SelectedIndex = 5 Then
            ReportDesc.Text = "The total sales amount per Suburb "
        End If
        If ReportComboBox.SelectedIndex = 6 Then
            ReportDesc.Text = "Shows the products sold per employee for each month for the last year(12 months)"
        End If
        If ReportComboBox.SelectedIndex = 7 Then
            ReportDesc.Text = "Shows the products sold for each month for the last year(12 months)"
        End If

        If ReportComboBox.SelectedIndex = 8 Then
            ReportDesc.Text = "Shows the Quotations accepted for each month"
        End If

        If ReportComboBox.SelectedIndex = 9 Then
            ReportDesc.Text = "Show Value of accepted Customer quotes per customer"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        ManagerHomeMenu.Show()

    End Sub
End Class
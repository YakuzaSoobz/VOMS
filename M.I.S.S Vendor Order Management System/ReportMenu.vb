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
    End Sub

    Private Sub ReportComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ReportComboBox.SelectedIndexChanged
        If ReportComboBox.SelectedIndex = 0 Then
            ReportDesc.Text = "placeholder"
        End If
        If ReportComboBox.SelectedIndex = 1 Then
            ReportDesc.Text = "placeholder1"
        End If
        If ReportComboBox.SelectedIndex = 2 Then
            ReportDesc.Text = "placeholder2"
        End If
        If ReportComboBox.SelectedIndex = 3 Then
            ReportDesc.Text = "placeholder3"
        End If
        If ReportComboBox.SelectedIndex = 4 Then
            ReportDesc.Text = "placeholder4"
        End If
        If ReportComboBox.SelectedIndex = 5 Then
            ReportDesc.Text = "placeholder5"
        End If
    End Sub
End Class
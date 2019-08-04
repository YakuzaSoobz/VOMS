Public Class ManagerHomeMenuRevised
    Private Sub CustomerQuoteManagerButton_Click(sender As Object, e As EventArgs) Handles CustomerQuoteManagerButton.Click
        CustomerQuoteManager.Show()
        Me.Close()
    End Sub

    Private Sub SupplierQuoteManagerButton_Click(sender As Object, e As EventArgs) Handles SupplierQuoteManagerButton.Click
        SupplierQuoteManager.Show()
        Me.Close()
    End Sub

    Private Sub ProductManagerButton_Click(sender As Object, e As EventArgs) Handles ProductManagerButton.Click
        ProductManager.Show()
        Me.Close()
    End Sub

    Private Sub SupplierManagerButton_Click(sender As Object, e As EventArgs) Handles SupplierManagerButton.Click
        SupplierManager.Show()
        Me.Close()
    End Sub

    Private Sub CustomerManagerButton_Click(sender As Object, e As EventArgs) Handles CustomerManagerButton.Click
        CustomerManager.Show()
        Me.Close()
    End Sub

    Private Sub EmployeeManagerButton_Click(sender As Object, e As EventArgs) Handles EmployeeManagerButton.Click
        EmployeeManager.Show()
        Me.Close()
    End Sub

    Private Sub SignOutButton_Click(sender As Object, e As EventArgs) Handles SignOutButton.Click
        Dim ret As Integer = MsgBox("Are you sure you want to sign out?", vbYesNo, "Sign Out?")

        If ret = 6 Then 'if user clicks yes to update'
            SignIn.Show()
            SignIn.EmployeeIDTextbox.ResetText()
            SignIn.PasswordTextBox.ResetText()
            SignIn.AccessCombo.ResetText()
            Me.Close()
        End If
    End Sub
End Class
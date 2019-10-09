Imports System.Data.SqlClient

Public Class CustomerQuoteManager

    Public CustomerQuoteReferenceID As Integer
    Public NewCustomerQuoteReferenceID As Integer

    Public EditStatus As Boolean
    Public CreateStatus As Boolean
    Public SortStatus As Boolean
    Public ViewQuoteStatus As Boolean

    Private Sub CustomerQuoteManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group16DataSet.CustLineItemJoinProducts' table. You can move, or remove it, as needed.

        Try
            CustomerQuoteJoinCustomerTableAdapter.Fill(Me.Group16DataSet.CustomerQuoteJoinCustomer) 'refreshes records'
            CustomerQuoteJoinCustomerDataGridView.ClearSelection()

            ViewButton.Enabled = False
            EditButton.Enabled = False

            SortStatus = False
            CreateStatus = False
            EditStatus = False
            ViewQuoteStatus = False

        Catch exe As SqlException
            MsgBox("Reconnect to network!", vbExclamation, "Reconnect to Network!")
        Catch exe As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
        End Try
    End Sub

    Private Sub LogOutButton_Click(sender As Object, e As EventArgs) Handles LogOutButton.Click
        Dim ret As Integer = MsgBox("Are you sure you want to sign out?", vbYesNo, "Sign Out?")

        If ret = 6 Then 'if user clicks yes to update'
            SignIn.Show()
            SignIn.EmployeeIDTextbox.ResetText()
            SignIn.PasswordTextBox.ResetText()
            SignIn.AccessCombo.ResetText()
            Me.Close()
        End If
    End Sub

    Public Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        Try
            Call CustomerQuoteManager_Load(sender, e)

            Me.CustomerQuoteJoinCustomerBindingSource.Filter = "Cust_FName LIKE '%'"
            SearchTextBox.ResetText()
            Group16DataSet.CustLineItemJoinProducts.Rows.Clear()
            SortComboBox.ResetText()

        Catch exe As SqlException
            MsgBox("Reconnect to network!", vbExclamation, "Reconnect to Network!")
        Catch exe As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
        End Try
    End Sub

    Private Sub CustomerQuoteJoinCustomerDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CustomerQuoteJoinCustomerDataGridView.CellClick
        Try
            'if row is clicked then the corresponding quoteed items is shown in the items datagrid
            Me.CustLineItemJoinProductsTableAdapter.Fill(Me.Group16DataSet.CustLineItemJoinProducts)

            CustomerQuoteReferenceID = CustomerQuoteJoinCustomerDataGridView.CurrentRow.Cells(0).Value.ToString
            CustLineItemJoinProductsBindingSource.Filter = "Cust_Quote_Reference_ID = '" & CustomerQuoteReferenceID & "'"

            ViewButton.Enabled = True
            EditButton.Enabled = True
        Catch ex As SyntaxErrorException
            MsgBox("Cannot be found!", vbExclamation, "Incorrect Input!")
        Catch ex As EvaluateException
            MsgBox("Cannot be found", vbExclamation, "Incorrect Input!")
        Catch ex As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
        End Try
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Try

            If SearchComboBox.SelectedItem = "Quote Reference ID" Then
                CustomerQuoteJoinCustomerBindingSource.Filter = "Cust_Quote_Reference_ID = '" & SearchTextBox.Text & "'"
            ElseIf SearchComboBox.SelectedItem = "Employee ID" Then
                CustomerQuoteJoinCustomerBindingSource.Filter = "Employee_ID = '" & SearchTextBox.Text & "'"
            ElseIf SearchComboBox.SelectedItem = "Employee Name" Then
                CustomerQuoteJoinCustomerBindingSource.Filter = "Employee_FName LIKE'" & SearchTextBox.Text & "%' OR Employee_SName LIKE'" & SearchTextBox.Text & "%'"
            ElseIf SearchComboBox.SelectedItem = "Customer ID" Then
                CustomerQuoteJoinCustomerBindingSource.Filter = "Customer_ID = '" & SearchTextBox.Text & "'"
            ElseIf SearchComboBox.SelectedItem = "Customer Name" Then
                CustomerQuoteJoinCustomerBindingSource.Filter = "Cust_FName LIKE'" & SearchTextBox.Text & "%' OR Cust_SName LIKE'" & SearchTextBox.Text & "%'"
            End If

        Catch ex As SyntaxErrorException
            MsgBox("Cannot be found!", vbExclamation, "Incorrect Input!")
        Catch ex As EvaluateException
            MsgBox("Cannot be found", vbExclamation, "Incorrect Input!")
        Catch ex As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
        End Try
    End Sub

    Private Sub SortButton_Click(sender As Object, e As EventArgs) Handles SortButton.Click

        Try

            If SortComboBox.SelectedItem = "Show only Accepted Quotes" Then
                CustomerQuoteJoinCustomerBindingSource.Filter = "Cust_Quote_Acceptance_Status = 'Y' OR Cust_Quote_Acceptance_Status = 'y' "

            ElseIf SortComboBox.SelectedItem = "Show only Non-Accepted Quotes" Then
                CustomerQuoteJoinCustomerBindingSource.Filter = "Cust_Quote_Acceptance_Status = 'N' OR Cust_Quote_Acceptance_Status = 'n' "

            ElseIf SortComboBox.SelectedItem = "Date Quote was Issued" Then
                SortStatus = True
                SortManagerPopUp.Show()

            ElseIf SortComboBox.SelectedItem = "Customer Name (Alphabetical Order)" Then
                CustomerQuoteJoinCustomerBindingSource.Sort = "Cust_FName"

            ElseIf SortComboBox.SelectedItem = "Employee Name (Alphabetical Order)" Then
                CustomerQuoteJoinCustomerBindingSource.Sort = "Employee_FName"

            End If

        Catch ex As SyntaxErrorException
            MsgBox("Cannot be found!", vbExclamation, "Incorrect Input!")
        Catch ex As EvaluateException
            MsgBox("Cannot be found", vbExclamation, "Incorrect Input!")
        Catch ex As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
        End Try

    End Sub

    Private Sub HelpBtn_Click(sender As Object, e As EventArgs) Handles HelpBtn.Click
        Help.ShowHelp(Me, HelpProvider2.HelpNamespace)

    End Sub

    Private Sub CreateButton_Click(sender As Object, e As EventArgs) Handles CreateButton.Click
        Try
            EditStatus = False
            CreateStatus = True

            Me.CustomerQuoteJoinCustomerBindingSource.Filter = "Cust_FName LIKE '%'"
            CustomerQuoteJoinCustomerBindingSource.MoveLast()
            NewCustomerQuoteReferenceID = Integer.Parse(CustomerQuoteJoinCustomerDataGridView.CurrentRow.Cells(0).Value.ToString) + 1


            CreateOrEditCustomerQuote.Show()
            CreateOrEditCustomerQuote.Text = "Customer Quote ReferenceID : " & NewCustomerQuoteReferenceID
            CreateOrEditCustomerQuote.CustomerQuoteID = NewCustomerQuoteReferenceID

            Me.Hide()
        Catch exe As SqlException
            MsgBox("Reconnect to network!", vbExclamation, "Reconnect to Network!")
        Catch exe As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
        End Try
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        Try
            If (CustomerQuoteJoinCustomerDataGridView.SelectedRows.Count > 0) Then
                EditStatus = True
                CreateStatus = False

                CreateOrEditCustomerQuote.Show()

                CreateOrEditCustomerQuote.CustomerQuoteBindingSource.Filter = "Cust_Quote_Reference_ID = '" & CustomerQuoteReferenceID & "'"
                CreateOrEditCustomerQuote.CustLineItemJoinProductsBindingSource.Filter = "Cust_Quote_Reference_ID = '" & CustomerQuoteReferenceID & "'"


                CreateOrEditCustomerQuote.Text = "Customer Quote Editor: Reference ID = " & CustomerQuoteReferenceID
                CreateOrEditCustomerQuote.CustomerQuoteID = CustomerQuoteReferenceID

                Me.Hide()
            Else
                MsgBox("Please select a quote to edit from the Customer Quote table", vbExclamation)
            End If

        Catch exe As SqlException
            MsgBox("Reconnect to network!", vbExclamation, "Reconnect to Network!")
        Catch exe As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
        End Try
    End Sub

    Private Sub ViewButton_Click(sender As Object, e As EventArgs) Handles ViewButton.Click
        ViewCustomerQuotePopUp.Show()

        Try
            Dim acceptanceStatus As String = CustomerQuoteJoinCustomerDataGridView.CurrentRow.Cells(3).Value.ToString

            If (acceptanceStatus = "N") Or (acceptanceStatus = "n") Then
                ViewCustomerQuotePopUp.QuoteStatus = True
            ElseIf (acceptanceStatus = "Y") Or (acceptanceStatus = "y") Then
                ViewCustomerQuotePopUp.InvoiceStatus = True
            End If

            ViewCustomerQuotePopUp.CustomerQuoteJoinCustomerBindingSource.Filter = "Cust_Quote_Reference_ID = '" & CustomerQuoteReferenceID & "'"
            ViewCustomerQuotePopUp.CustLineItemJoinProductsBindingSource.Filter = "Cust_Quote_Reference_ID = '" & CustomerQuoteReferenceID & "'"

        Catch exe As SqlException
            MsgBox("Reconnect to network!", vbExclamation, "Reconnect to Network!")
        Catch exe As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
        End Try
    End Sub

    Private Sub SearchButton_MouseHover(sender As Object, e As EventArgs) Handles SearchButton.MouseHover
        CustomerQuoteManagerTip.SetToolTip(SearchButton, "Click to search entry")

    End Sub

    Private Sub SortButton_MouseHover(sender As Object, e As EventArgs) Handles SortButton.MouseHover
        CustomerQuoteManagerTip.SetToolTip(SortButton, "Click to sort according to criteria")
    End Sub

    Private Sub ViewButton_MouseHover(sender As Object, e As EventArgs) Handles ViewButton.MouseHover
        CustomerQuoteManagerTip.SetToolTip(ViewButton, "Click to view quote")
    End Sub

    Private Sub CreateButton_MouseHover(sender As Object, e As EventArgs) Handles CreateButton.MouseHover
        CustomerQuoteManagerTip.SetToolTip(CreateButton, "Click to create quote")
    End Sub

    Private Sub EditButton_MouseHover(sender As Object, e As EventArgs) Handles EditButton.MouseHover
        CustomerQuoteManagerTip.SetToolTip(EditButton, "Click to edit quote")
    End Sub

    Private Sub RefreshButton_MouseHover(sender As Object, e As EventArgs) Handles RefreshButton.MouseHover
        CustomerQuoteManagerTip.SetToolTip(RefreshButton, "Click to refresh quotes")
    End Sub

    Private Sub LogOutButton_MouseHover(sender As Object, e As EventArgs) Handles LogOutButton.MouseHover
        CustomerQuoteManagerTip.SetToolTip(LogOutButton, "Click to logout")
    End Sub

    Private Sub HelpBtn_MouseHover(sender As Object, e As EventArgs) Handles HelpBtn.MouseHover
        CustomerQuoteManagerTip.SetToolTip(HelpBtn, "Click to get help")
    End Sub

    Private Sub BackButton_MouseHover(sender As Object, e As EventArgs) Handles BackButton.MouseHover
        CustomerQuoteManagerTip.SetToolTip(BackButton, "Click to leave form")
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click

        If (SignIn.ManagerStatus = True) And (SignIn.EmployeeStatus = False) And (CreateOrEditCustomerQuote.CreateCustomerStatus = False) Then
            ManagerHomeMenu.Show()
            Me.Close()
        ElseIf (SignIn.ManagerStatus = False) And (SignIn.EmployeeStatus = True) And (CreateOrEditCustomerQuote.CreateCustomerStatus = False) Then
            EmployeeHomeMenu.Show()
            Me.Close()
        End If

    End Sub
End Class
Imports System.Data.SqlClient


Public Class SupplierQuoteManager

    Public SupplierQuoteReferenceID As Integer
    Public NewSupplierQuoteReferenceID As Integer
    Public EditStatus As Boolean
    Public CreateStatus As Boolean
    Public SortStatus As Boolean
    Public ViewQuoteStatus As Boolean

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

    Private Sub SupplierQuoteManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group16DataSet.SuppLineItemJoinProduct' table. You can move, or remove it, as needed.

        Try
            Me.SupplierQuoteJoinSupplierTableAdapter.Fill(Me.Group16DataSet.SupplierQuoteJoinSupplier) 'refreshes records'
            SupplierQuoteJoinSupplierDataGridView.ClearSelection()

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

    Public Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        Try
            Call SupplierQuoteManager_Load(sender, e)

            Me.SupplierQuoteJoinSupplierBindingSource.Filter = "Supplier_Name LIKE '%'"
            SearchTextBox.ResetText()
            Group16DataSet.SuppLineItemJoinProduct.Rows.Clear()
            SortComboBox.ResetText()

        Catch exe As SqlException
            MsgBox("Reconnect to network!", vbExclamation, "Reconnect to Network!")
        Catch exe As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
        End Try
    End Sub

    Private Sub CreateButton_Click(sender As Object, e As EventArgs) Handles CreateButton.Click
        Try
            EditStatus = False
            CreateStatus = True
            CreateOrEditSupplierQuote.Show()

            SupplierQuoteJoinSupplierBindingSource.MoveLast()
            NewSupplierQuoteReferenceID = Integer.Parse(SupplierQuoteJoinSupplierDataGridView.CurrentRow.Cells(0).Value.ToString) + 1

            CreateOrEditSupplierQuote.Text = "Supplier Quote ReferenceID : " & NewSupplierQuoteReferenceID
            CreateOrEditSupplierQuote.SupplierQuoteID = NewSupplierQuoteReferenceID
            Me.Hide()
        Catch exe As SqlException
            MsgBox("Reconnect to network!", vbExclamation, "Reconnect to Network!")
        Catch exe As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
        End Try
    End Sub

    Private Sub ViewButton_Click(sender As Object, e As EventArgs) Handles ViewButton.Click
        Try
            ViewQuoteStatus = True
            ViewSupplierQuotePopUp.Show()

            Dim acceptanceStatus As String = SupplierQuoteJoinSupplierDataGridView.CurrentRow.Cells(3).Value.ToString

            If (acceptanceStatus = "N") Or (acceptanceStatus = "n") Then
                ViewSupplierQuotePopUp.QuoteStatus = True
            ElseIf (acceptanceStatus = "Y") Or (acceptanceStatus = "y") Then
                ViewSupplierQuotePopUp.InvoiceStatus = True
            End If

            ViewSupplierQuotePopUp.SupplierQuoteJoinSupplierBindingSource.Filter = "Supp_Quote_Reference_ID = '" & SupplierQuoteReferenceID & "'"
            ViewSupplierQuotePopUp.SuppLineItemJoinProductBindingSource.Filter = "Supp_Quote_Reference_ID = '" & SupplierQuoteReferenceID & "'"

        Catch exe As SqlException
            MsgBox("Reconnect to network!", vbExclamation, "Reconnect to Network!")
        Catch exe As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
        End Try
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click

        Try
            If (SupplierQuoteJoinSupplierDataGridView.SelectedRows.Count > 0) Then
                EditStatus = True
                CreateStatus = False

                CreateOrEditSupplierQuote.Show()

                CreateOrEditSupplierQuote.SupplierQuoteBindingSource.Filter = "Supp_Quote_Reference_ID = '" & SupplierQuoteReferenceID & "'"
                CreateOrEditSupplierQuote.SuppLineItemJoinProductBindingSource.Filter = "Supp_Quote_Reference_ID = '" & SupplierQuoteReferenceID & "'"

                CreateOrEditSupplierQuote.Text = "Supplier Quote Editor: Reference ID = " & SupplierQuoteReferenceID
                CreateOrEditSupplierQuote.SupplierQuoteID = SupplierQuoteReferenceID

                Me.Hide()
            Else
                MsgBox("Please select a quote to edit from the Supplier Quote table", vbExclamation)
            End If

        Catch exe As SqlException
            MsgBox("Reconnect to network!", vbExclamation, "Reconnect to Network!")
        Catch exe As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
        End Try
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Try
            If SearchComboBox.SelectedItem = "Quote Reference ID" Then
                SupplierQuoteJoinSupplierBindingSource.Filter = "Supp_Quote_Reference_ID = '" & SearchTextBox.Text & "'"
            ElseIf SearchComboBox.SelectedItem = "Supplier ID" Then
                SupplierQuoteJoinSupplierBindingSource.Filter = "Supplier_ID = '" & SearchTextBox.Text & "'"
            ElseIf SearchComboBox.SelectedItem = "Rep Name" Then
                SupplierQuoteJoinSupplierBindingSource.Filter = "Supplier_Rep_FName LIKE'" & SearchTextBox.Text & "%' OR Supplier_Rep_SName LIKE'" & SearchTextBox.Text & "%'"
            ElseIf SearchComboBox.SelectedItem = "Supplier Name" Then
                SupplierQuoteJoinSupplierBindingSource.Filter = "Supplier_Name LIKE'" & SearchTextBox.Text & "%'"
            End If

        Catch ex As SyntaxErrorException
            MsgBox("Cannot be found!", vbExclamation, "Incorrect Input!")
        Catch ex As EvaluateException
            MsgBox("Cannot be found", vbExclamation, "Incorrect Input!")
        Catch ex As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
        End Try
    End Sub

    Private Sub SupplierQuoteDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles SupplierQuoteJoinSupplierDataGridView.CellClick

        Try
            'if row is clicked then the corresponding quoteed items is shown in the items datagrid
            Me.SuppLineItemJoinProductTableAdapter.Fill(Me.Group16DataSet.SuppLineItemJoinProduct)

            SupplierQuoteReferenceID = SupplierQuoteJoinSupplierDataGridView.CurrentRow.Cells(0).Value.ToString
            SuppLineItemJoinProductBindingSource.Filter = "Supp_Quote_Reference_ID = '" & SupplierQuoteReferenceID & "'"

            'retreive supplier id from supplier id info button, display supplier details in supplier info form
            If (e.ColumnIndex = 5) Then
                Dim SupplierID As String = SupplierQuoteJoinSupplierDataGridView.CurrentRow.Cells(5).Value.ToString
                Dim SupplierName As String = SupplierQuoteJoinSupplierDataGridView.CurrentRow.Cells(6).Value.ToString

                SupplierInfoPopUp.Show()
                SupplierInfoPopUp.SupplierBindingSource.Filter = "Supplier_ID = '" & SupplierID & "'"
                SupplierInfoPopUp.Text = "Supplier Information: " & SupplierName

            End If
        Catch ex As SyntaxErrorException
            MsgBox("Cannot be found!", vbExclamation, "Incorrect Input!")
        Catch ex As EvaluateException
            MsgBox("Cannot be found", vbExclamation, "Incorrect Input!")
        Catch ex As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
        End Try
    End Sub

    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged

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

    Private Sub SortButton_Click(sender As Object, e As EventArgs) Handles SortButton.Click
        Try

            If SortComboBox.SelectedItem = "Show only Accepted Orders" Then
                SupplierQuoteJoinSupplierBindingSource.Filter = "Supp_Quote_Acceptance_Status = 'Y' OR Supp_Quote_Acceptance_Status = 'y' "

            ElseIf SortComboBox.SelectedItem = "Show only Non-Accepted Orders" Then
                SupplierQuoteJoinSupplierBindingSource.Filter = "Supp_Quote_Acceptance_Status = 'N' OR Supp_Quote_Acceptance_Status = 'n' "

            ElseIf SortComboBox.SelectedItem = "Date Quote was Recieved" Then
                SortStatus = True
                SortManagerPopUp.Show()

            ElseIf SortComboBox.SelectedItem = "Supplier Name (Alphabetical Order)" Then
                SupplierQuoteJoinSupplierBindingSource.Sort = "Supplier_Name"

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
        Dim helpFilePath = IO.Path.Combine(My.Application.Info.DirectoryPath, "M.I.S.chm")
        Help.ShowHelp(Me, helpFilePath)
    End Sub

    Private Sub SearchButton_MouseHover(sender As Object, e As EventArgs) Handles SearchButton.MouseHover
        ToolTip1.SetToolTip(SearchButton, "Click to search entry")

    End Sub

    Private Sub SortButton_MouseHover(sender As Object, e As EventArgs) Handles SortButton.MouseHover
        ToolTip1.SetToolTip(SortButton, "Click to sort according to criteria")
    End Sub

    Private Sub ViewButton_MouseHover(sender As Object, e As EventArgs) Handles ViewButton.MouseHover
        ToolTip1.SetToolTip(ViewButton, "Click to view supplier quote")
    End Sub

    Private Sub CreateButton_MouseHover(sender As Object, e As EventArgs) Handles CreateButton.MouseHover
        ToolTip1.SetToolTip(CreateButton, "Click to create supplier quote")
    End Sub

    Private Sub EditButton_MouseHover(sender As Object, e As EventArgs) Handles EditButton.MouseHover
        ToolTip1.SetToolTip(EditButton, "Click to edit supplier quote")
    End Sub

    Private Sub RefreshButton_MouseHover(sender As Object, e As EventArgs) Handles RefreshButton.MouseHover
        ToolTip1.SetToolTip(RefreshButton, "Click to refresh supplier quote")
    End Sub

    Private Sub LogOutButton_MouseHover(sender As Object, e As EventArgs) Handles LogOutButton.MouseHover
        ToolTip1.SetToolTip(LogOutButton, "Click to logout")
    End Sub

    Private Sub HelpBtn_MouseHover(sender As Object, e As EventArgs) Handles HelpBtn.MouseHover
        ToolTip1.SetToolTip(HelpBtn, "Click to get help")
    End Sub

    Private Sub BackButton_MouseHover(sender As Object, e As EventArgs) Handles BackButton.MouseHover
        ToolTip1.SetToolTip(BackButton, "Click to leave form")
    End Sub
End Class
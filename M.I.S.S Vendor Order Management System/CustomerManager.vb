Imports System.Data.SqlClient

Public Class CustomerManager
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

    Private Sub CustomerManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        NextButton.Enabled = False
        PreviousButton.Enabled = False

        DetailsGroupBox.Enabled = False
        UpdateButton.Enabled = False
        ButtonRefresh.Enabled = False
        ArchiveButton.Enabled = False
    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        Try
            'clears all controls'
            Dim a As Control
            For Each a In DetailsGroupBox.Controls
                If TypeOf a Is TextBox Or TypeOf a Is MaskedTextBox Or TypeOf a Is ComboBox Or TypeOf a Is DateTimePicker Then
                    a.ResetText()
                End If
            Next

            Dim b As Control
            For Each b In NavigationGroupBox.Controls
                If TypeOf b Is TextBox Or TypeOf b Is MaskedTextBox Or TypeOf b Is ComboBox Or TypeOf b Is DateTimePicker Then
                    b.ResetText()
                End If
            Next

            DetailsGroupBox.Enabled = False
            NavigationGroupBox.Enabled = True
            UpdateButton.Enabled = False
            ButtonRefresh.Enabled = False
            CreateButton.Enabled = True
            ArchiveButton.Enabled = False
        Catch ex As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
        End Try
    End Sub

    Private Sub CreateButton_Click(sender As Object, e As EventArgs) Handles CreateButton.Click
        Try
            Dim ret As Integer = MsgBox("Enter new values , then click the SAVE button!", vbYesNo, "Create new customer?")

            If ret = 6 Then 'if user clicks yes to update'

                NavigationGroupBox.Enabled = False
                DetailsGroupBox.Enabled = True
                UpdateButton.Enabled = True
                ButtonRefresh.Enabled = True
                ArchiveButton.Enabled = False
                CreateButton.Enabled = False

                Me.CustomerTableAdapter.Fill(Me.Group16DataSet.Customer)
                CustomerBindingSource.MoveLast()
                Dim currentID As Integer = Integer.Parse(CustomerIDTextBox.Text)
                CustomerBindingSource.AddNew()
                CustomerIDTextBox.Text = currentID + 1
            End If
        Catch ex As SqlException
            MsgBox("Cannot Add!", vbExclamation, "Cannot Add!")
        Catch ex As NoNullAllowedException
            MsgBox("Incorrect input!Follow correct format!", vbExclamation, "Incorrect Input!")
            Me.CustomerTableAdapter.Fill(Me.Group16DataSet.Customer) 'refreshes records'
        Catch ex As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
        End Try
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Try
            Dim ret As Integer = MsgBox("Confirm changes?", vbYesNo)

            If ret = 6 Then 'if user clicks yes to update'
                CustomerBindingSource.EndEdit()
                CustomerTableAdapter.Update(Group16DataSet)
                MsgBox("Update successful!")
                Call ButtonRefresh_Click(sender, e)
            End If
        Catch ex As SqlException
            MsgBox("Cannot Update!", vbExclamation, "Cannot Update!")
        Catch ex As NoNullAllowedException
            MsgBox("Incorrect input!Follow correct format!", vbExclamation, "Incorrect Input")
        Catch ex As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
        End Try
    End Sub

    Private Sub ArchiveButton_Click(sender As Object, e As EventArgs) Handles ArchiveButton.Click
        ActiveStatusComboBox.SelectedItem = "F"
        Call UpdateButton_Click(sender, e)
    End Sub

    Private Sub FirstButton_Click(sender As Object, e As EventArgs) Handles FirstButton.Click
        DetailsGroupBox.Enabled = True
        UpdateButton.Enabled = True
        ButtonRefresh.Enabled = True
        ArchiveButton.Enabled = True

        NextButton.Enabled = True
        PreviousButton.Enabled = True
        Try
            CustomerBindingSource.MoveFirst()
        Catch ex As NoNullAllowedException
            MsgBox("Incorrect input!Follow correct format!", vbExclamation, "Incorrect Input!")
        Catch ex As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
        Finally
            Try
                Me.CustomerTableAdapter.Fill(Me.Group16DataSet.Customer) 'refreshes records'
            Catch exe As SqlException
                MsgBox("Reconnect to network!", vbExclamation, "Reconnect to Network!")
            Catch exe As Exception
                MsgBox("Oops something went wrong!", vbExclamation, "Error!")
            End Try
        End Try
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click

        DetailsGroupBox.Enabled = True
        UpdateButton.Enabled = True
        ButtonRefresh.Enabled = True
        ArchiveButton.Enabled = True

        Try
            CustomerBindingSource.MoveNext()
        Catch ex As NoNullAllowedException
            MsgBox("Incorrect input!Follow correct format!", vbExclamation, "Incorrect Input!")

            Try
                Me.CustomerTableAdapter.Fill(Me.Group16DataSet.Customer) 'refreshes records'
            Catch exe As SqlException
                MsgBox("Reconnect to network!", vbExclamation, "Reconnect to Network!")
            Catch exe As Exception
                MsgBox("Oops something went wrong!", vbExclamation, "Error!")
            End Try
        Catch ex As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
        End Try
    End Sub

    Private Sub PreviousButton_Click(sender As Object, e As EventArgs) Handles PreviousButton.Click
        DetailsGroupBox.Enabled = True
        UpdateButton.Enabled = True
        ButtonRefresh.Enabled = True
        ArchiveButton.Enabled = True

        Try
            CustomerBindingSource.MovePrevious()
        Catch ex As NoNullAllowedException
            MsgBox("Incorrect input!Follow correct format!", vbExclamation, "Incorrect Input!")

            Try
                Me.CustomerTableAdapter.Fill(Me.Group16DataSet.Customer) 'refreshes records'
            Catch exe As SqlException
                MsgBox("Reconnect to network!", vbExclamation, "Reconnect to Network!")
            Catch exe As Exception
                MsgBox("Oops something went wrong!", vbExclamation, "Error!")
            End Try
        Catch ex As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
        End Try
    End Sub

    Private Sub LastButton_Click(sender As Object, e As EventArgs) Handles LastButton.Click
        DetailsGroupBox.Enabled = True
        UpdateButton.Enabled = True
        ButtonRefresh.Enabled = True
        ArchiveButton.Enabled = True

        NextButton.Enabled = True
        PreviousButton.Enabled = True
        Try
            CustomerBindingSource.MoveLast()

        Catch ex As NoNullAllowedException
            MsgBox("Incorrect input!Follow correct format!", vbExclamation, "Incorrect Input!")

            Try
                Me.CustomerTableAdapter.Fill(Me.Group16DataSet.Customer) 'refreshes records'
            Catch exe As SqlException
                MsgBox("Reconnect to network!", vbExclamation, "Reconnect to Network!")
            Catch exe As Exception
                MsgBox("Oops something went wrong!", vbExclamation, "Error!")
            End Try
        Catch ex As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
        End Try
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Try
            If SearchComboBox.SelectedItem = "Customer ID" Then
                CustomerBindingSource.Filter = "Customer_ID = '" & SearchTextBox.Text & "'"
            ElseIf SearchComboBox.SelectedItem = "Customer Name" Then
                CustomerBindingSource.Filter = "Cust_FName LIKE '" & SearchTextBox.Text & "%' OR Cust_SName LIKE '" & SearchTextBox.Text & "%'"
            ElseIf SearchComboBox.SelectedItem = "Customer City" Then
                CustomerBindingSource.Filter = "Cust_City LIKE '" & SearchTextBox.Text & "%'"
            End If

            DetailsGroupBox.Enabled = True
            UpdateButton.Enabled = True
            ButtonRefresh.Enabled = True
            ArchiveButton.Enabled = True
        Catch ex As SqlException
            MsgBox("Cannot be found!", vbExclamation, "Incorrect Input!")
        Catch ex As EvaluateException
            MsgBox("Cannot be found", vbExclamation, "Incorrect Input!")
        Catch ex As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
        End Try
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click

        Try
            If (SignIn.ManagerStatus = True) And (SignIn.EmployeeStatus = False) And (CreateOrEditCustomerQuote.CreateCustomerStatus = False) Then
                ManagerHomeMenu.Show()
                Me.Close()
            ElseIf (SignIn.ManagerStatus = False) And (SignIn.EmployeeStatus = True) And (CreateOrEditCustomerQuote.CreateCustomerStatus = False) Then
                EmployeeHomeMenu.Show()
                Me.Close()
            ElseIf (SignIn.ManagerStatus = False) And (SignIn.EmployeeStatus = False) And (CreateOrEditCustomerQuote.CreateCustomerStatus = True) Then
                CreateOrEditCustomerQuote.CreateCustomerStatus = False
                CreateOrEditCustomerQuote.CustomerTableAdapter.Fill(CreateOrEditCustomerQuote.Group16DataSet.Customer)
                Me.Close()
            End If
        Catch ex As SqlException
            MsgBox("Page did not load properly!", vbExclamation, "Network Error!")
        Catch ex As EvaluateException
            MsgBox("Cannot be found", vbExclamation, "Incorrect Input!")
        Catch ex As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
        End Try
    End Sub

    Private Sub HelpBtn_Click(sender As Object, e As EventArgs) Handles HelpBtn.Click
        HelpView.Show()
    End Sub


    Private Sub SearchButton_MouseHover(sender As Object, e As EventArgs) Handles SearchButton.MouseHover
        CustomerManagerTip.SetToolTip(SearchButton, "Click to search entry")
    End Sub

    Private Sub FirstButton_MouseHover(sender As Object, e As EventArgs) Handles FirstButton.MouseHover
        CustomerManagerTip.SetToolTip(FirstButton, "Click to go to first customer")
    End Sub

    Private Sub NextButton_MouseHover(sender As Object, e As EventArgs) Handles NextButton.MouseHover
        CustomerManagerTip.SetToolTip(NextButton, "Click to go to next customer")
    End Sub

    Private Sub PreviousButton_MouseHover(sender As Object, e As EventArgs) Handles PreviousButton.MouseHover
        CustomerManagerTip.SetToolTip(PreviousButton, "Click to go to previous customer")
    End Sub

    Private Sub LastButton_MouseHover(sender As Object, e As EventArgs) Handles LastButton.MouseHover
        CustomerManagerTip.SetToolTip(LastButton, "Click to go to last customer")
    End Sub

    Private Sub ArchiveButton_MouseHover(sender As Object, e As EventArgs) Handles ArchiveButton.MouseHover
        CustomerManagerTip.SetToolTip(ArchiveButton, "Click to archive customer")
    End Sub

    Private Sub UpdateButton_MouseHover(sender As Object, e As EventArgs) Handles UpdateButton.MouseHover
        CustomerManagerTip.SetToolTip(UpdateButton, "Click to update customer")
    End Sub

    Private Sub CreateButton_MouseHover(sender As Object, e As EventArgs) Handles CreateButton.MouseHover
        CustomerManagerTip.SetToolTip(CreateButton, "Click to create customer")
    End Sub

    Private Sub ButtonRefresh_MouseHover(sender As Object, e As EventArgs) Handles ButtonRefresh.MouseHover
        CustomerManagerTip.SetToolTip(ButtonRefresh, "Click to refresh customers")
    End Sub

    Private Sub LogOutButton_MouseHover(sender As Object, e As EventArgs) Handles LogOutButton.MouseHover
        CustomerManagerTip.SetToolTip(LogOutButton, "Click to logout")
    End Sub

    Private Sub HelpBtn_MouseHover(sender As Object, e As EventArgs) Handles HelpBtn.MouseHover
        CustomerManagerTip.SetToolTip(HelpBtn, "Click to get help")
    End Sub

    Private Sub BackButton_MouseHover(sender As Object, e As EventArgs) Handles BackButton.MouseHover
        CustomerManagerTip.SetToolTip(BackButton, "Click to go back")
    End Sub
End Class
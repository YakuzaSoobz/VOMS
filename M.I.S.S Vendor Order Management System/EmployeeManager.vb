Imports System.Data.SqlClient

Public Class EmployeeManager

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

    Private Sub EmployeeManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NextButton.Enabled = False
        PreviousButton.Enabled = False
        DetailsGroupBox.Enabled = False
        UpdateButton.Enabled = False
        ButtonRefresh.Enabled = False
        ArchiveButton.Enabled = False
    End Sub

    Private Sub FirstButton_Click(sender As Object, e As EventArgs) Handles FirstButton.Click
        NextButton.Enabled = True
        PreviousButton.Enabled = True
        DetailsGroupBox.Enabled = True
        UpdateButton.Enabled = True
        ButtonRefresh.Enabled = True
        ArchiveButton.Enabled = True

        Try
            EmployeeBindingSource.MoveFirst()
        Catch ex As NoNullAllowedException
            MsgBox("Incorrect input!Follow correct format!", vbExclamation, "Incorrect Input!")
        Catch ex As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
        Finally

            Try
                Me.EmployeeTableAdapter.Fill(Me.Group16DataSet.Employee) 'refreshes records'
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
            EmployeeBindingSource.MoveNext()
        Catch ex As NoNullAllowedException
            MsgBox("Incorrect input!Follow correct format!", vbExclamation, "Incorrect Input!")

            Try
                Me.EmployeeTableAdapter.Fill(Me.Group16DataSet.Employee) 'refreshes records'
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
            EmployeeBindingSource.MovePrevious()
        Catch ex As NoNullAllowedException
            MsgBox("Incorrect input!Follow correct format!", vbExclamation, "Incorrect Input!")

            Try
                Me.EmployeeTableAdapter.Fill(Me.Group16DataSet.Employee) 'refreshes records'
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
            EmployeeBindingSource.MoveLast()

        Catch ex As NoNullAllowedException
            MsgBox("Incorrect input!Follow correct format!", vbExclamation, "Incorrect Input!")

            Try
                Me.EmployeeTableAdapter.Fill(Me.Group16DataSet.Employee) 'refreshes records'
            Catch exe As SqlException
                MsgBox("Reconnect to network!", vbExclamation, "Reconnect to Network!")
            Catch exe As Exception
                MsgBox("Oops something went wrong!", vbExclamation, "Error!")
            End Try
        Catch ex As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
        End Try
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

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Try
            Dim ret As Integer = MsgBox("Confirm changes?", vbYesNo)

            If ret = 6 Then 'if user clicks yes to update'
                EmployeeBindingSource.EndEdit()
                EmployeeTableAdapter.Update(Group16DataSet)
                MsgBox("Update successful!")
                Call ButtonRefresh_Click(sender, e)
            End If
        Catch ex As SqlException
            MsgBox("Cannot Update!", vbExclamation, "Network Error!")
        Catch ex As NoNullAllowedException
            MsgBox("Incorrect input!Follow correct format!", vbExclamation, "Incorrect Input")
        Catch ex As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")

        End Try
    End Sub

    Private Sub CreateButton_Click(sender As Object, e As EventArgs) Handles CreateButton.Click
        Try
            Dim ret As Integer = MsgBox("Enter new values , then click the SAVE button!", vbYesNo, "Create new employee?")

            If ret = 6 Then 'if user clicks yes to update'

                NavigationGroupBox.Enabled = False
                DetailsGroupBox.Enabled = True
                UpdateButton.Enabled = True
                ButtonRefresh.Enabled = True
                ArchiveButton.Enabled = False
                CreateButton.Enabled = False

                Me.EmployeeTableAdapter.Fill(Me.Group16DataSet.Employee)
                EmployeeBindingSource.MoveLast()
                Dim currentID As Integer = Integer.Parse(EmployeeIDTextBox.Text)
                EmployeeBindingSource.AddNew()
                EmployeeIDTextBox.Text = currentID + 1
            End If
        Catch ex As SqlException
            MsgBox("Cannot Add!", vbExclamation, "Cannot Add!")
        Catch ex As NoNullAllowedException
            MsgBox("Incorrect input!Follow correct format!", vbExclamation, "Incorrect Input!")
            Me.EmployeeTableAdapter.Fill(Me.Group16DataSet.Employee) 'refreshes records'
        Catch ex As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
        End Try
    End Sub

    Private Sub ArchiveButton_Click(sender As Object, e As EventArgs) Handles ArchiveButton.Click
        ActiveStatusComboBox.SelectedItem = "F"
        Call UpdateButton_Click(sender, e)
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Try
            Call FirstButton_Click(sender, e)
            If SearchComboBox.SelectedItem = "Employee ID" Then
                EmployeeBindingSource.Filter = "Employee_ID = '" & SearchTextBox.Text & "'"
            ElseIf SearchComboBox.SelectedItem = "Employee Name" Then
                EmployeeBindingSource.Filter = "Employee_FName LIKE'" & SearchTextBox.Text & "%' OR Employee_SName LIKE'" & SearchTextBox.Text & "%'"
            ElseIf SearchComboBox.SelectedItem = "Employee City" Then
                EmployeeBindingSource.Filter = "Employee_City LIKE'" & SearchTextBox.Text & "%'"
            End If

            DetailsGroupBox.Enabled = True
            UpdateButton.Enabled = True
            ButtonRefresh.Enabled = True
            ArchiveButton.Enabled = True
        Catch ex As SyntaxErrorException
            MsgBox("Cannot be found!", vbExclamation, "Incorrect Input!")
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
        EmployeeManagerTip.SetToolTip(SearchButton, "Click to search entry")
    End Sub

    Private Sub FirstButton_MouseHover(sender As Object, e As EventArgs) Handles FirstButton.MouseHover
        EmployeeManagerTip.SetToolTip(FirstButton, "Click to go to first employee")
    End Sub

    Private Sub NextButton_MouseHover(sender As Object, e As EventArgs) Handles NextButton.MouseHover
        EmployeeManagerTip.SetToolTip(NextButton, "Click to go to next employee")
    End Sub

    Private Sub PreviousButton_MouseHover(sender As Object, e As EventArgs) Handles PreviousButton.MouseHover
        EmployeeManagerTip.SetToolTip(PreviousButton, "Click to go to previous employee")
    End Sub

    Private Sub LastButton_MouseHover(sender As Object, e As EventArgs) Handles LastButton.MouseHover
        EmployeeManagerTip.SetToolTip(LastButton, "Click to go to last employee")
    End Sub

    Private Sub ArchiveButton_MouseHover(sender As Object, e As EventArgs) Handles ArchiveButton.MouseHover
        EmployeeManagerTip.SetToolTip(ArchiveButton, "Click to archive employee")
    End Sub

    Private Sub UpdateButton_MouseHover(sender As Object, e As EventArgs) Handles UpdateButton.MouseHover
        EmployeeManagerTip.SetToolTip(UpdateButton, "Click to update employee")
    End Sub

    Private Sub CreateButton_MouseHover(sender As Object, e As EventArgs) Handles CreateButton.MouseHover
        EmployeeManagerTip.SetToolTip(CreateButton, "Click to create employee")
    End Sub

    Private Sub ButtonRefresh_MouseHover(sender As Object, e As EventArgs) Handles ButtonRefresh.MouseHover
        EmployeeManagerTip.SetToolTip(ButtonRefresh, "Click to refresh employees")
    End Sub

    Private Sub LogOutButton_MouseHover(sender As Object, e As EventArgs) Handles LogOutButton.MouseHover
        EmployeeManagerTip.SetToolTip(LogOutButton, "Click to logout")
    End Sub

    Private Sub HelpBtn_MouseHover(sender As Object, e As EventArgs) Handles HelpBtn.MouseHover
        EmployeeManagerTip.SetToolTip(HelpBtn, "Click to get help")
    End Sub

    Private Sub BackButton_MouseHover(sender As Object, e As EventArgs) Handles BackButton.MouseHover
        EmployeeManagerTip.SetToolTip(BackButton, "Click to go back")
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
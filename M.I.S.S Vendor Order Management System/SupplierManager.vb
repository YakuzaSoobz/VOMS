Imports System.Data.SqlClient

Public Class SupplierManager
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

    Private Sub FirstButton_Click(sender As Object, e As EventArgs) Handles FirstButton.Click
        DetailsGroupBox.Enabled = True
        RepDetailsGroupBox.Enabled = True
        UpdateButton.Enabled = True
        ButtonRefresh.Enabled = True
        ArchiveButton.Enabled = True
        NextButton.Enabled = True
        PreviousButton.Enabled = True
        Try
            SupplierBindingSource.MoveFirst()
        Catch ex As NoNullAllowedException
            MsgBox("Incorrect input! Follow correct format!", vbExclamation, "Incorrect Input!")
        Catch ex As Exception
            MsgBox("Oops, something went wrong!", vbExclamation, "Error!")
        Finally
            Try
                Me.SupplierTableAdapter.Fill(Me.Group16DataSet.Supplier) 'refreshes records'
            Catch ex As SqlException
                MsgBox("Reconnect to network!", vbExclamation, "Reconnect to Network!")
            Catch ex As Exception
                MsgBox("Oops, something went wrong!", vbExclamation, "Error!")
            End Try
        End Try
    End Sub

    Private Sub SupplierManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NextButton.Enabled = False
        PreviousButton.Enabled = False
        DetailsGroupBox.Enabled = False
        RepDetailsGroupBox.Enabled = False
        UpdateButton.Enabled = False
        ButtonRefresh.Enabled = False
        ArchiveButton.Enabled = False
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        DetailsGroupBox.Enabled = True
        RepDetailsGroupBox.Enabled = True
        UpdateButton.Enabled = True
        ButtonRefresh.Enabled = True
        ArchiveButton.Enabled = True

        Try
            SupplierBindingSource.MoveNext()
        Catch ex As NoNullAllowedException
            MsgBox("Incorrect input! Follow correct format!", vbExclamation, "Incorrect Input!")
            Try
                Me.SupplierTableAdapter.Fill(Me.Group16DataSet.Supplier) 'refreshes records'
            Catch exe As SqlException
                MsgBox("Reconnect to network!", vbExclamation, "Reconnect to Network!")
            Catch exe As Exception
                MsgBox("Oops, something went wrong!", vbExclamation, "Error!")
            End Try
        Catch ex As Exception
            MsgBox("Oops, something went wrong!", vbExclamation, "Error!")
        End Try
    End Sub

    Private Sub PreviousButton_Click(sender As Object, e As EventArgs) Handles PreviousButton.Click
        DetailsGroupBox.Enabled = True
        RepDetailsGroupBox.Enabled = True
        UpdateButton.Enabled = True
        ButtonRefresh.Enabled = True
        ArchiveButton.Enabled = True

        Try
            SupplierBindingSource.MovePrevious()
        Catch ex As NoNullAllowedException
            MsgBox("Incorrect input! Follow correct format!", vbExclamation, "Incorrect Input!")
            Try
                Me.SupplierTableAdapter.Fill(Me.Group16DataSet.Supplier) 'refreshes records'
            Catch exe As SqlException
                MsgBox("Reconnect to network!", vbExclamation, "Reconnect to Network!")
            Catch exe As Exception
                MsgBox("Oops, something went wrong!", vbExclamation, "Error!")
            End Try
        Catch ex As Exception
            MsgBox("Oops, something went wrong!", vbExclamation, "Error!")
        End Try
    End Sub

    Private Sub LastButton_Click(sender As Object, e As EventArgs) Handles LastButton.Click
        DetailsGroupBox.Enabled = True
        RepDetailsGroupBox.Enabled = True
        UpdateButton.Enabled = True
        ButtonRefresh.Enabled = True
        ArchiveButton.Enabled = True
        NextButton.Enabled = True
        PreviousButton.Enabled = True
        Try
            SupplierBindingSource.MoveLast()

        Catch ex As NoNullAllowedException
            MsgBox("Incorrect input! Follow correct format!", vbExclamation, "Incorrect Input!")
            Try
                Me.SupplierTableAdapter.Fill(Me.Group16DataSet.Supplier) 'refreshes records'
            Catch exe As SqlException
                MsgBox("Reconnect to network!", vbExclamation, "Reconnect to Network!")
            Catch exe As Exception
                MsgBox("Oops, something went wrong!", vbExclamation, "Error!")
            End Try
        Catch ex As Exception
            MsgBox("Oops, something went wrong!", vbExclamation, "Error!")
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

            Dim c As Control
            For Each c In RepDetailsGroupBox.Controls
                If TypeOf c Is TextBox Or TypeOf c Is MaskedTextBox Or TypeOf c Is ComboBox Or TypeOf c Is DateTimePicker Then
                    c.ResetText()
                End If
            Next

            DetailsGroupBox.Enabled = False
            RepDetailsGroupBox.Enabled = False
            NavigationGroupBox.Enabled = True
            UpdateButton.Enabled = False
            ButtonRefresh.Enabled = False
            CreateButton.Enabled = True
            ArchiveButton.Enabled = False
        Catch ex As Exception
            MsgBox("Oops, something went wrong!", vbExclamation, "Error!")
        End Try
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Try
            Dim ret As Integer = MsgBox("Confirm changes?", vbYesNo)

            If ret = 6 Then 'if user clicks yes to update'
                SupplierBindingSource.EndEdit()
                SupplierTableAdapter.Update(Group16DataSet)
                MsgBox("Update successful!")
                Call ButtonRefresh_Click(sender, e)

            End If
        Catch ex As SqlException
            MsgBox("Cannot Update!", vbExclamation, "Network Error!")
        Catch ex As NoNullAllowedException
            MsgBox("Incorrect input! Follow correct format!", vbExclamation, "Incorrect Input")
        Catch ex As Exception
            MsgBox("Oops, something went wrong!", vbExclamation, "Error!")

        End Try
    End Sub

    Private Sub CreateButton_Click(sender As Object, e As EventArgs) Handles CreateButton.Click
        Try
            Dim ret As Integer = MsgBox("Enter new values then click the SAVE button!", vbYesNo, "Create new supplier?")

            If ret = 6 Then 'if user clicks yes to update'

                NavigationGroupBox.Enabled = False
                DetailsGroupBox.Enabled = True
                RepDetailsGroupBox.Enabled = True
                UpdateButton.Enabled = True
                ButtonRefresh.Enabled = True
                ArchiveButton.Enabled = False
                CreateButton.Enabled = False

                Me.SupplierTableAdapter.Fill(Me.Group16DataSet.Supplier)
                SupplierBindingSource.MoveLast()
                Dim currentID As Integer = Integer.Parse(SupplierIDTextBox.Text)
                SupplierBindingSource.AddNew()
                SupplierIDTextBox.Text = currentID + 1
            End If
        Catch ex As SqlException
            MsgBox("Cannot Add!", vbExclamation, "Cannot Add!")
        Catch ex As NoNullAllowedException
            MsgBox("Incorrect input! Follow correct format!", vbExclamation, "Incorrect Input!")

            Try
                Me.SupplierTableAdapter.Fill(Me.Group16DataSet.Supplier) 'refreshes records'
            Catch exe As SqlException
                MsgBox("Reconnect to network!", vbExclamation, "Reconnect to Network!")
            Catch exe As Exception
                MsgBox("Oops, something went wrong!", vbExclamation, "Error!")
            End Try
        Catch ex As Exception
            MsgBox("Oops, something went wrong!", vbExclamation, "Error!")
        End Try
    End Sub

    Private Sub ArchiveButton_Click(sender As Object, e As EventArgs) Handles ArchiveButton.Click


    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Try
            Call FirstButton_Click(sender, e)
            If SearchComboBox.SelectedItem = "Supplier ID" Then
                SupplierBindingSource.Filter = "Supplier_ID = '" & SearchTextBox.Text & "'"
            ElseIf SearchComboBox.SelectedItem = "Company Name" Then
                SupplierBindingSource.Filter = "Supplier_Name LIKE'" & SearchTextBox.Text & "%'"
            ElseIf SearchComboBox.SelectedItem = "Supplier City" Then
                SupplierBindingSource.Filter = "Supplier_City LIKE'" & SearchTextBox.Text & "%'"
            ElseIf SearchComboBox.SelectedItem = "Rep Name" Then
                SupplierBindingSource.Filter = "Supplier_Rep_FName LIKE'" & SearchTextBox.Text & "%' OR Supplier_Rep_SName LIKE'" & SearchTextBox.Text & "%'"
            End If

            DetailsGroupBox.Enabled = True
            RepDetailsGroupBox.Enabled = True
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

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        If (SignIn.ManagerStatus = True) And (SignIn.EmployeeStatus = False) And (CreateOrEditSupplierQuote.CreateSupplierStatus = False) Then
            ManagerHomeMenuRevised.Show()
            Me.Close()

        ElseIf (SignIn.ManagerStatus = False) And (SignIn.EmployeeStatus = True) And (CreateOrEditCustomerQuote.CreateCustomerStatus = False) Then
            EmployeeHomeMenuRevised.Show()
            Me.Close()
        ElseIf (SignIn.ManagerStatus = False) And (SignIn.EmployeeStatus = False) And (CreateOrEditSupplierQuote.CreateSupplierStatus = True) Then
            CreateOrEditSupplierQuote.CreateSupplierStatus = False
            CreateOrEditSupplierQuote.SupplierTableAdapter.Fill(CreateOrEditSupplierQuote.Group16DataSet.Supplier)
            Me.Close()
        End If
    End Sub

    Private Sub Label35_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub HelpBtn_Click(sender As Object, e As EventArgs) Handles HelpBtn.Click
        'HelpView.Show()
        Help.ShowHelp(Me, HelpProvider1.HelpNamespace)
    End Sub

    Private Sub SearchButton_MouseHover(sender As Object, e As EventArgs) Handles SearchButton.MouseHover
        SupplierManagerTip.SetToolTip(SearchButton, "Click to search entry")
    End Sub

    Private Sub FirstButton_MouseHover(sender As Object, e As EventArgs) Handles FirstButton.MouseHover
        SupplierManagerTip.SetToolTip(FirstButton, "Click to go to first supplier")
    End Sub

    Private Sub NextButton_MouseHover(sender As Object, e As EventArgs) Handles NextButton.MouseHover
        SupplierManagerTip.SetToolTip(NextButton, "Click to go to next supplier")
    End Sub

    Private Sub PreviousButton_MouseHover(sender As Object, e As EventArgs) Handles PreviousButton.MouseHover
        SupplierManagerTip.SetToolTip(PreviousButton, "Click to go to previous supplier")
    End Sub

    Private Sub LastButton_MouseHover(sender As Object, e As EventArgs) Handles LastButton.MouseHover
        SupplierManagerTip.SetToolTip(LastButton, "Click to go to last supplier")
    End Sub

    Private Sub ArchiveButton_MouseHover(sender As Object, e As EventArgs) Handles ArchiveButton.MouseHover
        SupplierManagerTip.SetToolTip(ArchiveButton, "Click to archive supplier")
    End Sub

    Private Sub UpdateButton_MouseHover(sender As Object, e As EventArgs) Handles UpdateButton.MouseHover
        SupplierManagerTip.SetToolTip(UpdateButton, "Click to update supplier")
    End Sub

    Private Sub CreateButton_MouseHover(sender As Object, e As EventArgs) Handles CreateButton.MouseHover
        SupplierManagerTip.SetToolTip(CreateButton, "Click to create supplier")
    End Sub

    Private Sub ButtonRefresh_MouseHover(sender As Object, e As EventArgs) Handles ButtonRefresh.MouseHover
        SupplierManagerTip.SetToolTip(ButtonRefresh, "Click to refresh suppliers")
    End Sub

    Private Sub LogOutButton_MouseHover(sender As Object, e As EventArgs) Handles LogOutButton.MouseHover
        SupplierManagerTip.SetToolTip(LogOutButton, "Click to logout")
    End Sub

    Private Sub HelpBtn_MouseHover(sender As Object, e As EventArgs) Handles HelpBtn.MouseHover
        SupplierManagerTip.SetToolTip(HelpBtn, "Click to view additional help")
    End Sub

    Private Sub BackButton_MouseHover(sender As Object, e As EventArgs) Handles BackButton.MouseHover
        SupplierManagerTip.SetToolTip(BackButton, "Click to go back")
    End Sub
End Class
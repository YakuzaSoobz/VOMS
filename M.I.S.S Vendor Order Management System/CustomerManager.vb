﻿Imports System.Data.SqlClient

Public Class CustomerManager

    Dim InitialEmail As String = ""
    Dim CreateDefaultPassword = False

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
            CreateDefaultPassword = False
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
                CreateDefaultPassword = True
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

    Public Function ValidateEmail(ByVal strCheck As String) As Boolean
        Try
            Dim vEmailAddress As New System.Net.Mail.MailAddress(strCheck)
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Try
            CreateDefaultPassword = False

            If (FNameTextBox.Text = Nothing) Then
                MsgBox("First Name field cannot be left blank!", vbOK)
                FNameTextBox.ResetText()
            ElseIf (SNameTextBox.Text = Nothing) Then
                MsgBox("Surname field cannot be left blank!", vbOK)
                SNameTextBox.ResetText()
            ElseIf (DOBDateTimePicker.Text = Nothing) Then
                MsgBox("DOB field cannot be left blank!", vbOK)
                DOBDateTimePicker.ResetText()
            ElseIf (ContactNumberMaskedTextBox.Text = "(   )") Then
                MsgBox("Contact Number field cannot be left blank!", vbOK)
                ContactNumberMaskedTextBox.ResetText()
            ElseIf (EmailTextBox.Text = Nothing) Then
                MsgBox("Email field cannot be left blank!", vbOK)
                EmailTextBox.ResetText()
            ElseIf (PasswordTextBox.Text = Nothing) Then
                MsgBox("Password field cannot be left blank!", vbOK)
                PasswordTextBox.ResetText()
            ElseIf (StreetAddress1TextBox.Text = Nothing) Then
                MsgBox("Street Address 1 field cannot be left blank!", vbOK)
                StreetAddress1TextBox.ResetText()
            ElseIf (SuburbTextBox.Text = Nothing) Then
                MsgBox("Suburb field cannot be left blank!", vbOK)
                SuburbTextBox.ResetText()
            ElseIf (CityTextBox.Text = Nothing) Then
                MsgBox("City field cannot be left blank!", vbOK)
                CityTextBox.ResetText()
            ElseIf (ProvinceTextBox.Text = Nothing) Then
                MsgBox("Province field cannot be left blank!", vbOK)
                ProvinceTextBox.ResetText()
            ElseIf (PostalCodeMaskedTextBox.Text.Contains(" ")) Then
                MsgBox("Postal Code field cannot be left blank!", vbOK)
                PostalCodeMaskedTextBox.ResetText()
            ElseIf (ActiveStatusComboBox.Text = Nothing) Then
                MsgBox("Active Status field cannot be left blank!", vbOK)
                ActiveStatusComboBox.ResetText()

                'Above is a full check for blanks , contact num code is tweaked abit for masking'

                'check valid email
            ElseIf Not (ValidateEmail(EmailTextBox.Text)) Then
                MsgBox("Email format is invalid! , Follow this format eg.starplatinum@domain.com", vbOK)
                EmailTextBox.ResetText() 'Email validator which calls function'
            ElseIf ((checkUniqueEmail(EmailTextBox.Text) = False) And Not (InitialEmail = EmailTextBox.Text)) Then
                MsgBox("This email already exists in the database! , try a different one!", vbOK)
                EmailTextBox.Text = InitialEmail 'Email validator which calls function'

            ElseIf (PasswordTextBox.Text.Length > 10 Or PasswordTextBox.Text.Length < 0) Then
                MsgBox("Password length invalid!", vbOK)
                PasswordTextBox.ResetText() 'Password length checker'
            ElseIf Not (ActiveStatusComboBox.Text = "F" Or ActiveStatusComboBox.Text = "T") Then
                MsgBox("Active Status field must be either T or F!", vbOK)
                ActiveStatusComboBox.ResetText() 'Active Status checker'

            Else
                FNameTextBox.Text = FNameTextBox.Text.Trim
                SNameTextBox.Text = SNameTextBox.Text.Trim
                ContactNumberMaskedTextBox.Text = ContactNumberMaskedTextBox.Text.Trim
                EmailTextBox.Text = EmailTextBox.Text.Trim
                PasswordTextBox.Text = PasswordTextBox.Text.Trim
                StreetAddress1TextBox.Text = StreetAddress1TextBox.Text.Trim
                SuburbTextBox.Text = SuburbTextBox.Text.Trim
                CityTextBox.Text = CityTextBox.Text.Trim

                'Removes white spaces before and after certain fields to avoid invalids'

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
            End If
        Catch ex As FormatException
            MsgBox("Cannot add item. Please use correct format to fill fields!", vbExclamation, "Incorrect Input!")
        Catch ex As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
        End Try
    End Sub

    Public Function checkUniqueEmail(ByVal EmailAddress)

        If (EmployeeTableAdapter.GetUniqueEmailQuery(EmailAddress) > 0) Or (CustomerTableAdapter.CheckUniqueEmailQuery(EmailAddress) > 0) Or (SupplierTableAdapter.CheckUniqueSupplierEmailQuery(EmailAddress, EmailAddress) > 0) Then
            Return False
        Else
            Return True
        End If
    End Function

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
                InitialEmail = EmailTextBox.Text
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
            InitialEmail = EmailTextBox.Text
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
            InitialEmail = EmailTextBox.Text
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
            InitialEmail = EmailTextBox.Text
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
            InitialEmail = EmailTextBox.Text
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
            ElseIf (CreateOrEditCustomerQuote.CreateCustomerStatus = True) Then
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
        Dim helpFilePath = IO.Path.Combine(My.Application.Info.DirectoryPath, "M.I.S.chm")
        Help.ShowHelp(Me, helpFilePath)
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

    Private Sub FNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles FNameTextBox.TextChanged
        If (FNameTextBox.Text = Nothing) Then
            FNameTextBox.BackColor = Color.MistyRose
        Else
            FNameTextBox.BackColor = Color.White
        End If
    End Sub

    Private Sub SNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles SNameTextBox.TextChanged
        If (SNameTextBox.Text = Nothing) Then
            SNameTextBox.BackColor = Color.MistyRose
        Else
            SNameTextBox.BackColor = Color.White
        End If
    End Sub

    Private Sub ContactNumberMaskedTextBox_TextChanged(sender As Object, e As EventArgs) Handles ContactNumberMaskedTextBox.TextChanged
        If (ContactNumberMaskedTextBox.Text = "(   )") Then
            ContactNumberMaskedTextBox.BackColor = Color.MistyRose
        Else
            ContactNumberMaskedTextBox.BackColor = Color.White
        End If
    End Sub

    Private Sub EmailTextBox_TextChanged(sender As Object, e As EventArgs) Handles EmailTextBox.TextChanged
        If (EmailTextBox.Text = Nothing) Then
            EmailTextBox.BackColor = Color.MistyRose
        ElseIf Not (ValidateEmail(EmailTextBox.Text)) Then
            EmailTextBox.BackColor = Color.MistyRose
        Else
            EmailTextBox.BackColor = Color.White
        End If
    End Sub

    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles PasswordTextBox.TextChanged
        If (PasswordTextBox.Text = Nothing) Then
            PasswordTextBox.BackColor = Color.MistyRose
        Else
            PasswordTextBox.BackColor = Color.White
        End If
    End Sub

    Private Sub StreetAddress1TextBox_TextChanged(sender As Object, e As EventArgs) Handles StreetAddress1TextBox.TextChanged
        If (StreetAddress1TextBox.Text = Nothing) Then
            StreetAddress1TextBox.BackColor = Color.MistyRose
        Else
            StreetAddress1TextBox.BackColor = Color.White
        End If
    End Sub

    Private Sub SuburbTextBox_TextChanged(sender As Object, e As EventArgs) Handles SuburbTextBox.TextChanged
        If (SuburbTextBox.Text = Nothing) Then
            SuburbTextBox.BackColor = Color.MistyRose
        Else
            SuburbTextBox.BackColor = Color.White
        End If
    End Sub

    Private Sub CityTextBox_TextChanged(sender As Object, e As EventArgs) Handles CityTextBox.TextChanged
        If (CityTextBox.Text = Nothing) Then
            CityTextBox.BackColor = Color.MistyRose
        Else
            CityTextBox.BackColor = Color.White
        End If
    End Sub

    Private Sub ProvinceTextBox_TextChanged(sender As Object, e As EventArgs) Handles ProvinceTextBox.TextChanged
        If (ProvinceTextBox.Text = Nothing) Then
            ProvinceTextBox.BackColor = Color.MistyRose
        Else
            ProvinceTextBox.BackColor = Color.White
        End If
    End Sub

    Private Sub ActiveStatusComboBox_TextChanged(sender As Object, e As EventArgs) Handles ActiveStatusComboBox.TextChanged
        If (ActiveStatusComboBox.Text = Nothing) Then
            ActiveStatusComboBox.BackColor = Color.MistyRose
        ElseIf Not (ActiveStatusComboBox.Text = "F" Or ActiveStatusComboBox.Text = "T") Then
            ActiveStatusComboBox.BackColor = Color.MistyRose
        Else
            ActiveStatusComboBox.BackColor = Color.White
        End If
    End Sub

    Private Sub DOBDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles DOBDateTimePicker.ValueChanged
        Try
            If (CreateDefaultPassword = True) Then

                Dim DefaultPassword As String
                DefaultPassword = DOBDateTimePicker.Value.ToString("dd/MM/yyyy")
                PasswordTextBox.Text = DefaultPassword
                MsgBox(DefaultPassword)

            End If
                
        Catch ex As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
        End Try
    End Sub
End Class
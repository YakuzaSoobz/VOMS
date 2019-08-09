Imports System.Data.SqlClient

Public Class SupplierManager

    Dim InitialSupplierEmail As String = ""
    Dim InitialRepEmail As String = ""

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
            MsgBox("Incorrect input!Follow correct format!", vbExclamation, "Incorrect Input!")
        Catch ex As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
        Finally
            Try
                Me.SupplierTableAdapter.Fill(Me.Group16DataSet.Supplier) 'refreshes records'
                InitialSupplierEmail = SupplierEmailTextBox.Text
                InitialRepEmail = RepEmailTextBox.Text
            Catch ex As SqlException
                MsgBox("Reconnect to network!", vbExclamation, "Reconnect to Network!")
            Catch ex As Exception
                MsgBox("Oops something went wrong!", vbExclamation, "Error!")
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
            InitialSupplierEmail = SupplierEmailTextBox.Text
            InitialRepEmail = RepEmailTextBox.Text
        Catch ex As NoNullAllowedException
            MsgBox("Incorrect input!Follow correct format!", vbExclamation, "Incorrect Input!")
            Try
                Me.SupplierTableAdapter.Fill(Me.Group16DataSet.Supplier) 'refreshes records'
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
        RepDetailsGroupBox.Enabled = True
        UpdateButton.Enabled = True
        ButtonRefresh.Enabled = True
        ArchiveButton.Enabled = True

        Try
            SupplierBindingSource.MovePrevious()
            InitialSupplierEmail = SupplierEmailTextBox.Text
            InitialRepEmail = RepEmailTextBox.Text
        Catch ex As NoNullAllowedException
            MsgBox("Incorrect input!Follow correct format!", vbExclamation, "Incorrect Input!")
            Try
                Me.SupplierTableAdapter.Fill(Me.Group16DataSet.Supplier) 'refreshes records'
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
        RepDetailsGroupBox.Enabled = True
        UpdateButton.Enabled = True
        ButtonRefresh.Enabled = True
        ArchiveButton.Enabled = True
        NextButton.Enabled = True
        PreviousButton.Enabled = True
        Try
            SupplierBindingSource.MoveLast()
            InitialSupplierEmail = SupplierEmailTextBox.Text
            InitialRepEmail = RepEmailTextBox.Text
        Catch ex As NoNullAllowedException
            MsgBox("Incorrect input!Follow correct format!", vbExclamation, "Incorrect Input!")
            Try
                Me.SupplierTableAdapter.Fill(Me.Group16DataSet.Supplier) 'refreshes records'
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
            If (CompanyNameTextBox.Text = Nothing) Then
                MsgBox("Company Name field cannot be left blank!", vbOK)
                CompanyNameTextBox.ResetText()
            ElseIf (RepFNameTextBox.Text = Nothing) Then
                MsgBox("Rep First Name field cannot be left blank!", vbOK)
                RepFNameTextBox.ResetText()
            ElseIf (RepSNameTextBox.Text = Nothing) Then
                MsgBox("Rep Surname field cannot be left blank!", vbOK)
                RepSNameTextBox.ResetText()
            ElseIf (ContactNoMaskedTextBox.Text = "(   )") Then
                MsgBox("Contact Number field cannot be left blank!", vbOK)
                ContactNoMaskedTextBox.ResetText()
            ElseIf (RepContactNumberMaskedTextBox.Text = "(   )") Then
                MsgBox("Rep Contact Number field cannot be left blank!", vbOK)
                RepContactNumberMaskedTextBox.ResetText()
            ElseIf (SupplierEmailTextBox.Text = Nothing) Then
                MsgBox("Supplier Email field cannot be left blank!", vbOK)
                SupplierEmailTextBox.ResetText()
            ElseIf (RepEmailTextBox.Text = Nothing) Then
                MsgBox("Rep Email field cannot be left blank!", vbOK)
                RepEmailTextBox.ResetText()
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

                'check supplier valid email
            ElseIf Not (ValidateEmail(SupplierEmailTextBox.Text)) Then
                MsgBox("Supplier Email format is invalid! , Follow this format eg.starplatinum@domain.com", vbOK)
                SupplierEmailTextBox.ResetText() 'Email validator which calls function'
            ElseIf ((checkUniqueEmail(SupplierEmailTextBox.Text) = False) And Not (InitialSupplierEmail = SupplierEmailTextBox.Text)) Then
                MsgBox("This email already exists in the database! , try a different one!", vbOK)
                SupplierEmailTextBox.Text = InitialSupplierEmail 'Email validator which calls function'

                'check valid rep email
            ElseIf Not (ValidateEmail(RepEmailTextBox.Text)) Then
                MsgBox("The Representitive's Email format is invalid! , Follow this format eg.starplatinum@domain.com", vbOK)
                SupplierEmailTextBox.ResetText() 'Email validator which calls function'
            ElseIf ((checkUniqueEmail(RepEmailTextBox.Text) = False) And Not (InitialRepEmail = RepEmailTextBox.Text)) Then
                MsgBox("This email already exists in the database! , try a different one!", vbOK)
                RepEmailTextBox.Text = InitialRepEmail 'Email validator which calls function'

            ElseIf (PasswordTextBox.Text.Length > 10 Or PasswordTextBox.Text.Length < 0) Then
                MsgBox("Password length invalid!", vbOK)
                PasswordTextBox.ResetText() 'Password length checker'
            ElseIf Not (ActiveStatusComboBox.Text = "F" Or ActiveStatusComboBox.Text = "T") Then
                MsgBox("Active Status field must be either T or F!", vbOK)
                ActiveStatusComboBox.ResetText() 'Active Status checker'

            Else
                CompanyNameTextBox.Text = CompanyNameTextBox.Text.Trim
                RepFNameTextBox.Text = RepFNameTextBox.Text.Trim
                RepSNameTextBox.Text = RepSNameTextBox.Text.Trim
                ContactNoMaskedTextBox.Text = ContactNoMaskedTextBox.Text.Trim
                RepContactNumberMaskedTextBox.Text = RepContactNumberMaskedTextBox.Text.Trim
                SupplierEmailTextBox.Text = SupplierEmailTextBox.Text.Trim
                RepEmailTextBox.Text = RepEmailTextBox.Text.Trim
                PasswordTextBox.Text = PasswordTextBox.Text.Trim
                StreetAddress1TextBox.Text = StreetAddress1TextBox.Text.Trim
                SuburbTextBox.Text = SuburbTextBox.Text.Trim
                CityTextBox.Text = CityTextBox.Text.Trim

                'Removes white spaces before and after certain fields to avoid invalids'
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

    Private Sub CreateButton_Click(sender As Object, e As EventArgs) Handles CreateButton.Click
        Try
            Dim ret As Integer = MsgBox("Enter new values , then click the SAVE button!", vbYesNo, "Create new supplier?")

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
            MsgBox("Incorrect input!Follow correct format!", vbExclamation, "Incorrect Input!")

            Try
                Me.SupplierTableAdapter.Fill(Me.Group16DataSet.Supplier) 'refreshes records'
            Catch exe As SqlException
                MsgBox("Reconnect to network!", vbExclamation, "Reconnect to Network!")
            Catch exe As Exception
                MsgBox("Oops something went wrong!", vbExclamation, "Error!")
            End Try
        Catch ex As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
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

            InitialSupplierEmail = SupplierEmailTextBox.Text
            InitialRepEmail = RepEmailTextBox.Text
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
            ManagerHomeMenu.Show()
            Me.Close()

        ElseIf (SignIn.ManagerStatus = False) And (SignIn.EmployeeStatus = True) And (CreateOrEditCustomerQuote.CreateCustomerStatus = False) Then
            EmployeeHomeMenu.Show()
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
        HelpView.Show()
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
        SupplierManagerTip.SetToolTip(HelpBtn, "Click to get help")
    End Sub

    Private Sub BackButton_MouseHover(sender As Object, e As EventArgs) Handles BackButton.MouseHover
        SupplierManagerTip.SetToolTip(BackButton, "Click to go back")
    End Sub

    Private Sub CompanyNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles CompanyNameTextBox.TextChanged
        If (CompanyNameTextBox.Text = Nothing) Then
            CompanyNameTextBox.BackColor = Color.MistyRose
        Else
            CompanyNameTextBox.BackColor = Color.White
        End If
    End Sub

    Private Sub RepFNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles RepFNameTextBox.TextChanged
        If (RepFNameTextBox.Text = Nothing) Then
            RepFNameTextBox.BackColor = Color.MistyRose
        Else
            RepFNameTextBox.BackColor = Color.White
        End If
    End Sub

    Private Sub RepSNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles RepSNameTextBox.TextChanged
        If (RepSNameTextBox.Text = Nothing) Then
            RepSNameTextBox.BackColor = Color.MistyRose
        Else
            RepSNameTextBox.BackColor = Color.White
        End If
    End Sub

    Private Sub ContactNoMaskedTextBox_TextChanged(sender As Object, e As EventArgs) Handles ContactNoMaskedTextBox.TextChanged
        If (ContactNoMaskedTextBox.Text = "(   )") Then
            ContactNoMaskedTextBox.BackColor = Color.MistyRose
        Else
            ContactNoMaskedTextBox.BackColor = Color.White
        End If
    End Sub

    Private Sub SupplierEmailTextBox_TextChanged(sender As Object, e As EventArgs) Handles SupplierEmailTextBox.TextChanged
        If (SupplierEmailTextBox.Text = Nothing) Then
            SupplierEmailTextBox.BackColor = Color.MistyRose
        Else
            SupplierEmailTextBox.BackColor = Color.White
        End If
    End Sub

    Private Sub RepContactNumberMaskedTextBox_TextChanged(sender As Object, e As EventArgs) Handles RepContactNumberMaskedTextBox.TextChanged
        If (RepContactNumberMaskedTextBox.Text = "(   )") Then
            RepContactNumberMaskedTextBox.BackColor = Color.MistyRose
        Else
            RepContactNumberMaskedTextBox.BackColor = Color.White
        End If
    End Sub

    Private Sub RepEmailTextBox_TextChanged(sender As Object, e As EventArgs) Handles RepEmailTextBox.TextChanged
        If (RepEmailTextBox.Text = Nothing) Then
            RepEmailTextBox.BackColor = Color.MistyRose
        ElseIf Not (ValidateEmail(RepEmailTextBox.Text)) Then
            RepEmailTextBox.BackColor = Color.MistyRose
        Else
            RepEmailTextBox.BackColor = Color.White
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
End Class
Imports System.Data.SqlClient

Public Class ProductManager
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

    Private Sub ProductManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group16DataSet.Customer' table. You can move, or remove it, as needed.
        DetailsGroupBox.Enabled = False
        UpdateButton.Enabled = False
        ButtonRefresh.Enabled = False
        ArchiveButton.Enabled = False

        NextButton.Enabled = False
        PreviousButton.Enabled = False
    End Sub

    Private Sub FirstButton_Click(sender As Object, e As EventArgs) Handles FirstButton.Click
        NextButton.Enabled = True
        PreviousButton.Enabled = True
        DetailsGroupBox.Enabled = True
        UpdateButton.Enabled = True
        ButtonRefresh.Enabled = True
        ArchiveButton.Enabled = True

        Try
            ProductBindingSource.MoveFirst()
        Catch ex As NoNullAllowedException
            MsgBox("Incorrect input!Follow correct format!", vbExclamation, "Incorrect Input!")
        Catch ex As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
        Finally

            Try
                Me.ProductTableAdapter.Fill(Me.Group16DataSet.Product) 'refreshes records'
            Catch exe As SqlException
                MsgBox("Reconnect to network!", vbExclamation, "Reconnect to Network!")
            Catch exe As Exception
                MsgBox("Oops something went wrong!", vbExclamation, "Error!")
            End Try
        End Try
    End Sub

    Private Sub PreviousButton_Click(sender As Object, e As EventArgs) Handles PreviousButton.Click

        DetailsGroupBox.Enabled = True
        UpdateButton.Enabled = True
        ButtonRefresh.Enabled = True
        ArchiveButton.Enabled = True

        Try
            ProductBindingSource.MovePrevious()
        Catch ex As NoNullAllowedException
            MsgBox("Incorrect input!Follow correct format!", vbExclamation, "Incorrect Input!")
            Try
                Me.ProductTableAdapter.Fill(Me.Group16DataSet.Product) 'refreshes records'
            Catch exe As SqlException
                MsgBox("Reconnect to network!", vbExclamation, "Reconnect to Network!")
            Catch exe As Exception
                MsgBox("Oops something went wrong!", vbExclamation, "Error!")
            End Try
        Catch ex As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
        End Try
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click

        DetailsGroupBox.Enabled = True
        UpdateButton.Enabled = True
        ButtonRefresh.Enabled = True
        ArchiveButton.Enabled = True

        Try
            ProductBindingSource.MoveNext()
        Catch ex As NoNullAllowedException
            MsgBox("Incorrect input!Follow correct format!", vbExclamation, "Incorrect Input!")
            Try
                Me.ProductTableAdapter.Fill(Me.Group16DataSet.Product) 'refreshes records'
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
        NextButton.Enabled = True
        PreviousButton.Enabled = True
        DetailsGroupBox.Enabled = True
        UpdateButton.Enabled = True
        ButtonRefresh.Enabled = True
        ArchiveButton.Enabled = True

        Try
            ProductBindingSource.MoveLast()

        Catch ex As NoNullAllowedException
            MsgBox("Incorrect input!Follow correct format!", vbExclamation, "Incorrect Input!")
            Me.ProductTableAdapter.Fill(Me.Group16DataSet.Product) 'refreshes records'
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

            Group16DataSet.Product.Rows.Clear()

            DetailsGroupBox.Enabled = False
            NavigationGroupBox.Enabled = True
            UpdateButton.Enabled = False
            ButtonRefresh.Enabled = False
            ArchiveButton.Enabled = False
        Catch ex As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
        End Try
    End Sub

    Private Sub CreateButton_Click(sender As Object, e As EventArgs) Handles CreateButton.Click

        Try
            Dim ret As Integer = MsgBox("Enter new values , then click the SAVE button!", vbYesNo, "Create new product?")

            If ret = 6 Then 'if user clicks yes to update'

                NavigationGroupBox.Enabled = False
                DetailsGroupBox.Enabled = True
                UpdateButton.Enabled = True
                ButtonRefresh.Enabled = True
                ArchiveButton.Enabled = False
                CreateButton.Enabled = False

                Me.ProductTableAdapter.Fill(Me.Group16DataSet.Product)
                ProductBindingSource.MoveLast()
                Dim currentID As Integer = Integer.Parse(ProductIDTextBox.Text)
                ProductBindingSource.AddNew()
                ProductIDTextBox.Text = currentID + 1
            End If
        Catch ex As SqlException
            MsgBox("Cannot Add!", vbExclamation, "Cannot Add!")
        Catch ex As NoNullAllowedException
            MsgBox("Incorrect input!Follow correct format!", vbExclamation, "Incorrect Input!")
            Try
                Me.ProductTableAdapter.Fill(Me.Group16DataSet.Product) 'refreshes records'
            Catch exe As SqlException
                MsgBox("Reconnect to network!", vbExclamation, "Reconnect to Network!")
            Catch exe As Exception
                MsgBox("Oops something went wrong!", vbExclamation, "Error!")
            End Try
        Catch ex As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
        End Try
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Try
            If (ProductNameTextBox.Text.Trim = Nothing) Then
                MsgBox("Product Name field cannot be left blank!", vbOK)
                ProductNameTextBox.ResetText()
            ElseIf (BrandNameTextBox.Text.Trim = Nothing) Then
                MsgBox("Brand Name field cannot be left blank!", vbOK)
                BrandNameTextBox.ResetText()
            ElseIf (ProductDescriptionTextBox.Text = Nothing) Then
                MsgBox("Product Description field cannot be left blank!", vbOK)
                ProductDescriptionTextBox.ResetText()
            ElseIf (ActiveStatusComboBox.Text = Nothing) Then
                MsgBox("Active Status field cannot be left blank!", vbOK)
                ActiveStatusComboBox.ResetText()
            ElseIf Not (ActiveStatusComboBox.Text = "F" Or ActiveStatusComboBox.Text = "T") Then
                MsgBox("Active Status field must be either T or F!", vbOK)
                ActiveStatusComboBox.ResetText()

            Else

                Try
                Dim ret As Integer = MsgBox("Confirm changes?", vbYesNo)

                If ret = 6 Then 'if user clicks yes to update'
                    ProductBindingSource.EndEdit()
                    ProductTableAdapter.Update(Group16DataSet)
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
        End Try
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click

        Try
            Call FirstButton_Click(sender, e)
            If SearchComboBox.SelectedItem = "Product ID" Then
                ProductBindingSource.Filter = "Product_ID = '" & SearchTextBox.Text & "'"
            ElseIf SearchComboBox.SelectedItem = "Product Name" Then
                ProductBindingSource.Filter = "Product_Name LIKE'" & SearchTextBox.Text & "%'"
            ElseIf SearchComboBox.SelectedItem = "Product Brand" Then
                ProductBindingSource.Filter = "Product_Brand LIKE'" & SearchTextBox.Text & "%'"
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

    Private Sub ArchiveButton_Click(sender As Object, e As EventArgs) Handles ArchiveButton.Click

        ActiveStatusComboBox.SelectedItem = "F"
        Call UpdateButton_Click(sender, e)
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click

        Try
            If (SignIn.ManagerStatus = True) And (SignIn.EmployeeStatus = False) And (SupplierQuoteLineItemManager.CreateProductStatus = False) Then
                ManagerHomeMenu.Show()
                Me.Close()

            ElseIf (SignIn.ManagerStatus = False) And (SignIn.EmployeeStatus = True) And (CreateOrEditCustomerQuote.CreateCustomerStatus = False) Then
                EmployeeHomeMenu.Show()
                Me.Close()

            ElseIf (SignIn.ManagerStatus = False) And (SignIn.EmployeeStatus = False) And (SupplierQuoteLineItemManager.CreateProductStatus = True) Then
                SupplierQuoteLineItemManager.CreateProductStatus = False
                SupplierQuoteLineItemManager.ProductTableAdapter.Fill(SupplierQuoteLineItemManager.Group16DataSet.Product)
                Me.Close()
            End If
        Catch ex As SqlException
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
        ProductManagerTip.SetToolTip(SearchButton, "Click to search entry")
    End Sub

    Private Sub FirstButton_MouseHover(sender As Object, e As EventArgs) Handles FirstButton.MouseHover
        ProductManagerTip.SetToolTip(FirstButton, "Click to go to first product")
    End Sub

    Private Sub NextButton_MouseHover(sender As Object, e As EventArgs) Handles NextButton.MouseHover
        ProductManagerTip.SetToolTip(NextButton, "Click to go to next product")
    End Sub

    Private Sub PreviousButton_MouseHover(sender As Object, e As EventArgs) Handles PreviousButton.MouseHover
        ProductManagerTip.SetToolTip(PreviousButton, "Click to go to previous product")
    End Sub

    Private Sub LastButton_MouseHover(sender As Object, e As EventArgs) Handles LastButton.MouseHover
        ProductManagerTip.SetToolTip(LastButton, "Click to go to last product")
    End Sub

    Private Sub ArchiveButton_MouseHover(sender As Object, e As EventArgs) Handles ArchiveButton.MouseHover
        ProductManagerTip.SetToolTip(ArchiveButton, "Click to archive product")
    End Sub

    Private Sub UpdateButton_MouseHover(sender As Object, e As EventArgs) Handles UpdateButton.MouseHover
        ProductManagerTip.SetToolTip(UpdateButton, "Click to update product")
    End Sub

    Private Sub CreateButton_MouseHover(sender As Object, e As EventArgs) Handles CreateButton.MouseHover
        ProductManagerTip.SetToolTip(CreateButton, "Click to create product")
    End Sub

    Private Sub ButtonRefresh_MouseHover(sender As Object, e As EventArgs) Handles ButtonRefresh.MouseHover
        ProductManagerTip.SetToolTip(ButtonRefresh, "Click to refresh products")
    End Sub

    Private Sub LogOutButton_MouseHover(sender As Object, e As EventArgs) Handles LogOutButton.MouseHover
        ProductManagerTip.SetToolTip(LogOutButton, "Click to logout")
    End Sub

    Private Sub HelpBtn_MouseHover(sender As Object, e As EventArgs) Handles HelpBtn.MouseHover
        ProductManagerTip.SetToolTip(HelpBtn, "Click to get help")
    End Sub

    Private Sub BackButton_MouseHover(sender As Object, e As EventArgs) Handles BackButton.MouseHover
        ProductManagerTip.SetToolTip(BackButton, "Click to go back")
    End Sub

    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged

        Try
            Call FirstButton_Click(sender, e)

            If SearchComboBox.SelectedItem = "Product Name" Then
                ProductBindingSource.Filter = "Product_Name LIKE'" & SearchTextBox.Text & "%'"
            ElseIf SearchComboBox.SelectedItem = "Product Brand" Then
                ProductBindingSource.Filter = "Product_Brand LIKE'" & SearchTextBox.Text & "%'"
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

    Private Sub ProductNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles ProductNameTextBox.TextChanged
        If (ProductNameTextBox.Text.Trim = Nothing) Then
            ProductNameTextBox.BackColor = Color.MistyRose
        Else
            ProductNameTextBox.BackColor = Color.White
        End If
    End Sub

    Private Sub BrandNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles BrandNameTextBox.TextChanged
        If (BrandNameTextBox.Text.Trim = Nothing) Then
            BrandNameTextBox.BackColor = Color.MistyRose
        Else
            BrandNameTextBox.BackColor = Color.White
        End If
    End Sub

    Private Sub ProductDescriptionTextBox_TextChanged(sender As Object, e As EventArgs) Handles ProductDescriptionTextBox.TextChanged
        If (ProductDescriptionTextBox.Text.Trim = Nothing) Then
            ProductDescriptionTextBox.BackColor = Color.MistyRose
        Else
            ProductDescriptionTextBox.BackColor = Color.White
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
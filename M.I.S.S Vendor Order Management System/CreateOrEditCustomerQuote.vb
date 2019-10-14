Imports System.Data.SqlClient

Public Class CreateOrEditCustomerQuote

    Public CreateCustomerStatus As Boolean = False
    Public CustomerQuoteID As Integer
    Public ActiveQuoteStatus As Boolean = False



    Private Sub CreateOrEditCustomerQuote_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            If (CustomerQuoteManager.EditStatus = True) And (CustomerQuoteManager.CreateStatus = False) Then 'edit quote
                Me.Customer_QuoteTableAdapter.Fill(Me.Group16DataSet.Customer_Quote)
                Me.CustomerTableAdapter.Fill(Me.Group16DataSet.Customer)
                Me.EmployeeTableAdapter.Fill(Me.Group16DataSet.Employee)
                Me.CustLineItemJoinProductsTableAdapter.Fill(Me.Group16DataSet.CustLineItemJoinProducts)

                EditLineItemsButton.Text = "EDIT ITEMS"
                UpdateQuoteButton.Text = "UPDATE QUOTE"
                Me.Text = "Edit Customer Quote"
                NotificationLabel.Visible = False


            ElseIf (CustomerQuoteManager.EditStatus = False) And (CustomerQuoteManager.CreateStatus = True) Then 'create quote


                Me.CustomerTableAdapter.Fill(Me.Group16DataSet.Customer)
                Me.EmployeeTableAdapter.Fill(Me.Group16DataSet.Employee)
                QuoteAcceptanceStatusComboBox.SelectedItem = "N"

                MsgBox("Enter new QUOTE DETAILS and ADD ITEMS to the quote!Click SAVE when you are done.", vbInformation)
                Me.Text = "Create Customer Quote"
                UpdateQuoteButton.Text = "SAVE QUOTE"
                EditLineItemsButton.Text = "ADD ITEMS"

                DeleteQuoteButton.Enabled = False
                DeleteQuoteButton.Visible = False
                CustLineItemJoinProductDataGridView.Visible = False
                EditLineItemsButton.Enabled = False
                TotalPriceTextBox.Text = 0


            End If
        Catch exe As SqlException
            MsgBox("Reconnect to network!", vbExclamation, "Reconnect to Network!")
        Catch exe As Exception
            MsgBox("Oops... Page failed too load correctly!", vbExclamation, "Error!")
        End Try

    End Sub

    Private Sub QuoteAcceptanceStatusComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles QuoteAcceptanceStatusComboBox.SelectedIndexChanged

        If ((QuoteAcceptanceStatusComboBox.SelectedItem = "Y") Or (QuoteAcceptanceStatusComboBox.SelectedItem = "y")) Then

            DateAcceptedTextBox.Text = Date.Today

        ElseIf ((QuoteAcceptanceStatusComboBox.SelectedItem = "N") Or (QuoteAcceptanceStatusComboBox.SelectedItem = "n")) Then

            DateAcceptedTextBox.Text = ""

        End If

    End Sub

    Private Sub CreateCustomerButton_Click(sender As Object, e As EventArgs) Handles CreateCustomerButton.Click
        CreateCustomerStatus = True
        CustomerManager.Show()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click

        If (ActiveQuoteStatus = False) Then
            Dim answer As MsgBoxResult = MsgBox("Are you sure you want to leave this page? All unsaved changes will be lost", MsgBoxStyle.YesNo)
            If answer = MsgBoxResult.Yes Then
                CustomerQuoteManager.Show()
                Me.Close()
            End If
        ElseIf (ActiveQuoteStatus = True) Then 'save button has been clicked
            If ((CustLineItemJoinProductDataGridView.RowCount > 0)) Then

                Dim answer As MsgBoxResult = MsgBox("Are you sure you want to leave this page? All unsaved changes will be lost", MsgBoxStyle.YesNo)
                If answer = MsgBoxResult.Yes Then
                    CustomerQuoteManager.Show()
                    Me.Close()
                End If

            ElseIf ((CustLineItemJoinProductDataGridView.RowCount < 1)) Then
                MsgBox("You need to add atleast one item to the quote first before leaving!", MsgBoxStyle.YesNo)
            End If
        End If

        Call CustomerQuoteManager.RefreshButton_Click(sender, e)


    End Sub

    Public Sub UpdateQuoteButton_Click(sender As Object, e As EventArgs) Handles UpdateQuoteButton.Click
        Try
            If (CustomerQuoteManager.EditStatus = True) And (CustomerQuoteManager.CreateStatus = False) Then 'edit quote

                Try
                    getTotal()
                    Dim ret As Integer = MsgBox("Confirm changes to Customer Quote " & CustomerQuoteID & " ?", vbYesNo)
                    If ret = 6 Then 'if user clicks yes to update'

                        If (QuoteAcceptanceStatusComboBox.SelectedItem = "N") Then 'if date is empTy then make it 1111/11/11
                            DateAcceptedTextBox.Text = "1111/11/11"
                        End If

                        CustomerQuoteBindingSource.EndEdit()
                        Customer_QuoteTableAdapter.Update(Me.Group16DataSet.Customer_Quote)

                        If (QuoteAcceptanceStatusComboBox.SelectedItem = "N") Then 'if date is 1111/11/1111 then make it null
                            DateAcceptedTextBox.Text = ""
                            CustomerQuoteBindingSource.EndEdit()
                            Customer_QuoteTableAdapter.UpdateDateAcceptedNULLQuery(CustomerQuoteID)
                            MsgBox("Update successful!")
                        End If
                    End If
                Catch ex As SqlException
                    MsgBox("Cannot Update!", vbExclamation, "Cannot Update!")
                Catch ex As NoNullAllowedException
                    MsgBox("Incorrect input!Follow correct format!", vbExclamation, "Incorrect Input")
                Catch ex As Exception
                    MsgBox("Oops something went wrong!", vbExclamation, "Error!")
                Finally
                    CustomerQuoteManager.CustomerQuoteJoinCustomerTableAdapter.Fill(CustomerQuoteManager.Group16DataSet.CustomerQuoteJoinCustomer)
                    CustomerQuoteManager.CustLineItemJoinProductsTableAdapter.Fill(CustomerQuoteManager.Group16DataSet.CustLineItemJoinProducts)
                End Try

                'CREATE CODE
            ElseIf (CustomerQuoteManager.EditStatus = False) And (CustomerQuoteManager.CreateStatus = True) Then 'create quote
                Try
                    Dim ret As Integer = MsgBox("Add new Customer Quote too the database?", vbYesNo)
                    If ret = 6 Then 'if user clicks yes to update'

                        If (QuoteAcceptanceStatusComboBox.SelectedItem = "N") Then 'if date is empTy then make it 1111/11/11
                            DateAcceptedTextBox.Text = "1111/11/11"
                        End If

                        'variables
                        Dim CustomerID As Integer = Integer.Parse(CustomerIDComboBox.Text)
                        Dim EmployeeID As Integer = Integer.Parse(EmployeeIDComboBox.Text)
                        Dim totalPrice As Decimal = 0.0
                        Dim dateIssued As Date = DateIssuedDateTimePicker.Value.ToShortDateString
                        Dim acceptanceStatus As String = QuoteAcceptanceStatusComboBox.Text
                        Dim acceptanceDate As Date = DateAcceptedTextBox.Text


                        Customer_QuoteTableAdapter.Insert(CustomerQuoteManager.NewCustomerQuoteReferenceID, CustomerID, EmployeeID, totalPrice, dateIssued, acceptanceStatus, acceptanceDate)
                        Me.Customer_QuoteTableAdapter.Fill(Me.Group16DataSet.Customer_Quote)
                        Me.CustomerQuoteBindingSource.MoveLast()

                        If (QuoteAcceptanceStatusComboBox.SelectedItem = "N") Then 'if date is 1111/11/1111 then make it null
                            DateAcceptedTextBox.Text = ""

                            CustomerQuoteBindingSource.EndEdit()
                            Customer_QuoteTableAdapter.UpdateDateAcceptedNULLQuery(CustomerQuoteID)
                            MsgBox("Customer Quote " & CustomerQuoteIDTextBox.Text & " was successfully added to the database!")
                        End If

                        QuoteDetailsGroupBox.Enabled = False

                        CustomerQuoteIDTextBox.Enabled = True
                        TotalPriceTextBox.Enabled = True
                        EditLineItemsButton.Enabled = True
                        NotificationLabel.Visible = False
                        ActiveQuoteStatus = True
                        CustLineItemJoinProductDataGridView.Visible = True
                        CustLineItemJoinProductDataGridView.Enabled = True

                    End If
                Catch ex As SqlException
                    MsgBox("Cannot save Customer Quote to database!", vbExclamation, "Network Error!")
                Catch ex As NoNullAllowedException
                    MsgBox("Incorrect input!Follow correct format and fill all required fields!", vbExclamation, "Incorrect Input")
                Catch ex As Exception
                    MsgBox("Oops something went wrong!", vbExclamation, "Error!")
                Finally
                    SupplierQuoteManager.SupplierQuoteJoinSupplierTableAdapter.Fill(SupplierQuoteManager.Group16DataSet.SupplierQuoteJoinSupplier)
                    SupplierQuoteManager.SuppLineItemJoinProductTableAdapter.Fill(SupplierQuoteManager.Group16DataSet.SuppLineItemJoinProduct)
                End Try
            End If

        Catch exe As SqlException
            MsgBox("Reconnect to network!", vbExclamation, "Reconnect to Network!")
        Catch exe As Exception
            MsgBox("Please make sure that all required fields are filled!", vbExclamation, "Error!")
        End Try
    End Sub

    Private Sub DeleteQuoteButton_Click(sender As Object, e As EventArgs) Handles DeleteQuoteButton.Click

        If (CustomerQuoteManager.EditStatus = True) And (CustomerQuoteManager.CreateStatus = False) Then 'edit quote

            Dim SQLcon As SqlConnection = New SqlConnection()
            Dim SQLcomm As SqlCommand

            SQLcon.ConnectionString = "Server=146.230.177.46\ist3;Initial Catalog=group16;User ID=group16; Password=78fgg"

            Dim READER As SqlDataReader
            Try
                Dim ret As Integer = MsgBox("Are you sure you want to delete this Customer Quote(" & CustomerQuoteIDTextBox.Text & ") permanently?", vbYesNo, "Confirm Delete?")

                If ret = 6 Then 'if user clicks yes to delete'

                    SQLcon.Open()
                    Dim Query As String
                    Query = "DELETE FROM Customer_Quote WHERE Cust_Quote_Reference_ID = '" & CustomerQuoteIDTextBox.Text & "'"
                    SQLcomm = New SqlCommand(Query, SQLcon)
                    READER = SQLcomm.ExecuteReader
                    SQLcon.Close()
                    MsgBox("Delete was successful!")

                    CustomerQuoteManager.Show()
                    Me.Close()
                End If
            Catch ex As SqlException
                MsgBox("Cannot delete!", vbExclamation, "Cannot delete!")
            Catch ex As NoNullAllowedException
                MsgBox("Incorrect input!Follow correct format!", vbExclamation, "Incorrect Input!")
            Catch ex As Exception
                MsgBox("Oops something went wrong!", vbExclamation, "Error!")
            Finally
                SQLcon.Dispose()
                CustomerQuoteManager.CustomerQuoteJoinCustomerTableAdapter.Fill(CustomerQuoteManager.Group16DataSet.CustomerQuoteJoinCustomer)
                CustomerQuoteManager.CustLineItemJoinProductsTableAdapter.Fill(CustomerQuoteManager.Group16DataSet.CustLineItemJoinProducts)
            End Try
        End If
    End Sub

    Private Sub EditLineItemsButton_Click(sender As Object, e As EventArgs) Handles EditLineItemsButton.Click
        Try
            CustomerQuoteItemManager.Show()
            CustomerQuoteItemManager.CustLineItemJoinProductsBindingSource.Filter = "Cust_Quote_Reference_ID = '" & CustomerQuoteID & "'"
            CustomerQuoteItemManager.Text = "Customer Quote Line Item Manager: Reference ID: " & CustomerQuoteID
            CustomerQuoteItemManager.CustomerQuoteReferenceID = CustomerQuoteID
        Catch ex As SqlException
            MsgBox("Oops... Page failed too load correctly!", vbExclamation, "Error!")
        Catch ex As NoNullAllowedException
            MsgBox("Incorrect input!Follow correct format!", vbExclamation, "Incorrect Input!")
        Catch ex As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
        End Try
    End Sub

    Public Function getTotal() As Decimal 'gets total of quote
        Dim sum As Decimal = Customer_Quote_Line_ItemTableAdapter.TotalCustQuotePriceQuery(CustomerQuoteID)
        Try
            TotalPriceTextBox.Text = Customer_Quote_Line_ItemTableAdapter.TotalCustQuotePriceQuery(CustomerQuoteID)
        Catch ex As SqlException
            MsgBox("Error, cannot connect to network!", vbExclamation, "Error!")
        Catch ex As NoNullAllowedException
            MsgBox("Cannot compute Total Price!", vbExclamation, "Incorrect Input!")
        Catch ex As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
        End Try

        Return sum
    End Function

    Private Sub EmployeeInfoButton_Click(sender As Object, e As EventArgs) Handles EmployeeInfoButton.Click


        Try
            SelectEmployeePopUp.Show()

        Catch ex As SqlException
            MsgBox("Error, cannot connect to network!", vbExclamation, "Error!")
        Catch ex As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
        End Try


    End Sub

    Private Sub CustomerInfoButton_MouseHover(sender As Object, e As EventArgs) Handles CustomerInfoButton.MouseHover
        CreateOrEditCustomerQuoteTip.SetToolTip(CustomerInfoButton, "Click to view information on customer")
    End Sub

    Private Sub CreateCustomerButton_MouseHover(sender As Object, e As EventArgs) Handles CreateCustomerButton.MouseHover
        CreateOrEditCustomerQuoteTip.SetToolTip(CreateCustomerButton, "Click to create customer quote")
    End Sub

    Private Sub EmployeeInfoButton_MouseHover(sender As Object, e As EventArgs) Handles EmployeeInfoButton.MouseHover
        CreateOrEditCustomerQuoteTip.SetToolTip(EmployeeInfoButton, "Click to view information on employee")
    End Sub

    Private Sub UpdateQuoteButton_MouseHover(sender As Object, e As EventArgs) Handles UpdateQuoteButton.MouseHover
        CreateOrEditCustomerQuoteTip.SetToolTip(UpdateQuoteButton, "Click to update customer quote")
    End Sub

    Private Sub DeleteQuoteButton_MouseHover(sender As Object, e As EventArgs) Handles DeleteQuoteButton.MouseHover
        CreateOrEditCustomerQuoteTip.SetToolTip(DeleteQuoteButton, "Click to delete customer quote")
    End Sub

    Private Sub EditLineItemsButton_MouseHover(sender As Object, e As EventArgs) Handles EditLineItemsButton.MouseHover
        CreateOrEditCustomerQuoteTip.SetToolTip(EditLineItemsButton, "Click to edit items in a line")
    End Sub

    Private Sub BackButton_MouseHover(sender As Object, e As EventArgs) Handles BackButton.MouseHover
        CreateOrEditCustomerQuoteTip.SetToolTip(BackButton, "Click to leave form")
    End Sub

    Private Sub CustomerInfoButton_Click(sender As Object, e As EventArgs) Handles CustomerInfoButton.Click

        Try
            'CustomerInfoPopUp.Show()
            'CustomerInfoPopUp.CustomerBindingSource.Filter = "Customer_ID = '" & CustomerIDComboBox.Text & "'"
            'CustomerInfoPopUp.Text = "Employee Information: " & CustomerIDComboBox.Text

            SelectCustomerPopUp.Show()

        Catch ex As SqlException
            MsgBox("Error, cannot connect to network!", vbExclamation, "Error!")
        Catch ex As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
        End Try

    End Sub

    Public Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        Try
            CustLineItemJoinProductsTableAdapter.Fill(Me.Group16DataSet.CustLineItemJoinProducts)
            CustLineItemJoinProductsBindingSource.Filter = "Cust_Quote_Reference_ID = '" & CustomerQuoteIDTextBox.Text & "'"
            TotalPriceTextBox.Text = Me.getTotal()
            Customer_QuoteTableAdapter.TotalPriceUpdateQuery(getTotal, Integer.Parse(CustomerQuoteIDTextBox.Text))
        Catch ex As SqlException
            MsgBox("Error, cannot connect to network!", vbExclamation, "Error!")
        Catch ex As NoNullAllowedException
            MsgBox("Cannot compute Total Price!", vbExclamation, "Incorrect Input!")
        Catch ex As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
        End Try
    End Sub

    Private Sub HelpBtn_Click(sender As Object, e As EventArgs) Handles HelpBtn.Click
        Dim helpFilePath = IO.Path.Combine(My.Application.Info.DirectoryPath, "M.I.S.chm")
        Help.ShowHelp(Me, helpFilePath)
    End Sub
End Class
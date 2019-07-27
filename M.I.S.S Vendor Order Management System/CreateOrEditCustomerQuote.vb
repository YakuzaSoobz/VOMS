Imports System.Data.SqlClient

Public Class CreateOrEditCustomerQuote

    Public CreateCustomerStatus As Boolean = False
    Public CustomerQuoteID As Integer
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
                CustomerQuoteID = Integer.Parse(CustomerQuoteIDTextBox.Text)

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
                CustomerQuoteID = Integer.Parse(CustomerQuoteIDTextBox.Text)

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
        Dim answer As MsgBoxResult = MsgBox("Are you sure you want to leave this page? All unsaved changes will be lost", MsgBoxStyle.YesNo)
        If answer = MsgBoxResult.Yes Then
            CustomerQuoteManager.Show()
            Call CustomerQuoteManager.RefreshButton_Click(sender, e)
            Me.Close()
        End If
    End Sub

    Public Sub UpdateQuoteButton_Click(sender As Object, e As EventArgs) Handles UpdateQuoteButton.Click
        Try
            If (CustomerQuoteManager.EditStatus = True) And (CustomerQuoteManager.CreateStatus = False) Then 'edit quote

                Try
                    getTotal()
                    Dim ret As Integer = MsgBox("Confirm changes to Customer Quote " & CustomerQuoteIDTextBox.Text & " ?", vbYesNo)
                    If ret = 6 Then 'if user clicks yes to update'

                        If (DateAcceptedTextBox.Text = "") Then 'if date is empTy then make it 1111/11/11
                            DateAcceptedTextBox.Text = "1111/11/11"
                        End If

                        CustomerQuoteBindingSource.EndEdit()
                        Customer_QuoteTableAdapter.Update(Me.Group16DataSet.Customer_Quote)

                        If (DateAcceptedTextBox.Text = "1111/11/11") Then 'if date is 1111/11/1111 then make it null
                            DateAcceptedTextBox.Text = ""
                            CustomerQuoteBindingSource.EndEdit()
                            Customer_QuoteTableAdapter.UpdateDateAcceptedNULLQuery(Integer.Parse(CustomerQuoteIDTextBox.Text))
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

                        EmployeeTableAdapter.Fill(Me.Group16DataSet.Employee)
                        CustomerTableAdapter.Fill(Me.Group16DataSet.Customer)

                        If (DateAcceptedTextBox.Text = "") Then 'if date is empTy then make it 1111/11/11
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

                        If (DateAcceptedTextBox.Text = "1111/11/11") Then 'if date is 1111/11/1111 then make it null
                            DateAcceptedTextBox.Text = ""

                            CustomerQuoteBindingSource.EndEdit()
                            Customer_QuoteTableAdapter.UpdateDateAcceptedNULLQuery(Integer.Parse(CustomerQuoteIDTextBox.Text))
                            MsgBox("Customer Quote " & CustomerQuoteIDTextBox.Text & " was successfully added to the database!")
                        End If

                        QuoteDetailsGroupBox.Enabled = False

                        CustomerQuoteIDTextBox.Enabled = True
                        TotalPriceTextBox.Enabled = True
                        EditLineItemsButton.Enabled = True
                        NotificationLabel.Visible = False
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
            CustomerQuoteLineItemManager.Show()
            CustomerQuoteLineItemManager.CustomerQuoteLineItemBindingSource.Filter = "Cust_Quote_Reference_ID = '" & CustomerQuoteIDTextBox.Text & "'"
            CustomerQuoteLineItemManager.Text = "Customer Quote Line Item Manager: Reference ID: " & CustomerQuoteIDTextBox.Text
            CustomerQuoteLineItemManager.CustomerQuoteReferenceID = Integer.Parse(CustomerQuoteIDTextBox.Text)
        Catch ex As SqlException
            MsgBox("Oops... Page failed too load correctly!", vbExclamation, "Error!")
        Catch ex As NoNullAllowedException
            MsgBox("Incorrect input!Follow correct format!", vbExclamation, "Incorrect Input!")
        Catch ex As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
        End Try
    End Sub

    Public Function getTotal() As Decimal 'gets total of quote
        Dim sum As Decimal = 0
        Try
            For i As Integer = 0 To Me.Group16DataSet.CustLineItemJoinProducts.Rows.Count - 1

                If ((Me.Group16DataSet.CustLineItemJoinProducts.Rows(i)("Cust_Quote_Reference_ID")) = CustomerQuoteManager.CustomerQuoteReferenceID) Then

                    sum = sum + Decimal.Parse((Me.Group16DataSet.CustLineItemJoinProducts.Rows(i)("Cust_Line_Item_Sale_incl_VAT")) * (Me.Group16DataSet.CustLineItemJoinProducts.Rows(i)("Cust_Line_Item_Quantity")))

                End If
            Next

            TotalPriceTextBox.Text = sum
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
            EmployeeInfoPopUp.Show()
            EmployeeInfoPopUp.EmployeeBindingSource.Filter = "Employee_ID = '" & EmployeeIDComboBox.Text & "'"
            EmployeeInfoPopUp.Text = "Employee Information: " & EmployeeIDComboBox.Text

        Catch ex As SqlException
            MsgBox("Error, cannot connect to network!", vbExclamation, "Error!")
        Catch ex As NoNullAllowedException
            MsgBox("Cannot compute Total Price!", vbExclamation, "Incorrect Input!")
        Catch ex As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
        End Try


    End Sub

    Private Sub CaclulateTotalButton_Click(sender As Object, e As EventArgs) Handles CaclulateTotalButton.Click

        Try
            Me.getTotal()
            Customer_QuoteTableAdapter.TotalPriceUpdateQuery(getTotal, Integer.Parse(CustomerQuoteIDTextBox.Text))
        Catch ex As SqlException
            MsgBox("Error, cannot connect to network!", vbExclamation, "Error!")
        Catch ex As NoNullAllowedException
            MsgBox("Cannot compute Total Price!", vbExclamation, "Incorrect Input!")
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

    Private Sub CaclulateTotalButton_MouseHover(sender As Object, e As EventArgs) Handles CaclulateTotalButton.MouseHover
        CreateOrEditCustomerQuoteTip.SetToolTip(CaclulateTotalButton, "Click to calculate total amount")
    End Sub

    Private Sub EditLineItemsButton_MouseHover(sender As Object, e As EventArgs) Handles EditLineItemsButton.MouseHover
        CreateOrEditCustomerQuoteTip.SetToolTip(EditLineItemsButton, "Click to edit items in a line")
    End Sub

    Private Sub BackButton_MouseHover(sender As Object, e As EventArgs) Handles BackButton.MouseHover
        CreateOrEditCustomerQuoteTip.SetToolTip(BackButton, "Click to leave form")
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

    Private Sub CustomerInfoButton_Click(sender As Object, e As EventArgs) Handles CustomerInfoButton.Click
        CustomerInfoPopUp.Show()
    End Sub
End Class
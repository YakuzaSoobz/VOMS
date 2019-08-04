Imports System.Data.SqlClient

Public Class CreateOrEditSupplierQuote

    Public CreateSupplierStatus As Boolean = False

    Private Sub CreateSupplierButton_Click(sender As Object, e As EventArgs)
        SupplierManager.Show()
        Me.Hide()
    End Sub

    Private Sub SupplierInfoButton_Click(sender As Object, e As EventArgs)
        SupplierInfoPopUp.Show()
        Me.Hide()
    End Sub

    Private Sub CreateOrEditSupplierQuote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If (SupplierQuoteManager.EditStatus = True) And (SupplierQuoteManager.CreateStatus = False) Then 'edit quote
                Me.Supplier_QuoteTableAdapter.Fill(Me.Group16DataSet.Supplier_Quote)
                Me.SupplierTableAdapter.Fill(Me.Group16DataSet.Supplier)
                Me.SuppLineItemJoinProductTableAdapter.Fill(Me.Group16DataSet.SuppLineItemJoinProduct)

                EditLineItemsButton.Text = "EDIT ITEMS"
                UpdateSupplierQuoteButton.Text = "UPDATE QUOTE"
                Me.Text = "Edit Supplier Quote"
                NotificationLabel.Visible = False

            ElseIf (SupplierQuoteManager.EditStatus = False) And (SupplierQuoteManager.CreateStatus = True) Then 'create quote


                Me.SupplierTableAdapter.Fill(Me.Group16DataSet.Supplier)
                QuoteAcceptanceStatusComboBox.SelectedItem = "N"
                MsgBox("Enter new QUOTE DETAILS and ADD ITEMS to the quote!Click SAVE when you are done.", vbInformation)
                Me.Text = "Create Supplier Quote"
                UpdateSupplierQuoteButton.Text = "SAVE QUOTE"
                EditLineItemsButton.Text = "ADD ITEMS"
                DeleteSupplierQuoteButton.Enabled = False
                DeleteSupplierQuoteButton.Visible = False
                SuppLineItemJoinProductDataGridView.Visible = False
                EditLineItemsButton.Enabled = False
                TotalPriceTextBox.Text = 0

            End If
        Catch exe As SqlException
            MsgBox("Reconnect to network!", vbExclamation, "Reconnect to Network!")
        Catch exe As Exception
            MsgBox("Oops... Page failed too load correctly!", vbExclamation, "Error!")
        End Try

    End Sub

    Private Sub EditLineItemsButton_Click(sender As Object, e As EventArgs) Handles EditLineItemsButton.Click

        Try
            SupplierQuoteLineItemManager.Show()
            SupplierQuoteLineItemManager.SupplierQuoteLineItemBindingSource.Filter = "Supp_Quote_Reference_ID = '" & SupplierQuoteIDTextBox.Text & "'"
            SupplierQuoteLineItemManager.Text = "Supplier Quote Line Item Manager: Reference ID: " & SupplierQuoteIDTextBox.Text
            SupplierQuoteLineItemManager.SupplierQuoteReferenceID = Integer.Parse(SupplierQuoteIDTextBox.Text)
        Catch ex As SqlException
            MsgBox("Oops... Page failed to load correctly!", vbExclamation, "Error!")
        Catch ex As NoNullAllowedException
            MsgBox("Incorrect input! Follow correct format!", vbExclamation, "Incorrect Input!")
        Catch ex As Exception
            MsgBox("Oops, something went wrong!", vbExclamation, "Error!")
        End Try
    End Sub

    Private Sub UpdateSupplierQuoteButton_Click(sender As Object, e As EventArgs) Handles UpdateSupplierQuoteButton.Click
        Try
            If (SupplierQuoteManager.EditStatus = True) And (SupplierQuoteManager.CreateStatus = False) Then 'edit quote

                Try
                    Me.getTotal()
                    Dim ret As Integer = MsgBox("Confirm changes to Supplier Quote " & SupplierQuoteIDTextBox.Text & " ?", vbYesNo)
                    If ret = 6 Then 'if user clicks yes to update'

                        If (DateAcceptedTextBox.Text = "") Then 'if date is empTy then make it 1111/11/11
                            DateAcceptedTextBox.Text = "1111/11/11"
                        End If

                        SupplierQuoteBindingSource.EndEdit()
                        Supplier_QuoteTableAdapter.Update(Me.Group16DataSet.Supplier_Quote)

                        If (DateAcceptedTextBox.Text = "1111/11/11") Then 'if date is 1111/11/1111 then make it null
                            DateAcceptedTextBox.Text = ""
                            SupplierQuoteBindingSource.EndEdit()
                            Supplier_QuoteTableAdapter.UpdateDateAcceptedNullQuery(Integer.Parse(SupplierQuoteIDTextBox.Text))
                            MsgBox("Update successful!")
                        End If
                    End If
                Catch ex As SqlException
                    MsgBox("Cannot Update!", vbExclamation, "Cannot Update!")
                Catch ex As NoNullAllowedException
                    MsgBox("Incorrect input! Follow correct format!", vbExclamation, "Incorrect Input")
                Catch ex As Exception
                    MsgBox("Oops, something went wrong!", vbExclamation, "Error!")
                Finally
                    SupplierQuoteManager.SupplierQuoteJoinSupplierTableAdapter.Fill(SupplierQuoteManager.Group16DataSet.SupplierQuoteJoinSupplier)
                    SupplierQuoteManager.SuppLineItemJoinProductTableAdapter.Fill(SupplierQuoteManager.Group16DataSet.SuppLineItemJoinProduct)
                End Try

                'CREATE CODE
            ElseIf (SupplierQuoteManager.EditStatus = False) And (SupplierQuoteManager.CreateStatus = True) Then 'create quote
                Try
                    Dim ret As Integer = MsgBox("Add new Supplier Quote to database?", vbYesNo)
                    If ret = 6 Then 'if user clicks yes to update'


                        If (DateAcceptedTextBox.Text = "") Then 'if date is empTy then make it 1111/11/11
                            DateAcceptedTextBox.Text = "1111/11/11"
                        End If

                        'variables
                        Dim supplierID As Integer = Integer.Parse(SupplierIDComboBox.Text)
                        Dim totalPrice As Decimal = 0.0
                        Dim dateRecieved As Date = DateRecievedDateTimePicker.Value.ToShortDateString
                        Dim acceptanceStatus As String = QuoteAcceptanceStatusComboBox.Text
                        Dim acceptanceDate As Date = DateAcceptedTextBox.Text

                        Supplier_QuoteTableAdapter.Insert(supplierID, totalPrice, dateRecieved, acceptanceStatus, acceptanceDate)


                        Me.Supplier_QuoteTableAdapter.Fill(Me.Group16DataSet.Supplier_Quote)
                        Me.SupplierQuoteBindingSource.MoveLast()

                        If (DateAcceptedTextBox.Text = "1111/11/11") Then 'if date is 1111/11/1111 then make it null
                            DateAcceptedTextBox.Text = ""

                            SupplierQuoteBindingSource.EndEdit()
                            Supplier_QuoteTableAdapter.UpdateDateAcceptedNullQuery(Integer.Parse(SupplierQuoteIDTextBox.Text))
                            MsgBox("Supplier Quote " & SupplierQuoteIDTextBox.Text & " was successfully added to database!")
                        End If


                        QuoteDetailsGroupBox.Enabled = False
                        EditLineItemsButton.Enabled = True
                        NotificationLabel.Visible = False
                        SuppLineItemJoinProductDataGridView.Visible = True
                        SuppLineItemJoinProductDataGridView.Enabled = True

                    End If
                Catch ex As SqlException
                    MsgBox("Cannot save Supplier Quote to database!", vbExclamation, "Cannot Update!")
                Catch ex As NoNullAllowedException
                    MsgBox("Incorrect input! Follow correct format and fill all required fields!", vbExclamation, "Incorrect Input")
                Catch ex As Exception
                    MsgBox("Oops, something went wrong!", vbExclamation, "Error!")
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

    Private Sub QuoteAcceptanceStatusComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles QuoteAcceptanceStatusComboBox.SelectedIndexChanged

        If ((QuoteAcceptanceStatusComboBox.SelectedItem = "Y") Or (QuoteAcceptanceStatusComboBox.SelectedItem = "y")) Then

            DateAcceptedTextBox.Text = Date.Today

        ElseIf ((QuoteAcceptanceStatusComboBox.SelectedItem = "N") Or (QuoteAcceptanceStatusComboBox.SelectedItem = "n")) Then

            DateAcceptedTextBox.Text = ""

        End If

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click

        Dim answer As MsgBoxResult = MsgBox("Are you sure you want to leave this page? All unsaved changes will be lost.", MsgBoxStyle.YesNo)
        If answer = MsgBoxResult.Yes Then
            SupplierQuoteManager.Show()
            Me.Close()
        End If
    End Sub

    Private Sub DeleteSupplierQuoteButton_Click(sender As Object, e As EventArgs) Handles DeleteSupplierQuoteButton.Click

        If (SupplierQuoteManager.EditStatus = True) And (SupplierQuoteManager.CreateStatus = False) Then 'edit quote

            Dim SQLcon As SqlConnection = New SqlConnection()
            Dim SQLcomm As SqlCommand

            SQLcon.ConnectionString = "Server=146.230.177.46\ist3;Initial Catalog=group16;User ID=group16; Password=78fgg"

            Dim READER As SqlDataReader
            Try
                Dim ret As Integer = MsgBox("Are you sure you want to delete this Supplier Quote(" & SupplierQuoteIDTextBox.Text & ") permanently?", vbYesNo, "Confirm Delete?")

                If ret = 6 Then 'if user clicks yes to delete'

                    SQLcon.Open()
                    Dim Query As String
                    Query = "DELETE FROM Supplier_Quote WHERE Supp_Quote_Reference_ID = '" & SupplierQuoteIDTextBox.Text & "'"
                    SQLcomm = New SqlCommand(Query, SQLcon)
                    READER = SQLcomm.ExecuteReader
                    SQLcon.Close()
                    MsgBox("Delete successful!")

                    SupplierQuoteManager.Show()
                    Me.Close()
                End If
            Catch ex As SqlException
                MsgBox("Cannot delete!", vbExclamation, "Cannot Delete!")
            Catch ex As NoNullAllowedException
                MsgBox("Incorrect input! Follow correct format!", vbExclamation, "Incorrect Input!")
            Catch ex As Exception
                MsgBox("Oops, something went wrong!", vbExclamation, "Error!")
            Finally
                SQLcon.Dispose()
                SupplierQuoteManager.SupplierQuoteJoinSupplierTableAdapter.Fill(SupplierQuoteManager.Group16DataSet.SupplierQuoteJoinSupplier)
                SupplierQuoteManager.SuppLineItemJoinProductTableAdapter.Fill(SupplierQuoteManager.Group16DataSet.SuppLineItemJoinProduct)
            End Try
        End If
    End Sub

    Private Sub SupplierInfoButton_Click_1(sender As Object, e As EventArgs) Handles SupplierInfoButton.Click
        SupplierInfoPopUp.Show()
        SupplierInfoPopUp.SupplierBindingSource.Filter = "Supplier_ID = '" & SupplierIDComboBox.Text & "'"
        SupplierInfoPopUp.Text = "Supplier Information: " & SupplierIDComboBox.SelectedText
    End Sub

    Private Sub CreateSupplierButton_Click_1(sender As Object, e As EventArgs) Handles CreateSupplierButton.Click
        CreateSupplierStatus = True
        SupplierManager.Show()
    End Sub

    Public Function getTotal() As Decimal 'gets total of quote
        Dim sum As Decimal = 0
        Try
            For i As Integer = 0 To Me.Group16DataSet.SuppLineItemJoinProduct.Rows.Count - 1

                If ((Me.Group16DataSet.SuppLineItemJoinProduct.Rows(i)("Supp_Quote_Reference_ID")) = SupplierQuoteManager.SupplierQuoteReferenceID) Then

                    sum = sum + Decimal.Parse((Me.Group16DataSet.SuppLineItemJoinProduct.Rows(i)("Supp_Line_Item_Cost_Price")) * (Me.Group16DataSet.SuppLineItemJoinProduct.Rows(i)("Supp_Line_Item_Quantity")))

                End If
            Next

            TotalPriceTextBox.Text = sum
        Catch ex As SqlException
            MsgBox("Error, cannot connect to network!", vbExclamation, "Error!")
        Catch ex As NoNullAllowedException
            MsgBox("Cannot compute Total Price!", vbExclamation, "Incorrect Input!")
        Catch ex As Exception
            MsgBox("Oops, something went wrong!", vbExclamation, "Error!")
        End Try

        Return sum
    End Function

    Private Sub SupplierInfoButton_MouseHover(sender As Object, e As EventArgs) Handles SupplierInfoButton.MouseHover
        CreateOrEditSupplierQuoteTip.SetToolTip(SupplierInfoButton, "Click to view information on supplier")
    End Sub

    Private Sub CreateSupplierButton_MouseHover(sender As Object, e As EventArgs) Handles CreateSupplierButton.MouseHover
        CreateOrEditSupplierQuoteTip.SetToolTip(CreateSupplierButton, "Click to create supplier quote")
    End Sub

    Private Sub UpdateSupplierQuoteButton_MouseHover(sender As Object, e As EventArgs) Handles UpdateSupplierQuoteButton.MouseHover
        CreateOrEditSupplierQuoteTip.SetToolTip(UpdateSupplierQuoteButton, "Click to update supplier quote")
    End Sub

    Private Sub DeleteSupplierQuoteButton_MouseHover(sender As Object, e As EventArgs) Handles DeleteSupplierQuoteButton.MouseHover
        CreateOrEditSupplierQuoteTip.SetToolTip(DeleteSupplierQuoteButton, "Click to delete supplier quote")
    End Sub

    Private Sub HelpBtn_MouseHover(sender As Object, e As EventArgs) Handles HelpBtn.MouseHover
        CreateOrEditSupplierQuoteTip.SetToolTip(HelpBtn, "Click to view additional help")
    End Sub

    Private Sub EditLineItemsButton_MouseHover(sender As Object, e As EventArgs) Handles EditLineItemsButton.MouseHover
        CreateOrEditSupplierQuoteTip.SetToolTip(EditLineItemsButton, "Click to edit line items")
    End Sub

    Private Sub BackButton_MouseHover(sender As Object, e As EventArgs) Handles BackButton.MouseHover
        CreateOrEditSupplierQuoteTip.SetToolTip(BackButton, "Click to leave form")
    End Sub

    Public Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click

        Try
            SuppLineItemJoinProductTableAdapter.Fill(Me.Group16DataSet.SuppLineItemJoinProduct)
            SuppLineItemJoinProductBindingSource.Filter = "Supp_Quote_Reference_ID = '" & SupplierQuoteIDTextBox.Text & "'"
            TotalPriceTextBox.Text = Me.getTotal()
            Supplier_QuoteTableAdapter.TotalPriceUpdateQuery(getTotal, Integer.Parse(SupplierQuoteIDTextBox.Text))
        Catch ex As SqlException
            MsgBox("Error, cannot connect to network!", vbExclamation, "Error!")
        Catch ex As NoNullAllowedException
            MsgBox("Cannot compute Total Price!", vbExclamation, "Incorrect Input!")
        Catch ex As Exception
            MsgBox("Oops, something went wrong!", vbExclamation, "Error!")
        End Try
    End Sub

    Private Sub CaclulateTotalButton_Click(sender As Object, e As EventArgs) Handles CaclulateTotalButton.Click
        Try
            Me.getTotal()
            Supplier_QuoteTableAdapter.TotalPriceUpdateQuery(getTotal, Integer.Parse(SupplierQuoteIDTextBox.Text))
        Catch ex As SqlException
            MsgBox("Error, cannot connect to network!", vbExclamation, "Error!")
        Catch ex As NoNullAllowedException
            MsgBox("Cannot compute Total Price!", vbExclamation, "Incorrect Input!")
        Catch ex As Exception
            MsgBox("Oops, something went wrong!", vbExclamation, "Error!")
        End Try
    End Sub
End Class
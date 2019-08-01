Imports System.Data.SqlClient

Public Class LineItemDetailsPopUp

    Dim ProductID As Integer
    Dim SupplierID As Integer
    Dim CostPrice As Decimal
    Dim MarkupPercentage As Decimal
    Dim DiscountPercentage As Decimal = 0
    Dim SaleInclVat As Decimal
    Dim SaleExclVat As Decimal
    Dim Quantity As Integer
    Dim VATPercentage As Decimal = 0.15
    Dim SetMarkupPercentage As Decimal = 20

    Private Sub LineItemDetailsPopUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        If (CustomerQuoteLineItemManager.AddStatus = True) And (CustomerQuoteLineItemManager.UpdateStatus = False) Then

            Try

                Me.SupplierTableAdapter.Fill(Me.Group16DataSet.Supplier)
                'Me.SuppQuoteJoinSuppLineItemTableAdapter.Fill(Me.Group16DataSet.SuppQuoteJoinSuppLineItem)
                ProductID = CustomerQuoteLineItemManager.ProductID
                MarkupComboBox.SelectedItem = "20"
                DiscountComboBox.Text = 0
                QuantityComboBox.SelectedItem = "1"

            Catch ex As SqlException
                MsgBox("Cannot load form!", vbExclamation, "Network Error!")
            Catch ex As EvaluateException
                MsgBox("Cannot be found", vbExclamation, "Incorrect Input!")
            Catch ex As Exception
                MsgBox("Oops something went wrong!", vbExclamation, "Error!")
            End Try
        End If
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Dim answer As MsgBoxResult = MsgBox("Are you sure you want to leave this page? All unsaved changes will be lost", MsgBoxStyle.YesNo)
        If answer = MsgBoxResult.Yes Then
            Try

                CustomerQuoteLineItemManager.Customer_Quote_Line_ItemTableAdapter.Fill(CustomerQuoteLineItemManager.Group16DataSet.Customer_Quote_Line_Item)
                CustomerQuoteLineItemManager.CustomerQuoteLineItemBindingSource.Filter = "Cust_Quote_Reference_ID = '" & CustomerQuoteLineItemManager.CustomerQuoteReferenceID & "'"
                Me.Close()

            Catch ex As SqlException
                MsgBox("Cannot load form!", vbExclamation, "Network Error!")
            Catch ex As EvaluateException
                MsgBox("Cannot be found", vbExclamation, "Incorrect Input!")
            Catch ex As Exception
                MsgBox("Oops something went wrong!", vbExclamation, "Error!")
            End Try

        End If
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Try

            If Not (IsNumeric(QuantityComboBox.Text)) Then
                MsgBox("Only positive integers can be entered into the quanity field", vbOK)

            ElseIf ((Integer.Parse(QuantityComboBox.Text) < 1) Or (Integer.Parse(QuantityComboBox.Text) > 1000)) Then

                MsgBox("Enter an integer between 1 and 1000 for quantity!", vbOK)
                QuantityComboBox.ResetText()

            ElseIf Not ((Decimal.Parse(QuantityComboBox.Text)) = (Int(Decimal.Parse(QuantityComboBox.Text)))) Then
                MsgBox("Only positive integers can be entered into the quanity field", vbOK)
                QuantityComboBox.ResetText()

            ElseIf (QuantityComboBox.Text = Nothing) Then
                MsgBox("The quanity field is blank!", vbOK)

            Else

                Try
                    Dim ret As Integer = MsgBox("Save new Customer Line Item to Customer Quote " & CustomerQuoteLineItemManager.CustomerQuoteReferenceID & " ?", vbYesNo)

                    If ret = 6 Then 'if user clicks yes to add item'

                        SupplierID = Integer.Parse(SupplierIDTextBox.Text)

                        CostPrice = Decimal.Parse(CostPriceTextBox.Text)
                        MarkupPercentage = Decimal.Parse(MarkupComboBox.Text)
                        DiscountPercentage = Decimal.Parse(DiscountComboBox.Text)
                        Quantity = Integer.Parse(QuantityComboBox.Text)

                        Dim MarkupAmount As Decimal = (MarkupPercentage / 100) * CostPrice
                        Dim DiscountAmount As Decimal = (CostPrice + MarkupAmount) * (DiscountPercentage / 100)
                        SaleExclVat = ((CostPrice + MarkupAmount) - (DiscountAmount))
                        SaleInclVat = SaleExclVat + (SaleExclVat * VATPercentage)

                        SaleExclVATTextBox.Text = SaleExclVat
                        SaleInclVATTextBox.Text = SaleInclVat

                        CustomerQuoteLineItemManager.Customer_Quote_Line_ItemTableAdapter.Insert(ProductID, CustomerQuoteLineItemManager.CustomerQuoteReferenceID, SupplierID, CostPrice, SaleInclVat, SaleExclVat, MarkupPercentage, DiscountPercentage, Quantity)
                        CustomerQuoteLineItemManager.ProductTableAdapter.Fill(Me.Group16DataSet.Product)
                        CustomerQuoteLineItemManager.Customer_Quote_Line_ItemTableAdapter.Fill(Me.Group16DataSet.Customer_Quote_Line_Item)

                    End If

                Catch ex As SqlException
                    MsgBox("Cannot add item. Please use correct format to fill fields!", vbExclamation, "Incorrect Input!")
                Catch ex As EvaluateException
                    MsgBox("Cannot add item. Please use correct format to fill fields", vbExclamation, "Incorrect Input!")
                Catch ex As FormatException
                    MsgBox("Cannot add item. Please use correct format to fill fields", vbExclamation, "Incorrect Input!")
                End Try

            End If
        Catch ex As FormatException
            MsgBox("Cannot add item. Please use correct format to fill fields!", vbExclamation, "Incorrect Input!")
        End Try


    End Sub

    Private Sub SupplierDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles SupplierDataGridView.CellClick

        Try

            SupplierIDTextBox.Text = SupplierDataGridView.CurrentRow.Cells(0).Value.ToString
            SuppQuoteJoinSuppLineItemTableAdapter.Fill(Group16DataSet.SuppQuoteJoinSuppLineItem)
            SuppQuoteJoinSuppLineItemBindingSource.Filter = "Supplier_ID = '" & SupplierDataGridView.CurrentRow.Cells(0).Value.ToString & "' AND Product_ID = '" & ProductID & "'"

        Catch ex As SqlException
            MsgBox("Cannot load form!", vbExclamation, "Network Error!")
        Catch ex As EvaluateException
            MsgBox("Cannot be found", vbExclamation, "Incorrect Input!")
        Catch ex As Exception
            MsgBox("Select a SUPPLIER & then select a COST PRICE from Supplier Quotes, before proceeding to click SAVE!", vbInformation, "")
        End Try

    End Sub

    Private Sub SuppQuoteJoinSuppLineItemDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles SuppQuoteJoinSuppLineItemDataGridView.CellClick

        Try

            CostPriceTextBox.Text = SuppQuoteJoinSuppLineItemDataGridView.CurrentRow.Cells(2).Value.ToString

        Catch ex As SqlException
            MsgBox("Cannot load form!", vbExclamation, "Network Error!")
        Catch ex As EvaluateException
            MsgBox("Cannot be found", vbExclamation, "Incorrect Input!")
        Catch ex As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
        End Try

    End Sub

    Private Sub SaveButton_MouseHover(sender As Object, e As EventArgs) Handles SaveButton.MouseHover
        LineItemDetailsPopUpTip.SetToolTip(SaveButton, "Click to save line item to the quote")
    End Sub
End Class
Imports System.Data.SqlClient

Public Class SuppLineItemsDetailsPopUp

    Public ProductID As Integer
    Public CostPrice As Decimal
    Public Quantity As Integer

    Private Sub SuppLineItemsDetailsPopUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (SupplierQuoteLineItemManager.AddStatus = True) And (SupplierQuoteLineItemManager.UpdateStatus = False) Then

            Try

                ProductID = SupplierQuoteLineItemManager.ProductID
                ProductIDTextBox.Text = ProductID
                CostPriceTextBox.Text = "0"
                QuantityComboBox.Text = 1

            Catch ex As SqlException
                MsgBox("Cannot load form!", vbExclamation, "Network Error!")
            Catch ex As EvaluateException
                MsgBox("Cannot be found", vbExclamation, "Incorrect Input!")
            Catch ex As Exception
                MsgBox("Oops something went wrong!", vbExclamation, "Error!")
            End Try

        ElseIf (SupplierQuoteLineItemManager.AddStatus = False) And (SupplierQuoteLineItemManager.UpdateStatus = True) Then

            Try

                ProductID = SupplierQuoteLineItemManager.ProductID
                ProductIDTextBox.Text = ProductID
                CostPriceTextBox.Text = SupplierQuoteLineItemManager.CurrentCostPrice
                QuantityComboBox.Text = SupplierQuoteLineItemManager.CurrentQuantity


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
            QuantityComboBox.BackColor = Color.White
            CostPriceTextBox.BackColor = Color.White
            Dim result As Decimal = 0.0

            'QUANTITY------------------------------------------------------------------
            If String.IsNullOrWhiteSpace(QuantityComboBox.Text) Then 'quantity is blank
                MsgBox("The quanity field is blank!", vbOK)
                QuantityComboBox.BackColor = Color.MistyRose

            ElseIf Not (IsNumeric(QuantityComboBox.Text)) Then 'quantity is not numeric
                MsgBox("Only positive integers can be entered into the quanity field", vbOK, "Invalid entry")
                QuantityComboBox.ResetText()
                QuantityComboBox.BackColor = Color.MistyRose

            ElseIf ((Integer.Parse(QuantityComboBox.Text) < 1) Or (Integer.Parse(QuantityComboBox.Text) > 1000)) Then 'quantity is <1 and >1000
                MsgBox("Enter an integer between 1 and 1000 for quantity!", vbOK, "Invalid entry")
                QuantityComboBox.ResetText()
                QuantityComboBox.BackColor = Color.MistyRose

            ElseIf Not ((Decimal.Parse(QuantityComboBox.Text)) = (Int(Decimal.Parse(QuantityComboBox.Text)))) Then ' check if it's decimal
                MsgBox("Only positive integers can be entered into the quanity field and not decimals!", vbOK, "Invalid entry")
                QuantityComboBox.ResetText()
                QuantityComboBox.BackColor = Color.MistyRose

                'Price------------------------------------------------------------------
            ElseIf String.IsNullOrWhiteSpace(CostPriceTextBox.Text) Then 'quantity is blank
                MsgBox("The quanity field is blank!", vbOK)
                CostPriceTextBox.BackColor = Color.MistyRose

            ElseIf Not (Decimal.TryParse(CostPriceTextBox.Text, result)) Then 'quantity is not numeric
                MsgBox("Only positive decimals can be entered into the Cost Price field", vbOK, "Invalid entry")
                CostPriceTextBox.ResetText()
                CostPriceTextBox.BackColor = Color.MistyRose

            ElseIf ((Decimal.Parse(CostPriceTextBox.Text) < 1)) Then 'quantity is <1 and >1000
                MsgBox("Enter an positive price !", vbOK, "Invalid entry")
                CostPriceTextBox.ResetText()
                CostPriceTextBox.BackColor = Color.MistyRose

            Else 'if everything is valid

                If (SupplierQuoteLineItemManager.AddStatus = True) And (SupplierQuoteLineItemManager.UpdateStatus = False) Then
                    Try
                        Dim ret As Integer = MsgBox("Add new Supplier Line Item to Supplier Quote " & SupplierQuoteLineItemManager.SupplierQuoteReferenceID & " ?", vbYesNo)

                        If ret = 6 Then 'if user clicks yes to add item'

                            CostPrice = Convert.ToDecimal(CostPriceTextBox.Text)
                            Quantity = Convert.ToInt32(QuantityComboBox.Text)

                            SupplierQuoteLineItemManager.Quantity = Quantity
                            SupplierQuoteLineItemManager.CostPrice = CostPrice

                            SupplierQuoteLineItemManager.Add()
                            Me.Close()

                        End If

                    Catch ex As SqlException
                        MsgBox("Cannot add item. Please use correct format to fill fields!", vbExclamation, "Incorrect Input!")
                    Catch ex As EvaluateException
                        MsgBox("Cannot add item. Please use correct format to fill fields", vbExclamation, "Incorrect Input!")
                    Catch ex As FormatException
                        MsgBox("Cannot add item. Please use correct format to fill fields", vbExclamation, "Incorrect Input!")
                    End Try

                ElseIf (SupplierQuoteLineItemManager.AddStatus = False) And (SupplierQuoteLineItemManager.UpdateStatus = True) Then
                    Try
                        Dim ret As Integer = MsgBox("Save changes to product details?", vbYesNo)

                        If ret = 6 Then

                            CostPrice = Convert.ToDecimal(CostPriceTextBox.Text)
                            Quantity = Convert.ToInt32(QuantityComboBox.Text)

                            SupplierQuoteLineItemManager.Quantity = Quantity
                            SupplierQuoteLineItemManager.CostPrice = CostPrice

                            SupplierQuoteLineItemManager.UpdateItem()
                            Me.Close()

                        End If

                    Catch ex As SqlException
                        MsgBox("Cannot be found!", vbExclamation, "Incorrect Input!")
                    Catch ex As EvaluateException
                        MsgBox("Cannot be found", vbExclamation, "Incorrect Input!")
                    Catch ex As Exception
                        MsgBox("Oops something went wrong!", vbExclamation, "Error!")
                    End Try
                End If

            End If
        Catch ex As FormatException
            MsgBox("Cannot add item. Please use correct format to fill fields!", vbExclamation, "Incorrect Input!")
        End Try


    End Sub

    Private Sub QuantityComboBox_TextChanged(sender As Object, e As EventArgs) Handles QuantityComboBox.TextChanged
        Try
            If String.IsNullOrWhiteSpace(QuantityComboBox.Text) Then 'quantity is blank

                QuantityComboBox.BackColor = Color.MistyRose

            ElseIf Not (IsNumeric(QuantityComboBox.Text)) Then 'quantity is not numeric

                QuantityComboBox.BackColor = Color.MistyRose

            ElseIf ((Integer.Parse(QuantityComboBox.Text) < 1) Or (Integer.Parse(QuantityComboBox.Text) > 1000)) Then 'quantity is <1 and >1000

                QuantityComboBox.BackColor = Color.MistyRose

            ElseIf Not ((Decimal.Parse(QuantityComboBox.Text)) = (Int(Decimal.Parse(QuantityComboBox.Text)))) Then ' check if it's decimal

                QuantityComboBox.BackColor = Color.MistyRose
            Else
                QuantityComboBox.BackColor = Color.White
            End If

        Catch ex As SqlException
            MsgBox("Cannot add item. Please use correct format to fill fields!", vbExclamation, "Incorrect Input!")
        Catch ex As EvaluateException
            MsgBox("Cannot add item. Please use correct format to fill fields", vbExclamation, "Incorrect Input!")
        Catch ex As FormatException
            MsgBox("Cannot add item. Please use correct format to fill fields", vbExclamation, "Incorrect Input!")
        End Try
    End Sub

    Private Sub CostPriceTextBox_TextChanged(sender As Object, e As EventArgs) Handles CostPriceTextBox.TextChanged
        Try
            Dim result As Decimal = 0.0
            If String.IsNullOrWhiteSpace(CostPriceTextBox.Text) Then 'quantity is blank

                CostPriceTextBox.BackColor = Color.MistyRose

            ElseIf Not (Decimal.TryParse(CostPriceTextBox.Text, Result)) Then 'quantity is not numeric

                CostPriceTextBox.BackColor = Color.MistyRose

            ElseIf ((Decimal.Parse(CostPriceTextBox.Text) < 1)) Then 'quantity is <1 and >1000

                CostPriceTextBox.BackColor = Color.MistyRose
            Else
                CostPriceTextBox.BackColor = Color.White
            End If

        Catch ex As SqlException
            MsgBox("Cannot add item. Please use correct format to fill fields!", vbExclamation, "Incorrect Input!")
        Catch ex As EvaluateException
            MsgBox("Cannot add item. Please use correct format to fill fields", vbExclamation, "Incorrect Input!")
        Catch ex As FormatException
            MsgBox("Cannot add item. Please use correct format to fill fields", vbExclamation, "Incorrect Input!")
        End Try
    End Sub
End Class
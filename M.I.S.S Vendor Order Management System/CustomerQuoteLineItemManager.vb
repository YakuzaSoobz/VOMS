Imports System.Data.SqlClient

Public Class CustomerQuoteLineItemManager

    Public CustomerQuoteReferenceID As Integer
    Public ProductID As Integer
    Public SupplierID As Integer
    Public CostPrice As Decimal
    Public MarkupPercentage As Decimal
    Public DiscountPercentage As Decimal
    Public SaleInclVat As Decimal
    Public SaleExclVat As Decimal
    Public Quantity As Integer
    Public VATPercentage As Decimal = 0.15
    Public SetMarkupPercentage As Decimal = 20

    Public AddStatus = False
    Public UpdateStatus = False

    Private Sub CustomerQuoteLineItemManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Me.Customer_Quote_Line_ItemTableAdapter.Fill(Me.Group16DataSet.Customer_Quote_Line_Item)
            Me.ProductTableAdapter.Fill(Me.Group16DataSet.Product)
            Me.Customer_Quote_Line_ItemTableAdapter.Fill(Me.Group16DataSet.Customer_Quote_Line_Item)
        Catch ex As SyntaxErrorException
            MsgBox("Cannot be found!", vbExclamation, "Incorrect Input!")
        Catch ex As EvaluateException
            MsgBox("Cannot be found", vbExclamation, "Incorrect Input!")
        Catch ex As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
        End Try

    End Sub

    Private Sub CustomerQuoteLineItemDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CustomerQuoteLineItemDataGridView.CellClick

        If (e.ColumnIndex = 1) Then 'product info
            Try
                Dim ProductID As String = CustomerQuoteLineItemDataGridView.CurrentRow.Cells(1).Value.ToString

                ProductInfoPopUp.Show()
                ProductInfoPopUp.ProductBindingSource.Filter = "Product_ID = '" & ProductID & "'"
                ProductInfoPopUp.Text = "Product Information"

            Catch ex As SqlException
                MsgBox("Cannot be found!", vbExclamation, "Incorrect Input!")
            Catch ex As EvaluateException
                MsgBox("Cannot be found", vbExclamation, "Incorrect Input!")
            Catch ex As Exception
                MsgBox("Oops something went wrong!", vbExclamation, "Error!")
            End Try

        End If

        If (e.ColumnIndex = 10) Then ' remove item

            Dim SQLcon As SqlConnection = New SqlConnection()
            Dim SQLcomm As SqlCommand

            SQLcon.ConnectionString = "Server=146.230.177.46\ist3;Initial Catalog=group16;User ID=group16; Password=78fgg"
            Dim READER As SqlDataReader


            ProductID = Integer.Parse(CustomerQuoteLineItemDataGridView.CurrentRow.Cells(1).Value)
            SupplierID = Integer.Parse(CustomerQuoteLineItemDataGridView.CurrentRow.Cells(8).Value)
            CustomerQuoteReferenceID = Integer.Parse(CustomerQuoteLineItemDataGridView.CurrentRow.Cells(0).Value)

            Try
                Dim ret As Integer = MsgBox("Remove this Line Item from Customer Quote (" & CustomerQuoteReferenceID & ")?", vbYesNo, "Confirm Delete?")

                If ret = 6 Then 'if user clicks yes to delete'

                    SQLcon.Open()
                    Dim Query As String
                    Query = "DELETE FROM Customer_Quote_Line_Item WHERE Cust_Quote_Reference_ID = '" & CustomerQuoteReferenceID & "' AND Product_ID = '" & ProductID & "' AND Supplier_ID = '" & SupplierID & "'"
                    SQLcomm = New SqlCommand(Query, SQLcon)
                    READER = SQLcomm.ExecuteReader
                    SQLcon.Close()
                    MsgBox("Product (" & ProductID & ") was removed from Customer Quote (" & CustomerQuoteReferenceID & ") !", vbInformation)
                End If
            Catch ex As SqlException
                MsgBox("Cannot delete!", vbExclamation, "Cannot delete!")
            Catch ex As NoNullAllowedException
                MsgBox("Incorrect input!Follow correct format!", vbExclamation, "Incorrect Input!")
            Catch ex As Exception
                MsgBox("Oops something went wrong!", vbExclamation, "Error!")
            Finally
                SQLcon.Dispose()
                Me.ProductTableAdapter.Fill(Me.Group16DataSet.Product)
                Me.Customer_Quote_Line_ItemTableAdapter.Fill(Me.Group16DataSet.Customer_Quote_Line_Item)
            End Try

        ElseIf (e.ColumnIndex = 9) Then 'edit line item
            Try
                Dim ret As Integer = MsgBox("Edit line item details for Customer Quote?", vbYesNo)

                If ret = 6 Then

                    ProductID = Integer.Parse(CustomerQuoteLineItemDataGridView.CurrentRow.Cells(1).Value)
                    CustomerQuoteReferenceID = Integer.Parse(CustomerQuoteLineItemDataGridView.CurrentRow.Cells(0).Value)
                    SupplierID = Integer.Parse(CustomerQuoteLineItemDataGridView.CurrentRow.Cells(8).Value)

                    Dim CurrentCostPrice = Decimal.Parse(CustomerQuoteLineItemDataGridView.CurrentRow.Cells(2).Value)

                    Dim CurrentDiscountPercentage = Decimal.Parse(CustomerQuoteLineItemDataGridView.CurrentRow.Cells(4).Value)
                    Dim CurrentQuantity = Integer.Parse(CustomerQuoteLineItemDataGridView.CurrentRow.Cells(7).Value)

                    CostPrice = Decimal.Parse(InputBox("Enter item cost price in Rands:", vbOKOnly, CurrentCostPrice))
                    MarkupPercentage = Decimal.Parse(InputBox("Enter markup %:", vbOKOnly, SetMarkupPercentage))
                    DiscountPercentage = Decimal.Parse(InputBox("Enter item discount %:", vbOKOnly, CurrentDiscountPercentage))
                    Quantity = Integer.Parse(InputBox("Enter item quantity:", vbOKOnly, CurrentQuantity))

                    'calculations
                    Dim MarkupAmount As Decimal = (MarkupPercentage / 100) * CostPrice
                    Dim DiscountAmount As Decimal = (CostPrice + MarkupAmount) * (DiscountPercentage / 100)
                    SaleExclVat = ((CostPrice + MarkupAmount) - (DiscountAmount))
                    SaleInclVat = SaleExclVat + (SaleExclVat * VATPercentage)


                    Customer_Quote_Line_ItemTableAdapter.UpdateCustLineItemQuery(CostPrice, SaleInclVat, SaleExclVat, MarkupPercentage, DiscountPercentage, Quantity, ProductID, CustomerQuoteReferenceID, SupplierID)
                    Me.ProductTableAdapter.Fill(Me.Group16DataSet.Product)
                    Me.Customer_Quote_Line_ItemTableAdapter.Fill(Me.Group16DataSet.Customer_Quote_Line_Item)
                    Me.CustomerQuoteLineItemBindingSource.Filter = "Cust_Quote_Reference_ID = '" & CustomerQuoteReferenceID & "'"
                    Call ClearButton_Click(sender, e)
                End If

            Catch ex As SqlException
                MsgBox("Cannot be found!", vbExclamation, "Incorrect Input!")
            Catch ex As EvaluateException
                MsgBox("Cannot be found", vbExclamation, "Incorrect Input!")
            Catch ex As Exception
                MsgBox("Oops something went wrong!", vbExclamation, "Error!")
            End Try

        End If
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        SearchTextBox.ResetText()
    End Sub

    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        Try
            ProductBindingSource.Filter = "Product_Name LIKE'" & SearchTextBox.Text & "%'"
        Catch ex As SyntaxErrorException
            MsgBox("Cannot be found!", vbExclamation, "Incorrect Input!")
        Catch ex As EvaluateException
            MsgBox("Cannot be found", vbExclamation, "Incorrect Input!")
        Catch ex As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
        End Try
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click

        Try

            CustomerQuoteManager.CustomerQuoteJoinCustomerTableAdapter.Fill(CustomerQuoteManager.Group16DataSet.CustomerQuoteJoinCustomer)
            CustomerQuoteManager.CustLineItemJoinProductsTableAdapter.Fill(CustomerQuoteManager.Group16DataSet.CustLineItemJoinProducts)


            Call CreateOrEditCustomerQuote.RefreshButton_Click(sender, e)

            Me.Close()
        Catch ex As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
        End Try
    End Sub

    Private Sub ProductDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProductDataGridView.CellClick

        Try
            If (e.ColumnIndex = 5) Then 'add product to quote

                Dim ret As Integer = MsgBox("Add product to Customer Quote?", vbYesNo)

                If ret = 6 Then 'if user clicks yes to add item'

                    ProductID = Integer.Parse(ProductDataGridView.CurrentRow.Cells(0).Value)
                    AddStatus = True
                    UpdateStatus = False
                    LineItemDetailsPopUp.Show()
                    Call ClearButton_Click(sender, e)
                End If

            End If
        Catch ex As SyntaxErrorException
            MsgBox("Cannot add!", vbExclamation, "Cannot add!")
        Catch ex As EvaluateException
            MsgBox("Cannot add", vbExclamation, "Cannot add!")
        Catch ex As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
        End Try

    End Sub

    Private Sub ClearButton_MouseHover(sender As Object, e As EventArgs) Handles ClearButton.MouseHover
        CustomerQuoteLineItemManagerTip.SetToolTip(ClearButton, "Click to clear selection")
    End Sub

    Private Sub BackButton_MouseHover(sender As Object, e As EventArgs) Handles BackButton.MouseHover
        CustomerQuoteLineItemManagerTip.SetToolTip(BackButton, "Click to leave form")
    End Sub
End Class
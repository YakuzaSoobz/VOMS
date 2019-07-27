Imports System.Data.SqlClient

Public Class SupplierQuoteLineItemManager

    Public SupplierQuoteReferenceID As Integer
    Public CreateProductStatus = False
    Dim ProductID As Integer
    Dim CostPrice As Decimal
    Dim Quantity As Integer

    Private Sub SupplierQuoteLineItemManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Me.ProductTableAdapter.Fill(Me.Group16DataSet.Product)
            Me.Supplier_Quote_Line_ItemTableAdapter.Fill(Me.Group16DataSet.Supplier_Quote_Line_Item)

        Catch ex As SyntaxErrorException
            MsgBox("Cannot be found!", vbExclamation, "Incorrect Input!")
        Catch ex As EvaluateException
            MsgBox("Cannot be found", vbExclamation, "Incorrect Input!")
        Catch ex As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
        End Try
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        SearchTextBox.ResetText()
    End Sub

    Private Sub ProductDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProductDataGridView.CellClick
        Try

            If (e.ColumnIndex = 5) Then 'add product to quote

                Dim ret As Integer = MsgBox("Add product to Supplier Quote?", vbYesNo)

                If ret = 6 Then 'if user clicks yes to add item'

                    ProductID = Integer.Parse(ProductDataGridView.CurrentRow.Cells(0).Value)
                    CostPrice = Decimal.Parse(InputBox("Enter item cost price:", vbOKOnly, "0"))
                    Quantity = Integer.Parse(InputBox("Enter item quantity:", vbOKOnly, "1"))

                    Supplier_Quote_Line_ItemTableAdapter.Insert(SupplierQuoteReferenceID, ProductID, CostPrice, Quantity)
                    Me.ProductTableAdapter.Fill(Me.Group16DataSet.Product)
                    Me.Supplier_Quote_Line_ItemTableAdapter.Fill(Me.Group16DataSet.Supplier_Quote_Line_Item)
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

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click

        Try
            SupplierQuoteManager.SupplierQuoteJoinSupplierTableAdapter.Fill(SupplierQuoteManager.Group16DataSet.SupplierQuoteJoinSupplier)
            SupplierQuoteManager.SuppLineItemJoinProductTableAdapter.Fill(SupplierQuoteManager.Group16DataSet.SuppLineItemJoinProduct)
            Call CreateOrEditSupplierQuote.RefreshButton_Click(sender, e)

            Me.Close()
        Catch ex As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
        End Try
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

    Private Sub SupplierQuoteLineItemDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles SupplierQuoteLineItemDataGridView.CellClick

        If (e.ColumnIndex = 1) Then 'product info
            Try
                Dim ProductID As String = SupplierQuoteLineItemDataGridView.CurrentRow.Cells(1).Value.ToString

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

        If (e.ColumnIndex = 4) Then

            Dim SQLcon As SqlConnection = New SqlConnection()
            Dim SQLcomm As SqlCommand

            SQLcon.ConnectionString = "Server=146.230.177.46\ist3;Initial Catalog=group16;User ID=group16; Password=78fgg"
            Dim READER As SqlDataReader


            ProductID = Integer.Parse(SupplierQuoteLineItemDataGridView.CurrentRow.Cells(1).Value)

            Try
                Dim ret As Integer = MsgBox("Remove this Line Item from Supplier Quote (" & SupplierQuoteReferenceID & ")?", vbYesNo, "Confirm Delete?")

                If ret = 6 Then 'if user clicks yes to delete'

                    SQLcon.Open()
                    Dim Query As String
                    Query = "DELETE FROM Supplier_Quote_Line_Item WHERE Supp_Quote_Reference_ID = '" & SupplierQuoteReferenceID & "' AND Product_ID ='" & ProductID & "'"
                    SQLcomm = New SqlCommand(Query, SQLcon)
                    READER = SQLcomm.ExecuteReader
                    SQLcon.Close()
                    MsgBox("Product (" & ProductID & ") was removed from Supplier Quote (" & SupplierQuoteReferenceID & ") !", vbInformation)
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
                Me.Supplier_Quote_Line_ItemTableAdapter.Fill(Me.Group16DataSet.Supplier_Quote_Line_Item)
            End Try

        ElseIf (e.ColumnIndex = 5) Then 'edit line item
            Try
                Dim ret As Integer = MsgBox("Edit line item details for Supplier Quote?", vbYesNo)

                If ret = 6 Then 'if user clicks yes to add item'

                    ProductID = Integer.Parse(SupplierQuoteLineItemDataGridView.CurrentRow.Cells(1).Value)
                    SupplierQuoteReferenceID = Integer.Parse(SupplierQuoteLineItemDataGridView.CurrentRow.Cells(0).Value)
                    Dim CurrentCostPrice = Decimal.Parse(SupplierQuoteLineItemDataGridView.CurrentRow.Cells(2).Value)
                    Dim CurrentQuantity = Integer.Parse(SupplierQuoteLineItemDataGridView.CurrentRow.Cells(3).Value)

                    CostPrice = Decimal.Parse(InputBox("Enter item cost price:", vbOKOnly, CurrentCostPrice))
                    Quantity = Integer.Parse(InputBox("Enter item quantity:", vbOKOnly, CurrentQuantity))

                    Supplier_Quote_Line_ItemTableAdapter.UpdateSuppLineItemQuery(Quantity, CostPrice, SupplierQuoteReferenceID, ProductID)
                    Me.ProductTableAdapter.Fill(Me.Group16DataSet.Product)
                    Me.Supplier_Quote_Line_ItemTableAdapter.Fill(Me.Group16DataSet.Supplier_Quote_Line_Item)
                    Call ClearButton_Click(sender, e)
                End If


            Catch ex As SyntaxErrorException
                MsgBox("Cannot be found!", vbExclamation, "Incorrect Input!")
            Catch ex As EvaluateException
                MsgBox("Cannot be found", vbExclamation, "Incorrect Input!")
            Catch ex As Exception
                MsgBox("Oops something went wrong!", vbExclamation, "Error!")
            End Try

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CreateProductStatus = True
        ProductManager.Show()
    End Sub

    Private Sub ClearButton_MouseHover(sender As Object, e As EventArgs) Handles ClearButton.MouseHover
        ToolTip1.SetToolTip(ClearButton, "Click to clear selection")
    End Sub

    Private Sub BackButton_MouseHover(sender As Object, e As EventArgs) Handles BackButton.MouseHover
        ToolTip1.SetToolTip(BackButton, "Click to leave form")
    End Sub

    Public Function getTotal() As Decimal 'gets total of quote
        Dim sum As Decimal = 0
        Try
            For i As Integer = 0 To Me.Group16DataSet.Supplier_Quote_Line_Item.Rows.Count - 1

                If ((Me.Group16DataSet.Supplier_Quote_Line_Item.Rows(i)("Supp_Quote_Reference_ID")) = SupplierQuoteManager.SupplierQuoteReferenceID) Then

                    sum = sum + Decimal.Parse((Me.Group16DataSet.Supplier_Quote_Line_Item.Rows(i)("Supp_Line_Item_Cost_Price")) * (Me.Group16DataSet.SuppLineItemJoinProduct.Rows(i)("Supp_Line_Item_Quantity")))

                End If
            Next

        Catch ex As SqlException
            MsgBox("Error, cannot connect to network!", vbExclamation, "Error!")
        Catch ex As NoNullAllowedException
            MsgBox("Cannot compute Total Price!", vbExclamation, "Incorrect Input!")
        Catch ex As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
        End Try

        Return sum
    End Function
End Class
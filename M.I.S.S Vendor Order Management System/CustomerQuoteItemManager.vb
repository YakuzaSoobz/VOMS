Imports System.Data.SqlClient

Public Class CustomerQuoteItemManager

    Public CustomerQuoteReferenceID As Integer
    Public SupplierQuoteReferenceID As Integer
    Public ProductID As Integer
    Public Product As String
    Public ProductBrand As String
    Public ProductActiveStatus As String
    Public SupplierID As Integer
    Public SupplierQuoteSupplierID As Integer
    Public CostPrice As Decimal
    Public MarkupPercentage As Decimal
    Public DiscountPercentage As Decimal
    Public SaleInclVat As Decimal
    Public SaleExclVat As Decimal
    Public Quantity As Integer
    'Public VATPercentadfdfge As Decimal = 0.15
    Public SetMarkupPercentage As Decimal = 20

    Public AddStatus = False
    Public UpdateStatus = False

    Private Sub CustomerQuoteItemManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group16DataSet.CustLineItemJoinProducts' table. You can move, or remove it, as needed.

        Try
            Me.CustLineItemJoinProductsTableAdapter.Fill(Me.Group16DataSet.CustLineItemJoinProducts)

            Me.SupplierQuoteJoinSupplierTableAdapter.Fill(Me.Group16DataSet.SupplierQuoteJoinSupplier)
            'SupplierQuoteJoinSupplierBindingSource.Filter = "Cust_Quote_Date_Issued >= '2010-04-01'"
        Catch ex As SyntaxErrorException
            MsgBox("Cannot be found!", vbExclamation, "Incorrect Input!")
        Catch ex As EvaluateException
            MsgBox("Cannot be found", vbExclamation, "Incorrect Input!")
        Catch ex As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
        End Try
    End Sub

    Private Sub SupplierQuoteDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles SupplierQuoteDataGridView.CellClick
        Try
            'if row is clicked then the corresponding quoteed items is shown in the items datagrid
            Me.SuppLineItemJoinProductTableAdapter.Fill(Me.Group16DataSet.SuppLineItemJoinProduct)

            SupplierQuoteReferenceID = Integer.Parse(SupplierQuoteDataGridView.CurrentRow.Cells(0).Value)
            SupplierQuoteSupplierID = Integer.Parse(SupplierQuoteDataGridView.CurrentRow.Cells(2).Value.ToString)
            SuppLineItemJoinProductBindingSource.Filter = "Supp_Quote_Reference_ID = '" & SupplierQuoteReferenceID & "'"

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

            If ((CustQuoteLineItemDataGridView.RowCount > 0)) Then

                CustomerQuoteManager.CustomerQuoteJoinCustomerTableAdapter.Fill(CustomerQuoteManager.Group16DataSet.CustomerQuoteJoinCustomer)
                CustomerQuoteManager.CustLineItemJoinProductsTableAdapter.Fill(CustomerQuoteManager.Group16DataSet.CustLineItemJoinProducts)
                Call CreateOrEditCustomerQuote.RefreshButton_Click(sender, e)
                Me.Close()

            Else
                MsgBox("You need to add atleast one item to the quote first before leaving!", MsgBoxStyle.YesNo)
            End If

        Catch ex As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
        End Try
    End Sub

    Private Sub CustQuoteLineItemDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CustQuoteLineItemDataGridView.CellClick

        If (e.ColumnIndex = 14) Then ' remove item

            Dim SQLcon As SqlConnection = New SqlConnection()
            Dim SQLcomm As SqlCommand

            SQLcon.ConnectionString = "Server=146.230.177.46\ist3;Initial Catalog=group16;User ID=group16; Password=78fgg"
            Dim READER As SqlDataReader


            ProductID = Integer.Parse(CustQuoteLineItemDataGridView.CurrentRow.Cells(1).Value)
            SupplierID = Integer.Parse(CustQuoteLineItemDataGridView.CurrentRow.Cells(4).Value)

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
                Me.CustLineItemJoinProductsTableAdapter.Fill(Me.Group16DataSet.CustLineItemJoinProducts)
            End Try

        ElseIf (e.ColumnIndex = 13) Then 'edit line item
            Try

                Dim ret As Integer = MsgBox("Edit product details?", vbYesNo)

                If ret = 6 Then 'if user clicks yes to edit item'
                    AddStatus = False
                    UpdateStatus = True

                    LineItemDetailsPopUp.ProductID = Integer.Parse(CustQuoteLineItemDataGridView.CurrentRow.Cells(1).Value)
                    LineItemDetailsPopUp.SupplierID = Integer.Parse(CustQuoteLineItemDataGridView.CurrentRow.Cells(4).Value)
                    LineItemDetailsPopUp.Quantity = Integer.Parse(CustQuoteLineItemDataGridView.CurrentRow.Cells(9).Value)
                    LineItemDetailsPopUp.CostPrice = Decimal.Parse(CustQuoteLineItemDataGridView.CurrentRow.Cells(6).Value)
                    LineItemDetailsPopUp.MarkupPercentage = Decimal.Parse(CustQuoteLineItemDataGridView.CurrentRow.Cells(7).Value)
                    LineItemDetailsPopUp.DiscountPercentage = Decimal.Parse(CustQuoteLineItemDataGridView.CurrentRow.Cells(8).Value)

                    Product = CustQuoteLineItemDataGridView.CurrentRow.Cells(2).Value.ToString
                    ProductBrand = CustQuoteLineItemDataGridView.CurrentRow.Cells(3).Value.ToString
                    ProductActiveStatus = CustQuoteLineItemDataGridView.CurrentRow.Cells(12).Value.ToString

                    LineItemDetailsPopUp.Text = "Customer Quote Line Item ID: " & Integer.Parse(CustQuoteLineItemDataGridView.CurrentRow.Cells(1).Value)

                    LineItemDetailsPopUp.Show()
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

    Private Sub SuppLineItemDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles SuppLineItemDataGridView.CellClick
        Try
            If (e.ColumnIndex = 8) Then 'add product to quote

                Dim ret As Integer = MsgBox("Add product to Customer Quote?", vbYesNo)

                If ret = 6 Then 'if user clicks yes to add item'

                    ProductID = Integer.Parse(SuppLineItemDataGridView.CurrentRow.Cells(1).Value)

                    Product = SuppLineItemDataGridView.CurrentRow.Cells(2).Value.ToString
                    ProductBrand = SuppLineItemDataGridView.CurrentRow.Cells(3).Value.ToString
                    ProductActiveStatus = SuppLineItemDataGridView.CurrentRow.Cells(7).Value.ToString
                    Quantity = Integer.Parse(SuppLineItemDataGridView.CurrentRow.Cells(6).Value)
                    CostPrice = Decimal.Parse(SuppLineItemDataGridView.CurrentRow.Cells(5).Value)


                    AddStatus = True
                    UpdateStatus = False
                    LineItemDetailsPopUp.Show()

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

    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        Try
            SupplierQuoteJoinSupplierBindingSource.Filter = "Supplier_Name LIKE'" & SearchTextBox.Text & "%'"
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
End Class
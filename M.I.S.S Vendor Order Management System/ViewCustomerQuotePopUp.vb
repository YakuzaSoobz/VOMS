Imports System.Data.SqlClient

Public Class ViewCustomerQuotePopUp

    Public QuoteStatus As Boolean = False
    Public InvoiceStatus As Boolean = False

    Private Sub ViewCustomerQuotePopUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group16DataSet.CustomerQuoteJoinCustomer' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'Group16DataSet.CustLineItemJoinProducts' table. You can move, or remove it, as needed.

        Try
            Me.CustLineItemJoinProductsTableAdapter.Fill(Me.Group16DataSet.CustLineItemJoinProducts)
            Me.CustomerQuoteJoinCustomerTableAdapter.Fill(Me.Group16DataSet.CustomerQuoteJoinCustomer)

            If (QuoteStatus = True) And (InvoiceStatus = False) Then
                NavigationGroupBox.Text = "CUSTOMER QUOTE"
                Me.Text = "View Customer Quote"

            ElseIf (QuoteStatus = False) And (InvoiceStatus = True) Then
                NavigationGroupBox.Text = "CUSTOMER INVOICE"
                Me.Text = "View Customer Invoice"
                PrintQuoteButton.Text = "PRINT CUSTOMER INVOICE"
                TypeLabel.Text = "Customer Invoice:"
            End If
        Catch exe As SqlException
            MsgBox("Reconnect to network!", vbExclamation, "Reconnect to Network!")
        Catch exe As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
        End Try

    End Sub

    Private Sub ConfirmAndPrintOrderButton_Click(sender As Object, e As EventArgs) Handles PrintQuoteButton.Click
        Try


            PrintQuoteButton.Visible = False
            BackButton.Visible = False
            Me.PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
            Me.PrintForm1.Print()
            PrintQuoteButton.Visible = True
            BackButton.Visible = True


        Catch exe As SqlException
            MsgBox("Reconnect to network!", vbExclamation, "Reconnect to Network!")
        Catch exe As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
        End Try
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        CustomerQuoteManager.Show()
        Me.Close()
    End Sub
End Class
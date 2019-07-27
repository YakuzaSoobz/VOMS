Imports System.Data.SqlClient

Public Class ViewSupplierQuotePopUp

    Public QuoteStatus As Boolean = False
    Public InvoiceStatus As Boolean = False
    Private Sub PrintQuoteButton_Click(sender As Object, e As EventArgs) Handles PrintQuoteButton.Click

        Try

            If (SupplierQuoteManager.ViewQuoteStatus = True) Then
                PrintQuoteButton.Visible = False
                BackButton.Visible = False
                Me.PrintQuote.PrintAction = Printing.PrintAction.PrintToPreview
                Me.PrintQuote.Print()
                PrintQuoteButton.Visible = True
                BackButton.Visible = True
            End If

        Catch exe As SqlException
            MsgBox("Reconnect to network!", vbExclamation, "Reconnect to Network!")
        Catch exe As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
        End Try
    End Sub

    Private Sub ViewSupplierQuotePopUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Try
            Me.SupplierQuoteJoinSupplierTableAdapter.Fill(Me.Group16DataSet.SupplierQuoteJoinSupplier)
            Me.SuppLineItemJoinProductTableAdapter.Fill(Me.Group16DataSet.SuppLineItemJoinProduct)

            If (QuoteStatus = True) And (InvoiceStatus = False) Then
                NavigationGroupBox.Text = "SUPPLIER QUOTE"
                Me.Text = "View Supplier Quote"

            ElseIf (QuoteStatus = False) And (InvoiceStatus = True) Then
                NavigationGroupBox.Text = "SUPPLIER INVOICE"
                Me.Text = "View Supplier Invoice"
                PrintQuoteButton.Text = "PRINT SUPPLIER INVOICE"
            End If
        Catch exe As SqlException
            MsgBox("Reconnect to network!", vbExclamation, "Reconnect to Network!")
        Catch exe As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
        End Try
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        SupplierQuoteManager.Show()
        Me.Close()

    End Sub
End Class
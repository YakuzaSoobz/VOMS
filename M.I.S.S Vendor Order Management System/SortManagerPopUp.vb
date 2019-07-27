Imports System.Data.SqlClient

Public Class SortManagerPopUp

    Private Sub QuotesBetween_Click(sender As Object, e As EventArgs) Handles QuotesBetween.Click
        Try
            Dim dateFrom As String = FromDateTimePicker.Value.ToShortDateString
            Dim dateTo As String = ToDateTimePicker.Value.ToShortDateString

            If (SupplierQuoteManager.SortStatus = True) And (CustomerQuoteManager.SortStatus = False) Then
                SupplierQuoteManager.SupplierQuoteJoinSupplierBindingSource.Filter = "Supp_Quote_Date_Recieved >= '" & dateFrom & "' AND Supp_Quote_Date_Recieved <= '" & dateTo & "'"
                Call BackButton_Click(sender, e)

            ElseIf (SupplierQuoteManager.SortStatus = False) And (CustomerQuoteManager.SortStatus = True) Then
                CustomerQuoteManager.CustomerQuoteJoinCustomerBindingSource.Filter = "Cust_Quote_Date_Issued >= '" & dateFrom & "' AND Cust_Quote_Date_Issued <= '" & dateTo & "'"
                Call BackButton_Click(sender, e)
            End If
        Catch exe As SqlException
            MsgBox("Reconnect to network!", vbExclamation, "Reconnect to Network!")
        Catch exe As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
        End Try
    End Sub

    Private Sub DescendingOrderButton_Click(sender As Object, e As EventArgs) Handles DescendingOrderButton.Click

        Try
            If (SupplierQuoteManager.SortStatus = True) And (CustomerQuoteManager.SortStatus = False) Then
                SupplierQuoteManager.SupplierQuoteJoinSupplierTableAdapter.DateRecievedDescending(SupplierQuoteManager.Group16DataSet.SupplierQuoteJoinSupplier)
                Call BackButton_Click(sender, e)

            ElseIf (SupplierQuoteManager.SortStatus = False) And (CustomerQuoteManager.SortStatus = True) Then
                CustomerQuoteManager.CustomerQuoteJoinCustomerTableAdapter.FillDateIssuedDescending(CustomerQuoteManager.Group16DataSet.CustomerQuoteJoinCustomer)
                Call BackButton_Click(sender, e)
            End If

        Catch exe As SqlException
            MsgBox("Reconnect to network!", vbExclamation, "Reconnect to Network!")
        Catch exe As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
        End Try
    End Sub

    Private Sub AscendingOrderButton_Click(sender As Object, e As EventArgs) Handles AscendingOrderButton.Click
        Try
            If (SupplierQuoteManager.SortStatus = True) And (CustomerQuoteManager.SortStatus = False) Then
                SupplierQuoteManager.SupplierQuoteJoinSupplierTableAdapter.DateRecievedAscending(SupplierQuoteManager.Group16DataSet.SupplierQuoteJoinSupplier)
                Call BackButton_Click(sender, e)

            ElseIf (SupplierQuoteManager.SortStatus = False) And (CustomerQuoteManager.SortStatus = True) Then
                CustomerQuoteManager.CustomerQuoteJoinCustomerTableAdapter.FillDateIssuedAscending(CustomerQuoteManager.Group16DataSet.CustomerQuoteJoinCustomer)
                Call BackButton_Click(sender, e)
            End If
        Catch exe As SqlException
            MsgBox("Reconnect to network!", vbExclamation, "Reconnect to Network!")
        Catch exe As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
        End Try
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        SupplierQuoteManager.SortStatus = False
        CustomerQuoteManager.SortStatus = False
        Me.Close()
    End Sub

    Private Sub SortManagerPopUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (SupplierQuoteManager.SortStatus = True) And (CustomerQuoteManager.SortStatus = False) Then
            Me.Text = "Supplier Quote Manager: Date Sort Options"

        ElseIf (SupplierQuoteManager.SortStatus = False) And (CustomerQuoteManager.SortStatus = True) Then
            Me.Text = "Customer Quote Manager: Date Sort Options"
        End If
    End Sub
End Class
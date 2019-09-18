Imports System.Data.SqlClient

Public Class SelectCustomerPopUp



    Private Sub SelectCustomerPopUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group16DataSet.Customer' table. You can move, or remove it, as needed.

        Try
            Me.CustomerTableAdapter.Fill(Me.Group16DataSet.Customer)
        Catch exe As SqlException
            MsgBox("Reconnect to network!", vbExclamation, "Reconnect to Network!")
        Catch exe As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
        End Try
    End Sub

    Private Sub CreateCustomerButton_Click(sender As Object, e As EventArgs) Handles CreateCustomerButton.Click

        Try
            If (CustomerDataGridView.CurrentRow.Cells(4).Value.ToString = "T" Or CustomerDataGridView.CurrentRow.Cells(4).Value.ToString = "t") Then

                CreateOrEditCustomerQuote.CustomerIDComboBox.Text = Integer.Parse(CustomerDataGridView.CurrentRow.Cells(0).Value)

                Me.Close()
            ElseIf (CustomerDataGridView.CurrentRow.Cells(4).Value.ToString = "F" Or CustomerDataGridView.CurrentRow.Cells(4).Value.ToString = "f") Then
                MsgBox("This Customer is not active anymore! Please select an active customer.", vbExclamation, "Invalid Selection!")
            End If

        Catch exe As SqlException
            MsgBox("Reconnect to network!", vbExclamation, "Reconnect to Network!")
        Catch exe As Exception
            MsgBox("Oops something went wrong! Unable to select the customer of your choice.", vbExclamation, "Error!")
        End Try

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Close()
    End Sub
End Class
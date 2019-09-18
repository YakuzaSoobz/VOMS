Imports System.Data.SqlClient

Public Class SelectEmployeePopUp
    Private Sub SelectEmployeePopUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group16DataSet.Employee' table. You can move, or remove it, as needed.

        Try
            Me.EmployeeTableAdapter.Fill(Me.Group16DataSet.Employee)
        Catch exe As SqlException
            MsgBox("Reconnect to network!", vbExclamation, "Reconnect to Network!")
        Catch exe As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
        End Try

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Close()
    End Sub

    Private Sub SelectCustomerButton_Click(sender As Object, e As EventArgs) Handles SelectCustomerButton.Click
        Try
            If (EmployeeDataGridView.CurrentRow.Cells(5).Value.ToString = "T" Or EmployeeDataGridView.CurrentRow.Cells(5).Value.ToString = "t") Then

                CreateOrEditCustomerQuote.EmployeeIDComboBox.Text = Integer.Parse(EmployeeDataGridView.CurrentRow.Cells(0).Value)

                Me.Close()
            ElseIf (EmployeeDataGridView.CurrentRow.Cells(5).Value.ToString = "F" Or EmployeeDataGridView.CurrentRow.Cells(5).Value.ToString = "f") Then
                MsgBox("This Employee is not active anymore! Please select an active Employee.", vbExclamation, "Invalid Selection!")
            End If

        Catch exe As SqlException
            MsgBox("Reconnect to network!", vbExclamation, "Reconnect to Network!")
        Catch exe As Exception
            MsgBox("Oops something went wrong! Unable to select the customer of your choice.", vbExclamation, "Error!")
        End Try
    End Sub
End Class
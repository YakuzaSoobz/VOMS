Imports System.Data.SqlClient

Public Class SelectSupplierPopUp
    Private Sub SelectSupplierPopUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group16DataSet.Supplier' table. You can move, or remove it, as needed.

        Try
            Me.SupplierTableAdapter.Fill(Me.Group16DataSet.Supplier)
        Catch exe As SqlException
            MsgBox("Reconnect to network!", vbExclamation, "Reconnect to Network!")
        Catch exe As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
        End Try
    End Sub

    Private Sub SelectSupplierButton_Click(sender As Object, e As EventArgs) Handles SelectSupplierButton.Click
        Try
            If (SupplierDataGridView.CurrentRow.Cells(4).Value.ToString = "T" Or (SupplierDataGridView.CurrentRow.Cells(4).Value.ToString = "t")) Then

                CreateOrEditSupplierQuote.SupplierIDComboBox.Text = Integer.Parse((SupplierDataGridView.CurrentRow.Cells(0).Value))

                Me.Close()
            ElseIf (SupplierDataGridView.CurrentRow.Cells(4).Value.ToString = "F" Or (SupplierDataGridView.CurrentRow.Cells(4).Value.ToString = "f")) Then
                MsgBox("This Supplier is not active anymore! Please select an active Supplier.", vbExclamation, "Invalid Selection!")
            End If

        Catch exe As SqlException
            MsgBox("Reconnect to network!", vbExclamation, "Reconnect to Network!")
        Catch exe As Exception
            MsgBox("Oops something went wrong! Unable to select the Supplier of your choice.", vbExclamation, "Error!")
        End Try
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Close()
    End Sub
End Class
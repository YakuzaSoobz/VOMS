Imports System.Data.SqlClient

Public Class SupplierInfoPopUp
    Private Sub SupplierInfoPopUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Me.SupplierTableAdapter.Fill(Me.Group16DataSet.Supplier)
        Catch exe As SqlException
            MsgBox("Reconnect to network!", vbExclamation, "Reconnect to Network!")
        Catch exe As Exception
            MsgBox("Oops, something went wrong!", vbExclamation, "Error!")
        End Try
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Close()
    End Sub
End Class
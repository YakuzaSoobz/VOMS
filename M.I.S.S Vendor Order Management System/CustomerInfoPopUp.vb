Imports System.Data.SqlClient

Public Class CustomerInfoPopUp
    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Close()
    End Sub

    Private Sub CustomerInfoPopUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.CustomerTableAdapter.Fill(Me.Group16DataSet.Customer)
        Catch exe As SqlException
            MsgBox("Reconnect to network!", vbExclamation, "Reconnect to Network!")
        Catch exe As Exception
            MsgBox("Oops something went wrong!", vbExclamation, "Error!")
        End Try
    End Sub
End Class
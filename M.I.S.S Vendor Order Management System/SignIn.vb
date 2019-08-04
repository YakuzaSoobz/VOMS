Imports System.Data.SqlClient

Public Class SignIn

    Public ManagerStatus As Boolean
    Public EmployeeStatus As Boolean

    Private Sub SignInButton_Click(sender As Object, e As EventArgs) Handles SignInButton.Click

        Try
            EmployeeTableAdapter.FillBy(Group16DataSet.Employee, EmployeeIDTextbox.Text, PasswordTextBox.Text)
            Dim con As SqlConnection = New SqlConnection("Server=146.230.177.46\ist3;Initial Catalog=group16;User ID=group16; Password=78fgg")
            Dim com As SqlCommand = New SqlCommand("SELECT * FROM Employee WHERE Employee_Email='" & EmployeeIDTextbox.Text & "' AND Employee_Password='" & PasswordTextBox.Text & "' AND Employee_Admin_Level='" & AccessCombo.SelectedItem & "'", con)
            Dim sda As SqlDataAdapter = New SqlDataAdapter(com)
            Dim dt As DataTable = New DataTable()
            sda.Fill(dt)
            If (dt.Rows.Count > 0) Then
                If (AccessCombo.SelectedIndex = 0) Then

                    MessageBox.Show("Welcome " & EmployeeIDTextbox.Text & " ! You are logged in as a Manager.")
                    ManagerStatus = True
                    EmployeeStatus = False
                    ManagerHomeMenu.Show()

                    Me.Hide()


                Else
                    MessageBox.Show("Welcome " & EmployeeIDTextbox.Text & " ! You are logged in as an Employee.")

                    EmployeeStatus = True
                    ManagerStatus = False
                    EmployeeHomeMenu.Show()
                    Me.Hide()
                End If
            Else
                MessageBox.Show("Invalid Details entered, please try again.")


            End If
        Catch ex As SqlException
            MessageBox.Show("Oops! Connection to the server has failed.")
        Catch ex As Exception
            MessageBox.Show("Oops! Something went wrong.")

        End Try

    End Sub

    Private Sub EmployeeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EmployeeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Group16DataSet)

    End Sub

    Private Sub SignIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group16DataSet.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.Group16DataSet.Employee)
        PasswordTextBox.UseSystemPasswordChar = True
    End Sub

    Private Sub ShowPasswordButton_Click(sender As Object, e As EventArgs) Handles ShowPasswordButton.Click
        If PasswordTextBox.UseSystemPasswordChar = True Then

            PasswordTextBox.UseSystemPasswordChar = False
        Else
            PasswordTextBox.UseSystemPasswordChar = True
        End If
    End Sub
End Class

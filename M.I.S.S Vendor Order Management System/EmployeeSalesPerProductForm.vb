﻿Public Class EmployeeSalesPerProductForm
    Private Sub EmployeeSalesPerProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EmployeeTableAdapter1.Fill(Group16DataSet1.Employee)
        Customer_QuoteTableAdapter1.Fill(Group16DataSet1.Customer_Quote)
        Customer_Quote_Line_ItemTableAdapter1.Fill(Group16DataSet1.Customer_Quote_Line_Item)
        ProductTableAdapter1.Fill(Group16DataSet1.Product)
        employeeSalesPerProduct1.SetDataSource(Group16DataSet1)


    End Sub
End Class
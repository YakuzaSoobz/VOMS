<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductSoldPerMonthReportForm
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.Group16DataSet1 = New M.I.S.S_Vendor_Order_Management_System.group16DataSet()
		Me.ProductTableAdapter1 = New M.I.S.S_Vendor_Order_Management_System.group16DataSetTableAdapters.ProductTableAdapter()
		Me.Customer_QuoteTableAdapter1 = New M.I.S.S_Vendor_Order_Management_System.group16DataSetTableAdapters.Customer_QuoteTableAdapter()
		Me.Customer_Quote_Line_ItemTableAdapter1 = New M.I.S.S_Vendor_Order_Management_System.group16DataSetTableAdapters.Customer_Quote_Line_ItemTableAdapter()
		Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
		Me.amountOfProductsSoldMonthlyPastYear1 = New M.I.S.S_Vendor_Order_Management_System.AmountOfProductsSoldMonthlyPastYear()
		CType(Me.Group16DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Group16DataSet1
		'
		Me.Group16DataSet1.DataSetName = "group16DataSet"
		Me.Group16DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'ProductTableAdapter1
		'
		Me.ProductTableAdapter1.ClearBeforeFill = True
		'
		'Customer_QuoteTableAdapter1
		'
		Me.Customer_QuoteTableAdapter1.ClearBeforeFill = True
		'
		'Customer_Quote_Line_ItemTableAdapter1
		'
		Me.Customer_Quote_Line_ItemTableAdapter1.ClearBeforeFill = True
		'
		'CrystalReportViewer1
		'
		Me.CrystalReportViewer1.ActiveViewIndex = 0
		Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
		Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
		Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
		Me.CrystalReportViewer1.ReportSource = Me.amountOfProductsSoldMonthlyPastYear1
		Me.CrystalReportViewer1.Size = New System.Drawing.Size(915, 310)
		Me.CrystalReportViewer1.TabIndex = 0
		'
		'ProductSoldPerMonthReportForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(915, 310)
		Me.Controls.Add(Me.CrystalReportViewer1)
		Me.Name = "ProductSoldPerMonthReportForm"
		Me.Text = "Products Sold Per Month Report"
		CType(Me.Group16DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Group16DataSet1 As group16DataSet
	Friend WithEvents ProductTableAdapter1 As group16DataSetTableAdapters.ProductTableAdapter
	Friend WithEvents Customer_QuoteTableAdapter1 As group16DataSetTableAdapters.Customer_QuoteTableAdapter
	Friend WithEvents Customer_Quote_Line_ItemTableAdapter1 As group16DataSetTableAdapters.Customer_Quote_Line_ItemTableAdapter
	Friend WithEvents amountOfProductsSoldMonthlyPastYear1 As AmountOfProductsSoldMonthlyPastYear
	Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateOrEditCustomerQuote
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.QuoteDetailsGroupBox = New System.Windows.Forms.GroupBox()
        Me.EmployeeIDComboBox = New System.Windows.Forms.ComboBox()
        Me.CustomerQuoteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Group16DataSet = New M.I.S.S_Vendor_Order_Management_System.group16DataSet()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeSurnameTextBox = New System.Windows.Forms.TextBox()
        Me.EmployeeFirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerSurnameTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerFirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.OptionsGroupBox1 = New System.Windows.Forms.GroupBox()
        Me.UpdateQuoteButton = New System.Windows.Forms.Button()
        Me.DeleteQuoteButton = New System.Windows.Forms.Button()
        Me.DateAcceptedTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CreateCustomerButton = New System.Windows.Forms.Button()
        Me.EmployeeInfoButton = New System.Windows.Forms.Button()
        Me.CustomerInfoButton = New System.Windows.Forms.Button()
        Me.QuoteAcceptanceStatusComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CustomerIDComboBox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateIssuedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TotalPriceTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CustomerQuoteIDTextBox = New System.Windows.Forms.TextBox()
        Me.ItemGroupBox = New System.Windows.Forms.GroupBox()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.NotificationLabel = New System.Windows.Forms.Label()
        Me.EditLineItemsButton = New System.Windows.Forms.Button()
        Me.ItemsListGroupBox = New System.Windows.Forms.GroupBox()
        Me.CustLineItemJoinProductDataGridView = New System.Windows.Forms.DataGridView()
        Me.CustLineItemJoinProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Customer_QuoteTableAdapter = New M.I.S.S_Vendor_Order_Management_System.group16DataSetTableAdapters.Customer_QuoteTableAdapter()
        Me.CustomerTableAdapter = New M.I.S.S_Vendor_Order_Management_System.group16DataSetTableAdapters.CustomerTableAdapter()
        Me.EmployeeTableAdapter = New M.I.S.S_Vendor_Order_Management_System.group16DataSetTableAdapters.EmployeeTableAdapter()
        Me.CustLineItemJoinProductsTableAdapter = New M.I.S.S_Vendor_Order_Management_System.group16DataSetTableAdapters.CustLineItemJoinProductsTableAdapter()
        Me.CreateOrEditCustomerQuoteTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Customer_Quote_Line_ItemTableAdapter = New M.I.S.S_Vendor_Order_Management_System.group16DataSetTableAdapters.Customer_Quote_Line_ItemTableAdapter()
        Me.FKCustomerQuoteEmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HelpBtn = New System.Windows.Forms.Button()
        Me.HP1 = New System.Windows.Forms.HelpProvider()
        Me.ProductIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductBrandDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustLineItemCostPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustLineItemMarkupPercentageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustLineItemDiscountPercentageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustLineItemSaleexclVATDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustLineItemSaleinclVATDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustLineItemQuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuoteDetailsGroupBox.SuspendLayout()
        CType(Me.CustomerQuoteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group16DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OptionsGroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.ItemGroupBox.SuspendLayout()
        Me.ItemsListGroupBox.SuspendLayout()
        CType(Me.CustLineItemJoinProductDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustLineItemJoinProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKCustomerQuoteEmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BackButton.FlatAppearance.BorderSize = 3
        Me.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.BackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Location = New System.Drawing.Point(1169, 581)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(79, 33)
        Me.BackButton.TabIndex = 54
        Me.BackButton.Text = "BACK"
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'QuoteDetailsGroupBox
        '
        Me.QuoteDetailsGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.QuoteDetailsGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.QuoteDetailsGroupBox.Controls.Add(Me.EmployeeIDComboBox)
        Me.QuoteDetailsGroupBox.Controls.Add(Me.EmployeeSurnameTextBox)
        Me.QuoteDetailsGroupBox.Controls.Add(Me.EmployeeFirstNameTextBox)
        Me.QuoteDetailsGroupBox.Controls.Add(Me.CustomerSurnameTextBox)
        Me.QuoteDetailsGroupBox.Controls.Add(Me.CustomerFirstNameTextBox)
        Me.QuoteDetailsGroupBox.Controls.Add(Me.OptionsGroupBox1)
        Me.QuoteDetailsGroupBox.Controls.Add(Me.DateAcceptedTextBox)
        Me.QuoteDetailsGroupBox.Controls.Add(Me.Label5)
        Me.QuoteDetailsGroupBox.Controls.Add(Me.Label8)
        Me.QuoteDetailsGroupBox.Controls.Add(Me.CreateCustomerButton)
        Me.QuoteDetailsGroupBox.Controls.Add(Me.EmployeeInfoButton)
        Me.QuoteDetailsGroupBox.Controls.Add(Me.CustomerInfoButton)
        Me.QuoteDetailsGroupBox.Controls.Add(Me.QuoteAcceptanceStatusComboBox)
        Me.QuoteDetailsGroupBox.Controls.Add(Me.Label1)
        Me.QuoteDetailsGroupBox.Controls.Add(Me.Label3)
        Me.QuoteDetailsGroupBox.Controls.Add(Me.CustomerIDComboBox)
        Me.QuoteDetailsGroupBox.Controls.Add(Me.Label4)
        Me.QuoteDetailsGroupBox.Controls.Add(Me.DateIssuedDateTimePicker)
        Me.QuoteDetailsGroupBox.Controls.Add(Me.Label7)
        Me.QuoteDetailsGroupBox.Location = New System.Drawing.Point(11, 43)
        Me.QuoteDetailsGroupBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.QuoteDetailsGroupBox.Name = "QuoteDetailsGroupBox"
        Me.QuoteDetailsGroupBox.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.QuoteDetailsGroupBox.Size = New System.Drawing.Size(385, 465)
        Me.QuoteDetailsGroupBox.TabIndex = 68
        Me.QuoteDetailsGroupBox.TabStop = False
        Me.QuoteDetailsGroupBox.Text = "CUSTOMER QUOTE DETAILS"
        '
        'EmployeeIDComboBox
        '
        Me.EmployeeIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerQuoteBindingSource, "Employee_ID", True))
        Me.EmployeeIDComboBox.DataSource = Me.EmployeeBindingSource
        Me.EmployeeIDComboBox.DisplayMember = "Employee_ID"
        Me.EmployeeIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EmployeeIDComboBox.FormattingEnabled = True
        Me.EmployeeIDComboBox.Location = New System.Drawing.Point(137, 142)
        Me.EmployeeIDComboBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.EmployeeIDComboBox.MaxDropDownItems = 100
        Me.EmployeeIDComboBox.Name = "EmployeeIDComboBox"
        Me.EmployeeIDComboBox.Size = New System.Drawing.Size(35, 21)
        Me.EmployeeIDComboBox.TabIndex = 89
        '
        'CustomerQuoteBindingSource
        '
        Me.CustomerQuoteBindingSource.DataMember = "Customer_Quote"
        Me.CustomerQuoteBindingSource.DataSource = Me.Group16DataSet
        '
        'Group16DataSet
        '
        Me.Group16DataSet.DataSetName = "group16DataSet"
        Me.Group16DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "Employee"
        Me.EmployeeBindingSource.DataSource = Me.Group16DataSet
        '
        'EmployeeSurnameTextBox
        '
        Me.EmployeeSurnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Employee_SName", True))
        Me.EmployeeSurnameTextBox.Location = New System.Drawing.Point(264, 143)
        Me.EmployeeSurnameTextBox.Name = "EmployeeSurnameTextBox"
        Me.EmployeeSurnameTextBox.ReadOnly = True
        Me.EmployeeSurnameTextBox.Size = New System.Drawing.Size(88, 20)
        Me.EmployeeSurnameTextBox.TabIndex = 88
        '
        'EmployeeFirstNameTextBox
        '
        Me.EmployeeFirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Employee_FName", True))
        Me.EmployeeFirstNameTextBox.Location = New System.Drawing.Point(177, 143)
        Me.EmployeeFirstNameTextBox.Name = "EmployeeFirstNameTextBox"
        Me.EmployeeFirstNameTextBox.ReadOnly = True
        Me.EmployeeFirstNameTextBox.Size = New System.Drawing.Size(88, 20)
        Me.EmployeeFirstNameTextBox.TabIndex = 87
        '
        'CustomerSurnameTextBox
        '
        Me.CustomerSurnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Cust_SName", True))
        Me.CustomerSurnameTextBox.Location = New System.Drawing.Point(262, 42)
        Me.CustomerSurnameTextBox.Name = "CustomerSurnameTextBox"
        Me.CustomerSurnameTextBox.ReadOnly = True
        Me.CustomerSurnameTextBox.Size = New System.Drawing.Size(88, 20)
        Me.CustomerSurnameTextBox.TabIndex = 86
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me.Group16DataSet
        '
        'CustomerFirstNameTextBox
        '
        Me.CustomerFirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Cust_FName", True))
        Me.CustomerFirstNameTextBox.Location = New System.Drawing.Point(175, 42)
        Me.CustomerFirstNameTextBox.Name = "CustomerFirstNameTextBox"
        Me.CustomerFirstNameTextBox.ReadOnly = True
        Me.CustomerFirstNameTextBox.Size = New System.Drawing.Size(88, 20)
        Me.CustomerFirstNameTextBox.TabIndex = 84
        '
        'OptionsGroupBox1
        '
        Me.OptionsGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.OptionsGroupBox1.Controls.Add(Me.UpdateQuoteButton)
        Me.OptionsGroupBox1.Controls.Add(Me.DeleteQuoteButton)
        Me.OptionsGroupBox1.Location = New System.Drawing.Point(18, 359)
        Me.OptionsGroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.OptionsGroupBox1.Name = "OptionsGroupBox1"
        Me.OptionsGroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.OptionsGroupBox1.Size = New System.Drawing.Size(352, 78)
        Me.OptionsGroupBox1.TabIndex = 82
        Me.OptionsGroupBox1.TabStop = False
        Me.OptionsGroupBox1.Text = "OPTIONS"
        '
        'UpdateQuoteButton
        '
        Me.UpdateQuoteButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UpdateQuoteButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.UpdateQuoteButton.FlatAppearance.BorderSize = 3
        Me.UpdateQuoteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.UpdateQuoteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.UpdateQuoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpdateQuoteButton.Location = New System.Drawing.Point(32, 17)
        Me.UpdateQuoteButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UpdateQuoteButton.Name = "UpdateQuoteButton"
        Me.UpdateQuoteButton.Size = New System.Drawing.Size(128, 50)
        Me.UpdateQuoteButton.TabIndex = 1
        Me.UpdateQuoteButton.Text = "UPDATE"
        Me.UpdateQuoteButton.UseVisualStyleBackColor = False
        '
        'DeleteQuoteButton
        '
        Me.DeleteQuoteButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DeleteQuoteButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.DeleteQuoteButton.FlatAppearance.BorderSize = 3
        Me.DeleteQuoteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.DeleteQuoteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.DeleteQuoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteQuoteButton.Location = New System.Drawing.Point(194, 17)
        Me.DeleteQuoteButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DeleteQuoteButton.Name = "DeleteQuoteButton"
        Me.DeleteQuoteButton.Size = New System.Drawing.Size(128, 50)
        Me.DeleteQuoteButton.TabIndex = 2
        Me.DeleteQuoteButton.Text = "DELETE"
        Me.DeleteQuoteButton.UseVisualStyleBackColor = False
        '
        'DateAcceptedTextBox
        '
        Me.DateAcceptedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DateAcceptedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerQuoteBindingSource, "Cust_Quote_Date_Accepted", True))
        Me.DateAcceptedTextBox.Location = New System.Drawing.Point(248, 310)
        Me.DateAcceptedTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DateAcceptedTextBox.Name = "DateAcceptedTextBox"
        Me.DateAcceptedTextBox.ReadOnly = True
        Me.DateAcceptedTextBox.Size = New System.Drawing.Size(102, 20)
        Me.DateAcceptedTextBox.TabIndex = 80
        Me.DateAcceptedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(75, 312)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(169, 13)
        Me.Label5.TabIndex = 79
        Me.Label5.Text = "- Date Accepted (YYYY/MM/DD):"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(201, 286)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 13)
        Me.Label8.TabIndex = 78
        Me.Label8.Text = "(Y = Yes ; N = No)"
        Me.Label8.UseMnemonic = False
        '
        'CreateCustomerButton
        '
        Me.CreateCustomerButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CreateCustomerButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.CreateCustomerButton.FlatAppearance.BorderSize = 3
        Me.CreateCustomerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.CreateCustomerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.CreateCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CreateCustomerButton.Location = New System.Drawing.Point(189, 67)
        Me.CreateCustomerButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CreateCustomerButton.Name = "CreateCustomerButton"
        Me.CreateCustomerButton.Size = New System.Drawing.Size(146, 28)
        Me.CreateCustomerButton.TabIndex = 74
        Me.CreateCustomerButton.Text = "CREATE CUSTOMER"
        Me.CreateCustomerButton.UseVisualStyleBackColor = False
        '
        'EmployeeInfoButton
        '
        Me.EmployeeInfoButton.BackColor = System.Drawing.Color.Transparent
        Me.EmployeeInfoButton.BackgroundImage = Global.M.I.S.S_Vendor_Order_Management_System.My.Resources.Resources.info_sign
        Me.EmployeeInfoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.EmployeeInfoButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EmployeeInfoButton.FlatAppearance.BorderColor = System.Drawing.Color.BlanchedAlmond
        Me.EmployeeInfoButton.FlatAppearance.BorderSize = 0
        Me.EmployeeInfoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.EmployeeInfoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.EmployeeInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EmployeeInfoButton.Location = New System.Drawing.Point(352, 139)
        Me.EmployeeInfoButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.EmployeeInfoButton.Name = "EmployeeInfoButton"
        Me.EmployeeInfoButton.Size = New System.Drawing.Size(31, 24)
        Me.EmployeeInfoButton.TabIndex = 73
        Me.EmployeeInfoButton.UseVisualStyleBackColor = False
        '
        'CustomerInfoButton
        '
        Me.CustomerInfoButton.BackColor = System.Drawing.Color.Transparent
        Me.CustomerInfoButton.BackgroundImage = Global.M.I.S.S_Vendor_Order_Management_System.My.Resources.Resources.info_sign
        Me.CustomerInfoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CustomerInfoButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CustomerInfoButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.CustomerInfoButton.FlatAppearance.BorderSize = 0
        Me.CustomerInfoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.CustomerInfoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.CustomerInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CustomerInfoButton.Location = New System.Drawing.Point(350, 39)
        Me.CustomerInfoButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CustomerInfoButton.Name = "CustomerInfoButton"
        Me.CustomerInfoButton.Size = New System.Drawing.Size(31, 24)
        Me.CustomerInfoButton.TabIndex = 72
        Me.CustomerInfoButton.UseVisualStyleBackColor = False
        '
        'QuoteAcceptanceStatusComboBox
        '
        Me.QuoteAcceptanceStatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerQuoteBindingSource, "Cust_Quote_Acceptance_Status", True))
        Me.QuoteAcceptanceStatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.QuoteAcceptanceStatusComboBox.FormattingEnabled = True
        Me.QuoteAcceptanceStatusComboBox.Items.AddRange(New Object() {"N", "Y"})
        Me.QuoteAcceptanceStatusComboBox.Location = New System.Drawing.Point(151, 283)
        Me.QuoteAcceptanceStatusComboBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.QuoteAcceptanceStatusComboBox.MaxDropDownItems = 100
        Me.QuoteAcceptanceStatusComboBox.Name = "QuoteAcceptanceStatusComboBox"
        Me.QuoteAcceptanceStatusComboBox.Size = New System.Drawing.Size(46, 21)
        Me.QuoteAcceptanceStatusComboBox.TabIndex = 61
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(15, 50)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "- Customer:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(15, 145)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "- Issued by (Employee):"
        '
        'CustomerIDComboBox
        '
        Me.CustomerIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerQuoteBindingSource, "Customer_ID", True))
        Me.CustomerIDComboBox.DataSource = Me.CustomerBindingSource
        Me.CustomerIDComboBox.DisplayMember = "Customer_ID"
        Me.CustomerIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CustomerIDComboBox.FormattingEnabled = True
        Me.CustomerIDComboBox.Location = New System.Drawing.Point(135, 41)
        Me.CustomerIDComboBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CustomerIDComboBox.MaxDropDownItems = 100
        Me.CustomerIDComboBox.Name = "CustomerIDComboBox"
        Me.CustomerIDComboBox.Size = New System.Drawing.Size(35, 21)
        Me.CustomerIDComboBox.TabIndex = 59
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(15, 220)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "- Date Issued :"
        '
        'DateIssuedDateTimePicker
        '
        Me.DateIssuedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerQuoteBindingSource, "Cust_Quote_Date_Issued", True))
        Me.DateIssuedDateTimePicker.Location = New System.Drawing.Point(150, 214)
        Me.DateIssuedDateTimePicker.Name = "DateIssuedDateTimePicker"
        Me.DateIssuedDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateIssuedDateTimePicker.TabIndex = 58
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(7, 286)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(146, 13)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "- Quote Accepted as Order? :"
        Me.Label7.UseMnemonic = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.TotalPriceTextBox)
        Me.GroupBox4.Location = New System.Drawing.Point(11, 512)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(385, 58)
        Me.GroupBox4.TabIndex = 81
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "TOTAL AMOUNT in Rands:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(85, 28)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 13)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "R"
        Me.Label6.UseMnemonic = False
        '
        'TotalPriceTextBox
        '
        Me.TotalPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerQuoteBindingSource, "Cust__Quote_Total_Price", True))
        Me.TotalPriceTextBox.Location = New System.Drawing.Point(104, 25)
        Me.TotalPriceTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TotalPriceTextBox.Name = "TotalPriceTextBox"
        Me.TotalPriceTextBox.Size = New System.Drawing.Size(172, 20)
        Me.TotalPriceTextBox.TabIndex = 53
        Me.TotalPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(96, 22)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "- Quote Reference ID:"
        '
        'CustomerQuoteIDTextBox
        '
        Me.CustomerQuoteIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerQuoteBindingSource, "Cust_Quote_Reference_ID", True))
        Me.CustomerQuoteIDTextBox.Location = New System.Drawing.Point(209, 19)
        Me.CustomerQuoteIDTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CustomerQuoteIDTextBox.Name = "CustomerQuoteIDTextBox"
        Me.CustomerQuoteIDTextBox.ReadOnly = True
        Me.CustomerQuoteIDTextBox.Size = New System.Drawing.Size(78, 20)
        Me.CustomerQuoteIDTextBox.TabIndex = 39
        Me.CustomerQuoteIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ItemGroupBox
        '
        Me.ItemGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.ItemGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ItemGroupBox.Controls.Add(Me.RefreshButton)
        Me.ItemGroupBox.Controls.Add(Me.NotificationLabel)
        Me.ItemGroupBox.Controls.Add(Me.EditLineItemsButton)
        Me.ItemGroupBox.Controls.Add(Me.ItemsListGroupBox)
        Me.ItemGroupBox.Location = New System.Drawing.Point(400, 11)
        Me.ItemGroupBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ItemGroupBox.Name = "ItemGroupBox"
        Me.ItemGroupBox.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ItemGroupBox.Size = New System.Drawing.Size(848, 559)
        Me.ItemGroupBox.TabIndex = 77
        Me.ItemGroupBox.TabStop = False
        Me.ItemGroupBox.Text = "QUOTED ITEMS"
        '
        'RefreshButton
        '
        Me.RefreshButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RefreshButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.RefreshButton.FlatAppearance.BorderSize = 3
        Me.RefreshButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.RefreshButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RefreshButton.Location = New System.Drawing.Point(765, 483)
        Me.RefreshButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(79, 33)
        Me.RefreshButton.TabIndex = 80
        Me.RefreshButton.Text = "REFRESH"
        Me.RefreshButton.UseVisualStyleBackColor = False
        '
        'NotificationLabel
        '
        Me.NotificationLabel.AutoSize = True
        Me.NotificationLabel.BackColor = System.Drawing.Color.Transparent
        Me.NotificationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotificationLabel.ForeColor = System.Drawing.SystemColors.Control
        Me.NotificationLabel.Location = New System.Drawing.Point(302, 535)
        Me.NotificationLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.NotificationLabel.Name = "NotificationLabel"
        Me.NotificationLabel.Size = New System.Drawing.Size(329, 20)
        Me.NotificationLabel.TabIndex = 77
        Me.NotificationLabel.Text = "Save a Quote in order to add items to it!"
        '
        'EditLineItemsButton
        '
        Me.EditLineItemsButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EditLineItemsButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.EditLineItemsButton.FlatAppearance.BorderSize = 3
        Me.EditLineItemsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.EditLineItemsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.EditLineItemsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditLineItemsButton.Location = New System.Drawing.Point(305, 483)
        Me.EditLineItemsButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.EditLineItemsButton.Name = "EditLineItemsButton"
        Me.EditLineItemsButton.Size = New System.Drawing.Size(302, 50)
        Me.EditLineItemsButton.TabIndex = 76
        Me.EditLineItemsButton.Text = "EDIT LINE ITEMS"
        Me.EditLineItemsButton.UseVisualStyleBackColor = False
        '
        'ItemsListGroupBox
        '
        Me.ItemsListGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.ItemsListGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ItemsListGroupBox.Controls.Add(Me.CustLineItemJoinProductDataGridView)
        Me.ItemsListGroupBox.Location = New System.Drawing.Point(8, 17)
        Me.ItemsListGroupBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ItemsListGroupBox.Name = "ItemsListGroupBox"
        Me.ItemsListGroupBox.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ItemsListGroupBox.Size = New System.Drawing.Size(836, 463)
        Me.ItemsListGroupBox.TabIndex = 54
        Me.ItemsListGroupBox.TabStop = False
        Me.ItemsListGroupBox.Text = "LIST OF QUOTED ITEMS"
        '
        'CustLineItemJoinProductDataGridView
        '
        Me.CustLineItemJoinProductDataGridView.AllowUserToAddRows = False
        Me.CustLineItemJoinProductDataGridView.AllowUserToDeleteRows = False
        Me.CustLineItemJoinProductDataGridView.AutoGenerateColumns = False
        Me.CustLineItemJoinProductDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CustLineItemJoinProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustLineItemJoinProductDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductIDDataGridViewTextBoxColumn, Me.ProductNameDataGridViewTextBoxColumn, Me.ProductBrandDataGridViewTextBoxColumn, Me.CustLineItemCostPriceDataGridViewTextBoxColumn, Me.CustLineItemMarkupPercentageDataGridViewTextBoxColumn, Me.CustLineItemDiscountPercentageDataGridViewTextBoxColumn, Me.CustLineItemSaleexclVATDataGridViewTextBoxColumn, Me.CustLineItemSaleinclVATDataGridViewTextBoxColumn, Me.CustLineItemQuantityDataGridViewTextBoxColumn, Me.SupplierNameDataGridViewTextBoxColumn})
        Me.CustLineItemJoinProductDataGridView.DataSource = Me.CustLineItemJoinProductsBindingSource
        Me.CustLineItemJoinProductDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustLineItemJoinProductDataGridView.Location = New System.Drawing.Point(2, 15)
        Me.CustLineItemJoinProductDataGridView.Name = "CustLineItemJoinProductDataGridView"
        Me.CustLineItemJoinProductDataGridView.ReadOnly = True
        Me.CustLineItemJoinProductDataGridView.Size = New System.Drawing.Size(832, 446)
        Me.CustLineItemJoinProductDataGridView.TabIndex = 1
        '
        'CustLineItemJoinProductsBindingSource
        '
        Me.CustLineItemJoinProductsBindingSource.DataMember = "CustLineItemJoinProducts"
        Me.CustLineItemJoinProductsBindingSource.DataSource = Me.Group16DataSet
        '
        'Customer_QuoteTableAdapter
        '
        Me.Customer_QuoteTableAdapter.ClearBeforeFill = True
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'CustLineItemJoinProductsTableAdapter
        '
        Me.CustLineItemJoinProductsTableAdapter.ClearBeforeFill = True
        '
        'Customer_Quote_Line_ItemTableAdapter
        '
        Me.Customer_Quote_Line_ItemTableAdapter.ClearBeforeFill = True
        '
        'FKCustomerQuoteEmployeeBindingSource
        '
        Me.FKCustomerQuoteEmployeeBindingSource.DataMember = "FK_Customer_Quote_Employee"
        Me.FKCustomerQuoteEmployeeBindingSource.DataSource = Me.EmployeeBindingSource
        '
        'HelpBtn
        '
        Me.HelpBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HelpBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.HelpBtn.FlatAppearance.BorderSize = 3
        Me.HelpBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.HelpBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.HelpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HelpBtn.Location = New System.Drawing.Point(11, 581)
        Me.HelpBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.HelpBtn.Name = "HelpBtn"
        Me.HelpBtn.Size = New System.Drawing.Size(79, 33)
        Me.HelpBtn.TabIndex = 82
        Me.HelpBtn.Text = "HELP"
        Me.HelpBtn.UseVisualStyleBackColor = False
        '
        'HP1
        '
        Me.HP1.HelpNamespace = "C:\Users\pravz\Desktop\GitFolder\VOMS\M.I.S.chm"
        '
        'ProductIDDataGridViewTextBoxColumn
        '
        Me.ProductIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProductIDDataGridViewTextBoxColumn.DataPropertyName = "Product_ID"
        Me.ProductIDDataGridViewTextBoxColumn.HeaderText = "Product ID"
        Me.ProductIDDataGridViewTextBoxColumn.Name = "ProductIDDataGridViewTextBoxColumn"
        Me.ProductIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductNameDataGridViewTextBoxColumn
        '
        Me.ProductNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProductNameDataGridViewTextBoxColumn.DataPropertyName = "Product_Name"
        Me.ProductNameDataGridViewTextBoxColumn.HeaderText = "Product Name"
        Me.ProductNameDataGridViewTextBoxColumn.Name = "ProductNameDataGridViewTextBoxColumn"
        Me.ProductNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductBrandDataGridViewTextBoxColumn
        '
        Me.ProductBrandDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProductBrandDataGridViewTextBoxColumn.DataPropertyName = "Product_Brand"
        Me.ProductBrandDataGridViewTextBoxColumn.HeaderText = "Product Brand"
        Me.ProductBrandDataGridViewTextBoxColumn.Name = "ProductBrandDataGridViewTextBoxColumn"
        Me.ProductBrandDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustLineItemCostPriceDataGridViewTextBoxColumn
        '
        Me.CustLineItemCostPriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CustLineItemCostPriceDataGridViewTextBoxColumn.DataPropertyName = "Cust_Line_Item_Cost_Price"
        Me.CustLineItemCostPriceDataGridViewTextBoxColumn.HeaderText = "Cost Price"
        Me.CustLineItemCostPriceDataGridViewTextBoxColumn.Name = "CustLineItemCostPriceDataGridViewTextBoxColumn"
        Me.CustLineItemCostPriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustLineItemMarkupPercentageDataGridViewTextBoxColumn
        '
        Me.CustLineItemMarkupPercentageDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CustLineItemMarkupPercentageDataGridViewTextBoxColumn.DataPropertyName = "Cust_Line_Item_Markup_Percentage"
        Me.CustLineItemMarkupPercentageDataGridViewTextBoxColumn.HeaderText = "Markup Percentage"
        Me.CustLineItemMarkupPercentageDataGridViewTextBoxColumn.Name = "CustLineItemMarkupPercentageDataGridViewTextBoxColumn"
        Me.CustLineItemMarkupPercentageDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustLineItemDiscountPercentageDataGridViewTextBoxColumn
        '
        Me.CustLineItemDiscountPercentageDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CustLineItemDiscountPercentageDataGridViewTextBoxColumn.DataPropertyName = "Cust_Line_Item_Discount_Percentage"
        Me.CustLineItemDiscountPercentageDataGridViewTextBoxColumn.HeaderText = "Discount Percentage"
        Me.CustLineItemDiscountPercentageDataGridViewTextBoxColumn.Name = "CustLineItemDiscountPercentageDataGridViewTextBoxColumn"
        Me.CustLineItemDiscountPercentageDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustLineItemSaleexclVATDataGridViewTextBoxColumn
        '
        Me.CustLineItemSaleexclVATDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CustLineItemSaleexclVATDataGridViewTextBoxColumn.DataPropertyName = "Cust_Line_Item_Sale_excl_VAT"
        Me.CustLineItemSaleexclVATDataGridViewTextBoxColumn.HeaderText = "Sale excl VAT per Item"
        Me.CustLineItemSaleexclVATDataGridViewTextBoxColumn.Name = "CustLineItemSaleexclVATDataGridViewTextBoxColumn"
        Me.CustLineItemSaleexclVATDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustLineItemSaleinclVATDataGridViewTextBoxColumn
        '
        Me.CustLineItemSaleinclVATDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CustLineItemSaleinclVATDataGridViewTextBoxColumn.DataPropertyName = "Cust_Line_Item_Sale_incl_VAT"
        Me.CustLineItemSaleinclVATDataGridViewTextBoxColumn.HeaderText = "Sale incl VAT per Item"
        Me.CustLineItemSaleinclVATDataGridViewTextBoxColumn.Name = "CustLineItemSaleinclVATDataGridViewTextBoxColumn"
        Me.CustLineItemSaleinclVATDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustLineItemQuantityDataGridViewTextBoxColumn
        '
        Me.CustLineItemQuantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CustLineItemQuantityDataGridViewTextBoxColumn.DataPropertyName = "Cust_Line_Item_Quantity"
        Me.CustLineItemQuantityDataGridViewTextBoxColumn.HeaderText = "Item Quantity"
        Me.CustLineItemQuantityDataGridViewTextBoxColumn.Name = "CustLineItemQuantityDataGridViewTextBoxColumn"
        Me.CustLineItemQuantityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SupplierNameDataGridViewTextBoxColumn
        '
        Me.SupplierNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SupplierNameDataGridViewTextBoxColumn.DataPropertyName = "Supplier_Name"
        Me.SupplierNameDataGridViewTextBoxColumn.HeaderText = "Supplier Name"
        Me.SupplierNameDataGridViewTextBoxColumn.Name = "SupplierNameDataGridViewTextBoxColumn"
        Me.SupplierNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CreateOrEditCustomerQuote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackgroundImage = Global.M.I.S.S_Vendor_Order_Management_System.My.Resources.Resources.Background1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1259, 623)
        Me.Controls.Add(Me.HelpBtn)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.ItemGroupBox)
        Me.Controls.Add(Me.QuoteDetailsGroupBox)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.CustomerQuoteIDTextBox)
        Me.Controls.Add(Me.Label2)
        Me.DoubleBuffered = True
        Me.Name = "CreateOrEditCustomerQuote"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create/Edit Customer Quote"
        Me.QuoteDetailsGroupBox.ResumeLayout(False)
        Me.QuoteDetailsGroupBox.PerformLayout()
        CType(Me.CustomerQuoteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group16DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OptionsGroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ItemGroupBox.ResumeLayout(False)
        Me.ItemGroupBox.PerformLayout()
        Me.ItemsListGroupBox.ResumeLayout(False)
        CType(Me.CustLineItemJoinProductDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustLineItemJoinProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKCustomerQuoteEmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BackButton As Button
    Friend WithEvents QuoteDetailsGroupBox As GroupBox
    Friend WithEvents QuoteAcceptanceStatusComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DateIssuedDateTimePicker As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents CustomerQuoteIDTextBox As TextBox
    Friend WithEvents CreateCustomerButton As Button
    Friend WithEvents EmployeeInfoButton As Button
    Friend WithEvents CustomerInfoButton As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents DateAcceptedTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TotalPriceTextBox As TextBox
    Friend WithEvents OptionsGroupBox1 As GroupBox
    Friend WithEvents UpdateQuoteButton As Button
    Friend WithEvents DeleteQuoteButton As Button
    Friend WithEvents ItemGroupBox As GroupBox
    Friend WithEvents NotificationLabel As Label
    Friend WithEvents EditLineItemsButton As Button
    Friend WithEvents ItemsListGroupBox As GroupBox
    Friend WithEvents CustomerQuoteBindingSource As BindingSource
    Friend WithEvents Group16DataSet As group16DataSet
    Friend WithEvents Customer_QuoteTableAdapter As group16DataSetTableAdapters.Customer_QuoteTableAdapter
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As group16DataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents EmployeeBindingSource As BindingSource
    Friend WithEvents EmployeeTableAdapter As group16DataSetTableAdapters.EmployeeTableAdapter
    Friend WithEvents CustLineItemJoinProductsBindingSource As BindingSource
    Friend WithEvents CustLineItemJoinProductsTableAdapter As group16DataSetTableAdapters.CustLineItemJoinProductsTableAdapter
    Friend WithEvents CustLineItemJoinProductDataGridView As DataGridView
    Friend WithEvents CreateOrEditCustomerQuoteTip As ToolTip
    Friend WithEvents Customer_Quote_Line_ItemTableAdapter As group16DataSetTableAdapters.Customer_Quote_Line_ItemTableAdapter
    Friend WithEvents RefreshButton As Button
    Friend WithEvents CustomerFirstNameTextBox As TextBox
    Public WithEvents CustomerIDComboBox As ComboBox
    Public WithEvents CustomerSurnameTextBox As TextBox
    Public WithEvents EmployeeSurnameTextBox As TextBox
    Public WithEvents EmployeeFirstNameTextBox As TextBox
    Friend WithEvents FKCustomerQuoteEmployeeBindingSource As BindingSource
    Friend WithEvents EmployeeIDComboBox As ComboBox
    Friend WithEvents HelpBtn As Button
    Friend WithEvents HP1 As HelpProvider
    Friend WithEvents ProductIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductBrandDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustLineItemCostPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustLineItemMarkupPercentageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustLineItemDiscountPercentageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustLineItemSaleexclVATDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustLineItemSaleinclVATDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustLineItemQuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SupplierNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

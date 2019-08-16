<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateOrEditCustomerQuote
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
        Me.components = New System.ComponentModel.Container()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.QuoteDetailsGroupBox = New System.Windows.Forms.GroupBox()
        Me.OptionsGroupBox1 = New System.Windows.Forms.GroupBox()
        Me.UpdateQuoteButton = New System.Windows.Forms.Button()
        Me.DeleteQuoteButton = New System.Windows.Forms.Button()
        Me.DateAcceptedTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerQuoteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Group16DataSet = New M.I.S.S_Vendor_Order_Management_System.group16DataSet()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CreateCustomerButton = New System.Windows.Forms.Button()
        Me.EmployeeInfoButton = New System.Windows.Forms.Button()
        Me.CustomerInfoButton = New System.Windows.Forms.Button()
        Me.QuoteAcceptanceStatusComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EmployeeIDComboBox = New System.Windows.Forms.ComboBox()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerIDComboBox = New System.Windows.Forms.ComboBox()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.CustLineItemJoinProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Customer_QuoteTableAdapter = New M.I.S.S_Vendor_Order_Management_System.group16DataSetTableAdapters.Customer_QuoteTableAdapter()
        Me.CustomerTableAdapter = New M.I.S.S_Vendor_Order_Management_System.group16DataSetTableAdapters.CustomerTableAdapter()
        Me.EmployeeTableAdapter = New M.I.S.S_Vendor_Order_Management_System.group16DataSetTableAdapters.EmployeeTableAdapter()
        Me.CustLineItemJoinProductsTableAdapter = New M.I.S.S_Vendor_Order_Management_System.group16DataSetTableAdapters.CustLineItemJoinProductsTableAdapter()
        Me.CreateOrEditCustomerQuoteTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Customer_Quote_Line_ItemTableAdapter = New M.I.S.S_Vendor_Order_Management_System.group16DataSetTableAdapters.Customer_Quote_Line_ItemTableAdapter()
        Me.QuoteDetailsGroupBox.SuspendLayout()
        Me.OptionsGroupBox1.SuspendLayout()
        CType(Me.CustomerQuoteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group16DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.ItemGroupBox.SuspendLayout()
        Me.ItemsListGroupBox.SuspendLayout()
        CType(Me.CustLineItemJoinProductDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustLineItemJoinProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BackButton.Location = New System.Drawing.Point(1559, 715)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(105, 41)
        Me.BackButton.TabIndex = 54
        Me.BackButton.Text = "BACK"
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'QuoteDetailsGroupBox
        '
        Me.QuoteDetailsGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.QuoteDetailsGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
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
        Me.QuoteDetailsGroupBox.Controls.Add(Me.EmployeeIDComboBox)
        Me.QuoteDetailsGroupBox.Controls.Add(Me.CustomerIDComboBox)
        Me.QuoteDetailsGroupBox.Controls.Add(Me.Label4)
        Me.QuoteDetailsGroupBox.Controls.Add(Me.DateIssuedDateTimePicker)
        Me.QuoteDetailsGroupBox.Controls.Add(Me.Label7)
        Me.QuoteDetailsGroupBox.Location = New System.Drawing.Point(15, 66)
        Me.QuoteDetailsGroupBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.QuoteDetailsGroupBox.Name = "QuoteDetailsGroupBox"
        Me.QuoteDetailsGroupBox.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.QuoteDetailsGroupBox.Size = New System.Drawing.Size(513, 559)
        Me.QuoteDetailsGroupBox.TabIndex = 68
        Me.QuoteDetailsGroupBox.TabStop = False
        Me.QuoteDetailsGroupBox.Text = "CUSTOMER QUOTE DETAILS"
        '
        'OptionsGroupBox1
        '
        Me.OptionsGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.OptionsGroupBox1.Controls.Add(Me.UpdateQuoteButton)
        Me.OptionsGroupBox1.Controls.Add(Me.DeleteQuoteButton)
        Me.OptionsGroupBox1.Location = New System.Drawing.Point(24, 442)
        Me.OptionsGroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OptionsGroupBox1.Name = "OptionsGroupBox1"
        Me.OptionsGroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OptionsGroupBox1.Size = New System.Drawing.Size(469, 96)
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
        Me.UpdateQuoteButton.Location = New System.Drawing.Point(42, 21)
        Me.UpdateQuoteButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UpdateQuoteButton.Name = "UpdateQuoteButton"
        Me.UpdateQuoteButton.Size = New System.Drawing.Size(171, 62)
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
        Me.DeleteQuoteButton.Location = New System.Drawing.Point(259, 21)
        Me.DeleteQuoteButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DeleteQuoteButton.Name = "DeleteQuoteButton"
        Me.DeleteQuoteButton.Size = New System.Drawing.Size(171, 62)
        Me.DeleteQuoteButton.TabIndex = 2
        Me.DeleteQuoteButton.Text = "DELETE"
        Me.DeleteQuoteButton.UseVisualStyleBackColor = False
        '
        'DateAcceptedTextBox
        '
        Me.DateAcceptedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DateAcceptedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerQuoteBindingSource, "Cust_Quote_Date_Accepted", True))
        Me.DateAcceptedTextBox.Location = New System.Drawing.Point(283, 380)
        Me.DateAcceptedTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateAcceptedTextBox.Name = "DateAcceptedTextBox"
        Me.DateAcceptedTextBox.ReadOnly = True
        Me.DateAcceptedTextBox.Size = New System.Drawing.Size(135, 22)
        Me.DateAcceptedTextBox.TabIndex = 80
        Me.DateAcceptedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(52, 383)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(214, 17)
        Me.Label5.TabIndex = 79
        Me.Label5.Text = "- Date Accepted (YYYY/MM/DD):"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(260, 320)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 17)
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
        Me.CreateCustomerButton.Location = New System.Drawing.Point(216, 82)
        Me.CreateCustomerButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CreateCustomerButton.Name = "CreateCustomerButton"
        Me.CreateCustomerButton.Size = New System.Drawing.Size(203, 34)
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
        Me.EmployeeInfoButton.Location = New System.Drawing.Point(413, 165)
        Me.EmployeeInfoButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.EmployeeInfoButton.Name = "EmployeeInfoButton"
        Me.EmployeeInfoButton.Size = New System.Drawing.Size(41, 30)
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
        Me.CustomerInfoButton.Location = New System.Drawing.Point(413, 49)
        Me.CustomerInfoButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CustomerInfoButton.Name = "CustomerInfoButton"
        Me.CustomerInfoButton.Size = New System.Drawing.Size(41, 30)
        Me.CustomerInfoButton.TabIndex = 72
        Me.CustomerInfoButton.UseVisualStyleBackColor = False
        '
        'QuoteAcceptanceStatusComboBox
        '
        Me.QuoteAcceptanceStatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerQuoteBindingSource, "Cust_Quote_Acceptance_Status", True))
        Me.QuoteAcceptanceStatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.QuoteAcceptanceStatusComboBox.FormattingEnabled = True
        Me.QuoteAcceptanceStatusComboBox.Items.AddRange(New Object() {"N", "Y"})
        Me.QuoteAcceptanceStatusComboBox.Location = New System.Drawing.Point(216, 338)
        Me.QuoteAcceptanceStatusComboBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.QuoteAcceptanceStatusComboBox.MaxDropDownItems = 100
        Me.QuoteAcceptanceStatusComboBox.Name = "QuoteAcceptanceStatusComboBox"
        Me.QuoteAcceptanceStatusComboBox.Size = New System.Drawing.Size(201, 24)
        Me.QuoteAcceptanceStatusComboBox.TabIndex = 61
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(20, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "- Customer Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(17, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(196, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "- Issued by (Employee name):"
        '
        'EmployeeIDComboBox
        '
        Me.EmployeeIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerQuoteBindingSource, "Employee_ID", True))
        Me.EmployeeIDComboBox.DataSource = Me.EmployeeBindingSource
        Me.EmployeeIDComboBox.DisplayMember = "Employee_ID"
        Me.EmployeeIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EmployeeIDComboBox.FormattingEnabled = True
        Me.EmployeeIDComboBox.Location = New System.Drawing.Point(216, 169)
        Me.EmployeeIDComboBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.EmployeeIDComboBox.MaxDropDownItems = 100
        Me.EmployeeIDComboBox.Name = "EmployeeIDComboBox"
        Me.EmployeeIDComboBox.Size = New System.Drawing.Size(203, 24)
        Me.EmployeeIDComboBox.TabIndex = 60
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "Employee"
        Me.EmployeeBindingSource.DataSource = Me.Group16DataSet
        '
        'CustomerIDComboBox
        '
        Me.CustomerIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerQuoteBindingSource, "Customer_ID", True))
        Me.CustomerIDComboBox.DataSource = Me.CustomerBindingSource
        Me.CustomerIDComboBox.DisplayMember = "Customer_ID"
        Me.CustomerIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CustomerIDComboBox.FormattingEnabled = True
        Me.CustomerIDComboBox.Location = New System.Drawing.Point(216, 52)
        Me.CustomerIDComboBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CustomerIDComboBox.MaxDropDownItems = 100
        Me.CustomerIDComboBox.Name = "CustomerIDComboBox"
        Me.CustomerIDComboBox.Size = New System.Drawing.Size(203, 24)
        Me.CustomerIDComboBox.TabIndex = 59
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me.Group16DataSet
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(17, 252)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 17)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "- Date Issued :"
        '
        'DateIssuedDateTimePicker
        '
        Me.DateIssuedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerQuoteBindingSource, "Cust_Quote_Date_Issued", True))
        Me.DateIssuedDateTimePicker.Location = New System.Drawing.Point(216, 252)
        Me.DateIssuedDateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.DateIssuedDateTimePicker.Name = "DateIssuedDateTimePicker"
        Me.DateIssuedDateTimePicker.Size = New System.Drawing.Size(265, 22)
        Me.DateIssuedDateTimePicker.TabIndex = 58
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(17, 342)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(195, 17)
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
        Me.GroupBox4.Location = New System.Drawing.Point(15, 630)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(513, 71)
        Me.GroupBox4.TabIndex = 81
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "TOTAL AMOUNT in Rands:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(113, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 17)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "R"
        Me.Label6.UseMnemonic = False
        '
        'TotalPriceTextBox
        '
        Me.TotalPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerQuoteBindingSource, "Cust__Quote_Total_Price", True))
        Me.TotalPriceTextBox.Location = New System.Drawing.Point(139, 31)
        Me.TotalPriceTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TotalPriceTextBox.Name = "TotalPriceTextBox"
        Me.TotalPriceTextBox.Size = New System.Drawing.Size(228, 22)
        Me.TotalPriceTextBox.TabIndex = 53
        Me.TotalPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(128, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 17)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "- Quote Reference ID:"
        '
        'CustomerQuoteIDTextBox
        '
        Me.CustomerQuoteIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerQuoteBindingSource, "Cust_Quote_Reference_ID", True))
        Me.CustomerQuoteIDTextBox.Location = New System.Drawing.Point(279, 31)
        Me.CustomerQuoteIDTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CustomerQuoteIDTextBox.Name = "CustomerQuoteIDTextBox"
        Me.CustomerQuoteIDTextBox.ReadOnly = True
        Me.CustomerQuoteIDTextBox.Size = New System.Drawing.Size(103, 22)
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
        Me.ItemGroupBox.Location = New System.Drawing.Point(533, 14)
        Me.ItemGroupBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ItemGroupBox.Name = "ItemGroupBox"
        Me.ItemGroupBox.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ItemGroupBox.Size = New System.Drawing.Size(1131, 688)
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
        Me.RefreshButton.Location = New System.Drawing.Point(1020, 595)
        Me.RefreshButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(105, 41)
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
        Me.NotificationLabel.Location = New System.Drawing.Point(402, 658)
        Me.NotificationLabel.Name = "NotificationLabel"
        Me.NotificationLabel.Size = New System.Drawing.Size(395, 25)
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
        Me.EditLineItemsButton.Location = New System.Drawing.Point(407, 594)
        Me.EditLineItemsButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.EditLineItemsButton.Name = "EditLineItemsButton"
        Me.EditLineItemsButton.Size = New System.Drawing.Size(403, 62)
        Me.EditLineItemsButton.TabIndex = 76
        Me.EditLineItemsButton.Text = "EDIT LINE ITEMS"
        Me.EditLineItemsButton.UseVisualStyleBackColor = False
        '
        'ItemsListGroupBox
        '
        Me.ItemsListGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.ItemsListGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ItemsListGroupBox.Controls.Add(Me.CustLineItemJoinProductDataGridView)
        Me.ItemsListGroupBox.Location = New System.Drawing.Point(11, 21)
        Me.ItemsListGroupBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ItemsListGroupBox.Name = "ItemsListGroupBox"
        Me.ItemsListGroupBox.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ItemsListGroupBox.Size = New System.Drawing.Size(1115, 570)
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
        Me.CustLineItemJoinProductDataGridView.Location = New System.Drawing.Point(3, 17)
        Me.CustLineItemJoinProductDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.CustLineItemJoinProductDataGridView.Name = "CustLineItemJoinProductDataGridView"
        Me.CustLineItemJoinProductDataGridView.ReadOnly = True
        Me.CustLineItemJoinProductDataGridView.Size = New System.Drawing.Size(1109, 551)
        Me.CustLineItemJoinProductDataGridView.TabIndex = 1
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
        Me.CustLineItemSaleexclVATDataGridViewTextBoxColumn.HeaderText = "Sale excl VAT"
        Me.CustLineItemSaleexclVATDataGridViewTextBoxColumn.Name = "CustLineItemSaleexclVATDataGridViewTextBoxColumn"
        Me.CustLineItemSaleexclVATDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustLineItemSaleinclVATDataGridViewTextBoxColumn
        '
        Me.CustLineItemSaleinclVATDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CustLineItemSaleinclVATDataGridViewTextBoxColumn.DataPropertyName = "Cust_Line_Item_Sale_incl_VAT"
        Me.CustLineItemSaleinclVATDataGridViewTextBoxColumn.HeaderText = "Sale incl VAT"
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
        'CreateOrEditCustomerQuote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.M.I.S.S_Vendor_Order_Management_System.My.Resources.Resources.Background1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1679, 767)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.ItemGroupBox)
        Me.Controls.Add(Me.QuoteDetailsGroupBox)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.CustomerQuoteIDTextBox)
        Me.Controls.Add(Me.Label2)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CreateOrEditCustomerQuote"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create/Edit Customer Quote"
        Me.QuoteDetailsGroupBox.ResumeLayout(False)
        Me.QuoteDetailsGroupBox.PerformLayout()
        Me.OptionsGroupBox1.ResumeLayout(False)
        CType(Me.CustomerQuoteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group16DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ItemGroupBox.ResumeLayout(False)
        Me.ItemGroupBox.PerformLayout()
        Me.ItemsListGroupBox.ResumeLayout(False)
        CType(Me.CustLineItemJoinProductDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustLineItemJoinProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BackButton As Button
    Friend WithEvents QuoteDetailsGroupBox As GroupBox
    Friend WithEvents QuoteAcceptanceStatusComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents EmployeeIDComboBox As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CustomerIDComboBox As ComboBox
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
    Friend WithEvents CreateOrEditCustomerQuoteTip As ToolTip
    Friend WithEvents Customer_Quote_Line_ItemTableAdapter As group16DataSetTableAdapters.Customer_Quote_Line_ItemTableAdapter
    Friend WithEvents RefreshButton As Button
End Class

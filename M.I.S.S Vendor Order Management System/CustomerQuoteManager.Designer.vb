<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerQuoteManager
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.ViewButton = New System.Windows.Forms.Button()
        Me.CreateButton = New System.Windows.Forms.Button()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.LogOutButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.CustLineItemJoinProductDataGridView = New System.Windows.Forms.DataGridView()
        Me.ProductIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductBrandDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductDescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductActiveStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustLineItemCostPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustLineItemMarkupPercentageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustLineItemDiscountPercentageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustLineItemQuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustLineItemSaleinclVATDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustLineItemSaleexclVATDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustLineItemJoinProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Group16DataSet = New M.I.S.S_Vendor_Order_Management_System.group16DataSet()
        Me.CustomerQuoteJoinCustomerDataGridView = New System.Windows.Forms.DataGridView()
        Me.CustQuoteReferenceIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustQuoteTotalPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustQuoteDateIssuedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustQuoteAcceptanceStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustQuoteDateAcceptedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustFNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustSNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeFNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeSNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerQuoteJoinCustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NavigationGroupBox = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SortButton = New System.Windows.Forms.Button()
        Me.SortComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.SearchComboBox = New System.Windows.Forms.ComboBox()
        Me.CustomerQuoteJoinCustomerTableAdapter = New M.I.S.S_Vendor_Order_Management_System.group16DataSetTableAdapters.CustomerQuoteJoinCustomerTableAdapter()
        Me.CustLineItemJoinProductsTableAdapter = New M.I.S.S_Vendor_Order_Management_System.group16DataSetTableAdapters.CustLineItemJoinProductsTableAdapter()
        Me.HelpBtn = New System.Windows.Forms.Button()
        Me.CustomerQuoteManagerTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.CustLineItemJoinProductDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustLineItemJoinProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group16DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerQuoteJoinCustomerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerQuoteJoinCustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavigationGroupBox.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox2.Controls.Add(Me.EditButton)
        Me.GroupBox2.Controls.Add(Me.ViewButton)
        Me.GroupBox2.Controls.Add(Me.CreateButton)
        Me.GroupBox2.Controls.Add(Me.RefreshButton)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 736)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(1585, 75)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "OPTIONS"
        '
        'EditButton
        '
        Me.EditButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EditButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EditButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.EditButton.FlatAppearance.BorderSize = 3
        Me.EditButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.EditButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditButton.Location = New System.Drawing.Point(875, 21)
        Me.EditButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(265, 41)
        Me.EditButton.TabIndex = 51
        Me.EditButton.Text = "EDIT QUOTE"
        Me.EditButton.UseVisualStyleBackColor = False
        '
        'ViewButton
        '
        Me.ViewButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ViewButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ViewButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ViewButton.FlatAppearance.BorderSize = 3
        Me.ViewButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.ViewButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.ViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ViewButton.Location = New System.Drawing.Point(6, 19)
        Me.ViewButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ViewButton.Name = "ViewButton"
        Me.ViewButton.Size = New System.Drawing.Size(265, 41)
        Me.ViewButton.TabIndex = 8
        Me.ViewButton.Text = "VIEW QUOTE"
        Me.ViewButton.UseVisualStyleBackColor = False
        '
        'CreateButton
        '
        Me.CreateButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CreateButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CreateButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.CreateButton.FlatAppearance.BorderSize = 3
        Me.CreateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.CreateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.CreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CreateButton.Location = New System.Drawing.Point(446, 21)
        Me.CreateButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CreateButton.Name = "CreateButton"
        Me.CreateButton.Size = New System.Drawing.Size(265, 41)
        Me.CreateButton.TabIndex = 7
        Me.CreateButton.Text = "CREATE NEW CUSTOMER QUOTE"
        Me.CreateButton.UseVisualStyleBackColor = False
        '
        'RefreshButton
        '
        Me.RefreshButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RefreshButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RefreshButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.RefreshButton.FlatAppearance.BorderSize = 3
        Me.RefreshButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.RefreshButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RefreshButton.Location = New System.Drawing.Point(1313, 19)
        Me.RefreshButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(265, 41)
        Me.RefreshButton.TabIndex = 5
        Me.RefreshButton.Text = "REFRESH"
        Me.RefreshButton.UseVisualStyleBackColor = False
        '
        'LogOutButton
        '
        Me.LogOutButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogOutButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LogOutButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.LogOutButton.FlatAppearance.BorderSize = 3
        Me.LogOutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.LogOutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.LogOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogOutButton.Location = New System.Drawing.Point(13, 816)
        Me.LogOutButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LogOutButton.Name = "LogOutButton"
        Me.LogOutButton.Size = New System.Drawing.Size(105, 44)
        Me.LogOutButton.TabIndex = 39
        Me.LogOutButton.Text = "LOG OUT"
        Me.LogOutButton.UseVisualStyleBackColor = False
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BackButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BackButton.FlatAppearance.BorderSize = 3
        Me.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.BackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Location = New System.Drawing.Point(1513, 816)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(85, 44)
        Me.BackButton.TabIndex = 38
        Me.BackButton.Text = "BACK"
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.CustomerQuoteJoinCustomerDataGridView)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 148)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(1585, 583)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CUSTOMER QUOTES"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox4.Controls.Add(Me.CustLineItemJoinProductDataGridView)
        Me.GroupBox4.Location = New System.Drawing.Point(27, 334)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(1524, 245)
        Me.GroupBox4.TabIndex = 55
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "LIST OF LINE ITEMS IN CUSTOMER QUOTE:"
        '
        'CustLineItemJoinProductDataGridView
        '
        Me.CustLineItemJoinProductDataGridView.AllowUserToAddRows = False
        Me.CustLineItemJoinProductDataGridView.AllowUserToDeleteRows = False
        Me.CustLineItemJoinProductDataGridView.AutoGenerateColumns = False
        Me.CustLineItemJoinProductDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CustLineItemJoinProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustLineItemJoinProductDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductIDDataGridViewTextBoxColumn, Me.ProductNameDataGridViewTextBoxColumn, Me.ProductBrandDataGridViewTextBoxColumn, Me.ProductDescriptionDataGridViewTextBoxColumn, Me.ProductActiveStatusDataGridViewTextBoxColumn, Me.CustLineItemCostPriceDataGridViewTextBoxColumn, Me.CustLineItemMarkupPercentageDataGridViewTextBoxColumn, Me.CustLineItemDiscountPercentageDataGridViewTextBoxColumn, Me.CustLineItemQuantityDataGridViewTextBoxColumn, Me.CustLineItemSaleinclVATDataGridViewTextBoxColumn, Me.CustLineItemSaleexclVATDataGridViewTextBoxColumn, Me.SupplierNameDataGridViewTextBoxColumn})
        Me.CustLineItemJoinProductDataGridView.DataSource = Me.CustLineItemJoinProductsBindingSource
        Me.CustLineItemJoinProductDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustLineItemJoinProductDataGridView.Location = New System.Drawing.Point(3, 17)
        Me.CustLineItemJoinProductDataGridView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CustLineItemJoinProductDataGridView.Name = "CustLineItemJoinProductDataGridView"
        Me.CustLineItemJoinProductDataGridView.ReadOnly = True
        Me.CustLineItemJoinProductDataGridView.Size = New System.Drawing.Size(1518, 226)
        Me.CustLineItemJoinProductDataGridView.TabIndex = 0
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
        'ProductDescriptionDataGridViewTextBoxColumn
        '
        Me.ProductDescriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProductDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Product_Description"
        Me.ProductDescriptionDataGridViewTextBoxColumn.HeaderText = "Product Description"
        Me.ProductDescriptionDataGridViewTextBoxColumn.Name = "ProductDescriptionDataGridViewTextBoxColumn"
        Me.ProductDescriptionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductActiveStatusDataGridViewTextBoxColumn
        '
        Me.ProductActiveStatusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProductActiveStatusDataGridViewTextBoxColumn.DataPropertyName = "Product_Active_Status"
        Me.ProductActiveStatusDataGridViewTextBoxColumn.HeaderText = "Product Active Status"
        Me.ProductActiveStatusDataGridViewTextBoxColumn.Name = "ProductActiveStatusDataGridViewTextBoxColumn"
        Me.ProductActiveStatusDataGridViewTextBoxColumn.ReadOnly = True
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
        'CustLineItemQuantityDataGridViewTextBoxColumn
        '
        Me.CustLineItemQuantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CustLineItemQuantityDataGridViewTextBoxColumn.DataPropertyName = "Cust_Line_Item_Quantity"
        Me.CustLineItemQuantityDataGridViewTextBoxColumn.HeaderText = "Item Quantity"
        Me.CustLineItemQuantityDataGridViewTextBoxColumn.Name = "CustLineItemQuantityDataGridViewTextBoxColumn"
        Me.CustLineItemQuantityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustLineItemSaleinclVATDataGridViewTextBoxColumn
        '
        Me.CustLineItemSaleinclVATDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CustLineItemSaleinclVATDataGridViewTextBoxColumn.DataPropertyName = "Cust_Line_Item_Sale_incl_VAT"
        Me.CustLineItemSaleinclVATDataGridViewTextBoxColumn.HeaderText = "Sale incl VAT"
        Me.CustLineItemSaleinclVATDataGridViewTextBoxColumn.Name = "CustLineItemSaleinclVATDataGridViewTextBoxColumn"
        Me.CustLineItemSaleinclVATDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustLineItemSaleexclVATDataGridViewTextBoxColumn
        '
        Me.CustLineItemSaleexclVATDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CustLineItemSaleexclVATDataGridViewTextBoxColumn.DataPropertyName = "Cust_Line_Item_Sale_excl_VAT"
        Me.CustLineItemSaleexclVATDataGridViewTextBoxColumn.HeaderText = "Sale excl VAT"
        Me.CustLineItemSaleexclVATDataGridViewTextBoxColumn.Name = "CustLineItemSaleexclVATDataGridViewTextBoxColumn"
        Me.CustLineItemSaleexclVATDataGridViewTextBoxColumn.ReadOnly = True
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
        'Group16DataSet
        '
        Me.Group16DataSet.DataSetName = "group16DataSet"
        Me.Group16DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerQuoteJoinCustomerDataGridView
        '
        Me.CustomerQuoteJoinCustomerDataGridView.AllowUserToAddRows = False
        Me.CustomerQuoteJoinCustomerDataGridView.AllowUserToDeleteRows = False
        Me.CustomerQuoteJoinCustomerDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CustomerQuoteJoinCustomerDataGridView.AutoGenerateColumns = False
        Me.CustomerQuoteJoinCustomerDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CustomerQuoteJoinCustomerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomerQuoteJoinCustomerDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustQuoteReferenceIDDataGridViewTextBoxColumn, Me.CustQuoteTotalPriceDataGridViewTextBoxColumn, Me.CustQuoteDateIssuedDataGridViewTextBoxColumn, Me.CustQuoteAcceptanceStatusDataGridViewTextBoxColumn, Me.CustQuoteDateAcceptedDataGridViewTextBoxColumn, Me.CustomerIDDataGridViewTextBoxColumn, Me.CustFNameDataGridViewTextBoxColumn, Me.CustSNameDataGridViewTextBoxColumn, Me.EmployeeIDDataGridViewTextBoxColumn, Me.EmployeeFNameDataGridViewTextBoxColumn, Me.EmployeeSNameDataGridViewTextBoxColumn})
        Me.CustomerQuoteJoinCustomerDataGridView.DataSource = Me.CustomerQuoteJoinCustomerBindingSource
        Me.CustomerQuoteJoinCustomerDataGridView.Location = New System.Drawing.Point(5, 21)
        Me.CustomerQuoteJoinCustomerDataGridView.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CustomerQuoteJoinCustomerDataGridView.Name = "CustomerQuoteJoinCustomerDataGridView"
        Me.CustomerQuoteJoinCustomerDataGridView.ReadOnly = True
        Me.CustomerQuoteJoinCustomerDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.CustomerQuoteJoinCustomerDataGridView.RowTemplate.Height = 24
        Me.CustomerQuoteJoinCustomerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CustomerQuoteJoinCustomerDataGridView.Size = New System.Drawing.Size(1573, 308)
        Me.CustomerQuoteJoinCustomerDataGridView.TabIndex = 0
        '
        'CustQuoteReferenceIDDataGridViewTextBoxColumn
        '
        Me.CustQuoteReferenceIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CustQuoteReferenceIDDataGridViewTextBoxColumn.DataPropertyName = "Cust_Quote_Reference_ID"
        Me.CustQuoteReferenceIDDataGridViewTextBoxColumn.HeaderText = "Reference_ID"
        Me.CustQuoteReferenceIDDataGridViewTextBoxColumn.Name = "CustQuoteReferenceIDDataGridViewTextBoxColumn"
        Me.CustQuoteReferenceIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustQuoteTotalPriceDataGridViewTextBoxColumn
        '
        Me.CustQuoteTotalPriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CustQuoteTotalPriceDataGridViewTextBoxColumn.DataPropertyName = "Cust__Quote_Total_Price"
        Me.CustQuoteTotalPriceDataGridViewTextBoxColumn.HeaderText = "Total Price"
        Me.CustQuoteTotalPriceDataGridViewTextBoxColumn.Name = "CustQuoteTotalPriceDataGridViewTextBoxColumn"
        Me.CustQuoteTotalPriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustQuoteDateIssuedDataGridViewTextBoxColumn
        '
        Me.CustQuoteDateIssuedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CustQuoteDateIssuedDataGridViewTextBoxColumn.DataPropertyName = "Cust_Quote_Date_Issued"
        Me.CustQuoteDateIssuedDataGridViewTextBoxColumn.HeaderText = "Date Issued"
        Me.CustQuoteDateIssuedDataGridViewTextBoxColumn.Name = "CustQuoteDateIssuedDataGridViewTextBoxColumn"
        Me.CustQuoteDateIssuedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustQuoteAcceptanceStatusDataGridViewTextBoxColumn
        '
        Me.CustQuoteAcceptanceStatusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CustQuoteAcceptanceStatusDataGridViewTextBoxColumn.DataPropertyName = "Cust_Quote_Acceptance_Status"
        Me.CustQuoteAcceptanceStatusDataGridViewTextBoxColumn.HeaderText = "Acceptance Status"
        Me.CustQuoteAcceptanceStatusDataGridViewTextBoxColumn.Name = "CustQuoteAcceptanceStatusDataGridViewTextBoxColumn"
        Me.CustQuoteAcceptanceStatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustQuoteDateAcceptedDataGridViewTextBoxColumn
        '
        Me.CustQuoteDateAcceptedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CustQuoteDateAcceptedDataGridViewTextBoxColumn.DataPropertyName = "Cust_Quote_Date_Accepted"
        Me.CustQuoteDateAcceptedDataGridViewTextBoxColumn.HeaderText = "Date Accepted"
        Me.CustQuoteDateAcceptedDataGridViewTextBoxColumn.Name = "CustQuoteDateAcceptedDataGridViewTextBoxColumn"
        Me.CustQuoteDateAcceptedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustomerIDDataGridViewTextBoxColumn
        '
        Me.CustomerIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CustomerIDDataGridViewTextBoxColumn.DataPropertyName = "Customer_ID"
        Me.CustomerIDDataGridViewTextBoxColumn.HeaderText = "Customer ID"
        Me.CustomerIDDataGridViewTextBoxColumn.Name = "CustomerIDDataGridViewTextBoxColumn"
        Me.CustomerIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustFNameDataGridViewTextBoxColumn
        '
        Me.CustFNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CustFNameDataGridViewTextBoxColumn.DataPropertyName = "Cust_FName"
        Me.CustFNameDataGridViewTextBoxColumn.HeaderText = "Customer First Name"
        Me.CustFNameDataGridViewTextBoxColumn.Name = "CustFNameDataGridViewTextBoxColumn"
        Me.CustFNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustSNameDataGridViewTextBoxColumn
        '
        Me.CustSNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CustSNameDataGridViewTextBoxColumn.DataPropertyName = "Cust_SName"
        Me.CustSNameDataGridViewTextBoxColumn.HeaderText = "Customer Surname"
        Me.CustSNameDataGridViewTextBoxColumn.Name = "CustSNameDataGridViewTextBoxColumn"
        Me.CustSNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmployeeIDDataGridViewTextBoxColumn
        '
        Me.EmployeeIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EmployeeIDDataGridViewTextBoxColumn.DataPropertyName = "Employee_ID"
        Me.EmployeeIDDataGridViewTextBoxColumn.HeaderText = "Employee ID"
        Me.EmployeeIDDataGridViewTextBoxColumn.Name = "EmployeeIDDataGridViewTextBoxColumn"
        Me.EmployeeIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmployeeFNameDataGridViewTextBoxColumn
        '
        Me.EmployeeFNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EmployeeFNameDataGridViewTextBoxColumn.DataPropertyName = "Employee_FName"
        Me.EmployeeFNameDataGridViewTextBoxColumn.HeaderText = "Employee First Name"
        Me.EmployeeFNameDataGridViewTextBoxColumn.Name = "EmployeeFNameDataGridViewTextBoxColumn"
        Me.EmployeeFNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmployeeSNameDataGridViewTextBoxColumn
        '
        Me.EmployeeSNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EmployeeSNameDataGridViewTextBoxColumn.DataPropertyName = "Employee_SName"
        Me.EmployeeSNameDataGridViewTextBoxColumn.HeaderText = "Employee Surname"
        Me.EmployeeSNameDataGridViewTextBoxColumn.Name = "EmployeeSNameDataGridViewTextBoxColumn"
        Me.EmployeeSNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustomerQuoteJoinCustomerBindingSource
        '
        Me.CustomerQuoteJoinCustomerBindingSource.DataMember = "CustomerQuoteJoinCustomer"
        Me.CustomerQuoteJoinCustomerBindingSource.DataSource = Me.Group16DataSet
        '
        'NavigationGroupBox
        '
        Me.NavigationGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.NavigationGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NavigationGroupBox.Controls.Add(Me.GroupBox5)
        Me.NavigationGroupBox.Controls.Add(Me.GroupBox3)
        Me.NavigationGroupBox.Location = New System.Drawing.Point(15, 14)
        Me.NavigationGroupBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NavigationGroupBox.Name = "NavigationGroupBox"
        Me.NavigationGroupBox.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NavigationGroupBox.Size = New System.Drawing.Size(1584, 129)
        Me.NavigationGroupBox.TabIndex = 36
        Me.NavigationGroupBox.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.SortButton)
        Me.GroupBox5.Controls.Add(Me.SortComboBox)
        Me.GroupBox5.Location = New System.Drawing.Point(797, 21)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox5.Size = New System.Drawing.Size(752, 92)
        Me.GroupBox5.TabIndex = 102
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "SORT OPTIONS"
        '
        'Label3
        '
        Me.Label3.AccessibleName = "SortButton"
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(241, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 17)
        Me.Label3.TabIndex = 102
        Me.Label3.Text = "Sort Criteria"
        '
        'SortButton
        '
        Me.SortButton.AccessibleName = ""
        Me.SortButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SortButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SortButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.SortButton.FlatAppearance.BorderSize = 3
        Me.SortButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.SortButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.SortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SortButton.Location = New System.Drawing.Point(447, 36)
        Me.SortButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SortButton.Name = "SortButton"
        Me.SortButton.Size = New System.Drawing.Size(133, 41)
        Me.SortButton.TabIndex = 101
        Me.SortButton.Text = "SORT"
        Me.SortButton.UseVisualStyleBackColor = False
        '
        'SortComboBox
        '
        Me.SortComboBox.AccessibleName = "SortButton"
        Me.SortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SortComboBox.FormattingEnabled = True
        Me.SortComboBox.Items.AddRange(New Object() {"Show only Accepted Quotes", "Show only Non-Accepted Quotes", "Date Quote was Issued", "Customer Name (Alphabetical Order)", "Employee Name (Alphabetical Order)"})
        Me.SortComboBox.Location = New System.Drawing.Point(147, 43)
        Me.SortComboBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SortComboBox.MaxDropDownItems = 100
        Me.SortComboBox.Name = "SortComboBox"
        Me.SortComboBox.Size = New System.Drawing.Size(276, 24)
        Me.SortComboBox.TabIndex = 100
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.SearchButton)
        Me.GroupBox3.Controls.Add(Me.SearchTextBox)
        Me.GroupBox3.Controls.Add(Me.SearchComboBox)
        Me.GroupBox3.Location = New System.Drawing.Point(45, 21)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(747, 92)
        Me.GroupBox3.TabIndex = 35
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "SEARCH OPTIONS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(120, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(171, 17)
        Me.Label4.TabIndex = 101
        Me.Label4.Text = "Enter text to be searched:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(396, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 17)
        Me.Label1.TabIndex = 100
        Me.Label1.Text = "Search Criteria"
        '
        'SearchButton
        '
        Me.SearchButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SearchButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SearchButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.SearchButton.FlatAppearance.BorderSize = 3
        Me.SearchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.SearchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchButton.Location = New System.Drawing.Point(549, 34)
        Me.SearchButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(133, 41)
        Me.SearchButton.TabIndex = 99
        Me.SearchButton.Text = "SEARCH"
        Me.SearchButton.UseVisualStyleBackColor = False
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Location = New System.Drawing.Point(48, 44)
        Me.SearchTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(297, 22)
        Me.SearchTextBox.TabIndex = 93
        '
        'SearchComboBox
        '
        Me.SearchComboBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SearchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SearchComboBox.FormattingEnabled = True
        Me.SearchComboBox.Items.AddRange(New Object() {"Quote Reference ID", "Employee ID", "Employee Name", "Customer ID", "Customer Name"})
        Me.SearchComboBox.Location = New System.Drawing.Point(352, 43)
        Me.SearchComboBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SearchComboBox.MaxDropDownItems = 100
        Me.SearchComboBox.Name = "SearchComboBox"
        Me.SearchComboBox.Size = New System.Drawing.Size(191, 24)
        Me.SearchComboBox.TabIndex = 98
        '
        'CustomerQuoteJoinCustomerTableAdapter
        '
        Me.CustomerQuoteJoinCustomerTableAdapter.ClearBeforeFill = True
        '
        'CustLineItemJoinProductsTableAdapter
        '
        Me.CustLineItemJoinProductsTableAdapter.ClearBeforeFill = True
        '
        'HelpBtn
        '
        Me.HelpBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HelpBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HelpBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.HelpBtn.FlatAppearance.BorderSize = 3
        Me.HelpBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.HelpBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.HelpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HelpBtn.Location = New System.Drawing.Point(756, 816)
        Me.HelpBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.HelpBtn.Name = "HelpBtn"
        Me.HelpBtn.Size = New System.Drawing.Size(105, 44)
        Me.HelpBtn.TabIndex = 41
        Me.HelpBtn.Text = "HELP"
        Me.HelpBtn.UseVisualStyleBackColor = False
        '
        'CustomerQuoteManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.M.I.S.S_Vendor_Order_Management_System.My.Resources.Resources.Background1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1613, 879)
        Me.Controls.Add(Me.HelpBtn)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.LogOutButton)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.NavigationGroupBox)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "CustomerQuoteManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Quote Manager"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.CustLineItemJoinProductDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustLineItemJoinProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group16DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerQuoteJoinCustomerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerQuoteJoinCustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavigationGroupBox.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents EditButton As Button
    Friend WithEvents ViewButton As Button
    Friend WithEvents CreateButton As Button
    Friend WithEvents RefreshButton As Button
    Friend WithEvents LogOutButton As Button
    Friend WithEvents BackButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents CustLineItemJoinProductDataGridView As DataGridView
    Friend WithEvents CustomerQuoteJoinCustomerDataGridView As DataGridView
    Friend WithEvents NavigationGroupBox As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents SortButton As Button
    Friend WithEvents SortComboBox As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SearchButton As Button
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents SearchComboBox As ComboBox
    Friend WithEvents CustomerQuoteJoinCustomerBindingSource As BindingSource
    Friend WithEvents Group16DataSet As group16DataSet
    Friend WithEvents CustomerQuoteJoinCustomerTableAdapter As group16DataSetTableAdapters.CustomerQuoteJoinCustomerTableAdapter
    Friend WithEvents CustQuoteReferenceIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustQuoteTotalPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustQuoteDateIssuedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustQuoteAcceptanceStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustQuoteDateAcceptedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustFNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustSNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeFNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeSNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustLineItemJoinProductsBindingSource As BindingSource
    Friend WithEvents CustLineItemJoinProductsTableAdapter As group16DataSetTableAdapters.CustLineItemJoinProductsTableAdapter
    Friend WithEvents ProductIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductBrandDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductDescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductActiveStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustLineItemCostPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustLineItemMarkupPercentageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustLineItemDiscountPercentageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustLineItemQuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustLineItemSaleinclVATDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustLineItemSaleexclVATDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SupplierNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HelpBtn As Button
    Friend WithEvents CustomerQuoteManagerTip As ToolTip
End Class

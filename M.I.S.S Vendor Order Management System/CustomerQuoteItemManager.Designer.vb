<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerQuoteItemManager
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.SuppLineItemDataGridView = New System.Windows.Forms.DataGridView()
        Me.SuppQuoteReferenceIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductBrandDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductDescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuppLineItemCostPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuppLineItemQuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductActiveStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddLineItem = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.SuppLineItemJoinProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Group16DataSet = New M.I.S.S_Vendor_Order_Management_System.group16DataSet()
        Me.SupplierQuoteDataGridView = New System.Windows.Forms.DataGridView()
        Me.SuppQuoteReferenceIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuppQuoteTotalPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierRepFNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierActiveStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierRepSNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuppQuoteDateRecievedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuppQuoteAcceptanceStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuppQuoteDateAcceptanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierQuoteJoinSupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierQuoteJoinSupplierTableAdapter = New M.I.S.S_Vendor_Order_Management_System.group16DataSetTableAdapters.SupplierQuoteJoinSupplierTableAdapter()
        Me.SuppQuoteJoinSuppLineItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SuppQuoteJoinSuppLineItemTableAdapter = New M.I.S.S_Vendor_Order_Management_System.group16DataSetTableAdapters.SuppQuoteJoinSuppLineItemTableAdapter()
        Me.SuppLineItemJoinProductTableAdapter = New M.I.S.S_Vendor_Order_Management_System.group16DataSetTableAdapters.SuppLineItemJoinProductTableAdapter()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CustQuoteLineItemDataGridView = New System.Windows.Forms.DataGridView()
        Me.CustLineItemJoinProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustLineItemJoinProductsTableAdapter = New M.I.S.S_Vendor_Order_Management_System.group16DataSetTableAdapters.CustLineItemJoinProductsTableAdapter()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.Cust_Quote_Reference_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Product_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Product_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Product_Brand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Supplier_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Supplier_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cust_Line_Item_Cost_Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cust_Line_Item_Markup_Percentage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cust_Line_Item_Discount_Percentage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cust_Line_Item_Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cust_Line_Item_Sale_incl_VAT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cust_Line_Item_Sale_excl_VAT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Product_Active_Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Edit_Item = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridViewButtonColumn1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ProductIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustQuoteReferenceIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustLineItemCostPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustLineItemSaleinclVATDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustLineItemSaleexclVATDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustLineItemMarkupPercentageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustLineItemDiscountPercentageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustLineItemQuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductBrandDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductDescriptionDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductActiveStatusDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.SuppLineItemDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuppLineItemJoinProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group16DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierQuoteDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierQuoteJoinSupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuppQuoteJoinSuppLineItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.CustQuoteLineItemDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustLineItemJoinProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ClearButton)
        Me.GroupBox1.Controls.Add(Me.SearchTextBox)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.SupplierQuoteDataGridView)
        Me.GroupBox1.Location = New System.Drawing.Point(98, 264)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(1085, 409)
        Me.GroupBox1.TabIndex = 77
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ADD ITEMS FROM SUPPLIER QUOTES"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(390, 18)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 13)
        Me.Label4.TabIndex = 109
        Me.Label4.Text = " Enter Supplier Name to be searched:"
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClearButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ClearButton.FlatAppearance.BorderSize = 3
        Me.ClearButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.ClearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearButton.Location = New System.Drawing.Point(605, 27)
        Me.ClearButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(96, 34)
        Me.ClearButton.TabIndex = 108
        Me.ClearButton.Text = "CLEAR TEXT"
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Location = New System.Drawing.Point(371, 35)
        Me.SearchTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(215, 20)
        Me.SearchTextBox.TabIndex = 107
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox4.Controls.Add(Me.SuppLineItemDataGridView)
        Me.GroupBox4.Location = New System.Drawing.Point(75, 205)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(948, 198)
        Me.GroupBox4.TabIndex = 55
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "ADD SUPPLIER ITEMS TO CUSTOMER QUOTE"
        '
        'SuppLineItemDataGridView
        '
        Me.SuppLineItemDataGridView.AllowUserToAddRows = False
        Me.SuppLineItemDataGridView.AllowUserToDeleteRows = False
        Me.SuppLineItemDataGridView.AutoGenerateColumns = False
        Me.SuppLineItemDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SuppLineItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SuppLineItemDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SuppQuoteReferenceIDDataGridViewTextBoxColumn1, Me.ProductIDDataGridViewTextBoxColumn, Me.ProductNameDataGridViewTextBoxColumn, Me.ProductBrandDataGridViewTextBoxColumn, Me.ProductDescriptionDataGridViewTextBoxColumn, Me.SuppLineItemCostPriceDataGridViewTextBoxColumn, Me.SuppLineItemQuantityDataGridViewTextBoxColumn, Me.ProductActiveStatusDataGridViewTextBoxColumn, Me.AddLineItem})
        Me.SuppLineItemDataGridView.DataSource = Me.SuppLineItemJoinProductBindingSource
        Me.SuppLineItemDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuppLineItemDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.SuppLineItemDataGridView.Location = New System.Drawing.Point(2, 15)
        Me.SuppLineItemDataGridView.Name = "SuppLineItemDataGridView"
        Me.SuppLineItemDataGridView.ReadOnly = True
        Me.SuppLineItemDataGridView.Size = New System.Drawing.Size(944, 181)
        Me.SuppLineItemDataGridView.TabIndex = 0
        '
        'SuppQuoteReferenceIDDataGridViewTextBoxColumn1
        '
        Me.SuppQuoteReferenceIDDataGridViewTextBoxColumn1.DataPropertyName = "Supp_Quote_Reference_ID"
        Me.SuppQuoteReferenceIDDataGridViewTextBoxColumn1.HeaderText = "Quote Ref ID"
        Me.SuppQuoteReferenceIDDataGridViewTextBoxColumn1.Name = "SuppQuoteReferenceIDDataGridViewTextBoxColumn1"
        Me.SuppQuoteReferenceIDDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ProductIDDataGridViewTextBoxColumn
        '
        Me.ProductIDDataGridViewTextBoxColumn.DataPropertyName = "Product_ID"
        Me.ProductIDDataGridViewTextBoxColumn.HeaderText = "Product ID"
        Me.ProductIDDataGridViewTextBoxColumn.Name = "ProductIDDataGridViewTextBoxColumn"
        Me.ProductIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductNameDataGridViewTextBoxColumn
        '
        Me.ProductNameDataGridViewTextBoxColumn.DataPropertyName = "Product_Name"
        Me.ProductNameDataGridViewTextBoxColumn.HeaderText = "Product Name"
        Me.ProductNameDataGridViewTextBoxColumn.Name = "ProductNameDataGridViewTextBoxColumn"
        Me.ProductNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductBrandDataGridViewTextBoxColumn
        '
        Me.ProductBrandDataGridViewTextBoxColumn.DataPropertyName = "Product_Brand"
        Me.ProductBrandDataGridViewTextBoxColumn.HeaderText = "Brand"
        Me.ProductBrandDataGridViewTextBoxColumn.Name = "ProductBrandDataGridViewTextBoxColumn"
        Me.ProductBrandDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductDescriptionDataGridViewTextBoxColumn
        '
        Me.ProductDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Product_Description"
        Me.ProductDescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.ProductDescriptionDataGridViewTextBoxColumn.Name = "ProductDescriptionDataGridViewTextBoxColumn"
        Me.ProductDescriptionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SuppLineItemCostPriceDataGridViewTextBoxColumn
        '
        Me.SuppLineItemCostPriceDataGridViewTextBoxColumn.DataPropertyName = "Supp_Line_Item_Cost_Price"
        Me.SuppLineItemCostPriceDataGridViewTextBoxColumn.HeaderText = "Cost Price"
        Me.SuppLineItemCostPriceDataGridViewTextBoxColumn.Name = "SuppLineItemCostPriceDataGridViewTextBoxColumn"
        Me.SuppLineItemCostPriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SuppLineItemQuantityDataGridViewTextBoxColumn
        '
        Me.SuppLineItemQuantityDataGridViewTextBoxColumn.DataPropertyName = "Supp_Line_Item_Quantity"
        Me.SuppLineItemQuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.SuppLineItemQuantityDataGridViewTextBoxColumn.Name = "SuppLineItemQuantityDataGridViewTextBoxColumn"
        Me.SuppLineItemQuantityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductActiveStatusDataGridViewTextBoxColumn
        '
        Me.ProductActiveStatusDataGridViewTextBoxColumn.DataPropertyName = "Product_Active_Status"
        Me.ProductActiveStatusDataGridViewTextBoxColumn.HeaderText = "Active Status"
        Me.ProductActiveStatusDataGridViewTextBoxColumn.Name = "ProductActiveStatusDataGridViewTextBoxColumn"
        Me.ProductActiveStatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AddLineItem
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.NullValue = "ADD"
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.BlueViolet
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.AddLineItem.DefaultCellStyle = DataGridViewCellStyle1
        Me.AddLineItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddLineItem.HeaderText = "Add Item"
        Me.AddLineItem.Name = "AddLineItem"
        Me.AddLineItem.ReadOnly = True
        Me.AddLineItem.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AddLineItem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.AddLineItem.Text = "ADD"
        Me.AddLineItem.ToolTipText = "Add item to quote"
        '
        'SuppLineItemJoinProductBindingSource
        '
        Me.SuppLineItemJoinProductBindingSource.DataMember = "SuppLineItemJoinProduct"
        Me.SuppLineItemJoinProductBindingSource.DataSource = Me.Group16DataSet
        '
        'Group16DataSet
        '
        Me.Group16DataSet.DataSetName = "group16DataSet"
        Me.Group16DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SupplierQuoteDataGridView
        '
        Me.SupplierQuoteDataGridView.AllowUserToAddRows = False
        Me.SupplierQuoteDataGridView.AllowUserToDeleteRows = False
        Me.SupplierQuoteDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SupplierQuoteDataGridView.AutoGenerateColumns = False
        Me.SupplierQuoteDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SupplierQuoteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SupplierQuoteDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SuppQuoteReferenceIDDataGridViewTextBoxColumn, Me.SuppQuoteTotalPriceDataGridViewTextBoxColumn, Me.SupplierIDDataGridViewTextBoxColumn, Me.SupplierNameDataGridViewTextBoxColumn, Me.SupplierRepFNameDataGridViewTextBoxColumn, Me.SupplierActiveStatusDataGridViewTextBoxColumn, Me.SupplierRepSNameDataGridViewTextBoxColumn, Me.SuppQuoteDateRecievedDataGridViewTextBoxColumn, Me.SuppQuoteAcceptanceStatusDataGridViewTextBoxColumn, Me.SuppQuoteDateAcceptanceDataGridViewTextBoxColumn})
        Me.SupplierQuoteDataGridView.DataSource = Me.SupplierQuoteJoinSupplierBindingSource
        Me.SupplierQuoteDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.SupplierQuoteDataGridView.Location = New System.Drawing.Point(4, 65)
        Me.SupplierQuoteDataGridView.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SupplierQuoteDataGridView.Name = "SupplierQuoteDataGridView"
        Me.SupplierQuoteDataGridView.ReadOnly = True
        Me.SupplierQuoteDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.SupplierQuoteDataGridView.RowTemplate.Height = 24
        Me.SupplierQuoteDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SupplierQuoteDataGridView.Size = New System.Drawing.Size(1077, 136)
        Me.SupplierQuoteDataGridView.TabIndex = 0
        '
        'SuppQuoteReferenceIDDataGridViewTextBoxColumn
        '
        Me.SuppQuoteReferenceIDDataGridViewTextBoxColumn.DataPropertyName = "Supp_Quote_Reference_ID"
        Me.SuppQuoteReferenceIDDataGridViewTextBoxColumn.HeaderText = "Quote Ref ID"
        Me.SuppQuoteReferenceIDDataGridViewTextBoxColumn.Name = "SuppQuoteReferenceIDDataGridViewTextBoxColumn"
        Me.SuppQuoteReferenceIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SuppQuoteTotalPriceDataGridViewTextBoxColumn
        '
        Me.SuppQuoteTotalPriceDataGridViewTextBoxColumn.DataPropertyName = "Supp_Quote_Total_Price"
        Me.SuppQuoteTotalPriceDataGridViewTextBoxColumn.HeaderText = "Total Price"
        Me.SuppQuoteTotalPriceDataGridViewTextBoxColumn.Name = "SuppQuoteTotalPriceDataGridViewTextBoxColumn"
        Me.SuppQuoteTotalPriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SupplierIDDataGridViewTextBoxColumn
        '
        Me.SupplierIDDataGridViewTextBoxColumn.DataPropertyName = "Supplier_ID"
        Me.SupplierIDDataGridViewTextBoxColumn.HeaderText = "Supplier ID"
        Me.SupplierIDDataGridViewTextBoxColumn.Name = "SupplierIDDataGridViewTextBoxColumn"
        Me.SupplierIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SupplierNameDataGridViewTextBoxColumn
        '
        Me.SupplierNameDataGridViewTextBoxColumn.DataPropertyName = "Supplier_Name"
        Me.SupplierNameDataGridViewTextBoxColumn.HeaderText = "Supplier Name"
        Me.SupplierNameDataGridViewTextBoxColumn.Name = "SupplierNameDataGridViewTextBoxColumn"
        Me.SupplierNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SupplierRepFNameDataGridViewTextBoxColumn
        '
        Me.SupplierRepFNameDataGridViewTextBoxColumn.DataPropertyName = "Supplier_Rep_FName"
        Me.SupplierRepFNameDataGridViewTextBoxColumn.HeaderText = "Rep First Name"
        Me.SupplierRepFNameDataGridViewTextBoxColumn.Name = "SupplierRepFNameDataGridViewTextBoxColumn"
        Me.SupplierRepFNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SupplierActiveStatusDataGridViewTextBoxColumn
        '
        Me.SupplierActiveStatusDataGridViewTextBoxColumn.DataPropertyName = "Supplier_Active_Status"
        Me.SupplierActiveStatusDataGridViewTextBoxColumn.HeaderText = "Supplier Active Status"
        Me.SupplierActiveStatusDataGridViewTextBoxColumn.Name = "SupplierActiveStatusDataGridViewTextBoxColumn"
        Me.SupplierActiveStatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SupplierRepSNameDataGridViewTextBoxColumn
        '
        Me.SupplierRepSNameDataGridViewTextBoxColumn.DataPropertyName = "Supplier_Rep_SName"
        Me.SupplierRepSNameDataGridViewTextBoxColumn.HeaderText = "Rep Surname"
        Me.SupplierRepSNameDataGridViewTextBoxColumn.Name = "SupplierRepSNameDataGridViewTextBoxColumn"
        Me.SupplierRepSNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SuppQuoteDateRecievedDataGridViewTextBoxColumn
        '
        Me.SuppQuoteDateRecievedDataGridViewTextBoxColumn.DataPropertyName = "Supp_Quote_Date_Recieved"
        Me.SuppQuoteDateRecievedDataGridViewTextBoxColumn.HeaderText = "Date Recieved"
        Me.SuppQuoteDateRecievedDataGridViewTextBoxColumn.Name = "SuppQuoteDateRecievedDataGridViewTextBoxColumn"
        Me.SuppQuoteDateRecievedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SuppQuoteAcceptanceStatusDataGridViewTextBoxColumn
        '
        Me.SuppQuoteAcceptanceStatusDataGridViewTextBoxColumn.DataPropertyName = "Supp_Quote_Acceptance_Status"
        Me.SuppQuoteAcceptanceStatusDataGridViewTextBoxColumn.HeaderText = "Acceptance Status"
        Me.SuppQuoteAcceptanceStatusDataGridViewTextBoxColumn.Name = "SuppQuoteAcceptanceStatusDataGridViewTextBoxColumn"
        Me.SuppQuoteAcceptanceStatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SuppQuoteDateAcceptanceDataGridViewTextBoxColumn
        '
        Me.SuppQuoteDateAcceptanceDataGridViewTextBoxColumn.DataPropertyName = "Supp_Quote_Date_Acceptance"
        Me.SuppQuoteDateAcceptanceDataGridViewTextBoxColumn.HeaderText = "Date Accepted"
        Me.SuppQuoteDateAcceptanceDataGridViewTextBoxColumn.Name = "SuppQuoteDateAcceptanceDataGridViewTextBoxColumn"
        Me.SuppQuoteDateAcceptanceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SupplierQuoteJoinSupplierBindingSource
        '
        Me.SupplierQuoteJoinSupplierBindingSource.DataMember = "SupplierQuoteJoinSupplier"
        Me.SupplierQuoteJoinSupplierBindingSource.DataSource = Me.Group16DataSet
        '
        'SupplierQuoteJoinSupplierTableAdapter
        '
        Me.SupplierQuoteJoinSupplierTableAdapter.ClearBeforeFill = True
        '
        'SuppQuoteJoinSuppLineItemBindingSource
        '
        Me.SuppQuoteJoinSuppLineItemBindingSource.DataMember = "SuppQuoteJoinSuppLineItem"
        Me.SuppQuoteJoinSuppLineItemBindingSource.DataSource = Me.Group16DataSet
        '
        'SuppQuoteJoinSuppLineItemTableAdapter
        '
        Me.SuppQuoteJoinSuppLineItemTableAdapter.ClearBeforeFill = True
        '
        'SuppLineItemJoinProductTableAdapter
        '
        Me.SuppLineItemJoinProductTableAdapter.ClearBeforeFill = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox2.Controls.Add(Me.CustQuoteLineItemDataGridView)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 11)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(1259, 250)
        Me.GroupBox2.TabIndex = 108
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CUSTOMER QUOTE LINE ITEMS"
        '
        'CustQuoteLineItemDataGridView
        '
        Me.CustQuoteLineItemDataGridView.AllowUserToAddRows = False
        Me.CustQuoteLineItemDataGridView.AllowUserToDeleteRows = False
        Me.CustQuoteLineItemDataGridView.AutoGenerateColumns = False
        Me.CustQuoteLineItemDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CustQuoteLineItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustQuoteLineItemDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cust_Quote_Reference_ID, Me.Product_ID, Me.Product_Name, Me.Product_Brand, Me.Supplier_ID, Me.Supplier_Name, Me.Cust_Line_Item_Cost_Price, Me.Cust_Line_Item_Markup_Percentage, Me.Cust_Line_Item_Discount_Percentage, Me.Cust_Line_Item_Quantity, Me.Cust_Line_Item_Sale_incl_VAT, Me.Cust_Line_Item_Sale_excl_VAT, Me.Product_Active_Status, Me.Edit_Item, Me.DataGridViewButtonColumn1, Me.ProductIDDataGridViewTextBoxColumn1, Me.CustQuoteReferenceIDDataGridViewTextBoxColumn, Me.SupplierIDDataGridViewTextBoxColumn1, Me.CustLineItemCostPriceDataGridViewTextBoxColumn, Me.CustLineItemSaleinclVATDataGridViewTextBoxColumn, Me.CustLineItemSaleexclVATDataGridViewTextBoxColumn, Me.CustLineItemMarkupPercentageDataGridViewTextBoxColumn, Me.CustLineItemDiscountPercentageDataGridViewTextBoxColumn, Me.CustLineItemQuantityDataGridViewTextBoxColumn, Me.ProductNameDataGridViewTextBoxColumn1, Me.ProductBrandDataGridViewTextBoxColumn1, Me.ProductDescriptionDataGridViewTextBoxColumn1, Me.ProductActiveStatusDataGridViewTextBoxColumn1, Me.SupplierNameDataGridViewTextBoxColumn1})
        Me.CustQuoteLineItemDataGridView.DataSource = Me.CustLineItemJoinProductsBindingSource
        Me.CustQuoteLineItemDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustQuoteLineItemDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.CustQuoteLineItemDataGridView.Location = New System.Drawing.Point(2, 15)
        Me.CustQuoteLineItemDataGridView.Name = "CustQuoteLineItemDataGridView"
        Me.CustQuoteLineItemDataGridView.ReadOnly = True
        Me.CustQuoteLineItemDataGridView.RowHeadersWidth = 40
        Me.CustQuoteLineItemDataGridView.Size = New System.Drawing.Size(1255, 233)
        Me.CustQuoteLineItemDataGridView.TabIndex = 0
        '
        'CustLineItemJoinProductsBindingSource
        '
        Me.CustLineItemJoinProductsBindingSource.DataMember = "CustLineItemJoinProducts"
        Me.CustLineItemJoinProductsBindingSource.DataSource = Me.Group16DataSet
        '
        'CustLineItemJoinProductsTableAdapter
        '
        Me.CustLineItemJoinProductsTableAdapter.ClearBeforeFill = True
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BackButton.FlatAppearance.BorderSize = 3
        Me.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.BackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Location = New System.Drawing.Point(1192, 680)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(76, 43)
        Me.BackButton.TabIndex = 109
        Me.BackButton.Text = "BACK"
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'Cust_Quote_Reference_ID
        '
        Me.Cust_Quote_Reference_ID.DataPropertyName = "Cust_Quote_Reference_ID"
        Me.Cust_Quote_Reference_ID.HeaderText = "Quote Ref ID"
        Me.Cust_Quote_Reference_ID.Name = "Cust_Quote_Reference_ID"
        Me.Cust_Quote_Reference_ID.ReadOnly = True
        Me.Cust_Quote_Reference_ID.Width = 60
        '
        'Product_ID
        '
        Me.Product_ID.DataPropertyName = "Product_ID"
        Me.Product_ID.HeaderText = "Product ID"
        Me.Product_ID.Name = "Product_ID"
        Me.Product_ID.ReadOnly = True
        Me.Product_ID.Width = 50
        '
        'Product_Name
        '
        Me.Product_Name.DataPropertyName = "Product_Name"
        Me.Product_Name.HeaderText = "Product"
        Me.Product_Name.Name = "Product_Name"
        Me.Product_Name.ReadOnly = True
        Me.Product_Name.Width = 120
        '
        'Product_Brand
        '
        Me.Product_Brand.DataPropertyName = "Product_Brand"
        Me.Product_Brand.HeaderText = "Brand"
        Me.Product_Brand.Name = "Product_Brand"
        Me.Product_Brand.ReadOnly = True
        '
        'Supplier_ID
        '
        Me.Supplier_ID.DataPropertyName = "Supplier_ID"
        Me.Supplier_ID.HeaderText = "Supplier ID"
        Me.Supplier_ID.Name = "Supplier_ID"
        Me.Supplier_ID.ReadOnly = True
        Me.Supplier_ID.Width = 50
        '
        'Supplier_Name
        '
        Me.Supplier_Name.DataPropertyName = "Supplier_Name"
        Me.Supplier_Name.HeaderText = "Supplier"
        Me.Supplier_Name.Name = "Supplier_Name"
        Me.Supplier_Name.ReadOnly = True
        '
        'Cust_Line_Item_Cost_Price
        '
        Me.Cust_Line_Item_Cost_Price.DataPropertyName = "Cust_Line_Item_Cost_Price"
        Me.Cust_Line_Item_Cost_Price.HeaderText = "Cost Price"
        Me.Cust_Line_Item_Cost_Price.Name = "Cust_Line_Item_Cost_Price"
        Me.Cust_Line_Item_Cost_Price.ReadOnly = True
        '
        'Cust_Line_Item_Markup_Percentage
        '
        Me.Cust_Line_Item_Markup_Percentage.DataPropertyName = "Cust_Line_Item_Markup_Percentage"
        Me.Cust_Line_Item_Markup_Percentage.HeaderText = "Markup %"
        Me.Cust_Line_Item_Markup_Percentage.Name = "Cust_Line_Item_Markup_Percentage"
        Me.Cust_Line_Item_Markup_Percentage.ReadOnly = True
        Me.Cust_Line_Item_Markup_Percentage.Width = 60
        '
        'Cust_Line_Item_Discount_Percentage
        '
        Me.Cust_Line_Item_Discount_Percentage.DataPropertyName = "Cust_Line_Item_Discount_Percentage"
        Me.Cust_Line_Item_Discount_Percentage.HeaderText = "Discount %"
        Me.Cust_Line_Item_Discount_Percentage.Name = "Cust_Line_Item_Discount_Percentage"
        Me.Cust_Line_Item_Discount_Percentage.ReadOnly = True
        Me.Cust_Line_Item_Discount_Percentage.Width = 70
        '
        'Cust_Line_Item_Quantity
        '
        Me.Cust_Line_Item_Quantity.DataPropertyName = "Cust_Line_Item_Quantity"
        Me.Cust_Line_Item_Quantity.HeaderText = "Quantity"
        Me.Cust_Line_Item_Quantity.Name = "Cust_Line_Item_Quantity"
        Me.Cust_Line_Item_Quantity.ReadOnly = True
        Me.Cust_Line_Item_Quantity.Width = 50
        '
        'Cust_Line_Item_Sale_incl_VAT
        '
        Me.Cust_Line_Item_Sale_incl_VAT.DataPropertyName = "Cust_Line_Item_Sale_incl_VAT"
        Me.Cust_Line_Item_Sale_incl_VAT.HeaderText = "Sale incl VAT per Item"
        Me.Cust_Line_Item_Sale_incl_VAT.Name = "Cust_Line_Item_Sale_incl_VAT"
        Me.Cust_Line_Item_Sale_incl_VAT.ReadOnly = True
        '
        'Cust_Line_Item_Sale_excl_VAT
        '
        Me.Cust_Line_Item_Sale_excl_VAT.DataPropertyName = "Cust_Line_Item_Sale_excl_VAT"
        Me.Cust_Line_Item_Sale_excl_VAT.HeaderText = "Sale excl VAT per Item"
        Me.Cust_Line_Item_Sale_excl_VAT.Name = "Cust_Line_Item_Sale_excl_VAT"
        Me.Cust_Line_Item_Sale_excl_VAT.ReadOnly = True
        '
        'Product_Active_Status
        '
        Me.Product_Active_Status.DataPropertyName = "Product_Active_Status"
        Me.Product_Active_Status.HeaderText = "Active Status"
        Me.Product_Active_Status.Name = "Product_Active_Status"
        Me.Product_Active_Status.ReadOnly = True
        Me.Product_Active_Status.Width = 50
        '
        'Edit_Item
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.NullValue = "EDIT"
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.Edit_Item.DefaultCellStyle = DataGridViewCellStyle2
        Me.Edit_Item.HeaderText = "Edit"
        Me.Edit_Item.Name = "Edit_Item"
        Me.Edit_Item.ReadOnly = True
        Me.Edit_Item.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Edit_Item.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewButtonColumn1
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.NullValue = "REMOVE"
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridViewButtonColumn1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewButtonColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DataGridViewButtonColumn1.HeaderText = "Remove"
        Me.DataGridViewButtonColumn1.Name = "DataGridViewButtonColumn1"
        Me.DataGridViewButtonColumn1.ReadOnly = True
        Me.DataGridViewButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewButtonColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewButtonColumn1.Text = "REMOVE"
        Me.DataGridViewButtonColumn1.ToolTipText = "Remove item from quote"
        '
        'ProductIDDataGridViewTextBoxColumn1
        '
        Me.ProductIDDataGridViewTextBoxColumn1.DataPropertyName = "Product_ID"
        Me.ProductIDDataGridViewTextBoxColumn1.HeaderText = "Product_ID"
        Me.ProductIDDataGridViewTextBoxColumn1.Name = "ProductIDDataGridViewTextBoxColumn1"
        Me.ProductIDDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'CustQuoteReferenceIDDataGridViewTextBoxColumn
        '
        Me.CustQuoteReferenceIDDataGridViewTextBoxColumn.DataPropertyName = "Cust_Quote_Reference_ID"
        Me.CustQuoteReferenceIDDataGridViewTextBoxColumn.HeaderText = "Cust_Quote_Reference_ID"
        Me.CustQuoteReferenceIDDataGridViewTextBoxColumn.Name = "CustQuoteReferenceIDDataGridViewTextBoxColumn"
        Me.CustQuoteReferenceIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SupplierIDDataGridViewTextBoxColumn1
        '
        Me.SupplierIDDataGridViewTextBoxColumn1.DataPropertyName = "Supplier_ID"
        Me.SupplierIDDataGridViewTextBoxColumn1.HeaderText = "Supplier_ID"
        Me.SupplierIDDataGridViewTextBoxColumn1.Name = "SupplierIDDataGridViewTextBoxColumn1"
        Me.SupplierIDDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'CustLineItemCostPriceDataGridViewTextBoxColumn
        '
        Me.CustLineItemCostPriceDataGridViewTextBoxColumn.DataPropertyName = "Cust_Line_Item_Cost_Price"
        Me.CustLineItemCostPriceDataGridViewTextBoxColumn.HeaderText = "Cust_Line_Item_Cost_Price"
        Me.CustLineItemCostPriceDataGridViewTextBoxColumn.Name = "CustLineItemCostPriceDataGridViewTextBoxColumn"
        Me.CustLineItemCostPriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustLineItemSaleinclVATDataGridViewTextBoxColumn
        '
        Me.CustLineItemSaleinclVATDataGridViewTextBoxColumn.DataPropertyName = "Cust_Line_Item_Sale_incl_VAT"
        Me.CustLineItemSaleinclVATDataGridViewTextBoxColumn.HeaderText = "Cust_Line_Item_Sale_incl_VAT"
        Me.CustLineItemSaleinclVATDataGridViewTextBoxColumn.Name = "CustLineItemSaleinclVATDataGridViewTextBoxColumn"
        Me.CustLineItemSaleinclVATDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustLineItemSaleexclVATDataGridViewTextBoxColumn
        '
        Me.CustLineItemSaleexclVATDataGridViewTextBoxColumn.DataPropertyName = "Cust_Line_Item_Sale_excl_VAT"
        Me.CustLineItemSaleexclVATDataGridViewTextBoxColumn.HeaderText = "Cust_Line_Item_Sale_excl_VAT"
        Me.CustLineItemSaleexclVATDataGridViewTextBoxColumn.Name = "CustLineItemSaleexclVATDataGridViewTextBoxColumn"
        Me.CustLineItemSaleexclVATDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustLineItemMarkupPercentageDataGridViewTextBoxColumn
        '
        Me.CustLineItemMarkupPercentageDataGridViewTextBoxColumn.DataPropertyName = "Cust_Line_Item_Markup_Percentage"
        Me.CustLineItemMarkupPercentageDataGridViewTextBoxColumn.HeaderText = "Cust_Line_Item_Markup_Percentage"
        Me.CustLineItemMarkupPercentageDataGridViewTextBoxColumn.Name = "CustLineItemMarkupPercentageDataGridViewTextBoxColumn"
        Me.CustLineItemMarkupPercentageDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustLineItemDiscountPercentageDataGridViewTextBoxColumn
        '
        Me.CustLineItemDiscountPercentageDataGridViewTextBoxColumn.DataPropertyName = "Cust_Line_Item_Discount_Percentage"
        Me.CustLineItemDiscountPercentageDataGridViewTextBoxColumn.HeaderText = "Cust_Line_Item_Discount_Percentage"
        Me.CustLineItemDiscountPercentageDataGridViewTextBoxColumn.Name = "CustLineItemDiscountPercentageDataGridViewTextBoxColumn"
        Me.CustLineItemDiscountPercentageDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustLineItemQuantityDataGridViewTextBoxColumn
        '
        Me.CustLineItemQuantityDataGridViewTextBoxColumn.DataPropertyName = "Cust_Line_Item_Quantity"
        Me.CustLineItemQuantityDataGridViewTextBoxColumn.HeaderText = "Cust_Line_Item_Quantity"
        Me.CustLineItemQuantityDataGridViewTextBoxColumn.Name = "CustLineItemQuantityDataGridViewTextBoxColumn"
        Me.CustLineItemQuantityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductNameDataGridViewTextBoxColumn1
        '
        Me.ProductNameDataGridViewTextBoxColumn1.DataPropertyName = "Product_Name"
        Me.ProductNameDataGridViewTextBoxColumn1.HeaderText = "Product_Name"
        Me.ProductNameDataGridViewTextBoxColumn1.Name = "ProductNameDataGridViewTextBoxColumn1"
        Me.ProductNameDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ProductBrandDataGridViewTextBoxColumn1
        '
        Me.ProductBrandDataGridViewTextBoxColumn1.DataPropertyName = "Product_Brand"
        Me.ProductBrandDataGridViewTextBoxColumn1.HeaderText = "Product_Brand"
        Me.ProductBrandDataGridViewTextBoxColumn1.Name = "ProductBrandDataGridViewTextBoxColumn1"
        Me.ProductBrandDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ProductDescriptionDataGridViewTextBoxColumn1
        '
        Me.ProductDescriptionDataGridViewTextBoxColumn1.DataPropertyName = "Product_Description"
        Me.ProductDescriptionDataGridViewTextBoxColumn1.HeaderText = "Product_Description"
        Me.ProductDescriptionDataGridViewTextBoxColumn1.Name = "ProductDescriptionDataGridViewTextBoxColumn1"
        Me.ProductDescriptionDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ProductActiveStatusDataGridViewTextBoxColumn1
        '
        Me.ProductActiveStatusDataGridViewTextBoxColumn1.DataPropertyName = "Product_Active_Status"
        Me.ProductActiveStatusDataGridViewTextBoxColumn1.HeaderText = "Product_Active_Status"
        Me.ProductActiveStatusDataGridViewTextBoxColumn1.Name = "ProductActiveStatusDataGridViewTextBoxColumn1"
        Me.ProductActiveStatusDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'SupplierNameDataGridViewTextBoxColumn1
        '
        Me.SupplierNameDataGridViewTextBoxColumn1.DataPropertyName = "Supplier_Name"
        Me.SupplierNameDataGridViewTextBoxColumn1.HeaderText = "Supplier_Name"
        Me.SupplierNameDataGridViewTextBoxColumn1.Name = "SupplierNameDataGridViewTextBoxColumn1"
        Me.SupplierNameDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'CustomerQuoteItemManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = Global.M.I.S.S_Vendor_Order_Management_System.My.Resources.Resources.Background1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1282, 734)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "CustomerQuoteItemManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CustomerQuoteItemManager"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.SuppLineItemDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuppLineItemJoinProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group16DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierQuoteDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierQuoteJoinSupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuppQuoteJoinSuppLineItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.CustQuoteLineItemDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustLineItemJoinProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents SuppLineItemDataGridView As DataGridView
    Friend WithEvents SupplierQuoteDataGridView As DataGridView
    Friend WithEvents Group16DataSet As group16DataSet
    Friend WithEvents SupplierQuoteJoinSupplierBindingSource As BindingSource
    Friend WithEvents SupplierQuoteJoinSupplierTableAdapter As group16DataSetTableAdapters.SupplierQuoteJoinSupplierTableAdapter
    Friend WithEvents SuppQuoteJoinSuppLineItemBindingSource As BindingSource
    Friend WithEvents SuppQuoteJoinSuppLineItemTableAdapter As group16DataSetTableAdapters.SuppQuoteJoinSuppLineItemTableAdapter
    Friend WithEvents SuppLineItemJoinProductBindingSource As BindingSource
    Friend WithEvents SuppLineItemJoinProductTableAdapter As group16DataSetTableAdapters.SuppLineItemJoinProductTableAdapter
    Friend WithEvents SuppQuoteReferenceIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ProductIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductBrandDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductDescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SuppLineItemCostPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SuppLineItemQuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductActiveStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddLineItem As DataGridViewButtonColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CustQuoteLineItemDataGridView As DataGridView
    Friend WithEvents CustLineItemJoinProductsBindingSource As BindingSource
    Friend WithEvents CustLineItemJoinProductsTableAdapter As group16DataSetTableAdapters.CustLineItemJoinProductsTableAdapter
    Friend WithEvents SuppQuoteReferenceIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SuppQuoteTotalPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SupplierIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SupplierNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SupplierRepFNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SupplierActiveStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SupplierRepSNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SuppQuoteDateRecievedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SuppQuoteAcceptanceStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SuppQuoteDateAcceptanceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BackButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents ClearButton As Button
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents Cust_Quote_Reference_ID As DataGridViewTextBoxColumn
    Friend WithEvents Product_ID As DataGridViewTextBoxColumn
    Friend WithEvents Product_Name As DataGridViewTextBoxColumn
    Friend WithEvents Product_Brand As DataGridViewTextBoxColumn
    Friend WithEvents Supplier_ID As DataGridViewTextBoxColumn
    Friend WithEvents Supplier_Name As DataGridViewTextBoxColumn
    Friend WithEvents Cust_Line_Item_Cost_Price As DataGridViewTextBoxColumn
    Friend WithEvents Cust_Line_Item_Markup_Percentage As DataGridViewTextBoxColumn
    Friend WithEvents Cust_Line_Item_Discount_Percentage As DataGridViewTextBoxColumn
    Friend WithEvents Cust_Line_Item_Quantity As DataGridViewTextBoxColumn
    Friend WithEvents Cust_Line_Item_Sale_incl_VAT As DataGridViewTextBoxColumn
    Friend WithEvents Cust_Line_Item_Sale_excl_VAT As DataGridViewTextBoxColumn
    Friend WithEvents Product_Active_Status As DataGridViewTextBoxColumn
    Friend WithEvents Edit_Item As DataGridViewButtonColumn
    Friend WithEvents DataGridViewButtonColumn1 As DataGridViewButtonColumn
    Friend WithEvents ProductIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CustQuoteReferenceIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SupplierIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CustLineItemCostPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustLineItemSaleinclVATDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustLineItemSaleexclVATDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustLineItemMarkupPercentageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustLineItemDiscountPercentageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustLineItemQuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ProductBrandDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ProductDescriptionDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ProductActiveStatusDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents SupplierNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
End Class

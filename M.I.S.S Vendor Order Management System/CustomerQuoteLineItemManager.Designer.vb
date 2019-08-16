<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomerQuoteLineItemManager
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ProductDataGridView = New System.Windows.Forms.DataGridView()
        Me.ProductIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductBrandDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductDescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductActiveStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddLineItem = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Group16DataSet = New M.I.S.S_Vendor_Order_Management_System.group16DataSet()
        Me.CustomerQuoteLineItemDataGridView = New System.Windows.Forms.DataGridView()
        Me.CustQuoteReferenceIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.CustLineItemCostPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustLineItemMarkupPercentageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustLineItemDiscountPercentageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustLineItemSaleinclVATDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustLineItemSaleexclVATDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustLineItemQuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Edit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.RemoveLineItem = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.CustomerQuoteLineItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductTableAdapter = New M.I.S.S_Vendor_Order_Management_System.group16DataSetTableAdapters.ProductTableAdapter()
        Me.Customer_Quote_Line_ItemTableAdapter = New M.I.S.S_Vendor_Order_Management_System.group16DataSetTableAdapters.Customer_Quote_Line_ItemTableAdapter()
        Me.CustomerQuoteLineItemManagerTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.ProductDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group16DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerQuoteLineItemDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerQuoteLineItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BackButton.Location = New System.Drawing.Point(1381, 622)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(105, 41)
        Me.BackButton.TabIndex = 77
        Me.BackButton.Text = "BACK"
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ClearButton)
        Me.GroupBox1.Controls.Add(Me.SearchTextBox)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.CustomerQuoteLineItemDataGridView)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 9)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(1471, 596)
        Me.GroupBox1.TabIndex = 76
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CUSTOMER QUOTE LINE ITEMS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(568, 514)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(236, 17)
        Me.Label4.TabIndex = 106
        Me.Label4.Text = "Enter product name to be searched:"
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClearButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ClearButton.FlatAppearance.BorderSize = 3
        Me.ClearButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.ClearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearButton.Location = New System.Drawing.Point(855, 526)
        Me.ClearButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(128, 42)
        Me.ClearButton.TabIndex = 104
        Me.ClearButton.Text = "CLEAR TEXT"
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Location = New System.Drawing.Point(543, 535)
        Me.SearchTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(285, 22)
        Me.SearchTextBox.TabIndex = 102
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox4.Controls.Add(Me.ProductDataGridView)
        Me.GroupBox4.Location = New System.Drawing.Point(109, 261)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(1236, 244)
        Me.GroupBox4.TabIndex = 55
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "ALL PRODUCTS"
        '
        'ProductDataGridView
        '
        Me.ProductDataGridView.AllowUserToAddRows = False
        Me.ProductDataGridView.AllowUserToDeleteRows = False
        Me.ProductDataGridView.AutoGenerateColumns = False
        Me.ProductDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductIDDataGridViewTextBoxColumn1, Me.ProductNameDataGridViewTextBoxColumn1, Me.ProductBrandDataGridViewTextBoxColumn1, Me.ProductDescriptionDataGridViewTextBoxColumn, Me.ProductActiveStatusDataGridViewTextBoxColumn, Me.AddLineItem})
        Me.ProductDataGridView.DataSource = Me.ProductBindingSource
        Me.ProductDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProductDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.ProductDataGridView.Location = New System.Drawing.Point(3, 17)
        Me.ProductDataGridView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ProductDataGridView.Name = "ProductDataGridView"
        Me.ProductDataGridView.ReadOnly = True
        Me.ProductDataGridView.Size = New System.Drawing.Size(1230, 225)
        Me.ProductDataGridView.TabIndex = 0
        '
        'ProductIDDataGridViewTextBoxColumn1
        '
        Me.ProductIDDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProductIDDataGridViewTextBoxColumn1.DataPropertyName = "Product_ID"
        Me.ProductIDDataGridViewTextBoxColumn1.HeaderText = "Product ID"
        Me.ProductIDDataGridViewTextBoxColumn1.Name = "ProductIDDataGridViewTextBoxColumn1"
        Me.ProductIDDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ProductNameDataGridViewTextBoxColumn1
        '
        Me.ProductNameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProductNameDataGridViewTextBoxColumn1.DataPropertyName = "Product_Name"
        Me.ProductNameDataGridViewTextBoxColumn1.HeaderText = "Product Name"
        Me.ProductNameDataGridViewTextBoxColumn1.Name = "ProductNameDataGridViewTextBoxColumn1"
        Me.ProductNameDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ProductBrandDataGridViewTextBoxColumn1
        '
        Me.ProductBrandDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProductBrandDataGridViewTextBoxColumn1.DataPropertyName = "Product_Brand"
        Me.ProductBrandDataGridViewTextBoxColumn1.HeaderText = "Product Brand"
        Me.ProductBrandDataGridViewTextBoxColumn1.Name = "ProductBrandDataGridViewTextBoxColumn1"
        Me.ProductBrandDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ProductDescriptionDataGridViewTextBoxColumn
        '
        Me.ProductDescriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProductDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Product_Description"
        Me.ProductDescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.ProductDescriptionDataGridViewTextBoxColumn.Name = "ProductDescriptionDataGridViewTextBoxColumn"
        Me.ProductDescriptionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductActiveStatusDataGridViewTextBoxColumn
        '
        Me.ProductActiveStatusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
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
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataMember = "Product"
        Me.ProductBindingSource.DataSource = Me.Group16DataSet
        '
        'Group16DataSet
        '
        Me.Group16DataSet.DataSetName = "group16DataSet"
        Me.Group16DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerQuoteLineItemDataGridView
        '
        Me.CustomerQuoteLineItemDataGridView.AllowUserToAddRows = False
        Me.CustomerQuoteLineItemDataGridView.AllowUserToDeleteRows = False
        Me.CustomerQuoteLineItemDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CustomerQuoteLineItemDataGridView.AutoGenerateColumns = False
        Me.CustomerQuoteLineItemDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CustomerQuoteLineItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomerQuoteLineItemDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustQuoteReferenceIDDataGridViewTextBoxColumn, Me.ProductIDDataGridViewTextBoxColumn, Me.CustLineItemCostPriceDataGridViewTextBoxColumn, Me.CustLineItemMarkupPercentageDataGridViewTextBoxColumn, Me.CustLineItemDiscountPercentageDataGridViewTextBoxColumn, Me.CustLineItemSaleinclVATDataGridViewTextBoxColumn, Me.CustLineItemSaleexclVATDataGridViewTextBoxColumn, Me.CustLineItemQuantityDataGridViewTextBoxColumn, Me.SupplierIDDataGridViewTextBoxColumn, Me.Edit, Me.RemoveLineItem})
        Me.CustomerQuoteLineItemDataGridView.DataSource = Me.CustomerQuoteLineItemBindingSource
        Me.CustomerQuoteLineItemDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.CustomerQuoteLineItemDataGridView.Location = New System.Drawing.Point(5, 21)
        Me.CustomerQuoteLineItemDataGridView.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CustomerQuoteLineItemDataGridView.Name = "CustomerQuoteLineItemDataGridView"
        Me.CustomerQuoteLineItemDataGridView.ReadOnly = True
        Me.CustomerQuoteLineItemDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.CustomerQuoteLineItemDataGridView.RowTemplate.Height = 24
        Me.CustomerQuoteLineItemDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CustomerQuoteLineItemDataGridView.Size = New System.Drawing.Size(1460, 235)
        Me.CustomerQuoteLineItemDataGridView.TabIndex = 0
        '
        'CustQuoteReferenceIDDataGridViewTextBoxColumn
        '
        Me.CustQuoteReferenceIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CustQuoteReferenceIDDataGridViewTextBoxColumn.DataPropertyName = "Cust_Quote_Reference_ID"
        Me.CustQuoteReferenceIDDataGridViewTextBoxColumn.HeaderText = "Quote Reference_ID"
        Me.CustQuoteReferenceIDDataGridViewTextBoxColumn.Name = "CustQuoteReferenceIDDataGridViewTextBoxColumn"
        Me.CustQuoteReferenceIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductIDDataGridViewTextBoxColumn
        '
        Me.ProductIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProductIDDataGridViewTextBoxColumn.DataPropertyName = "Product_ID"
        Me.ProductIDDataGridViewTextBoxColumn.HeaderText = "Product ID"
        Me.ProductIDDataGridViewTextBoxColumn.Name = "ProductIDDataGridViewTextBoxColumn"
        Me.ProductIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ProductIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
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
        'CustLineItemQuantityDataGridViewTextBoxColumn
        '
        Me.CustLineItemQuantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CustLineItemQuantityDataGridViewTextBoxColumn.DataPropertyName = "Cust_Line_Item_Quantity"
        Me.CustLineItemQuantityDataGridViewTextBoxColumn.HeaderText = "Item Quantity"
        Me.CustLineItemQuantityDataGridViewTextBoxColumn.Name = "CustLineItemQuantityDataGridViewTextBoxColumn"
        Me.CustLineItemQuantityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SupplierIDDataGridViewTextBoxColumn
        '
        Me.SupplierIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SupplierIDDataGridViewTextBoxColumn.DataPropertyName = "Supplier_ID"
        Me.SupplierIDDataGridViewTextBoxColumn.HeaderText = "Supplier ID"
        Me.SupplierIDDataGridViewTextBoxColumn.Name = "SupplierIDDataGridViewTextBoxColumn"
        Me.SupplierIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Edit
        '
        Me.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.NullValue = "EDIT"
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.Edit.DefaultCellStyle = DataGridViewCellStyle2
        Me.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Edit.HeaderText = "Edit"
        Me.Edit.Name = "Edit"
        Me.Edit.ReadOnly = True
        Me.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Edit.Text = "Edit"
        Me.Edit.ToolTipText = "Edit Line Item details"
        '
        'RemoveLineItem
        '
        Me.RemoveLineItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.NullValue = "REMOVE"
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.RemoveLineItem.DefaultCellStyle = DataGridViewCellStyle3
        Me.RemoveLineItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RemoveLineItem.HeaderText = "Remove"
        Me.RemoveLineItem.Name = "RemoveLineItem"
        Me.RemoveLineItem.ReadOnly = True
        Me.RemoveLineItem.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RemoveLineItem.Text = "Remove"
        Me.RemoveLineItem.ToolTipText = "Remove Line Item from Quote"
        '
        'CustomerQuoteLineItemBindingSource
        '
        Me.CustomerQuoteLineItemBindingSource.DataMember = "Customer_Quote_Line_Item"
        Me.CustomerQuoteLineItemBindingSource.DataSource = Me.Group16DataSet
        '
        'ProductTableAdapter
        '
        Me.ProductTableAdapter.ClearBeforeFill = True
        '
        'Customer_Quote_Line_ItemTableAdapter
        '
        Me.Customer_Quote_Line_ItemTableAdapter.ClearBeforeFill = True
        '
        'CustomerQuoteLineItemManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.M.I.S.S_Vendor_Order_Management_System.My.Resources.Resources.Background1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1500, 674)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "CustomerQuoteLineItemManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Quote Line Item Manager"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.ProductDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group16DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerQuoteLineItemDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerQuoteLineItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BackButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ClearButton As Button
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents ProductDataGridView As DataGridView
    Friend WithEvents CustomerQuoteLineItemDataGridView As DataGridView
    Friend WithEvents Group16DataSet As group16DataSet
    Friend WithEvents ProductBindingSource As BindingSource
    Friend WithEvents ProductTableAdapter As group16DataSetTableAdapters.ProductTableAdapter
    Friend WithEvents CustomerQuoteLineItemBindingSource As BindingSource
    Friend WithEvents Customer_Quote_Line_ItemTableAdapter As group16DataSetTableAdapters.Customer_Quote_Line_ItemTableAdapter
    Friend WithEvents CustomerQuoteLineItemManagerTip As ToolTip
    Friend WithEvents ProductIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ProductNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ProductBrandDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ProductDescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductActiveStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddLineItem As DataGridViewButtonColumn
    Friend WithEvents CustQuoteReferenceIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductIDDataGridViewTextBoxColumn As DataGridViewButtonColumn
    Friend WithEvents CustLineItemCostPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustLineItemMarkupPercentageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustLineItemDiscountPercentageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustLineItemSaleinclVATDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustLineItemSaleexclVATDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustLineItemQuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SupplierIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Edit As DataGridViewButtonColumn
    Friend WithEvents RemoveLineItem As DataGridViewButtonColumn
End Class

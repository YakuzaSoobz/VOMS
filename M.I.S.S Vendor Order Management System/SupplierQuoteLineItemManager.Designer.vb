<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SupplierQuoteLineItemManager
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ProductDataGridView = New System.Windows.Forms.DataGridView()
        Me.ProductIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductBrandDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductDescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductActiveStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddLineItem = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Group16DataSet = New M.I.S.S_Vendor_Order_Management_System.group16DataSet()
        Me.SupplierQuoteLineItemDataGridView = New System.Windows.Forms.DataGridView()
        Me.SuppQuoteReferenceIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.SuppLineItemCostPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuppLineItemQuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemoveLineItem = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Edit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.SupplierQuoteLineItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Supplier_Quote_Line_ItemTableAdapter = New M.I.S.S_Vendor_Order_Management_System.group16DataSetTableAdapters.Supplier_Quote_Line_ItemTableAdapter()
        Me.ProductTableAdapter = New M.I.S.S_Vendor_Order_Management_System.group16DataSetTableAdapters.ProductTableAdapter()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.ProductDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group16DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierQuoteLineItemDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierQuoteLineItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ClearButton)
        Me.GroupBox1.Controls.Add(Me.SearchTextBox)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.SupplierQuoteLineItemDataGridView)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 14)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(1144, 662)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SUPPLIER QUOTE LINE ITEMS"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.BorderSize = 3
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(888, 601)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(168, 54)
        Me.Button1.TabIndex = 107
        Me.Button1.Text = "CREATE PRODUCT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(427, 598)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(236, 17)
        Me.Label4.TabIndex = 106
        Me.Label4.Text = "Enter product name to be searched:"
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClearButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ClearButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ClearButton.FlatAppearance.BorderSize = 3
        Me.ClearButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.ClearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearButton.Location = New System.Drawing.Point(695, 607)
        Me.ClearButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(140, 43)
        Me.ClearButton.TabIndex = 104
        Me.ClearButton.Text = "CLEAR TEXT"
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Location = New System.Drawing.Point(391, 617)
        Me.SearchTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(297, 22)
        Me.SearchTextBox.TabIndex = 102
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox4.Controls.Add(Me.ProductDataGridView)
        Me.GroupBox4.Location = New System.Drawing.Point(24, 342)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(1089, 244)
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
        Me.ProductDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductIDDataGridViewTextBoxColumn1, Me.ProductNameDataGridViewTextBoxColumn, Me.ProductBrandDataGridViewTextBoxColumn, Me.ProductDescriptionDataGridViewTextBoxColumn, Me.ProductActiveStatusDataGridViewTextBoxColumn, Me.AddLineItem})
        Me.ProductDataGridView.DataSource = Me.ProductBindingSource
        Me.ProductDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProductDataGridView.Location = New System.Drawing.Point(3, 17)
        Me.ProductDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.ProductDataGridView.Name = "ProductDataGridView"
        Me.ProductDataGridView.ReadOnly = True
        Me.ProductDataGridView.Size = New System.Drawing.Size(1083, 225)
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
        Me.ProductBrandDataGridViewTextBoxColumn.HeaderText = "Brand"
        Me.ProductBrandDataGridViewTextBoxColumn.Name = "ProductBrandDataGridViewTextBoxColumn"
        Me.ProductBrandDataGridViewTextBoxColumn.ReadOnly = True
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
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
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
        'SupplierQuoteLineItemDataGridView
        '
        Me.SupplierQuoteLineItemDataGridView.AllowUserToAddRows = False
        Me.SupplierQuoteLineItemDataGridView.AllowUserToDeleteRows = False
        Me.SupplierQuoteLineItemDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SupplierQuoteLineItemDataGridView.AutoGenerateColumns = False
        Me.SupplierQuoteLineItemDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SupplierQuoteLineItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SupplierQuoteLineItemDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SuppQuoteReferenceIDDataGridViewTextBoxColumn, Me.ProductIDDataGridViewTextBoxColumn, Me.SuppLineItemCostPriceDataGridViewTextBoxColumn, Me.SuppLineItemQuantityDataGridViewTextBoxColumn, Me.RemoveLineItem, Me.Edit})
        Me.SupplierQuoteLineItemDataGridView.DataSource = Me.SupplierQuoteLineItemBindingSource
        Me.SupplierQuoteLineItemDataGridView.Location = New System.Drawing.Point(5, 21)
        Me.SupplierQuoteLineItemDataGridView.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SupplierQuoteLineItemDataGridView.Name = "SupplierQuoteLineItemDataGridView"
        Me.SupplierQuoteLineItemDataGridView.ReadOnly = True
        Me.SupplierQuoteLineItemDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.SupplierQuoteLineItemDataGridView.RowTemplate.Height = 24
        Me.SupplierQuoteLineItemDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SupplierQuoteLineItemDataGridView.Size = New System.Drawing.Size(1133, 316)
        Me.SupplierQuoteLineItemDataGridView.TabIndex = 0
        '
        'SuppQuoteReferenceIDDataGridViewTextBoxColumn
        '
        Me.SuppQuoteReferenceIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SuppQuoteReferenceIDDataGridViewTextBoxColumn.DataPropertyName = "Supp_Quote_Reference_ID"
        Me.SuppQuoteReferenceIDDataGridViewTextBoxColumn.HeaderText = "Quote Reference ID"
        Me.SuppQuoteReferenceIDDataGridViewTextBoxColumn.Name = "SuppQuoteReferenceIDDataGridViewTextBoxColumn"
        Me.SuppQuoteReferenceIDDataGridViewTextBoxColumn.ReadOnly = True
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
        'SuppLineItemCostPriceDataGridViewTextBoxColumn
        '
        Me.SuppLineItemCostPriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SuppLineItemCostPriceDataGridViewTextBoxColumn.DataPropertyName = "Supp_Line_Item_Cost_Price"
        Me.SuppLineItemCostPriceDataGridViewTextBoxColumn.HeaderText = "Item Cost Price"
        Me.SuppLineItemCostPriceDataGridViewTextBoxColumn.Name = "SuppLineItemCostPriceDataGridViewTextBoxColumn"
        Me.SuppLineItemCostPriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SuppLineItemQuantityDataGridViewTextBoxColumn
        '
        Me.SuppLineItemQuantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SuppLineItemQuantityDataGridViewTextBoxColumn.DataPropertyName = "Supp_Line_Item_Quantity"
        Me.SuppLineItemQuantityDataGridViewTextBoxColumn.HeaderText = "Item Quantity"
        Me.SuppLineItemQuantityDataGridViewTextBoxColumn.Name = "SuppLineItemQuantityDataGridViewTextBoxColumn"
        Me.SuppLineItemQuantityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RemoveLineItem
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.NullValue = "REMOVE"
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.RemoveLineItem.DefaultCellStyle = DataGridViewCellStyle2
        Me.RemoveLineItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RemoveLineItem.HeaderText = "Remove"
        Me.RemoveLineItem.Name = "RemoveLineItem"
        Me.RemoveLineItem.ReadOnly = True
        Me.RemoveLineItem.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RemoveLineItem.Text = "Remove"
        Me.RemoveLineItem.ToolTipText = "Remove Line Item from Quote"
        '
        'Edit
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.NullValue = "EDIT"
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.Edit.DefaultCellStyle = DataGridViewCellStyle3
        Me.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Edit.HeaderText = "Edit"
        Me.Edit.Name = "Edit"
        Me.Edit.ReadOnly = True
        Me.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Edit.Text = "Edit"
        Me.Edit.ToolTipText = "Edit Line Item details"
        '
        'SupplierQuoteLineItemBindingSource
        '
        Me.SupplierQuoteLineItemBindingSource.DataMember = "Supplier_Quote_Line_Item"
        Me.SupplierQuoteLineItemBindingSource.DataSource = Me.Group16DataSet
        '
        'Supplier_Quote_Line_ItemTableAdapter
        '
        Me.Supplier_Quote_Line_ItemTableAdapter.ClearBeforeFill = True
        '
        'ProductTableAdapter
        '
        Me.ProductTableAdapter.ClearBeforeFill = True
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
        Me.BackButton.Location = New System.Drawing.Point(1068, 681)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(85, 44)
        Me.BackButton.TabIndex = 75
        Me.BackButton.Text = "BACK"
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'SupplierQuoteLineItemManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = Global.M.I.S.S_Vendor_Order_Management_System.My.Resources.Resources.Background1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1173, 738)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "SupplierQuoteLineItemManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Supplier Quote Line Item Manager"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.ProductDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group16DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierQuoteLineItemDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierQuoteLineItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents ProductDataGridView As DataGridView
    Friend WithEvents SupplierQuoteLineItemDataGridView As DataGridView
    Friend WithEvents Group16DataSet As group16DataSet
    Friend WithEvents SupplierQuoteLineItemBindingSource As BindingSource
    Friend WithEvents Supplier_Quote_Line_ItemTableAdapter As group16DataSetTableAdapters.Supplier_Quote_Line_ItemTableAdapter
    Friend WithEvents ProductBindingSource As BindingSource
    Friend WithEvents ProductTableAdapter As group16DataSetTableAdapters.ProductTableAdapter
    Friend WithEvents BackButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents ClearButton As Button
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents SuppQuoteReferenceIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductIDDataGridViewTextBoxColumn As DataGridViewButtonColumn
    Friend WithEvents SuppLineItemCostPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SuppLineItemQuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RemoveLineItem As DataGridViewButtonColumn
    Friend WithEvents Edit As DataGridViewButtonColumn
    Friend WithEvents ProductIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ProductNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductBrandDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductDescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductActiveStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddLineItem As DataGridViewButtonColumn
    Friend WithEvents ToolTip1 As ToolTip
End Class

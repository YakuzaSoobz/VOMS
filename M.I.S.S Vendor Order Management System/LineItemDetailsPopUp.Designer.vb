﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LineItemDetailsPopUp
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
        Me.QuoteDetailsGroupBox = New System.Windows.Forms.GroupBox()
        Me.VATButton = New System.Windows.Forms.Button()
        Me.VATTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.QuantityComboBox = New System.Windows.Forms.ComboBox()
        Me.MarkupComboBox = New System.Windows.Forms.ComboBox()
        Me.DiscountComboBox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuppQuoteJoinSuppLineItemDataGridView = New System.Windows.Forms.DataGridView()
        Me.Supp_Quote_Reference_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Product_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Supp_Quote_Date_Recieved = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostPriceTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SupplierDataGridView = New System.Windows.Forms.DataGridView()
        Me.SupplierIDTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SaleExclVATTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SaleInclVATTextBox = New System.Windows.Forms.TextBox()
        Me.OptionsGroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.LineItemDetailsPopUpTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuppLineItemCostPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuppQuoteJoinSuppLineItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Group16DataSet = New M.I.S.S_Vendor_Order_Management_System.group16DataSet()
        Me.SupplierIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierTableAdapter = New M.I.S.S_Vendor_Order_Management_System.group16DataSetTableAdapters.SupplierTableAdapter()
        Me.SuppQuoteJoinSuppLineItemTableAdapter = New M.I.S.S_Vendor_Order_Management_System.group16DataSetTableAdapters.SuppQuoteJoinSuppLineItemTableAdapter()
        Me.QuoteDetailsGroupBox.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.SuppQuoteJoinSuppLineItemDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SupplierDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.OptionsGroupBox1.SuspendLayout()
        CType(Me.SuppQuoteJoinSuppLineItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group16DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QuoteDetailsGroupBox
        '
        Me.QuoteDetailsGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.QuoteDetailsGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.QuoteDetailsGroupBox.Controls.Add(Me.VATButton)
        Me.QuoteDetailsGroupBox.Controls.Add(Me.VATTextBox)
        Me.QuoteDetailsGroupBox.Controls.Add(Me.Label8)
        Me.QuoteDetailsGroupBox.Controls.Add(Me.GroupBox4)
        Me.QuoteDetailsGroupBox.Controls.Add(Me.GroupBox2)
        Me.QuoteDetailsGroupBox.Controls.Add(Me.GroupBox1)
        Me.QuoteDetailsGroupBox.Location = New System.Drawing.Point(11, 11)
        Me.QuoteDetailsGroupBox.Margin = New System.Windows.Forms.Padding(2)
        Me.QuoteDetailsGroupBox.Name = "QuoteDetailsGroupBox"
        Me.QuoteDetailsGroupBox.Padding = New System.Windows.Forms.Padding(2)
        Me.QuoteDetailsGroupBox.Size = New System.Drawing.Size(651, 399)
        Me.QuoteDetailsGroupBox.TabIndex = 69
        Me.QuoteDetailsGroupBox.TabStop = False
        Me.QuoteDetailsGroupBox.Text = "CUSTOMER QUOTE DETAILS"
        '
        'VATButton
        '
        Me.VATButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.VATButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.VATButton.FlatAppearance.BorderSize = 3
        Me.VATButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.VATButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.VATButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VATButton.Location = New System.Drawing.Point(328, 359)
        Me.VATButton.Margin = New System.Windows.Forms.Padding(2)
        Me.VATButton.Name = "VATButton"
        Me.VATButton.Size = New System.Drawing.Size(120, 29)
        Me.VATButton.TabIndex = 94
        Me.VATButton.Text = "SAVE NEW % VAT"
        Me.VATButton.UseVisualStyleBackColor = False
        '
        'VATTextBox
        '
        Me.VATTextBox.Location = New System.Drawing.Point(274, 364)
        Me.VATTextBox.Name = "VATTextBox"
        Me.VATTextBox.Size = New System.Drawing.Size(49, 20)
        Me.VATTextBox.TabIndex = 93
        Me.VATTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(221, 367)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 92
        Me.Label8.Text = "- % VAT:"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.QuantityComboBox)
        Me.GroupBox4.Controls.Add(Me.MarkupComboBox)
        Me.GroupBox4.Controls.Add(Me.DiscountComboBox)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Location = New System.Drawing.Point(486, 176)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Size = New System.Drawing.Size(148, 172)
        Me.GroupBox4.TabIndex = 91
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "ITEM DETAILS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(11, 19)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 86
        Me.Label3.Text = "- Selected Quanity:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(11, 70)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 13)
        Me.Label5.TabIndex = 90
        Me.Label5.Text = "- Selected Markup %:"
        '
        'QuantityComboBox
        '
        Me.QuantityComboBox.FormattingEnabled = True
        Me.QuantityComboBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.QuantityComboBox.Location = New System.Drawing.Point(14, 35)
        Me.QuantityComboBox.Name = "QuantityComboBox"
        Me.QuantityComboBox.Size = New System.Drawing.Size(121, 21)
        Me.QuantityComboBox.TabIndex = 85
        '
        'MarkupComboBox
        '
        Me.MarkupComboBox.FormattingEnabled = True
        Me.MarkupComboBox.Items.AddRange(New Object() {"10", "15", "20", "25", "30", "35", "40", "45", "50", "55", "60", "65", "70"})
        Me.MarkupComboBox.Location = New System.Drawing.Point(14, 86)
        Me.MarkupComboBox.Name = "MarkupComboBox"
        Me.MarkupComboBox.Size = New System.Drawing.Size(121, 21)
        Me.MarkupComboBox.TabIndex = 89
        '
        'DiscountComboBox
        '
        Me.DiscountComboBox.FormattingEnabled = True
        Me.DiscountComboBox.Items.AddRange(New Object() {"5", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55", "60", "65", "70"})
        Me.DiscountComboBox.Location = New System.Drawing.Point(14, 139)
        Me.DiscountComboBox.Name = "DiscountComboBox"
        Me.DiscountComboBox.Size = New System.Drawing.Size(121, 21)
        Me.DiscountComboBox.TabIndex = 87
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(11, 123)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 13)
        Me.Label4.TabIndex = 88
        Me.Label4.Text = "- Selected Discount %:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.SuppQuoteJoinSuppLineItemDataGridView)
        Me.GroupBox2.Controls.Add(Me.CostPriceTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 176)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(460, 172)
        Me.GroupBox2.TabIndex = 84
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SELECT COST PRICE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(8, 143)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 85
        Me.Label2.Text = "- Cost Price:"
        '
        'SuppQuoteJoinSuppLineItemDataGridView
        '
        Me.SuppQuoteJoinSuppLineItemDataGridView.AllowUserToAddRows = False
        Me.SuppQuoteJoinSuppLineItemDataGridView.AllowUserToDeleteRows = False
        Me.SuppQuoteJoinSuppLineItemDataGridView.AutoGenerateColumns = False
        Me.SuppQuoteJoinSuppLineItemDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SuppQuoteJoinSuppLineItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SuppQuoteJoinSuppLineItemDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Supp_Quote_Reference_ID, Me.Product_ID, Me.SuppLineItemCostPriceDataGridViewTextBoxColumn, Me.Supp_Quote_Date_Recieved})
        Me.SuppQuoteJoinSuppLineItemDataGridView.DataSource = Me.SuppQuoteJoinSuppLineItemBindingSource
        Me.SuppQuoteJoinSuppLineItemDataGridView.Location = New System.Drawing.Point(6, 19)
        Me.SuppQuoteJoinSuppLineItemDataGridView.Name = "SuppQuoteJoinSuppLineItemDataGridView"
        Me.SuppQuoteJoinSuppLineItemDataGridView.ReadOnly = True
        Me.SuppQuoteJoinSuppLineItemDataGridView.Size = New System.Drawing.Size(449, 115)
        Me.SuppQuoteJoinSuppLineItemDataGridView.TabIndex = 0
        '
        'Supp_Quote_Reference_ID
        '
        Me.Supp_Quote_Reference_ID.DataPropertyName = "Supp_Quote_Reference_ID"
        Me.Supp_Quote_Reference_ID.HeaderText = "Supplier Quote ID"
        Me.Supp_Quote_Reference_ID.Name = "Supp_Quote_Reference_ID"
        Me.Supp_Quote_Reference_ID.ReadOnly = True
        '
        'Product_ID
        '
        Me.Product_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Product_ID.DataPropertyName = "Product_ID"
        Me.Product_ID.HeaderText = "Product ID"
        Me.Product_ID.Name = "Product_ID"
        Me.Product_ID.ReadOnly = True
        '
        'Supp_Quote_Date_Recieved
        '
        Me.Supp_Quote_Date_Recieved.DataPropertyName = "Supp_Quote_Date_Recieved"
        Me.Supp_Quote_Date_Recieved.HeaderText = "Date Recieved"
        Me.Supp_Quote_Date_Recieved.Name = "Supp_Quote_Date_Recieved"
        Me.Supp_Quote_Date_Recieved.ReadOnly = True
        '
        'CostPriceTextBox
        '
        Me.CostPriceTextBox.Location = New System.Drawing.Point(81, 140)
        Me.CostPriceTextBox.Name = "CostPriceTextBox"
        Me.CostPriceTextBox.ReadOnly = True
        Me.CostPriceTextBox.Size = New System.Drawing.Size(96, 20)
        Me.CostPriceTextBox.TabIndex = 84
        Me.CostPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.SupplierDataGridView)
        Me.GroupBox1.Controls.Add(Me.SupplierIDTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 17)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(618, 155)
        Me.GroupBox1.TabIndex = 83
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SELECT SUPPLIER"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(8, 129)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "- Supplier ID:"
        '
        'SupplierDataGridView
        '
        Me.SupplierDataGridView.AllowUserToAddRows = False
        Me.SupplierDataGridView.AllowUserToDeleteRows = False
        Me.SupplierDataGridView.AutoGenerateColumns = False
        Me.SupplierDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SupplierDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SupplierDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SupplierIDDataGridViewTextBoxColumn, Me.SupplierNameDataGridViewTextBoxColumn})
        Me.SupplierDataGridView.DataSource = Me.SupplierBindingSource
        Me.SupplierDataGridView.Location = New System.Drawing.Point(6, 19)
        Me.SupplierDataGridView.Name = "SupplierDataGridView"
        Me.SupplierDataGridView.ReadOnly = True
        Me.SupplierDataGridView.Size = New System.Drawing.Size(599, 99)
        Me.SupplierDataGridView.TabIndex = 0
        '
        'SupplierIDTextBox
        '
        Me.SupplierIDTextBox.Location = New System.Drawing.Point(81, 126)
        Me.SupplierIDTextBox.Name = "SupplierIDTextBox"
        Me.SupplierIDTextBox.ReadOnly = True
        Me.SupplierIDTextBox.Size = New System.Drawing.Size(99, 20)
        Me.SupplierIDTextBox.TabIndex = 84
        Me.SupplierIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.SaleExclVATTextBox)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.SaleInclVATTextBox)
        Me.GroupBox3.Location = New System.Drawing.Point(375, 414)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(165, 121)
        Me.GroupBox3.TabIndex = 91
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "SALE PRICE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(12, 20)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 89
        Me.Label7.Text = "- Sale excl VAT:"
        '
        'SaleExclVATTextBox
        '
        Me.SaleExclVATTextBox.Location = New System.Drawing.Point(15, 38)
        Me.SaleExclVATTextBox.Name = "SaleExclVATTextBox"
        Me.SaleExclVATTextBox.ReadOnly = True
        Me.SaleExclVATTextBox.Size = New System.Drawing.Size(108, 20)
        Me.SaleExclVATTextBox.TabIndex = 88
        Me.SaleExclVATTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(14, 68)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 87
        Me.Label6.Text = "- Sale Incl VAT:"
        '
        'SaleInclVATTextBox
        '
        Me.SaleInclVATTextBox.Location = New System.Drawing.Point(15, 84)
        Me.SaleInclVATTextBox.Name = "SaleInclVATTextBox"
        Me.SaleInclVATTextBox.ReadOnly = True
        Me.SaleInclVATTextBox.Size = New System.Drawing.Size(108, 20)
        Me.SaleInclVATTextBox.TabIndex = 86
        Me.SaleInclVATTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OptionsGroupBox1
        '
        Me.OptionsGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.OptionsGroupBox1.Controls.Add(Me.SaveButton)
        Me.OptionsGroupBox1.Location = New System.Drawing.Point(124, 414)
        Me.OptionsGroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.OptionsGroupBox1.Name = "OptionsGroupBox1"
        Me.OptionsGroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.OptionsGroupBox1.Size = New System.Drawing.Size(238, 121)
        Me.OptionsGroupBox1.TabIndex = 82
        Me.OptionsGroupBox1.TabStop = False
        Me.OptionsGroupBox1.Text = "OPTIONS"
        '
        'SaveButton
        '
        Me.SaveButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SaveButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.SaveButton.FlatAppearance.BorderSize = 3
        Me.SaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.SaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveButton.Location = New System.Drawing.Point(8, 17)
        Me.SaveButton.Margin = New System.Windows.Forms.Padding(2)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(214, 87)
        Me.SaveButton.TabIndex = 1
        Me.SaveButton.Text = "SAVE"
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BackButton.FlatAppearance.BorderSize = 3
        Me.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.BackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Location = New System.Drawing.Point(599, 515)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(2)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(64, 36)
        Me.BackButton.TabIndex = 83
        Me.BackButton.Text = "BACK"
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'SuppLineItemCostPriceDataGridViewTextBoxColumn
        '
        Me.SuppLineItemCostPriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SuppLineItemCostPriceDataGridViewTextBoxColumn.DataPropertyName = "Supp_Line_Item_Cost_Price"
        Me.SuppLineItemCostPriceDataGridViewTextBoxColumn.HeaderText = "Cost Price"
        Me.SuppLineItemCostPriceDataGridViewTextBoxColumn.Name = "SuppLineItemCostPriceDataGridViewTextBoxColumn"
        Me.SuppLineItemCostPriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SuppQuoteJoinSuppLineItemBindingSource
        '
        Me.SuppQuoteJoinSuppLineItemBindingSource.DataMember = "SuppQuoteJoinSuppLineItem"
        Me.SuppQuoteJoinSuppLineItemBindingSource.DataSource = Me.Group16DataSet
        '
        'Group16DataSet
        '
        Me.Group16DataSet.DataSetName = "group16DataSet"
        Me.Group16DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SupplierIDDataGridViewTextBoxColumn
        '
        Me.SupplierIDDataGridViewTextBoxColumn.DataPropertyName = "Supplier_ID"
        Me.SupplierIDDataGridViewTextBoxColumn.HeaderText = "Supplier ID"
        Me.SupplierIDDataGridViewTextBoxColumn.Name = "SupplierIDDataGridViewTextBoxColumn"
        Me.SupplierIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.SupplierIDDataGridViewTextBoxColumn.Width = 109
        '
        'SupplierNameDataGridViewTextBoxColumn
        '
        Me.SupplierNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SupplierNameDataGridViewTextBoxColumn.DataPropertyName = "Supplier_Name"
        Me.SupplierNameDataGridViewTextBoxColumn.HeaderText = "Supplier Name"
        Me.SupplierNameDataGridViewTextBoxColumn.Name = "SupplierNameDataGridViewTextBoxColumn"
        Me.SupplierNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SupplierBindingSource
        '
        Me.SupplierBindingSource.DataMember = "Supplier"
        Me.SupplierBindingSource.DataSource = Me.Group16DataSet
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'SuppQuoteJoinSuppLineItemTableAdapter
        '
        Me.SuppQuoteJoinSuppLineItemTableAdapter.ClearBeforeFill = True
        '
        'LineItemDetailsPopUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.M.I.S.S_Vendor_Order_Management_System.My.Resources.Resources.Background1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(674, 562)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.OptionsGroupBox1)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.QuoteDetailsGroupBox)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "LineItemDetailsPopUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Line Item Details"
        Me.QuoteDetailsGroupBox.ResumeLayout(False)
        Me.QuoteDetailsGroupBox.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.SuppQuoteJoinSuppLineItemDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SupplierDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.OptionsGroupBox1.ResumeLayout(False)
        CType(Me.SuppQuoteJoinSuppLineItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group16DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents QuoteDetailsGroupBox As GroupBox
    Friend WithEvents OptionsGroupBox1 As GroupBox
    Friend WithEvents SaveButton As Button
    Friend WithEvents Group16DataSet As group16DataSet
    Friend WithEvents SupplierBindingSource As BindingSource
    Friend WithEvents SupplierTableAdapter As group16DataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents SupplierIDTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SupplierDataGridView As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents SuppQuoteJoinSuppLineItemDataGridView As DataGridView
    Friend WithEvents CostPriceTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SupplierIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SupplierNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents MarkupComboBox As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DiscountComboBox As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents QuantityComboBox As ComboBox
    Friend WithEvents SuppQuoteJoinSuppLineItemBindingSource As BindingSource
    Friend WithEvents SuppQuoteJoinSuppLineItemTableAdapter As group16DataSetTableAdapters.SuppQuoteJoinSuppLineItemTableAdapter
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents SaleExclVATTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents SaleInclVATTextBox As TextBox
    Friend WithEvents BackButton As Button
    Friend WithEvents LineItemDetailsPopUpTip As ToolTip
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Supp_Quote_Reference_ID As DataGridViewTextBoxColumn
    Friend WithEvents Product_ID As DataGridViewTextBoxColumn
    Friend WithEvents SuppLineItemCostPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Supp_Quote_Date_Recieved As DataGridViewTextBoxColumn
    Friend WithEvents VATButton As Button
    Friend WithEvents VATTextBox As TextBox
    Friend WithEvents Label8 As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewCustomerQuotePopUp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewCustomerQuotePopUp))
        Me.NavigationGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CustomerQuoteJoinCustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Group16DataSet = New M.I.S.S_Vendor_Order_Management_System.group16DataSet()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ProductIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductBrandDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustLineItemDiscountPercentageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustLineItemSaleexclVATDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustLineItemSaleinclVATDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustLineItemQuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustLineItemJoinProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InvoiceRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.PrintQuoteButton = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.BackButton = New System.Windows.Forms.Button()
        Me.CustLineItemJoinProductsTableAdapter = New M.I.S.S_Vendor_Order_Management_System.group16DataSetTableAdapters.CustLineItemJoinProductsTableAdapter()
        Me.CustomerQuoteJoinCustomerTableAdapter = New M.I.S.S_Vendor_Order_Management_System.group16DataSetTableAdapters.CustomerQuoteJoinCustomerTableAdapter()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TypeLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.NavigationGroupBox.SuspendLayout()
        CType(Me.CustomerQuoteJoinCustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group16DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustLineItemJoinProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NavigationGroupBox
        '
        Me.NavigationGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.NavigationGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NavigationGroupBox.Controls.Add(Me.PictureBox1)
        Me.NavigationGroupBox.Controls.Add(Me.TypeLabel)
        Me.NavigationGroupBox.Controls.Add(Me.Label17)
        Me.NavigationGroupBox.Controls.Add(Me.Label16)
        Me.NavigationGroupBox.Controls.Add(Me.Label15)
        Me.NavigationGroupBox.Controls.Add(Me.Label14)
        Me.NavigationGroupBox.Controls.Add(Me.Label13)
        Me.NavigationGroupBox.Controls.Add(Me.Label12)
        Me.NavigationGroupBox.Controls.Add(Me.Label11)
        Me.NavigationGroupBox.Controls.Add(Me.Label10)
        Me.NavigationGroupBox.Controls.Add(Me.Label9)
        Me.NavigationGroupBox.Controls.Add(Me.Label8)
        Me.NavigationGroupBox.Controls.Add(Me.Label7)
        Me.NavigationGroupBox.Controls.Add(Me.Label6)
        Me.NavigationGroupBox.Controls.Add(Me.Label5)
        Me.NavigationGroupBox.Controls.Add(Me.Label4)
        Me.NavigationGroupBox.Controls.Add(Me.Label3)
        Me.NavigationGroupBox.Controls.Add(Me.Label2)
        Me.NavigationGroupBox.Controls.Add(Me.Label1)
        Me.NavigationGroupBox.Controls.Add(Me.DataGridView1)
        Me.NavigationGroupBox.Controls.Add(Me.InvoiceRichTextBox)
        Me.NavigationGroupBox.Location = New System.Drawing.Point(11, 11)
        Me.NavigationGroupBox.Margin = New System.Windows.Forms.Padding(2)
        Me.NavigationGroupBox.Name = "NavigationGroupBox"
        Me.NavigationGroupBox.Padding = New System.Windows.Forms.Padding(2)
        Me.NavigationGroupBox.Size = New System.Drawing.Size(586, 574)
        Me.NavigationGroupBox.TabIndex = 20
        Me.NavigationGroupBox.TabStop = False
        Me.NavigationGroupBox.Text = "INVOICE"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerQuoteJoinCustomerBindingSource, "Cust_Quote_Date_Accepted", True))
        Me.Label10.Location = New System.Drawing.Point(496, 183)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Date Accepted"
        '
        'CustomerQuoteJoinCustomerBindingSource
        '
        Me.CustomerQuoteJoinCustomerBindingSource.DataMember = "CustomerQuoteJoinCustomer"
        Me.CustomerQuoteJoinCustomerBindingSource.DataSource = Me.Group16DataSet
        '
        'Group16DataSet
        '
        Me.Group16DataSet.DataSetName = "group16DataSet"
        Me.Group16DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(408, 183)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Date Accepted:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerQuoteJoinCustomerBindingSource, "Cust__Quote_Total_Price", True))
        Me.Label8.Location = New System.Drawing.Point(325, 545)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Price"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(223, 545)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Total Price:         R"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerQuoteJoinCustomerBindingSource, "Cust_Quote_Date_Issued", True))
        Me.Label6.Location = New System.Drawing.Point(499, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Date Issued"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(408, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Date Issued:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerQuoteJoinCustomerBindingSource, "Cust_FName", True))
        Me.Label4.Location = New System.Drawing.Point(104, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Customer Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(13, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Customer Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerQuoteJoinCustomerBindingSource, "Cust_Quote_Reference_ID", True))
        Me.Label2.Location = New System.Drawing.Point(72, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Quote ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 157)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Quote ID:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductIDDataGridViewTextBoxColumn, Me.ProductNameDataGridViewTextBoxColumn, Me.ProductBrandDataGridViewTextBoxColumn, Me.CustLineItemDiscountPercentageDataGridViewTextBoxColumn, Me.CustLineItemSaleexclVATDataGridViewTextBoxColumn, Me.CustLineItemSaleinclVATDataGridViewTextBoxColumn, Me.CustLineItemQuantityDataGridViewTextBoxColumn, Me.SupplierNameDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CustLineItemJoinProductsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(14, 213)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(566, 330)
        Me.DataGridView1.TabIndex = 1
        '
        'ProductIDDataGridViewTextBoxColumn
        '
        Me.ProductIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProductIDDataGridViewTextBoxColumn.DataPropertyName = "Product_ID"
        Me.ProductIDDataGridViewTextBoxColumn.HeaderText = "Product ID"
        Me.ProductIDDataGridViewTextBoxColumn.Name = "ProductIDDataGridViewTextBoxColumn"
        '
        'ProductNameDataGridViewTextBoxColumn
        '
        Me.ProductNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProductNameDataGridViewTextBoxColumn.DataPropertyName = "Product_Name"
        Me.ProductNameDataGridViewTextBoxColumn.HeaderText = "Product Name"
        Me.ProductNameDataGridViewTextBoxColumn.Name = "ProductNameDataGridViewTextBoxColumn"
        '
        'ProductBrandDataGridViewTextBoxColumn
        '
        Me.ProductBrandDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProductBrandDataGridViewTextBoxColumn.DataPropertyName = "Product_Brand"
        Me.ProductBrandDataGridViewTextBoxColumn.HeaderText = "Product Brand"
        Me.ProductBrandDataGridViewTextBoxColumn.Name = "ProductBrandDataGridViewTextBoxColumn"
        '
        'CustLineItemDiscountPercentageDataGridViewTextBoxColumn
        '
        Me.CustLineItemDiscountPercentageDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CustLineItemDiscountPercentageDataGridViewTextBoxColumn.DataPropertyName = "Cust_Line_Item_Discount_Percentage"
        Me.CustLineItemDiscountPercentageDataGridViewTextBoxColumn.HeaderText = "Discount Percentage"
        Me.CustLineItemDiscountPercentageDataGridViewTextBoxColumn.Name = "CustLineItemDiscountPercentageDataGridViewTextBoxColumn"
        '
        'CustLineItemSaleexclVATDataGridViewTextBoxColumn
        '
        Me.CustLineItemSaleexclVATDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CustLineItemSaleexclVATDataGridViewTextBoxColumn.DataPropertyName = "Cust_Line_Item_Sale_excl_VAT"
        Me.CustLineItemSaleexclVATDataGridViewTextBoxColumn.HeaderText = "Sale excl VAT"
        Me.CustLineItemSaleexclVATDataGridViewTextBoxColumn.Name = "CustLineItemSaleexclVATDataGridViewTextBoxColumn"
        '
        'CustLineItemSaleinclVATDataGridViewTextBoxColumn
        '
        Me.CustLineItemSaleinclVATDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CustLineItemSaleinclVATDataGridViewTextBoxColumn.DataPropertyName = "Cust_Line_Item_Sale_incl_VAT"
        Me.CustLineItemSaleinclVATDataGridViewTextBoxColumn.HeaderText = "Sale incl VAT"
        Me.CustLineItemSaleinclVATDataGridViewTextBoxColumn.Name = "CustLineItemSaleinclVATDataGridViewTextBoxColumn"
        '
        'CustLineItemQuantityDataGridViewTextBoxColumn
        '
        Me.CustLineItemQuantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CustLineItemQuantityDataGridViewTextBoxColumn.DataPropertyName = "Cust_Line_Item_Quantity"
        Me.CustLineItemQuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.CustLineItemQuantityDataGridViewTextBoxColumn.Name = "CustLineItemQuantityDataGridViewTextBoxColumn"
        '
        'SupplierNameDataGridViewTextBoxColumn
        '
        Me.SupplierNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SupplierNameDataGridViewTextBoxColumn.DataPropertyName = "Supplier_Name"
        Me.SupplierNameDataGridViewTextBoxColumn.HeaderText = "Supplier Name"
        Me.SupplierNameDataGridViewTextBoxColumn.Name = "SupplierNameDataGridViewTextBoxColumn"
        '
        'CustLineItemJoinProductsBindingSource
        '
        Me.CustLineItemJoinProductsBindingSource.DataMember = "CustLineItemJoinProducts"
        Me.CustLineItemJoinProductsBindingSource.DataSource = Me.Group16DataSet
        '
        'InvoiceRichTextBox
        '
        Me.InvoiceRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InvoiceRichTextBox.Location = New System.Drawing.Point(2, 15)
        Me.InvoiceRichTextBox.Name = "InvoiceRichTextBox"
        Me.InvoiceRichTextBox.Size = New System.Drawing.Size(582, 557)
        Me.InvoiceRichTextBox.TabIndex = 0
        Me.InvoiceRichTextBox.Text = ""
        '
        'PrintQuoteButton
        '
        Me.PrintQuoteButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PrintQuoteButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.PrintQuoteButton.FlatAppearance.BorderSize = 3
        Me.PrintQuoteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.PrintQuoteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.PrintQuoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PrintQuoteButton.Location = New System.Drawing.Point(218, 599)
        Me.PrintQuoteButton.Margin = New System.Windows.Forms.Padding(2)
        Me.PrintQuoteButton.Name = "PrintQuoteButton"
        Me.PrintQuoteButton.Size = New System.Drawing.Size(177, 33)
        Me.PrintQuoteButton.TabIndex = 51
        Me.PrintQuoteButton.Text = "PRINT CUSTOMER QUOTE"
        Me.PrintQuoteButton.UseVisualStyleBackColor = False
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BackButton.FlatAppearance.BorderSize = 3
        Me.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.BackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Location = New System.Drawing.Point(519, 590)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(79, 42)
        Me.BackButton.TabIndex = 52
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'CustLineItemJoinProductsTableAdapter
        '
        Me.CustLineItemJoinProductsTableAdapter.ClearBeforeFill = True
        '
        'CustomerQuoteJoinCustomerTableAdapter
        '
        Me.CustomerQuoteJoinCustomerTableAdapter.ClearBeforeFill = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(72, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(445, 24)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Mhlathuze Industrial Suppliers and Services cc"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(13, 185)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 13)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Issued By:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerQuoteJoinCustomerBindingSource, "Employee_FName", True))
        Me.Label13.Location = New System.Drawing.Point(75, 185)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 13)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Quote ID"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerQuoteJoinCustomerBindingSource, "Employee_SName", True))
        Me.Label14.Location = New System.Drawing.Point(129, 185)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 13)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "Quote ID"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(129, 50)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(158, 16)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "mhlatuzeISS@gmail.com"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(327, 50)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(92, 16)
        Me.Label16.TabIndex = 17
        Me.Label16.Text = "(031) 234 5098"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.White
        Me.Label17.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerQuoteJoinCustomerBindingSource, "Cust_SName", True))
        Me.Label17.Location = New System.Drawing.Point(183, 127)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(82, 13)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "Customer Name"
        '
        'TypeLabel
        '
        Me.TypeLabel.AutoSize = True
        Me.TypeLabel.BackColor = System.Drawing.Color.White
        Me.TypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TypeLabel.Location = New System.Drawing.Point(13, 96)
        Me.TypeLabel.Name = "TypeLabel"
        Me.TypeLabel.Size = New System.Drawing.Size(127, 16)
        Me.TypeLabel.TabIndex = 19
        Me.TypeLabel.Text = "Customer Quote:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.M.I.S.S_Vendor_Order_Management_System.My.Resources.Resources.M_I_S_S_Logo
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(411, 68)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(152, 84)
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'ViewCustomerQuotePopUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.M.I.S.S_Vendor_Order_Management_System.My.Resources.Resources.Background1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(608, 643)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.PrintQuoteButton)
        Me.Controls.Add(Me.NavigationGroupBox)
        Me.DoubleBuffered = True
        Me.Name = "ViewCustomerQuotePopUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Customer Quote"
        Me.NavigationGroupBox.ResumeLayout(False)
        Me.NavigationGroupBox.PerformLayout()
        CType(Me.CustomerQuoteJoinCustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group16DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustLineItemJoinProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NavigationGroupBox As GroupBox
    Friend WithEvents InvoiceRichTextBox As RichTextBox
    Friend WithEvents PrintQuoteButton As Button
    Friend WithEvents PrintForm1 As PowerPacks.Printing.PrintForm
    Friend WithEvents BackButton As Button
    Friend WithEvents Group16DataSet As group16DataSet
    Friend WithEvents CustLineItemJoinProductsBindingSource As BindingSource
    Friend WithEvents CustLineItemJoinProductsTableAdapter As group16DataSetTableAdapters.CustLineItemJoinProductsTableAdapter
    Friend WithEvents CustomerQuoteJoinCustomerBindingSource As BindingSource
    Friend WithEvents CustomerQuoteJoinCustomerTableAdapter As group16DataSetTableAdapters.CustomerQuoteJoinCustomerTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ProductIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductBrandDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustLineItemDiscountPercentageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustLineItemSaleexclVATDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustLineItemSaleinclVATDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustLineItemQuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SupplierNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TypeLabel As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class

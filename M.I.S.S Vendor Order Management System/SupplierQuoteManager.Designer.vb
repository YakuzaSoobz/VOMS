<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SupplierQuoteManager
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.SuppLineItemJoinProductDataGridView = New System.Windows.Forms.DataGridView()
        Me.SuppQuoteReferenceIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuppLineItemCostPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuppLineItemQuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuppLineItemJoinProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Group16DataSet = New M.I.S.S_Vendor_Order_Management_System.group16DataSet()
        Me.SupplierQuoteJoinSupplierDataGridView = New System.Windows.Forms.DataGridView()
        Me.SuppQuoteReferenceIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuppQuoteTotalPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuppQuoteDateRecievedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuppQuoteAcceptanceStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuppQuoteDateAcceptanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.SupplierNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierPhoneNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierEmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierRepFNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierRepSNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierQuoteJoinSupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BackButton = New System.Windows.Forms.Button()
        Me.LogOutButton = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.ViewButton = New System.Windows.Forms.Button()
        Me.CreateButton = New System.Windows.Forms.Button()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableAdapterManager = New M.I.S.S_Vendor_Order_Management_System.group16DataSetTableAdapters.TableAdapterManager()
        Me.SuppLineItemJoinProductTableAdapter = New M.I.S.S_Vendor_Order_Management_System.group16DataSetTableAdapters.SuppLineItemJoinProductTableAdapter()
        Me.SupplierQuoteJoinSupplierTableAdapter = New M.I.S.S_Vendor_Order_Management_System.group16DataSetTableAdapters.SupplierQuoteJoinSupplierTableAdapter()
        Me.HelpBtn = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.HP1 = New System.Windows.Forms.HelpProvider()
        Me.NavigationGroupBox.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.SuppLineItemJoinProductDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuppLineItemJoinProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group16DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierQuoteJoinSupplierDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierQuoteJoinSupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'NavigationGroupBox
        '
        Me.NavigationGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.NavigationGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NavigationGroupBox.Controls.Add(Me.GroupBox5)
        Me.NavigationGroupBox.Controls.Add(Me.GroupBox3)
        Me.NavigationGroupBox.Location = New System.Drawing.Point(16, 14)
        Me.NavigationGroupBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NavigationGroupBox.Name = "NavigationGroupBox"
        Me.NavigationGroupBox.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NavigationGroupBox.Size = New System.Drawing.Size(1525, 129)
        Me.NavigationGroupBox.TabIndex = 20
        Me.NavigationGroupBox.TabStop = False
        Me.NavigationGroupBox.Text = "SEARCH OPTIONS"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.SortButton)
        Me.GroupBox5.Controls.Add(Me.SortComboBox)
        Me.GroupBox5.Location = New System.Drawing.Point(767, 21)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox5.Size = New System.Drawing.Size(716, 92)
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
        Me.SortButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.SortButton.FlatAppearance.BorderSize = 3
        Me.SortButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.SortButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.SortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SortButton.Location = New System.Drawing.Point(429, 34)
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
        Me.SortComboBox.Items.AddRange(New Object() {"Show only Accepted Orders", "Show only Non-Accepted Orders", "Date Quote was Recieved", "Supplier Name (Alphabetical Order)"})
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
        Me.GroupBox3.Size = New System.Drawing.Size(716, 92)
        Me.GroupBox3.TabIndex = 35
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "SEARCH"
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
        Me.SearchButton.BackColor = System.Drawing.Color.Transparent
        Me.SearchButton.BackgroundImage = Global.M.I.S.S_Vendor_Order_Management_System.My.Resources.Resources.search
        Me.SearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.SearchButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.SearchButton.FlatAppearance.BorderSize = 0
        Me.SearchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.SearchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchButton.Location = New System.Drawing.Point(549, 39)
        Me.SearchButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(41, 30)
        Me.SearchButton.TabIndex = 99
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
        Me.SearchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SearchComboBox.FormattingEnabled = True
        Me.SearchComboBox.Items.AddRange(New Object() {"Supplier ID", "Quote Reference ID", "Supplier Name", "Rep Name"})
        Me.SearchComboBox.Location = New System.Drawing.Point(352, 43)
        Me.SearchComboBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SearchComboBox.MaxDropDownItems = 100
        Me.SearchComboBox.Name = "SearchComboBox"
        Me.SearchComboBox.Size = New System.Drawing.Size(191, 24)
        Me.SearchComboBox.TabIndex = 98
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.SupplierQuoteJoinSupplierDataGridView)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 148)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(1528, 583)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SUPPLIER QUOTES"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox4.Controls.Add(Me.SuppLineItemJoinProductDataGridView)
        Me.GroupBox4.Location = New System.Drawing.Point(108, 334)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(1303, 245)
        Me.GroupBox4.TabIndex = 55
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "LIST OF LINE ITEMS IN SUPPLIER QUOTE"
        '
        'SuppLineItemJoinProductDataGridView
        '
        Me.SuppLineItemJoinProductDataGridView.AllowUserToAddRows = False
        Me.SuppLineItemJoinProductDataGridView.AllowUserToDeleteRows = False
        Me.SuppLineItemJoinProductDataGridView.AutoGenerateColumns = False
        Me.SuppLineItemJoinProductDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SuppLineItemJoinProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SuppLineItemJoinProductDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SuppQuoteReferenceIDDataGridViewTextBoxColumn1, Me.ProductIDDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.SuppLineItemCostPriceDataGridViewTextBoxColumn, Me.SuppLineItemQuantityDataGridViewTextBoxColumn})
        Me.SuppLineItemJoinProductDataGridView.DataSource = Me.SuppLineItemJoinProductBindingSource
        Me.SuppLineItemJoinProductDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuppLineItemJoinProductDataGridView.Location = New System.Drawing.Point(3, 17)
        Me.SuppLineItemJoinProductDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.SuppLineItemJoinProductDataGridView.Name = "SuppLineItemJoinProductDataGridView"
        Me.SuppLineItemJoinProductDataGridView.ReadOnly = True
        Me.SuppLineItemJoinProductDataGridView.Size = New System.Drawing.Size(1297, 226)
        Me.SuppLineItemJoinProductDataGridView.TabIndex = 0
        '
        'SuppQuoteReferenceIDDataGridViewTextBoxColumn1
        '
        Me.SuppQuoteReferenceIDDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SuppQuoteReferenceIDDataGridViewTextBoxColumn1.DataPropertyName = "Supp_Quote_Reference_ID"
        Me.SuppQuoteReferenceIDDataGridViewTextBoxColumn1.HeaderText = "Quote Reference ID"
        Me.SuppQuoteReferenceIDDataGridViewTextBoxColumn1.Name = "SuppQuoteReferenceIDDataGridViewTextBoxColumn1"
        Me.SuppQuoteReferenceIDDataGridViewTextBoxColumn1.ReadOnly = True
        Me.SuppQuoteReferenceIDDataGridViewTextBoxColumn1.ToolTipText = "Quote Reference ID "
        '
        'ProductIDDataGridViewTextBoxColumn
        '
        Me.ProductIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProductIDDataGridViewTextBoxColumn.DataPropertyName = "Product_ID"
        Me.ProductIDDataGridViewTextBoxColumn.HeaderText = "Product ID"
        Me.ProductIDDataGridViewTextBoxColumn.Name = "ProductIDDataGridViewTextBoxColumn"
        Me.ProductIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductIDDataGridViewTextBoxColumn.ToolTipText = "Product ID"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Product_Name"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.ToolTipText = "Product name"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Product_Brand"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Brand"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.ToolTipText = "Product Brand"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Product_Description"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.ToolTipText = "Product Description"
        '
        'SuppLineItemCostPriceDataGridViewTextBoxColumn
        '
        Me.SuppLineItemCostPriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SuppLineItemCostPriceDataGridViewTextBoxColumn.DataPropertyName = "Supp_Line_Item_Cost_Price"
        Me.SuppLineItemCostPriceDataGridViewTextBoxColumn.HeaderText = "Cost Price"
        Me.SuppLineItemCostPriceDataGridViewTextBoxColumn.Name = "SuppLineItemCostPriceDataGridViewTextBoxColumn"
        Me.SuppLineItemCostPriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.SuppLineItemCostPriceDataGridViewTextBoxColumn.ToolTipText = "Cost price of the item"
        '
        'SuppLineItemQuantityDataGridViewTextBoxColumn
        '
        Me.SuppLineItemQuantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SuppLineItemQuantityDataGridViewTextBoxColumn.DataPropertyName = "Supp_Line_Item_Quantity"
        Me.SuppLineItemQuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.SuppLineItemQuantityDataGridViewTextBoxColumn.Name = "SuppLineItemQuantityDataGridViewTextBoxColumn"
        Me.SuppLineItemQuantityDataGridViewTextBoxColumn.ReadOnly = True
        Me.SuppLineItemQuantityDataGridViewTextBoxColumn.ToolTipText = "Quantity of the item"
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
        'SupplierQuoteJoinSupplierDataGridView
        '
        Me.SupplierQuoteJoinSupplierDataGridView.AllowUserToAddRows = False
        Me.SupplierQuoteJoinSupplierDataGridView.AllowUserToDeleteRows = False
        Me.SupplierQuoteJoinSupplierDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SupplierQuoteJoinSupplierDataGridView.AutoGenerateColumns = False
        Me.SupplierQuoteJoinSupplierDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SupplierQuoteJoinSupplierDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SupplierQuoteJoinSupplierDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SuppQuoteReferenceIDDataGridViewTextBoxColumn, Me.SuppQuoteTotalPriceDataGridViewTextBoxColumn, Me.SuppQuoteDateRecievedDataGridViewTextBoxColumn, Me.SuppQuoteAcceptanceStatusDataGridViewTextBoxColumn, Me.SuppQuoteDateAcceptanceDataGridViewTextBoxColumn, Me.SupplierIDDataGridViewTextBoxColumn, Me.SupplierNameDataGridViewTextBoxColumn, Me.SupplierPhoneNoDataGridViewTextBoxColumn, Me.SupplierEmailDataGridViewTextBoxColumn, Me.SupplierRepFNameDataGridViewTextBoxColumn, Me.SupplierRepSNameDataGridViewTextBoxColumn})
        Me.SupplierQuoteJoinSupplierDataGridView.DataSource = Me.SupplierQuoteJoinSupplierBindingSource
        Me.SupplierQuoteJoinSupplierDataGridView.Location = New System.Drawing.Point(5, 21)
        Me.SupplierQuoteJoinSupplierDataGridView.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SupplierQuoteJoinSupplierDataGridView.Name = "SupplierQuoteJoinSupplierDataGridView"
        Me.SupplierQuoteJoinSupplierDataGridView.ReadOnly = True
        Me.SupplierQuoteJoinSupplierDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.SupplierQuoteJoinSupplierDataGridView.RowTemplate.Height = 24
        Me.SupplierQuoteJoinSupplierDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SupplierQuoteJoinSupplierDataGridView.Size = New System.Drawing.Size(1516, 308)
        Me.SupplierQuoteJoinSupplierDataGridView.TabIndex = 0
        '
        'SuppQuoteReferenceIDDataGridViewTextBoxColumn
        '
        Me.SuppQuoteReferenceIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SuppQuoteReferenceIDDataGridViewTextBoxColumn.DataPropertyName = "Supp_Quote_Reference_ID"
        Me.SuppQuoteReferenceIDDataGridViewTextBoxColumn.HeaderText = "Quote Reference ID"
        Me.SuppQuoteReferenceIDDataGridViewTextBoxColumn.Name = "SuppQuoteReferenceIDDataGridViewTextBoxColumn"
        Me.SuppQuoteReferenceIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.SuppQuoteReferenceIDDataGridViewTextBoxColumn.ToolTipText = "Supplier Quote Reference ID"
        '
        'SuppQuoteTotalPriceDataGridViewTextBoxColumn
        '
        Me.SuppQuoteTotalPriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SuppQuoteTotalPriceDataGridViewTextBoxColumn.DataPropertyName = "Supp_Quote_Total_Price"
        Me.SuppQuoteTotalPriceDataGridViewTextBoxColumn.HeaderText = "Total Price"
        Me.SuppQuoteTotalPriceDataGridViewTextBoxColumn.Name = "SuppQuoteTotalPriceDataGridViewTextBoxColumn"
        Me.SuppQuoteTotalPriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.SuppQuoteTotalPriceDataGridViewTextBoxColumn.ToolTipText = "Total Quote Amount"
        '
        'SuppQuoteDateRecievedDataGridViewTextBoxColumn
        '
        Me.SuppQuoteDateRecievedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SuppQuoteDateRecievedDataGridViewTextBoxColumn.DataPropertyName = "Supp_Quote_Date_Recieved"
        Me.SuppQuoteDateRecievedDataGridViewTextBoxColumn.HeaderText = "Date Recieved"
        Me.SuppQuoteDateRecievedDataGridViewTextBoxColumn.Name = "SuppQuoteDateRecievedDataGridViewTextBoxColumn"
        Me.SuppQuoteDateRecievedDataGridViewTextBoxColumn.ReadOnly = True
        Me.SuppQuoteDateRecievedDataGridViewTextBoxColumn.ToolTipText = "The date the quote was recieved by our company"
        '
        'SuppQuoteAcceptanceStatusDataGridViewTextBoxColumn
        '
        Me.SuppQuoteAcceptanceStatusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SuppQuoteAcceptanceStatusDataGridViewTextBoxColumn.DataPropertyName = "Supp_Quote_Acceptance_Status"
        Me.SuppQuoteAcceptanceStatusDataGridViewTextBoxColumn.HeaderText = "Quote Acceptance Status"
        Me.SuppQuoteAcceptanceStatusDataGridViewTextBoxColumn.Name = "SuppQuoteAcceptanceStatusDataGridViewTextBoxColumn"
        Me.SuppQuoteAcceptanceStatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.SuppQuoteAcceptanceStatusDataGridViewTextBoxColumn.ToolTipText = "Quote was accepted and an order was placed? True or False"
        '
        'SuppQuoteDateAcceptanceDataGridViewTextBoxColumn
        '
        Me.SuppQuoteDateAcceptanceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SuppQuoteDateAcceptanceDataGridViewTextBoxColumn.DataPropertyName = "Supp_Quote_Date_Acceptance"
        Me.SuppQuoteDateAcceptanceDataGridViewTextBoxColumn.HeaderText = "Quote Date Acceptance"
        Me.SuppQuoteDateAcceptanceDataGridViewTextBoxColumn.Name = "SuppQuoteDateAcceptanceDataGridViewTextBoxColumn"
        Me.SuppQuoteDateAcceptanceDataGridViewTextBoxColumn.ReadOnly = True
        Me.SuppQuoteDateAcceptanceDataGridViewTextBoxColumn.ToolTipText = "Date that the quote was accepted and an order was placed"
        '
        'SupplierIDDataGridViewTextBoxColumn
        '
        Me.SupplierIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SupplierIDDataGridViewTextBoxColumn.DataPropertyName = "Supplier_ID"
        Me.SupplierIDDataGridViewTextBoxColumn.HeaderText = "Supplier ID"
        Me.SupplierIDDataGridViewTextBoxColumn.Name = "SupplierIDDataGridViewTextBoxColumn"
        Me.SupplierIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.SupplierIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SupplierIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.SupplierIDDataGridViewTextBoxColumn.ToolTipText = "Supplier ID"
        '
        'SupplierNameDataGridViewTextBoxColumn
        '
        Me.SupplierNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SupplierNameDataGridViewTextBoxColumn.DataPropertyName = "Supplier_Name"
        Me.SupplierNameDataGridViewTextBoxColumn.HeaderText = "Supplier Name"
        Me.SupplierNameDataGridViewTextBoxColumn.Name = "SupplierNameDataGridViewTextBoxColumn"
        Me.SupplierNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.SupplierNameDataGridViewTextBoxColumn.ToolTipText = "Supplier company name"
        '
        'SupplierPhoneNoDataGridViewTextBoxColumn
        '
        Me.SupplierPhoneNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SupplierPhoneNoDataGridViewTextBoxColumn.DataPropertyName = "Supplier_Phone_No"
        Me.SupplierPhoneNoDataGridViewTextBoxColumn.HeaderText = "Supplier Phone No"
        Me.SupplierPhoneNoDataGridViewTextBoxColumn.Name = "SupplierPhoneNoDataGridViewTextBoxColumn"
        Me.SupplierPhoneNoDataGridViewTextBoxColumn.ReadOnly = True
        Me.SupplierPhoneNoDataGridViewTextBoxColumn.ToolTipText = "Supplier phone number"
        '
        'SupplierEmailDataGridViewTextBoxColumn
        '
        Me.SupplierEmailDataGridViewTextBoxColumn.DataPropertyName = "Supplier_Email"
        Me.SupplierEmailDataGridViewTextBoxColumn.HeaderText = "Supplier Email"
        Me.SupplierEmailDataGridViewTextBoxColumn.Name = "SupplierEmailDataGridViewTextBoxColumn"
        Me.SupplierEmailDataGridViewTextBoxColumn.ReadOnly = True
        Me.SupplierEmailDataGridViewTextBoxColumn.ToolTipText = "Supplier email address"
        '
        'SupplierRepFNameDataGridViewTextBoxColumn
        '
        Me.SupplierRepFNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SupplierRepFNameDataGridViewTextBoxColumn.DataPropertyName = "Supplier_Rep_FName"
        Me.SupplierRepFNameDataGridViewTextBoxColumn.HeaderText = "Rep First Name"
        Me.SupplierRepFNameDataGridViewTextBoxColumn.Name = "SupplierRepFNameDataGridViewTextBoxColumn"
        Me.SupplierRepFNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.SupplierRepFNameDataGridViewTextBoxColumn.ToolTipText = "The representative's first name"
        '
        'SupplierRepSNameDataGridViewTextBoxColumn
        '
        Me.SupplierRepSNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SupplierRepSNameDataGridViewTextBoxColumn.DataPropertyName = "Supplier_Rep_SName"
        Me.SupplierRepSNameDataGridViewTextBoxColumn.HeaderText = "Rep Surname"
        Me.SupplierRepSNameDataGridViewTextBoxColumn.Name = "SupplierRepSNameDataGridViewTextBoxColumn"
        Me.SupplierRepSNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.SupplierRepSNameDataGridViewTextBoxColumn.ToolTipText = "The representative's surname"
        '
        'SupplierQuoteJoinSupplierBindingSource
        '
        Me.SupplierQuoteJoinSupplierBindingSource.DataMember = "SupplierQuoteJoinSupplier"
        Me.SupplierQuoteJoinSupplierBindingSource.DataSource = Me.Group16DataSet
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BackButton.FlatAppearance.BorderSize = 3
        Me.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.BackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Location = New System.Drawing.Point(1460, 816)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(85, 44)
        Me.BackButton.TabIndex = 29
        Me.BackButton.Text = "BACK"
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'LogOutButton
        '
        Me.LogOutButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogOutButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.LogOutButton.FlatAppearance.BorderSize = 3
        Me.LogOutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.LogOutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.LogOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogOutButton.Location = New System.Drawing.Point(15, 816)
        Me.LogOutButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LogOutButton.Name = "LogOutButton"
        Me.LogOutButton.Size = New System.Drawing.Size(99, 44)
        Me.LogOutButton.TabIndex = 34
        Me.LogOutButton.Text = "LOG OUT"
        Me.LogOutButton.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox2.Controls.Add(Me.EditButton)
        Me.GroupBox2.Controls.Add(Me.ViewButton)
        Me.GroupBox2.Controls.Add(Me.CreateButton)
        Me.GroupBox2.Controls.Add(Me.RefreshButton)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 736)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(1527, 75)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "OPTIONS"
        '
        'EditButton
        '
        Me.EditButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EditButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.EditButton.FlatAppearance.BorderSize = 3
        Me.EditButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.EditButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditButton.Location = New System.Drawing.Point(843, 21)
        Me.EditButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(251, 41)
        Me.EditButton.TabIndex = 51
        Me.EditButton.Text = "EDIT QUOTE"
        Me.EditButton.UseVisualStyleBackColor = False
        '
        'ViewButton
        '
        Me.ViewButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ViewButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ViewButton.FlatAppearance.BorderSize = 3
        Me.ViewButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.ViewButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.ViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ViewButton.Location = New System.Drawing.Point(49, 21)
        Me.ViewButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ViewButton.Name = "ViewButton"
        Me.ViewButton.Size = New System.Drawing.Size(251, 41)
        Me.ViewButton.TabIndex = 8
        Me.ViewButton.Text = "VIEW QUOTE"
        Me.ViewButton.UseVisualStyleBackColor = False
        '
        'CreateButton
        '
        Me.CreateButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CreateButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.CreateButton.FlatAppearance.BorderSize = 3
        Me.CreateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.CreateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.CreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CreateButton.Location = New System.Drawing.Point(432, 21)
        Me.CreateButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CreateButton.Name = "CreateButton"
        Me.CreateButton.Size = New System.Drawing.Size(256, 41)
        Me.CreateButton.TabIndex = 7
        Me.CreateButton.Text = "CREATE NEW SUPPLIER QUOTE"
        Me.CreateButton.UseVisualStyleBackColor = False
        '
        'RefreshButton
        '
        Me.RefreshButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RefreshButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.RefreshButton.FlatAppearance.BorderSize = 3
        Me.RefreshButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.RefreshButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RefreshButton.Location = New System.Drawing.Point(1235, 18)
        Me.RefreshButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(251, 41)
        Me.RefreshButton.TabIndex = 5
        Me.RefreshButton.Text = "REFRESH"
        Me.RefreshButton.UseVisualStyleBackColor = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Supp_Quote_Reference_ID"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Supp_Quote_Reference_ID"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Product_ID"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Product_ID"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Supp_Line_Item_Cost_Price"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Supp_Line_Item_Cost_Price"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Supp_Line_Item_Quantity"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Supp_Line_Item_Quantity"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.Customer_Quote_Line_ItemTableAdapter = Nothing
        Me.TableAdapterManager.Customer_QuoteTableAdapter = Nothing
        Me.TableAdapterManager.CustomerTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeTableAdapter = Nothing
        Me.TableAdapterManager.ProductTableAdapter = Nothing
        Me.TableAdapterManager.Supplier_Quote_Line_ItemTableAdapter = Nothing
        Me.TableAdapterManager.Supplier_QuoteTableAdapter = Nothing
        Me.TableAdapterManager.SupplierTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = M.I.S.S_Vendor_Order_Management_System.group16DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SuppLineItemJoinProductTableAdapter
        '
        Me.SuppLineItemJoinProductTableAdapter.ClearBeforeFill = True
        '
        'SupplierQuoteJoinSupplierTableAdapter
        '
        Me.SupplierQuoteJoinSupplierTableAdapter.ClearBeforeFill = True
        '
        'HelpBtn
        '
        Me.HelpBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HelpBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.HelpBtn.FlatAppearance.BorderSize = 3
        Me.HelpBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.HelpBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.HelpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HelpBtn.Location = New System.Drawing.Point(723, 817)
        Me.HelpBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.HelpBtn.Name = "HelpBtn"
        Me.HelpBtn.Size = New System.Drawing.Size(105, 44)
        Me.HelpBtn.TabIndex = 42
        Me.HelpBtn.Text = "HELP"
        Me.HelpBtn.UseVisualStyleBackColor = False
        '
        'HP1
        '
        Me.HP1.HelpNamespace = "C:\Users\pravz\Desktop\GitFolder\VOMS\M.I.S.chm"
        '
        'SupplierQuoteManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackgroundImage = Global.M.I.S.S_Vendor_Order_Management_System.My.Resources.Resources.Background1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1560, 874)
        Me.Controls.Add(Me.HelpBtn)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.LogOutButton)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.NavigationGroupBox)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "SupplierQuoteManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Supplier Quote Manager"
        Me.NavigationGroupBox.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.SuppLineItemJoinProductDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuppLineItemJoinProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group16DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierQuoteJoinSupplierDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierQuoteJoinSupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NavigationGroupBox As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents BackButton As Button
    Friend WithEvents LogOutButton As Button
    Friend WithEvents SearchButton As Button
    Friend WithEvents SearchComboBox As ComboBox
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents SortButton As Button
    Friend WithEvents SortComboBox As ComboBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ViewButton As Button
    Friend WithEvents CreateButton As Button
    Friend WithEvents RefreshButton As Button
    Friend WithEvents EditButton As Button
    Friend WithEvents Group16DataSet As group16DataSet
    Friend WithEvents TableAdapterManager As group16DataSetTableAdapters.TableAdapterManager
    Friend WithEvents SupplierQuoteJoinSupplierDataGridView As DataGridView
    Friend WithEvents ProductNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductBrandDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductDescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductActiveStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents SuppLineItemJoinProductDataGridView As DataGridView
    Friend WithEvents SuppLineItemJoinProductBindingSource As BindingSource
    Friend WithEvents SuppLineItemJoinProductTableAdapter As group16DataSetTableAdapters.SuppLineItemJoinProductTableAdapter
    Friend WithEvents SupplierQuoteJoinSupplierBindingSource As BindingSource
    Friend WithEvents SupplierQuoteJoinSupplierTableAdapter As group16DataSetTableAdapters.SupplierQuoteJoinSupplierTableAdapter
    Friend WithEvents SuppQuoteReferenceIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ProductIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents SuppLineItemCostPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SuppLineItemQuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SuppQuoteReferenceIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SuppQuoteTotalPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SuppQuoteDateRecievedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SuppQuoteAcceptanceStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SuppQuoteDateAcceptanceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SupplierIDDataGridViewTextBoxColumn As DataGridViewButtonColumn
    Friend WithEvents SupplierNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SupplierPhoneNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SupplierEmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SupplierRepFNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SupplierRepSNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents HelpBtn As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents HP1 As HelpProvider
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateOrEditSupplierQuote
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
        Me.QuoteDetailsGroupBox = New System.Windows.Forms.GroupBox()
        Me.SupplierNameTextBox = New System.Windows.Forms.TextBox()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Group16DataSet = New M.I.S.S_Vendor_Order_Management_System.group16DataSet()
        Me.SupplierInfoButton = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DateAcceptedTextBox = New System.Windows.Forms.TextBox()
        Me.SupplierQuoteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CreateSupplierButton = New System.Windows.Forms.Button()
        Me.OptionsGroupBox1 = New System.Windows.Forms.GroupBox()
        Me.UpdateSupplierQuoteButton = New System.Windows.Forms.Button()
        Me.DeleteSupplierQuoteButton = New System.Windows.Forms.Button()
        Me.QuoteAcceptanceStatusComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SupplierIDComboBox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateRecievedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TotalPriceTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SupplierQuoteIDTextBox = New System.Windows.Forms.TextBox()
        Me.ItemGroupBox = New System.Windows.Forms.GroupBox()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.NotificationLabel = New System.Windows.Forms.Label()
        Me.EditLineItemsButton = New System.Windows.Forms.Button()
        Me.ItemsListGroupBox = New System.Windows.Forms.GroupBox()
        Me.SuppLineItemJoinProductDataGridView = New System.Windows.Forms.DataGridView()
        Me.SuppQuoteReferenceIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuppLineItemCostPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuppLineItemQuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuppLineItemJoinProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BackButton = New System.Windows.Forms.Button()
        Me.Supplier_QuoteTableAdapter = New M.I.S.S_Vendor_Order_Management_System.group16DataSetTableAdapters.Supplier_QuoteTableAdapter()
        Me.SupplierTableAdapter = New M.I.S.S_Vendor_Order_Management_System.group16DataSetTableAdapters.SupplierTableAdapter()
        Me.SuppLineItemJoinProductTableAdapter = New M.I.S.S_Vendor_Order_Management_System.group16DataSetTableAdapters.SuppLineItemJoinProductTableAdapter()
        Me.HelpBtn = New System.Windows.Forms.Button()
        Me.CreateOrEditSupplierQuoteTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Supplier_Quote_Line_ItemTableAdapter = New M.I.S.S_Vendor_Order_Management_System.group16DataSetTableAdapters.Supplier_Quote_Line_ItemTableAdapter()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.HelpProvider2 = New System.Windows.Forms.HelpProvider()
        Me.QuoteDetailsGroupBox.SuspendLayout()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group16DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierQuoteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OptionsGroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.ItemGroupBox.SuspendLayout()
        Me.ItemsListGroupBox.SuspendLayout()
        CType(Me.SuppLineItemJoinProductDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuppLineItemJoinProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QuoteDetailsGroupBox
        '
        Me.QuoteDetailsGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.QuoteDetailsGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.QuoteDetailsGroupBox.Controls.Add(Me.SupplierNameTextBox)
        Me.QuoteDetailsGroupBox.Controls.Add(Me.SupplierInfoButton)
        Me.QuoteDetailsGroupBox.Controls.Add(Me.Label8)
        Me.QuoteDetailsGroupBox.Controls.Add(Me.DateAcceptedTextBox)
        Me.QuoteDetailsGroupBox.Controls.Add(Me.CreateSupplierButton)
        Me.QuoteDetailsGroupBox.Controls.Add(Me.OptionsGroupBox1)
        Me.QuoteDetailsGroupBox.Controls.Add(Me.QuoteAcceptanceStatusComboBox)
        Me.QuoteDetailsGroupBox.Controls.Add(Me.Label1)
        Me.QuoteDetailsGroupBox.Controls.Add(Me.SupplierIDComboBox)
        Me.QuoteDetailsGroupBox.Controls.Add(Me.Label4)
        Me.QuoteDetailsGroupBox.Controls.Add(Me.DateRecievedDateTimePicker)
        Me.QuoteDetailsGroupBox.Controls.Add(Me.Label7)
        Me.QuoteDetailsGroupBox.Controls.Add(Me.Label6)
        Me.QuoteDetailsGroupBox.Location = New System.Drawing.Point(11, 43)
        Me.QuoteDetailsGroupBox.Margin = New System.Windows.Forms.Padding(2)
        Me.QuoteDetailsGroupBox.Name = "QuoteDetailsGroupBox"
        Me.QuoteDetailsGroupBox.Padding = New System.Windows.Forms.Padding(2)
        Me.QuoteDetailsGroupBox.Size = New System.Drawing.Size(404, 408)
        Me.QuoteDetailsGroupBox.TabIndex = 77
        Me.QuoteDetailsGroupBox.TabStop = False
        Me.QuoteDetailsGroupBox.Text = "SUPPLIER QUOTE DETAILS"
        '
        'SupplierNameTextBox
        '
        Me.SupplierNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "Supplier_Name", True))
        Me.SupplierNameTextBox.Location = New System.Drawing.Point(220, 32)
        Me.SupplierNameTextBox.Name = "SupplierNameTextBox"
        Me.SupplierNameTextBox.ReadOnly = True
        Me.SupplierNameTextBox.Size = New System.Drawing.Size(127, 20)
        Me.SupplierNameTextBox.TabIndex = 88
        '
        'SupplierBindingSource
        '
        Me.SupplierBindingSource.DataMember = "Supplier"
        Me.SupplierBindingSource.DataSource = Me.Group16DataSet
        '
        'Group16DataSet
        '
        Me.Group16DataSet.DataSetName = "group16DataSet"
        Me.Group16DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SupplierInfoButton
        '
        Me.SupplierInfoButton.BackColor = System.Drawing.Color.Transparent
        Me.SupplierInfoButton.BackgroundImage = Global.M.I.S.S_Vendor_Order_Management_System.My.Resources.Resources.info_sign
        Me.SupplierInfoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.SupplierInfoButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SupplierInfoButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.SupplierInfoButton.FlatAppearance.BorderSize = 0
        Me.SupplierInfoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.SupplierInfoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.SupplierInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SupplierInfoButton.Location = New System.Drawing.Point(352, 28)
        Me.SupplierInfoButton.Margin = New System.Windows.Forms.Padding(2)
        Me.SupplierInfoButton.Name = "SupplierInfoButton"
        Me.SupplierInfoButton.Size = New System.Drawing.Size(31, 24)
        Me.SupplierInfoButton.TabIndex = 87
        Me.SupplierInfoButton.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(239, 232)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 13)
        Me.Label8.TabIndex = 77
        Me.Label8.Text = "(Y = Yes ; N = No)"
        Me.Label8.UseMnemonic = False
        '
        'DateAcceptedTextBox
        '
        Me.DateAcceptedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DateAcceptedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierQuoteBindingSource, "Supp_Quote_Date_Acceptance", True))
        Me.DateAcceptedTextBox.Location = New System.Drawing.Point(276, 262)
        Me.DateAcceptedTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.DateAcceptedTextBox.Name = "DateAcceptedTextBox"
        Me.DateAcceptedTextBox.ReadOnly = True
        Me.DateAcceptedTextBox.Size = New System.Drawing.Size(102, 20)
        Me.DateAcceptedTextBox.TabIndex = 76
        Me.DateAcceptedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SupplierQuoteBindingSource
        '
        Me.SupplierQuoteBindingSource.DataMember = "Supplier_Quote"
        Me.SupplierQuoteBindingSource.DataSource = Me.Group16DataSet
        '
        'CreateSupplierButton
        '
        Me.CreateSupplierButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CreateSupplierButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.CreateSupplierButton.FlatAppearance.BorderSize = 3
        Me.CreateSupplierButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.CreateSupplierButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.CreateSupplierButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CreateSupplierButton.Location = New System.Drawing.Point(221, 57)
        Me.CreateSupplierButton.Margin = New System.Windows.Forms.Padding(2)
        Me.CreateSupplierButton.Name = "CreateSupplierButton"
        Me.CreateSupplierButton.Size = New System.Drawing.Size(127, 28)
        Me.CreateSupplierButton.TabIndex = 75
        Me.CreateSupplierButton.Text = "CREATE SUPPLIER"
        Me.CreateSupplierButton.UseVisualStyleBackColor = False
        '
        'OptionsGroupBox1
        '
        Me.OptionsGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.OptionsGroupBox1.Controls.Add(Me.UpdateSupplierQuoteButton)
        Me.OptionsGroupBox1.Controls.Add(Me.DeleteSupplierQuoteButton)
        Me.OptionsGroupBox1.Location = New System.Drawing.Point(17, 319)
        Me.OptionsGroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.OptionsGroupBox1.Name = "OptionsGroupBox1"
        Me.OptionsGroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.OptionsGroupBox1.Size = New System.Drawing.Size(374, 78)
        Me.OptionsGroupBox1.TabIndex = 75
        Me.OptionsGroupBox1.TabStop = False
        Me.OptionsGroupBox1.Text = "OPTIONS"
        '
        'UpdateSupplierQuoteButton
        '
        Me.UpdateSupplierQuoteButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UpdateSupplierQuoteButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.UpdateSupplierQuoteButton.FlatAppearance.BorderSize = 3
        Me.UpdateSupplierQuoteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.UpdateSupplierQuoteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.UpdateSupplierQuoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpdateSupplierQuoteButton.Location = New System.Drawing.Point(35, 17)
        Me.UpdateSupplierQuoteButton.Margin = New System.Windows.Forms.Padding(2)
        Me.UpdateSupplierQuoteButton.Name = "UpdateSupplierQuoteButton"
        Me.UpdateSupplierQuoteButton.Size = New System.Drawing.Size(128, 50)
        Me.UpdateSupplierQuoteButton.TabIndex = 1
        Me.UpdateSupplierQuoteButton.Text = "UPDATE"
        Me.UpdateSupplierQuoteButton.UseVisualStyleBackColor = False
        '
        'DeleteSupplierQuoteButton
        '
        Me.DeleteSupplierQuoteButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DeleteSupplierQuoteButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.DeleteSupplierQuoteButton.FlatAppearance.BorderSize = 3
        Me.DeleteSupplierQuoteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.DeleteSupplierQuoteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.DeleteSupplierQuoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteSupplierQuoteButton.Location = New System.Drawing.Point(211, 17)
        Me.DeleteSupplierQuoteButton.Margin = New System.Windows.Forms.Padding(2)
        Me.DeleteSupplierQuoteButton.Name = "DeleteSupplierQuoteButton"
        Me.DeleteSupplierQuoteButton.Size = New System.Drawing.Size(128, 50)
        Me.DeleteSupplierQuoteButton.TabIndex = 2
        Me.DeleteSupplierQuoteButton.Text = "DELETE"
        Me.DeleteSupplierQuoteButton.UseVisualStyleBackColor = False
        '
        'QuoteAcceptanceStatusComboBox
        '
        Me.QuoteAcceptanceStatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierQuoteBindingSource, "Supp_Quote_Acceptance_Status", True))
        Me.QuoteAcceptanceStatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.QuoteAcceptanceStatusComboBox.FormattingEnabled = True
        Me.QuoteAcceptanceStatusComboBox.Items.AddRange(New Object() {"N", "Y"})
        Me.QuoteAcceptanceStatusComboBox.Location = New System.Drawing.Point(178, 229)
        Me.QuoteAcceptanceStatusComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.QuoteAcceptanceStatusComboBox.MaxDropDownItems = 100
        Me.QuoteAcceptanceStatusComboBox.Name = "QuoteAcceptanceStatusComboBox"
        Me.QuoteAcceptanceStatusComboBox.Size = New System.Drawing.Size(57, 21)
        Me.QuoteAcceptanceStatusComboBox.TabIndex = 61
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(15, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "- Supplier :"
        '
        'SupplierIDComboBox
        '
        Me.SupplierIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierQuoteBindingSource, "Supplier_ID", True))
        Me.SupplierIDComboBox.DataSource = Me.SupplierBindingSource
        Me.SupplierIDComboBox.DisplayMember = "Supplier_ID"
        Me.SupplierIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SupplierIDComboBox.FormattingEnabled = True
        Me.SupplierIDComboBox.Location = New System.Drawing.Point(178, 31)
        Me.SupplierIDComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.SupplierIDComboBox.MaxDropDownItems = 100
        Me.SupplierIDComboBox.Name = "SupplierIDComboBox"
        Me.SupplierIDComboBox.Size = New System.Drawing.Size(37, 21)
        Me.SupplierIDComboBox.TabIndex = 59
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(15, 149)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "- Date Recieved:"
        '
        'DateRecievedDateTimePicker
        '
        Me.DateRecievedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SupplierQuoteBindingSource, "Supp_Quote_Date_Recieved", True))
        Me.DateRecievedDateTimePicker.Location = New System.Drawing.Point(179, 142)
        Me.DateRecievedDateTimePicker.Name = "DateRecievedDateTimePicker"
        Me.DateRecievedDateTimePicker.Size = New System.Drawing.Size(199, 20)
        Me.DateRecievedDateTimePicker.TabIndex = 58
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(13, 232)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(146, 13)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "- Quote Accepted as Order? :"
        Me.Label7.UseMnemonic = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(103, 264)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(169, 13)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "- Date Accepted (YYYY/MM/DD):"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.TotalPriceTextBox)
        Me.GroupBox4.Location = New System.Drawing.Point(11, 457)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Size = New System.Drawing.Size(404, 64)
        Me.GroupBox4.TabIndex = 72
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "TOTAL AMOUNT in Rands:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(99, 28)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 13)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "R"
        Me.Label3.UseMnemonic = False
        '
        'TotalPriceTextBox
        '
        Me.TotalPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierQuoteBindingSource, "Supp_Quote_Total_Price", True))
        Me.TotalPriceTextBox.Location = New System.Drawing.Point(118, 25)
        Me.TotalPriceTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.TotalPriceTextBox.Name = "TotalPriceTextBox"
        Me.TotalPriceTextBox.Size = New System.Drawing.Size(172, 20)
        Me.TotalPriceTextBox.TabIndex = 53
        Me.TotalPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(92, 13)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "- Quote Reference ID:"
        '
        'SupplierQuoteIDTextBox
        '
        Me.SupplierQuoteIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SupplierQuoteIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierQuoteBindingSource, "Supp_Quote_Reference_ID", True))
        Me.SupplierQuoteIDTextBox.Location = New System.Drawing.Point(212, 11)
        Me.SupplierQuoteIDTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.SupplierQuoteIDTextBox.Name = "SupplierQuoteIDTextBox"
        Me.SupplierQuoteIDTextBox.ReadOnly = True
        Me.SupplierQuoteIDTextBox.Size = New System.Drawing.Size(69, 20)
        Me.SupplierQuoteIDTextBox.TabIndex = 39
        Me.SupplierQuoteIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ItemGroupBox
        '
        Me.ItemGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.ItemGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ItemGroupBox.Controls.Add(Me.RefreshButton)
        Me.ItemGroupBox.Controls.Add(Me.NotificationLabel)
        Me.ItemGroupBox.Controls.Add(Me.EditLineItemsButton)
        Me.ItemGroupBox.Controls.Add(Me.ItemsListGroupBox)
        Me.ItemGroupBox.Location = New System.Drawing.Point(419, 11)
        Me.ItemGroupBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ItemGroupBox.Name = "ItemGroupBox"
        Me.ItemGroupBox.Padding = New System.Windows.Forms.Padding(2)
        Me.ItemGroupBox.Size = New System.Drawing.Size(829, 510)
        Me.ItemGroupBox.TabIndex = 76
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
        Me.RefreshButton.Location = New System.Drawing.Point(742, 433)
        Me.RefreshButton.Margin = New System.Windows.Forms.Padding(2)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(79, 33)
        Me.RefreshButton.TabIndex = 78
        Me.RefreshButton.Text = "REFRESH"
        Me.RefreshButton.UseVisualStyleBackColor = False
        '
        'NotificationLabel
        '
        Me.NotificationLabel.AutoSize = True
        Me.NotificationLabel.BackColor = System.Drawing.Color.Transparent
        Me.NotificationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotificationLabel.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.NotificationLabel.Location = New System.Drawing.Point(274, 488)
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
        Me.EditLineItemsButton.Location = New System.Drawing.Point(278, 433)
        Me.EditLineItemsButton.Margin = New System.Windows.Forms.Padding(2)
        Me.EditLineItemsButton.Name = "EditLineItemsButton"
        Me.EditLineItemsButton.Size = New System.Drawing.Size(284, 50)
        Me.EditLineItemsButton.TabIndex = 76
        Me.EditLineItemsButton.Text = "EDIT LINE ITEMS"
        Me.EditLineItemsButton.UseVisualStyleBackColor = False
        '
        'ItemsListGroupBox
        '
        Me.ItemsListGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.ItemsListGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ItemsListGroupBox.Controls.Add(Me.SuppLineItemJoinProductDataGridView)
        Me.ItemsListGroupBox.Location = New System.Drawing.Point(8, 17)
        Me.ItemsListGroupBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ItemsListGroupBox.Name = "ItemsListGroupBox"
        Me.ItemsListGroupBox.Padding = New System.Windows.Forms.Padding(2)
        Me.ItemsListGroupBox.Size = New System.Drawing.Size(812, 413)
        Me.ItemsListGroupBox.TabIndex = 54
        Me.ItemsListGroupBox.TabStop = False
        Me.ItemsListGroupBox.Text = "LIST OF QUOTED ITEMS"
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
        Me.SuppLineItemJoinProductDataGridView.Location = New System.Drawing.Point(2, 15)
        Me.SuppLineItemJoinProductDataGridView.Name = "SuppLineItemJoinProductDataGridView"
        Me.SuppLineItemJoinProductDataGridView.ReadOnly = True
        Me.SuppLineItemJoinProductDataGridView.Size = New System.Drawing.Size(808, 396)
        Me.SuppLineItemJoinProductDataGridView.TabIndex = 1
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
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BackButton.FlatAppearance.BorderSize = 3
        Me.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.BackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Location = New System.Drawing.Point(1169, 530)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(2)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(79, 33)
        Me.BackButton.TabIndex = 74
        Me.BackButton.Text = "BACK"
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'Supplier_QuoteTableAdapter
        '
        Me.Supplier_QuoteTableAdapter.ClearBeforeFill = True
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'SuppLineItemJoinProductTableAdapter
        '
        Me.SuppLineItemJoinProductTableAdapter.ClearBeforeFill = True
        '
        'HelpBtn
        '
        Me.HelpBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HelpBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.HelpBtn.FlatAppearance.BorderSize = 3
        Me.HelpBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.HelpBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.HelpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HelpBtn.Location = New System.Drawing.Point(9, 530)
        Me.HelpBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.HelpBtn.Name = "HelpBtn"
        Me.HelpBtn.Size = New System.Drawing.Size(79, 33)
        Me.HelpBtn.TabIndex = 79
        Me.HelpBtn.Text = "HELP"
        Me.HelpBtn.UseVisualStyleBackColor = False
        '
        'Supplier_Quote_Line_ItemTableAdapter
        '
        Me.Supplier_Quote_Line_ItemTableAdapter.ClearBeforeFill = True
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\Users\pravz\Desktop\GitFolder\VOMS\M.I.S.chm"
        '
        'HelpProvider2
        '
        Me.HelpProvider2.HelpNamespace = "C:\Users\munis\Documents\GitHub Normalisers42\VOMS\VOMSHelpFinal.chm"
        '
        'CreateOrEditSupplierQuote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = Global.M.I.S.S_Vendor_Order_Management_System.My.Resources.Resources.Background1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1260, 572)
        Me.Controls.Add(Me.HelpBtn)
        Me.Controls.Add(Me.QuoteDetailsGroupBox)
        Me.Controls.Add(Me.ItemGroupBox)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.SupplierQuoteIDTextBox)
        Me.Controls.Add(Me.Label2)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "CreateOrEditSupplierQuote"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create/Edit Supplier Quote"
        Me.QuoteDetailsGroupBox.ResumeLayout(False)
        Me.QuoteDetailsGroupBox.PerformLayout()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group16DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierQuoteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OptionsGroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ItemGroupBox.ResumeLayout(False)
        Me.ItemGroupBox.PerformLayout()
        Me.ItemsListGroupBox.ResumeLayout(False)
        CType(Me.SuppLineItemJoinProductDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuppLineItemJoinProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents QuoteDetailsGroupBox As GroupBox
    Friend WithEvents CreateSupplierButton As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TotalPriceTextBox As TextBox
    Friend WithEvents QuoteAcceptanceStatusComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SupplierIDComboBox As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DateRecievedDateTimePicker As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents SupplierQuoteIDTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents OptionsGroupBox1 As GroupBox
    Friend WithEvents UpdateSupplierQuoteButton As Button
    Friend WithEvents DeleteSupplierQuoteButton As Button
    Friend WithEvents ItemGroupBox As GroupBox
    Friend WithEvents EditLineItemsButton As Button
    Friend WithEvents ItemsListGroupBox As GroupBox
    Friend WithEvents BackButton As Button
    Friend WithEvents SupplierQuoteBindingSource As BindingSource
    Friend WithEvents Group16DataSet As group16DataSet
    Friend WithEvents Supplier_QuoteTableAdapter As group16DataSetTableAdapters.Supplier_QuoteTableAdapter
    Friend WithEvents SupplierBindingSource As BindingSource
    Friend WithEvents SupplierTableAdapter As group16DataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents SuppLineItemJoinProductBindingSource As BindingSource
    Friend WithEvents SuppLineItemJoinProductTableAdapter As group16DataSetTableAdapters.SuppLineItemJoinProductTableAdapter
    Friend WithEvents SuppLineItemJoinProductDataGridView As DataGridView
    Friend WithEvents SuppQuoteReferenceIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ProductIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents SuppLineItemCostPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SuppLineItemQuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents HelpBtn As Button
    Friend WithEvents DateAcceptedTextBox As TextBox
    Friend WithEvents NotificationLabel As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents CreateOrEditSupplierQuoteTip As ToolTip
    Friend WithEvents RefreshButton As Button
    Friend WithEvents Supplier_Quote_Line_ItemTableAdapter As group16DataSetTableAdapters.Supplier_Quote_Line_ItemTableAdapter
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents HelpProvider2 As HelpProvider
    Friend WithEvents SupplierNameTextBox As TextBox
    Friend WithEvents SupplierInfoButton As Button
End Class

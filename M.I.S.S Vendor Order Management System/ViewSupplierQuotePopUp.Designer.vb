﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSupplierQuotePopUp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewSupplierQuotePopUp))
        Me.NavigationGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SupplierQuoteJoinSupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Group16DataSet = New M.I.S.S_Vendor_Order_Management_System.group16DataSet()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuppLineItemJoinProductDataGridView = New System.Windows.Forms.DataGridView()
        Me.ProductIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuppLineItemCostPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuppLineItemQuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuppLineItemJoinProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.QuoteRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.PrintQuoteButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.SupplierQuoteJoinSupplierTableAdapter = New M.I.S.S_Vendor_Order_Management_System.group16DataSetTableAdapters.SupplierQuoteJoinSupplierTableAdapter()
        Me.SuppLineItemJoinProductTableAdapter = New M.I.S.S_Vendor_Order_Management_System.group16DataSetTableAdapters.SuppLineItemJoinProductTableAdapter()
        Me.TableAdapterManager = New M.I.S.S_Vendor_Order_Management_System.group16DataSetTableAdapters.TableAdapterManager()
        Me.PrintQuote = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.NavigationGroupBox.SuspendLayout()
        CType(Me.SupplierQuoteJoinSupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group16DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuppLineItemJoinProductDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuppLineItemJoinProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NavigationGroupBox
        '
        Me.NavigationGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.NavigationGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NavigationGroupBox.Controls.Add(Me.Label10)
        Me.NavigationGroupBox.Controls.Add(Me.Label9)
        Me.NavigationGroupBox.Controls.Add(Me.Label8)
        Me.NavigationGroupBox.Controls.Add(Me.Label7)
        Me.NavigationGroupBox.Controls.Add(Me.Label6)
        Me.NavigationGroupBox.Controls.Add(Me.Label5)
        Me.NavigationGroupBox.Controls.Add(Me.SuppLineItemJoinProductDataGridView)
        Me.NavigationGroupBox.Controls.Add(Me.Label2)
        Me.NavigationGroupBox.Controls.Add(Me.Label4)
        Me.NavigationGroupBox.Controls.Add(Me.Label3)
        Me.NavigationGroupBox.Controls.Add(Me.Label1)
        Me.NavigationGroupBox.Controls.Add(Me.QuoteRichTextBox)
        Me.NavigationGroupBox.Location = New System.Drawing.Point(11, 11)
        Me.NavigationGroupBox.Margin = New System.Windows.Forms.Padding(2)
        Me.NavigationGroupBox.Name = "NavigationGroupBox"
        Me.NavigationGroupBox.Padding = New System.Windows.Forms.Padding(2)
        Me.NavigationGroupBox.Size = New System.Drawing.Size(546, 359)
        Me.NavigationGroupBox.TabIndex = 21
        Me.NavigationGroupBox.TabStop = False
        Me.NavigationGroupBox.Text = "QUOTE"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierQuoteJoinSupplierBindingSource, "Supp_Quote_Date_Acceptance", True))
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(479, 53)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Date/Time"
        '
        'SupplierQuoteJoinSupplierBindingSource
        '
        Me.SupplierQuoteJoinSupplierBindingSource.DataMember = "SupplierQuoteJoinSupplier"
        Me.SupplierQuoteJoinSupplierBindingSource.DataSource = Me.Group16DataSet
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
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(387, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Date Accepted:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierQuoteJoinSupplierBindingSource, "Supp_Quote_Date_Recieved", True))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(479, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Date/Time"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierQuoteJoinSupplierBindingSource, "Supplier_Name", True))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(268, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Supplier Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierQuoteJoinSupplierBindingSource, "Supp_Quote_Reference_ID", True))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(87, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Quote ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Quote ID:"
        '
        'SuppLineItemJoinProductDataGridView
        '
        Me.SuppLineItemJoinProductDataGridView.AllowUserToAddRows = False
        Me.SuppLineItemJoinProductDataGridView.AllowUserToDeleteRows = False
        Me.SuppLineItemJoinProductDataGridView.AutoGenerateColumns = False
        Me.SuppLineItemJoinProductDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.SuppLineItemJoinProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SuppLineItemJoinProductDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductIDDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.SuppLineItemCostPriceDataGridViewTextBoxColumn, Me.SuppLineItemQuantityDataGridViewTextBoxColumn})
        Me.SuppLineItemJoinProductDataGridView.DataSource = Me.SuppLineItemJoinProductBindingSource
        Me.SuppLineItemJoinProductDataGridView.Location = New System.Drawing.Point(31, 82)
        Me.SuppLineItemJoinProductDataGridView.Name = "SuppLineItemJoinProductDataGridView"
        Me.SuppLineItemJoinProductDataGridView.ReadOnly = True
        Me.SuppLineItemJoinProductDataGridView.Size = New System.Drawing.Size(488, 229)
        Me.SuppLineItemJoinProductDataGridView.TabIndex = 10
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierQuoteJoinSupplierBindingSource, "Supp_Quote_Total_Price", True))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(296, 323)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(183, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Supplier Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(387, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Date Issued:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(205, 323)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Total Price:         R"
        '
        'QuoteRichTextBox
        '
        Me.QuoteRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QuoteRichTextBox.Location = New System.Drawing.Point(2, 15)
        Me.QuoteRichTextBox.Name = "QuoteRichTextBox"
        Me.QuoteRichTextBox.Size = New System.Drawing.Size(542, 342)
        Me.QuoteRichTextBox.TabIndex = 0
        Me.QuoteRichTextBox.Text = ""
        '
        'PrintQuoteButton
        '
        Me.PrintQuoteButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PrintQuoteButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.PrintQuoteButton.FlatAppearance.BorderSize = 3
        Me.PrintQuoteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.PrintQuoteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.PrintQuoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PrintQuoteButton.Location = New System.Drawing.Point(163, 386)
        Me.PrintQuoteButton.Margin = New System.Windows.Forms.Padding(2)
        Me.PrintQuoteButton.Name = "PrintQuoteButton"
        Me.PrintQuoteButton.Size = New System.Drawing.Size(251, 33)
        Me.PrintQuoteButton.TabIndex = 52
        Me.PrintQuoteButton.Text = "PRINT QUOTE"
        Me.PrintQuoteButton.UseVisualStyleBackColor = False
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BackButton.FlatAppearance.BorderSize = 3
        Me.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.BackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Location = New System.Drawing.Point(493, 410)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(2)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(64, 36)
        Me.BackButton.TabIndex = 53
        Me.BackButton.Text = "BACK"
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'SupplierQuoteJoinSupplierTableAdapter
        '
        Me.SupplierQuoteJoinSupplierTableAdapter.ClearBeforeFill = True
        '
        'SuppLineItemJoinProductTableAdapter
        '
        Me.SuppLineItemJoinProductTableAdapter.ClearBeforeFill = True
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
        'PrintQuote
        '
        Me.PrintQuote.DocumentName = "document"
        Me.PrintQuote.Form = Me
        Me.PrintQuote.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintQuote.PrinterSettings = CType(resources.GetObject("PrintQuote.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintQuote.PrintFileName = Nothing
        '
        'ViewSupplierQuotePopUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.M.I.S.S_Vendor_Order_Management_System.My.Resources.Resources.Background1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(568, 457)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.PrintQuoteButton)
        Me.Controls.Add(Me.NavigationGroupBox)
        Me.DoubleBuffered = True
        Me.Name = "ViewSupplierQuotePopUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Supplier Quote"
        Me.NavigationGroupBox.ResumeLayout(False)
        Me.NavigationGroupBox.PerformLayout()
        CType(Me.SupplierQuoteJoinSupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group16DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuppLineItemJoinProductDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuppLineItemJoinProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NavigationGroupBox As GroupBox
    Friend WithEvents QuoteRichTextBox As RichTextBox
    Friend WithEvents PrintQuoteButton As Button
    Friend WithEvents BackButton As Button
    Friend WithEvents SupplierQuoteJoinSupplierTableAdapter As group16DataSetTableAdapters.SupplierQuoteJoinSupplierTableAdapter
    Friend WithEvents SuppLineItemJoinProductTableAdapter As group16DataSetTableAdapters.SuppLineItemJoinProductTableAdapter
    Friend WithEvents TableAdapterManager As group16DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Group16DataSet As group16DataSet
    Friend WithEvents Label1 As Label
    Friend WithEvents SuppLineItemJoinProductBindingSource As BindingSource
    Friend WithEvents SupplierQuoteJoinSupplierBindingSource As BindingSource
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents SuppLineItemJoinProductDataGridView As DataGridView
    Friend WithEvents PrintQuote As PowerPacks.Printing.PrintForm
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ProductIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents SuppLineItemCostPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SuppLineItemQuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

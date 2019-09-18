<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectSupplierPopUp
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
        Me.SelectSupplierButton = New System.Windows.Forms.Button()
        Me.SupplierDataGridView = New System.Windows.Forms.DataGridView()
        Me.Group16DataSet = New M.I.S.S_Vendor_Order_Management_System.group16DataSet()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierTableAdapter = New M.I.S.S_Vendor_Order_Management_System.group16DataSetTableAdapters.SupplierTableAdapter()
        Me.SupplierIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierPhoneNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierEmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierActiveStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.SupplierDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group16DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BackButton.Location = New System.Drawing.Point(429, 166)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(2)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(79, 33)
        Me.BackButton.TabIndex = 79
        Me.BackButton.Text = "CLOSE"
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'SelectSupplierButton
        '
        Me.SelectSupplierButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SelectSupplierButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.SelectSupplierButton.FlatAppearance.BorderSize = 3
        Me.SelectSupplierButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.SelectSupplierButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.SelectSupplierButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SelectSupplierButton.Location = New System.Drawing.Point(183, 166)
        Me.SelectSupplierButton.Margin = New System.Windows.Forms.Padding(2)
        Me.SelectSupplierButton.Name = "SelectSupplierButton"
        Me.SelectSupplierButton.Size = New System.Drawing.Size(152, 33)
        Me.SelectSupplierButton.TabIndex = 78
        Me.SelectSupplierButton.Text = "SELECT SUPPLIER"
        Me.SelectSupplierButton.UseVisualStyleBackColor = False
        '
        'SupplierDataGridView
        '
        Me.SupplierDataGridView.AllowUserToAddRows = False
        Me.SupplierDataGridView.AllowUserToDeleteRows = False
        Me.SupplierDataGridView.AutoGenerateColumns = False
        Me.SupplierDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SupplierDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SupplierIDDataGridViewTextBoxColumn, Me.SupplierNameDataGridViewTextBoxColumn, Me.SupplierPhoneNoDataGridViewTextBoxColumn, Me.SupplierEmailDataGridViewTextBoxColumn, Me.SupplierActiveStatusDataGridViewTextBoxColumn})
        Me.SupplierDataGridView.DataSource = Me.SupplierBindingSource
        Me.SupplierDataGridView.Location = New System.Drawing.Point(16, 11)
        Me.SupplierDataGridView.Name = "SupplierDataGridView"
        Me.SupplierDataGridView.ReadOnly = True
        Me.SupplierDataGridView.Size = New System.Drawing.Size(492, 150)
        Me.SupplierDataGridView.TabIndex = 77
        '
        'Group16DataSet
        '
        Me.Group16DataSet.DataSetName = "group16DataSet"
        Me.Group16DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'SupplierIDDataGridViewTextBoxColumn
        '
        Me.SupplierIDDataGridViewTextBoxColumn.DataPropertyName = "Supplier_ID"
        Me.SupplierIDDataGridViewTextBoxColumn.HeaderText = "Supplier ID"
        Me.SupplierIDDataGridViewTextBoxColumn.Name = "SupplierIDDataGridViewTextBoxColumn"
        Me.SupplierIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.SupplierIDDataGridViewTextBoxColumn.Width = 60
        '
        'SupplierNameDataGridViewTextBoxColumn
        '
        Me.SupplierNameDataGridViewTextBoxColumn.DataPropertyName = "Supplier_Name"
        Me.SupplierNameDataGridViewTextBoxColumn.HeaderText = "Supplier"
        Me.SupplierNameDataGridViewTextBoxColumn.Name = "SupplierNameDataGridViewTextBoxColumn"
        Me.SupplierNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SupplierPhoneNoDataGridViewTextBoxColumn
        '
        Me.SupplierPhoneNoDataGridViewTextBoxColumn.DataPropertyName = "Supplier_Phone_No"
        Me.SupplierPhoneNoDataGridViewTextBoxColumn.HeaderText = "Phone No"
        Me.SupplierPhoneNoDataGridViewTextBoxColumn.Name = "SupplierPhoneNoDataGridViewTextBoxColumn"
        Me.SupplierPhoneNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SupplierEmailDataGridViewTextBoxColumn
        '
        Me.SupplierEmailDataGridViewTextBoxColumn.DataPropertyName = "Supplier_Email"
        Me.SupplierEmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.SupplierEmailDataGridViewTextBoxColumn.Name = "SupplierEmailDataGridViewTextBoxColumn"
        Me.SupplierEmailDataGridViewTextBoxColumn.ReadOnly = True
        Me.SupplierEmailDataGridViewTextBoxColumn.Width = 130
        '
        'SupplierActiveStatusDataGridViewTextBoxColumn
        '
        Me.SupplierActiveStatusDataGridViewTextBoxColumn.DataPropertyName = "Supplier_Active_Status"
        Me.SupplierActiveStatusDataGridViewTextBoxColumn.HeaderText = "Active Status"
        Me.SupplierActiveStatusDataGridViewTextBoxColumn.Name = "SupplierActiveStatusDataGridViewTextBoxColumn"
        Me.SupplierActiveStatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.SupplierActiveStatusDataGridViewTextBoxColumn.Width = 50
        '
        'SelectSupplierPopUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.M.I.S.S_Vendor_Order_Management_System.My.Resources.Resources.Background1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(524, 211)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.SelectSupplierButton)
        Me.Controls.Add(Me.SupplierDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SelectSupplierPopUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select Supplier"
        CType(Me.SupplierDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group16DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BackButton As Button
    Friend WithEvents SelectSupplierButton As Button
    Friend WithEvents SupplierDataGridView As DataGridView
    Friend WithEvents Group16DataSet As group16DataSet
    Friend WithEvents SupplierBindingSource As BindingSource
    Friend WithEvents SupplierTableAdapter As group16DataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents SupplierIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SupplierNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SupplierPhoneNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SupplierEmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SupplierActiveStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

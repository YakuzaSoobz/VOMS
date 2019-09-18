<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectCustomerPopUp
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
        Me.CustomerDataGridView = New System.Windows.Forms.DataGridView()
        Me.CustomerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustFNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustSNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustEmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustActiveStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Group16DataSet = New M.I.S.S_Vendor_Order_Management_System.group16DataSet()
        Me.CustomerTableAdapter = New M.I.S.S_Vendor_Order_Management_System.group16DataSetTableAdapters.CustomerTableAdapter()
        Me.CreateCustomerButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        CType(Me.CustomerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group16DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustomerDataGridView
        '
        Me.CustomerDataGridView.AllowUserToAddRows = False
        Me.CustomerDataGridView.AllowUserToDeleteRows = False
        Me.CustomerDataGridView.AutoGenerateColumns = False
        Me.CustomerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomerDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomerIDDataGridViewTextBoxColumn, Me.CustFNameDataGridViewTextBoxColumn, Me.CustSNameDataGridViewTextBoxColumn, Me.CustEmailDataGridViewTextBoxColumn, Me.CustActiveStatusDataGridViewTextBoxColumn})
        Me.CustomerDataGridView.DataSource = Me.CustomerBindingSource
        Me.CustomerDataGridView.Location = New System.Drawing.Point(13, 13)
        Me.CustomerDataGridView.Name = "CustomerDataGridView"
        Me.CustomerDataGridView.ReadOnly = True
        Me.CustomerDataGridView.Size = New System.Drawing.Size(553, 150)
        Me.CustomerDataGridView.TabIndex = 0
        '
        'CustomerIDDataGridViewTextBoxColumn
        '
        Me.CustomerIDDataGridViewTextBoxColumn.DataPropertyName = "Customer_ID"
        Me.CustomerIDDataGridViewTextBoxColumn.HeaderText = "Cust ID"
        Me.CustomerIDDataGridViewTextBoxColumn.Name = "CustomerIDDataGridViewTextBoxColumn"
        Me.CustomerIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.CustomerIDDataGridViewTextBoxColumn.Width = 50
        '
        'CustFNameDataGridViewTextBoxColumn
        '
        Me.CustFNameDataGridViewTextBoxColumn.DataPropertyName = "Cust_FName"
        Me.CustFNameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.CustFNameDataGridViewTextBoxColumn.Name = "CustFNameDataGridViewTextBoxColumn"
        Me.CustFNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.CustFNameDataGridViewTextBoxColumn.Width = 110
        '
        'CustSNameDataGridViewTextBoxColumn
        '
        Me.CustSNameDataGridViewTextBoxColumn.DataPropertyName = "Cust_SName"
        Me.CustSNameDataGridViewTextBoxColumn.HeaderText = "Surname"
        Me.CustSNameDataGridViewTextBoxColumn.Name = "CustSNameDataGridViewTextBoxColumn"
        Me.CustSNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.CustSNameDataGridViewTextBoxColumn.Width = 110
        '
        'CustEmailDataGridViewTextBoxColumn
        '
        Me.CustEmailDataGridViewTextBoxColumn.DataPropertyName = "Cust_Email"
        Me.CustEmailDataGridViewTextBoxColumn.HeaderText = "Cust Email"
        Me.CustEmailDataGridViewTextBoxColumn.Name = "CustEmailDataGridViewTextBoxColumn"
        Me.CustEmailDataGridViewTextBoxColumn.ReadOnly = True
        Me.CustEmailDataGridViewTextBoxColumn.Width = 150
        '
        'CustActiveStatusDataGridViewTextBoxColumn
        '
        Me.CustActiveStatusDataGridViewTextBoxColumn.DataPropertyName = "Cust_Active_Status"
        Me.CustActiveStatusDataGridViewTextBoxColumn.HeaderText = "Active Status"
        Me.CustActiveStatusDataGridViewTextBoxColumn.Name = "CustActiveStatusDataGridViewTextBoxColumn"
        Me.CustActiveStatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.CustActiveStatusDataGridViewTextBoxColumn.Width = 70
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me.Group16DataSet
        '
        'Group16DataSet
        '
        Me.Group16DataSet.DataSetName = "group16DataSet"
        Me.Group16DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'CreateCustomerButton
        '
        Me.CreateCustomerButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CreateCustomerButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.CreateCustomerButton.FlatAppearance.BorderSize = 3
        Me.CreateCustomerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.CreateCustomerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.CreateCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CreateCustomerButton.Location = New System.Drawing.Point(210, 168)
        Me.CreateCustomerButton.Margin = New System.Windows.Forms.Padding(2)
        Me.CreateCustomerButton.Name = "CreateCustomerButton"
        Me.CreateCustomerButton.Size = New System.Drawing.Size(152, 33)
        Me.CreateCustomerButton.TabIndex = 75
        Me.CreateCustomerButton.Text = "SELECT CUSTOMER"
        Me.CreateCustomerButton.UseVisualStyleBackColor = False
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BackButton.FlatAppearance.BorderSize = 3
        Me.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.BackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Location = New System.Drawing.Point(487, 168)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(2)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(79, 33)
        Me.BackButton.TabIndex = 76
        Me.BackButton.Text = "CLOSE"
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'SelectCustomerPopUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.M.I.S.S_Vendor_Order_Management_System.My.Resources.Resources.Background1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(578, 208)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.CreateCustomerButton)
        Me.Controls.Add(Me.CustomerDataGridView)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SelectCustomerPopUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select Customer"
        CType(Me.CustomerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group16DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CustomerDataGridView As DataGridView
    Friend WithEvents Group16DataSet As group16DataSet
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As group16DataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents CreateCustomerButton As Button
    Friend WithEvents BackButton As Button
    Friend WithEvents CustomerIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustFNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustSNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustEmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustActiveStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

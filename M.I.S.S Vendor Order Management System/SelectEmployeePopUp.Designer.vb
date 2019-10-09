<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectEmployeePopUp
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
        Me.SelectCustomerButton = New System.Windows.Forms.Button()
        Me.EmployeeDataGridView = New System.Windows.Forms.DataGridView()
        Me.Group16DataSet = New M.I.S.S_Vendor_Order_Management_System.group16DataSet()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeTableAdapter = New M.I.S.S_Vendor_Order_Management_System.group16DataSetTableAdapters.EmployeeTableAdapter()
        Me.EmployeeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeFNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeSNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeEmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeePositionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeActiveStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.EmployeeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group16DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BackButton.Location = New System.Drawing.Point(531, 167)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(2)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(79, 33)
        Me.BackButton.TabIndex = 79
        Me.BackButton.Text = "CLOSE"
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'SelectCustomerButton
        '
        Me.SelectCustomerButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SelectCustomerButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.SelectCustomerButton.FlatAppearance.BorderSize = 3
        Me.SelectCustomerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.SelectCustomerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.SelectCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SelectCustomerButton.Location = New System.Drawing.Point(238, 166)
        Me.SelectCustomerButton.Margin = New System.Windows.Forms.Padding(2)
        Me.SelectCustomerButton.Name = "SelectCustomerButton"
        Me.SelectCustomerButton.Size = New System.Drawing.Size(152, 33)
        Me.SelectCustomerButton.TabIndex = 78
        Me.SelectCustomerButton.Text = "SELECT EMPLOYEE"
        Me.SelectCustomerButton.UseVisualStyleBackColor = False
        '
        'EmployeeDataGridView
        '
        Me.EmployeeDataGridView.AllowUserToAddRows = False
        Me.EmployeeDataGridView.AllowUserToDeleteRows = False
        Me.EmployeeDataGridView.AutoGenerateColumns = False
        Me.EmployeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmployeeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmployeeIDDataGridViewTextBoxColumn, Me.EmployeeFNameDataGridViewTextBoxColumn, Me.EmployeeSNameDataGridViewTextBoxColumn, Me.EmployeeEmailDataGridViewTextBoxColumn, Me.EmployeePositionDataGridViewTextBoxColumn, Me.EmployeeActiveStatusDataGridViewTextBoxColumn})
        Me.EmployeeDataGridView.DataSource = Me.EmployeeBindingSource
        Me.EmployeeDataGridView.Location = New System.Drawing.Point(16, 11)
        Me.EmployeeDataGridView.Name = "EmployeeDataGridView"
        Me.EmployeeDataGridView.ReadOnly = True
        Me.EmployeeDataGridView.Size = New System.Drawing.Size(594, 150)
        Me.EmployeeDataGridView.TabIndex = 77
        '
        'Group16DataSet
        '
        Me.Group16DataSet.DataSetName = "group16DataSet"
        Me.Group16DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "Employee"
        Me.EmployeeBindingSource.DataSource = Me.Group16DataSet
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'EmployeeIDDataGridViewTextBoxColumn
        '
        Me.EmployeeIDDataGridViewTextBoxColumn.DataPropertyName = "Employee_ID"
        Me.EmployeeIDDataGridViewTextBoxColumn.HeaderText = "Employee ID"
        Me.EmployeeIDDataGridViewTextBoxColumn.Name = "EmployeeIDDataGridViewTextBoxColumn"
        Me.EmployeeIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmployeeIDDataGridViewTextBoxColumn.Width = 60
        '
        'EmployeeFNameDataGridViewTextBoxColumn
        '
        Me.EmployeeFNameDataGridViewTextBoxColumn.DataPropertyName = "Employee_FName"
        Me.EmployeeFNameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.EmployeeFNameDataGridViewTextBoxColumn.Name = "EmployeeFNameDataGridViewTextBoxColumn"
        Me.EmployeeFNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmployeeFNameDataGridViewTextBoxColumn.Width = 110
        '
        'EmployeeSNameDataGridViewTextBoxColumn
        '
        Me.EmployeeSNameDataGridViewTextBoxColumn.DataPropertyName = "Employee_SName"
        Me.EmployeeSNameDataGridViewTextBoxColumn.HeaderText = "Surname"
        Me.EmployeeSNameDataGridViewTextBoxColumn.Name = "EmployeeSNameDataGridViewTextBoxColumn"
        Me.EmployeeSNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmployeeSNameDataGridViewTextBoxColumn.Width = 110
        '
        'EmployeeEmailDataGridViewTextBoxColumn
        '
        Me.EmployeeEmailDataGridViewTextBoxColumn.DataPropertyName = "Employee_Email"
        Me.EmployeeEmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmployeeEmailDataGridViewTextBoxColumn.Name = "EmployeeEmailDataGridViewTextBoxColumn"
        Me.EmployeeEmailDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmployeeEmailDataGridViewTextBoxColumn.Width = 150
        '
        'EmployeePositionDataGridViewTextBoxColumn
        '
        Me.EmployeePositionDataGridViewTextBoxColumn.DataPropertyName = "Employee_Position"
        Me.EmployeePositionDataGridViewTextBoxColumn.HeaderText = "Position"
        Me.EmployeePositionDataGridViewTextBoxColumn.Name = "EmployeePositionDataGridViewTextBoxColumn"
        Me.EmployeePositionDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmployeePositionDataGridViewTextBoxColumn.Width = 50
        '
        'EmployeeActiveStatusDataGridViewTextBoxColumn
        '
        Me.EmployeeActiveStatusDataGridViewTextBoxColumn.DataPropertyName = "Employee_Active_Status"
        Me.EmployeeActiveStatusDataGridViewTextBoxColumn.HeaderText = "Active Status"
        Me.EmployeeActiveStatusDataGridViewTextBoxColumn.Name = "EmployeeActiveStatusDataGridViewTextBoxColumn"
        Me.EmployeeActiveStatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmployeeActiveStatusDataGridViewTextBoxColumn.Width = 50
        '
        'SelectEmployeePopUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.M.I.S.S_Vendor_Order_Management_System.My.Resources.Resources.Background1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(627, 211)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.SelectCustomerButton)
        Me.Controls.Add(Me.EmployeeDataGridView)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SelectEmployeePopUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select Employee"
        CType(Me.EmployeeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group16DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BackButton As Button
    Friend WithEvents SelectCustomerButton As Button
    Friend WithEvents EmployeeDataGridView As DataGridView
    Friend WithEvents Group16DataSet As group16DataSet
    Friend WithEvents EmployeeBindingSource As BindingSource
    Friend WithEvents EmployeeTableAdapter As group16DataSetTableAdapters.EmployeeTableAdapter
    Friend WithEvents EmployeeIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeFNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeSNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeEmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeePositionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeActiveStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

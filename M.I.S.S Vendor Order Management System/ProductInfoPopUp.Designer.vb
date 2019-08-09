<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductInfoPopUp
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
        Me.DetailsGroupBox = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Group16DataSet = New M.I.S.S_Vendor_Order_Management_System.group16DataSet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ProductIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.ProductDescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BrandNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ProductNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.ProductTableAdapter = New M.I.S.S_Vendor_Order_Management_System.group16DataSetTableAdapters.ProductTableAdapter()
        Me.DetailsGroupBox.SuspendLayout()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group16DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DetailsGroupBox
        '
        Me.DetailsGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.DetailsGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DetailsGroupBox.Controls.Add(Me.TextBox1)
        Me.DetailsGroupBox.Controls.Add(Me.Label4)
        Me.DetailsGroupBox.Controls.Add(Me.ProductIDTextBox)
        Me.DetailsGroupBox.Controls.Add(Me.Label18)
        Me.DetailsGroupBox.Controls.Add(Me.ProductDescriptionTextBox)
        Me.DetailsGroupBox.Controls.Add(Me.Label9)
        Me.DetailsGroupBox.Controls.Add(Me.BrandNameTextBox)
        Me.DetailsGroupBox.Controls.Add(Me.Label3)
        Me.DetailsGroupBox.Controls.Add(Me.ProductNameTextBox)
        Me.DetailsGroupBox.Controls.Add(Me.Label2)
        Me.DetailsGroupBox.Controls.Add(Me.Label1)
        Me.DetailsGroupBox.Location = New System.Drawing.Point(15, 14)
        Me.DetailsGroupBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DetailsGroupBox.Name = "DetailsGroupBox"
        Me.DetailsGroupBox.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DetailsGroupBox.Size = New System.Drawing.Size(1067, 199)
        Me.DetailsGroupBox.TabIndex = 73
        Me.DetailsGroupBox.TabStop = False
        Me.DetailsGroupBox.Text = "PRODUCT DETAILS"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Product_Brand", True))
        Me.TextBox1.Location = New System.Drawing.Point(689, 149)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 79
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(811, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(158, 34)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "- ""T"" for True = Active" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- ""F"" for False = Inactive"
        '
        'ProductIDTextBox
        '
        Me.ProductIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Product_ID", True))
        Me.ProductIDTextBox.Location = New System.Drawing.Point(179, 27)
        Me.ProductIDTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ProductIDTextBox.Name = "ProductIDTextBox"
        Me.ProductIDTextBox.ReadOnly = True
        Me.ProductIDTextBox.Size = New System.Drawing.Size(180, 22)
        Me.ProductIDTextBox.TabIndex = 77
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(533, 148)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(94, 17)
        Me.Label18.TabIndex = 73
        Me.Label18.Text = "Active Status:"
        '
        'ProductDescriptionTextBox
        '
        Me.ProductDescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Product_Description", True))
        Me.ProductDescriptionTextBox.Location = New System.Drawing.Point(689, 21)
        Me.ProductDescriptionTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ProductDescriptionTextBox.Multiline = True
        Me.ProductDescriptionTextBox.Name = "ProductDescriptionTextBox"
        Me.ProductDescriptionTextBox.Size = New System.Drawing.Size(328, 111)
        Me.ProductDescriptionTextBox.TabIndex = 53
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(533, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(136, 17)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "Product Description:"
        '
        'BrandNameTextBox
        '
        Me.BrandNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Product_Brand", True))
        Me.BrandNameTextBox.Location = New System.Drawing.Point(179, 160)
        Me.BrandNameTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BrandNameTextBox.Name = "BrandNameTextBox"
        Me.BrandNameTextBox.Size = New System.Drawing.Size(287, 22)
        Me.BrandNameTextBox.TabIndex = 41
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 17)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Brand Name:"
        '
        'ProductNameTextBox
        '
        Me.ProductNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Product_Name", True))
        Me.ProductNameTextBox.Location = New System.Drawing.Point(179, 95)
        Me.ProductNameTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ProductNameTextBox.Name = "ProductNameTextBox"
        Me.ProductNameTextBox.Size = New System.Drawing.Size(287, 22)
        Me.ProductNameTextBox.TabIndex = 39
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(37, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 17)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Product ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(39, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Product Name:"
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
        Me.BackButton.Location = New System.Drawing.Point(996, 218)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(85, 44)
        Me.BackButton.TabIndex = 74
        Me.BackButton.Text = "BACK"
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'ProductTableAdapter
        '
        Me.ProductTableAdapter.ClearBeforeFill = True
        '
        'ProductInfoPopUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = Global.M.I.S.S_Vendor_Order_Management_System.My.Resources.Resources.Background1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1099, 277)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.DetailsGroupBox)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ProductInfoPopUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Info "
        Me.DetailsGroupBox.ResumeLayout(False)
        Me.DetailsGroupBox.PerformLayout()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group16DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DetailsGroupBox As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ProductIDTextBox As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents ProductDescriptionTextBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents BrandNameTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ProductNameTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BackButton As Button
    Friend WithEvents Group16DataSet As group16DataSet
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ProductBindingSource As BindingSource
    Friend WithEvents ProductTableAdapter As group16DataSetTableAdapters.ProductTableAdapter
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerInfoPopUp
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
        Me.Group16DataSet = New M.I.S.S_Vendor_Order_Management_System.group16DataSet()
        Me.CustomerTableAdapter = New M.I.S.S_Vendor_Order_Management_System.group16DataSetTableAdapters.CustomerTableAdapter()
        Me.DetailsGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.CustomerIDTextBox = New System.Windows.Forms.TextBox()
        Me.ActiveStatusComboBox = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.PostalCodeMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.SuburbTextBox = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ProvinceTextBox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DOBDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.StreetAddress2TextBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.StreetAddress1TextBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.AltContactNumberMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ContactNumberMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.Group16DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DetailsGroupBox.SuspendLayout()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BackButton.Location = New System.Drawing.Point(795, 335)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(2)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(64, 36)
        Me.BackButton.TabIndex = 69
        Me.BackButton.Text = "BACK"
        Me.BackButton.UseVisualStyleBackColor = False
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
        'DetailsGroupBox
        '
        Me.DetailsGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.DetailsGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DetailsGroupBox.Controls.Add(Me.Label5)
        Me.DetailsGroupBox.Controls.Add(Me.PasswordTextBox)
        Me.DetailsGroupBox.Controls.Add(Me.Label19)
        Me.DetailsGroupBox.Controls.Add(Me.CustomerIDTextBox)
        Me.DetailsGroupBox.Controls.Add(Me.ActiveStatusComboBox)
        Me.DetailsGroupBox.Controls.Add(Me.Label18)
        Me.DetailsGroupBox.Controls.Add(Me.PostalCodeMaskedTextBox)
        Me.DetailsGroupBox.Controls.Add(Me.Label14)
        Me.DetailsGroupBox.Controls.Add(Me.CityTextBox)
        Me.DetailsGroupBox.Controls.Add(Me.Label13)
        Me.DetailsGroupBox.Controls.Add(Me.SuburbTextBox)
        Me.DetailsGroupBox.Controls.Add(Me.Label12)
        Me.DetailsGroupBox.Controls.Add(Me.ProvinceTextBox)
        Me.DetailsGroupBox.Controls.Add(Me.Label11)
        Me.DetailsGroupBox.Controls.Add(Me.DOBDateTimePicker)
        Me.DetailsGroupBox.Controls.Add(Me.StreetAddress2TextBox)
        Me.DetailsGroupBox.Controls.Add(Me.Label10)
        Me.DetailsGroupBox.Controls.Add(Me.StreetAddress1TextBox)
        Me.DetailsGroupBox.Controls.Add(Me.Label9)
        Me.DetailsGroupBox.Controls.Add(Me.EmailTextBox)
        Me.DetailsGroupBox.Controls.Add(Me.Label8)
        Me.DetailsGroupBox.Controls.Add(Me.AltContactNumberMaskedTextBox)
        Me.DetailsGroupBox.Controls.Add(Me.Label7)
        Me.DetailsGroupBox.Controls.Add(Me.ContactNumberMaskedTextBox)
        Me.DetailsGroupBox.Controls.Add(Me.Label6)
        Me.DetailsGroupBox.Controls.Add(Me.SNameTextBox)
        Me.DetailsGroupBox.Controls.Add(Me.Label3)
        Me.DetailsGroupBox.Controls.Add(Me.FNameTextBox)
        Me.DetailsGroupBox.Controls.Add(Me.Label4)
        Me.DetailsGroupBox.Controls.Add(Me.Label2)
        Me.DetailsGroupBox.Controls.Add(Me.Label1)
        Me.DetailsGroupBox.Location = New System.Drawing.Point(11, 11)
        Me.DetailsGroupBox.Margin = New System.Windows.Forms.Padding(2)
        Me.DetailsGroupBox.Name = "DetailsGroupBox"
        Me.DetailsGroupBox.Padding = New System.Windows.Forms.Padding(2)
        Me.DetailsGroupBox.Size = New System.Drawing.Size(848, 320)
        Me.DetailsGroupBox.TabIndex = 70
        Me.DetailsGroupBox.TabStop = False
        Me.DetailsGroupBox.Text = "CUSTOMER DETAILS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(703, 271)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 26)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = "- ""T"" for True = Active" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- ""F"" for False = Inactive"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Cust_Password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(221, 293)
        Me.PasswordTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PasswordTextBox.MaxLength = 10
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.ReadOnly = True
        Me.PasswordTextBox.Size = New System.Drawing.Size(162, 20)
        Me.PasswordTextBox.TabIndex = 81
        Me.PasswordTextBox.UseSystemPasswordChar = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(30, 293)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(157, 13)
        Me.Label19.TabIndex = 80
        Me.Label19.Text = "* Password(Max 10 characters):"
        '
        'CustomerIDTextBox
        '
        Me.CustomerIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Customer_ID", True))
        Me.CustomerIDTextBox.Location = New System.Drawing.Point(221, 17)
        Me.CustomerIDTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.CustomerIDTextBox.Name = "CustomerIDTextBox"
        Me.CustomerIDTextBox.ReadOnly = True
        Me.CustomerIDTextBox.Size = New System.Drawing.Size(80, 20)
        Me.CustomerIDTextBox.TabIndex = 77
        '
        'ActiveStatusComboBox
        '
        Me.ActiveStatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Cust_Active_Status", True))
        Me.ActiveStatusComboBox.FormattingEnabled = True
        Me.ActiveStatusComboBox.Items.AddRange(New Object() {"T", "F"})
        Me.ActiveStatusComboBox.Location = New System.Drawing.Point(651, 271)
        Me.ActiveStatusComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ActiveStatusComboBox.MaxDropDownItems = 100
        Me.ActiveStatusComboBox.Name = "ActiveStatusComboBox"
        Me.ActiveStatusComboBox.Size = New System.Drawing.Size(48, 21)
        Me.ActiveStatusComboBox.TabIndex = 76
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(517, 274)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 13)
        Me.Label18.TabIndex = 73
        Me.Label18.Text = "* Active Status:"
        '
        'PostalCodeMaskedTextBox
        '
        Me.PostalCodeMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Cust_Postal_Code", True))
        Me.PostalCodeMaskedTextBox.Location = New System.Drawing.Point(651, 226)
        Me.PostalCodeMaskedTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PostalCodeMaskedTextBox.Mask = "0000"
        Me.PostalCodeMaskedTextBox.Name = "PostalCodeMaskedTextBox"
        Me.PostalCodeMaskedTextBox.ReadOnly = True
        Me.PostalCodeMaskedTextBox.Size = New System.Drawing.Size(48, 20)
        Me.PostalCodeMaskedTextBox.TabIndex = 64
        Me.PostalCodeMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(517, 229)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(74, 13)
        Me.Label14.TabIndex = 63
        Me.Label14.Text = "* Postal Code:"
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Cust_City", True))
        Me.CityTextBox.Location = New System.Drawing.Point(651, 147)
        Me.CityTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.ReadOnly = True
        Me.CityTextBox.Size = New System.Drawing.Size(167, 20)
        Me.CityTextBox.TabIndex = 62
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(516, 150)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(34, 13)
        Me.Label13.TabIndex = 61
        Me.Label13.Text = "* City:"
        '
        'SuburbTextBox
        '
        Me.SuburbTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Cust_Suburb", True))
        Me.SuburbTextBox.Location = New System.Drawing.Point(651, 110)
        Me.SuburbTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.SuburbTextBox.Name = "SuburbTextBox"
        Me.SuburbTextBox.ReadOnly = True
        Me.SuburbTextBox.Size = New System.Drawing.Size(167, 20)
        Me.SuburbTextBox.TabIndex = 60
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(516, 113)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 13)
        Me.Label12.TabIndex = 59
        Me.Label12.Text = "* Suburb:"
        '
        'ProvinceTextBox
        '
        Me.ProvinceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Cust_Province", True))
        Me.ProvinceTextBox.Location = New System.Drawing.Point(651, 187)
        Me.ProvinceTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ProvinceTextBox.Name = "ProvinceTextBox"
        Me.ProvinceTextBox.ReadOnly = True
        Me.ProvinceTextBox.Size = New System.Drawing.Size(167, 20)
        Me.ProvinceTextBox.TabIndex = 58
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(516, 190)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 13)
        Me.Label11.TabIndex = 57
        Me.Label11.Text = "* Province:"
        '
        'DOBDateTimePicker
        '
        Me.DOBDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerBindingSource, "Cust_DOB", True))
        Me.DOBDateTimePicker.Location = New System.Drawing.Point(221, 132)
        Me.DOBDateTimePicker.Name = "DOBDateTimePicker"
        Me.DOBDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DOBDateTimePicker.TabIndex = 56
        '
        'StreetAddress2TextBox
        '
        Me.StreetAddress2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Cust_Street_Addr_2", True))
        Me.StreetAddress2TextBox.Location = New System.Drawing.Point(651, 68)
        Me.StreetAddress2TextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.StreetAddress2TextBox.Name = "StreetAddress2TextBox"
        Me.StreetAddress2TextBox.ReadOnly = True
        Me.StreetAddress2TextBox.Size = New System.Drawing.Size(167, 20)
        Me.StreetAddress2TextBox.TabIndex = 55
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(516, 71)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(136, 13)
        Me.Label10.TabIndex = 54
        Me.Label10.Text = "Street Address 2 (Optional):"
        '
        'StreetAddress1TextBox
        '
        Me.StreetAddress1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Cust_Street_Addr_1", True))
        Me.StreetAddress1TextBox.Location = New System.Drawing.Point(651, 28)
        Me.StreetAddress1TextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.StreetAddress1TextBox.Name = "StreetAddress1TextBox"
        Me.StreetAddress1TextBox.ReadOnly = True
        Me.StreetAddress1TextBox.Size = New System.Drawing.Size(167, 20)
        Me.StreetAddress1TextBox.TabIndex = 53
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(516, 31)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 13)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "* Street Address 1:"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Cust_Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(221, 252)
        Me.EmailTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.ReadOnly = True
        Me.EmailTextBox.Size = New System.Drawing.Size(162, 20)
        Me.EmailTextBox.TabIndex = 49
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(30, 255)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "* Email:"
        '
        'AltContactNumberMaskedTextBox
        '
        Me.AltContactNumberMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Cust_Alt_Phone_No", True))
        Me.AltContactNumberMaskedTextBox.Location = New System.Drawing.Point(221, 213)
        Me.AltContactNumberMaskedTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.AltContactNumberMaskedTextBox.Mask = "(000)0000000"
        Me.AltContactNumberMaskedTextBox.Name = "AltContactNumberMaskedTextBox"
        Me.AltContactNumberMaskedTextBox.ReadOnly = True
        Me.AltContactNumberMaskedTextBox.Size = New System.Drawing.Size(80, 20)
        Me.AltContactNumberMaskedTextBox.TabIndex = 47
        Me.AltContactNumberMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(30, 216)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(180, 13)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Alternate Contact Number (Optional):"
        '
        'ContactNumberMaskedTextBox
        '
        Me.ContactNumberMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Cust_Phone_No", True))
        Me.ContactNumberMaskedTextBox.Location = New System.Drawing.Point(221, 174)
        Me.ContactNumberMaskedTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ContactNumberMaskedTextBox.Mask = "(000)0000000"
        Me.ContactNumberMaskedTextBox.Name = "ContactNumberMaskedTextBox"
        Me.ContactNumberMaskedTextBox.ReadOnly = True
        Me.ContactNumberMaskedTextBox.Size = New System.Drawing.Size(80, 20)
        Me.ContactNumberMaskedTextBox.TabIndex = 45
        Me.ContactNumberMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 177)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 13)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "* Contact Number:"
        '
        'SNameTextBox
        '
        Me.SNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Cust_SName", True))
        Me.SNameTextBox.Location = New System.Drawing.Point(221, 95)
        Me.SNameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.SNameTextBox.Name = "SNameTextBox"
        Me.SNameTextBox.ReadOnly = True
        Me.SNameTextBox.Size = New System.Drawing.Size(162, 20)
        Me.SNameTextBox.TabIndex = 41
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 98)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "* Surname:"
        '
        'FNameTextBox
        '
        Me.FNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Cust_FName", True))
        Me.FNameTextBox.Location = New System.Drawing.Point(221, 57)
        Me.FNameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.FNameTextBox.Name = "FNameTextBox"
        Me.FNameTextBox.ReadOnly = True
        Me.FNameTextBox.Size = New System.Drawing.Size(162, 20)
        Me.FNameTextBox.TabIndex = 39
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(30, 139)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "* Date Of Birth: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(28, 25)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "* Customer ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(29, 63)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "* First Name:"
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me.Group16DataSet
        '
        'CustomerInfoPopUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.M.I.S.S_Vendor_Order_Management_System.My.Resources.Resources.Background1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(871, 385)
        Me.Controls.Add(Me.DetailsGroupBox)
        Me.Controls.Add(Me.BackButton)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "CustomerInfoPopUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Info"
        CType(Me.Group16DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DetailsGroupBox.ResumeLayout(False)
        Me.DetailsGroupBox.PerformLayout()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BackButton As Button
    Friend WithEvents Group16DataSet As group16DataSet
    Friend WithEvents CustomerTableAdapter As group16DataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents DetailsGroupBox As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents Label19 As Label
    Friend WithEvents CustomerIDTextBox As TextBox
    Friend WithEvents ActiveStatusComboBox As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents PostalCodeMaskedTextBox As MaskedTextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents SuburbTextBox As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents ProvinceTextBox As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents DOBDateTimePicker As DateTimePicker
    Friend WithEvents StreetAddress2TextBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents StreetAddress1TextBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents AltContactNumberMaskedTextBox As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ContactNumberMaskedTextBox As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents SNameTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents FNameTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class

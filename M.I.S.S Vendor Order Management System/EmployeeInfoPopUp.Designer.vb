<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeInfoPopUp
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
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Group16DataSet = New M.I.S.S_Vendor_Order_Management_System.group16DataSet()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.EmployeeIDTextBox = New System.Windows.Forms.TextBox()
        Me.GenderComboBox = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.PositionTextBox = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.SAIDMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.EmployeeTableAdapter = New M.I.S.S_Vendor_Order_Management_System.group16DataSetTableAdapters.EmployeeTableAdapter()
        Me.DetailsGroupBox.SuspendLayout()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group16DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DetailsGroupBox
        '
        Me.DetailsGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.DetailsGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DetailsGroupBox.Controls.Add(Me.TextBox2)
        Me.DetailsGroupBox.Controls.Add(Me.TextBox1)
        Me.DetailsGroupBox.Controls.Add(Me.Label21)
        Me.DetailsGroupBox.Controls.Add(Me.Label20)
        Me.DetailsGroupBox.Controls.Add(Me.PasswordTextBox)
        Me.DetailsGroupBox.Controls.Add(Me.Label19)
        Me.DetailsGroupBox.Controls.Add(Me.EmployeeIDTextBox)
        Me.DetailsGroupBox.Controls.Add(Me.GenderComboBox)
        Me.DetailsGroupBox.Controls.Add(Me.Label18)
        Me.DetailsGroupBox.Controls.Add(Me.Label17)
        Me.DetailsGroupBox.Controls.Add(Me.PositionTextBox)
        Me.DetailsGroupBox.Controls.Add(Me.Label16)
        Me.DetailsGroupBox.Controls.Add(Me.SAIDMaskedTextBox)
        Me.DetailsGroupBox.Controls.Add(Me.Label15)
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
        Me.DetailsGroupBox.Controls.Add(Me.Label5)
        Me.DetailsGroupBox.Controls.Add(Me.SNameTextBox)
        Me.DetailsGroupBox.Controls.Add(Me.Label3)
        Me.DetailsGroupBox.Controls.Add(Me.FNameTextBox)
        Me.DetailsGroupBox.Controls.Add(Me.Label4)
        Me.DetailsGroupBox.Controls.Add(Me.Label2)
        Me.DetailsGroupBox.Controls.Add(Me.Label1)
        Me.DetailsGroupBox.Location = New System.Drawing.Point(15, 14)
        Me.DetailsGroupBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DetailsGroupBox.Name = "DetailsGroupBox"
        Me.DetailsGroupBox.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DetailsGroupBox.Size = New System.Drawing.Size(1079, 485)
        Me.DetailsGroupBox.TabIndex = 17
        Me.DetailsGroupBox.TabStop = False
        Me.DetailsGroupBox.Text = "EMPLOYEE DETAILS"
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Employee_Active_Status", True))
        Me.TextBox2.Location = New System.Drawing.Point(840, 439)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(64, 22)
        Me.TextBox2.TabIndex = 126
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "Employee"
        Me.EmployeeBindingSource.DataSource = Me.Group16DataSet
        '
        'Group16DataSet
        '
        Me.Group16DataSet.DataSetName = "group16DataSet"
        Me.Group16DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Employee_Admin_Level", True))
        Me.TextBox1.Location = New System.Drawing.Point(840, 375)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(64, 22)
        Me.TextBox1.TabIndex = 125
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(911, 368)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(150, 34)
        Me.Label21.TabIndex = 81
        Me.Label21.Text = "- ""1"" = Employee" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- ""2"" = Manager/Admin"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(911, 430)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(158, 34)
        Me.Label20.TabIndex = 80
        Me.Label20.Text = "- ""T"" for True = Active" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- ""F"" for False = Inactive"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Employee_Password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(295, 452)
        Me.PasswordTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PasswordTextBox.MaxLength = 10
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.ReadOnly = True
        Me.PasswordTextBox.Size = New System.Drawing.Size(207, 22)
        Me.PasswordTextBox.TabIndex = 79
        Me.PasswordTextBox.UseSystemPasswordChar = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(37, 455)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(199, 17)
        Me.Label19.TabIndex = 78
        Me.Label19.Text = "Password(Max 10 characters):"
        '
        'EmployeeIDTextBox
        '
        Me.EmployeeIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Employee_ID", True))
        Me.EmployeeIDTextBox.Location = New System.Drawing.Point(295, 27)
        Me.EmployeeIDTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.EmployeeIDTextBox.Name = "EmployeeIDTextBox"
        Me.EmployeeIDTextBox.ReadOnly = True
        Me.EmployeeIDTextBox.Size = New System.Drawing.Size(117, 22)
        Me.EmployeeIDTextBox.TabIndex = 77
        '
        'GenderComboBox
        '
        Me.GenderComboBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GenderComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Employee_Gender", True))
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.Items.AddRange(New Object() {"M", "F", "O"})
        Me.GenderComboBox.Location = New System.Drawing.Point(295, 265)
        Me.GenderComboBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GenderComboBox.MaxDropDownItems = 100
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(63, 24)
        Me.GenderComboBox.TabIndex = 76
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(635, 446)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(94, 17)
        Me.Label18.TabIndex = 73
        Me.Label18.Text = "Active Status:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(633, 380)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(89, 17)
        Me.Label17.TabIndex = 71
        Me.Label17.Text = "Admin Level:"
        '
        'PositionTextBox
        '
        Me.PositionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Employee_Position", True))
        Me.PositionTextBox.Location = New System.Drawing.Point(840, 306)
        Me.PositionTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PositionTextBox.Name = "PositionTextBox"
        Me.PositionTextBox.ReadOnly = True
        Me.PositionTextBox.Size = New System.Drawing.Size(171, 22)
        Me.PositionTextBox.TabIndex = 70
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(633, 315)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(62, 17)
        Me.Label16.TabIndex = 69
        Me.Label16.Text = "Position:"
        '
        'SAIDMaskedTextBox
        '
        Me.SAIDMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Employee_SA_ID_No", True))
        Me.SAIDMaskedTextBox.Location = New System.Drawing.Point(295, 215)
        Me.SAIDMaskedTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SAIDMaskedTextBox.Mask = "0000000000000"
        Me.SAIDMaskedTextBox.Name = "SAIDMaskedTextBox"
        Me.SAIDMaskedTextBox.ReadOnly = True
        Me.SAIDMaskedTextBox.Size = New System.Drawing.Size(117, 22)
        Me.SAIDMaskedTextBox.TabIndex = 68
        Me.SAIDMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(37, 219)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(114, 17)
        Me.Label15.TabIndex = 67
        Me.Label15.Text = "South African ID:"
        '
        'PostalCodeMaskedTextBox
        '
        Me.PostalCodeMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Employee_Postal_Code", True))
        Me.PostalCodeMaskedTextBox.Location = New System.Drawing.Point(840, 258)
        Me.PostalCodeMaskedTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PostalCodeMaskedTextBox.Mask = "0000"
        Me.PostalCodeMaskedTextBox.Name = "PostalCodeMaskedTextBox"
        Me.PostalCodeMaskedTextBox.ReadOnly = True
        Me.PostalCodeMaskedTextBox.Size = New System.Drawing.Size(64, 22)
        Me.PostalCodeMaskedTextBox.TabIndex = 64
        Me.PostalCodeMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(635, 262)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 17)
        Me.Label14.TabIndex = 63
        Me.Label14.Text = "Postal Code:"
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Employee_City", True))
        Me.CityTextBox.Location = New System.Drawing.Point(840, 161)
        Me.CityTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.ReadOnly = True
        Me.CityTextBox.Size = New System.Drawing.Size(171, 22)
        Me.CityTextBox.TabIndex = 62
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(633, 165)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 17)
        Me.Label13.TabIndex = 61
        Me.Label13.Text = "City:"
        '
        'SuburbTextBox
        '
        Me.SuburbTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Employee_Suburb", True))
        Me.SuburbTextBox.Location = New System.Drawing.Point(840, 116)
        Me.SuburbTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SuburbTextBox.Name = "SuburbTextBox"
        Me.SuburbTextBox.ReadOnly = True
        Me.SuburbTextBox.Size = New System.Drawing.Size(171, 22)
        Me.SuburbTextBox.TabIndex = 60
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(633, 119)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 17)
        Me.Label12.TabIndex = 59
        Me.Label12.Text = "Suburb:"
        '
        'ProvinceTextBox
        '
        Me.ProvinceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Employee_Province", True))
        Me.ProvinceTextBox.Location = New System.Drawing.Point(840, 210)
        Me.ProvinceTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ProvinceTextBox.Name = "ProvinceTextBox"
        Me.ProvinceTextBox.ReadOnly = True
        Me.ProvinceTextBox.Size = New System.Drawing.Size(171, 22)
        Me.ProvinceTextBox.TabIndex = 58
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(633, 214)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 17)
        Me.Label11.TabIndex = 57
        Me.Label11.Text = "Province:"
        '
        'DOBDateTimePicker
        '
        Me.DOBDateTimePicker.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DOBDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmployeeBindingSource, "Employee_DOB", True))
        Me.DOBDateTimePicker.Location = New System.Drawing.Point(295, 162)
        Me.DOBDateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.DOBDateTimePicker.Name = "DOBDateTimePicker"
        Me.DOBDateTimePicker.Size = New System.Drawing.Size(265, 22)
        Me.DOBDateTimePicker.TabIndex = 56
        '
        'StreetAddress2TextBox
        '
        Me.StreetAddress2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Employee_Street_Addr_2", True))
        Me.StreetAddress2TextBox.Location = New System.Drawing.Point(840, 64)
        Me.StreetAddress2TextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.StreetAddress2TextBox.Name = "StreetAddress2TextBox"
        Me.StreetAddress2TextBox.ReadOnly = True
        Me.StreetAddress2TextBox.Size = New System.Drawing.Size(171, 22)
        Me.StreetAddress2TextBox.TabIndex = 55
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(633, 68)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(185, 17)
        Me.Label10.TabIndex = 54
        Me.Label10.Text = "Street Address 2 (Optional):"
        '
        'StreetAddress1TextBox
        '
        Me.StreetAddress1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Employee_Street_Addr_1", True))
        Me.StreetAddress1TextBox.Location = New System.Drawing.Point(840, 15)
        Me.StreetAddress1TextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.StreetAddress1TextBox.Name = "StreetAddress1TextBox"
        Me.StreetAddress1TextBox.ReadOnly = True
        Me.StreetAddress1TextBox.Size = New System.Drawing.Size(171, 22)
        Me.StreetAddress1TextBox.TabIndex = 53
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(633, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(118, 17)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "Street Address 1:"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Employee_Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(295, 407)
        Me.EmailTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.ReadOnly = True
        Me.EmailTextBox.Size = New System.Drawing.Size(207, 22)
        Me.EmailTextBox.TabIndex = 49
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(40, 416)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 17)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Email:"
        '
        'AltContactNumberMaskedTextBox
        '
        Me.AltContactNumberMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Employee_Alt_Phone_No", True))
        Me.AltContactNumberMaskedTextBox.Location = New System.Drawing.Point(295, 364)
        Me.AltContactNumberMaskedTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AltContactNumberMaskedTextBox.Mask = "(000)0000000"
        Me.AltContactNumberMaskedTextBox.Name = "AltContactNumberMaskedTextBox"
        Me.AltContactNumberMaskedTextBox.ReadOnly = True
        Me.AltContactNumberMaskedTextBox.Size = New System.Drawing.Size(117, 22)
        Me.AltContactNumberMaskedTextBox.TabIndex = 47
        Me.AltContactNumberMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(40, 368)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(242, 17)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Alternate Contact Number (Optional):"
        '
        'ContactNumberMaskedTextBox
        '
        Me.ContactNumberMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Employee_Phone_No", True))
        Me.ContactNumberMaskedTextBox.Location = New System.Drawing.Point(295, 316)
        Me.ContactNumberMaskedTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ContactNumberMaskedTextBox.Mask = "(000)0000000"
        Me.ContactNumberMaskedTextBox.Name = "ContactNumberMaskedTextBox"
        Me.ContactNumberMaskedTextBox.ReadOnly = True
        Me.ContactNumberMaskedTextBox.Size = New System.Drawing.Size(117, 22)
        Me.ContactNumberMaskedTextBox.TabIndex = 45
        Me.ContactNumberMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(40, 320)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 17)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Contact Number:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 268)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 17)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Gender:"
        '
        'SNameTextBox
        '
        Me.SNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Employee_SName", True))
        Me.SNameTextBox.Location = New System.Drawing.Point(295, 117)
        Me.SNameTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SNameTextBox.Name = "SNameTextBox"
        Me.SNameTextBox.ReadOnly = True
        Me.SNameTextBox.Size = New System.Drawing.Size(175, 22)
        Me.SNameTextBox.TabIndex = 41
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Surname:"
        '
        'FNameTextBox
        '
        Me.FNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Employee_FName", True))
        Me.FNameTextBox.Location = New System.Drawing.Point(295, 70)
        Me.FNameTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FNameTextBox.Name = "FNameTextBox"
        Me.FNameTextBox.ReadOnly = True
        Me.FNameTextBox.Size = New System.Drawing.Size(175, 22)
        Me.FNameTextBox.TabIndex = 39
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(40, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 17)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Date Of Birth: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(37, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 17)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Employee ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(39, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name:"
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
        Me.BackButton.Location = New System.Drawing.Point(1008, 503)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(85, 44)
        Me.BackButton.TabIndex = 27
        Me.BackButton.Text = "BACK"
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'EmployeeInfoPopUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = Global.M.I.S.S_Vendor_Order_Management_System.My.Resources.Resources.Background1
        Me.ClientSize = New System.Drawing.Size(1109, 554)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.DetailsGroupBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "EmployeeInfoPopUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Info"
        Me.DetailsGroupBox.ResumeLayout(False)
        Me.DetailsGroupBox.PerformLayout()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group16DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DetailsGroupBox As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents EmployeeIDTextBox As TextBox
    Friend WithEvents GenderComboBox As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents PositionTextBox As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents SAIDMaskedTextBox As MaskedTextBox
    Friend WithEvents Label15 As Label
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
    Friend WithEvents Label5 As Label
    Friend WithEvents SNameTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents FNameTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BackButton As Button
    Friend WithEvents EmployeeBindingSource As BindingSource
    Friend WithEvents Group16DataSet As group16DataSet
    Friend WithEvents EmployeeTableAdapter As group16DataSetTableAdapters.EmployeeTableAdapter
End Class

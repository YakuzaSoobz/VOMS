<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SupplierInfoPopUp
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
        Me.RepDetailsGroupBox = New System.Windows.Forms.GroupBox()
        Me.RepEmailTextBox = New System.Windows.Forms.TextBox()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Group16DataSet = New M.I.S.S_Vendor_Order_Management_System.group16DataSet()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.RepAltContactNumberMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RepContactNumberMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RepSNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RepFNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DetailsGroupBox = New System.Windows.Forms.GroupBox()
        Me.ActiveStatusTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.SupplierEmailTextBox = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.AltContactNoMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ContactNoMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.SupplierIDTextBox = New System.Windows.Forms.TextBox()
        Me.CompanyNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PostalCodeMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.SuburbTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ProvinceTextBox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.StreetAddress2TextBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.StreetAddress1TextBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.AdminLevelGroupBox = New System.Windows.Forms.GroupBox()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.SupplierTableAdapter = New M.I.S.S_Vendor_Order_Management_System.group16DataSetTableAdapters.SupplierTableAdapter()
        Me.TableAdapterManager = New M.I.S.S_Vendor_Order_Management_System.group16DataSetTableAdapters.TableAdapterManager()
        Me.RepDetailsGroupBox.SuspendLayout()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group16DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DetailsGroupBox.SuspendLayout()
        Me.AdminLevelGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'RepDetailsGroupBox
        '
        Me.RepDetailsGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.RepDetailsGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RepDetailsGroupBox.Controls.Add(Me.RepEmailTextBox)
        Me.RepDetailsGroupBox.Controls.Add(Me.Label8)
        Me.RepDetailsGroupBox.Controls.Add(Me.RepAltContactNumberMaskedTextBox)
        Me.RepDetailsGroupBox.Controls.Add(Me.Label7)
        Me.RepDetailsGroupBox.Controls.Add(Me.RepContactNumberMaskedTextBox)
        Me.RepDetailsGroupBox.Controls.Add(Me.Label6)
        Me.RepDetailsGroupBox.Controls.Add(Me.RepSNameTextBox)
        Me.RepDetailsGroupBox.Controls.Add(Me.Label3)
        Me.RepDetailsGroupBox.Controls.Add(Me.RepFNameTextBox)
        Me.RepDetailsGroupBox.Controls.Add(Me.Label1)
        Me.RepDetailsGroupBox.Location = New System.Drawing.Point(855, 21)
        Me.RepDetailsGroupBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RepDetailsGroupBox.Name = "RepDetailsGroupBox"
        Me.RepDetailsGroupBox.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RepDetailsGroupBox.Size = New System.Drawing.Size(411, 374)
        Me.RepDetailsGroupBox.TabIndex = 77
        Me.RepDetailsGroupBox.TabStop = False
        Me.RepDetailsGroupBox.Text = "SUPPLIER REPRESENTATIVE DETAILS"
        '
        'RepEmailTextBox
        '
        Me.RepEmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "Supplier_Rep_Email", True))
        Me.RepEmailTextBox.Location = New System.Drawing.Point(172, 271)
        Me.RepEmailTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RepEmailTextBox.Name = "RepEmailTextBox"
        Me.RepEmailTextBox.ReadOnly = True
        Me.RepEmailTextBox.Size = New System.Drawing.Size(189, 22)
        Me.RepEmailTextBox.TabIndex = 99
        Me.RepEmailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 274)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 17)
        Me.Label8.TabIndex = 98
        Me.Label8.Text = "Email:"
        '
        'RepAltContactNumberMaskedTextBox
        '
        Me.RepAltContactNumberMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "Supplier_Rep_Alt_Phone_No", True))
        Me.RepAltContactNumberMaskedTextBox.Location = New System.Drawing.Point(172, 223)
        Me.RepAltContactNumberMaskedTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RepAltContactNumberMaskedTextBox.Mask = "(000)0000000"
        Me.RepAltContactNumberMaskedTextBox.Name = "RepAltContactNumberMaskedTextBox"
        Me.RepAltContactNumberMaskedTextBox.ReadOnly = True
        Me.RepAltContactNumberMaskedTextBox.Size = New System.Drawing.Size(103, 22)
        Me.RepAltContactNumberMaskedTextBox.TabIndex = 97
        Me.RepAltContactNumberMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 217)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 34)
        Me.Label7.TabIndex = 96
        Me.Label7.Text = "Alternate Contact " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Number (Optional):"
        '
        'RepContactNumberMaskedTextBox
        '
        Me.RepContactNumberMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "Supplier_Rep_Phone_No", True))
        Me.RepContactNumberMaskedTextBox.Location = New System.Drawing.Point(172, 175)
        Me.RepContactNumberMaskedTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RepContactNumberMaskedTextBox.Mask = "(000)0000000"
        Me.RepContactNumberMaskedTextBox.Name = "RepContactNumberMaskedTextBox"
        Me.RepContactNumberMaskedTextBox.ReadOnly = True
        Me.RepContactNumberMaskedTextBox.Size = New System.Drawing.Size(103, 22)
        Me.RepContactNumberMaskedTextBox.TabIndex = 95
        Me.RepContactNumberMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 17)
        Me.Label6.TabIndex = 94
        Me.Label6.Text = "Contact Number:"
        '
        'RepSNameTextBox
        '
        Me.RepSNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "Supplier_Rep_SName", True))
        Me.RepSNameTextBox.Location = New System.Drawing.Point(172, 119)
        Me.RepSNameTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RepSNameTextBox.Name = "RepSNameTextBox"
        Me.RepSNameTextBox.ReadOnly = True
        Me.RepSNameTextBox.Size = New System.Drawing.Size(189, 22)
        Me.RepSNameTextBox.TabIndex = 93
        Me.RepSNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 92
        Me.Label3.Text = "Surname:"
        '
        'RepFNameTextBox
        '
        Me.RepFNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "Supplier_Rep_FName", True))
        Me.RepFNameTextBox.Location = New System.Drawing.Point(172, 73)
        Me.RepFNameTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RepFNameTextBox.Name = "RepFNameTextBox"
        Me.RepFNameTextBox.ReadOnly = True
        Me.RepFNameTextBox.Size = New System.Drawing.Size(189, 22)
        Me.RepFNameTextBox.TabIndex = 91
        Me.RepFNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(15, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 17)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "First Name:"
        '
        'DetailsGroupBox
        '
        Me.DetailsGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.DetailsGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DetailsGroupBox.Controls.Add(Me.ActiveStatusTextBox)
        Me.DetailsGroupBox.Controls.Add(Me.Label4)
        Me.DetailsGroupBox.Controls.Add(Me.PasswordTextBox)
        Me.DetailsGroupBox.Controls.Add(Me.Label19)
        Me.DetailsGroupBox.Controls.Add(Me.SupplierEmailTextBox)
        Me.DetailsGroupBox.Controls.Add(Me.Label15)
        Me.DetailsGroupBox.Controls.Add(Me.AltContactNoMaskedTextBox)
        Me.DetailsGroupBox.Controls.Add(Me.Label16)
        Me.DetailsGroupBox.Controls.Add(Me.ContactNoMaskedTextBox)
        Me.DetailsGroupBox.Controls.Add(Me.Label17)
        Me.DetailsGroupBox.Controls.Add(Me.Label18)
        Me.DetailsGroupBox.Controls.Add(Me.SupplierIDTextBox)
        Me.DetailsGroupBox.Controls.Add(Me.CompanyNameTextBox)
        Me.DetailsGroupBox.Controls.Add(Me.Label5)
        Me.DetailsGroupBox.Controls.Add(Me.PostalCodeMaskedTextBox)
        Me.DetailsGroupBox.Controls.Add(Me.Label14)
        Me.DetailsGroupBox.Controls.Add(Me.CityTextBox)
        Me.DetailsGroupBox.Controls.Add(Me.Label13)
        Me.DetailsGroupBox.Controls.Add(Me.SuburbTextBox)
        Me.DetailsGroupBox.Controls.Add(Me.Label2)
        Me.DetailsGroupBox.Controls.Add(Me.Label12)
        Me.DetailsGroupBox.Controls.Add(Me.ProvinceTextBox)
        Me.DetailsGroupBox.Controls.Add(Me.Label11)
        Me.DetailsGroupBox.Controls.Add(Me.StreetAddress2TextBox)
        Me.DetailsGroupBox.Controls.Add(Me.Label10)
        Me.DetailsGroupBox.Controls.Add(Me.StreetAddress1TextBox)
        Me.DetailsGroupBox.Controls.Add(Me.Label9)
        Me.DetailsGroupBox.Location = New System.Drawing.Point(21, 21)
        Me.DetailsGroupBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DetailsGroupBox.Name = "DetailsGroupBox"
        Me.DetailsGroupBox.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DetailsGroupBox.Size = New System.Drawing.Size(828, 374)
        Me.DetailsGroupBox.TabIndex = 78
        Me.DetailsGroupBox.TabStop = False
        Me.DetailsGroupBox.Text = "SUPPLIER DETAILS"
        '
        'ActiveStatusTextBox
        '
        Me.ActiveStatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "Supplier_Active_Status", True))
        Me.ActiveStatusTextBox.Location = New System.Drawing.Point(176, 321)
        Me.ActiveStatusTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ActiveStatusTextBox.MaxLength = 10
        Me.ActiveStatusTextBox.Name = "ActiveStatusTextBox"
        Me.ActiveStatusTextBox.ReadOnly = True
        Me.ActiveStatusTextBox.Size = New System.Drawing.Size(49, 22)
        Me.ActiveStatusTextBox.TabIndex = 120
        Me.ActiveStatusTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(245, 316)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(158, 34)
        Me.Label4.TabIndex = 119
        Me.Label4.Text = "- ""T"" for True = Active" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- ""F"" for False = Inactive"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "Supplier_Password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(176, 277)
        Me.PasswordTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PasswordTextBox.MaxLength = 10
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.ReadOnly = True
        Me.PasswordTextBox.Size = New System.Drawing.Size(203, 22)
        Me.PasswordTextBox.TabIndex = 118
        Me.PasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PasswordTextBox.UseSystemPasswordChar = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(19, 272)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(138, 34)
        Me.Label19.TabIndex = 117
        Me.Label19.Text = "Optional Password" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Max 10 characters):"
        '
        'SupplierEmailTextBox
        '
        Me.SupplierEmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "Supplier_Email", True))
        Me.SupplierEmailTextBox.Location = New System.Drawing.Point(176, 220)
        Me.SupplierEmailTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SupplierEmailTextBox.Name = "SupplierEmailTextBox"
        Me.SupplierEmailTextBox.ReadOnly = True
        Me.SupplierEmailTextBox.Size = New System.Drawing.Size(203, 22)
        Me.SupplierEmailTextBox.TabIndex = 116
        Me.SupplierEmailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(19, 223)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(109, 17)
        Me.Label15.TabIndex = 115
        Me.Label15.Text = "Company Email:"
        '
        'AltContactNoMaskedTextBox
        '
        Me.AltContactNoMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "Supplier_Alt_Phone_No", True))
        Me.AltContactNoMaskedTextBox.Location = New System.Drawing.Point(176, 174)
        Me.AltContactNoMaskedTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AltContactNoMaskedTextBox.Mask = "(000)0000000"
        Me.AltContactNoMaskedTextBox.Name = "AltContactNoMaskedTextBox"
        Me.AltContactNoMaskedTextBox.ReadOnly = True
        Me.AltContactNoMaskedTextBox.Size = New System.Drawing.Size(105, 22)
        Me.AltContactNoMaskedTextBox.TabIndex = 114
        Me.AltContactNoMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(19, 167)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(129, 34)
        Me.Label16.TabIndex = 113
        Me.Label16.Text = "Alternate Contact " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Number (Optional):"
        '
        'ContactNoMaskedTextBox
        '
        Me.ContactNoMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "Supplier_Phone_No", True))
        Me.ContactNoMaskedTextBox.Location = New System.Drawing.Point(176, 119)
        Me.ContactNoMaskedTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ContactNoMaskedTextBox.Mask = "(000)0000000"
        Me.ContactNoMaskedTextBox.Name = "ContactNoMaskedTextBox"
        Me.ContactNoMaskedTextBox.ReadOnly = True
        Me.ContactNoMaskedTextBox.Size = New System.Drawing.Size(105, 22)
        Me.ContactNoMaskedTextBox.TabIndex = 112
        Me.ContactNoMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(19, 124)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(114, 17)
        Me.Label17.TabIndex = 111
        Me.Label17.Text = "Contact Number:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(19, 325)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(94, 17)
        Me.Label18.TabIndex = 109
        Me.Label18.Text = "Active Status:"
        '
        'SupplierIDTextBox
        '
        Me.SupplierIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "Supplier_ID", True))
        Me.SupplierIDTextBox.Location = New System.Drawing.Point(176, 30)
        Me.SupplierIDTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SupplierIDTextBox.Name = "SupplierIDTextBox"
        Me.SupplierIDTextBox.ReadOnly = True
        Me.SupplierIDTextBox.Size = New System.Drawing.Size(105, 22)
        Me.SupplierIDTextBox.TabIndex = 106
        Me.SupplierIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CompanyNameTextBox
        '
        Me.CompanyNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "Supplier_Name", True))
        Me.CompanyNameTextBox.Location = New System.Drawing.Point(176, 73)
        Me.CompanyNameTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CompanyNameTextBox.Name = "CompanyNameTextBox"
        Me.CompanyNameTextBox.ReadOnly = True
        Me.CompanyNameTextBox.Size = New System.Drawing.Size(203, 22)
        Me.CompanyNameTextBox.TabIndex = 93
        Me.CompanyNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(19, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 17)
        Me.Label5.TabIndex = 92
        Me.Label5.Text = "Company Name:"
        '
        'PostalCodeMaskedTextBox
        '
        Me.PostalCodeMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "Supplier_Postal_Code", True))
        Me.PostalCodeMaskedTextBox.Location = New System.Drawing.Point(623, 289)
        Me.PostalCodeMaskedTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PostalCodeMaskedTextBox.Mask = "0000"
        Me.PostalCodeMaskedTextBox.Name = "PostalCodeMaskedTextBox"
        Me.PostalCodeMaskedTextBox.ReadOnly = True
        Me.PostalCodeMaskedTextBox.Size = New System.Drawing.Size(63, 22)
        Me.PostalCodeMaskedTextBox.TabIndex = 88
        Me.PostalCodeMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(432, 294)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 17)
        Me.Label14.TabIndex = 87
        Me.Label14.Text = "Postal Code:"
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "Supplier_City", True))
        Me.CityTextBox.Location = New System.Drawing.Point(623, 191)
        Me.CityTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.ReadOnly = True
        Me.CityTextBox.Size = New System.Drawing.Size(175, 22)
        Me.CityTextBox.TabIndex = 86
        Me.CityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(431, 193)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 17)
        Me.Label13.TabIndex = 85
        Me.Label13.Text = "City:"
        '
        'SuburbTextBox
        '
        Me.SuburbTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "Supplier_Suburb", True))
        Me.SuburbTextBox.Location = New System.Drawing.Point(623, 146)
        Me.SuburbTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SuburbTextBox.Name = "SuburbTextBox"
        Me.SuburbTextBox.ReadOnly = True
        Me.SuburbTextBox.Size = New System.Drawing.Size(175, 22)
        Me.SuburbTextBox.TabIndex = 84
        Me.SuburbTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(19, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 17)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Supplier ID:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(431, 148)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 17)
        Me.Label12.TabIndex = 83
        Me.Label12.Text = "Suburb:"
        '
        'ProvinceTextBox
        '
        Me.ProvinceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "Supplier_Province", True))
        Me.ProvinceTextBox.Location = New System.Drawing.Point(623, 241)
        Me.ProvinceTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ProvinceTextBox.Name = "ProvinceTextBox"
        Me.ProvinceTextBox.ReadOnly = True
        Me.ProvinceTextBox.Size = New System.Drawing.Size(175, 22)
        Me.ProvinceTextBox.TabIndex = 82
        Me.ProvinceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(431, 244)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 17)
        Me.Label11.TabIndex = 81
        Me.Label11.Text = "Province:"
        '
        'StreetAddress2TextBox
        '
        Me.StreetAddress2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "Supplier_Street_Addr_2", True))
        Me.StreetAddress2TextBox.Location = New System.Drawing.Point(623, 95)
        Me.StreetAddress2TextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.StreetAddress2TextBox.Name = "StreetAddress2TextBox"
        Me.StreetAddress2TextBox.ReadOnly = True
        Me.StreetAddress2TextBox.Size = New System.Drawing.Size(175, 22)
        Me.StreetAddress2TextBox.TabIndex = 80
        Me.StreetAddress2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(431, 96)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(185, 17)
        Me.Label10.TabIndex = 79
        Me.Label10.Text = "Street Address 2 (Optional):"
        '
        'StreetAddress1TextBox
        '
        Me.StreetAddress1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "Supplier_Street_Addr_1", True))
        Me.StreetAddress1TextBox.Location = New System.Drawing.Point(623, 46)
        Me.StreetAddress1TextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.StreetAddress1TextBox.Name = "StreetAddress1TextBox"
        Me.StreetAddress1TextBox.ReadOnly = True
        Me.StreetAddress1TextBox.Size = New System.Drawing.Size(175, 22)
        Me.StreetAddress1TextBox.TabIndex = 78
        Me.StreetAddress1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(431, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(118, 17)
        Me.Label9.TabIndex = 77
        Me.Label9.Text = "Street Address 1:"
        '
        'AdminLevelGroupBox
        '
        Me.AdminLevelGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.AdminLevelGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AdminLevelGroupBox.Controls.Add(Me.DetailsGroupBox)
        Me.AdminLevelGroupBox.Controls.Add(Me.RepDetailsGroupBox)
        Me.AdminLevelGroupBox.Location = New System.Drawing.Point(15, 14)
        Me.AdminLevelGroupBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AdminLevelGroupBox.Name = "AdminLevelGroupBox"
        Me.AdminLevelGroupBox.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AdminLevelGroupBox.Size = New System.Drawing.Size(1283, 414)
        Me.AdminLevelGroupBox.TabIndex = 73
        Me.AdminLevelGroupBox.TabStop = False
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BackButton.FlatAppearance.BorderSize = 3
        Me.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.BackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Location = New System.Drawing.Point(1200, 440)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(105, 41)
        Me.BackButton.TabIndex = 26
        Me.BackButton.Text = "BACK"
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Customer_Quote_Line_ItemTableAdapter = Nothing
        Me.TableAdapterManager.Customer_QuoteTableAdapter = Nothing
        Me.TableAdapterManager.CustomerTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeTableAdapter = Nothing
        Me.TableAdapterManager.ProductTableAdapter = Nothing
        Me.TableAdapterManager.Supplier_Quote_Line_ItemTableAdapter = Nothing
        Me.TableAdapterManager.Supplier_QuoteTableAdapter = Nothing
        Me.TableAdapterManager.SupplierTableAdapter = Me.SupplierTableAdapter
        Me.TableAdapterManager.UpdateOrder = M.I.S.S_Vendor_Order_Management_System.group16DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SupplierInfoPopUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = Global.M.I.S.S_Vendor_Order_Management_System.My.Resources.Resources.Background1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1317, 492)
        Me.Controls.Add(Me.AdminLevelGroupBox)
        Me.Controls.Add(Me.BackButton)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "SupplierInfoPopUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Supplier Info"
        Me.RepDetailsGroupBox.ResumeLayout(False)
        Me.RepDetailsGroupBox.PerformLayout()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group16DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DetailsGroupBox.ResumeLayout(False)
        Me.DetailsGroupBox.PerformLayout()
        Me.AdminLevelGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RepDetailsGroupBox As GroupBox
    Friend WithEvents RepEmailTextBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents RepAltContactNumberMaskedTextBox As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents RepContactNumberMaskedTextBox As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents RepSNameTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents RepFNameTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DetailsGroupBox As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents SupplierEmailTextBox As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents AltContactNoMaskedTextBox As MaskedTextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents ContactNoMaskedTextBox As MaskedTextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents SupplierIDTextBox As TextBox
    Friend WithEvents CompanyNameTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PostalCodeMaskedTextBox As MaskedTextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents SuburbTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents ProvinceTextBox As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents StreetAddress2TextBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents StreetAddress1TextBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents AdminLevelGroupBox As GroupBox
    Friend WithEvents BackButton As Button
    Friend WithEvents ActiveStatusTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents SupplierBindingSource As BindingSource
    Friend WithEvents Group16DataSet As group16DataSet
    Friend WithEvents SupplierTableAdapter As group16DataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents TableAdapterManager As group16DataSetTableAdapters.TableAdapterManager
End Class

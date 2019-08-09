<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SupplierManager
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
        Me.OptionsGroupBox = New System.Windows.Forms.GroupBox()
        Me.ArchiveButton = New System.Windows.Forms.Button()
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        Me.CreateButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.NavigationGroupBox = New System.Windows.Forms.GroupBox()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.SearchComboBox = New System.Windows.Forms.ComboBox()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.LastButton = New System.Windows.Forms.Button()
        Me.PreviousButton = New System.Windows.Forms.Button()
        Me.FirstButton = New System.Windows.Forms.Button()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.LogOutButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.AdminLevelGroupBox = New System.Windows.Forms.GroupBox()
        Me.DetailsGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Group16DataSet = New M.I.S.S_Vendor_Order_Management_System.group16DataSet()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.SupplierEmailTextBox = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.AltContactNoMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ContactNoMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ActiveStatusComboBox = New System.Windows.Forms.ComboBox()
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
        Me.RepDetailsGroupBox = New System.Windows.Forms.GroupBox()
        Me.RepEmailTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.RepAltContactNumberMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RepContactNumberMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RepSNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RepFNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SupplierTableAdapter = New M.I.S.S_Vendor_Order_Management_System.group16DataSetTableAdapters.SupplierTableAdapter()
        Me.TableAdapterManager = New M.I.S.S_Vendor_Order_Management_System.group16DataSetTableAdapters.TableAdapterManager()
        Me.HelpBtn = New System.Windows.Forms.Button()
        Me.SupplierManagerTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.CustomerTableAdapter = New M.I.S.S_Vendor_Order_Management_System.group16DataSetTableAdapters.CustomerTableAdapter()
        Me.EmployeeTableAdapter = New M.I.S.S_Vendor_Order_Management_System.group16DataSetTableAdapters.EmployeeTableAdapter()
        Me.OptionsGroupBox.SuspendLayout()
        Me.NavigationGroupBox.SuspendLayout()
        Me.AdminLevelGroupBox.SuspendLayout()
        Me.DetailsGroupBox.SuspendLayout()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group16DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RepDetailsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'OptionsGroupBox
        '
        Me.OptionsGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.OptionsGroupBox.Controls.Add(Me.ArchiveButton)
        Me.OptionsGroupBox.Controls.Add(Me.ButtonRefresh)
        Me.OptionsGroupBox.Controls.Add(Me.CreateButton)
        Me.OptionsGroupBox.Controls.Add(Me.UpdateButton)
        Me.OptionsGroupBox.Location = New System.Drawing.Point(11, 468)
        Me.OptionsGroupBox.Margin = New System.Windows.Forms.Padding(2)
        Me.OptionsGroupBox.Name = "OptionsGroupBox"
        Me.OptionsGroupBox.Padding = New System.Windows.Forms.Padding(2)
        Me.OptionsGroupBox.Size = New System.Drawing.Size(962, 59)
        Me.OptionsGroupBox.TabIndex = 76
        Me.OptionsGroupBox.TabStop = False
        Me.OptionsGroupBox.Text = "OPTIONS"
        '
        'ArchiveButton
        '
        Me.ArchiveButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ArchiveButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ArchiveButton.FlatAppearance.BorderSize = 3
        Me.ArchiveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.ArchiveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.ArchiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ArchiveButton.Location = New System.Drawing.Point(28, 17)
        Me.ArchiveButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ArchiveButton.Name = "ArchiveButton"
        Me.ArchiveButton.Size = New System.Drawing.Size(172, 33)
        Me.ArchiveButton.TabIndex = 5
        Me.ArchiveButton.Text = "ARCHIVE SUPPLIER"
        Me.ArchiveButton.UseVisualStyleBackColor = False
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonRefresh.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonRefresh.FlatAppearance.BorderSize = 3
        Me.ButtonRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.ButtonRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.ButtonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRefresh.Location = New System.Drawing.Point(761, 17)
        Me.ButtonRefresh.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(172, 33)
        Me.ButtonRefresh.TabIndex = 4
        Me.ButtonRefresh.Text = "REFRESH"
        Me.ButtonRefresh.UseVisualStyleBackColor = False
        '
        'CreateButton
        '
        Me.CreateButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CreateButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.CreateButton.FlatAppearance.BorderSize = 3
        Me.CreateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.CreateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.CreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CreateButton.Location = New System.Drawing.Point(522, 17)
        Me.CreateButton.Margin = New System.Windows.Forms.Padding(2)
        Me.CreateButton.Name = "CreateButton"
        Me.CreateButton.Size = New System.Drawing.Size(172, 33)
        Me.CreateButton.TabIndex = 3
        Me.CreateButton.Text = "CREATE NEW SUPPLIER"
        Me.CreateButton.UseVisualStyleBackColor = False
        '
        'UpdateButton
        '
        Me.UpdateButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UpdateButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.UpdateButton.FlatAppearance.BorderSize = 3
        Me.UpdateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.UpdateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpdateButton.Location = New System.Drawing.Point(274, 17)
        Me.UpdateButton.Margin = New System.Windows.Forms.Padding(2)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(172, 33)
        Me.UpdateButton.TabIndex = 1
        Me.UpdateButton.Text = "UPDATE/SAVE SUPPLIER"
        Me.UpdateButton.UseVisualStyleBackColor = False
        '
        'NavigationGroupBox
        '
        Me.NavigationGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.NavigationGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NavigationGroupBox.Controls.Add(Me.SearchButton)
        Me.NavigationGroupBox.Controls.Add(Me.SearchComboBox)
        Me.NavigationGroupBox.Controls.Add(Me.NextButton)
        Me.NavigationGroupBox.Controls.Add(Me.LastButton)
        Me.NavigationGroupBox.Controls.Add(Me.PreviousButton)
        Me.NavigationGroupBox.Controls.Add(Me.FirstButton)
        Me.NavigationGroupBox.Controls.Add(Me.SearchTextBox)
        Me.NavigationGroupBox.Location = New System.Drawing.Point(11, 11)
        Me.NavigationGroupBox.Margin = New System.Windows.Forms.Padding(2)
        Me.NavigationGroupBox.Name = "NavigationGroupBox"
        Me.NavigationGroupBox.Padding = New System.Windows.Forms.Padding(2)
        Me.NavigationGroupBox.Size = New System.Drawing.Size(962, 114)
        Me.NavigationGroupBox.TabIndex = 75
        Me.NavigationGroupBox.TabStop = False
        Me.NavigationGroupBox.Text = "NAVIGATION"
        '
        'SearchButton
        '
        Me.SearchButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SearchButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.SearchButton.FlatAppearance.BorderSize = 3
        Me.SearchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.SearchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchButton.Location = New System.Drawing.Point(616, 21)
        Me.SearchButton.Margin = New System.Windows.Forms.Padding(2)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(100, 33)
        Me.SearchButton.TabIndex = 92
        Me.SearchButton.Text = "SEARCH"
        Me.SearchButton.UseVisualStyleBackColor = False
        '
        'SearchComboBox
        '
        Me.SearchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SearchComboBox.FormattingEnabled = True
        Me.SearchComboBox.Items.AddRange(New Object() {"Supplier ID", "Company Name", "Supplier City", "Rep Name"})
        Me.SearchComboBox.Location = New System.Drawing.Point(468, 27)
        Me.SearchComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.SearchComboBox.MaxDropDownItems = 100
        Me.SearchComboBox.Name = "SearchComboBox"
        Me.SearchComboBox.Size = New System.Drawing.Size(144, 21)
        Me.SearchComboBox.TabIndex = 91
        '
        'NextButton
        '
        Me.NextButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NextButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.NextButton.FlatAppearance.BorderSize = 3
        Me.NextButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.NextButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NextButton.Location = New System.Drawing.Point(364, 65)
        Me.NextButton.Margin = New System.Windows.Forms.Padding(2)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(100, 33)
        Me.NextButton.TabIndex = 35
        Me.NextButton.Text = "NEXT"
        Me.NextButton.UseVisualStyleBackColor = False
        '
        'LastButton
        '
        Me.LastButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LastButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.LastButton.FlatAppearance.BorderSize = 3
        Me.LastButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.LastButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.LastButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LastButton.Location = New System.Drawing.Point(616, 65)
        Me.LastButton.Margin = New System.Windows.Forms.Padding(2)
        Me.LastButton.Name = "LastButton"
        Me.LastButton.Size = New System.Drawing.Size(100, 33)
        Me.LastButton.TabIndex = 37
        Me.LastButton.Text = "LAST"
        Me.LastButton.UseVisualStyleBackColor = False
        '
        'PreviousButton
        '
        Me.PreviousButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PreviousButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.PreviousButton.FlatAppearance.BorderSize = 3
        Me.PreviousButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.PreviousButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.PreviousButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PreviousButton.Location = New System.Drawing.Point(492, 65)
        Me.PreviousButton.Margin = New System.Windows.Forms.Padding(2)
        Me.PreviousButton.Name = "PreviousButton"
        Me.PreviousButton.Size = New System.Drawing.Size(100, 33)
        Me.PreviousButton.TabIndex = 36
        Me.PreviousButton.Text = "PREVIOUS"
        Me.PreviousButton.UseVisualStyleBackColor = False
        '
        'FirstButton
        '
        Me.FirstButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FirstButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.FirstButton.FlatAppearance.BorderSize = 3
        Me.FirstButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.FirstButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.FirstButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FirstButton.Location = New System.Drawing.Point(240, 65)
        Me.FirstButton.Margin = New System.Windows.Forms.Padding(2)
        Me.FirstButton.Name = "FirstButton"
        Me.FirstButton.Size = New System.Drawing.Size(100, 33)
        Me.FirstButton.TabIndex = 34
        Me.FirstButton.Text = "FIRST"
        Me.FirstButton.UseVisualStyleBackColor = False
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Location = New System.Drawing.Point(240, 28)
        Me.SearchTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(224, 20)
        Me.SearchTextBox.TabIndex = 23
        '
        'LogOutButton
        '
        Me.LogOutButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogOutButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.LogOutButton.FlatAppearance.BorderSize = 3
        Me.LogOutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.LogOutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.LogOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogOutButton.Location = New System.Drawing.Point(11, 529)
        Me.LogOutButton.Margin = New System.Windows.Forms.Padding(2)
        Me.LogOutButton.Name = "LogOutButton"
        Me.LogOutButton.Size = New System.Drawing.Size(80, 39)
        Me.LogOutButton.TabIndex = 74
        Me.LogOutButton.Text = "LOG OUT"
        Me.LogOutButton.UseVisualStyleBackColor = False
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BackButton.FlatAppearance.BorderSize = 3
        Me.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.BackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Location = New System.Drawing.Point(909, 534)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(2)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(64, 39)
        Me.BackButton.TabIndex = 73
        Me.BackButton.Text = "BACK"
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'AdminLevelGroupBox
        '
        Me.AdminLevelGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.AdminLevelGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AdminLevelGroupBox.Controls.Add(Me.DetailsGroupBox)
        Me.AdminLevelGroupBox.Controls.Add(Me.RepDetailsGroupBox)
        Me.AdminLevelGroupBox.Location = New System.Drawing.Point(11, 129)
        Me.AdminLevelGroupBox.Margin = New System.Windows.Forms.Padding(2)
        Me.AdminLevelGroupBox.Name = "AdminLevelGroupBox"
        Me.AdminLevelGroupBox.Padding = New System.Windows.Forms.Padding(2)
        Me.AdminLevelGroupBox.Size = New System.Drawing.Size(962, 336)
        Me.AdminLevelGroupBox.TabIndex = 72
        Me.AdminLevelGroupBox.TabStop = False
        '
        'DetailsGroupBox
        '
        Me.DetailsGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.DetailsGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DetailsGroupBox.Controls.Add(Me.Label4)
        Me.DetailsGroupBox.Controls.Add(Me.PasswordTextBox)
        Me.DetailsGroupBox.Controls.Add(Me.Label19)
        Me.DetailsGroupBox.Controls.Add(Me.SupplierEmailTextBox)
        Me.DetailsGroupBox.Controls.Add(Me.Label15)
        Me.DetailsGroupBox.Controls.Add(Me.AltContactNoMaskedTextBox)
        Me.DetailsGroupBox.Controls.Add(Me.Label16)
        Me.DetailsGroupBox.Controls.Add(Me.ContactNoMaskedTextBox)
        Me.DetailsGroupBox.Controls.Add(Me.Label17)
        Me.DetailsGroupBox.Controls.Add(Me.ActiveStatusComboBox)
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
        Me.DetailsGroupBox.Enabled = False
        Me.DetailsGroupBox.Location = New System.Drawing.Point(16, 17)
        Me.DetailsGroupBox.Margin = New System.Windows.Forms.Padding(2)
        Me.DetailsGroupBox.Name = "DetailsGroupBox"
        Me.DetailsGroupBox.Padding = New System.Windows.Forms.Padding(2)
        Me.DetailsGroupBox.Size = New System.Drawing.Size(621, 305)
        Me.DetailsGroupBox.TabIndex = 78
        Me.DetailsGroupBox.TabStop = False
        Me.DetailsGroupBox.Text = "SUPPLIER DETAILS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(184, 262)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 26)
        Me.Label4.TabIndex = 119
        Me.Label4.Text = "- ""T"" for True = Active" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- ""F"" for False = Inactive"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "Supplier_Password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(132, 225)
        Me.PasswordTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PasswordTextBox.MaxLength = 10
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(153, 20)
        Me.PasswordTextBox.TabIndex = 118
        Me.PasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(14, 221)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(104, 26)
        Me.Label19.TabIndex = 117
        Me.Label19.Text = "* Optional Password" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Max 10 characters):"
        '
        'SupplierEmailTextBox
        '
        Me.SupplierEmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "Supplier_Email", True))
        Me.SupplierEmailTextBox.Location = New System.Drawing.Point(132, 179)
        Me.SupplierEmailTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.SupplierEmailTextBox.Name = "SupplierEmailTextBox"
        Me.SupplierEmailTextBox.Size = New System.Drawing.Size(153, 20)
        Me.SupplierEmailTextBox.TabIndex = 116
        Me.SupplierEmailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(14, 181)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(89, 13)
        Me.Label15.TabIndex = 115
        Me.Label15.Text = "* Company Email:"
        '
        'AltContactNoMaskedTextBox
        '
        Me.AltContactNoMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "Supplier_Alt_Phone_No", True))
        Me.AltContactNoMaskedTextBox.Location = New System.Drawing.Point(132, 141)
        Me.AltContactNoMaskedTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.AltContactNoMaskedTextBox.Mask = "(000)0000000"
        Me.AltContactNoMaskedTextBox.Name = "AltContactNoMaskedTextBox"
        Me.AltContactNoMaskedTextBox.Size = New System.Drawing.Size(80, 20)
        Me.AltContactNoMaskedTextBox.TabIndex = 114
        Me.AltContactNoMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(14, 136)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(95, 26)
        Me.Label16.TabIndex = 113
        Me.Label16.Text = "Alternate Contact " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Number (Optional):"
        '
        'ContactNoMaskedTextBox
        '
        Me.ContactNoMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "Supplier_Phone_No", True))
        Me.ContactNoMaskedTextBox.Location = New System.Drawing.Point(132, 97)
        Me.ContactNoMaskedTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ContactNoMaskedTextBox.Mask = "(000)0000000"
        Me.ContactNoMaskedTextBox.Name = "ContactNoMaskedTextBox"
        Me.ContactNoMaskedTextBox.Size = New System.Drawing.Size(80, 20)
        Me.ContactNoMaskedTextBox.TabIndex = 112
        Me.ContactNoMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(14, 101)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(94, 13)
        Me.Label17.TabIndex = 111
        Me.Label17.Text = "* Contact Number:"
        '
        'ActiveStatusComboBox
        '
        Me.ActiveStatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "Supplier_Active_Status", True))
        Me.ActiveStatusComboBox.FormattingEnabled = True
        Me.ActiveStatusComboBox.Items.AddRange(New Object() {"T", "F"})
        Me.ActiveStatusComboBox.Location = New System.Drawing.Point(132, 262)
        Me.ActiveStatusComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ActiveStatusComboBox.MaxDropDownItems = 100
        Me.ActiveStatusComboBox.Name = "ActiveStatusComboBox"
        Me.ActiveStatusComboBox.Size = New System.Drawing.Size(48, 21)
        Me.ActiveStatusComboBox.TabIndex = 110
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(14, 264)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 13)
        Me.Label18.TabIndex = 109
        Me.Label18.Text = "* Active Status:"
        '
        'SupplierIDTextBox
        '
        Me.SupplierIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "Supplier_ID", True))
        Me.SupplierIDTextBox.Location = New System.Drawing.Point(132, 24)
        Me.SupplierIDTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.SupplierIDTextBox.Name = "SupplierIDTextBox"
        Me.SupplierIDTextBox.ReadOnly = True
        Me.SupplierIDTextBox.Size = New System.Drawing.Size(80, 20)
        Me.SupplierIDTextBox.TabIndex = 106
        Me.SupplierIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CompanyNameTextBox
        '
        Me.CompanyNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "Supplier_Name", True))
        Me.CompanyNameTextBox.Location = New System.Drawing.Point(132, 59)
        Me.CompanyNameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.CompanyNameTextBox.Name = "CompanyNameTextBox"
        Me.CompanyNameTextBox.Size = New System.Drawing.Size(153, 20)
        Me.CompanyNameTextBox.TabIndex = 93
        Me.CompanyNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(14, 64)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 92
        Me.Label5.Text = "* Company Name:"
        '
        'PostalCodeMaskedTextBox
        '
        Me.PostalCodeMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "Supplier_Postal_Code", True))
        Me.PostalCodeMaskedTextBox.Location = New System.Drawing.Point(456, 233)
        Me.PostalCodeMaskedTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PostalCodeMaskedTextBox.Mask = "0000"
        Me.PostalCodeMaskedTextBox.Name = "PostalCodeMaskedTextBox"
        Me.PostalCodeMaskedTextBox.Size = New System.Drawing.Size(48, 20)
        Me.PostalCodeMaskedTextBox.TabIndex = 88
        Me.PostalCodeMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(313, 237)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(74, 13)
        Me.Label14.TabIndex = 87
        Me.Label14.Text = "* Postal Code:"
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "Supplier_City", True))
        Me.CityTextBox.Location = New System.Drawing.Point(456, 153)
        Me.CityTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(132, 20)
        Me.CityTextBox.TabIndex = 86
        Me.CityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(312, 155)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(34, 13)
        Me.Label13.TabIndex = 85
        Me.Label13.Text = "* City:"
        '
        'SuburbTextBox
        '
        Me.SuburbTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "Supplier_Suburb", True))
        Me.SuburbTextBox.Location = New System.Drawing.Point(456, 117)
        Me.SuburbTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.SuburbTextBox.Name = "SuburbTextBox"
        Me.SuburbTextBox.Size = New System.Drawing.Size(132, 20)
        Me.SuburbTextBox.TabIndex = 84
        Me.SuburbTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(14, 28)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "* Supplier ID:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(312, 118)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 13)
        Me.Label12.TabIndex = 83
        Me.Label12.Text = "* Suburb:"
        '
        'ProvinceTextBox
        '
        Me.ProvinceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "Supplier_Province", True))
        Me.ProvinceTextBox.Location = New System.Drawing.Point(456, 194)
        Me.ProvinceTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ProvinceTextBox.Name = "ProvinceTextBox"
        Me.ProvinceTextBox.Size = New System.Drawing.Size(132, 20)
        Me.ProvinceTextBox.TabIndex = 82
        Me.ProvinceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(312, 196)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 13)
        Me.Label11.TabIndex = 81
        Me.Label11.Text = "* Province:"
        '
        'StreetAddress2TextBox
        '
        Me.StreetAddress2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "Supplier_Street_Addr_2", True))
        Me.StreetAddress2TextBox.Location = New System.Drawing.Point(456, 75)
        Me.StreetAddress2TextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.StreetAddress2TextBox.Name = "StreetAddress2TextBox"
        Me.StreetAddress2TextBox.Size = New System.Drawing.Size(132, 20)
        Me.StreetAddress2TextBox.TabIndex = 80
        Me.StreetAddress2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(312, 76)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(136, 13)
        Me.Label10.TabIndex = 79
        Me.Label10.Text = "Street Address 2 (Optional):"
        '
        'StreetAddress1TextBox
        '
        Me.StreetAddress1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "Supplier_Street_Addr_1", True))
        Me.StreetAddress1TextBox.Location = New System.Drawing.Point(456, 35)
        Me.StreetAddress1TextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.StreetAddress1TextBox.Name = "StreetAddress1TextBox"
        Me.StreetAddress1TextBox.Size = New System.Drawing.Size(132, 20)
        Me.StreetAddress1TextBox.TabIndex = 78
        Me.StreetAddress1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(312, 36)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 13)
        Me.Label9.TabIndex = 77
        Me.Label9.Text = "* Street Address 1:"
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
        Me.RepDetailsGroupBox.Enabled = False
        Me.RepDetailsGroupBox.Location = New System.Drawing.Point(641, 17)
        Me.RepDetailsGroupBox.Margin = New System.Windows.Forms.Padding(2)
        Me.RepDetailsGroupBox.Name = "RepDetailsGroupBox"
        Me.RepDetailsGroupBox.Padding = New System.Windows.Forms.Padding(2)
        Me.RepDetailsGroupBox.Size = New System.Drawing.Size(308, 305)
        Me.RepDetailsGroupBox.TabIndex = 77
        Me.RepDetailsGroupBox.TabStop = False
        Me.RepDetailsGroupBox.Text = "SUPPLIER REPRESENTATIVE DETAILS"
        '
        'RepEmailTextBox
        '
        Me.RepEmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "Supplier_Rep_Email", True))
        Me.RepEmailTextBox.Location = New System.Drawing.Point(129, 220)
        Me.RepEmailTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.RepEmailTextBox.Name = "RepEmailTextBox"
        Me.RepEmailTextBox.Size = New System.Drawing.Size(143, 20)
        Me.RepEmailTextBox.TabIndex = 99
        Me.RepEmailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 223)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 98
        Me.Label8.Text = "* Email:"
        '
        'RepAltContactNumberMaskedTextBox
        '
        Me.RepAltContactNumberMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "Supplier_Rep_Alt_Phone_No", True))
        Me.RepAltContactNumberMaskedTextBox.Location = New System.Drawing.Point(129, 181)
        Me.RepAltContactNumberMaskedTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.RepAltContactNumberMaskedTextBox.Mask = "(000)0000000"
        Me.RepAltContactNumberMaskedTextBox.Name = "RepAltContactNumberMaskedTextBox"
        Me.RepAltContactNumberMaskedTextBox.Size = New System.Drawing.Size(78, 20)
        Me.RepAltContactNumberMaskedTextBox.TabIndex = 97
        Me.RepAltContactNumberMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 176)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 26)
        Me.Label7.TabIndex = 96
        Me.Label7.Text = "Alternate Contact " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Number (Optional):"
        '
        'RepContactNumberMaskedTextBox
        '
        Me.RepContactNumberMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "Supplier_Rep_Phone_No", True))
        Me.RepContactNumberMaskedTextBox.Location = New System.Drawing.Point(129, 142)
        Me.RepContactNumberMaskedTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.RepContactNumberMaskedTextBox.Mask = "(000)0000000"
        Me.RepContactNumberMaskedTextBox.Name = "RepContactNumberMaskedTextBox"
        Me.RepContactNumberMaskedTextBox.Size = New System.Drawing.Size(78, 20)
        Me.RepContactNumberMaskedTextBox.TabIndex = 95
        Me.RepContactNumberMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 143)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 13)
        Me.Label6.TabIndex = 94
        Me.Label6.Text = "* Contact Number:"
        '
        'RepSNameTextBox
        '
        Me.RepSNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "Supplier_Rep_SName", True))
        Me.RepSNameTextBox.Location = New System.Drawing.Point(129, 97)
        Me.RepSNameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.RepSNameTextBox.Name = "RepSNameTextBox"
        Me.RepSNameTextBox.Size = New System.Drawing.Size(143, 20)
        Me.RepSNameTextBox.TabIndex = 93
        Me.RepSNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 97)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 92
        Me.Label3.Text = "* Surname:"
        '
        'RepFNameTextBox
        '
        Me.RepFNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "Supplier_Rep_FName", True))
        Me.RepFNameTextBox.Location = New System.Drawing.Point(129, 59)
        Me.RepFNameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.RepFNameTextBox.Name = "RepFNameTextBox"
        Me.RepFNameTextBox.Size = New System.Drawing.Size(143, 20)
        Me.RepFNameTextBox.TabIndex = 91
        Me.RepFNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(11, 62)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "* First Name:"
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
        'HelpBtn
        '
        Me.HelpBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HelpBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.HelpBtn.FlatAppearance.BorderSize = 3
        Me.HelpBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.HelpBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.HelpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HelpBtn.Location = New System.Drawing.Point(452, 532)
        Me.HelpBtn.Name = "HelpBtn"
        Me.HelpBtn.Size = New System.Drawing.Size(79, 36)
        Me.HelpBtn.TabIndex = 77
        Me.HelpBtn.Text = "HELP"
        Me.HelpBtn.UseVisualStyleBackColor = False
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'SupplierManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = Global.M.I.S.S_Vendor_Order_Management_System.My.Resources.Resources.Background1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(986, 584)
        Me.Controls.Add(Me.HelpBtn)
        Me.Controls.Add(Me.OptionsGroupBox)
        Me.Controls.Add(Me.NavigationGroupBox)
        Me.Controls.Add(Me.LogOutButton)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.AdminLevelGroupBox)
        Me.DoubleBuffered = True
        Me.Name = "SupplierManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Supplier Manager"
        Me.OptionsGroupBox.ResumeLayout(False)
        Me.NavigationGroupBox.ResumeLayout(False)
        Me.NavigationGroupBox.PerformLayout()
        Me.AdminLevelGroupBox.ResumeLayout(False)
        Me.DetailsGroupBox.ResumeLayout(False)
        Me.DetailsGroupBox.PerformLayout()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group16DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RepDetailsGroupBox.ResumeLayout(False)
        Me.RepDetailsGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents OptionsGroupBox As GroupBox
    Friend WithEvents ButtonRefresh As Button
    Friend WithEvents CreateButton As Button
    Friend WithEvents UpdateButton As Button
    Friend WithEvents NavigationGroupBox As GroupBox
    Friend WithEvents NextButton As Button
    Friend WithEvents LastButton As Button
    Friend WithEvents PreviousButton As Button
    Friend WithEvents FirstButton As Button
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents LogOutButton As Button
    Friend WithEvents BackButton As Button
    Friend WithEvents AdminLevelGroupBox As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DetailsGroupBox As GroupBox
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
    Friend WithEvents CompanyNameTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PostalCodeMaskedTextBox As MaskedTextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents SuburbTextBox As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents ProvinceTextBox As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents StreetAddress2TextBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents StreetAddress1TextBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents SupplierIDTextBox As TextBox
    Friend WithEvents SearchComboBox As ComboBox
    Friend WithEvents SearchButton As Button
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents SupplierEmailTextBox As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents AltContactNoMaskedTextBox As MaskedTextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents ContactNoMaskedTextBox As MaskedTextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents ActiveStatusComboBox As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents ArchiveButton As Button
    Friend WithEvents SupplierBindingSource As BindingSource
    Friend WithEvents Group16DataSet As group16DataSet
    Friend WithEvents SupplierTableAdapter As group16DataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents TableAdapterManager As group16DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label4 As Label
    Friend WithEvents HelpBtn As Button
    Friend WithEvents SupplierManagerTip As ToolTip
    Friend WithEvents CustomerTableAdapter As group16DataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents EmployeeTableAdapter As group16DataSetTableAdapters.EmployeeTableAdapter
End Class

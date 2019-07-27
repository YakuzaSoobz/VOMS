<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerManager
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
        Me.OptionsGroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ArchiveButton = New System.Windows.Forms.Button()
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        Me.CreateButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.NavigationGroupBox = New System.Windows.Forms.GroupBox()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.SearchComboBox = New System.Windows.Forms.ComboBox()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.LastButton = New System.Windows.Forms.Button()
        Me.PreviousButton = New System.Windows.Forms.Button()
        Me.FirstButton = New System.Windows.Forms.Button()
        Me.LogOutButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.DetailsGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Group16DataSet = New M.I.S.S_Vendor_Order_Management_System.group16DataSet()
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
        Me.CustomerTableAdapter = New M.I.S.S_Vendor_Order_Management_System.group16DataSetTableAdapters.CustomerTableAdapter()
        Me.TableAdapterManager = New M.I.S.S_Vendor_Order_Management_System.group16DataSetTableAdapters.TableAdapterManager()
        Me.HelpBtn = New System.Windows.Forms.Button()
        Me.CustomerManagerTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.OptionsGroupBox1.SuspendLayout()
        Me.NavigationGroupBox.SuspendLayout()
        Me.DetailsGroupBox.SuspendLayout()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group16DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OptionsGroupBox1
        '
        Me.OptionsGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.OptionsGroupBox1.Controls.Add(Me.ArchiveButton)
        Me.OptionsGroupBox1.Controls.Add(Me.ButtonRefresh)
        Me.OptionsGroupBox1.Controls.Add(Me.CreateButton)
        Me.OptionsGroupBox1.Controls.Add(Me.UpdateButton)
        Me.OptionsGroupBox1.Location = New System.Drawing.Point(11, 453)
        Me.OptionsGroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.OptionsGroupBox1.Name = "OptionsGroupBox1"
        Me.OptionsGroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.OptionsGroupBox1.Size = New System.Drawing.Size(848, 59)
        Me.OptionsGroupBox1.TabIndex = 71
        Me.OptionsGroupBox1.TabStop = False
        Me.OptionsGroupBox1.Text = "OPTIONS"
        '
        'ArchiveButton
        '
        Me.ArchiveButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ArchiveButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ArchiveButton.FlatAppearance.BorderSize = 3
        Me.ArchiveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.ArchiveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.ArchiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ArchiveButton.Location = New System.Drawing.Point(31, 17)
        Me.ArchiveButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ArchiveButton.Name = "ArchiveButton"
        Me.ArchiveButton.Size = New System.Drawing.Size(172, 33)
        Me.ArchiveButton.TabIndex = 5
        Me.ArchiveButton.Text = "ARCHIVE CUSTOMER"
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
        Me.ButtonRefresh.Location = New System.Drawing.Point(683, 17)
        Me.ButtonRefresh.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(135, 33)
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
        Me.CreateButton.Location = New System.Drawing.Point(472, 17)
        Me.CreateButton.Margin = New System.Windows.Forms.Padding(2)
        Me.CreateButton.Name = "CreateButton"
        Me.CreateButton.Size = New System.Drawing.Size(157, 33)
        Me.CreateButton.TabIndex = 3
        Me.CreateButton.Text = "CREATE NEW CUSTOMER"
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
        Me.UpdateButton.Location = New System.Drawing.Point(256, 17)
        Me.UpdateButton.Margin = New System.Windows.Forms.Padding(2)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(165, 33)
        Me.UpdateButton.TabIndex = 1
        Me.UpdateButton.Text = "UPDATE/SAVE CUSTOMER"
        Me.UpdateButton.UseVisualStyleBackColor = False
        '
        'NavigationGroupBox
        '
        Me.NavigationGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.NavigationGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NavigationGroupBox.Controls.Add(Me.Label16)
        Me.NavigationGroupBox.Controls.Add(Me.Label15)
        Me.NavigationGroupBox.Controls.Add(Me.SearchButton)
        Me.NavigationGroupBox.Controls.Add(Me.SearchComboBox)
        Me.NavigationGroupBox.Controls.Add(Me.SearchTextBox)
        Me.NavigationGroupBox.Controls.Add(Me.NextButton)
        Me.NavigationGroupBox.Controls.Add(Me.LastButton)
        Me.NavigationGroupBox.Controls.Add(Me.PreviousButton)
        Me.NavigationGroupBox.Controls.Add(Me.FirstButton)
        Me.NavigationGroupBox.Location = New System.Drawing.Point(11, 11)
        Me.NavigationGroupBox.Margin = New System.Windows.Forms.Padding(2)
        Me.NavigationGroupBox.Name = "NavigationGroupBox"
        Me.NavigationGroupBox.Padding = New System.Windows.Forms.Padding(2)
        Me.NavigationGroupBox.Size = New System.Drawing.Size(848, 114)
        Me.NavigationGroupBox.TabIndex = 70
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
        Me.SearchButton.Location = New System.Drawing.Point(568, 18)
        Me.SearchButton.Margin = New System.Windows.Forms.Padding(2)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(100, 33)
        Me.SearchButton.TabIndex = 98
        Me.SearchButton.Text = "SEARCH"
        Me.SearchButton.UseVisualStyleBackColor = False
        '
        'SearchComboBox
        '
        Me.SearchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SearchComboBox.FormattingEnabled = True
        Me.SearchComboBox.Items.AddRange(New Object() {"Customer ID", "Customer Name", "Customer City"})
        Me.SearchComboBox.Location = New System.Drawing.Point(420, 24)
        Me.SearchComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.SearchComboBox.MaxDropDownItems = 100
        Me.SearchComboBox.Name = "SearchComboBox"
        Me.SearchComboBox.Size = New System.Drawing.Size(144, 21)
        Me.SearchComboBox.TabIndex = 97
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Location = New System.Drawing.Point(200, 25)
        Me.SearchTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(216, 20)
        Me.SearchTextBox.TabIndex = 96
        '
        'NextButton
        '
        Me.NextButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NextButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.NextButton.FlatAppearance.BorderSize = 3
        Me.NextButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.NextButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NextButton.Location = New System.Drawing.Point(322, 66)
        Me.NextButton.Margin = New System.Windows.Forms.Padding(2)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(101, 33)
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
        Me.LastButton.Location = New System.Drawing.Point(567, 66)
        Me.LastButton.Margin = New System.Windows.Forms.Padding(2)
        Me.LastButton.Name = "LastButton"
        Me.LastButton.Size = New System.Drawing.Size(101, 33)
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
        Me.PreviousButton.Location = New System.Drawing.Point(444, 66)
        Me.PreviousButton.Margin = New System.Windows.Forms.Padding(2)
        Me.PreviousButton.Name = "PreviousButton"
        Me.PreviousButton.Size = New System.Drawing.Size(101, 33)
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
        Me.FirstButton.Location = New System.Drawing.Point(200, 66)
        Me.FirstButton.Margin = New System.Windows.Forms.Padding(2)
        Me.FirstButton.Name = "FirstButton"
        Me.FirstButton.Size = New System.Drawing.Size(101, 33)
        Me.FirstButton.TabIndex = 34
        Me.FirstButton.Text = "FIRST"
        Me.FirstButton.UseVisualStyleBackColor = False
        '
        'LogOutButton
        '
        Me.LogOutButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogOutButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.LogOutButton.FlatAppearance.BorderSize = 3
        Me.LogOutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.LogOutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.LogOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogOutButton.Location = New System.Drawing.Point(11, 519)
        Me.LogOutButton.Margin = New System.Windows.Forms.Padding(2)
        Me.LogOutButton.Name = "LogOutButton"
        Me.LogOutButton.Size = New System.Drawing.Size(89, 36)
        Me.LogOutButton.TabIndex = 69
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
        Me.BackButton.Location = New System.Drawing.Point(795, 520)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(2)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(64, 36)
        Me.BackButton.TabIndex = 68
        Me.BackButton.Text = "BACK"
        Me.BackButton.UseVisualStyleBackColor = False
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
        Me.DetailsGroupBox.Location = New System.Drawing.Point(11, 129)
        Me.DetailsGroupBox.Margin = New System.Windows.Forms.Padding(2)
        Me.DetailsGroupBox.Name = "DetailsGroupBox"
        Me.DetailsGroupBox.Padding = New System.Windows.Forms.Padding(2)
        Me.DetailsGroupBox.Size = New System.Drawing.Size(848, 320)
        Me.DetailsGroupBox.TabIndex = 67
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
        Me.PasswordTextBox.Size = New System.Drawing.Size(162, 20)
        Me.PasswordTextBox.TabIndex = 81
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
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Customer_Quote_Line_ItemTableAdapter = Nothing
        Me.TableAdapterManager.Customer_QuoteTableAdapter = Nothing
        Me.TableAdapterManager.CustomerTableAdapter = Me.CustomerTableAdapter
        Me.TableAdapterManager.EmployeeTableAdapter = Nothing
        Me.TableAdapterManager.ProductTableAdapter = Nothing
        Me.TableAdapterManager.Supplier_Quote_Line_ItemTableAdapter = Nothing
        Me.TableAdapterManager.Supplier_QuoteTableAdapter = Nothing
        Me.TableAdapterManager.SupplierTableAdapter = Nothing
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
        Me.HelpBtn.Location = New System.Drawing.Point(393, 520)
        Me.HelpBtn.Name = "HelpBtn"
        Me.HelpBtn.Size = New System.Drawing.Size(79, 36)
        Me.HelpBtn.TabIndex = 134
        Me.HelpBtn.Text = "HELP"
        Me.HelpBtn.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(244, 10)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(129, 13)
        Me.Label15.TabIndex = 102
        Me.Label15.Text = "Enter text to be searched:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Location = New System.Drawing.Point(457, 10)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(76, 13)
        Me.Label16.TabIndex = 103
        Me.Label16.Text = "Search Criteria"
        '
        'CustomerManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.M.I.S.S_Vendor_Order_Management_System.My.Resources.Resources.Background1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(873, 566)
        Me.Controls.Add(Me.HelpBtn)
        Me.Controls.Add(Me.OptionsGroupBox1)
        Me.Controls.Add(Me.NavigationGroupBox)
        Me.Controls.Add(Me.LogOutButton)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.DetailsGroupBox)
        Me.DoubleBuffered = True
        Me.Name = "CustomerManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Manager"
        Me.OptionsGroupBox1.ResumeLayout(False)
        Me.NavigationGroupBox.ResumeLayout(False)
        Me.NavigationGroupBox.PerformLayout()
        Me.DetailsGroupBox.ResumeLayout(False)
        Me.DetailsGroupBox.PerformLayout()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group16DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents OptionsGroupBox1 As GroupBox
    Friend WithEvents ButtonRefresh As Button
    Friend WithEvents CreateButton As Button
    Friend WithEvents UpdateButton As Button
    Friend WithEvents NavigationGroupBox As GroupBox
    Friend WithEvents NextButton As Button
    Friend WithEvents LastButton As Button
    Friend WithEvents PreviousButton As Button
    Friend WithEvents FirstButton As Button
    Friend WithEvents LogOutButton As Button
    Friend WithEvents BackButton As Button
    Friend WithEvents DetailsGroupBox As GroupBox
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
    Friend WithEvents ActiveStatusComboBox As ComboBox
    Friend WithEvents CustomerIDTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents ArchiveButton As Button
    Friend WithEvents SearchButton As Button
    Friend WithEvents SearchComboBox As ComboBox
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents Group16DataSet As group16DataSet
    Friend WithEvents CustomerTableAdapter As group16DataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents TableAdapterManager As group16DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label5 As Label
    Friend WithEvents HelpBtn As Button
    Friend WithEvents CustomerManagerTip As ToolTip
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
End Class

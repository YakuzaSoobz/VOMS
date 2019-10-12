<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SignIn
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AccessCombo = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SignInButton = New System.Windows.Forms.Button()
        Me.ShowPasswordButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EmployeeIDTextbox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.AboutButton = New System.Windows.Forms.Button()
        Me.HelpBtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Normalisers42PictureBox = New System.Windows.Forms.PictureBox()
        Me.Group16DataSet = New M.I.S.S_Vendor_Order_Management_System.group16DataSet()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeTableAdapter = New M.I.S.S_Vendor_Order_Management_System.group16DataSetTableAdapters.EmployeeTableAdapter()
        Me.TableAdapterManager = New M.I.S.S_Vendor_Order_Management_System.group16DataSetTableAdapters.TableAdapterManager()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.HelpProvider2 = New System.Windows.Forms.HelpProvider()
        Me.AccessLevelTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Normalisers42PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group16DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.AccessLevelTextBox)
        Me.GroupBox1.Controls.Add(Me.AccessCombo)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.SignInButton)
        Me.GroupBox1.Controls.Add(Me.ShowPasswordButton)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.EmployeeIDTextbox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.PasswordTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(102, 155)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(432, 240)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "EMPLOYEE SIGN IN"
        '
        'AccessCombo
        '
        Me.AccessCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AccessCombo.FormattingEnabled = True
        Me.AccessCombo.Items.AddRange(New Object() {"2", "1"})
        Me.AccessCombo.Location = New System.Drawing.Point(87, 157)
        Me.AccessCombo.Name = "AccessCombo"
        Me.AccessCombo.Size = New System.Drawing.Size(56, 21)
        Me.AccessCombo.TabIndex = 42
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(84, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 13)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Select Access Level :"
        '
        'SignInButton
        '
        Me.SignInButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SignInButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.SignInButton.FlatAppearance.BorderSize = 3
        Me.SignInButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.SignInButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.SignInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SignInButton.Location = New System.Drawing.Point(203, 183)
        Me.SignInButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SignInButton.Name = "SignInButton"
        Me.SignInButton.Size = New System.Drawing.Size(64, 34)
        Me.SignInButton.TabIndex = 32
        Me.SignInButton.Text = "SIGN IN"
        Me.SignInButton.UseVisualStyleBackColor = False
        '
        'ShowPasswordButton
        '
        Me.ShowPasswordButton.BackColor = System.Drawing.Color.Transparent
        Me.ShowPasswordButton.BackgroundImage = Global.M.I.S.S_Vendor_Order_Management_System.My.Resources.Resources.purepng_com_eyeeyesorgans_of_the_visual_systemorganisms_visionoptical_systemlightfocuseslensclipart_1421526883251xkcin
        Me.ShowPasswordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ShowPasswordButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ShowPasswordButton.FlatAppearance.BorderSize = 0
        Me.ShowPasswordButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.ShowPasswordButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.ShowPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ShowPasswordButton.Location = New System.Drawing.Point(332, 97)
        Me.ShowPasswordButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ShowPasswordButton.Name = "ShowPasswordButton"
        Me.ShowPasswordButton.Size = New System.Drawing.Size(31, 24)
        Me.ShowPasswordButton.TabIndex = 22
        Me.ShowPasswordButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(84, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee Email:"
        '
        'EmployeeIDTextbox
        '
        Me.EmployeeIDTextbox.Location = New System.Drawing.Point(87, 45)
        Me.EmployeeIDTextbox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.EmployeeIDTextbox.Name = "EmployeeIDTextbox"
        Me.EmployeeIDTextbox.Size = New System.Drawing.Size(241, 20)
        Me.EmployeeIDTextbox.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(84, 85)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password :"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(87, 100)
        Me.PasswordTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PasswordTextBox.MaxLength = 10
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(241, 20)
        Me.PasswordTextBox.TabIndex = 20
        '
        'AboutButton
        '
        Me.AboutButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AboutButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.AboutButton.FlatAppearance.BorderSize = 3
        Me.AboutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.AboutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AboutButton.Location = New System.Drawing.Point(9, 431)
        Me.AboutButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AboutButton.Name = "AboutButton"
        Me.AboutButton.Size = New System.Drawing.Size(79, 33)
        Me.AboutButton.TabIndex = 34
        Me.AboutButton.Text = "ABOUT"
        Me.AboutButton.UseVisualStyleBackColor = False
        '
        'HelpBtn
        '
        Me.HelpBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HelpBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.HelpBtn.FlatAppearance.BorderSize = 3
        Me.HelpBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.HelpBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.HelpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HelpBtn.Location = New System.Drawing.Point(555, 431)
        Me.HelpBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.HelpBtn.Name = "HelpBtn"
        Me.HelpBtn.Size = New System.Drawing.Size(79, 33)
        Me.HelpBtn.TabIndex = 35
        Me.HelpBtn.Text = "HELP"
        Me.HelpBtn.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(62, 22)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(509, 29)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Mhlathuze Industrial Suppliers and Services cc"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(190, 132)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(257, 21)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Vendor Order Management System"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.M.I.S.S_Vendor_Order_Management_System.My.Resources.Resources.M_I_S_S_Logo
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(266, 57)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(103, 72)
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(174, 428)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(201, 19)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Developed by Normalisers42"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Normalisers42PictureBox
        '
        Me.Normalisers42PictureBox.BackgroundImage = Global.M.I.S.S_Vendor_Order_Management_System.My.Resources.Resources.Normalisers42_Logo
        Me.Normalisers42PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Normalisers42PictureBox.Location = New System.Drawing.Point(380, 411)
        Me.Normalisers42PictureBox.Name = "Normalisers42PictureBox"
        Me.Normalisers42PictureBox.Size = New System.Drawing.Size(50, 50)
        Me.Normalisers42PictureBox.TabIndex = 40
        Me.Normalisers42PictureBox.TabStop = False
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Customer_Quote_Line_ItemTableAdapter = Nothing
        Me.TableAdapterManager.Customer_QuoteTableAdapter = Nothing
        Me.TableAdapterManager.CustomerTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeTableAdapter = Me.EmployeeTableAdapter
        Me.TableAdapterManager.ProductTableAdapter = Nothing
        Me.TableAdapterManager.Supplier_Quote_Line_ItemTableAdapter = Nothing
        Me.TableAdapterManager.Supplier_QuoteTableAdapter = Nothing
        Me.TableAdapterManager.SupplierTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = M.I.S.S_Vendor_Order_Management_System.group16DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\Users\pravz\Desktop\GitFolder\VOMS\M.I.S.chm"
        '
        'HelpProvider2
        '
        Me.HelpProvider2.HelpNamespace = "C:\Users\munis\Documents\GitHub Normalisers42\VOMS\VOMSHelpFinal.chm"
        '
        'AccessLevelTextBox
        '
        Me.AccessLevelTextBox.Location = New System.Drawing.Point(149, 157)
        Me.AccessLevelTextBox.Name = "AccessLevelTextBox"
        Me.AccessLevelTextBox.Size = New System.Drawing.Size(179, 20)
        Me.AccessLevelTextBox.TabIndex = 43
        '
        'SignIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = Global.M.I.S.S_Vendor_Order_Management_System.My.Resources.Resources.Background1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(643, 473)
        Me.Controls.Add(Me.Normalisers42PictureBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.HelpBtn)
        Me.Controls.Add(Me.AboutButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Name = "SignIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "M.I.S.S Vendor Order Managment System"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Normalisers42PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group16DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SignInButton As Button
    Friend WithEvents ShowPasswordButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents EmployeeIDTextbox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents AboutButton As Button
    Friend WithEvents HelpBtn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Normalisers42PictureBox As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents AccessCombo As ComboBox
    Friend WithEvents Group16DataSet As group16DataSet
    Friend WithEvents EmployeeBindingSource As BindingSource
    Friend WithEvents EmployeeTableAdapter As group16DataSetTableAdapters.EmployeeTableAdapter
    Friend WithEvents TableAdapterManager As group16DataSetTableAdapters.TableAdapterManager
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents HelpProvider2 As HelpProvider
    Friend WithEvents AccessLevelTextBox As TextBox
End Class

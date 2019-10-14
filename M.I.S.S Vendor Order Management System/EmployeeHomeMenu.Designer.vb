<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeHomeMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmployeeHomeMenu))
        Me.SignOutButton = New System.Windows.Forms.Button()
        Me.MenuGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SupplierQuoteManagerButton = New System.Windows.Forms.Button()
        Me.CustomerQuoteManagerButton = New System.Windows.Forms.Button()
        Me.ProductManagerButton = New System.Windows.Forms.Button()
        Me.CustomerManagerButton = New System.Windows.Forms.Button()
        Me.SupplierManagerButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'SignOutButton
        '
        Me.SignOutButton.BackColor = System.Drawing.Color.Transparent
        Me.SignOutButton.BackgroundImage = Global.M.I.S.S_Vendor_Order_Management_System.My.Resources.Resources.Sign_out
        Me.SignOutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.SignOutButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SignOutButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.SignOutButton.FlatAppearance.BorderSize = 0
        Me.SignOutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.SignOutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.SignOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SignOutButton.Location = New System.Drawing.Point(654, 742)
        Me.SignOutButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SignOutButton.Name = "SignOutButton"
        Me.SignOutButton.Size = New System.Drawing.Size(70, 47)
        Me.SignOutButton.TabIndex = 43
        Me.SignOutButton.UseVisualStyleBackColor = False
        '
        'MenuGroupBox
        '
        Me.MenuGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.MenuGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuGroupBox.Controls.Add(Me.Label4)
        Me.MenuGroupBox.Controls.Add(Me.Label5)
        Me.MenuGroupBox.Controls.Add(Me.Label6)
        Me.MenuGroupBox.Controls.Add(Me.Label7)
        Me.MenuGroupBox.Controls.Add(Me.Label1)
        Me.MenuGroupBox.Controls.Add(Me.SupplierQuoteManagerButton)
        Me.MenuGroupBox.Controls.Add(Me.CustomerQuoteManagerButton)
        Me.MenuGroupBox.Controls.Add(Me.ProductManagerButton)
        Me.MenuGroupBox.Controls.Add(Me.CustomerManagerButton)
        Me.MenuGroupBox.Controls.Add(Me.SupplierManagerButton)
        Me.MenuGroupBox.Location = New System.Drawing.Point(35, 62)
        Me.MenuGroupBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MenuGroupBox.Name = "MenuGroupBox"
        Me.MenuGroupBox.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MenuGroupBox.Size = New System.Drawing.Size(664, 668)
        Me.MenuGroupBox.TabIndex = 42
        Me.MenuGroupBox.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(180, 617)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(175, 17)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "CUSTOMER MANAGER"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(336, 417)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 17)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "SUPPLIER MANAGER"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(32, 417)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(164, 17)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "PRODUCT MANAGER"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(336, 215)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(224, 17)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "SUPPLIER QUOTE MANAGER"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 215)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "CUSTOMER QUOTE MANAGER"
        '
        'SupplierQuoteManagerButton
        '
        Me.SupplierQuoteManagerButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SupplierQuoteManagerButton.BackgroundImage = CType(resources.GetObject("SupplierQuoteManagerButton.BackgroundImage"), System.Drawing.Image)
        Me.SupplierQuoteManagerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.SupplierQuoteManagerButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SupplierQuoteManagerButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.SupplierQuoteManagerButton.FlatAppearance.BorderSize = 4
        Me.SupplierQuoteManagerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.SupplierQuoteManagerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.SupplierQuoteManagerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SupplierQuoteManagerButton.Location = New System.Drawing.Point(339, 53)
        Me.SupplierQuoteManagerButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SupplierQuoteManagerButton.Name = "SupplierQuoteManagerButton"
        Me.SupplierQuoteManagerButton.Size = New System.Drawing.Size(289, 160)
        Me.SupplierQuoteManagerButton.TabIndex = 7
        Me.SupplierQuoteManagerButton.UseVisualStyleBackColor = False
        '
        'CustomerQuoteManagerButton
        '
        Me.CustomerQuoteManagerButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CustomerQuoteManagerButton.BackgroundImage = CType(resources.GetObject("CustomerQuoteManagerButton.BackgroundImage"), System.Drawing.Image)
        Me.CustomerQuoteManagerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CustomerQuoteManagerButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CustomerQuoteManagerButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.CustomerQuoteManagerButton.FlatAppearance.BorderSize = 4
        Me.CustomerQuoteManagerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.CustomerQuoteManagerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.CustomerQuoteManagerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CustomerQuoteManagerButton.Location = New System.Drawing.Point(35, 53)
        Me.CustomerQuoteManagerButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CustomerQuoteManagerButton.Name = "CustomerQuoteManagerButton"
        Me.CustomerQuoteManagerButton.Size = New System.Drawing.Size(289, 160)
        Me.CustomerQuoteManagerButton.TabIndex = 3
        Me.CustomerQuoteManagerButton.UseVisualStyleBackColor = False
        '
        'ProductManagerButton
        '
        Me.ProductManagerButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ProductManagerButton.BackgroundImage = CType(resources.GetObject("ProductManagerButton.BackgroundImage"), System.Drawing.Image)
        Me.ProductManagerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ProductManagerButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ProductManagerButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ProductManagerButton.FlatAppearance.BorderSize = 4
        Me.ProductManagerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.ProductManagerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.ProductManagerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ProductManagerButton.Location = New System.Drawing.Point(35, 255)
        Me.ProductManagerButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ProductManagerButton.Name = "ProductManagerButton"
        Me.ProductManagerButton.Size = New System.Drawing.Size(289, 160)
        Me.ProductManagerButton.TabIndex = 4
        Me.ProductManagerButton.UseVisualStyleBackColor = False
        '
        'CustomerManagerButton
        '
        Me.CustomerManagerButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CustomerManagerButton.BackgroundImage = CType(resources.GetObject("CustomerManagerButton.BackgroundImage"), System.Drawing.Image)
        Me.CustomerManagerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CustomerManagerButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CustomerManagerButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.CustomerManagerButton.FlatAppearance.BorderSize = 4
        Me.CustomerManagerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.CustomerManagerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.CustomerManagerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CustomerManagerButton.Location = New System.Drawing.Point(184, 454)
        Me.CustomerManagerButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CustomerManagerButton.Name = "CustomerManagerButton"
        Me.CustomerManagerButton.Size = New System.Drawing.Size(289, 160)
        Me.CustomerManagerButton.TabIndex = 6
        Me.CustomerManagerButton.UseVisualStyleBackColor = False
        '
        'SupplierManagerButton
        '
        Me.SupplierManagerButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SupplierManagerButton.BackgroundImage = CType(resources.GetObject("SupplierManagerButton.BackgroundImage"), System.Drawing.Image)
        Me.SupplierManagerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.SupplierManagerButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SupplierManagerButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.SupplierManagerButton.FlatAppearance.BorderSize = 4
        Me.SupplierManagerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.SupplierManagerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.SupplierManagerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SupplierManagerButton.Location = New System.Drawing.Point(339, 255)
        Me.SupplierManagerButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SupplierManagerButton.Name = "SupplierManagerButton"
        Me.SupplierManagerButton.Size = New System.Drawing.Size(289, 160)
        Me.SupplierManagerButton.TabIndex = 5
        Me.SupplierManagerButton.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(163, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(390, 36)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "EMPLOYEE HOME MENU"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'EmployeeHomeMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackgroundImage = Global.M.I.S.S_Vendor_Order_Management_System.My.Resources.Resources.Background1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(736, 800)
        Me.Controls.Add(Me.SignOutButton)
        Me.Controls.Add(Me.MenuGroupBox)
        Me.Controls.Add(Me.Label3)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "EmployeeHomeMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Home Menu"
        Me.MenuGroupBox.ResumeLayout(False)
        Me.MenuGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SignOutButton As Button
    Friend WithEvents MenuGroupBox As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SupplierQuoteManagerButton As Button
    Friend WithEvents CustomerQuoteManagerButton As Button
    Friend WithEvents ProductManagerButton As Button
    Friend WithEvents CustomerManagerButton As Button
    Friend WithEvents SupplierManagerButton As Button
    Friend WithEvents Label3 As Label
End Class

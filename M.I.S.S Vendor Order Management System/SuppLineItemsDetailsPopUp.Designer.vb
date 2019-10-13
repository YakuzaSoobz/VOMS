<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SuppLineItemsDetailsPopUp
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
        Me.OptionsGroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.QuoteDetailsGroupBox = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.QuantityComboBox = New System.Windows.Forms.ComboBox()
        Me.ProductIDTextBox = New System.Windows.Forms.TextBox()
        Me.CostPriceTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OptionsGroupBox1.SuspendLayout()
        Me.QuoteDetailsGroupBox.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'OptionsGroupBox1
        '
        Me.OptionsGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.OptionsGroupBox1.Controls.Add(Me.SaveButton)
        Me.OptionsGroupBox1.Location = New System.Drawing.Point(18, 167)
        Me.OptionsGroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.OptionsGroupBox1.Name = "OptionsGroupBox1"
        Me.OptionsGroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.OptionsGroupBox1.Size = New System.Drawing.Size(278, 87)
        Me.OptionsGroupBox1.TabIndex = 93
        Me.OptionsGroupBox1.TabStop = False
        Me.OptionsGroupBox1.Text = "OPTIONS"
        '
        'SaveButton
        '
        Me.SaveButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SaveButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.SaveButton.FlatAppearance.BorderSize = 3
        Me.SaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.SaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveButton.Location = New System.Drawing.Point(40, 17)
        Me.SaveButton.Margin = New System.Windows.Forms.Padding(2)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(196, 53)
        Me.SaveButton.TabIndex = 1
        Me.SaveButton.Text = "SAVE"
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BackButton.FlatAppearance.BorderSize = 3
        Me.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.BackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Location = New System.Drawing.Point(244, 282)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(2)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(79, 33)
        Me.BackButton.TabIndex = 94
        Me.BackButton.Text = "CLOSE"
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'QuoteDetailsGroupBox
        '
        Me.QuoteDetailsGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.QuoteDetailsGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.QuoteDetailsGroupBox.Controls.Add(Me.OptionsGroupBox1)
        Me.QuoteDetailsGroupBox.Controls.Add(Me.GroupBox2)
        Me.QuoteDetailsGroupBox.Location = New System.Drawing.Point(11, 11)
        Me.QuoteDetailsGroupBox.Margin = New System.Windows.Forms.Padding(2)
        Me.QuoteDetailsGroupBox.Name = "QuoteDetailsGroupBox"
        Me.QuoteDetailsGroupBox.Padding = New System.Windows.Forms.Padding(2)
        Me.QuoteDetailsGroupBox.Size = New System.Drawing.Size(312, 267)
        Me.QuoteDetailsGroupBox.TabIndex = 92
        Me.QuoteDetailsGroupBox.TabStop = False
        Me.QuoteDetailsGroupBox.Text = "CUSTOMER QUOTE DETAILS"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.QuantityComboBox)
        Me.GroupBox2.Controls.Add(Me.ProductIDTextBox)
        Me.GroupBox2.Controls.Add(Me.CostPriceTextBox)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 17)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(278, 146)
        Me.GroupBox2.TabIndex = 84
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SUPPLIER ITEM DETAILS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(14, 110)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 86
        Me.Label3.Text = "- Selected Quanity:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(15, 28)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 13)
        Me.Label9.TabIndex = 89
        Me.Label9.Text = "- Product ID:"
        '
        'QuantityComboBox
        '
        Me.QuantityComboBox.FormattingEnabled = True
        Me.QuantityComboBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.QuantityComboBox.Location = New System.Drawing.Point(128, 107)
        Me.QuantityComboBox.Name = "QuantityComboBox"
        Me.QuantityComboBox.Size = New System.Drawing.Size(124, 21)
        Me.QuantityComboBox.TabIndex = 85
        '
        'ProductIDTextBox
        '
        Me.ProductIDTextBox.Location = New System.Drawing.Point(128, 25)
        Me.ProductIDTextBox.Name = "ProductIDTextBox"
        Me.ProductIDTextBox.ReadOnly = True
        Me.ProductIDTextBox.Size = New System.Drawing.Size(124, 20)
        Me.ProductIDTextBox.TabIndex = 88
        Me.ProductIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CostPriceTextBox
        '
        Me.CostPriceTextBox.Location = New System.Drawing.Point(128, 66)
        Me.CostPriceTextBox.Name = "CostPriceTextBox"
        Me.CostPriceTextBox.Size = New System.Drawing.Size(124, 20)
        Me.CostPriceTextBox.TabIndex = 84
        Me.CostPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(15, 69)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 85
        Me.Label2.Text = "- Cost Price:"
        '
        'SuppLineItemsDetailsPopUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = Global.M.I.S.S_Vendor_Order_Management_System.My.Resources.Resources.Background1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(334, 325)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.QuoteDetailsGroupBox)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "SuppLineItemsDetailsPopUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item Details"
        Me.OptionsGroupBox1.ResumeLayout(False)
        Me.QuoteDetailsGroupBox.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OptionsGroupBox1 As GroupBox
    Friend WithEvents SaveButton As Button
    Friend WithEvents BackButton As Button
    Friend WithEvents QuoteDetailsGroupBox As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents QuantityComboBox As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ProductIDTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CostPriceTextBox As TextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SortManagerPopUp
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
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ToDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FromDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.QuotesBetween = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AscendingOrderButton = New System.Windows.Forms.Button()
        Me.DescendingOrderButton = New System.Windows.Forms.Button()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.ToDateTimePicker)
        Me.GroupBox5.Controls.Add(Me.FromDateTimePicker)
        Me.GroupBox5.Controls.Add(Me.QuotesBetween)
        Me.GroupBox5.Location = New System.Drawing.Point(19, 16)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox5.Size = New System.Drawing.Size(668, 82)
        Me.GroupBox5.TabIndex = 36
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "SHOW QUOTES BETWEEN DATES:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(525, 26)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 13)
        Me.Label10.TabIndex = 58
        Me.Label10.Text = "End:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(96, 25)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "Start:"
        '
        'ToDateTimePicker
        '
        Me.ToDateTimePicker.Location = New System.Drawing.Point(449, 43)
        Me.ToDateTimePicker.Name = "ToDateTimePicker"
        Me.ToDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.ToDateTimePicker.TabIndex = 56
        '
        'FromDateTimePicker
        '
        Me.FromDateTimePicker.Location = New System.Drawing.Point(16, 43)
        Me.FromDateTimePicker.Name = "FromDateTimePicker"
        Me.FromDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FromDateTimePicker.TabIndex = 55
        '
        'QuotesBetween
        '
        Me.QuotesBetween.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.QuotesBetween.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.QuotesBetween.FlatAppearance.BorderSize = 3
        Me.QuotesBetween.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.QuotesBetween.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.QuotesBetween.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.QuotesBetween.Location = New System.Drawing.Point(264, 27)
        Me.QuotesBetween.Margin = New System.Windows.Forms.Padding(2)
        Me.QuotesBetween.Name = "QuotesBetween"
        Me.QuotesBetween.Size = New System.Drawing.Size(140, 36)
        Me.QuotesBetween.TabIndex = 27
        Me.QuotesBetween.Text = "QUOTES BETWEEN"
        Me.QuotesBetween.UseVisualStyleBackColor = False
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BackButton.FlatAppearance.BorderSize = 3
        Me.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.BackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Location = New System.Drawing.Point(623, 188)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(2)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(64, 36)
        Me.BackButton.TabIndex = 33
        Me.BackButton.Text = "BACK"
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.AscendingOrderButton)
        Me.GroupBox1.Controls.Add(Me.DescendingOrderButton)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 102)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(668, 75)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ORDER BY DATE:"
        '
        'AscendingOrderButton
        '
        Me.AscendingOrderButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AscendingOrderButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.AscendingOrderButton.FlatAppearance.BorderSize = 3
        Me.AscendingOrderButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.AscendingOrderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.AscendingOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AscendingOrderButton.Location = New System.Drawing.Point(349, 26)
        Me.AscendingOrderButton.Margin = New System.Windows.Forms.Padding(2)
        Me.AscendingOrderButton.Name = "AscendingOrderButton"
        Me.AscendingOrderButton.Size = New System.Drawing.Size(236, 36)
        Me.AscendingOrderButton.TabIndex = 29
        Me.AscendingOrderButton.Text = "ASCENDING ORDER"
        Me.AscendingOrderButton.UseVisualStyleBackColor = False
        '
        'DescendingOrderButton
        '
        Me.DescendingOrderButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DescendingOrderButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.DescendingOrderButton.FlatAppearance.BorderSize = 3
        Me.DescendingOrderButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.DescendingOrderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.DescendingOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DescendingOrderButton.Location = New System.Drawing.Point(76, 26)
        Me.DescendingOrderButton.Margin = New System.Windows.Forms.Padding(2)
        Me.DescendingOrderButton.Name = "DescendingOrderButton"
        Me.DescendingOrderButton.Size = New System.Drawing.Size(236, 36)
        Me.DescendingOrderButton.TabIndex = 28
        Me.DescendingOrderButton.Text = "DESCENDING ORDER"
        Me.DescendingOrderButton.UseVisualStyleBackColor = False
        '
        'SortManagerPopUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.M.I.S.S_Vendor_Order_Management_System.My.Resources.Resources.Background1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(698, 237)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.BackButton)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "SortManagerPopUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Sort Options"
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ToDateTimePicker As DateTimePicker
    Friend WithEvents FromDateTimePicker As DateTimePicker
    Friend WithEvents QuotesBetween As Button
    Friend WithEvents BackButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents AscendingOrderButton As Button
    Friend WithEvents DescendingOrderButton As Button
End Class

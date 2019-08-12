<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportMenu
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
        Me.ReportComboBox = New System.Windows.Forms.ComboBox()
        Me.ReportDesc = New System.Windows.Forms.TextBox()
        Me.ReportTitle = New System.Windows.Forms.Label()
        Me.ReportDescLbl = New System.Windows.Forms.Label()
        Me.ReportButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ReportComboBox
        '
        Me.ReportComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ReportComboBox.FormattingEnabled = True
        Me.ReportComboBox.Items.AddRange(New Object() {"Acceptance Time Report", "Employee Sales per Product", "Total Product Sales", "Total Value of Sales per Item for Select Months", "Total Supplier Cost per Supplier", "Total Sales per Suburb"})
        Me.ReportComboBox.Location = New System.Drawing.Point(50, 42)
        Me.ReportComboBox.Name = "ReportComboBox"
        Me.ReportComboBox.Size = New System.Drawing.Size(397, 21)
        Me.ReportComboBox.TabIndex = 0
        '
        'ReportDesc
        '
        Me.ReportDesc.Location = New System.Drawing.Point(50, 111)
        Me.ReportDesc.Multiline = True
        Me.ReportDesc.Name = "ReportDesc"
        Me.ReportDesc.ReadOnly = True
        Me.ReportDesc.Size = New System.Drawing.Size(397, 131)
        Me.ReportDesc.TabIndex = 1
        '
        'ReportTitle
        '
        Me.ReportTitle.AutoSize = True
        Me.ReportTitle.BackColor = System.Drawing.Color.Transparent
        Me.ReportTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportTitle.Location = New System.Drawing.Point(47, 21)
        Me.ReportTitle.Name = "ReportTitle"
        Me.ReportTitle.Size = New System.Drawing.Size(57, 18)
        Me.ReportTitle.TabIndex = 2
        Me.ReportTitle.Text = "Report:"
        '
        'ReportDescLbl
        '
        Me.ReportDescLbl.AutoSize = True
        Me.ReportDescLbl.BackColor = System.Drawing.Color.Transparent
        Me.ReportDescLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportDescLbl.Location = New System.Drawing.Point(47, 90)
        Me.ReportDescLbl.Name = "ReportDescLbl"
        Me.ReportDescLbl.Size = New System.Drawing.Size(136, 18)
        Me.ReportDescLbl.TabIndex = 3
        Me.ReportDescLbl.Text = "Report Description:"
        '
        'ReportButton
        '
        Me.ReportButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportButton.Location = New System.Drawing.Point(174, 271)
        Me.ReportButton.Name = "ReportButton"
        Me.ReportButton.Size = New System.Drawing.Size(152, 40)
        Me.ReportButton.TabIndex = 4
        Me.ReportButton.Text = "View Report"
        Me.ReportButton.UseVisualStyleBackColor = True
        '
        'ReportMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.M.I.S.S_Vendor_Order_Management_System.My.Resources.Resources.Background1
        Me.ClientSize = New System.Drawing.Size(504, 334)
        Me.Controls.Add(Me.ReportButton)
        Me.Controls.Add(Me.ReportDescLbl)
        Me.Controls.Add(Me.ReportTitle)
        Me.Controls.Add(Me.ReportDesc)
        Me.Controls.Add(Me.ReportComboBox)
        Me.Name = "ReportMenu"
        Me.Text = "ReportMenu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportComboBox As ComboBox
    Friend WithEvents ReportDesc As TextBox
    Friend WithEvents ReportTitle As Label
    Friend WithEvents ReportDescLbl As Label
    Friend WithEvents ReportButton As Button
End Class

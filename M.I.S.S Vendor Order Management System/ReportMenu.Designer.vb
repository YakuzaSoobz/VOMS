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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ReportComboBox = New System.Windows.Forms.ComboBox()
        Me.ReportDesc = New System.Windows.Forms.TextBox()
        Me.ViewReportButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Report:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Report Description:"
        '
        'ReportComboBox
        '
        Me.ReportComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ReportComboBox.FormattingEnabled = True
        Me.ReportComboBox.Items.AddRange(New Object() {"Acceptance Time Report", "Employee Sales per Product", "Total Product Sales", "Total Value of Sales per Item for Select Months", "Total Supplier Cost per Supplier", "Total Sales per Suburb", "Amount of Products Sold per Employee Last Year", "Amount of Products Sold per Month for Last Year", "Quotations Per Month", "Customer Income"})
        Me.ReportComboBox.Location = New System.Drawing.Point(59, 51)
        Me.ReportComboBox.Name = "ReportComboBox"
        Me.ReportComboBox.Size = New System.Drawing.Size(384, 21)
        Me.ReportComboBox.TabIndex = 2
        '
        'ReportDesc
        '
        Me.ReportDesc.Location = New System.Drawing.Point(59, 130)
        Me.ReportDesc.Multiline = True
        Me.ReportDesc.Name = "ReportDesc"
        Me.ReportDesc.ReadOnly = True
        Me.ReportDesc.Size = New System.Drawing.Size(384, 137)
        Me.ReportDesc.TabIndex = 3
        '
        'ViewReportButton
        '
        Me.ViewReportButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ViewReportButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ViewReportButton.FlatAppearance.BorderSize = 3
        Me.ViewReportButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.ViewReportButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.ViewReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ViewReportButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewReportButton.Location = New System.Drawing.Point(176, 292)
        Me.ViewReportButton.Name = "ViewReportButton"
        Me.ViewReportButton.Size = New System.Drawing.Size(156, 41)
        Me.ViewReportButton.TabIndex = 4
        Me.ViewReportButton.Text = "View Report"
        Me.ViewReportButton.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.BorderSize = 3
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(418, 298)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 33)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ReportMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.M.I.S.S_Vendor_Order_Management_System.My.Resources.Resources.Background1
        Me.ClientSize = New System.Drawing.Size(506, 342)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ViewReportButton)
        Me.Controls.Add(Me.ReportDesc)
        Me.Controls.Add(Me.ReportComboBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ReportMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReportMenu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ReportComboBox As ComboBox
    Friend WithEvents ReportDesc As TextBox
    Friend WithEvents ViewReportButton As Button
    Friend WithEvents Button1 As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServiceAvailability
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
        Me.cbServiceDuration = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbServiceType = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbServices = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtSlots = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbServiceDuration
        '
        Me.cbServiceDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbServiceDuration.FormattingEnabled = True
        Me.cbServiceDuration.Location = New System.Drawing.Point(142, 88)
        Me.cbServiceDuration.Name = "cbServiceDuration"
        Me.cbServiceDuration.Size = New System.Drawing.Size(200, 21)
        Me.cbServiceDuration.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(67, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Duration"
        '
        'cbServiceType
        '
        Me.cbServiceType.DisplayMember = "TypeName"
        Me.cbServiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbServiceType.FormattingEnabled = True
        Me.cbServiceType.Location = New System.Drawing.Point(142, 61)
        Me.cbServiceType.Name = "cbServiceType"
        Me.cbServiceType.Size = New System.Drawing.Size(200, 21)
        Me.cbServiceType.TabIndex = 15
        Me.cbServiceType.Tag = "Cost"
        Me.cbServiceType.ValueMember = "TypeID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(67, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(67, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Service"
        '
        'cbServices
        '
        Me.cbServices.DisplayMember = "ServiceName"
        Me.cbServices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbServices.FormattingEnabled = True
        Me.cbServices.Location = New System.Drawing.Point(142, 34)
        Me.cbServices.Name = "cbServices"
        Me.cbServices.Size = New System.Drawing.Size(200, 21)
        Me.cbServices.TabIndex = 13
        Me.cbServices.ValueMember = "ServiceID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(143, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "in next"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(187, 116)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(78, 20)
        Me.NumericUpDown1.TabIndex = 20
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(271, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "days"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(142, 142)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Check"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtSlots
        '
        Me.txtSlots.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtSlots.Location = New System.Drawing.Point(0, 207)
        Me.txtSlots.Name = "txtSlots"
        Me.txtSlots.Size = New System.Drawing.Size(408, 194)
        Me.txtSlots.TabIndex = 24
        Me.txtSlots.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(0, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(273, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "All slots other than following are available for reservation:"
        Me.Label5.Visible = False
        '
        'frmServiceAvailability
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 401)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSlots)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbServiceDuration)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbServiceType)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbServices)
        Me.Name = "frmServiceAvailability"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Service Availability"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbServiceDuration As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbServiceType As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbServices As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtSlots As System.Windows.Forms.RichTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class

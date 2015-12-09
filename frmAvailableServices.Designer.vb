<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAvailableServices
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
        Me.cbStartMinutes = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbStartHrs = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.txtAvailableServices = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'cbStartMinutes
        '
        Me.cbStartMinutes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStartMinutes.FormattingEnabled = True
        Me.cbStartMinutes.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"})
        Me.cbStartMinutes.Location = New System.Drawing.Point(157, 47)
        Me.cbStartMinutes.Name = "cbStartMinutes"
        Me.cbStartMinutes.Size = New System.Drawing.Size(53, 21)
        Me.cbStartMinutes.TabIndex = 16
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(98, 23)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Date"
        '
        'cbStartHrs
        '
        Me.cbStartHrs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStartHrs.FormattingEnabled = True
        Me.cbStartHrs.Items.AddRange(New Object() {"08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.cbStartHrs.Location = New System.Drawing.Point(98, 47)
        Me.cbStartHrs.Name = "cbStartHrs"
        Me.cbStartHrs.Size = New System.Drawing.Size(53, 21)
        Me.cbStartHrs.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Time"
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(98, 74)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(75, 23)
        Me.btnCheck.TabIndex = 17
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'txtAvailableServices
        '
        Me.txtAvailableServices.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtAvailableServices.Location = New System.Drawing.Point(0, 114)
        Me.txtAvailableServices.Name = "txtAvailableServices"
        Me.txtAvailableServices.Size = New System.Drawing.Size(410, 168)
        Me.txtAvailableServices.TabIndex = 18
        Me.txtAvailableServices.Text = ""
        '
        'frmAvailableServices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 282)
        Me.Controls.Add(Me.txtAvailableServices)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.cbStartMinutes)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbStartHrs)
        Me.Controls.Add(Me.Label5)
        Me.Name = "frmAvailableServices"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Available Services"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbStartMinutes As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbStartHrs As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnCheck As System.Windows.Forms.Button
    Friend WithEvents txtAvailableServices As System.Windows.Forms.RichTextBox
End Class

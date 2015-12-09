<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOperations
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
        Me.btnAddGuest = New System.Windows.Forms.Button()
        Me.btnNewAppointment = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnAvailableServices = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAddGuest
        '
        Me.btnAddGuest.Location = New System.Drawing.Point(79, 55)
        Me.btnAddGuest.Name = "btnAddGuest"
        Me.btnAddGuest.Size = New System.Drawing.Size(113, 23)
        Me.btnAddGuest.TabIndex = 0
        Me.btnAddGuest.Text = "Add Guest"
        Me.btnAddGuest.UseVisualStyleBackColor = True
        '
        'btnNewAppointment
        '
        Me.btnNewAppointment.Location = New System.Drawing.Point(79, 84)
        Me.btnNewAppointment.Name = "btnNewAppointment"
        Me.btnNewAppointment.Size = New System.Drawing.Size(113, 23)
        Me.btnNewAppointment.TabIndex = 1
        Me.btnNewAppointment.Text = "New Appointment"
        Me.btnNewAppointment.UseVisualStyleBackColor = True
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(79, 113)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(113, 23)
        Me.btnView.TabIndex = 2
        Me.btnView.Text = "View Appointments"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'btnAvailableServices
        '
        Me.btnAvailableServices.Location = New System.Drawing.Point(79, 142)
        Me.btnAvailableServices.Name = "btnAvailableServices"
        Me.btnAvailableServices.Size = New System.Drawing.Size(113, 23)
        Me.btnAvailableServices.TabIndex = 3
        Me.btnAvailableServices.Text = "Available Services"
        Me.btnAvailableServices.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(79, 171)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Service Availability"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmOperations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnAvailableServices)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnNewAppointment)
        Me.Controls.Add(Me.btnAddGuest)
        Me.Name = "frmOperations"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Operations"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAddGuest As System.Windows.Forms.Button
    Friend WithEvents btnNewAppointment As System.Windows.Forms.Button
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents btnAvailableServices As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaintenance
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
        Me.btnAddService = New System.Windows.Forms.Button()
        Me.btnAddServiceType = New System.Windows.Forms.Button()
        Me.btnUpdateService = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAddService
        '
        Me.btnAddService.Location = New System.Drawing.Point(135, 22)
        Me.btnAddService.Name = "btnAddService"
        Me.btnAddService.Size = New System.Drawing.Size(123, 23)
        Me.btnAddService.TabIndex = 0
        Me.btnAddService.Text = "Add Services"
        Me.btnAddService.UseVisualStyleBackColor = True
        '
        'btnAddServiceType
        '
        Me.btnAddServiceType.Location = New System.Drawing.Point(264, 22)
        Me.btnAddServiceType.Name = "btnAddServiceType"
        Me.btnAddServiceType.Size = New System.Drawing.Size(125, 23)
        Me.btnAddServiceType.TabIndex = 1
        Me.btnAddServiceType.Text = "Add Service Types"
        Me.btnAddServiceType.UseVisualStyleBackColor = True
        '
        'btnUpdateService
        '
        Me.btnUpdateService.Location = New System.Drawing.Point(135, 51)
        Me.btnUpdateService.Name = "btnUpdateService"
        Me.btnUpdateService.Size = New System.Drawing.Size(123, 23)
        Me.btnUpdateService.TabIndex = 2
        Me.btnUpdateService.Text = "Update Services"
        Me.btnUpdateService.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(264, 51)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Update Services Type"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 367)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnUpdateService)
        Me.Controls.Add(Me.btnAddServiceType)
        Me.Controls.Add(Me.btnAddService)
        Me.Name = "frmMaintenance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Items"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAddService As System.Windows.Forms.Button
    Friend WithEvents btnAddServiceType As System.Windows.Forms.Button
    Friend WithEvents btnUpdateService As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnOperation = New System.Windows.Forms.Button()
        Me.btnMaintenance = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnOperation
        '
        Me.btnOperation.Location = New System.Drawing.Point(95, 77)
        Me.btnOperation.Name = "btnOperation"
        Me.btnOperation.Size = New System.Drawing.Size(123, 44)
        Me.btnOperation.TabIndex = 0
        Me.btnOperation.Text = "Operation"
        Me.btnOperation.UseVisualStyleBackColor = True
        '
        'btnMaintenance
        '
        Me.btnMaintenance.Location = New System.Drawing.Point(224, 77)
        Me.btnMaintenance.Name = "btnMaintenance"
        Me.btnMaintenance.Size = New System.Drawing.Size(123, 44)
        Me.btnMaintenance.TabIndex = 1
        Me.btnMaintenance.Text = "Maintenance"
        Me.btnMaintenance.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 225)
        Me.Controls.Add(Me.btnMaintenance)
        Me.Controls.Add(Me.btnOperation)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mud in Your Eye"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnOperation As System.Windows.Forms.Button
    Friend WithEvents btnMaintenance As System.Windows.Forms.Button

End Class

'this is the main form that we first see at the begining
Public Class Form1
    Private Sub btnMaintenance_Click(sender As Object, e As EventArgs) Handles btnMaintenance.Click
        'Show Maintenance Form
        'test 1
        frmMaintenance.ShowDialog()
    End Sub

    Private Sub btnOperation_Click(sender As Object, e As EventArgs) Handles btnOperation.Click
        'Show Operations Form
        frmOperations.ShowDialog()
    End Sub
End Class

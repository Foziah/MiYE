Public Class Form1
    Private Sub btnMaintenance_Click(sender As Object, e As EventArgs) Handles btnMaintenance.Click
        frmMaintenance.ShowDialog()
    End Sub

    Private Sub btnOperation_Click(sender As Object, e As EventArgs) Handles btnOperation.Click
        frmOperations.ShowDialog()
    End Sub
End Class

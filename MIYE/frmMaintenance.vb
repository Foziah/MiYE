Public Class frmMaintenance

    Private Sub btnAddService_Click(sender As Object, e As EventArgs) Handles btnAddService.Click
        frmAddService.ShowDialog()
    End Sub

    Private Sub btnAddServiceType_Click(sender As Object, e As EventArgs) Handles btnAddServiceType.Click
        frmAddServiceType.ShowDialog()
    End Sub

    Private Sub btnUpdateService_Click(sender As Object, e As EventArgs) Handles btnUpdateService.Click
        frmUpdateServices.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmUpdateServiceTypes.ShowDialog()
    End Sub
End Class
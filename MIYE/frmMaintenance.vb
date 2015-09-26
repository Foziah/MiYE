Public Class frmMaintenance

    Private Sub btnAddService_Click(sender As Object, e As EventArgs) Handles btnAddService.Click
        frmAddService.ShowDialog()
    End Sub

    Private Sub btnAddServiceType_Click(sender As Object, e As EventArgs) Handles btnAddServiceType.Click
        frmAddServiceType.ShowDialog()
    End Sub
End Class
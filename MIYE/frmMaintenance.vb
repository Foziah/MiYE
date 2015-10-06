Public Class frmMaintenance

    Private Sub btnAddService_Click(sender As Object, e As EventArgs) Handles btnAddService.Click
        'Show Add Services Form
        frmAddService.ShowDialog()
    End Sub

    Private Sub btnAddServiceType_Click(sender As Object, e As EventArgs) Handles btnAddServiceType.Click
        'Show Add Service Types Form
        frmAddServiceType.ShowDialog()
    End Sub

    Private Sub btnUpdateService_Click(sender As Object, e As EventArgs) Handles btnUpdateService.Click
        'Update Services Here
        frmUpdateServices.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Update Service Types Here
        frmUpdateServiceTypes.ShowDialog()
    End Sub
End Class
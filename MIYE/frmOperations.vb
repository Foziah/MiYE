Public Class frmOperations

    Private Sub btnAddGuest_Click(sender As Object, e As EventArgs) Handles btnAddGuest.Click
        'Open Add Guest Form
        frmAddGuest.ShowDialog()
    End Sub

    Private Sub btnNewAppointment_Click(sender As Object, e As EventArgs) Handles btnNewAppointment.Click
        'Show New Appointment Form
        frmAppointment.ShowDialog()
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        'View All Appointments
        frmViewAppointments.ShowDialog()
    End Sub
End Class
Public Class frmViewAppointments

    Private Sub frmViewAppointments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MIYEDataset.viewAppointments' table. You can move, or remove it, as needed.
        Me.ViewAppointmentsTableAdapter.Fill(Me.MIYEDataset.viewAppointments)

    End Sub

    Private Sub txtAppointmentID_TextChanged(sender As Object, e As EventArgs) Handles txtAppointmentID.TextChanged
        Me.ViewAppointmentsTableAdapter.FillByAppointmentID(Me.MIYEDataset.viewAppointments, Val(txtAppointmentID.Text))
    End Sub

    Private Sub txtGuestName_TextChanged(sender As Object, e As EventArgs) Handles txtGuestName.TextChanged
        Me.ViewAppointmentsTableAdapter.FillByName(Me.MIYEDataset.viewAppointments, txtGuestName.Text)
    End Sub

    Private Sub txtGuestNumber_TextChanged(sender As Object, e As EventArgs) Handles txtGuestNumber.TextChanged
        Me.ViewAppointmentsTableAdapter.FillByGuestID(Me.MIYEDataset.viewAppointments, Val(txtGuestNumber.Text))
    End Sub

    Private Sub btnShowALl_Click(sender As Object, e As EventArgs) Handles btnShowALl.Click
        Me.ViewAppointmentsTableAdapter.Fill(Me.MIYEDataset.viewAppointments)
    End Sub
End Class
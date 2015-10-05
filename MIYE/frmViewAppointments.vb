Public Class frmViewAppointments

    Private Sub frmViewAppointments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MIYEDataset.viewAppointments' table. You can move, or remove it, as needed.
        Me.ViewAppointmentsTableAdapter.Fill(Me.MIYEDataset.viewAppointments)

    End Sub
End Class
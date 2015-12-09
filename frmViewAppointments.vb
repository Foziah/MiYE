Public Class frmViewAppointments
    Public appointmentID As Decimal = 0
    Private Sub frmViewAppointments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MIYEDataset.viewAppointments' table. You can move, or remove it, as needed.
        Me.ViewAppointmentsTableAdapter.Fill(Me.MIYEDataset.viewAppointments)

    End Sub

    Private Sub txtAppointmentID_TextChanged(sender As Object, e As EventArgs) Handles txtAppointmentID.TextChanged
        'Load grid filter by Appointment ID
        Me.ViewAppointmentsTableAdapter.FillByAppointmentID(Me.MIYEDataset.viewAppointments, Val(txtAppointmentID.Text))
    End Sub

    Private Sub txtGuestName_TextChanged(sender As Object, e As EventArgs) Handles txtGuestName.TextChanged
        'Load grid filter by Guest Name
        Me.ViewAppointmentsTableAdapter.FillByName(Me.MIYEDataset.viewAppointments, txtGuestName.Text)
    End Sub

    Private Sub txtGuestNumber_TextChanged(sender As Object, e As EventArgs) Handles txtGuestNumber.TextChanged
        'Load grid by Guest Number
        Me.ViewAppointmentsTableAdapter.FillByGuestID(Me.MIYEDataset.viewAppointments, Val(txtGuestNumber.Text))
    End Sub

    Private Sub btnShowALl_Click(sender As Object, e As EventArgs) Handles btnShowALl.Click
        'View All Appointments
        Me.ViewAppointmentsTableAdapter.Fill(Me.MIYEDataset.viewAppointments)
    End Sub



    Private Sub gvAppointments_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles gvAppointments.RowEnter
        appointmentID = gvAppointments.Rows(e.RowIndex).Cells(0).Value
        lblAppointmentID.Text = appointmentID.ToString()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        frmPrint.ShowDialog()
    End Sub

    Private Sub btnCancelREservation_Click(sender As Object, e As EventArgs) Handles btnCancelREservation.Click
        Dim appointments As New MIYEDatasetTableAdapters.viewAppointmentsTableAdapter
        Dim appointmentsAdapter As New MIYEDatasetTableAdapters.tblAppointmentsTableAdapter
        Dim dt As DataTable = appointments.GetDataByAppointmentID(appointmentID)
        Dim value As DateTime = Convert.ToDateTime(dt.Rows(0)(15).ToString())
        Dim appDate As DateTime = Convert.ToDateTime(CDate(dt.Rows(0)(8).ToString()) + " " + dt.Rows(0)(9).ToString())
        Dim diff = DateDiff(DateInterval.Minute, value, DateTime.Now)
        Dim diff2 = DateDiff(DateInterval.Minute, appDate, value)
        If (appointmentsAdapter.getAppointmentStatus(appointmentID) = "Active") Then
            If (diff <= 10 Or diff2 <= 90) Then
                appointmentsAdapter.UpdateAppointmentStatusWithoutFine(0, "Cancelled", appointmentID)
                MessageBox.Show("Appointment Cancelled Without Any Charges.")
            Else
                appointmentsAdapter.UpdateAppointmentStatusWithFine("Cancelled", appointmentID)
                MessageBox.Show("Appointment Cancelled. You still have to make payment because cancellation was not made within required timeframe.")
            End If
            Me.ViewAppointmentsTableAdapter.Fill(Me.MIYEDataset.viewAppointments)
        Else
            MessageBox.Show("This Appointment Cannot Be Cancelled.")
        End If
        
    End Sub
End Class
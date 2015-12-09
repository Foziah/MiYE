Public Class frmPrint

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtAppintmentID.TextChanged

    End Sub

    Private Sub frmPrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim appointments As New MIYEDatasetTableAdapters.viewAppointmentsTableAdapter
            Dim appID As Decimal = frmViewAppointments.appointmentID
            Dim dt As DataTable = appointments.GetDataByAppointmentID(appID)
            txtAppintmentID.Text = dt.Rows(0)(5).ToString()
            txtGuestID.Text = dt.Rows(0)(0).ToString()
            txtFName.Text = dt.Rows(0)(1).ToString()
            txtLName.Text = dt.Rows(0)(2).ToString()
            txtAppointmentDate.Text = CDate(dt.Rows(0)(8).ToString()).ToShortDateString()
            txtStartTime.Text = dt.Rows(0)(9).ToString()
            txtEndTime.Text = dt.Rows(0)(10).ToString()
            txtServiceName.Text = dt.Rows(0)(17).ToString()
            txtServiceType.Text = dt.Rows(0)(14).ToString()
            txtRate.Text = dt.Rows(0)(18).ToString()
            lblTotalPrice.Text = "$ " + dt.Rows(0)(11).ToString()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub
End Class
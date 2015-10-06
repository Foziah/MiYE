Imports System.Globalization

Public Class frmAppointment
    Dim totalPrice As Decimal = 0
    Private Sub frmAppointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable = TblGuestsTableAdapter.GetDataBynAME()
        cbGuestID.DataSource = dt
        cbGuestName.DataSource = dt
        cbGuestID.ValueMember = "GuestID"
        cbGuestID.DisplayMember = "GuestID"

        cbGuestName.ValueMember = "GuestID"
        cbGuestName.DisplayMember = "Name"
        'TODO: This line of code loads data into the 'MIYEDataset.tblServices' table. You can move, or remove it, as needed.
        Me.TblServicesTableAdapter.Fill(Me.MIYEDataset.tblServices)

        cbGuestID.SelectedIndex = 0
        cbServices.SelectedIndex = 0
        cbStartHrs.SelectedIndex = 0
        cbStartMinutes.SelectedIndex = 0
        cbServiceDuration.SelectedIndex = 0
        cbServiceDuration.SelectedIndex = 0
        'TODO: This line of code loads data into the 'MIYEDataset.tblServiceTypes' table. You can move, or remove it, as needed.
        Me.TblServiceTypesTableAdapter.FillByServiceID(Me.MIYEDataset.tblServiceTypes, cbServices.SelectedValue)

    End Sub

    Private Sub FillByNaMEToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.TblGuestsTableAdapter.FillByNaME(Me.MIYEDataset.tblGuests)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByNaMEToolStripButton1_Click(sender As Object, e As EventArgs)
        Try
            Me.TblGuestsTableAdapter.FillByNaME(Me.MIYEDataset.tblGuests)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub cbGuestID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGuestID.SelectedIndexChanged
        'cbGuestName.SelectedValue = cbGuestID.SelectedValue
    End Sub


    Private Sub btnMakeAppointment_Click(sender As Object, e As EventArgs) Handles btnMakeAppointment.Click
        Dim startTime As String = cbStartHrs.Text + ":" + cbStartMinutes.Text
        Dim serviceDate As Date = DateTimePicker1.Text
        Dim endTime As String = lblEndTime.Text
        Dim appointments As New MIYEDatasetTableAdapters.tblAppointmentsTableAdapter
        appointments.Insert(cbGuestID.SelectedValue, cbServiceType.SelectedValue, serviceDate, TimeSpan.Parse(startTime), TimeSpan.Parse(endTime), totalPrice)
        MessageBox.Show("Appointment Saved Successfully.")
    End Sub

    Private Sub cbServices_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbServices.SelectedIndexChanged
        Me.TblServiceTypesTableAdapter.FillByServiceID(Me.MIYEDataset.tblServiceTypes, cbServices.SelectedValue)
        ProcessTime()
    End Sub

    Private Sub cbServiceDuration_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbServiceDuration.SelectedIndexChanged
        ProcessTime()
    End Sub

    Sub ProcessTime()
        Dim startTime As String = cbStartHrs.Text + ":" + cbStartMinutes.Text
        Dim serviceDate As Date = DateTimePicker1.Text

        Dim cost As Decimal = TblServicesTableAdapter.GetCostByServiceID(cbServices.SelectedValue)
        Dim serviceDateTime As String = serviceDate.ToShortDateString() + " " + startTime
        Dim endDateTime As String = ""
        If cbServiceDuration.SelectedIndex = 0 Then
            '30 Minutes
            endDateTime = Convert.ToDateTime(serviceDateTime).AddMinutes(30)
            totalPrice = cost * 30
        Else
            '60 Minutes
            endDateTime = Convert.ToDateTime(serviceDateTime).AddMinutes(60)
            totalPrice = cost * 60
        End If
        Dim dtt As DateTime = Convert.ToDateTime(endDateTime)
        Dim convertedTime As String = dtt.ToString("HH:mm")
        lblEndTime.Text = convertedTime
        lblTotalPrice.Text = "$ " + totalPrice.ToString()
    End Sub
End Class
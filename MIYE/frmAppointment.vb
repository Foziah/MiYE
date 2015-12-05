Imports System.Globalization

Public Class frmAppointment
    Dim totalPrice As Decimal = 0
    Private Sub frmAppointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set data source of Guest Dropdowns
        Dim dt As DataTable = TblGuestsTableAdapter.GetDataBynAME()
        cbGuestID.DataSource = dt
        cbGuestName.DataSource = dt
        cbGuestID.ValueMember = "GuestID"
        cbGuestID.DisplayMember = "GuestID"
        cbGuestName.ValueMember = "GuestID"
        cbGuestName.DisplayMember = "Name"
        'Loading All Services
        Me.TblServicesTableAdapter.Fill(Me.MIYEDataset.tblServices)
        LoadServiceDurations()
        'Initializing Values
        cbGuestID.SelectedIndex = 0
        cbServices.SelectedIndex = 0
        cbStartHrs.SelectedIndex = 0
        cbStartMinutes.SelectedIndex = 0
        cbServiceDuration.SelectedIndex = 0
        cbServiceDuration.SelectedIndex = 0
        'Loading Service Types
        Me.TblServiceTypesTableAdapter.FillByServiceID(Me.MIYEDataset.tblServiceTypes, cbServices.SelectedValue)
        ProcessTime()
    End Sub

    Private Sub cbGuestID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGuestID.SelectedIndexChanged
        'cbGuestName.SelectedValue = cbGuestID.SelectedValue
    End Sub

    Private Sub btnMakeAppointment_Click(sender As Object, e As EventArgs) Handles btnMakeAppointment.Click
        Dim appointments As New MIYEDatasetTableAdapters.tblAppointmentsTableAdapter
        Dim guest As New MIYEDatasetTableAdapters.tblGuestsTableAdapter
        Dim dtGuestInfo As DataTable = guest.GetDataByCheckInCheckOut(cbGuestID.SelectedValue)
        Dim checkinDate As Date = CDate(dtGuestInfo.Rows(0)("CheckinDate"))
        Dim checkinTime As String = (dtGuestInfo.Rows(0)("CheckinTime")).ToString()
        Dim checkoutDate As Date = CDate(dtGuestInfo.Rows(0)("CheckoutDate"))
        Dim checkoutTime As String = (dtGuestInfo.Rows(0)("CheckoutTime")).ToString()
        Dim startTime As String = cbStartHrs.Text + ":" + cbStartMinutes.Text 'concatenates hours:minutes
        Dim serviceDate As Date = DateTimePicker1.Text 'get service date
        Dim endTime As String = lblEndTime.Text 'get end time, end time is calculated using function ProcessTime()

        If serviceDate >= checkinDate And serviceDate <= checkoutDate Then
            If cbServices.SelectedValue = 1 Then
                'Mineral Bath Services
                If appointments.GetDataByGuestID(serviceDate, startTime, cbGuestID.SelectedValue).Rows.Count > 0 Then
                    'A guest cannot reserve overlapping services
                    MessageBox.Show("A guest cannot reserve overlapping services")
                Else
                    'This function saves the appointment in database.
                    appointments.Insert(cbGuestID.SelectedValue, cbServiceType.SelectedValue, serviceDate, TimeSpan.Parse(startTime), TimeSpan.Parse(endTime), totalPrice, DateTime.Now, "Active") 'Inserting data in database
                    MessageBox.Show("Appointment Saved Successfully.")
                End If
            Else
                'Services Other Than Mineral Bath
                If appointments.GetDataByAppointmentExists(serviceDate, startTime, cbServiceType.SelectedValue).Rows.Count > 0 Then
                    'Appointment for someone already exists
                    MessageBox.Show("Only one guest at a time may reserve any service.")
                Else
                    If appointments.GetDataByGuestID(serviceDate, startTime, cbGuestID.SelectedValue).Rows.Count > 0 Then
                        'A guest cannot reserve overlapping services
                        MessageBox.Show("A guest cannot reserve overlapping services")
                    Else
                        'This function saves the appointment in database.
                        appointments.Insert(cbGuestID.SelectedValue, cbServiceType.SelectedValue, serviceDate, TimeSpan.Parse(startTime), TimeSpan.Parse(endTime), totalPrice, DateTime.Now, "Active") 'Inserting data in database
                        MessageBox.Show("Appointment Saved Successfully.")
                    End If
                End If
            End If
        Else
            MessageBox.Show("A guest can only reserve a service during duration of their stay. This guest's stay is between " + checkinDate + " AND " + checkoutDate)
        End If
        
    End Sub
    Public Sub LoadServiceDurations()
        If cbServices.SelectedValue = 1 Or cbServices.SelectedValue = 4 Then
            'Mineral Bath Services/ Specialty Treatment Services (60-90 minutes)
            cbServiceDuration.Items.Clear()
            cbServiceDuration.Items.Add("60 minutes")
            cbServiceDuration.Items.Add("90 minutes")
        Else
            cbServiceDuration.Items.Clear()
            cbServiceDuration.Items.Add("30 minutes")
            cbServiceDuration.Items.Add("60 minutes")
        End If
        cbServiceDuration.SelectedIndex = 0
    End Sub
    Private Sub cbServices_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbServices.SelectedIndexChanged
        LoadServiceDurations()
        'Load Service Types
        Me.TblServiceTypesTableAdapter.FillByServiceID(Me.MIYEDataset.tblServiceTypes, cbServices.SelectedValue)
        'updates time and cost when values are changed 
        ProcessTime()
    End Sub

    Private Sub cbServiceDuration_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbServiceDuration.SelectedIndexChanged
        'updates time and cost when values are changed 
        ProcessTime()
    End Sub

    'this function updates time and cost when values are changed on the form.
    Sub ProcessTime()
        Try
            Dim startTime As String = cbStartHrs.Text + ":" + cbStartMinutes.Text
            Dim serviceDate As Date = DateTimePicker1.Text
            'Get cost of selected service from database
            Dim cost As Decimal = TblServicesTableAdapter.GetCostByServiceID(cbServices.SelectedValue)
            Dim serviceDateTime As String = serviceDate.ToShortDateString() + " " + startTime
            Dim endDateTime As String = ""
            'Check if service is 30 minutes or 60 minutes
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
            lblEndTime.Text = convertedTime 'displaying end time on form
            lblTotalPrice.Text = "$ " + totalPrice.ToString() 'displaying total price on form
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbStartHrs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbStartHrs.SelectedIndexChanged
        ProcessTime()
    End Sub

    Private Sub cbStartMinutes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbStartMinutes.SelectedIndexChanged
        ProcessTime()
    End Sub
End Class
Public Class frmServiceAvailability

    Private Sub frmServiceAvailability_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim s As New Service()
        s.LoadServices(cbServices)
        LoadServiceTypes()
        cbServices.SelectedIndex = 0
    End Sub
    Public Sub LoadServiceTypes()
        Dim st As New ServiceTypes()
        st.LoadServiceTypes(cbServiceType, cbServices.SelectedValue)
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
        LoadServiceTypes()
        LoadServiceDurations()
    End Sub

    Private Sub cbServiceType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbServiceType.SelectedIndexChanged
        LoadServiceDurations()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtSlots.Clear()
        Dim appointments As New MIYEDatasetTableAdapters.tblAppointmentsTableAdapter
        Dim tblServiceTypes As New MIYEDatasetTableAdapters.tblServiceTypesTableAdapter
        Dim serviceDate As Date = Date.Today 'get service date
        Dim services As DataTable = tblServiceTypes.GetDataByServiceAndServiceTypes
        Dim startTime As String = "08:00"  'concatenates hours:minutes
        Dim endTime As String = "20:59"
        Dim duration As Integer = 0
        If cbServiceDuration.SelectedItem.Contains(30) Then
            duration = 30
        ElseIf cbServiceDuration.SelectedItem.Contains(60) Then
            duration = 60
        ElseIf cbServiceDuration.SelectedItem.Contains(90) Then
            duration = 90
        End If
        Dim days As Integer = Val(NumericUpDown1.Value)
        If cbServices.SelectedValue = 1 Then
            'Mineral Bath Services
            txtSlots.Text = "For Mineral Bath Services, You can Make Reservation For Any Time Between 0800 hrs -  20:59 hrs"
            Label5.Visible = False
        Else
            Label5.Visible = True
            For d As Integer = 1 To days
                txtSlots.Text &= serviceDate + vbNewLine
                Dim serviceID As Integer = cbServices.SelectedValue
                If serviceID <> 1 Then
                    Dim appts As DataTable = appointments.GetAppointmentsByDateAndService(serviceDate, cbServiceType.SelectedValue)
                    If appts.Rows.Count = 0 Then
                        txtSlots.Text &= "No Reservations Found." + vbNewLine
                    Else
                        For Each r As DataRow In appts.Rows
                            txtSlots.Text &= r(4).ToString() + " TO " + r(5).ToString + vbNewLine
                        Next
                    End If
                End If
                serviceDate = serviceDate.AddDays(1)
            Next
        End If
    End Sub
End Class
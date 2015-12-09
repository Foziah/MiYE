Public Class frmAvailableServices

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        txtAvailableServices.Clear()
        Dim appointments As New MIYEDatasetTableAdapters.tblAppointmentsTableAdapter
        Dim tblServiceTypes As New MIYEDatasetTableAdapters.tblServiceTypesTableAdapter
        Dim serviceDate As Date = DateTimePicker1.Text 'get service date
        Dim services As DataTable = tblServiceTypes.GetDataByServiceAndServiceTypes
        Dim startTime As String = cbStartHrs.Text + ":" + cbStartMinutes.Text 'concatenates hours:minutes
        For Each row As DataRow In services.Rows
            '0,1,2,3,4
            'TypeID, ServiceID, TypeName, ServiceName, Cost
            Dim typeID As Integer = Convert.ToInt32(row(0).ToString)
            Dim serviceID As Integer = Convert.ToInt32(row(1).ToString)
            Dim typeName As String = row(2).ToString
            Dim serviceName As String = row(3).ToString
            If serviceID = 1 Then
                'Mineral Bath Services- Multiple People Can Reserve At A Time
                'Available for Reservation
                txtAvailableServices.Text &= serviceName + "-" + typeName + vbNewLine
            Else
                'Services Other Than Mineral Bath- Only one person can reserve at a time
                If appointments.GetDataByAppointmentExists(serviceDate, startTime, typeID).Rows.Count > 0 Then
                    'Appointment for someone already exists
                Else
                    'Available for Reservation
                    txtAvailableServices.Text &= serviceName + "-" + typeName + vbNewLine
                End If
            End If
        Next
    End Sub
End Class
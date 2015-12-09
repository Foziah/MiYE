Public Class frmAddGuest

    Private Sub frmAddGuest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load All Guests
        LoadGuests()
        cbStartHrs.SelectedIndex = 0
        cbStartMinutes.SelectedIndex = 0
        cbCheckoutHour.SelectedIndex = 0
        cbCheckoutMinute.SelectedIndex = 0
    End Sub
    
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim checkInTime As String = cbStartHrs.Text + ":" + cbStartMinutes.Text
        Dim checkinDt As Date = checkinDate.Text
        Dim checkoutTime As String = cbCheckoutHour.Text + ":" + cbCheckoutMinute.Text
        Dim checkoutDt As Date = checkoutDate.Text
        Dim guest As New Guest(txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtPhone.Text, checkinDt, checkInTime, checkoutDt, checkoutTime)
        guest.AddGuest()
        'Load All Guests
        LoadGuests()
    End Sub
    Public Sub LoadGuests()
        Dim g As New Guest()
        Dim AllGuests As DataTable = g.GetAllGuests()
        gvGuests.DataSource = AllGuests
    End Sub
End Class
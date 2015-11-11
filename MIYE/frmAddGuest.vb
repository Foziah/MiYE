Public Class frmAddGuest

    Private Sub frmAddGuest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load All Guests
        LoadGuests()
    End Sub
    
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim guest As New Guest(txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtPhone.Text)
        guest.AddGuest()
        'Load All Guests
        LoadGuests()
    End Sub
    Private Sub LoadGuests()
        Dim g As New Guest()
        Dim AllGuests As DataTable = g.GetAllGuests()
        gvGuests.DataSource = AllGuests
    End Sub
End Class
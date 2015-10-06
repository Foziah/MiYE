Public Class frmAddGuest

    Private Sub frmAddGuest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load All Guests
        Me.TblGuestsTableAdapter.Fill(Me.MIYEDataset.tblGuests)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Inserting guest in database
        TblGuestsTableAdapter.Insert(txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtPhone.Text)
        'Refreshing all guests
        Me.TblGuestsTableAdapter.Fill(Me.MIYEDataset.tblGuests)

    End Sub
End Class
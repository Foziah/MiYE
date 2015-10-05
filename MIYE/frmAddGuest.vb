Public Class frmAddGuest

    Private Sub frmAddGuest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MIYEDataset.tblGuests' table. You can move, or remove it, as needed.
        Me.TblGuestsTableAdapter.Fill(Me.MIYEDataset.tblGuests)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        TblGuestsTableAdapter.Insert(txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtPhone.Text)
        Me.TblGuestsTableAdapter.Fill(Me.MIYEDataset.tblGuests)

    End Sub
End Class
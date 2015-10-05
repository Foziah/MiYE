Public Class frmAddServiceType

    Private Sub frmAddServiceType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MIYEDataset.tblServices' table. You can move, or remove it, as needed.
        Me.TblServicesTableAdapter.Fill(Me.MIYEDataset.tblServices)
        'TODO: This line of code loads data into the 'MIYEDataset.viewServiceTypes' table. You can move, or remove it, as needed.
        Me.ViewServiceTypesTableAdapter.FillByServiceID(Me.MIYEDataset.viewServiceTypes, cbServices.SelectedValue)
        cbServices.SelectedIndex = 0
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim typeName As String = txtTypeName.Text
        If (typeName <> "") Then
            Dim tblServiceTypes As New MIYEDatasetTableAdapters.tblServiceTypesTableAdapter
            tblServiceTypes.Insert(cbServices.SelectedValue, txtTypeName.Text)
            Me.ViewServiceTypesTableAdapter.FillByServiceID(Me.MIYEDataset.viewServiceTypes, cbServices.SelectedValue)
        Else
            MsgBox("Cannot be Empty.")
        End If
    End Sub

    Private Sub cbServices_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbServices.SelectedIndexChanged
        Me.ViewServiceTypesTableAdapter.FillByServiceID(Me.MIYEDataset.viewServiceTypes, cbServices.SelectedValue)
    End Sub
End Class
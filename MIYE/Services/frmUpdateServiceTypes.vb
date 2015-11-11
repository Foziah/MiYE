Public Class frmUpdateServiceTypes
    Dim serviceID As Object
    Dim typID As Object
    Private Sub frmUpdateServiceTypes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MIYEDataset.tblServices' table. You can move, or remove it, as needed.
        Me.TblServicesTableAdapter.Fill(Me.MIYEDataset.tblServices)
        'TODO: This line of code loads data into the 'MIYEDataset.viewServiceTypes' table. You can move, or remove it, as needed.
        Me.ViewServiceTypesTableAdapter.FillByServiceID(Me.MIYEDataset.viewServiceTypes, cbServices.SelectedValue)
        cbServices.SelectedIndex = 0
    End Sub

    Private Sub cbServices_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbServices.SelectedIndexChanged
        Me.ViewServiceTypesTableAdapter.FillByServiceID(Me.MIYEDataset.viewServiceTypes, cbServices.SelectedValue)
    End Sub

   
    Private Sub gvServiceTypes_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles gvServiceTypes.RowEnter
        typID = gvServiceTypes.Rows(e.RowIndex).Cells(3).Value
        serviceID = gvServiceTypes.Rows(e.RowIndex).Cells(0).Value
        txtTypeName.Text = gvServiceTypes.Rows(e.RowIndex).Cells(2).Value
        cbServices.SelectedValue = serviceID
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim serviceTypes As New MIYEDatasetTableAdapters.tblServiceTypesTableAdapter
        serviceTypes.UpdateServiceType(txtTypeName.Text, typID)
        MessageBox.Show("Record Updated")
        Me.ViewServiceTypesTableAdapter.FillByServiceID(Me.MIYEDataset.viewServiceTypes, cbServices.SelectedValue)

    End Sub
End Class
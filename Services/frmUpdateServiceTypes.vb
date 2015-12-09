Public Class frmUpdateServiceTypes
    Dim serviceID As Object
    Dim typID As Object
    Private Sub frmUpdateServiceTypes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim s As New Service()
        s.LoadServices(cbServices)
        LoadServiceTypes()
        cbServices.SelectedIndex = 0
    End Sub

    Private Sub LoadServiceTypes()
        Dim g As New ServiceTypes()
        Dim AllServiceTypes As DataTable = g.GetAllServiceTypes(cbServices.SelectedValue)
        gvServiceTypes.DataSource = AllServiceTypes
    End Sub
    Private Sub cbServices_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbServices.SelectedIndexChanged
        LoadServiceTypes()
    End Sub
    Private Sub gvServiceTypes_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles gvServiceTypes.RowEnter
        typID = gvServiceTypes.Rows(e.RowIndex).Cells(3).Value
        serviceID = gvServiceTypes.Rows(e.RowIndex).Cells(0).Value
        txtTypeName.Text = gvServiceTypes.Rows(e.RowIndex).Cells(2).Value
        cbServices.SelectedValue = serviceID
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim s As New ServiceTypes
        s.UpdateServiceType(txtTypeName.Text, typID)
        MessageBox.Show("Record Updated")
        LoadServiceTypes()
    End Sub
End Class
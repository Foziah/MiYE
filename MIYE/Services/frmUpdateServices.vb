Public Class frmUpdateServices
    Dim serviceID As Object
    Private Sub frmUpdatePrice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MIYEDataset.tblServices' table. You can move, or remove it, as needed.
        Me.TblServicesTableAdapter.Fill(Me.MIYEDataset.tblServices)

    End Sub

  

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        TblServicesTableAdapter.UpdateServices(txtServiceName.Text, Val(txtCost.Text), serviceID)
        MessageBox.Show("Record Updated")
        Me.TblServicesTableAdapter.Fill(Me.MIYEDataset.tblServices)
    End Sub

    Private Sub gvServices_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles gvServices.RowEnter
        serviceID = gvServices.Rows(e.RowIndex).Cells(0).Value
        Dim serviceName = gvServices.Rows(e.RowIndex).Cells(1).Value
        Dim cost = gvServices.Rows(e.RowIndex).Cells(2).Value
        txtServiceName.Text = serviceName
        txtCost.Text = cost
    End Sub


End Class
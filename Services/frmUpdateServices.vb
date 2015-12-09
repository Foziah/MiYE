Public Class frmUpdateServices
    Dim serviceID As Object
    Private Sub frmUpdatePrice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadServices()
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim serviceName As String = txtServiceName.Text
        Dim serviceCost As Decimal = Val(txtCost.Text)
        If serviceName = "" Then
            MsgBox("Fields cannot be blank.")
        ElseIf serviceCost = 0 Then
            MsgBox("Invalid Cost Entered.")
        Else
            Dim s As New Service()
            s.UpdateService(serviceName, serviceCost, serviceID)
            MessageBox.Show("Record Updated")
            LoadServices()
        End If
        
    End Sub
    Private Sub LoadServices()
        Dim g As New Service()
        Dim AllServices As DataTable = g.GetAllServices
        gvServices.DataSource = AllServices
    End Sub
    Private Sub gvServices_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles gvServices.RowEnter
        serviceID = gvServices.Rows(e.RowIndex).Cells(0).Value
        Dim serviceName = gvServices.Rows(e.RowIndex).Cells(1).Value
        Dim cost = gvServices.Rows(e.RowIndex).Cells(2).Value
        txtServiceName.Text = serviceName
        txtCost.Text = cost
    End Sub
End Class
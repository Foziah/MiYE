Public Class frmAddService

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim serviceName As String = txtServiceName.Text
        Dim serviceCost As Decimal = Val(txtCost.Text)
        Dim tblServicesAdapter As New MIYEDatasetTableAdapters.tblServicesTableAdapter
        If serviceName = "" Then
            MsgBox("Fields cannot be blank.")
        ElseIf serviceCost = 0 Then
            MsgBox("Invalid Cost Entered.")
        Else
            Dim service As New Service(serviceName, serviceCost)
            service.AddService()
            LoadServices()
        End If
    End Sub
    Private Sub LoadServices()
        Dim g As New Service()
        Dim AllServices As DataTable = g.GetAllServices
        gvServices.DataSource = AllServices
    End Sub
    Private Sub frmAddService_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadServices()
    End Sub
End Class
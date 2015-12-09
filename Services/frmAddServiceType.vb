Public Class frmAddServiceType

    Private Sub frmAddServiceType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim typeName As String = txtTypeName.Text
        If (typeName <> "") Then
            Dim serviceType As New ServiceTypes(typeName)
            serviceType.AddServiceType(cbServices.SelectedValue)
            LoadServiceTypes()
        Else
            MsgBox("Cannot be Empty.")
        End If
    End Sub

    Private Sub cbServices_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbServices.SelectedIndexChanged
        LoadServiceTypes()
    End Sub
End Class
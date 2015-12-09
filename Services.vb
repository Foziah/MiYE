Public Class Service
    Private serviceName As String
    Private serviceCost As Decimal
    Private Services As New MIYEDatasetTableAdapters.tblServicesTableAdapter
    Public Sub New()

    End Sub
    Public Sub New(ByVal name As String, ByVal cost As Decimal)
        serviceName = name
        serviceCost = cost
    End Sub
    Public Sub AddService()
        Services.Insert(serviceName, serviceCost)
    End Sub
    Public Sub UpdateService(ByVal name As String, ByVal cost As Decimal, ByVal serviceID As Integer)
        Services.UpdateServices(name, cost, serviceID)
    End Sub
    Function GetAllServices() As DataTable
        Dim s As DataTable = Services.GetData()
        Return s
    End Function
    Public Sub LoadServices(ByRef cbServices As ComboBox)
        Dim AllServices As DataTable = GetAllServices()
        cbServices.DisplayMember = "ServiceName"
        cbServices.ValueMember = "ServiceID"
        cbServices.DataSource = AllServices
    End Sub
End Class

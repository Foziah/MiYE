Public Class ServiceTypes
    Private typeName As String
    Private ServiceTypes As New MIYEDatasetTableAdapters.tblServiceTypesTableAdapter
    Public Sub New()

    End Sub
    Public Sub New(ByVal name As String)
        typeName = name
    End Sub
    Public Sub AddServiceType(ByVal serviceID As Integer)
        ServiceTypes.Insert(serviceID, typeName)
    End Sub
    Public Sub UpdateServiceType(ByVal name As String, ByVal typeID As Integer)
        ServiceTypes.UpdateServiceType(name, typeID)
    End Sub
    Function GetAllServiceTypes(ByVal serviceID As Integer) As DataTable
        Dim ViewServiceTypes As New MIYEDatasetTableAdapters.viewServiceTypesTableAdapter
        Dim s As DataTable = ViewServiceTypes.GetDataByServiceID(serviceID)
        Return s
    End Function
    Public Sub LoadServiceTypes(ByRef cbServiceTypes As ComboBox, ByVal serviceID As Integer)
        Dim AllServices As DataTable = GetAllServiceTypes(serviceID)
        cbServiceTypes.DisplayMember = "TypeName"
        cbServiceTypes.ValueMember = "TypeID"
        cbServiceTypes.DataSource = AllServices
    End Sub
End Class

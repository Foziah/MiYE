Public Class Guest
    Private firstName As String
    Private lastName As String
    Private email As String
    Private phone As String
    Private checkinDate As Date
    Private checkinTime As String
    Private checkoutDate As Date
    Private checkoutTime As String
    Private Guests As New MIYEDatasetTableAdapters.tblGuestsTableAdapter
    Public Sub AddGuest()
        Guests.Insert(firstName, lastName, email, phone, checkinDate, TimeSpan.Parse(checkinTime), checkoutDate, TimeSpan.Parse(checkoutTime))
    End Sub
    Function GetAllGuests() As DataTable
        Dim g As DataTable = Guests.GetData()
        Return g
    End Function
    Public Sub New()

    End Sub
    Public Sub New(ByVal fName As String, ByVal lName As String, ByVal guestEmail As String, ByVal guestPhone As String, ByVal checkinDt As Date, ByVal checkinTm As String, ByVal checkoutDt As Date, ByVal checkoutTm As String)
        MyClass.firstName = fName
        MyClass.lastName = lName
        MyClass.email = guestEmail
        MyClass.phone = guestPhone
        MyClass.checkinDate = checkinDt
        MyClass.checkinTime = checkinTm
        MyClass.checkoutDate = checkoutDt
        MyClass.checkoutTime = checkoutTm
    End Sub
End Class

Public Class Guest
    Private firstName As String
    Private lastName As String
    Private email As String
    Private phone As String
    Private Guests As New MIYEDatasetTableAdapters.tblGuestsTableAdapter
    Public Sub AddGuest()
        Guests.Insert(firstName, lastName, email, phone)
    End Sub
    Function GetAllGuests() As DataTable
        Dim g As DataTable = Guests.GetData()
        Return g
    End Function
    Public Sub New()

    End Sub
    Public Sub New(ByVal fName As String, ByVal lName As String, ByVal guestEmail As String, ByVal guestPhone As String)
        MyClass.firstName = fName
        MyClass.lastName = lName
        MyClass.email = guestEmail
        MyClass.phone = guestPhone
    End Sub
End Class

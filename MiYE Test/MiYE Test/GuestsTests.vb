Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class GuestTests

    <TestMethod()> Public Sub addGuestTest()
        Dim guest As New Guest('Bob', 'Smith', 'bob.smith@me.com', '9095558787')
        guest.AddGuest()
        Dim guestByID As DataTable = g.GetAllGuests()
        gvGuests.DataSource = AllGuests


    End Sub

End Class
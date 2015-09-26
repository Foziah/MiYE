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
            tblServicesAdapter.Insert(serviceName, serviceCost)
            Me.TblServicesTableAdapter.Fill(Me.MIYEDataset.tblServices)
        End If

    End Sub

    Private Sub frmAddService_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MIYEDataset.tblServices' table. You can move, or remove it, as needed.
        Me.TblServicesTableAdapter.Fill(Me.MIYEDataset.tblServices)

    End Sub
End Class
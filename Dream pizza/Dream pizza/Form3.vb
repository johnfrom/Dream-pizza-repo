Public Class Form3
    Dim ammount As Integer
    Public name As String
    Dim phone As String
    Dim address As String
    Public Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        name = txtName.Text
        phone = txtPhone.Text
        address = txtAddress.Text
        lblOrder.Text = "Name: " & name & ""
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub
End Class
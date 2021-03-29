Public Class Form3
    Dim ammount As Integer

    Public Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form2.txtAddress.Text = "" Then
            lblOrder.Text = "Name: " & Form2.names & "
Phone: " & Form2.phone & ""
        Else lblOrder.Text = "Name: " & Form2.names & "
Phone: " & Form2.phone & "
Address: " & Form2.address & ""
        End If

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        Close()
        Form2.Show()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Close()
        Form2.Close()
        Form1.Close()
    End Sub
End Class
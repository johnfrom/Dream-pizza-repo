Public Class Form1
    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hide() 'hides the current form
        Form2.Show() 'shows the customer details form
    End Sub
End Class
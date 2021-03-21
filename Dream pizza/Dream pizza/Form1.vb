Public Class Form1
    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hide() 'hide the first form
        Form2.Show() 'show the seccond form
    End Sub
End Class
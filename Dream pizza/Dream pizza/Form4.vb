Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSummaryBack_Click(sender As Object, e As EventArgs) Handles btnSummaryBack.Click
        Close()  'closes form 4
        Form3.Show() 'opens form 3
    End Sub
End Class
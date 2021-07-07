Public Class Form4

    Private Sub btnSummaryBack_Click(sender As Object, e As EventArgs) Handles btnSummaryBack.Click
        Close()  'closes form 4
        Form3.Show() 'opens form 3
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        End 'closes all forms
    End Sub
End Class
Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hide()
        Form3.Show()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then 'check if the checkbox is checked or not
            txtAdress.Enabled = True 'If checkbox is checked the adress text box will be enabled
        Else
            txtAdress.Enabled = False 'If checkbox is not checked disable the adress text box
        End If
    End Sub
End Class
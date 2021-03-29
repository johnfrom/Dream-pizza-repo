Public Class Form2
    Public names As String
    Public phone As String
    Public address As String
    Public delivery As String
    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtName.Text = "" Then
            MessageBox.Show("you need to enter your name")
        ElseIf txtPhone.Text = "" Then
            MessageBox.Show("you need to enter your phone number")
        ElseIf chkDelivery.Checked = True And txtAddress.Text = "" Then
            MessageBox.Show("you need to enter your address")
        Else Hide()
            names = txtName.Text
            phone = txtPhone.Text
            address = txtAddress.Text
            Form3.Show()
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkDelivery.CheckedChanged
        txtAddress.Text = ""
        If chkDelivery.Checked = True Then 'check if the checkbox is checked or not
            txtAddress.Enabled = True 'If checkbox is checked the adress text box will be enabled
        Else
            txtAddress.Enabled = False 'If checkbox is not checked disable the adress text box trolololol. :)
        End If
    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtPhone.MaskInputRejected

    End Sub
End Class
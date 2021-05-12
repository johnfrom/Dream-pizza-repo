Public Class Form2
    Public names As String
    Public phone As String
    Public address As String
    Public delivery As String
    'defines all customer information as public so it can be used on form3 and as string becuase it is text
    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles btnContinue.Click

        Form3.totalammount = Val(0)
        If chkDelivery.Checked = True Then
            Form3.totalammount = Form3.totalammount + Val(3)
        Else
            Form3.totalammount = Val(0).ToString("C")
        End If
        For price = 0 To 11
            Form3.totalammount = Form3.totalammount + Form3.pizza(1, price)
            Form3.lblTotal.Text = Form3.totalammount.ToString("C")
        Next

        If txtName.Text = "" Then
            MessageBox.Show("you need to enter your name")  'checks if a name was entered
        ElseIf txtPhone.Text = "(   )    -" Then
            MessageBox.Show("you need to enter your phone number") 'checks if a phone number was entered
        ElseIf chkDelivery.Checked = True And txtAddress.Text = "" Then
            MessageBox.Show("you need to enter your address")  'checks if the delivery check box was checked and if so also checks if the address text box is blank
        Else Hide()    'if something has been entered in all the text boxes then hide form2
            names = txtName.Text
            phone = txtPhone.Text
            address = txtAddress.Text
            Form3.Show()   'apply the text from the text boxes to the matching variables and show form3
        End If


    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkDelivery.CheckedChanged

        txtAddress.Text = ""  'clear text in the address text box
        If chkDelivery.Checked = True Then 'check if the checkbox is checked or not
            txtAddress.Enabled = True 'If checkbox is checked the adress text box will be enabled
        Else
            txtAddress.Enabled = False 'If checkbox is not checked disable the adress text box
        End If

    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtPhone.MaskInputRejected

    End Sub
End Class
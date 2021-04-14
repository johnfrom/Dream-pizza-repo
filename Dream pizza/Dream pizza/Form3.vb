Public Class Form3
    Dim amount As Integer
    Public totalammount As Decimal
    Dim pizzanumber As Integer


    Public Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pizzanumber = 1
        lblTotal.Text = totalammount
        If Form2.txtAddress.Text = "" Then
            lblOrder.Text = "Name: " & Form2.names & "
Phone: " & Form2.phone & "

Total Cost: " & Form2.cost & ""
        Else lblOrder.Text = "Name: " & Form2.names & "
Phone: " & Form2.phone & "
Delivery Address: " & Form2.address & ""
        End If

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        Close()  'joe
        Form2.Show()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Close()
        Form2.Close()
        Form1.Close() 'closes all forms
    End Sub

    Private Sub cmbCheese_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCheese.SelectedIndexChanged
        totalammount = Val(lblTotal.Text).ToString("C")  '    lblOrder.Text += "" & cmbCheese.Text & " Cheese pizzas $" & amount * 8.5 lblTotal.Text = totalammount + amount * 8.5
        amount = Val(cmbCheese.Text).ToString("C")

    End Sub

    Private Sub cmbBeef_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBeef.SelectedIndexChanged
        totalammount = Val(lblTotal.Text).ToString("C")
        amount = Val(cmbBeef.Text).ToString("C")
        lblOrder.Text += "
" & cmbBeef.Text & " Beef and Onion $" & amount * 8.5
        lblTotal.Text = totalammount + amount * 8.5
    End Sub
End Class
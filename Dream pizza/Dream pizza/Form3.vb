Public Class Form3
    Dim amount As Integer
    Public cost As Decimal
    Public totalammount As Decimal
    Dim pizza(1, 11) As Decimal
    Const REGULARPRICE As Decimal = 8.5 'makes the regular price 8.5
    Const GOURMETPRICE As Decimal = REGULARPRICE + 5 'makes the gourmet price the regular price plus 5



    Public Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For p = 0 To 6
            pizza(0, p) = REGULARPRICE  '
        Next

        For p = 7 To 11
            pizza(0, p) = GOURMETPRICE
        Next


        lblTotal.Text = totalammount
        If Form2.txtAddress.Text = "" Then
            lblOrder.Text = "Name: " & Form2.names & "
Phone: " & Form2.phone & "

Total Cost: " & cost & ""
        Else lblOrder.Text = "Name: " & Form2.names & "
Phone: " & Form2.phone & "
Delivery Address: " & Form2.address & ""
        End If

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        Close()  'closes 
        Form2.Show()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Close()
        Form2.Close()
        Form1.Close() 'closes all forms
    End Sub

    Private Sub cmbCheese_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCheese.SelectedIndexChanged
        lblPizzas.Text = ""
        totalammount = Val(lblTotal.Text).ToString("C")
        amount = Val(cmbCheese.Text).ToString("C")

    End Sub

    Private Sub cmbBeef_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBeef.SelectedIndexChanged
        totalammount = Val(lblTotal.Text).ToString("C")
        amount = Val(cmbBeef.Text).ToString("C")
        lblOrder.Text += "
" & cmbBeef.Text & " Beef and Onion $" & amount * REGULARPRICE
        lblTotal.Text = totalammount + amount * REGULARPRICE
    End Sub
End Class
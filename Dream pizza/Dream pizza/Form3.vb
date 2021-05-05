Public Class Form3
    Dim amount As Integer
    Public totalammount As Decimal
    Dim pizza(1, 11) As Decimal
    Const REGULARPRICE As Decimal = 8.5 'makes the regular price 8.5
    Const GOURMETPRICE As Decimal = REGULARPRICE + 5 'makes the gourmet price the regular price plus 5



    Public Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For p = 0 To 6
            pizza(0, p) = REGULARPRICE  'makes the first 7 pizzas the regular price
        Next

        For p = 7 To 11
            pizza(0, p) = GOURMETPRICE  'makes the last 5 pizzas the gourmet price
        Next


        lblTotal.Text = totalammount  'makes the text in the total text box equal the total variable
        If Form2.txtAddress.Text = "" Then
            lblOrder.Text = "Name: " & Form2.names & " 
Phone: " & Form2.phone  'if there is no adress display the name and phone on the order label
        Else lblOrder.Text = "Name: " & Form2.names & "
Phone: " & Form2.phone & "
Delivery Address: " & Form2.address 'also display the address
        End If

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        Close()  'closes form 3
        Form2.Show() 'opens form 2
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Close()
        Form2.Close()
        Form1.Close() 'closes all forms
    End Sub

    Private Sub cmbCheese_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCheese.SelectedIndexChanged
        pizza(1, 1) = Val(cmbCheese.Text) * REGULARPRICE
        lblCheeseCost.Text = pizza(1, 1).ToString("C")

    End Sub

    Private Sub cmbBeef_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBeef.SelectedIndexChanged
        pizza(1, 2) = Val(cmbBeef.Text) * pizza(0, 2)
        lblPizzas.Text = pizza(1, 1) & " " & pizza(1, 2)
    End Sub
End Class
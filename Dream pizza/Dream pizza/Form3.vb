Public Class Form3
    Public totalammount As Decimal
    Public pizza(1, 11) As Decimal
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
        pizza(1, 1) = Val(cmbCheese.Text) * pizza(0, 1)
        lblCheeseCost.Text = pizza(1, 1).ToString("C")

        totalammount = Val(0)
        If Form2.chkDelivery.Checked = True Then
            totalammount = totalammount + Val(3).ToString("C")
        End If
        For price = 0 To 11
            totalammount = totalammount + pizza(1, price)
            lblTotal.Text = "Total Price: " & totalammount.ToString("C")
        Next

    End Sub

    Private Sub cmbBeef_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBeef.SelectedIndexChanged
        pizza(1, 2) = Val(cmbBeef.Text) * pizza(0, 2)
        lblBeefCost.Text = pizza(1, 2).ToString("C")

        totalammount = Val(0)
        If Form2.chkDelivery.Checked = True Then
            totalammount = totalammount + Val(3).ToString("C")
        End If
        For price = 0 To 11
            totalammount = totalammount + pizza(1, price)
            lblTotal.Text = "Total Price: " & totalammount.ToString("C")
        Next

    End Sub

    Private Sub cmbBurger_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBurger.SelectedIndexChanged
        pizza(1, 3) = Val(cmbBurger.Text) * pizza(0, 3)
        lblBurgerCost.Text = pizza(1, 3).ToString("C")

        totalammount = Val(0)
        If Form2.chkDelivery.Checked = True Then
            totalammount = totalammount + Val(3).ToString("C")
        End If
        For price = 0 To 11
            totalammount = totalammount + pizza(1, price)
            lblTotal.Text = "Total Price: " & totalammount.ToString("C")
        Next
    End Sub

    Private Sub cmbHawaiian_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbHawaiian.SelectedIndexChanged
        pizza(1, 4) = Val(cmbHawaiian.Text) * pizza(0, 4)
        lblHawaiianCost.Text = pizza(1, 4).ToString("C")

        totalammount = Val(0)
        If Form2.chkDelivery.Checked = True Then
            totalammount = totalammount + Val(3).ToString("C")
        End If
        For price = 0 To 11
            totalammount = totalammount + pizza(1, price)
            lblTotal.Text = "Total Price: " & totalammount.ToString("C")
        Next
    End Sub

    Private Sub cmbPepperoni_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPepperoni.SelectedIndexChanged
        pizza(1, 5) = Val(cmbPepperoni.Text) * pizza(0, 5)
        lblPepperoniCost.Text = pizza(1, 5).ToString("C")

        totalammount = Val(0)
        If Form2.chkDelivery.Checked = True Then
            totalammount = totalammount + Val(3).ToString("C")
        End If
        For price = 0 To 11
            totalammount = totalammount + pizza(1, price)
            lblTotal.Text = "Total Price: " & totalammount.ToString("C")
        Next
    End Sub

    Private Sub cmbMeat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMeat.SelectedIndexChanged
        pizza(1, 6) = Val(cmbMeat.Text) * pizza(0, 6)
        lblMeatCost.Text = pizza(1, 6).ToString("C")

        totalammount = Val(0)
        If Form2.chkDelivery.Checked = True Then
            totalammount = totalammount + Val(3).ToString("C")
        End If
        For price = 0 To 11
            totalammount = totalammount + pizza(1, price)
            lblTotal.Text = "Total Price: " & totalammount.ToString("C")
        Next
    End Sub

    Private Sub cmbSupreme_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSupreme.SelectedIndexChanged
        pizza(1, 6) = Val(cmbSupreme.Text) * pizza(0, 6)
        lblSupremeCost.Text = pizza(1, 6).ToString("C")

        totalammount = Val(0)
        If Form2.chkDelivery.Checked = True Then
            totalammount = totalammount + Val(3).ToString("C")
        End If
        For price = 0 To 11
            totalammount = totalammount + pizza(1, price)
            lblTotal.Text = "Total Price: " & totalammount.ToString("C")
        Next
    End Sub

    Private Sub cmbParmesean_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbParmesean.SelectedIndexChanged
        pizza(1, 7) = Val(cmbParmesean.Text) * pizza(0, 7)
        lblParmesanCost.Text = pizza(1, 7).ToString("C")

        totalammount = Val(0)
        If Form2.chkDelivery.Checked = True Then
            totalammount = totalammount + Val(3).ToString("C")
        End If
        For price = 0 To 11
            totalammount = totalammount + pizza(1, price)
            lblTotal.Text = "Total Price: " & totalammount.ToString("C")
        Next
    End Sub

    Private Sub cmbMegaMeat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMegaMeat.SelectedIndexChanged
        pizza(1, 8) = Val(cmbMegaMeat.Text) * pizza(0, 8)
        lblMegaCost.Text = pizza(1, 8).ToString("C")

        totalammount = Val(0)
        If Form2.chkDelivery.Checked = True Then
            totalammount = totalammount + Val(3).ToString("C")
        End If
        For price = 0 To 11
            totalammount = totalammount + pizza(1, price)
            lblTotal.Text = "Total Price: " & totalammount.ToString("C")
        Next
    End Sub

    Private Sub cmbMegaPepperoni_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMegaPepperoni.SelectedIndexChanged
        pizza(1, 9) = Val(cmbMegaPepperoni.Text) * pizza(0, 9)
        lblMeggaPepperoniCost.Text = pizza(1, 9).ToString("C")

        totalammount = Val(0)
        If Form2.chkDelivery.Checked = True Then
            totalammount = totalammount + Val(3).ToString("C")
        End If
        For price = 0 To 11
            totalammount = totalammount + pizza(1, price)
            lblTotal.Text = "Total Price: " & totalammount.ToString("C")
        Next
    End Sub

    Private Sub cmbOlive_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbOlive.SelectedIndexChanged
        pizza(1, 10) = Val(cmbOlive.Text) * pizza(0, 10)
        lblOliveCost.Text = pizza(1, 10).ToString("C")

        totalammount = Val(0)
        If Form2.chkDelivery.Checked = True Then
            totalammount = totalammount + Val(3).ToString("C")
        End If
        For price = 0 To 11
            totalammount = totalammount + pizza(1, price)
            lblTotal.Text = "Total Price: " & totalammount.ToString("C")
        Next
    End Sub

    Private Sub cmbNewYorkCheese_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNewYorkCheese.SelectedIndexChanged
        pizza(1, 11) = Val(cmbNewYorkCheese.Text) * pizza(0, 11)
        lblNewYorkerCost.Text = pizza(1, 11).ToString("C")

        totalammount = Val(0)
        If Form2.chkDelivery.Checked = True Then
            totalammount = totalammount + Val(3).ToString("C")
        End If
        For price = 0 To 11
            totalammount = totalammount + pizza(1, price)
            lblTotal.Text = "Total Price: " & totalammount.ToString("C")
        Next


    End Sub

    Private Sub btnSummary_Click(sender As Object, e As EventArgs) Handles btnSummary.Click
        Form4.lblSummary1.Text = "Customer Details" & vbCrLf
        Form4.lblSummary1.Text = Form4.lblSummary1.Text & Form3.
        For x = 0 To 11
            If pizza Then
        Next
    End Sub

    Private Sub lblTotal_Click(sender As Object, e As EventArgs) Handles lblTotal.Click

    End Sub
End Class
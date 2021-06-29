Public Class Form3
    Public totalammount As Decimal
    Public pizza(2, 11) As Decimal
    Public pizzanames(0, 11) As String
    Const REGULARPRICE As Decimal = 8.5 'makes the regular price 8.5
    Const GOURMETPRICE As Decimal = REGULARPRICE + 5 'makes the gourmet price the regular price plus 5



    Public Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        pizzanames(0, 0) = "Cheese"
        pizzanames(0, 1) = "Beef"
        pizzanames(0, 2) = "Burger"
        pizzanames(0, 3) = "Hawaiian"
        pizzanames(0, 4) = "Pepperoni"
        pizzanames(0, 5) = "Meat"
        pizzanames(0, 6) = "Supreme"
        pizzanames(0, 7) = "Parmesan"
        pizzanames(0, 8) = "Mega Meat"
        pizzanames(0, 9) = "Mega Pepperoni"
        pizzanames(0, 10) = "Olive"
        pizzanames(0, 11) = "New Yorker Cheese"
        'puts all of the pizza names into an array that is used for the summary


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
        pizza(2, 0) = Val(cmbCheese.Text)
        pizza(1, 0) = pizza(2, 0) * pizza(0, 0)
        lblCheeseCost.Text = pizza(1, 0).ToString("C")

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
        pizza(2, 1) = Val(cmbBeef.Text)
        pizza(1, 1) = pizza(2, 1) * pizza(0, 1)
        lblBeefCost.Text = pizza(1, 1).ToString("C")

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
        pizza(2, 2) = Val(cmbBurger.Text)
        pizza(1, 2) = pizza(2, 2) * pizza(0, 2)
        lblBurgerCost.Text = pizza(1, 2).ToString("C")

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
        pizza(2, 3) = Val(cmbHawaiian.Text)
        pizza(1, 3) = pizza(2, 3) * pizza(0, 3)
        lblHawaiianCost.Text = pizza(1, 3).ToString("C")

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
        pizza(2, 4) = Val(cmbPepperoni.Text)
        pizza(1, 4) = pizza(2, 4) * pizza(0, 4)
        lblPepperoniCost.Text = pizza(1, 4).ToString("C")

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
        pizza(2, 5) = Val(cmbMeat.Text)
        pizza(1, 5) = pizza(2, 5) * pizza(0, 5)
        lblMeatCost.Text = pizza(1, 5).ToString("C")

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
        pizza(2, 6) = Val(cmbSupreme.Text)
        pizza(1, 6) = pizza(2, 6) * pizza(0, 6)
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
        pizza(2, 7) = Val(cmbParmesean.Text)
        pizza(1, 7) = pizza(2, 7) * pizza(0, 7)
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
        pizza(2, 8) = Val(cmbMegaMeat.Text)
        pizza(1, 8) = pizza(2, 8) * pizza(0, 8)
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
        pizza(2, 9) = Val(cmbMegaPepperoni.Text)
        pizza(1, 9) = pizza(2, 9) * pizza(0, 9)
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
        pizza(2, 10) = Val(cmbOlive.Text)
        pizza(1, 10) = pizza(2, 10) * pizza(0, 10)
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
        pizza(2, 11) = Val(cmbNewYorkCheese.Text)
        pizza(1, 11) = pizza(2, 11) * pizza(0, 11)
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
        Form4.lblSummaryCustomer.Text = "Customer Details" & vbCrLf & vbCrLf  'adds the text "Customer Details" to the customer data label on Form4 and skips a line
        Form4.lblSummaryCustomer.Text = Form4.lblSummaryCustomer.Text & "Name: " & Form2.names & vbCrLf 'adds a line showing the customers name
        Form4.lblSummaryCustomer.Text = Form4.lblSummaryCustomer.Text & "Phone: " & Form2.phone & vbCrLf 'adds a line showing the customers phone number
        If Form2.chkDelivery.Checked = True Then
            Form4.lblSummaryCustomer.Text = Form4.lblSummaryCustomer.Text & "Address: " & Form2.address 'if the delivery checkbox is checked in Form2 then a live showing the customers address will be shown
        End If

        Form4.lblSummaryPizzaNames.Text = "Pizza" & vbCrLf & vbCrLf 'Adds the title "Pizza" to the pizza names label and adds a gap
        Form4.lblSummaryQuantity.Text = "Quantity" & vbCrLf & vbCrLf 'Adds the title "Quantity" to the pizza quantities label and adds a gap
        Form4.lblSummaryPrice.Text = "Cost" & vbCrLf & vbCrLf 'Adds the title "Cost" to the pizza costs label and adds a gap

        For x = 0 To 11
            If pizza(1, x) > 0 Then
                Form4.lblSummaryPizzaNames.Text = Form4.lblSummaryPizzaNames.Text & pizzanames(0, x) & vbCrLf
                Form4.lblSummaryQuantity.Text = Form4.lblSummaryQuantity.Text & pizza(2, x) & vbCrLf
                Form4.lblSummaryPrice.Text = Form4.lblSummaryPrice.Text & pizza(1, x).ToString("C") & vbCrLf
            End If
        Next
        Form4.lblSummaryPrice.Text = Form4.lblSummaryPrice.Text & vbCrLf & "Total Cost: " & totalammount.ToString("C")
        Form4.Show()
    End Sub

    Private Sub lblTotal_Click(sender As Object, e As EventArgs) Handles lblTotal.Click

    End Sub
End Class
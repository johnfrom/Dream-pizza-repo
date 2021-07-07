Public Class Form3
    Public totalammount As Decimal 'variable used to store the total cost
    Public pizza(2, 11) As Decimal 'array used for storing the prices, quantitys ordered and total cost for each pizza flavor
    Public pizzanames(0, 11) As String 'array used to store the names of the pizzas
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

        If Form2.txtAddress.Text = "" Then
            lblOrder.Text = "Name: " & Form2.names & " 
Phone: " & Form2.phone  'if there is no adress display the name and phone on the order label
        Else lblOrder.Text = "Name: " & Form2.names & "
Phone: " & Form2.phone & "
Delivery Address: " & Form2.address 'also display the address
        End If

    End Sub

    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        Close()  'closes form 3
        Form2.Show() 'opens form 2
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        End 'closes all forms
    End Sub

    Private Sub cmbCheese_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCheese.SelectedIndexChanged
        pizza(2, 0) = Val(cmbCheese.Text) 'the ammount of pizzas selected in the combo box is converted to a value so it can be used in calculations
        pizza(1, 0) = pizza(2, 0) * pizza(0, 0) 'the result of the price of the pizza times the ammount of pizzas selected is stored in the array
        lblCheeseCost.Text = pizza(1, 0).ToString("C") 'the result of the calculation above is displayed 

        totalammount = Val(0) 'resets the total ammount to 0
        If Form2.chkDelivery.Checked = True Then 'checks if the deliver checkbox is checked
            totalammount = totalammount + Val(3).ToString("C") 'adds $3 to the total ammount if the deliver checkbox is ticked
        End If
        For price = 0 To 11
            totalammount = totalammount + pizza(1, price) 'adds all of the single pizza cost totals to the grand total
            lblTotal.Text = "Total Price: " & totalammount.ToString("C") 'turns the total ammount into a currency and displays it on the form
        Next
    End Sub

    Private Sub cmbBeef_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBeef.SelectedIndexChanged
        pizza(2, 1) = Val(cmbBeef.Text) 'the ammount of pizzas selected in the combo box is converted to a value so it can be used in calculations
        pizza(1, 1) = pizza(2, 1) * pizza(0, 1) 'the result of the price of the pizza times the ammount of pizzas selected is stored in the array
        lblBeefCost.Text = pizza(1, 1).ToString("C")

        totalammount = Val(0) 'resets the total ammount to 0
        If Form2.chkDelivery.Checked = True Then 'checks if the deliver checkbox is checked
            totalammount = totalammount + Val(3).ToString("C") 'adds $3 to the total ammount if the deliver checkbox is ticked
        End If
        For price = 0 To 11
            totalammount = totalammount + pizza(1, price) 'adds all of the single pizza cost totals to the grand total
            lblTotal.Text = "Total Price: " & totalammount.ToString("C") 'turns the total ammount into a currency and displays it on the form
        Next
    End Sub

    Private Sub cmbBurger_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBurger.SelectedIndexChanged
        pizza(2, 2) = Val(cmbBurger.Text) 'the ammount of pizzas selected in the combo box is converted to a value so it can be used in calculations
        pizza(1, 2) = pizza(2, 2) * pizza(0, 2) 'the result of the price of the pizza times the ammount of pizzas selected is stored in the array
        lblBurgerCost.Text = pizza(1, 2).ToString("C") 'the result of the calculation above is displayed 

        totalammount = Val(0) 'resets the total ammount to 0
        If Form2.chkDelivery.Checked = True Then 'checks if the deliver checkbox is checked
            totalammount = totalammount + Val(3).ToString("C") 'adds $3 to the total ammount if the deliver checkbox is ticked
        End If
        For price = 0 To 11
            totalammount = totalammount + pizza(1, price) 'adds all of the single pizza cost totals to the grand total
            lblTotal.Text = "Total Price: " & totalammount.ToString("C") 'turns the total ammount into a currency and displays it on the form
        Next
    End Sub

    Private Sub cmbHawaiian_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbHawaiian.SelectedIndexChanged
        pizza(2, 3) = Val(cmbHawaiian.Text) 'the ammount of pizzas selected in the combo box is converted to a value so it can be used in calculations
        pizza(1, 3) = pizza(2, 3) * pizza(0, 3) 'the result of the price of the pizza times the ammount of pizzas selected is stored in the array
        lblHawaiianCost.Text = pizza(1, 3).ToString("C") 'the result of the calculation above is displayed 

        totalammount = Val(0) 'resets the total ammount to 0
        If Form2.chkDelivery.Checked = True Then 'checks if the deliver checkbox is checked
            totalammount = totalammount + Val(3).ToString("C") 'adds $3 to the total ammount if the deliver checkbox is ticked
        End If
        For price = 0 To 11
            totalammount = totalammount + pizza(1, price) 'adds all of the single pizza cost totals to the grand total
            lblTotal.Text = "Total Price: " & totalammount.ToString("C") 'turns the total ammount into a currency and displays it on the form
        Next
    End Sub

    Private Sub cmbPepperoni_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPepperoni.SelectedIndexChanged
        pizza(2, 4) = Val(cmbPepperoni.Text) 'the ammount of pizzas selected in the combo box is converted to a value so it can be used in calculations
        pizza(1, 4) = pizza(2, 4) * pizza(0, 4) 'the result of the price of the pizza times the ammount of pizzas selected is stored in the array
        lblPepperoniCost.Text = pizza(1, 4).ToString("C") 'the result of the calculation above is displayed 

        totalammount = Val(0) 'resets the total ammount to 0
        If Form2.chkDelivery.Checked = True Then 'checks if the deliver checkbox is checked
            totalammount = totalammount + Val(3).ToString("C") 'adds $3 to the total ammount if the deliver checkbox is ticked
        End If
        For price = 0 To 11
            totalammount = totalammount + pizza(1, price) 'adds all of the single pizza cost totals to the grand total
            lblTotal.Text = "Total Price: " & totalammount.ToString("C") 'turns the total ammount into a currency and displays it on the form
        Next
    End Sub

    Private Sub cmbMeat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMeat.SelectedIndexChanged
        pizza(2, 5) = Val(cmbMeat.Text) 'the ammount of pizzas selected in the combo box is converted to a value so it can be used in calculations
        pizza(1, 5) = pizza(2, 5) * pizza(0, 5) 'the result of the price of the pizza times the ammount of pizzas selected is stored in the array
        lblMeatCost.Text = pizza(1, 5).ToString("C") 'the result of the calculation above is displayed 

        totalammount = Val(0) 'resets the total ammount to 0
        If Form2.chkDelivery.Checked = True Then 'checks if the deliver checkbox is checked
            totalammount = totalammount + Val(3).ToString("C") 'adds $3 to the total ammount if the deliver checkbox is ticked
        End If
        For price = 0 To 11
            totalammount = totalammount + pizza(1, price) 'adds all of the single pizza cost totals to the grand total
            lblTotal.Text = "Total Price: " & totalammount.ToString("C") 'turns the total ammount into a currency and displays it on the form
        Next
    End Sub

    Private Sub cmbSupreme_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSupreme.SelectedIndexChanged
        pizza(2, 6) = Val(cmbSupreme.Text) 'the ammount of pizzas selected in the combo box is converted to a value so it can be used in calculations
        pizza(1, 6) = pizza(2, 6) * pizza(0, 6) 'the result of the price of the pizza times the ammount of pizzas selected is stored in the array
        lblSupremeCost.Text = pizza(1, 6).ToString("C") 'the result of the calculation above is displayed 

        totalammount = Val(0) 'resets the total ammount to 0
        If Form2.chkDelivery.Checked = True Then 'checks if the deliver checkbox is checked
            totalammount = totalammount + Val(3).ToString("C") 'adds $3 to the total ammount if the deliver checkbox is ticked
        End If
        For price = 0 To 11
            totalammount = totalammount + pizza(1, price) 'adds all of the single pizza cost totals to the grand total
            lblTotal.Text = "Total Price: " & totalammount.ToString("C") 'turns the total ammount into a currency and displays it on the form
        Next
    End Sub

    Private Sub cmbParmesean_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbParmesean.SelectedIndexChanged
        pizza(2, 7) = Val(cmbParmesean.Text) 'the ammount of pizzas selected in the combo box is converted to a value so it can be used in calculations
        pizza(1, 7) = pizza(2, 7) * pizza(0, 7) 'the result of the price of the pizza times the ammount of pizzas selected is stored in the array
        lblParmesanCost.Text = pizza(1, 7).ToString("C") 'the result of the calculation above is displayed 

        totalammount = Val(0) 'resets the total ammount to 0
        If Form2.chkDelivery.Checked = True Then 'checks if the deliver checkbox is checked
            totalammount = totalammount + Val(3).ToString("C") 'adds $3 to the total ammount if the deliver checkbox is ticked
        End If
        For price = 0 To 11
            totalammount = totalammount + pizza(1, price) 'adds all of the single pizza cost totals to the grand total
            lblTotal.Text = "Total Price: " & totalammount.ToString("C") 'turns the total ammount into a currency and displays it on the form
        Next
    End Sub

    Private Sub cmbMegaMeat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMegaMeat.SelectedIndexChanged
        pizza(2, 8) = Val(cmbMegaMeat.Text) 'the ammount of pizzas selected in the combo box is converted to a value so it can be used in calculations
        pizza(1, 8) = pizza(2, 8) * pizza(0, 8) 'the result of the price of the pizza times the ammount of pizzas selected is stored in the array
        lblMegaCost.Text = pizza(1, 8).ToString("C") 'the result of the calculation above is displayed 

        totalammount = Val(0) 'resets the total ammount to 0
        If Form2.chkDelivery.Checked = True Then 'checks if the deliver checkbox is checked
            totalammount = totalammount + Val(3).ToString("C") 'adds $3 to the total ammount if the deliver checkbox is ticked
        End If
        For price = 0 To 11
            totalammount = totalammount + pizza(1, price) 'adds all of the single pizza cost totals to the grand total
            lblTotal.Text = "Total Price: " & totalammount.ToString("C") 'turns the total ammount into a currency and displays it on the form
        Next
    End Sub

    Private Sub cmbMegaPepperoni_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMegaPepperoni.SelectedIndexChanged
        pizza(2, 9) = Val(cmbMegaPepperoni.Text) 'the ammount of pizzas selected in the combo box is converted to a value so it can be used in calculations
        pizza(1, 9) = pizza(2, 9) * pizza(0, 9) 'the result of the price of the pizza times the ammount of pizzas selected is stored in the array
        lblMeggaPepperoniCost.Text = pizza(1, 9).ToString("C") 'the result of the calculation above is displayed 

        totalammount = Val(0) 'resets the total ammount to 0
        If Form2.chkDelivery.Checked = True Then 'checks if the deliver checkbox is checked
            totalammount = totalammount + Val(3).ToString("C") 'adds $3 to the total ammount if the deliver checkbox is ticked
        End If
        For price = 0 To 11
            totalammount = totalammount + pizza(1, price) 'adds all of the single pizza cost totals to the grand total
            lblTotal.Text = "Total Price: " & totalammount.ToString("C") 'turns the total ammount into a currency and displays it on the form
        Next
    End Sub

    Private Sub cmbOlive_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbOlive.SelectedIndexChanged
        pizza(2, 10) = Val(cmbOlive.Text) 'the ammount of pizzas selected in the combo box is converted to a value so it can be used in calculations
        pizza(1, 10) = pizza(2, 10) * pizza(0, 10) 'the result of the price of the pizza times the ammount of pizzas selected is stored in the array
        lblOliveCost.Text = pizza(1, 10).ToString("C") 'the result of the calculation above is displayed 

        totalammount = Val(0) 'resets the total ammount to 0
        If Form2.chkDelivery.Checked = True Then 'checks if the deliver checkbox is checked
            totalammount = totalammount + Val(3).ToString("C") 'adds $3 to the total ammount if the deliver checkbox is ticked
        End If
        For price = 0 To 11
            totalammount = totalammount + pizza(1, price) 'adds all of the single pizza cost totals to the grand total
            lblTotal.Text = "Total Price: " & totalammount.ToString("C") 'turns the total ammount into a currency and displays it on the form
        Next
    End Sub

    Private Sub cmbNewYorkCheese_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNewYorkCheese.SelectedIndexChanged
        pizza(2, 11) = Val(cmbNewYorkCheese.Text) 'the ammount of pizzas selected in the combo box is converted to a value so it can be used in calculations
        pizza(1, 11) = pizza(2, 11) * pizza(0, 11) 'the result of the price of the pizza times the ammount of pizzas selected is stored in the array
        lblNewYorkerCost.Text = pizza(1, 11).ToString("C") 'the result of the calculation above is displayed 

        totalammount = Val(0) 'resets the total ammount to 0
        If Form2.chkDelivery.Checked = True Then 'checks if the deliver checkbox is checked
            totalammount = totalammount + Val(3).ToString("C") 'adds $3 to the total ammount if the deliver checkbox is ticked
        End If
        For price = 0 To 11
            totalammount = totalammount + pizza(1, price) 'adds all of the single pizza cost totals to the grand total
            lblTotal.Text = "Total Price: " & totalammount.ToString("C") 'turns the total ammount into a currency and displays it on the form
        Next
    End Sub

    Private Sub btnSummary_Click(sender As Object, e As EventArgs) Handles btnSummary.Click
        Form4.lblSummaryCustomer.Text = "Customer Details" & vbCrLf & vbCrLf  'adds the text "Customer Details" to the customer data label on Form4 and skips a line
        Form4.lblSummaryCustomer.Text = Form4.lblSummaryCustomer.Text & "Name: " & Form2.names & vbCrLf 'adds a line showing the customers name
        Form4.lblSummaryCustomer.Text = Form4.lblSummaryCustomer.Text & "Phone: " & Form2.phone & vbCrLf 'adds a line showing the customers phone number
        If Form2.chkDelivery.Checked = True Then
            Form4.lblSummaryCustomer.Text = Form4.lblSummaryCustomer.Text & "Address: " & Form2.address 'if the delivery checkbox is checked in Form2 then a line showing the customers address will be shown
        End If
        Form4.lblSummaryCustomer.Text = Form4.lblSummaryCustomer.Text & "



" & "Total Price: " & totalammount.ToString("C")  'skips a few lines then displays the total price in the customer details label

        Form4.lblSummaryPizzaNames.Text = "Pizza" & vbCrLf & vbCrLf 'Adds the title "Pizza" to the pizza names label and adds a gap
        Form4.lblSummaryQuantity.Text = "Quantity" & vbCrLf & vbCrLf 'Adds the title "Quantity" to the pizza quantities label and adds a gap
        Form4.lblSummaryPrice.Text = "Cost" & vbCrLf & vbCrLf 'Adds the title "Cost" to the pizza costs label and adds a gap

        For x = 0 To 11
            If pizza(1, x) > 0 Then  'if 1 or more of a pizza flavor is selected
                Form4.lblSummaryPizzaNames.Text = Form4.lblSummaryPizzaNames.Text & pizzanames(0, x) & vbCrLf 'display that pizza flavor's name in the left summary label
                Form4.lblSummaryQuantity.Text = Form4.lblSummaryQuantity.Text & pizza(2, x) & vbCrLf 'display the quantity of that pizza flavor that the customer selected in the middle summary label 
                Form4.lblSummaryPrice.Text = Form4.lblSummaryPrice.Text & pizza(1, x).ToString("C") & vbCrLf 'display the price of however many pizzas were ordered in the right summary label
            End If
        Next
        Me.Hide() 'hide the pizza ordering form
        Form4.Show() 'display the summary form
    End Sub
End Class

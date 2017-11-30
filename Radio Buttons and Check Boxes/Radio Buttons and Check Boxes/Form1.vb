Public Class Form1

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles radSandwhich.CheckedChanged

    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        Dim dblBurger As Double = 6.99
        Dim dblTomato As Double = 0.5
        Dim dblFries As Double = 1.99
        Dim Total As Double
        If radCheese.Checked = True Then
            lblResult.Text = "You selected Cheese Burger"
        ElseIf radChicken.Checked = True Then
            lblResult.Text = "You selected Chicken Patty"
        ElseIf radHam.Checked = True Then
            lblResult.Text = "You selected Hamburger"
            Total = dblBurger = Total
        ElseIf radSandwhich.Checked = True Then
            lblResult.Text = "You selected Cheese SandWhich"
        End If

        If chkTomato.Checked = True Then
            lblResult.Text &= " , and  Tomato"
            Total = dblTomato + Total
        End If
        If chkLettuce.Checked = True Then
            lblResult.Text &= " , and Lettuce"
        End If
        If chkMayo.Checked = True Then
            lblResult.Text &= " , and Mayo"
        End If
        If chkFires.Checked = True Then
            lblResult.Text &= " , and Fires"
        End If

        If radFires.Checked = True Then
            lblResult.Text &= "Awesome"
            Total = dblFries + Total
        End If
        If radFruit.Checked = True Then
            lblResult.Text &= "What"
        End If
        If radWings.Checked = True Then
            lblResult.Text &= "MMM"
        End If



    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class

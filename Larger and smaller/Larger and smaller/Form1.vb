Public Class Form1

    Private Sub btnCompare_Click(sender As Object, e As EventArgs) Handles btnCompare.Click
        Dim dblValue, dblValue2 As Double
        Try
            dblValue = CDbl(txtA.Text)
            dblValue2 = CDbl(txtB.Text)

            If (dblValue > dblValue2) Then
                lblResult.Text = "Value A is greater than Value B!"
            Else
                lblResult.Text = "Value A is less than Value B!"
            End If
            If (dblValue = dblValue2) Then
                lblResult.Text = "Value A is equal to Value B!"
            End If
        Catch ex As Exception
            lblResult.Text = "Values must be numeric!!!"
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class

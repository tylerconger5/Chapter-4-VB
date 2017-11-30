Public Class Form1

    Private Sub btnResults_Click(sender As Object, e As EventArgs) Handles btnResults.Click
        Dim dblTime1, dblTime2, DblTime3 As Double

        dblTime1 = txtTime1.Text
        dblTime2 = txtName2.Text
        DblTime3 = txtName3.Text

        If dblTime1 < dblTime2 And dblTime1 < DblTime3 Then
            lblResult.Text = txtName1.Text
            If dblTime2 < DblTime3 Then
                lblResult2.Text = txtName2.Text
                lblResult3.Text = txtName3.Text
            ElseIf DblTime3 < dblTime2 Then
                lblResult2.Text = txtName3.Text
                lblResult3.Text = txtName2.Text

            End If

        End If
        If dblTime2 < dblTime1 And dblTime2 < dblTime1 Then
            lblResult.Text = txtName2.Text

        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

    End Sub
End Class

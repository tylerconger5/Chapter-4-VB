Public Class Form1

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles lblResult.Click

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblScore1, dblScore2, dblScore3, dblAverage As Double

        Const Num_Scores As Integer = 3
        Const dblHigh_Scores As Double = 95.0

        Try
            dblScore1 = CDbl(txtScore1.Text)
            dblScore2 = CDbl(txtScore2.Text)
            dblSCore3 = CDbl(txtScore3.Text)
            dblAverage = (dblScore1 + dblScore2 + dblScore3) / Num_Scores
            ' Display the average, runded to decimal places. 
            lblResult.Text = dblAverage.ToString("n2")

            'Dispaly the letter grade.
            If dblAverage < 60 Then
                lblGrade.Text = "F"
            ElseIf dblAverage < 70 Then
                lblGrade.Text = "D"
            ElseIf dblAverage < 80 Then
                lblGrade.Text = "C"
            ElseIf dblAverage < 90 Then
                lblGrade.Text = "B"
            ElseIf dblAverage <= 100 Then
                lblGrade.Text = "A"
            End If

            ' If the score is high give the student prasie.
            ' Otherwise, give some encouragemnt.
            lblResult.Text = dblAverage.ToString("n2")
            If dblAverage > dblHigh_Scores Then
                lblMessage.Text = ("Congratuations! Great Job!")
            Else
                lblMessage.Text = "Keep trying!"



            End If
        Catch ex As Exception
            ' Dispaly an eror message.
            lblMessage.Text = ("score must be numeric")

        End Try
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class

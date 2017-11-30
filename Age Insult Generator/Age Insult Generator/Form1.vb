Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnInsult_Click(sender As Object, e As EventArgs) Handles btnInsult.Click
        Dim intAge As Integer

        Try
            If intAge < 10 Then
                lblResult.Text = "Can you even Read?"
            ElseIf intAge >= 10 And intAge < 14 Then
                lblResult.Text = "There are no words to express how naive you are."
            ElseIf intAge >= 14 And intAge < 18 Then
                lblResult.Text = "You have no clue how the real world works"
            ElseIf intAge >= 18 And intAge < 24 Then
                lblResult.Text = "Good job you're an adult"
            ElseIf intAge >= 24 And intAge < 30 Then
                lblResult.Text = "I bet you still live your parents"
            ElseIf intAge >= 30 And intAge < 40 Then
                lblResult.Text = "Please tell me you are out of your parents basement"
            ElseIf intAge >= 60 Then
                lblResult.Text = "Good job you are almost done with life"

            End If

        Catch ex As Exception
            lblMessage.Text = "Enter a numeric value"
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAge.Clear()

    End Sub

    Private Sub lblResult_Click(sender As Object, e As EventArgs) Handles lblResult.Click

    End Sub
End Class

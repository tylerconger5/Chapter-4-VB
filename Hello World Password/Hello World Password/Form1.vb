Public Class Form1

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim password As String

        Try
            password = CStr("Dog")
            If txtAnswer.Text = password Then
                lblResult.Text = "Correct"
            Else
                lblResult.Text = "Password is incorrect!!"
            End If

        Catch ex As Exception


        End Try

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class

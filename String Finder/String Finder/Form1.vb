Public Class Form1

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblString.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim instartIndex As Integer
        Dim intfoundIndex As Integer

        If IsNumeric(txtStartIndex.Text) Then
            If txtToFind.Text.Length > 0 Then
                intStartIndex = CInt(txtStartIndex.Text)
                intfoundIndex = lblString.Text.IndexOf(txtToFind > Text, IntStartIndex)
            End If
            If intfoundIndex = -1 Then
                lblResult.Text("The string was not found fool")
            Else
                lblResult.Text("the string was found at index " & intfoundIndex)
            End If
        Else
            MessageBox()
        End If
    End Sub
End Class

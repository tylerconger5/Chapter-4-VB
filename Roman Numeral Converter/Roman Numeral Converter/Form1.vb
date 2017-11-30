Public Class Form1

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim intNumeral As Integer
        Try
            intNumeral = CInt(txtInteger.Text)
            Select Case intNumeral
                Case Is = 1
                    lblResult.Text = "I"
                Case Is = 2
                    lblResult.Text = "II"
                Case Is = 3
                    lblResult.Text = "III"
                Case Is = 4
                    lblResult.Text = "IV"
                Case Is = 5
                    lblResult.Text = "V"
                Case Is = 6
                    lblResult.Text = "VI"
                Case Is = 7
                    lblResult.Text = "VII"
                Case Is = 8
                    lblResult.Text = "VIII"
                Case Is = 9
                    lblResult.Text = "IX"
                Case Is = 10
                    lblResult.Text = "X"

            End Select

            If (intNumeral > 10 Or intNumeral < 1) Then
                lblResult.Text = "Conversion is not available"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class

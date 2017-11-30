Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim strInput As String 'Hold selected from list  boxes

        If listColor.SelectedIndex = -1 Then
            MessageBox.Show("Select a color.")
        ElseIf listEst.SelectedIndex = -1 Then
            MessageBox.Show("No word ending in Est was selected.")

        End If


        strInput = listColor.SelectedItem.ToString() & "Dragon is the " &
             listEst.SelectedItem.ToString() & " Dragon of all. It has " & ListNumber.SelectedItem.ToString() &
            " " & listBodyPart.SelectedItem.ToString & " , and a " &
            listAnimal.SelectedItem.ToString() & " shaped like a " &
         listNoun.SelectedItem.ToString() & " The Dragon has a " &
        listPluralNoun.SelectedItem.ToString() & " He has multiple "


        MessageBox.Show("The " & strInput & " , although it will feast on nearly anything.")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        listColor.SelectedIndex = -1
        listAnimal.SelectedIndex = -1
        listBodyPart.SelectedIndex = -1
        listColor.SelectedIndex = -1
        listEst.SelectedIndex = -1
        listNoun.SelectedIndex = -1
        ListNumber.SelectedIndex = -1
    End Sub
End Class

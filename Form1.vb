Public Class Form1
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim YourMessage As String
        Dim BirthYear As Integer
        YourMessage = "Happy bday! How old are you now?"

        MessageBox.Show(YourMessage)
        BirthYear = Val(InputBox("Enter Year of birth"))
        MessageBox.Show("You are now " & 2023 - BirthYear & " years old")
    End Sub
End Class

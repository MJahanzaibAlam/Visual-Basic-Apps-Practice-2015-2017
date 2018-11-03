Public Class DoUntil

    Private Sub btnPass_Click(sender As System.Object, e As System.EventArgs) Handles btnPass.Click
        Dim Password, InputPassword As String
        Dim Attempt As Integer
        Password = "secret"
        Attempt = 0
        Do
            Attempt = Attempt + 1
            InputPassword = InputBox("This is attempt number " & Attempt & " of 3", "Enter Password")
        Loop Until (Attempt = 3) Or (InputPassword = Password)
        If InputPassword = Password Then
            MsgBox("Password is valid", MsgBoxStyle.Information, "Access Granted")
        Else
            MsgBox("Invalid Password", MsgBoxStyle.Exclamation, "Invalid Password")
        End If
    End Sub
End Class

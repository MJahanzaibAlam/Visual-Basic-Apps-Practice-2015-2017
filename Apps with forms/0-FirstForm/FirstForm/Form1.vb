Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Label1.Text = "Hello world"
    End Sub

    Private Sub BtnToggle_Click(sender As System.Object, e As System.EventArgs) Handles BtnToggle.Click
        If BtnToggle.Text = "Turn off" Then
            Pbox1.Visible = False
            BtnToggle.Text = "Turn On"
        Else
            Pbox1.Visible = True
            BtnToggle.Text = "Turn off"
        End If
    End Sub
End Class

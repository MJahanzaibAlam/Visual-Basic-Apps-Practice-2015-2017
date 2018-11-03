Public Class Form1

    Private Sub radLightOn_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radLightOn.CheckedChanged
        pic3.Visible = False
        pic2.Visible = True
        lblStatus.Text = "Light is on"
    End Sub

    Private Sub radLightOff_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radLightOff.CheckedChanged
        pic2.Visible = False
        pic3.Visible = True
        lblStatus.Text = "Light is off"
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class

Public Class Form1

    Private Sub btnSelectPicture_Click(sender As System.Object, e As System.EventArgs) Handles btnSelectPicture.Click
        If ofdSelectPicture.ShowDialog = Windows.Forms.DialogResult.OK Then
            picShowPicture.Image = Image.FromFile(ofdSelectPicture.FileName)
            Me.Text = "Picture Viewer(" & ofdSelectPicture.FileName & ")"
        End If
    End Sub

    Private Sub btnQuit_Click(sender As System.Object, e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub
End Class

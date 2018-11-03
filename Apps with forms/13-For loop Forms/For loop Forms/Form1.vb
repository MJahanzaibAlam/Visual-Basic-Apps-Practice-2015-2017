Public Class ForLoop
    Private Sub btnLoop_Click(sender As System.Object, e As System.EventArgs) Handles btnLoop.Click
        For number = 1 To 100
            lstLoopbox.Items.Add(number)
        Next
    End Sub
End Class

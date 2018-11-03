Public Class DoWhileMultiplication

    Private Sub btnLoop_Click(sender As System.Object, e As System.EventArgs) Handles btnLoop.Click
        Dim Number As Integer = 5
        Do While Number <> 10
            lstNumber.Items.Add(Number * Number)
            Number = Number + 1
        Loop
    End Sub
End Class

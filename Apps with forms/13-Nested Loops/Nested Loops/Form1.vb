Public Class Form1

    Private Sub btnLoop_Click(sender As System.Object, e As System.EventArgs) Handles btnLoop.Click
        Dim outerNum As Integer
        Dim innerNum As Integer
        Dim message As String = ""
        For outerNum = 1 To 3
            message = message & "Outer Loop: " & outerNum & vbNewLine & vbNewLine
            For innerNum = 1 To 5
                message = message & "   Inner Loop: " & innerNum & vbNewLine
            Next innerNum
            message += vbNewLine
        Next outerNum
        MsgBox(message, MsgBoxStyle.OkOnly, "Nested For Loop")
    End Sub
End Class

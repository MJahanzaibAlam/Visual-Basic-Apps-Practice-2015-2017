Public Class HighTemperatures
    Dim temperatures(0 To 6) As Single
    Private Sub btnEnterTemp_Click(sender As System.Object, e As System.EventArgs) Handles btnEnterTemp.Click
        Dim prompt As String
        Dim title As String
        Dim ai As Short
        prompt = "Enter the day's highest temperature..."
        For ai = 0 To UBound(temperatures)
            title = "Day " & (ai + 1)
            temperatures(ai) = InputBox(prompt, title)
        Next
    End Sub

    Private Sub btnDisplayTemp_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplayTemp.Click
        Dim result As String
        Dim ai As Short
        Dim total As Single = 0
        result = "High temperatures for the week: " & vbCrLf & vbCrLf
        For ai = 0 To UBound(temperatures)
            result = result & "Day " & (ai + 1) & vbTab & temperatures(ai) & vbCrLf
        Next
        result = result & vbCrLf & "Average Temp: " & Format((total / 7), "0.00")
        txtOutput.Text = result
    End Sub
End Class

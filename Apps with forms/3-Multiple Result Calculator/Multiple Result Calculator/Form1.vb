Public Class Form1
    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnLabelResult_Click(sender As System.Object, e As System.EventArgs) Handles btnLabelResult.Click
        Dim A As Single = Me.txtFirstNumber.Text
        Dim B As Single = Me.txtSecondNumber.Text
        Dim Message As String
        Message = "1st Num + 2nd Num = " & A + B & vbNewLine &
            "1st Num - 2nd Num = " & A - B & vbNewLine &
            "1st Num / 2nd Num = " & A / B & vbNewLine &
            "1st Num * 2nd Num = " & A * B
        Me.lblResult.Text = Message
    End Sub

    Private Sub btnTextBoxResult_Click(sender As System.Object, e As System.EventArgs) Handles btnTextBoxResult.Click
        Dim A As Single = Me.txtFirstNumber.Text
        Dim B As Single = Me.txtSecondNumber.Text
        Dim Message As String
        Message = "1st Num + 2nd Num = " & A + B & vbNewLine &
            "1st Num - 2nd Num = " & A - B & vbNewLine &
            "1st Num / 2nd Num = " & A / B & vbNewLine &
            "1st Num * 2nd Num = " & A * B
        Me.txtResult.Text = Message
    End Sub

    Private Sub btnMessageboxResult_Click(sender As System.Object, e As System.EventArgs) Handles btnMessageboxResult.Click
        Dim A As Single = Me.txtFirstNumber.Text
        Dim B As Single = Me.txtSecondNumber.Text
        Dim Message As String
        Message = "1st Num + 2nd Num = " & A + B & vbNewLine &
            "1st Num - 2nd Num = " & A - B & vbNewLine &
            "1st Num / 2nd Num = " & A / B & vbNewLine &
            "1st Num * 2nd Num = " & A * B
        MsgBox(Message, MsgBoxStyle.OkOnly)
    End Sub
End Class

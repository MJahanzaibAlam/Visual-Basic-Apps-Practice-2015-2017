Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Const MAX_VAL = 5
        Dim ColNumber, RowNumber, Sum As Integer
        Dim Message As String
        Message = "+" & Space(11)
        For ColNumber = 0 To MAX_VAL
            Message = Message & ColNumber & Space(8)
        Next ColNumber
        Message = Message & vbNewLine & vbNewLine
        For RowNumber = 0 To MAX_VAL
            Message = Message & RowNumber & Space(12)
            For ColNumber = 0 To MAX_VAL
                Sum = ColNumber + RowNumber
                Message = Message & Sum & Space(8)
            Next ColNumber
            Message = Message & vbNewLine
        Next RowNumber
        MsgBox(Message, , "Addition table using a nested For Loop")
    End Sub
End Class

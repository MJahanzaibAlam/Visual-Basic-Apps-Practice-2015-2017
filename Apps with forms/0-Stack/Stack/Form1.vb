Public Class Form1
    Dim Stack(10) As Integer
    Dim index As Integer
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'In
        If index = 9 Then
            TextBox2.Text = "Stack is full"
        Else
            TextBox2.Text = ""
            If IsNumeric(TextBox1.Text) Then
                Stack(index) = TextBox1.Text
                TextBox1.Text = ""
                index += 1
            Else
                TextBox2.Text = "Please enter a numerical value"
            End If
        End If
        TextBox1.Focus()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        If index = 0 Then
            TextBox2.Text = "Stack is empty"
        Else
            TextBox2.Text = ""
            index -= 1
            TextBox1.Text = Stack(index)
            Stack(index) = Nothing
        End If
        TextBox1.Focus()
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        index = 0
    End Sub
End Class
'TextBox1.text
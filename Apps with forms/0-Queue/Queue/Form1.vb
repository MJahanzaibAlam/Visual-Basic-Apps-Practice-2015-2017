Public Class Form1
    Dim Queue(10) As Integer
    Dim index As Integer
    Dim index2 As Integer
    Dim counter As Integer
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If index = 10 Then
            index = 0
        End If
        If counter = 10 Then
            TextBox2.Text = "Queue full, could not add " & TextBox1.Text
            TextBox1.Text = ""
        Else
            TextBox2.Text = ""
            If IsNumeric(TextBox1.Text) Then
                Queue(index) = TextBox1.Text
                index += 1
                TextBox1.Text = ""
                counter += 1
            Else
                TextBox2.Text = "Please enter a numerical value"
            End If
        End If
        TextBox1.Focus()
    End Sub
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If index2 = 10 Then
            index2 = 0
        End If
        If counter = 0 Then
            TextBox2.Text = "Queue empty"
            TextBox1.Text = ""
        Else
            TextBox2.Text = ""
            TextBox1.Text = Queue(index2)
            Queue(index2) = Nothing
            index2 += 1
            counter -= 1
        End If
        TextBox1.Focus()
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        index = 0
        index2 = 0
        counter = 0
    End Sub
End Class
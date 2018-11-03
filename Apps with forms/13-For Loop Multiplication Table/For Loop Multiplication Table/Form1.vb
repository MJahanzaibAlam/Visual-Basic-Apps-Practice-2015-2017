Public Class Form1

    Private Sub btnMultiply_Click(sender As System.Object, e As System.EventArgs) Handles btnMultiply.Click
        Dim number As Integer
        Dim index As Integer
        Dim result As Integer
        Try
            number = txtNumber.Text
            For index = 1 To 12
                result = index * number
                lstNumber.Items.Add(number & " x " & index & " = " & result)
            Next index
            btnClear.Focus()
        Catch ex As Exception
            MsgBox("Enter a number to proceed!", MsgBoxStyle.Critical, "Error")
            txtNumber.Focus()
        End Try
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        lstNumber.Items.Clear()
        txtNumber.Text = ""
        txtNumber.Focus()
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Dim response As MsgBoxResult = MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNo, "Multiplication table")
        If response = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnMultiplyIncrement_Click(sender As System.Object, e As System.EventArgs) Handles btnMultiplyIncrement.Click
        Dim number As Integer
        Dim index As Integer
        Dim result As Integer
        Try
            number = txtNumber.Text
            For index = 0 To 12 Step 2
                result = index * number
                lstNumber.Items.Add(number & " x " & index & " = " & result)
            Next index
            btnClear.Focus()
        Catch ex As Exception
            MsgBox("Enter a number to proceed!", MsgBoxStyle.Critical, "Error")
            txtNumber.Focus()
        End Try
    End Sub
End Class

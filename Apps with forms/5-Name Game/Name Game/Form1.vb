Public Class Form1
    Dim FirstName As String
    Dim LastName As String
    Dim FullName As String
    Dim Space As Integer
    Dim NameLength As Integer
    Private Sub btnGetInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetInfo.Click
        FullName = txtInput.Text
        NameLength = Len(txtInput.Text)
        Space = InStr(FullName, " ")
        FirstName = Microsoft.VisualBasic.Left(FullName, Space - 1)
        LastName = Microsoft.VisualBasic.Right(FullName, NameLength - Space)

        Me.lblOutput.Text = ("Your first name is " & FirstName & vbNewLine)
        Me.lblOutput.Text &= ("Your last name is " & LastName & vbNewLine & vbNewLine)
        Me.lblOutput.Text &= ("There are " & NameLength - 1 & " characters in your name")

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        txtInput.Focus()
        FullName = Nothing
        FirstName = Nothing
        LastName = Nothing
        NameLength = Nothing
        Space = Nothing
        lblOutput.Text = Nothing

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class

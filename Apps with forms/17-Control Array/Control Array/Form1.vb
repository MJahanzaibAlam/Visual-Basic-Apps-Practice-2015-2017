Public Class Form1
    Dim lblCourts(3) As Label
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblCourts(0) = lblCourt1
        lblCourts(1) = lblCourt2
        lblCourts(2) = lblCourt3
        lblCourts(3) = lblCourt4
    End Sub

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        Dim courtNumber_str As String = txtCourtNumber.Text
        Dim index_int As Short = 0
        For index_int = 0 To 3
            If lblCourts(index_int).Text = courtNumber_str Then
                lblCourts(index_int).BackColor = Color.Green
            End If
        Next
    End Sub

    Private Sub txtCourtNumber_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCourtNumber.TextChanged
        Dim courtNumber_str As String = txtCourtNumber.Text
        Dim index_int As Short = 0
        If e.KeyChar = Chr(Keys.Enter) Then
            For index_int = 0 To 3
                If lblCourts(index_int).Text = courtNumber_str Then
                    lblCourts(index_int).BackColor = Color.Green
                End If
            Next
            e.Handled = True
        End If
    End Sub
End Class

Public Class ArrayClassMethods
    Dim randArray(0 To 499) As Long
    Private Sub ArrayClassMethods_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = UBound(randArray)
        lblProgress.Text = "0 %"
    End Sub

    Private Sub btnFillArray_Click(sender As System.Object, e As System.EventArgs) Handles btnFillArray.Click
        Dim ai As Integer
        txtoutput.text = ""
        For ai = 0 To UBound(randArray)
            randArray(ai) = Int(Rnd() & 10000)
            txtoutput.text = txtoutput.text & randArray(ai) & vbCrLf
            ProgressBar1.Value = ai
            lblProgress.Text = Int((ProgressBar1.Value + 1) / 5).ToString() & " %"
            lblProgress.Refresh()
        Next
    End Sub

    Private Sub btnSortArray_Click(sender As System.Object, e As System.EventArgs) Handles btnSortArray.Click
        Dim ai As Integer
        txtOutput.Text = ""
        Array.Sort(randArray)
        For ai = 0 To UBound(randArray)
            txtOutput.Text = txtOutput.Text & randArray(ai) & vbCrLf
            ProgressBar1.Value = ai
            lblProgress.Text = Int((ProgressBar1.Value + 1) / 5).ToString() & " %"
            lblProgress.Refresh()
        Next
    End Sub

    Private Sub btnReverseArray_Click(sender As System.Object, e As System.EventArgs) Handles btnReverseArray.Click
        Dim ai As Integer
        txtOutput.Text = ""
        Array.Reverse(randArray)
        For ai = 0 To UBound(randArray)
            txtOutput.Text = txtOutput.Text & randArray(ai) & vbCrLf
            ProgressBar1.Value = ai
            lblProgress.Text = Int((ProgressBar1.Value + 1) / 5).ToString() & " %"
            lblProgress.Refresh()
        Next
    End Sub
End Class

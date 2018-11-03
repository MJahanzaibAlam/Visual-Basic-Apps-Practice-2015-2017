Public Class TemperatureConverter

    Private Sub btnMin_Click(sender As System.Object, e As System.EventArgs) Handles btnMin.Click
        Me.VScrollBar1.Value = Me.VScrollBar1.Maximum
    End Sub

    Private Sub btnMax_Click(sender As System.Object, e As System.EventArgs) Handles btnMax.Click
        Me.VScrollBar1.Value = Me.VScrollBar1.Minimum
    End Sub

    Private Sub ConvertTemp()
        Dim degF As Int16
        Dim degC As Double
        degF = 130 - VScrollBar1.Value
        degC = (5.0 / 9.0) * (degF - 32.0)
        txtFahrenheit.Text = degF.ToString()
        txtCentigrade.Text = Convert.ToInt16(degC).ToString()
    End Sub

    Private Sub VScrollBar1_Scroll(sender As System.Object, e As System.Windows.Forms.ScrollEventArgs) Handles VScrollBar1.Scroll
        ConvertTemp()
    End Sub
End Class

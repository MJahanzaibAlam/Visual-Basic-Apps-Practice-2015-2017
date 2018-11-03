Public Class CarHire
    Dim Premium As Double = 0.1
    Dim total As Single = 0.0
    Dim insurance As Integer = 100

    Private Sub lstVehicleType_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstVehicleType.SelectedIndexChanged
        If lstVehicleType.Text = "Economic" Then
            Me.txtCostPerDay.Text = "12.00"
        End If
        If lstVehicleType.Text = "Value" Then
            Me.txtCostPerDay.Text = "15.00"
        End If
        If lstVehicleType.Text = "Luxury" Then
            Me.txtCostPerDay.Text = "21.00"
        End If
    End Sub

    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click

    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click

    End Sub
End Class

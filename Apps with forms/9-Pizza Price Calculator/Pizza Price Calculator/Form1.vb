Public Class Form1
    Dim total As Single = 5.0
    Dim MeatTopping As Boolean = False
    Dim OtherTopping As Boolean = False
    Private Sub radSmall_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radSmall.CheckedChanged
        CalculatePrice()
    End Sub

    Private Sub radMedium_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radMedium.CheckedChanged
        CalculatePrice()
    End Sub

    Private Sub radLarge_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radLarge.CheckedChanged
        CalculatePrice()
    End Sub

    Private Sub radThin_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radThin.CheckedChanged
        CalculatePrice()
    End Sub
    Private Sub radDeepPan_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radDeepPan.CheckedChanged
        CalculatePrice()
    End Sub

    Private Sub radCheeseFilled_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radCheeseFilled.CheckedChanged
        CalculatePrice()
    End Sub

    Private Sub chkPepperoni_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkPepperoni.CheckedChanged
        CalculatePrice()
    End Sub

    Private Sub chkBeef_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkBeef.CheckedChanged
        CalculatePrice()
    End Sub

    Private Sub chkHam_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkHam.CheckedChanged
        CalculatePrice()
    End Sub

    Private Sub chkChicken_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkChicken.CheckedChanged
        CalculatePrice()
    End Sub

    Private Sub chkSausage_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkSausage.CheckedChanged
        CalculatePrice()
    End Sub

    Private Sub chkProscuitto_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkProscuitto.CheckedChanged
        CalculatePrice()
    End Sub

    Private Sub chkTuna_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkTuna.CheckedChanged
        CalculatePrice()
    End Sub

    Private Sub chkAnchovies_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkAnchovies.CheckedChanged
        CalculatePrice()
    End Sub

    Private Sub chkVegetables_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkVegetables.CheckedChanged
        CalculatePrice()
    End Sub

    Private Sub chkMushrooms_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkMushrooms.CheckedChanged
        CalculatePrice()
    End Sub

    Private Sub chkOnions_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkOnions.CheckedChanged
        CalculatePrice()
    End Sub

    Private Sub chkOlives_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkOlives.CheckedChanged
        CalculatePrice()
    End Sub

    Private Sub chkMozarella_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkMozarella.CheckedChanged
        CalculatePrice()
    End Sub

    Private Sub chkGoatsCheese_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkGoatsCheese.CheckedChanged
        CalculatePrice()
    End Sub

    Private Sub chkFeta_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkFeta.CheckedChanged
        CalculatePrice()
    End Sub

    Private Sub chkCapers_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkCapers.CheckedChanged
        CalculatePrice()
    End Sub

    Private Sub chkPinapple_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkPineapple.CheckedChanged
        CalculatePrice()
    End Sub

    Private Sub chkRocket_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkRocket.CheckedChanged
        CalculatePrice()
    End Sub
    Private Sub CalculatePrice()
        total = 5.0
        If chkAnchovies.Checked = True Then
            total += 0.75
        End If
        If chkVegetables.Checked = True Then
            total += 0.75
        End If
        If chkMushrooms.Checked = True Then
            total += 0.75
        End If
        If chkOnions.Checked = True Then
            total += 0.75
        End If
        If chkOlives.Checked = True Then
            total += 0.75
        End If
        If chkMozarella.Checked = True Then
            total += 0.75
        End If
        If chkGoatsCheese.Checked = True Then
            total += 0.75
        End If
        If chkFeta.Checked = True Then
            total += 0.75
        End If
        If chkCapers.Checked = True Then
            total += 0.75
        End If
        If chkPineapple.Checked = True Then
            total += 0.75
        End If
        If chkRocket.Checked = True Then
            total += 0.75
        End If
        If chkPepperoni.Checked = True Then
            total += 1
        End If
        If chkBeef.Checked = True Then
            total += 1
        End If
        If chkHam.Checked = True Then
            total += 1
        End If
        If chkChicken.Checked = True Then
            total += 1
        End If
        If chkSausage.Checked = True Then
            total += 1
        End If
        If chkProscuitto.Checked = True Then
            total += 1
        End If
        If chkTuna.Checked = True Then
            total += 1
        End If
        If radDeepPan.Checked = True Then
            total += 1
        End If
        If radCheeseFilled.Checked = True Then
            total += 2
        End If
        If radMedium.Checked = True Then
            total += total * 0.25
        End If
        If radLarge.Checked = True Then
            total += total * 0.5
        End If
        FormatCurrency(total)
        lblPrice.Text = FormatCurrency(total)
    End Sub

    Private Sub btnReset_Click(sender As System.Object, e As System.EventArgs) Handles btnReset.Click

    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Dim msg As String = "Are you sure you want to exit?"
        Dim title As String = "Pizza Price Calculator"
        Dim style As MsgBoxResult = MsgBoxStyle.YesNo
        Dim response As MsgBoxResult = MsgBox(msg, style, title)
        If response = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class

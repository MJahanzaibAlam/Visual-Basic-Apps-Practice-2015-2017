Public Class WageCalculator
    Const Salary = 1000.0#
    Dim HourlyRate As Double = 5.5#
    Dim Message As String
    Private Sub btnCalculatePay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculatePay.Click
        If Me.radSalary.Checked = True Then
            If Me.chkOvertime.Checked = True Then
                Me.txtTotal.Text = "£ " & Salary + Val(Me.txtOvertime.Text) * (HourlyRate * 1.5)
            Else
                Me.txtTotal.Text = "£ " & Salary
            End If
        End If

        If Me.radHourly.Checked = True Then

        If Me.chkOvertime.Checked = True Then
                Me.txtTotal.Text = "£ " & (Val(Me.txtOvertime.Text) * (Val(Me.lsHourlyRate.Text) * 1.5) + (Val(Me.lsHourlyRate.Text) * Val(Me.txtHoursWorked.Text)))
            Else
                Me.txtTotal.Text = "£ " & Val(Me.lsHourlyRate.Text) * Val(Me.txtHoursWorked.Text)

            End If
        End If
    End Sub

    Private Sub radSalary_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radSalary.CheckedChanged
        Me.lsHourlyRate.Enabled = False
        Me.txtHoursWorked.Enabled = False
        Me.btnDetails.Enabled = False
    End Sub

    Private Sub radHourly_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radHourly.CheckedChanged
        Me.lsHourlyRate.Enabled = True
        Me.txtHoursWorked.Enabled = True
        Me.btnDetails.Enabled = True
    End Sub

    Private Sub btnDetails_Click(sender As System.Object, e As System.EventArgs) Handles btnDetails.Click
        Message = "Pay Calculation: " & vbCr & vbCr
        Message += "Basic Hours Worked: " & txtHoursWorked.Text & vbCr
        Message += "Hourly Rate of Pay: " & lsHourlyRate.Text & vbCr
        Message += "Basic pay: £" & Val(txtHoursWorked.Text) * Val(lsHourlyRate.Text) & vbCr
        Message += "Overtime Hours Worked: " & txtOvertime.Text & vbCr
        Message += "Overtime Hourly Pay Rate: £" & Val(lsHourlyRate.Text) & 1.5 & vbCr
        Message += "Overtime Pay £: " & Val(lsHourlyRate.Text & 1.5) * Val(txtOvertime.Text)
        MsgBox(Message)
    End Sub

    Private Sub btnReset_Click(sender As System.Object, e As System.EventArgs) Handles btnReset.Click
        Me.txtOvertime.Text = ""
        Me.txtHoursWorked.Text = ""
        Me.txtTotal.Text = ""
        Me.chkOvertime.Checked = False
        Me.lsHourlyRate.ClearSelected()
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Dim msg As String = "Are you sure you want to exit?"
        Dim title As String = "Wage Calculator"
        Dim style As MsgBoxResult = MsgBoxStyle.YesNo
        Dim response As MsgBoxResult = MsgBox(msg, style, title)
        If response = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub chkOvertime_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkOvertime.CheckedChanged
        If chkOvertime.Checked = True Then
            txtOvertime.Enabled = True
        Else
            txtOvertime.Text = ""
            txtOvertime.Enabled = False
        End If
    End Sub
End Class

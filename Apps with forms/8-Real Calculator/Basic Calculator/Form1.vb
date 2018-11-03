Option Explicit On
Imports System.Math
Public Class Calculator
    Dim FirstNum As Single
    Dim SecondNum As Single
    Dim AnswerNum As Single
    Dim arithmetic As String
    Private Sub btnDot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDot.Click
        txtDisplay.Text += "."
    End Sub

    Private Sub btn0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn0.Click
        txtDisplay.Text += "0"
    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        txtDisplay.Text += "1"
    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        txtDisplay.Text += "2"
    End Sub

    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        txtDisplay.Text += "3"
    End Sub

    Private Sub btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click
        txtDisplay.Text += "4"
    End Sub

    Private Sub btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
        txtDisplay.Text += "5"
    End Sub

    Private Sub btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn6.Click
        txtDisplay.Text += "6"
    End Sub

    Private Sub btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn7.Click
        txtDisplay.Text += "7"
    End Sub

    Private Sub btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn8.Click
        txtDisplay.Text += "8"
    End Sub

    Private Sub btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn9.Click
        txtDisplay.Text += "9"
    End Sub

    Private Sub btnPlus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlus.Click
        FirstNum = Val(txtDisplay.Text)
        txtDisplay.Text = ""
        arithmetic = "+"
    End Sub

    Private Sub btnMinus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinus.Click
        FirstNum = Val(txtDisplay.Text)
        txtDisplay.Text = ""
        arithmetic = "-"
    End Sub

    Private Sub btnMultiply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMultiply.Click
        FirstNum = Val(txtDisplay.Text)
        txtDisplay.Text = ""
        arithmetic = "*"
    End Sub

    Private Sub btnDivide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDivide.Click
        FirstNum = Val(txtDisplay.Text)
        txtDisplay.Text = ""
        arithmetic = "/"
    End Sub

    Private Sub btnEqual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEqual.Click
        SecondNum = Val(txtDisplay.Text)
        Select Case arithmetic
            Case "+"
                AnswerNum = FirstNum + SecondNum
            Case "-"
                AnswerNum = FirstNum - SecondNum
            Case "*"
                AnswerNum = FirstNum * SecondNum
            Case "/"
                If Not (SecondNum = 0) Then
                    AnswerNum = FirstNum / SecondNum
                Else
                    MsgBox("You can't divide by 0")
                End If
            Case "Exp"
                AnswerNum = FirstNum ^ SecondNum
            Case "Atan"
                AnswerNum = Atan(SecondNum)
            Case "Tan"
                AnswerNum = Tan(SecondNum)
            Case "Sin"
                AnswerNum = Sin(SecondNum)
            Case "Cos"
                AnswerNum = Cos(SecondNum)
            Case "Sqrt"
                AnswerNum = Sqrt(SecondNum)
        End Select
        txtDisplay.Text = AnswerNum
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        FirstNum = Nothing
        SecondNum = Nothing
        AnswerNum = Nothing
        arithmetic = Nothing
        txtDisplay.Text = Nothing
    End Sub

    Private Sub btnNeg_Click(sender As System.Object, e As System.EventArgs) Handles btnNeg.Click
        FirstNum = Val(txtDisplay.Text)
        txtDisplay.Text = FirstNum - (2 * FirstNum)
    End Sub

    Private Sub btnArc_Click(sender As System.Object, e As System.EventArgs) Handles btnArc.Click
        txtDisplay.Text = ""
        arithmetic = "Atan"
    End Sub

    Private Sub btnCos_Click(sender As System.Object, e As System.EventArgs) Handles btnCos.Click
        txtDisplay.Text = ""
        arithmetic = "Cos"
    End Sub

    Private Sub btnExp_Click(sender As System.Object, e As System.EventArgs) Handles btnExp.Click
        FirstNum = Val(txtDisplay.Text)
        txtDisplay.Text = ""
        arithmetic = "Exp"
    End Sub

    Private Sub btnTan_Click(sender As System.Object, e As System.EventArgs) Handles btnTan.Click
        txtDisplay.Text = ""
        arithmetic = "Tan"
    End Sub

    Private Sub btnSin_Click(sender As System.Object, e As System.EventArgs) Handles btnSin.Click
        txtDisplay.Text = ""
        arithmetic = "Sin"
    End Sub

    Private Sub btnSqrt_Click(sender As System.Object, e As System.EventArgs) Handles btnSqrt.Click
        txtDisplay.Text = ""
        arithmetic = "Sqrt"
    End Sub
End Class

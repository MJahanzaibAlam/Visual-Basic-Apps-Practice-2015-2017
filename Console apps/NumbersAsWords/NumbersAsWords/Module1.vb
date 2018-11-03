Module Module1

    Sub Main()
        Dim intNumber As Integer

        Dim strDigits(4) As String
        Dim MultipleOfTen As Integer
        Dim intDigits(4) As Integer
        Do
            MultipleOfTen = 10000 'first digit will be a thousand e.g. 4000. So dividing by 10,000 will leave a remainder of 4000, then divide this by the lower multiple of ten to just get the first digit, 4. .
            Console.Write(vbNewLine & "Please enter a number which is up to 4 digits long: ")
            intNumber = Console.ReadLine()
            If intNumber < 10000 Then

                For intDigitIndex As Integer = 0 To 3
                    intDigits(intDigitIndex) = Math.Floor((intNumber Mod MultipleOfTen) / (MultipleOfTen * 0.1))
                    'Loop iteration 0: e.g. 4023. Divide 4023 by 10,000 and remainder is 4023. Divide 4023 by the next multiple of ten (1000) and you get 4.023. Floor 4.023 and you get 4. Store as digit[0]
                    'Loop iteration 1: e.g. 4023. Divide 4023 by 1,000 and remainder is 23 (023). Divide 23 by the next multiple of ten (100) and you get 0.23. Floor 0.23 and you get 0. Store as digit[1]
                    'Loop iteration 2: e.g. 4023. Divide 4023 by 100 and reminader is 23. Divide 23 by next multiple of ten (10) and you get 2.3. Floor 2.3 and you get 2. Store as digit[2]
                    'Loop iteration 3: e.g. 4023. Divide 4023 by 10 and remainder is 3. Divide 3 by next multiple of ten (1) and you get 3. Floor 3 and you get 3. Store as digit[3]
                    Select Case MultipleOfTen
                        Case 10000
                            strDigits(intDigitIndex) = ConvertToWord(intDigits(intDigitIndex))
                            strDigits(intDigitIndex) += "-thousand "
                        Case 1000
                            strDigits(intDigitIndex) = ConvertToWord(intDigits(intDigitIndex))
                            strDigits(intDigitIndex) += "-hundred and "
                        Case (100)
                            intDigits(intDigitIndex) *= 10
                            strDigits(intDigitIndex) = ConvertToWord(intDigits(intDigitIndex))
                        Case (10)
                            strDigits(intDigitIndex) = ConvertToWord(intDigits(intDigitIndex))
                    End Select

                    MultipleOfTen /= 10
                Next
                CheckWords(strDigits, intDigits)
                For intWordIndex As Integer = 0 To 3
                    Console.Write(strDigits(intWordIndex))
                Next
            Else
                Console.WriteLine("Please enter a number that is up to four digits long")
            End If
        Loop
        Console.ReadLine()
    End Sub

    Public Function ConvertToWord(ByVal intDigit As Integer) As String
        Dim word As String = Nothing

        Select Case intDigit
            Case "0"
                word = Nothing
            Case "1"
                word = "One"
            Case "2"
                word = "Two"
            Case "3"
                word = "Three"
            Case "4"
                word = "Four"
            Case "5"
                word = "Five"
            Case "6"
                word = "Six"
            Case "7"
                word = "Seven"
            Case "8"
                word = "Eight"
            Case "9"
                word = "Nine"
            Case "10"
                word = "Ten"
            Case "11"
                word = "Eleven"
            Case "12"
                word = "Twelve"
            Case "13"
                word = "Thirteen"
            Case "14"
                word = "Fourteen"
            Case "15"
                word = "Fifteen"
            Case "16"
                word = "Sixteen"
            Case "17"
                word = "Seventeen"
            Case "18"
                word = "Eighteen"
            Case "19"
                word = "Ninteen"
            Case "20"
                word = "Twenty "
            Case "30"
                word = "Thirty "
            Case "40"
                word = "Fourty "
            Case "50"
                word = "Fifty "
            Case "60"
                word = "Sixty "
            Case "70"
                word = "Seventy "
            Case "80"
                word = "Eighty "
            Case "90"
                word = "Ninty "
        End Select

        Return word

    End Function

    Sub CheckWords(ByRef strDigits() As String, ByVal intDigits() As Integer)

        If strDigits(0) = "-thousand " Then
            strDigits(0) = Nothing
        End If

        If strDigits(1) = "-hundred and " Then
            strDigits(1) = Nothing
        End If

        If (strDigits(2) = "Ten") And strDigits(3) <> Nothing Then
            strDigits(2) = ConvertToWord(intDigits(3) + 10)
            strDigits(3) = Nothing
        End If

        If strDigits(0) <> Nothing And strDigits(1) = Nothing And ((strDigits(2) <> Nothing Or strDigits(3) <> Nothing)) Then
            strDigits(0) += "and "
        End If

        If strDigits(1) <> Nothing And strDigits(2) = Nothing And strDigits(3) = Nothing Then
            strDigits(1) = strDigits(1).Remove(strDigits(1).Length - 4, 4)
        End If

    End Sub

End Module

Module Module1
    Dim number1, number2 As Integer
    Sub Main()
        Dim answer As Double
        inputdata()
        calculations(number1, number2, answer)
        outputdata(answer)
        DoNotClose()
    End Sub
    Sub inputdata()
        Console.Write("Input first number ")
        number1 = Console.ReadLine()
        Console.Write("Input second number ")
        number2 = Console.ReadLine()
    End Sub
    Sub outputdata(ByVal n4 As Double)
        Console.WriteLine("The average of {0} and {1} is {2}", number1, number2, n4)
    End Sub
    Sub DoNotClose()
        Console.ReadLine()
    End Sub
    Sub calculations(ByVal n1 As Integer, ByVal n2 As Integer, ByRef n3 As Double)
        n3 = (n1 + n2) / 2
    End Sub

End Module

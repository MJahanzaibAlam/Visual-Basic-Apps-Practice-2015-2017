Module Module1

    Sub Main()
        Console.WriteLine("Please enter cost of item e.g. £3.80")
        Dim cost As Single = Console.ReadLine
        Console.WriteLine("Please insert payment (type amount of change entered, e.g. 3.40)")
        Dim payment As Single = Console.ReadLine
        Dim change As Single = payment - cost
        Console.WriteLine(change)
        Dim givencoin(30) As Single
        Dim coins() As Single = {0.01, 0.02, 0.05, 0.1, 0.2, 0.5, 1, 2}
        Dim i As Integer = 7
        Dim a As Integer = 0
        Do
            Console.WriteLine(change & " , " & coins(i) & " , " & a)
            If change >= coins(i) Then
                givencoin(a) = coins(i)
                change -= coins(i)
                change = Int(change * 100) / 100
                a += 1
            Else
                i = i - 1
            End If
        Loop Until change <= 0.01
        i = 0
        Do
            Console.WriteLine(givencoin(i))
            i += 1
        Loop Until i = 30
        Console.ReadLine()
    End Sub

End Module

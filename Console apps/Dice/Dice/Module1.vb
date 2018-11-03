Module Module1

    Sub Main()
        Dim y() As String = {"one", "two", "three", "four", "five", "six"}
        Randomize()
        Dim z As Integer = Rnd() * 6
        Console.WriteLine(y(z))
        Console.ReadLine()
    End Sub

End Module

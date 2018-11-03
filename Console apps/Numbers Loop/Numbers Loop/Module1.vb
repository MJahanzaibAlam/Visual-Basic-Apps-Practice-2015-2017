Module Module1

    Sub Main()
        Console.WriteLine("Please enter how many values you would like added and averaged:")
        Dim values As Integer = Console.ReadLine
        Dim counter As Integer = 0
        Do
            Dim a As Integer = Console.ReadLine
            a = a + 1
            counter = counter + 1
        Loop Until counter = values
        Console.ReadKey()
    End Sub

End Module

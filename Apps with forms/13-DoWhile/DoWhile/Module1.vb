Module Module1

    Sub Main()
        Dim totalnumber As Integer = 0
        Dim numberpassed As Integer = 0
        Dim response As String
        Console.WriteLine("Has person passed driving test? Y/N or Q to quit?")
        response = Console.ReadLine
        Do While (response = "y") Or (response = "n")
            totalnumber = totalnumber + 1
            If response = "y" Then
                numberpassed = numberpassed + 1
            End If
            Console.WriteLine("Has person passed driving test? Y/N or Q to quit?")
            response = Console.ReadLine()
        Loop
        Console.WriteLine("Total Number of people: {0} ", totalnumber)
        Console.WriteLine("Percentage who passed: {0} ", Format(numberpassed / totalnumber * 100, "###.00"))
        Console.ReadKey()
    End Sub

End Module

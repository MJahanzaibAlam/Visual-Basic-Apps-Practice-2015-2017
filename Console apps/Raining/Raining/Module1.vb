Module Module1

    Sub Main()
        Console.WriteLine("Is it raining?")
        Dim response As String = Console.ReadLine()
        If response = "Yes" Then
            Console.WriteLine("Don't forget your umbrella!")
            Console.ReadKey()
        End If
    End Sub

End Module

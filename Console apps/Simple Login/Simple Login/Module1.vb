Module Module1

    Sub Main()
        Console.WriteLine("Enter username")
        Dim username As String
        Do
            username = Console.ReadLine()
        Loop Until username = "admin"
        Console.WriteLine("You are now logged in as admin")
        Console.ReadKey()
    End Sub

End Module

Module Module1

    Sub Main()
        Console.WriteLine("Press Enter to knock on the door")
        Dim key As ConsoleKeyInfo = Console.ReadKey(True)
        If key.Key = ConsoleKey.Enter Then
            Console.WriteLine("Knock")
            key = ConsoleKey.Backspace
        Else : Console.WriteLine("....You didn't knock on the door. Goodbye.")
            System.Threading.Thread.Sleep(5000)
        End If
        If key.Key = ConsoleKey.Enter Then
            Console.WriteLine("Knock")
            Console.ReadLine()
        Else : Console.WriteLine("....You didn't knock on the door. Goodbye.")
            System.Threading.Thread.Sleep(5000)
        End If

    End Sub

End Module

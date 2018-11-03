Module Module1

    Sub Main()
        Dim room As String = Console.ReadLine
        If room.StartsWith("B") Then
            Console.Write(room & " Is in the Ball Building ")
        End If
        If room.Contains("2") Then
            Console.WriteLine("on the second floor")
        End If
        Console.ReadKey()
    End Sub

End Module

Module Module1

    Sub Main()
        Dim Name(100), Score(100)
        For i As Integer = 1 To 100
            Console.Write("Please enter student " & i & "'s name: ")
            Name(i) = Console.ReadLine
            If Name(i) = "Finished" Then
                Exit For
            Else
                Console.Write("Please enter student " & i & "'s score: ")
                Score(i) = Console.ReadLine
            End If
        Next
        Console.WriteLine("Name".PadLeft(8) & Space(8) & "Score".PadLeft(8))
        For i As Integer = 1 To 100
            Console.WriteLine(Name(i).ToString.PadLeft(8) & Space(8) & Score(i).ToString.PadLeft(8))
        Next
        Dim total As Integer = Score(100)
        Console.Write("Total score: " & total)
        Console.ReadKey()
    End Sub

End Module

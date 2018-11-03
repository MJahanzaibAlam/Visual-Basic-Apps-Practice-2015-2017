Module Module1

    Sub Main()
        Console.Title = "Difference between ages"
        Console.WriteLine("Person 1, please enter your age.")
        Dim Age1 As Integer = Console.ReadLine()
        Console.WriteLine("Person 2, please enter your age.")
        Dim Age2 As Integer = Console.ReadLine()
        Dim AgeD As Integer = Math.Abs(Age1 - Age2)
        Console.WriteLine("The difference between your ages is {0}", AgeD)
        Console.ReadKey()
        'Alternative:
        '        Console.WriteLine("Person 1, please enter your age.")
        'Dim Age1 As Integer = Console.ReadLine()
        '    Console.WriteLine("Person 2, please enter your age.")
        'Dim Age2 As Integer = Console.ReadLine()
        '    If Age1 > Age2 Then
        'Dim AgeD As Integer = Age1 - Age2
        '        Console.WriteLine("The difference between your ages is " & AgeD)
        '    Else : Dim AgeD As Integer = Age2 - Age1
        '        Console.WriteLine("The difference between your ages is " & AgeD)
        '    End If
        'Console.ReadKey()
    End Sub

End Module

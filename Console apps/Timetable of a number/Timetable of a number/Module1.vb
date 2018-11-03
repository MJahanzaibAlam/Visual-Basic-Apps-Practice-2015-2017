Module Module1

    Sub Main()
        Console.WriteLine("Enter the number for which the timetable should be displayed")
        Dim number As Integer = Console.ReadLine
        For counter As Integer = number * 1 To number * 10 Step number
            Console.WriteLine(counter.ToString)
        Next
        Console.WriteLine("Start")
        Console.ReadKey()
    End Sub

End Module

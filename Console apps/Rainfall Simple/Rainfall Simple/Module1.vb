Module Module1

    Sub Main()
        Console.WriteLine("Please enter the rainfall for each month (mm) ")
        Dim total As Integer
        For i As Integer = 1 To 12
            Console.Write("Month " + i.ToString + ": ")
            total = total + Console.ReadLine
        Next
        Console.WriteLine("Total Rainfall: " + total.ToString)
        Dim average As Double = (total / 12)
        Console.WriteLine("Average Monthly Rainfall: " + Math.Round(average, 2).ToString)
        Console.ReadLine()
    End Sub

End Module

Module Module1

    Sub Main()
        Console.WriteLine("Please enter 3 numbers which you would like totalled and averaged:")
        Dim a As Integer = Console.ReadLine
        Dim b As Integer = Console.ReadLine
        Dim c As Integer = Console.ReadLine
        Dim total As Integer = a + b + c
        Console.WriteLine("The total of these numbers is " & total)
        Console.WriteLine("The average of these numbers is " & total / 3)
        Console.WriteLine("Please enter some numbers you would like added. To stop and add the numbers, enter 0.")
        Dim d As Integer = 0
        Dim e As Integer = 0
        Dim f As Integer = 0
        Do
            e = Console.ReadLine()
            d = d + e
            f = f + 1
        Loop Until e = 0
        Console.WriteLine("The total of these numbers is " & d)
        Console.WriteLine("Would you like the average of these numbers? Enter 'yes' if you would")
        If Console.ReadLine() = "yes" Then
            Console.WriteLine("The average of these numbers is " & d / f)
            Console.ReadKey()
        Else
            Console.ReadKey()
        End If
    End Sub

End Module

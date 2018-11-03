Module Module1

    Sub Main()
        Console.WriteLine("Please enter the number of values you would like added and averaged:")
        Dim number As Integer = Console.ReadLine()
        If number > 50 Then
            Console.WriteLine("It would take you far too long to input that many numbers")
        Else

            Console.WriteLine("Now enter the values you would like added and averaged:")
            Dim total As Integer = 0
            Dim counter As Integer = 0
            Do
                total = total + Console.ReadLine()
                counter = counter + 1
            Loop Until counter = number
            Console.WriteLine("The addition of these values gives: " & total)
            Console.WriteLine("The average of these values is: " & total / number)
            If total / number > 1000 Then
                Console.WriteLine("You have input some very large numbers")
            End If
        End If
        Console.ReadKey()
    End Sub

End Module

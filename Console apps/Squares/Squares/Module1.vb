Module Module1

    Sub Main()
        Console.Write("Please enter the number of symbols for the width: ")
        Dim Number As Integer = Console.ReadLine()
        Console.Write("Please enter the number of symbols for the length: ")
        Dim Number2 As Integer = Console.ReadLine()
        For x As Integer = 1 To Number 'start a loop to count to the value of number
            Console.Write("#")
            For z As Integer = 1 To Number2
                Console.Write("#")
            Next
            Console.WriteLine()
        Next
    End Sub

End Module

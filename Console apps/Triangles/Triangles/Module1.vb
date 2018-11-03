Module Module1

    Sub Main()
        Console.Write("Please enter the number of symbols for the triangle: ")
        Dim Number As Integer = Console.ReadLine()
        For y As Integer = Number To 1 Step -1 'y loops from 1 to the number entered
            For z As Integer = 1 To Number - y 'z loops from 1 to number entered -1 each time
                Console.Write(" ") 'print this space by the number of times the loop runs.
            Next
            For x As Integer = 1 To y
                Console.Write("#") 'print this hash after the first loop has printed the spaces.
            Next
            Console.WriteLine()
        Next
        Console.ReadKey()
    End Sub

End Module

            For y As Integer = Number To 1 Step -1
                For z As Integer = Number To 1 - y
                    Console.Write(" ")
                Next
                For x As Integer = 1 To y
                    Console.Write("#")
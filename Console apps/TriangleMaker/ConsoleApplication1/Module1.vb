Module Module1

    Sub Main()
        Dim sizeOfTriangle As Integer = Console.ReadLine
        Dim spaces As Integer = sizeOfTriangle

        For column As Integer = 1 To sizeOfTriangle
            For spacesWrite As Integer = 1 To spaces
                Console.Write(" ")
            Next
            For row As Integer = 1 To column * 2
                Console.Write("#")
            Next
            Console.WriteLine()
            spaces -= 1
        Next
        Console.ReadLine()
    End Sub

End Module

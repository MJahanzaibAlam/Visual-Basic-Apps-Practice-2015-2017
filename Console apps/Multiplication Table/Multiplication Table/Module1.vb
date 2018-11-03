Module Module1

    Sub Main()
        For counter As Integer = 1 To 10
            For counter2 As Integer = counter To (counter * 10) Step counter
                Console.Write(counter2.ToString.PadLeft(3) & Space(2))
            Next counter2
            Console.WriteLine()
        Next
        Console.ReadKey()
    End Sub

End Module

Module Module1

    Sub Main()
        Console.Write("Please enter your marks: ")
        Dim marks As Integer = Console.ReadLine()
        Console.Write("Your grade is: ")
        If marks < 40 Then
            Console.WriteLine("You are a failure")
        ElseIf marks >= 90 Then
            Console.WriteLine("A*")
        ElseIf marks >= 80 Then
            Console.WriteLine("A")
        ElseIf marks >= 70 Then
            Console.WriteLine("B")
        ElseIf marks >= 60 Then
            Console.WriteLine("C")
        ElseIf marks >= 50 Then
            Console.WriteLine("D")
        ElseIf marks >= 40 Then
            Console.WriteLine("E")
        Else
            Console.WriteLine("Please enter your marks")
        End If
        Console.ReadKey()
    End Sub

End Module

Module Module1

    Sub Main()
        Dim FName(100), Lname(100), Tnumber(100), Pcode(100), Starter(100), Mcourse(100), Desert(100)
        For i As Integer = 1 To 100
            Console.Write("Please enter customer " & i & "'s first name: ")
            FName(i) = Console.ReadLine
            If FName(i) = "Finished" Then
                Exit For
            Else
                Console.Write("Please enter customer " & i & "'s last name: ")
                Lname(i) = Console.ReadLine
                Console.Write("Please enter customer " & i & "'s telephone number: ")
                Tnumber(i) = Console.ReadLine
                Console.Write("Please enter customer " & i & "'s post code: ")
                Pcode(i) = Console.ReadLine
                Console.Write("Please enter customer " & i & "'s starter: ")
                Starter(i) = Console.ReadLine
                Console.Write("Please enter customer " & i & "'s main course: ")
                Mcourse(i) = Console.ReadLine
                Console.Write("Please enter customer " & i & "'s desert: ")
                Desert(i) = Console.ReadLine
            End If
        Next
        Console.WriteLine("First name" & Space(5) & "Last name" & Space(5) & "Telephone number" & Space(5) & "Post code" & Space(5) & "Starter" & Space(5) & "Main course" & Space(5) & "Desert")
        For i As Integer = 1 To 100
            Console.WriteLine(FName(i) & Space(5) & Lname(i) & Space(5) & Tnumber(i) & Space(5) & Pcode(i) & Space(5) & Starter(i) & Space(5) & Mcourse(i) & Space(5) & Desert(i))
        Next
        Console.ReadKey()
    End Sub

End Module

Module Module1
    Structure record
        Dim ID As Integer
        Dim fName As String
        Dim Sname As String
        Dim Grade As String
    End Structure
    Dim Student(100) As record
    Sub Main()
        Dim FullLine As String = ""
        FileOpen(1, "N:\Desktop\Wraowlafi.txt", OpenMode.Input)
        Dim i As Integer = 1
        Do
            FullLine = LineInput(1)
            Dim Item() As String = Split(FullLine, ",")
            Student(i).ID = Item(0)
            Student(i).fName = Item(1)
            Student(i).Sname = Item(2)
            Student(i).Grade = Item(3)
            i = i + 1
        Loop Until EOF(1)
        FileClose(1)
        Do
            Console.WriteLine("Main menu:")
            Console.WriteLine("___________________________________________")
            Console.WriteLine("1 – Add student")
            Console.WriteLine("2 – Show student")
            Console.WriteLine("3 – Delete student")
            Console.WriteLine("4 – Edit student")
            Console.WriteLine("5 – Save students")
            Console.WriteLine("9 - Exit")
            Console.WriteLine("___________________________________________")
            Console.WriteLine("What would you like to do?")
            Dim choice As Integer = Console.ReadLine()
            Select Case choice
                Case 1
                    enterStudent()
                Case 2
                    showStudent()
                Case 3
                    deleteStudent()
                Case 4
                    editStudent()
                Case 5
                    savestudents()
                Case 9
                    Exit Do
            End Select
        Loop
    End Sub
    Sub enterStudent()
        For i As Integer = 1 To 100
            Do
                Console.Write("Would you like to add another student? If yes, enter y. If no, enter n.")
                Dim Response As Char = Console.ReadLine()
                If Response = "n" Then
                    Exit For
                Else
                    Do
                        If Student(i).ID > 0 Then
                            i = i + 1
                        End If
                    Loop Until Student(i).ID = Nothing
                    Console.Write("Please enter the student's ID: ")
                    Student(i).ID = Console.ReadLine()
                    Console.Write("Please enter the student's first name: ")
                    Student(i).fName = Console.ReadLine()
                    Console.Write("Please enter the student's surname: ")
                    Student(i).Sname = Console.ReadLine()
                    Console.Write("Please enter the student's grade: ")
                    Student(i).Grade = Console.ReadLine()
                    i = i + 1
                End If
            Loop
        Next
    End Sub
    Sub showStudent()
        Console.WriteLine("Which student is it?")
        Dim i As Integer = Console.ReadLine()
        If Student(i).ID = Nothing Then
            Console.WriteLine("--------------------------------------")
            Console.WriteLine("The student is not in the database")
            Console.WriteLine("--------------------------------------")
            Exit Sub
        Else
            Console.WriteLine("ID: " + Student(i).ID.ToString)
            Console.WriteLine("First name: " + Student(i).fName.ToString)
            Console.WriteLine("Surname: " + Student(i).Sname.ToString)
            Console.WriteLine("Grade: " + Student(i).Grade.ToString)
        End If
    End Sub
    Sub editStudent()
        Do
            Console.WriteLine("Edit Menu:")
            Console.WriteLine("Which student is it?")
            Dim i As Integer = Console.ReadLine()
            Console.WriteLine("___________________________________________")
            Console.WriteLine("1 – ID: " + Student(i).ID.ToString)
            Console.WriteLine("2 – First name: " + Student(i).fName.ToString)
            Console.WriteLine("3 – Surname: " + Student(i).Sname.ToString)
            Console.WriteLine("4 – Grade: " + Student(i).Grade.ToString)
            Console.WriteLine("9 - Exit this menu")
            Console.WriteLine("___________________________________________")
            Console.WriteLine("What would you like to change?")
            Dim choice As Integer = Console.ReadLine()
            Select Case choice
                Case 1
                    Console.Write("Please enter the student's new ID: ")
                    Student(i).ID = Console.ReadLine()
                Case 2
                    Console.Write("Please enter the student's new first name: ")
                    Student(i).fName = Console.ReadLine()
                Case 3
                    Console.Write("Please enter the student's new surname: ")
                    Student(i).Sname = Console.ReadLine()
                Case 4
                    Console.Write("Please enter the student's new grade")
                    Student(i).Grade = Console.ReadLine()
                Case 9
                    Exit Do
            End Select
        Loop
    End Sub
    Sub deleteStudent()
        Console.WriteLine("Which student is it?")
        Dim i As Integer = Console.ReadLine
        Student(i).ID = Nothing
        Student(i).fName = Nothing
        Student(i).Sname = Nothing
        Student(i).Grade = Nothing
    End Sub
    Sub savestudents()
        Dim FullLine As String = ""
        FileOpen(1, "N:\Desktop\Wraowlafi.txt", OpenMode.Output)
        For i As Integer = 1 To 100
            If Student(i).ID = Nothing Or "0" Then
                Exit For
            End If
            Dim Item() As String = Split(FullLine, ",")
            FullLine = Student(i).ID & ", " & Student(i).fName & ", " & Student(i).Sname & ", " & Student(i).Grade
            PrintLine(1, FullLine)
        Next
        Console.WriteLine("STUDENTS SAVED TO FILE")
        FileClose(1)
    End Sub
End Module
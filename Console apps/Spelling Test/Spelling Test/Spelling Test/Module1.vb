Module Module1
    Structure record
        Dim fName As String 'fName stores the student's first name.
        Dim sName As String 'sName stores the student's last name.                            <-------- Details of students stored in file
        Dim datecounter As Integer 'Stores the number of tests the student has done and is reset once 6 weeks have passed since the date of the first test in order to calculate improvement.
        Dim Merit As Boolean 'Stores how many merits the student has earned.
        Dim DateOfLatestTest As Date 'Stores the date on which the student took their most recent test.
        Dim WeekScore As Integer 'Stores the student's score in their most recent test.
        Dim TermScore As Integer 'Stores the total score of a student over 6 weeks.
        Dim PrevTermScore As Integer 'Stores the total score of a student over the previous 6 weeks in order to calculate improvement.
        Dim improvement As Integer 'Stores the student's improvement (TermScore-PrevTermScore)
    End Structure
    Dim student(100) As record 'Stores up to 100 students. Only one year group should be loaded into the system at any one time so 100 has been set as the limit.
    Sub Main()
        MainMenu()
    End Sub
    Private Sub MainMenu() 'Allows the user to add student, login as student or login as teacher.
        Dim check As String = "a" 'Stores a, a non-numeric value at first. When the user inputs something for a choice selection, the value of check will be stored in choice if it is a numeric value that is entered.
        Dim choice As Integer 'Stores the choice which the user enters for selection in the menu.
        Console.ForegroundColor = ConsoleColor.White
        Console.BackgroundColor = ConsoleColor.Blue
        Console.WriteLine("Welcome to the weekly spelling test program, Spelling Bee." & vbNewLine)
        Console.ForegroundColor = ConsoleColor.Gray
        Console.BackgroundColor = ConsoleColor.Black
        Do
            Console.WriteLine("Main menu:")
            Console.WriteLine("___________________________________________")
            Console.ForegroundColor = ConsoleColor.Cyan
            Console.WriteLine("1 – Student login")
            Console.ForegroundColor = ConsoleColor.Magenta
            Console.WriteLine("2 – Teacher login")
            Console.ForegroundColor = ConsoleColor.Yellow
            Console.WriteLine("3 – New student")
            Console.ForegroundColor = ConsoleColor.Gray
            Console.WriteLine("___________________________________________")
            Console.Write("What would you like to do?: ")
            Do
                check = Console.ReadLine
                If IsNumeric(check) Then
                    choice = check
                Else                                         '<----------------- Switch to teacher or student menu from this main menu
                    Console.BackgroundColor = ConsoleColor.White
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("Please enter a numerical value")
                    Console.BackgroundColor = ConsoleColor.Black
                    Console.ForegroundColor = ConsoleColor.Gray
                End If
            Loop While Not IsNumeric(choice)
            Select Case choice
                Case 1
                    studentlogin()
                Case 2
                    teacherlogin()
                Case 3
                    addstudent()
            End Select
        Loop
    End Sub
    Private Sub addstudent() 'Allows user to add a student using a first name and a last name. A student record is then appended at the end of the appropriate file.
        Dim check As String = "a" 'Stores a, a non-numeric value at first. When the user inputs something for a choice selection, the value of check will be stored in choice if it is a numeric value that is entered.
        Dim choice As Integer 'Stores the choice which the user enters for selection in the menu.
        Dim Fullline As String = "" 'Stores the full line which will be added to file (student and all student variables in this case).
        Dim Item() As String 'Stores the parts of the full line which will be all the variables under a student record.
        Dim firstname As String 'Stores the firstname of the student to be added.
        Dim lastname As String 'Stores the lastname of the student to be added.
        Console.Write("Which year group are you in?: ")
        Do
            check = Console.ReadLine
            If IsNumeric(check) Then
                choice = check
            Else
                Console.Write("Please enter a number between 3 and 6: ")
            End If
        Loop While Not IsNumeric(check)
        If My.Computer.FileSystem.FileExists(CurDir() & "\Year" & choice.ToString & ".txt") Then
            FileOpen(1, CurDir() & "\Year" & choice.ToString & ".txt", OpenMode.Append)
            Console.Write("Please enter your first name: ")
            firstname = Console.ReadLine
            Console.Write("Please enter your last name: ")                                                                     '<---------- Adds a new student to file using append mode on the end of the file.
            lastname = Console.ReadLine
            Item = Split(Fullline, ", ")
            Fullline = firstname & ", " & lastname & ", " & 0 & ", " & False & ", " & "01/08/2015" & ", " & 0 & ", " & 0 & ", " & 0 & ", " & 0
            PrintLine(1, Fullline)
            Console.ForegroundColor = ConsoleColor.Black
            Console.BackgroundColor = ConsoleColor.Green
            Console.WriteLine(vbNewLine & "You have been added to the file." & vbNewLine)
            Console.BackgroundColor = ConsoleColor.Black
            Console.ForegroundColor = ConsoleColor.Gray
            FileClose(1)
        Else
            Console.BackgroundColor = ConsoleColor.White
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine(vbNewLine & "File seems to be missing, please check that the file is present in the current directory." & vbNewLine)
            Console.BackgroundColor = ConsoleColor.Black
            Console.ForegroundColor = ConsoleColor.Gray
        End If
    End Sub
    Private Sub studentlogin() 'Allows user to login as student using firstname, lastname and year group. Then Moves to load students and test subroutines.
        Dim check As String = "a" 'Stores a, a non-numeric value at first. When the user inputs something for a choice selection, the value of check will be stored in choice if it is a numeric value that is entered.
        Dim choice As Integer 'Stores the choice which the user enters for selection in the menu.
        Dim ID As Integer = 0 'An index for identifying a student in the array.
        Dim firstname As String 'Stores the user's firstname in order to do a linear search for the student in the file.
        Dim lastname As String 'Stores the user's firstname in order to do a linear search as well. 2 students could have the same firstname so lastname is checked as well.
        Dim fullline As String = "" 'Stores a full line that will be input or output from a file.
        Console.Write("Which year group are you in?: ")
        Do
            check = Console.ReadLine
            If IsNumeric(check) And (check > 2 And check < 7) Then
                choice = check
            Else
                Console.BackgroundColor = ConsoleColor.White
                Console.ForegroundColor = ConsoleColor.Red
                Console.Write("Please enter a numerical value between 3 and 6: ")
                Console.BackgroundColor = ConsoleColor.Black
                Console.ForegroundColor = ConsoleColor.Gray
            End If
        Loop While Not IsNumeric(check) And Not (check > 2 And check < 7)
        Console.Write("What is your first name?: ")
        firstname = Console.ReadLine
        Console.Write("What is your last name?: ")
        lastname = Console.ReadLine
        If My.Computer.FileSystem.FileExists(CurDir() & "\Year" & choice & ".txt") Then
            FileOpen(1, CurDir() & "\Year" & choice & ".txt", OpenMode.Input)
            Do While Not EOF(1)
                fullline = LineInput(1)
                Dim item() As String = Split(fullline, ", ") 'Splits full line into separate parts where there are commas and stores each part in this array.
                If firstname.ToLower = item(0).ToLower And lastname.ToLower = item(1).ToLower Then
                    With student(ID)
                        .fName = item(0)
                        .sName = item(1)
                        .datecounter = item(2)
                        .Merit = item(3)
                        .DateOfLatestTest = item(4)
                        .WeekScore = item(5)
                        .TermScore = item(6)
                        .PrevTermScore = item(7)
                        .improvement = item(8)
                    End With
                    Exit Do                                                        '<----------------------- Does a linear search to check which year a student is in using the first name and then moves to the test subroutine.
                Else
                    ID += 1
                End If
            Loop
            FileClose(1)
        Else
            Console.BackgroundColor = ConsoleColor.White
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine(vbNewLine & "File seems to be missing, please check that the file is present in the current directory." & vbNewLine)
            Console.BackgroundColor = ConsoleColor.Black
            Console.ForegroundColor = ConsoleColor.Gray
        End If
        If student(ID).fName = Nothing Then
            Console.BackgroundColor = ConsoleColor.White
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine(vbNewLine & "Sorry, you are not in the database." & vbNewLine)
            Console.BackgroundColor = ConsoleColor.Black
            Console.ForegroundColor = ConsoleColor.Gray
        Else
            Select Case choice
                Case "3"
                    LoadStudents(choice)
                    test(choice, ID)
                Case "4"
                    LoadStudents(choice)
                    test(choice, ID)
                Case "5"
                    LoadStudents(choice)
                    test(choice, ID)
                Case "6"
                    LoadStudents(choice)
                    test(choice, ID)
            End Select
        End If
    End Sub
    Private Sub test(ByVal choice As Integer, ByVal ID As Integer) 'Allows the student to take the test. Mistakes are checked using the minorError subroutine. Student record variables are altered according to the test result and then saved to file.
        Dim day As Integer = DatePart(DateInterval.Weekday, Today) - 1 'Current day needed to check that it is friday. Holds the number of the day of the week.
        'If day = 5 Then                                                'If it is Friday, the test will be taken. Otherwise, the student will be logged out as it is not the day for the test.
        Dim word As String 'Stores the spelling that the student inputs.
        Dim fullline As String = "" 'Stores the full line that will be input/output. In this case, the spellings are being input into the system.
        Dim spelling(2, 10) As String 'Stores the spelling and its definition in a 2D array. If imagined in a grid, spelling in the first column and definition in the second.
        Dim aspelling As String 'Stores the current spelling that is being tested in order to be passed into the MinorError subroutine to check if one mark can be awarded.
        Dim i As Integer = 1 'Stores the index for the loop to input all the spellings and definitions, 1 to 10.
        Dim Item() As String 'Stores the parts of the full line separated by commas (spelling, definition).
        Dim mistakes(2, 10) As String 'Stores the mistakes the student has made along with the correct spelling.
        student(ID).WeekScore = 0
        If student(ID).DateOfLatestTest = Today Then
            Console.WriteLine("You have already taken the spelling test for this week.")
            Main()
        End If
        If My.Computer.FileSystem.FileExists(CurDir() & "\Year" & choice & "test.txt") Then
            FileOpen(1, CurDir() & "\Year" & choice & "test.txt", OpenMode.Input)
            Do While Not EOF(1)
                fullline = LineInput(1)
                Item = Split(fullline, ", ")
                spelling(1, i) = Item(0)
                spelling(2, i) = Item(1)
                i = i + 1                                                                       '<------ Opens correct file using the choice from the previous sub, loads the spellings, definitions and minor mistakes.
            Loop
            FileClose(1)
        Else
            Console.BackgroundColor = ConsoleColor.White
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine(vbNewLine & "File seems to be missing, please contact a teacher for help." & vbNewLine)
            Console.BackgroundColor = ConsoleColor.Black
            Console.ForegroundColor = ConsoleColor.Gray
            Exit Sub
        End If
        For I2 As Integer = 1 To 10 'Outputs the definition 1 to 10 and allows the user to input after each one.
            Console.BackgroundColor = ConsoleColor.Black
            Console.ForegroundColor = ConsoleColor.Cyan
            Console.WriteLine(I2 & ")Definition: " & spelling(2, I2))
            Console.BackgroundColor = ConsoleColor.DarkBlue
            Console.Write("Please enter the word: ")
            Console.ForegroundColor = ConsoleColor.Black
            Console.ForegroundColor = ConsoleColor.Yellow
            word = Console.ReadLine
            If word.ToLower = spelling(1, I2).ToLower Then
                student(ID).WeekScore += 2
            Else
                aspelling = spelling(1, I2)
                mistakes(1, I2) = word
                mistakes(2, I2) = spelling(1, I2)
                MinorError(word, aspelling, ID)
            End If
        Next
        student(ID).DateOfLatestTest = Today                                                   '<---------- Increases the student's weekscore by 2 or 1. Then the date counter for the student is increased by 1.
        student(ID).datecounter += 1
        If student(ID).datecounter = 6 Then
            student(ID).PrevTermScore = student(ID).TermScore
            student(ID).improvement = student(ID).TermScore - student(ID).PrevTermScore                   '<---------- Calculates the students improvement once the date counter has reached 6 weeks (one half term).
            student(ID).TermScore = 0
            If student(ID).improvement > 15 Then
                student(ID).Merit = True                                                                   '<---------- Student is given a merit for this improvement if their total score has increased by 15 or more.
            End If
        Else
            student(ID).TermScore += student(ID).WeekScore
        End If
        If My.Computer.FileSystem.FileExists(CurDir() & "\Year" & choice & "Historic.txt") Then
            FileOpen(1, CurDir() & "\Year" & choice & "Historic.txt", OpenMode.Append)
            With student(ID)
                fullline = .fName & ", " & .sName & ", " & .WeekScore
            End With
            PrintLine(1, fullline)
            FileClose(1)
            SaveStudents(choice)                 'Moves to the student saving sub routine to save results etc.
            Console.WriteLine("You scored: " & student(ID).WeekScore & " out of 20 which is " & (student(ID).WeekScore / 20) * 100 & "%")       'Displays the students test results.
            Console.WriteLine(vbNewLine & "Corrections: " & vbNewLine)
            Console.ForegroundColor = ConsoleColor.Gray
            Console.BackgroundColor = ConsoleColor.Black
            For corrections As Integer = 1 To 10 'Outputs all the mistakes and corrections.
                If mistakes(1, corrections) = Nothing Then
                Else
                    Console.WriteLine("Mispelt word: ".PadLeft(10) & mistakes(1, corrections).PadLeft(10) & Space(5) & " Correct spelling: ".PadLeft(10) & mistakes(2, corrections).PadLeft(10))
                End If
            Next
        Else
            Console.BackgroundColor = ConsoleColor.White
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine(vbNewLine & "File seems to be missing, please check that the file is present in the current directory." & vbNewLine)
            Console.BackgroundColor = ConsoleColor.Black
            Console.ForegroundColor = ConsoleColor.Gray
        End If
        'Else
        Console.BackgroundColor = ConsoleColor.White
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine(vbNewLine & "You may only take the test on a friday." & vbNewLine)
        Console.BackgroundColor = ConsoleColor.Black
        Console.ForegroundColor = ConsoleColor.Gray
        'End If
    End Sub
    Private Sub MinorError(ByVal word As String, ByVal aspelling As String, ByVal ID As Integer) 'The mispelt word and spelling are split into characters. Depending on the length of the word and how many characters match, the student may be awarded one minor error mark.
        Dim SpellingLetters() As Char 'Stores each character of aspelling in an array.
        Dim wordLetters() As Char 'Stores each character of the student input spelling in an array.
        Dim matchcounter As Integer = 0 'Counter for the number of characters of the spelling that match the input word.
        Dim i As Integer = 0 'Stores the index of the characters in the arrays. Once the index has reached the length of the word, the loop that checks for matching characters is exited.
        Dim DiffInLength As Integer 'Stores the difference in the lengths of the actual spelling and the student's spelling in order to cut out extra characters or fill in missing characters that were/weren't input.
        DiffInLength = aspelling.Length - word.Length
        If DiffInLength > 0 Then
            For diff As Integer = 0 To DiffInLength - 1 'Adds # onto the word for each missing character so the word and spelling are the same length.
                word = word & "#"
            Next
        End If
        SpellingLetters = aspelling.ToLower.ToCharArray
        wordLetters = word.ToLower.ToCharArray()
        Do
            If wordLetters(i) = (SpellingLetters(i)) Then
                matchcounter += 1
            End If
            i += 1
            If i = aspelling.Length Then
                Exit Do
            End If
        Loop
        If matchcounter = (aspelling.Length - 1 And aspelling.Length <= 5) Or (matchcounter = aspelling.Length And aspelling.Length <= 5) Then
            student(ID).WeekScore += 1
        End If
        If (matchcounter = aspelling.Length - 2 And aspelling.Length > 5) Or (matchcounter = aspelling.Length - 1 And aspelling.Length > 5) Or (matchcounter = aspelling.Length And aspelling.Length > 5) Then
            student(ID).WeekScore += 1
        End If
    End Sub
    Private Sub LoadStudents(ByVal choice As Integer) 'A full year group of students are loaded into the system.
        Dim fullline As String = "" 'Stores the full line that will be input into the system.
        Dim Item() As String 'Stores the parts of the full line, in this case, each variable that is stored in a student record. (All separated by commas in the file).
        Dim i As Integer = 0 'Index for student array.
        If My.Computer.FileSystem.FileExists(CurDir() & "\Year" & choice & ".txt") Then
            FileOpen(1, CurDir() & "\Year" & choice & ".txt", OpenMode.Input)
            Do While Not EOF(1)
                fullline = LineInput(1)
                Item = Split(fullline, ", ")
                With student(i)
                    .fName = Item(0)
                    .sName = Item(1)
                    .datecounter = Item(2)
                    .Merit = Item(3)
                    .DateOfLatestTest = Item(4)
                    .WeekScore = Item(5)
                    .TermScore = Item(6)
                    .PrevTermScore = Item(7)
                    .improvement = Item(8)
                End With
                i = i + 1                                                                       '<------ Opens correct file using the choice from the previous sub, loads the spellings, definitions and minor mistakes.
            Loop
            FileClose(1)
        Else
            Console.BackgroundColor = ConsoleColor.White
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine(vbNewLine & "File seems to be missing, please check that the file is present in the current directory." & vbNewLine)
            Console.BackgroundColor = ConsoleColor.Black
            Console.ForegroundColor = ConsoleColor.Gray
        End If
    End Sub
    Private Sub SaveStudents(ByVal choice As Integer) 'All students currently loaded into the system will be saved to the appropriate file.
        Dim FullLine As String = "" 'Stores the full line that will be output into the file, in this case, the full line is all of the variables in a student record separated by commas.
        If My.Computer.FileSystem.FileExists(CurDir() & "\Year" & choice & ".txt") Then
            FileOpen(1, CurDir() & "\Year" & choice & ".txt", OpenMode.Output)
            For i As Integer = 0 To 99  '<------------- Saves all students that are loaded into the system to the file.
                If student(i).fName = Nothing Then
                    Exit For
                End If
                With student(i)
                    FullLine = .fName & ", " & .sName & ", " & .datecounter & ", " & .Merit & ", " & .DateOfLatestTest & ", " & .WeekScore & ", " & .TermScore & ", " & .PrevTermScore & ", " & .improvement
                End With
                PrintLine(1, FullLine)
            Next
            FileClose(1)
        Else
            Console.BackgroundColor = ConsoleColor.White
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine(vbNewLine & "File seems to be missing, please check that the file is present in the current directory." & vbNewLine)
            Console.BackgroundColor = ConsoleColor.Black
            Console.ForegroundColor = ConsoleColor.Gray
        End If
    End Sub
    Private Sub teacherlogin() 'Allows a teacher to login using the password masterpass and selecting their year group. Then moves to teacher menu subroutine.
        Dim check As String = "a" 'Stores a, a non-numeric value at first. When the user inputs something for a choice selection, the value of check will be stored in choice if it is a numeric value that is entered.
        Dim choice As Integer 'Stores the choice which the user enters for selection in the menu.
        Console.Write("Please enter the teacher master password: ")
        Console.ForegroundColor = ConsoleColor.Black
        If Console.ReadLine = "masterpass" Then
            Console.ForegroundColor = ConsoleColor.Gray
            Console.Write("Which class do you teach? Please enter the year: ")
            Do
                check = Console.ReadLine
                If IsNumeric(check) And (check > 2 And check < 7) Then
                    choice = check
                Else
                    Console.BackgroundColor = ConsoleColor.White
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.Write("Please enter a numerical value between 3 and 6: ")
                    Console.BackgroundColor = ConsoleColor.Black
                    Console.ForegroundColor = ConsoleColor.Gray
                End If
            Loop While Not IsNumeric(check) And Not (check > 2 And check < 7)
            Select Case choice
                Case 3
                    LoadStudents(choice)
                    teachermenu(choice)
                Case 4
                    LoadStudents(choice)                      '<---------- If master password entered, loads the year group that the teacher teaches
                    teachermenu(choice)                      'by passing the year group number by value to the load subroutine and then loads the menu.
                Case 5
                    LoadStudents(choice)
                    teachermenu(choice)
                Case 6
                    LoadStudents(choice)
                    teachermenu(choice)
                Case 9
            End Select
        Else
            Console.ForegroundColor = ConsoleColor.Gray
            Exit Sub
        End If
    End Sub
    Private Sub teachermenu(ByVal choice As Integer) 'Gives the teacher a set of options to go to different sub-routines.
        Dim check As String = "a" 'Stores a, a non-numeric value at first. When the user inputs something for a choice selection, the value of check will be stored in choice if it is a numeric value that is entered.
        Dim choice2 As Integer 'Stores the choice which the user enters for selection in the menu. Cannot be the same as choice because choice now stores the year group that was chosen.
        Console.WriteLine("Welcome to the teachers menu")
        Do
            Console.WriteLine("Teacher's menu:")
            Console.WriteLine("___________________________________________")
            Console.WriteLine("1 – Input weekly spellings")
            Console.WriteLine("2 – Show student")
            Console.WriteLine("3 - Merit assembly(See merits to be awarded and most improved students)")
            Console.WriteLine("4 - Show all student results")
            Console.WriteLine("5 - End of year, clear year 6 and move all other years up")
            Console.WriteLine("9 - Exit")
            Console.WriteLine("___________________________________________")
            Console.Write("What would you like to do?: ")
            Do
                check = Console.ReadLine
                If IsNumeric(check) Then
                    choice2 = check
                Else
                    Console.Write("Please enter a numerical value: ")
                End If
            Loop While Not IsNumeric(check)
            Select Case choice2
                Case 1
                    inputSpellings(choice)
                Case 2
                    showStudent(choice)
                Case 3
                    ShowMostImproved(choice)
                Case 4
                    ShowHistoricResults(choice)
                Case 5
                    EndOfYear()
                Case 9
                    Exit Do
            End Select
        Loop
    End Sub
    Private Sub showStudent(ByVal choice As Integer) 'Allows the teacher to pick one student using their first and last name and shown their details.
        Dim firstname As String 'Stores the user's firstname in order to do a linear search for the student in the file.
        Dim lastname As String 'Stores the user's firstname in order to do a linear search as well. 2 students could have the same firstname so lastname is checked as well.
        Dim i As Integer 'Stores the index of the student that is going to be displayed.
        Dim MeritCheck As String = "" 'If the student does not have a merit, this will store "not" so the line below reads "Does not have a merit".
        Console.Write("What is the student's first name?: ")
        firstname = Console.ReadLine()
        Console.Write("What is the student's last name?: ")
        lastname = Console.ReadLine()
        i = 0
        For a As Integer = 0 To 99 'Linear search for a student using their first and lastname
            If student(a).fName = "" Then
                If a = 99 Then
                    Console.WriteLine("--------------------------------------")
                    Console.BackgroundColor = ConsoleColor.White
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("The student is not in the database")
                    Console.BackgroundColor = ConsoleColor.Black
                    Console.ForegroundColor = ConsoleColor.Gray
                    Console.WriteLine("--------------------------------------")
                    showStudent(choice)
                End If
            Else
                If student(a).fName.ToLower = firstname.ToLower And student(a).sName.ToLower = lastname.ToLower Then
                    i = a
                    Exit For
                ElseIf a = 99 Then
                    Console.WriteLine("--------------------------------------")
                    Console.BackgroundColor = ConsoleColor.White
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("The student is not in the database")
                    Console.BackgroundColor = ConsoleColor.Black
                    Console.ForegroundColor = ConsoleColor.Gray
                    Console.WriteLine("--------------------------------------")
                    showStudent(choice)
                End If
            End If
        Next
        Console.WriteLine(vbNewLine & "First name: " & student(i).fName.ToString)
        Console.WriteLine("Last name: " & student(i).sName.ToString)
        Console.WriteLine("Score in most recent test: " & student(i).WeekScore.ToString)
        Console.WriteLine("Date of most recent test: " & student(i).DateOfLatestTest.ToString)
        Console.WriteLine("Improvement in score between recent and previous half terms: " & student(i).improvement.ToString)
        If student(i).Merit = False Then MeritCheck = "not "
        Console.WriteLine("The student has " & MeritCheck & "received a merit this half term.")
        Console.WriteLine("Display all of this student's test results? Enter y if yes or any other key if no.")
        If Console.ReadLine = "y" Then
            ShowStudentResults(firstname, lastname, choice)
        End If
        Console.WriteLine()
    End Sub
    Private Sub ShowStudentResults(ByVal firstname As String, ByVal lastname As String, ByVal choice As Integer) 'Shows all the test results of the student selected in the previous sub-routine.
        Dim i As Integer = 1 'Stores the index of the tests for the student.
        Dim numberoftests As Integer = 1 'Stores the number of tests the student has taken.
        Dim fullline As String 'Stores the full line that will be input into the system. In this case, the student's first and last name to check it is the correct student and then their test score.
        Dim scores(100) As Integer 'Stores all the student's test scores in an array.
        Dim Item() As String 'Stores the parts of the full line (firstname, lastname, score are the three items).
        If My.Computer.FileSystem.FileExists(CurDir() & "\Year" & choice & "Historic.txt") Then
            FileOpen(1, CurDir() & "\Year" & choice & "Historic.txt", OpenMode.Input)
            Do While Not EOF(1)
                fullline = LineInput(1)
                Item = Split(fullline, ", ")
                If Item(0).ToLower = firstname.ToLower And Item(1).ToLower = lastname.ToLower Then
                    scores(i) = Item(2)
                    i += 1
                    numberoftests += 1                                                              '<------ Opens correct file using the choice from the previous sub, loads the spellings, definitions and minor mistakes.
                End If
            Loop
            FileClose(1)
        Else
            Console.BackgroundColor = ConsoleColor.White
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine(vbNewLine & "File seems to be missing, please check that the file is present in the current directory." & vbNewLine)
            Console.BackgroundColor = ConsoleColor.Black
            Console.ForegroundColor = ConsoleColor.Gray
        End If
        Console.WriteLine("Test".PadLeft(2) & Space(5) & "Score".PadRight(2))
        For history As Integer = 1 To numberoftests - 1 'Outputs all of the student's score from 1 to the number of tests they have taken.
            Console.WriteLine(history & Space(4).PadLeft(2) & Space(5) & scores(history).ToString.PadRight(2))
        Next
    End Sub
    Private Sub ShowHistoricResults(ByVal choice As Integer) 'Shows all the test results of the tests taken by a year group in a grid using a 2D array.
        Dim id As Integer = 0 'Stores the index of the student in the array of students.
        Dim numberoftests As Integer = 1 'Stores the number of tests the current student has taken.
        Dim fullline As String 'Stores the full line that will be input into the system, first this will be the scores of the student, and then the student's names.
        Dim scores(100, 100) As Integer 'Stores the student's scores, the number of the test in the first column and the score itself in the second.
        Dim Item() As String 'Stores the part of the fullline that will be input into the system (firstname, lastname, score)
        Dim i As Integer = 1 'Stores the index of the student in the students array.
        Console.WriteLine()
        If My.Computer.FileSystem.FileExists(CurDir() & "\Year" & choice & "Historic.txt") Then
            Do
                FileOpen(1, CurDir() & "\Year" & choice & "Historic.txt", OpenMode.Input)
                Do While Not EOF(1)
                    fullline = LineInput(1)
                    Item = Split(fullline, ", ")
                    If Item(0).ToLower = student(id).fName.ToLower And Item(1).ToLower = student(id).sName.ToLower Then
                        scores(id, numberoftests) = Item(2)
                        numberoftests += 1                      '<------ Opens correct file using the choice from the previous sub.
                    End If
                Loop
                FileClose(1)
                id += 1
                numberoftests = 1
            Loop Until student(id).fName = Nothing
        Else
            Console.BackgroundColor = ConsoleColor.White
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine(vbNewLine & "File seems to be missing, please check that the file is present in the current directory." & vbNewLine)
            Console.BackgroundColor = ConsoleColor.Black
            Console.ForegroundColor = ConsoleColor.Gray
        End If
        Console.WriteLine("Name".PadLeft(12) & Space(5) & "Test scores".PadLeft(30))
        id = 0
        Do
            Console.Write(student(id).fName.PadLeft(12) & Space(1) & student(id).sName.PadLeft(12) & Space(2))
            i = 1
            Do
                Console.Write(scores(id, i).ToString.PadLeft(20) & Space(5))
                i += 1
            Loop Until scores(id, i) = Nothing
            Console.WriteLine()
            id += 1
        Loop Until student(id).fName = Nothing
        FileClose(1)
        Console.WriteLine()
    End Sub
    Private Sub ShowMostImproved(ByVal choice As Integer) 'Displays the students in order of most improved to least improved and gives the teacher the option to see all students or just the ones who will be awarded.
        Dim students(2, 100) As String 'Stores the student's firstname and lastname in first index column and their improvement in the second.
        Dim i As Integer = 0 'Index for students.
        Console.WriteLine(vbNewLine)
        Console.WriteLine("The following students should be awarded during the merit assembly:" & vbNewLine & "(descending from most improved to least improved" & vbNewLine)
        Console.WriteLine("Name".PadLeft(25) & Space(6) & "Improvement".PadLeft(25))
        Do
            i += 1
        Loop Until student(i).fName = Nothing
        SortStudentsImprovement(i)
        For id As Integer = 0 To i 'Stores imrovements and names into the 2D array, loops for every student in the system (1 to the number of students).
            If student(id).Merit = True Then
                students(1, id) = student(id).fName & "_" & student(id).sName
                students(2, id) = student(id).improvement
            End If
        Next
        For i2 As Integer = 0 To 99 'Outputs all of the students along with their improvement.
            If students(1, i2) = Nothing Then
                Exit For
            End If
            Console.WriteLine(students(1, i2).PadLeft(25) & Space(6) & students(2, i2).PadLeft(25))
        Next
        Console.WriteLine(vbNewLine & "If you would like to see all students (most improved to least improved, enter y")
        If Console.ReadLine.ToLower = "y" Then
            For id As Integer = 0 To i - 1 'Stores improvements and names of all students not just ones with merits.
                students(1, id) = student(id).fName & "_" & student(id).sName
                students(2, id) = student(id).improvement
            Next
            For i2 As Integer = 0 To 99 'Outputs all of the students along with their improvement.
                If students(1, i2) = Nothing Then
                    Exit For
                End If
                Console.WriteLine(students(1, i2).PadLeft(25) & Space(6) & students(2, i2).PadLeft(25))
            Next
            Console.WriteLine()
        Else
            Exit Sub
        End If
    End Sub
    Private Sub SortStudentsImprovement(ByVal i As Integer) 'Sorts all the students in the system based on their improvement, highest to lowest, using a bubble sort.
        Dim swapped As Boolean = False 'Keeps track of whether or not values have been swapped during the bubble sort.
        Do
            swapped = False
            For sortloop As Integer = 0 To i - 1 'Bubble sorts all students in system.
                If student(sortloop).improvement < student(sortloop + 1).improvement Then
                    Dim temporary As record = student(sortloop + 1) 'Temporary storage for the student records to be swapped.
                    student(sortloop + 1) = student(sortloop)
                    student(sortloop) = temporary
                    swapped = True
                End If
            Next
        Loop Until swapped = False
    End Sub
    Private Sub inputSpellings(ByVal choice As Integer) 'Allows the teacher to input 10 words with 10 definitions in a 2D array and these are stored in the test file.
        Dim i As Integer = 1 'Index for spellings.
        Dim spelling(2, 10) As String '(imagine in table), stores spelling in first column and definitions in second.
        Dim Fullline As String 'Stores the line that will be input into the file (spelling, definition).
        Dim Item() As String 'Stores the parts of the full line (the spelling and the definition).
        If My.Computer.FileSystem.FileExists(CurDir() & "\Year" & choice.ToString & "Test.txt") Then
            FileOpen(1, CurDir() & "\Year" & choice.ToString & "Test.txt", OpenMode.Output)
            Fullline = ""
            Item = Split(Fullline, ", ")
            For spellings As Integer = 1 To 10 'Allows teacher to input 10 spellings and definitions.
                Console.Write("Please enter word number " & i & ":")
                spelling(1, i) = Console.ReadLine
                Console.Write("Please enter the definition of the word: ")
                spelling(2, i) = Console.ReadLine
                Fullline = spelling(1, i) & ", " & spelling(2, i)
                PrintLine(1, Fullline)
                i = i + 1
            Next
            FileClose(1)
            Exit Sub
        Else
            Console.BackgroundColor = ConsoleColor.White
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine(vbNewLine & "File seems to be missing, please check that the file is present in the current directory." & vbNewLine)
            Console.BackgroundColor = ConsoleColor.Black
            Console.ForegroundColor = ConsoleColor.Gray
        End If
    End Sub
    Private Sub EndOfYear() 'Clears year 6, move years 3, 4 and 5 up and then clears year 3 for new students.
        Dim choice As Integer = 5 'Stores which year group is currently selected for loading/saving sub-routines.
        Console.WriteLine("Please enter the end of year password")
        If Not Console.ReadLine = "endofyearpass" Then
            Console.WriteLine("Sorry, that is not the correct password")
            Main()
        End If
        LoadStudents(choice)               'Load year 5
        choice = 6
        SaveStudents(choice)               'Save year 5 to year 6 file
        For a As Integer = 0 To 99 'Clears students from system.
            student(a) = Nothing
        Next
        choice = 4
        LoadStudents(choice)               'Load year 4
        choice = 5
        SaveStudents(choice)               'Save year 4 to year 5 file
        For a As Integer = 0 To 99 'Clears students from system.
            student(a) = Nothing
        Next
        choice = 3                         'Load year 3
        LoadStudents(choice)
        choice = 4
        SaveStudents(choice)               'Save year 3 to year 4 file
        If My.Computer.FileSystem.FileExists(CurDir() & "\Year3.txt") Then
            FileOpen(1, CurDir() & "\Year3.txt", OpenMode.Output)
        Else
            Console.BackgroundColor = ConsoleColor.White
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine(vbNewLine & "File seems to be missing, please check that the file is present in the current directory." & vbNewLine)
            Console.BackgroundColor = ConsoleColor.Black
            Console.ForegroundColor = ConsoleColor.Gray
        End If
        For i As Integer = 3 To 6 'Clears all historic test result files (years 3 to 6)
            If My.Computer.FileSystem.FileExists(CurDir() & "\Year" & i & "Historic.txt") Then
                FileOpen(1, CurDir() & "\Year" & i & "Historic.txt", OpenMode.Output)
                FileClose(1)
            Else
                Console.BackgroundColor = ConsoleColor.White
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine(vbNewLine & "File seems to be missing, please check that the file is present in the current directory." & vbNewLine)
                Console.BackgroundColor = ConsoleColor.Black
                Console.ForegroundColor = ConsoleColor.Gray
            End If
        Next
        Console.WriteLine("Please enter the new year 3 students using the add student option in the main menu.")
    End Sub
End Module
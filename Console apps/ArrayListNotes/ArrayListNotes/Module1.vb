Module Module1

    Sub Main()
        Dim Notes As New ArrayList
        Do
            Notes.Sort()
            Console.WriteLine(vbNewLine & "Main menu:")
            Console.WriteLine("___________________________________________")
            Console.WriteLine("1 – Show all notes")
            Console.WriteLine("2 – Add a note")
            Console.WriteLine("3 – Overwrite a note")
            Console.WriteLine("4 – Remove a note")
            Console.WriteLine("___________________________________________")
            Console.WriteLine("What would you like to do?" & vbNewLine)
            Dim choice As Integer = Console.ReadLine()
            Select Case choice
                Case 1
                    Dim a As Integer = 0
                    For i = 0 To Notes.Count - 1
                        Console.WriteLine(i & ": " & Notes.Item(i))
                    Next
                Case 2
                    Console.Write("Enter note: ")
                    Notes.Add(Console.ReadLine)
                    Notes.Sort()
                Case 3
                    Console.WriteLine("Which note should be replaced?")
                    Dim i As Integer = Console.ReadLine
                    Console.WriteLine("Enter new note")
                    Notes.Insert(i, Console.ReadLine)
                    Notes.Remove(i + 1)
                Case 4
                    Console.WriteLine("Which note should be removed?")
                    Dim i As Integer = Console.ReadLine
                    Notes.Remove(Notes(i))
            End Select
        Loop
    End Sub

End Module

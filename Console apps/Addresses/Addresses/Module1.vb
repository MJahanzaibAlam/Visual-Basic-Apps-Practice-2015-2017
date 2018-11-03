Module Module1
    Structure Person
        Dim Title As String
        Dim Forename As String
        Dim Surname As String
        Dim Company As String
        Dim Town As String
        Dim County As String
        Dim Postcode As String
    End Structure
    Dim persons(250) As Person
    Sub Main()
        LoadCSV()
    End Sub
    Sub menu(ByVal i As Integer)
        Do
            Dim choice As Integer
            Console.WriteLine("--------------------------------------------------------------")
            Console.WriteLine("1 - Display list of the data")
            Console.WriteLine("2 - Find a person through their postcode") 'linear search
            Console.WriteLine("3 - Find a person through their company") 'binary search
            Console.WriteLine("4 - Show all data sorted by surname")
            Console.WriteLine("5 - Show all data sorted by postcode") 'insertion sort
            Console.WriteLine("--------------------------------------------------------------")
            choice = Console.ReadLine
            Select Case choice
                Case 1
                    Display(i)
                Case 2
                    LinearSearchPostCode()
                Case 3
                    BinarySearchCompany(i)
                Case 4
                    BubbleSortSurname(i)
                Case 5
                    InsertionSortPostCode(i)
            End Select
        Loop
    End Sub
    Private Sub LoadCSV()
        Dim i As Integer = 0
        If My.Computer.FileSystem.FileExists(CurDir() & "\address.csv") Then
            FileOpen(1, CurDir() & "\address.csv", OpenMode.Input)
            Do While Not EOF(1)
                Dim item() As String = Split(LineInput(1), ",")
                With persons(i)
                    .Title = item(0)
                    .Forename = item(1)
                    .Surname = item(2)
                    .Company = item(3)
                    .Town = item(4)
                    .County = item(5)
                    .Postcode = item(6)
                End With
                i += 1
            Loop
            FileClose(1)
        Else
            Console.WriteLine("File does not exist")
        End If
        menu(i)
    End Sub
    Private Sub Display(i)
        Console.WriteLine("Title".PadRight(5) & "Forename".PadRight(10) & "Surname".PadRight(15) & "Company".PadRight(60) & "Town".PadRight(28) & "County".PadRight(20) & "Postcode")
        For a As Integer = 0 To i - 1
            With persons(a)
                Console.WriteLine(.Title.PadRight(5) & .Forename.PadRight(10) & .Surname.PadRight(15) & .Company.PadRight(60) & .Town.PadRight(28) & .County.PadRight(20) & .Postcode)
            End With
        Next
    End Sub
    Private Sub LinearSearchPostCode()
        Console.Write(vbNewLine & "Please enter the person's postcode (with a space): ")
        Dim requestcode As String = Console.ReadLine
        Dim i As Integer = 0
        Do While Not (persons(i).Postcode = Nothing)
            'Do While persons(i).Postcode = Not (Nothing)
            If persons(i).Postcode = requestcode.ToUpper Then
                With persons(i)
                    Console.WriteLine(vbNewLine & .Title & Space(4) & .Forename & Space(4) & .Surname & Space(4) & .Company & Space(4) & .Town & Space(4) & .County & Space(4) & .Postcode)
                End With
                Exit Sub
            ElseIf i = 249 Then
                Console.WriteLine("Postcode not found")
                Exit Do
            Else
                i += 1
            End If
        Loop
    End Sub
    Private Sub BinarySearchCompany(ByVal i As Integer)
        Console.Write(vbNewLine & "Please enter the person's company (with spaces): ")
        Dim Requestcompany As String = Console.ReadLine.ToLower
        Dim LB As Integer = 0
        Dim UB As Integer = i - 1
        Dim MP As Integer
        Dim Found As Boolean = False
        Do While Found = False And LB <= UB
            MP = Math.Round((UB + LB) / 2)
            If persons(MP).Company.ToLower = Requestcompany Then
                Found = True
                Exit Do
            ElseIf persons(MP).Company.ToLower < Requestcompany Then ' And Not (persons(MP).Company = Nothing) Then
                LB = MP + 1
            Else
                UB = MP - 1
            End If
        Loop
        If Found = True Then
            Console.WriteLine("Item found at " & MP)
        Else
            Console.WriteLine("Item not in list")
        End If
    End Sub
    Private Sub BubbleSortSurname(ByVal i As Integer)
        Dim swapped As Boolean = True
        Do
            swapped = False
            For sortloop As Integer = 0 To i - 2
                If persons(sortloop).Surname > persons(sortloop + 1).Surname Then
                    Dim temporary As Person = persons(sortloop)
                    persons(sortloop) = persons(sortloop + 1)
                    persons(sortloop + 1) = temporary
                    swapped = True
                End If
            Next
        Loop Until swapped = False
        Display(i)
    End Sub
    Private Sub InsertionSortPostCode(ByVal i As Integer)
        Dim a, j As Integer
        For a = 1 To i - 1 Step 1
            Dim pick_item As Person = persons(a)
            Dim inserted As Integer = 0
            j = a - 1
            While (j >= 0 And inserted <> 1)
                If (pick_item.Postcode < persons(j).Postcode) Then
                    persons(j + 1) = persons(j)
                    j -= 1
                    persons(j + 1) = pick_item
                Else : inserted = 1
                End If
            End While
        Next
        Display(i)
    End Sub
End Module

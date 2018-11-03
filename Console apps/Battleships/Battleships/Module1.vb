Module Module1

    Sub Main()
        TwoPlayer()
    End Sub
    Sub TwoPlayer()
        Randomize()
        Dim Ships(10, 10) As Integer
        Dim Misses As Integer = 0
        Dim Score As Integer = 0
        Dim x As Integer
        Dim y As Integer
        For i As Integer = 1 To 5
            Randomize()
            x = Rnd() * 10
            y = Rnd() * 10
            Ships(x, y) = 1
        Next
        Dim a As Integer
        Dim b As Integer
        For i2 As Integer = 1 To 5
            Console.WriteLine("Enter the first co-ordinate of the ship")
            a = Console.ReadLine
            Console.WriteLine("Enter the second co-ordinate of the ship")
            b = Console.ReadLine
            If Ships(a, b) = 2 Then
                Console.WriteLine("----------------------------------------------")
                Console.WriteLine("You've already entered those co-ordinates")
                i2 = i2 - 1
                Console.WriteLine("----------------------------------------------" & vbNewLine)
            End If
            Ships(a, b) = 2
            If Ships(a, b) = 1 Then
                Console.WriteLine("----------------------------------------------")
                Console.WriteLine("You destroyed a ship!")
                Score += 1
                Console.WriteLine("Score = " & Score)
                Console.WriteLine("Misses = " & Misses)
                Console.WriteLine("----------------------------------------------" & vbNewLine)
            Else
                Console.WriteLine("----------------------------------------------")
                Console.WriteLine("There is no ship at that location.")

                Misses += 1
                Console.WriteLine("Score = " & Score)
                Console.WriteLine("Misses = " & Misses)
                Console.WriteLine("----------------------------------------------" & vbNewLine)
            End If
        Next
        Console.WriteLine("There were ships at the following co-ordinates:")
        Dim h As Integer
        For i As Integer = 1 To 10
            For i2 As Integer = 10 To 1 Step -1
                h = Ships(i, i2)
                If h = 1 Then
                    Console.WriteLine(i & Space(2) & i2)
                End If
            Next
        Next
        Console.ReadLine()
    End Sub
    Sub OnePlayer()
        Randomize()
        Dim Ships(10, 10) As Integer
        Dim Misses As Integer = 0
        Dim Score As Integer = 0
        Dim x As Integer
        Dim y As Integer
        For i As Integer = 1 To 5
            Randomize()
            x = Rnd() * 10
            y = Rnd() * 10
            Ships(x, y) = 1
        Next
        Dim a As Integer
        Dim b As Integer
        For i2 As Integer = 1 To 5
            Console.WriteLine("Enter the first co-ordinate of the ship")
            a = Console.ReadLine
            Console.WriteLine("Enter the second co-ordinate of the ship")
            b = Console.ReadLine
            If Ships(a, b) = 2 Then
                Console.WriteLine("----------------------------------------------")
                Console.WriteLine("You've already entered those co-ordinates")
                i2 = i2 - 1
                Console.WriteLine("----------------------------------------------" & vbNewLine)
            End If
            Ships(a, b) = 2
            If Ships(a, b) = 1 Then
                Console.WriteLine("----------------------------------------------")
                Console.WriteLine("You destroyed a ship!")
                Score += 1
                Console.WriteLine("Score = " & Score)
                Console.WriteLine("Misses = " & Misses)
                Console.WriteLine("----------------------------------------------" & vbNewLine)
            Else
                Console.WriteLine("----------------------------------------------")
                Console.WriteLine("There is no ship at that location.")

                Misses += 1
                Console.WriteLine("Score = " & Score)
                Console.WriteLine("Misses = " & Misses)
                Console.WriteLine("----------------------------------------------" & vbNewLine)
            End If
        Next
        Console.WriteLine("There were ships at the following co-ordinates:")
        Dim h As Integer
        For i As Integer = 1 To 10
            For i2 As Integer = 10 To 1 Step -1
                h = Ships(i, i2)
                If h = 1 Then
                    Console.WriteLine(i & Space(2) & i2)
                End If
            Next
        Next
        Console.ReadLine()
    End Sub
End Module

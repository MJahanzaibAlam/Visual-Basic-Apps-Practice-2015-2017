Module Module1

    Sub Main()
        Dim Question(15), Answer(15), RealAnswer(15) As String
        Question(1) = ("How tall is a duck in metres?")
        RealAnswer(1) = 2
        Question(2) = ("How old is the creator of this program?")
        RealAnswer(2) = 16
        Question(3) = ("How many years ago was this program made?")
        RealAnswer(3) = 0
        Question(4) = ("What do you use to pick up a spoon?")
        RealAnswer(4) = "Hand"
        Question(5) = ("What colour is a brown cat?")
        RealAnswer(5) = "brown"
        Question(6) = ("The answer to this question is 1 but what is the answer?")
        RealAnswer(6) = 1
        Question(7) = ("How many brothers does the creator of this program have?")
        RealAnswer(7) = 1
        Question(8) = ("How many sisters does the creator of this program have?")
        RealAnswer(8) = 1
        Question(9) = ("What is the name of the operating system currently in use?")
        RealAnswer(9) = "Windows 7"
        Question(10) = ("What is a chicken?")
        RealAnswer(10) = "An animal"
        Question(11) = ("What is a bedroom?")
        Question(12) = ("What is the capital city of Pakistan?")
        RealAnswer(11) = "A room"
        Question(13) = ("What is the name of this college?")
        RealAnswer(12) = "Islamabad"
        Question(14) = ("What is the colour of the taskbar on this operating system?")
        RealAnswer(14) = "blue"
        RealAnswer(13) = "Loreto"
        Question(15) = ("What was the answer to question 1?")
        RealAnswer(15) = 2
        For i = 1 To 15
            Console.WriteLine("Question " & i & ": " & Question(i))
            Answer(i) = Console.ReadLine()
        Next
        Dim score As Integer = 0
        For i = 1 To 15
            If RealAnswer(i) = Answer(i) Then
                score = score + 1
            End If
        Next
        Console.WriteLine(vbNewLine & "You scored " & score & " out of 15")
        Console.WriteLine()
        For i = 1 To 15
            Console.WriteLine(Question(i) & " Your answer was '" & Answer(i) & "', the real answer was: " & RealAnswer(i))
        Next
        Console.ReadKey()
    End Sub

End Module

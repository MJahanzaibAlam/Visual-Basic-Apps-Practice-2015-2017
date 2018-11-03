Module Module1

    Sub Main()
        Console.Title = "My Simple Calculator"
        Console.WriteLine("First number: ")
        Dim a As Integer = Console.ReadLine()
        Console.WriteLine("Second number: ")
        Dim b As Integer = Console.ReadLine()
        Dim c As Integer = a + b
        Dim d As Integer = a - b
        Dim e As Integer = a * b
        Dim f As Integer = a / b
        Console.Write(a.ToString + " + " + b.ToString)
        Console.WriteLine(" = " + c.ToString.PadLeft(3))
        Console.Write(a.ToString + " - " + b.ToString)
        Console.WriteLine(" = " + d.ToString.PadLeft(3))
        Console.Write(a.ToString + " x " + b.ToString)
        Console.WriteLine(" = " + e.ToString.PadLeft(3))
        Console.Write(a.ToString + " / " + b.ToString)
        Console.WriteLine(" = " + f.ToString.PadLeft(3))
        Console.Write("If you would like to change the title of this program, press y. ")
        Console.Write("If not, press n.")
        Dim z As Char = Console.ReadLine()
        If z = "y" Then
            Console.WriteLine("Enter new title of program: ")
            Dim j As String = Console.ReadLine()
            Console.Title = j
        End If
        If z = "n" Then
            Console.WriteLine("You chose not to change the title of the program.")
        End If
        Console.WriteLine("1")
        System.Threading.Thread.Sleep(10000)
        Console.WriteLine("2")
        Console.ReadKey()
    End Sub

End Module

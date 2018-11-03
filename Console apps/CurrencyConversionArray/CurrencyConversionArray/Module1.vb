Module Module1

    Sub Main()
        Dim Rate(5, 5) As String
        Rate(1, 1) = "Pounds"
        Rate(1, 2) = 1.5
        Rate(2, 1) = "Dollars"
        Rate(2, 2) = 1.44
        Rate(3, 1) = "Chinese Yuan"
        Rate(3, 2) = 9.5
        Rate(4, 1) = "Pakistani Rupees"
        Rate(4, 2) = 151.13
        Console.WriteLine("Please enter the amount of money you have in British pounds")
        Dim Money As Double = Console.ReadLine
        Console.WriteLine("Which currency would you like it converted to? 2-American, 3-China, 4-Pakistan")
        Dim i As Integer = Console.ReadLine
        Dim NewMoney As Double = Money * Rate(i, 2)
        Console.WriteLine(NewMoney & Space(1) & Rate(i, 1))
        Console.ReadKey()
    End Sub

End Module

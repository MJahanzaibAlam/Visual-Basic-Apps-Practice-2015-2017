Module Module1

    Sub Main()
        Console.Title = "Convert your age from years to days"
        Console.WriteLine("Please enter your age in years and it will be converted into days")
        Dim A As Integer = Console.ReadLine()
        Dim B As Double = A * 365.242
        Console.WriteLine("Your age in days is {0}", B)
        Console.ReadKey()
    End Sub

End Module

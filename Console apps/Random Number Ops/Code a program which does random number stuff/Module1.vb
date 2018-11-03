Module Module1

    Sub Main()
        Console.Title = "Unusual Program"
        Console.WriteLine("Please enter a number.")
        Dim A As Integer = Console.ReadLine()
        Console.WriteLine("Please enter a second number.")
        Dim B As Integer = Console.ReadLine()
        Console.WriteLine("Please enter a third number.")
        Dim C As Integer = Console.ReadLine()
        Dim Total As Integer = A + B + C
        Dim Average As Double = Total / 3
        Dim Fifth As Double = 0.2 * Total
        Console.WriteLine("The total of these numbers is {0} ", Total)
        Console.WriteLine("The average of these numbers is {0}", Average)
        Console.WriteLine("20% of these numbers is {0}", Fifth)
        Console.ReadKey()
    End Sub

End Module

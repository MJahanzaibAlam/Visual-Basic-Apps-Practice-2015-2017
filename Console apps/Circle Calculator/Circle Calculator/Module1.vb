Module Module1

    Sub Main()
        Dim pi As Double = "3.142"
        Dim area As Double
        Do
            Console.WriteLine("Please enter the radius of a circle to find its area")
            Dim radius As Integer = Console.ReadLine
            area = pi * radius * radius
            Console.WriteLine("The area of the circle is {0}", area)
        Loop While area > 30
        Console.ReadKey()
    End Sub

End Module


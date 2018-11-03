Module Module1

    Sub Main()
        Console.WriteLine("Tervuren Car Hire Company" & vbNewLine) 'Displays the text in quotes and adds two new lines.
        Console.Write("Please enter the make of your car: ") 'Displays the text asking the user for the make of the car.
        Dim make As String = Console.ReadLine() 'Allows the user to input the make of the car.
        Console.Write("Please enter the car model: ") 'Displays the text asking the user for the model of the car.
        Dim model As String = Console.ReadLine() 'Allows the user to input the model of the car.
        Console.Write("Please enter the daily rate: ") 'Displays the text asking the user for the daily rate.
        Dim rate As Integer = Console.ReadLine 'Allows the user to input the daily rate.
        Dim day As Integer = 1 'Defines day as the number 1
        Console.WriteLine("Day" & Space(2) & "Charge") 'Displays the words Day and Charge with two spaces in between.
        For Charge As Integer = rate To rate * 12 Step rate 'Defines Charge as a loop from the daily rate of one day to the daily rate of the 12th day going up by the rate each time.
            Console.WriteLine(day.ToString.PadLeft(2) & Space(4) & Charge.ToString.PadLeft(2)) 'Writes the charges for the first day to the 12th day with the charge 2 spaces after each day. 
            day = day + 1 'Increases the value in day by one so the next time the loop runs, the day displays the day number incremented by one.
        Next  'Ends the loop.
        If make = "VW" Then 'Creates an if statement, if the make is defined by the user as VW then...
            Console.WriteLine("YOU GET A FREE ROAD ATLAS WITH THIS HIRE") 'this message is displayed
        End If 'otherwise nothing happens.
        Console.ReadKey() 'Waits for the user to press a key. This stops the program from closing after the last task.
    End Sub

End Module

Module Module1

    Sub Main()
        Console.Title = "CPU ROM and RAM"
        Console.WriteLine("Please type in and enter either CPU, ROM or RAM to find out about the component.")
        Console.WriteLine("If you would like to find out about the differences between ROM and RAM, type in Differences and press enter")
        Console.ReadLine()
        If Console.ReadLine() = "CPU" Then
            Console.WriteLine("A CPU is a central processing unit, this consists of the processor, cache and main memory. The CPU carries out all the main tasks of a computer and manages the other components.")
        End If
        If Console.ReadLine() = "RAM" Then
            Console.WriteLine("RAM is random access memory which can load data from any place. It is read/write and volatile.")
        End If
        If Console.ReadLine() = "ROM" Then
            Console.WriteLine("ROM is read only memory which contains the main startup instructions for the computer. It is non volatile and read only.")
        End If
        If Console.ReadLine() = "Differences" Then
            Console.WriteLine("The differences between ROM and RAM are that RAM is random access memory which can access data from anywhere, it is read/write and volatile while ROM is read only and non volatile. ROM is slower than RAM.")
        End If
        Console.ReadKey()
    End Sub

End Module

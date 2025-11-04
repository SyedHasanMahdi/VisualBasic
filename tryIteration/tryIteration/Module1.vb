Module Module1
    '   Title:      tryIteration
    '   Author:     ME
    '   Version:    0.1
    '   Date:       08/10/2023
    '   Description:    Working with iterative statements
    Sub Main()
        '   Output the even numbers from 0 to 100

        Dim num1, num2, Steps As Integer
        Console.WriteLine("Please enter the starting value")
        num1 = Console.ReadLine
        Console.WriteLine("please enter the limit")
        num2 = Console.ReadLine
        Console.WriteLine("Enter a step for this list")
        Steps = Console.ReadLine()

        If num1 < num2 Then
            Console.WriteLine("Num1 is: " & num1)
            Console.WriteLine("Num2 is: " & num2)
            For index = num2 To num2 Step Steps
                Console.WriteLine(index)
            Next
        Else
            For index = num2 To num1 Step (-Steps)
                Console.WriteLine("Num1 is: " & num1)
                Console.WriteLine("Num2 is: " & num2)
                Console.WriteLine(index)
            Next
        End If
        Console.ReadLine()
    End Sub

End Module

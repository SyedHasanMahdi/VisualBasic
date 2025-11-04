Module Module1

    Sub Main()
        '   Title:          tryLoops
        '   Author:         Hasan
        '   Version:        0.1
        '   Date:           19/11/2024
        '   Desc:           Trying out the three programming constructs

        Dim num, counter As Integer

        Console.WriteLine("Enter a whole number")
        num = Console.ReadLine()

        For counter = 1 To num
            If counter Mod 4 = 0 Then
                Console.WriteLine(counter)
            End If
        Next

        counter = 1
        While counter <= num
            If counter Mod 4 = 0 Then
                Console.WriteLine(counter)
            End If
            counter = counter + 1
        End While

        counter = 1
        Do Until counter > num
            If counter Mod 4 = 0 Then
                Console.WriteLine(counter)
            End If
            counter = counter + 1
        Loop

        Dim num2 As Integer = 0
        Dim sum As Integer = 0

        counter = 1
        Console.WriteLine("Enter a number between 1 and 300 inclusive")
        num2 = Console.ReadLine()
        While num2 > 300 And num2 < 1 And num2 <> Math.Round(num2, 0)
            Console.WriteLine("Enter a number between 1 and 300 inclusive")
            num2 = Console.ReadLine()
        End While
        While counter <= num2
            If counter Mod 2 = 1 Then
                Console.WriteLine(counter)
                sum = sum + counter
            End If
            counter = counter + 1
        End While
        Console.WriteLine("The sum of odd numbers from 1 to " & num2 & " is " & sum)

        counter = 1
        sum = 0
        Console.WriteLine("Enter a number between 1 and 300 inclusive")
        num2 = Console.ReadLine()
        Do Until num2 >= 1 And num2 <= 300 And num2 = Math.Round(num2, 0)
            Console.WriteLine("Enter a number between 1 and 300 inclusive")
            num2 = Console.ReadLine()
        Loop
        Do Until counter = num2
            If counter Mod 2 = 1 Then
                Console.WriteLine(counter)
                sum = sum + counter
            End If
            counter = counter + 1
        Loop
        Console.WriteLine("The sum of odd numbers from 1 to " & num2 & " is " & sum)

        Console.WriteLine("Enter a number between 1 and 300 inclusive")
        num2 = Console.ReadLine()
        sum = 0
        While num2 > 300 And num2 < 1 And num2 <> Math.Round(num2, 0)
            Console.WriteLine("Enter a number between 1 and 300 inclusive")
            num2 = Console.ReadLine()
        End While
        For counter = 1 To num2
            If counter Mod 2 = 1 Then
                Console.WriteLine(counter)
                sum = sum + counter
            End If
        Next
        Console.WriteLine("The sum of odd numbers from 1 to " & num2 & " is " & sum)






        Console.ReadLine()

    End Sub

End Module

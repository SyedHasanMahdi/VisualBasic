Module Module1
    '   Title:          tryFor
    '   Author:         Hasan
    '   Version:        0.1
    '   Date:           22/10/2024
    '   Desc:           Trying out some basic For Loop exercises
    Sub Main()
        Dim x, y As Integer


        'Console.WriteLine("Enter a number x")
        'x = Console.ReadLine()
        'Console.WriteLine("Enter a number y")
        'y = Console.ReadLine()


        'If x > Y Then
        '    For counter = Y To x
        '        Console.WriteLine(counter)
        '    Next
        'Else
        '    For counter = x To Y
        '        Console.WriteLine(counter)
        '    Next
        'End If

        'Dim temp As Integer = 0
        'If x > y Then
        '    temp = x
        '    x = y
        '    y = temp
        '    For counter = x To y
        '        Console.WriteLine(counter)
        '    Next
        'End If

        'For index = 10 To 1 Step -1
        '    Console.WriteLine(index)
        'Next

        For counter = 1 To 100
            If counter Mod 3 = 0 Then
                If counter Mod 15 = 0 Then
                    Console.WriteLine("Fizz Buzz")
                Else
                    Console.WriteLine("fizz")
                End If


            Else
                If counter Mod 5 = 0 Then
                    Console.WriteLine("buzz")
                Else
                    Console.WriteLine(counter)
                End If
            End If

        Next








        ' Keeping the console open
        Console.ReadLine()
    End Sub

End Module

Module Module1
    '   Title:          tryCollatzSequence
    '   Author:         Hasan
    '   Version:        0.1
    '   Date:           24/10/2024
    '   Desc:           Making an attept to create a collatz sequence
    Sub Main()
        Dim number, terms As Integer
        Dim NextNumber, HighestNumber As Integer

        Dim max As Integer = 0


        'Console.WriteLine("Enter a number between 1 and 1 000 000")
        'number = Console.ReadLine
        'If number > 1000000 Or number < 1 Then
        '    Console.WriteLine("Incorrect, enter a number between 1 and 1 million")
        '    number = Console.ReadLine()
        'End If

        Console.Clear()
        For number = 2 To 100000
            NextNumber = number
            While NextNumber <> 1
                'Console.WriteLine(number)
                If NextNumber Mod 2 = 0 Then
                    NextNumber = NextNumber / 2
                Else
                    NextNumber = (NextNumber * 3) + 1
                End If
                terms = terms + 1
            End While
            'Console.WriteLine("1")
            terms = terms + 1
            'Console.WriteLine(divisions)
            If terms > max Then
                max = terms
                HighestNumber = number
            End If
        Next

        Console.WriteLine("Input with most number of terms: " & HighestNumber & " with " & max & " terms")


        Console.ReadLine()
    End Sub

End Module

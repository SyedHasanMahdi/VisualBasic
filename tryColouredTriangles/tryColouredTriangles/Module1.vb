Module Module1

    Sub Main()
        Dim FirstRow As String = " "
        Console.WriteLine("Enter the starting row of length 1 to 10")
        FirstRow = Console.ReadLine()

        Dim randomVal, index As Integer
        Dim NextRow, nextTwo As String
        Dim randomChar As Char

        NextRow = ""

        For index = 1 To Len(FirstRow) - 1

            nextTwo = Mid(FirstRow, index, 2)
            If nextTwo = "RR" Or nextTwo = "GG" Or nextTwo = "BB" Then
                NextRow = NextRow & Mid(nextTwo, 1, 1)
            Else
                Randomize()
                randomVal = (Rnd() * 3) + 1
                Select Case randomVal
                    Case 1
                        randomChar = "R"
                    Case 2
                        randomChar = "G"
                    Case 3
                        randomChar = "B"
                End Select
                NextRow = NextRow & randomChar
            End If
        Next

        Console.WriteLine(NextRow)
        Console.ReadLine()
    End Sub

End Module

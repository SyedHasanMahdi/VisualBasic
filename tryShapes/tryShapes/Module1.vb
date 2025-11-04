Module Module1
    '   Title:          tryShapes
    '   Author:         
    '   Version:        0.1
    '   Date:           12/09/2023
    '   Description:    Calculate the area and perimeter of shapes
    Sub Main()
        Dim Area As Double = 0
        Dim Length As Double = 0
        Dim pi As Double = Math.PI

        Console.WriteLine("Enter the length of your shape")
        Length = Console.ReadLine()
        Console.WriteLine("The area of a circle with the length " & Length & "cm is: " & Math.Round((pi * (Length ^ 2)), 1) & " and the Perimeter is: " & Math.Round((2 * pi * Length), 1))
        Console.WriteLine("The area of a equilatteral triangle with the length " & Length & "cm is: " & Math.Round(((3 ^ 0.5) / 4) * (Length ^ 2), 1) & " and the perimeter is: " & (3 * Length))
        Console.WriteLine("The area of a square with the length " & Length & "cm is: " & Length ^ 2 & " and the perimeter is: " & 4 * Length)
        Console.ReadLine()


    End Sub

End Module

Module Module1
    '   Title:          tryHelloWorld
    '   Author:         Hasan
    '   Version:        0.1
    '   Date:           24/09/2024
    '   Desc:           Trying out some basic input and output

    Sub Main()
        '   Declare a variable
        Dim radius As Integer = 0 'Giving a variable a starting value is helpful

        '   Declare a constant
        Const PI = Math.PI
        Console.WriteLine("The value of pi is " & PI)

        '   Set radius to 5
        radius = 5
        Console.WriteLine("The area of the circle is " & PI * radius ^ 2 & "cm²")
        Console.WriteLine("The volume of sphere is " & 4 / 3 * PI * radius ^ 3 & "cm³")
        '   Set radius to 11
        radius = 11
        Console.WriteLine("The area of the circle is " & PI * radius ^ 2 & "cm²")
        Console.WriteLine("The volume of sphere is " & 4 / 3 * PI * radius ^ 3 & "cm³")
        '   Set radius to 342
        radius = 342
        Console.WriteLine("The area of the circle is " & PI * radius ^ 2 & "cm²")
        Console.WriteLine("The volume of sphere is " & 4 / 3 * PI * radius ^ 3 & "cm³")












        '   we need this to stop the programming from closing
        Console.ReadLine()
    End Sub

End Module

Module Module1
    '   Title:          tryAnimal
    '   Author:         Hasan
    '   Version:        0.1
    '   Date:           01/10/2025
    '   Desc:           Trying out some basic input and output
    Sub Main()
        Dim myAnimal1 As Animal = New Animal(2, "pink", 5, True)
        Dim myAnimal2 As Animal = New Animal(4, "orange", 50, True)
        Dim myAnimal3 As Animal = New Animal(8, "black", 1, False)

        Console.WriteLine(myAnimal1)
        Console.WriteLine(myAnimal2)
        Console.WriteLine(myAnimal3)


        Dim myCat1 As Cat = New Cat("Grey", 6, 20, True)
        Console.WriteLine(myCat1)
    End Sub

End Module

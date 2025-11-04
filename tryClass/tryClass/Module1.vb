Module Module1

    Sub Main()

        '   Declaring an object
        Dim myNum As Number
        myNum = New Number(5)


        Dim myNum2 As Number = New Number(7)


        '   Declaring an array of the number
        Dim myArr(99) As Number


        Randomize()


        For index = 0 To 99
            myArr(index) = New Number(Rnd() * 1001)
        Next

        Console.WriteLine("Value: " & myArr(5).getValue)
        Console.WriteLine("Is it Odd: " & myArr(5).getIsOdd)
        Console.WriteLine("Sum of all number from 1 to Value: " & myArr(5).getSum())
        Console.WriteLine("Factorial of the value: " & myArr(5).getFact())
        Console.WriteLine("Is it Prime: " & myArr(5).getIsPrime())



        Console.WriteLine(myArr(4).ToString())

    End Sub

End Module

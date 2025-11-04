Module Module1
    '   Title:          trySub
    '   Author:         Hasan
    '   Version:        0.1
    '   Date:           07/01/2025
    '   Desc:           Trying out some subroutines including functions and procedures

    Dim myFactorial As Integer = 1


    Sub Main()

        Call myName()

        Dim name As String
        Console.WriteLine("Please enter a name")
        name = Console.ReadLine()

        Call myName2(name)

        Call myName2("Bob")

        Dim myNum As Integer = 0
        Dim myNum2 As Integer = 0
        Console.WriteLine("Enter a number")
        myNum = Console.ReadLine()

        Console.WriteLine(OddOrEven(myNum))


        Console.WriteLine("Number is in range: " & InRange(myNum))

        If InRange(myNum) = True Then
            myFactorial = Factorial(myNum)
            Console.WriteLine("Factorial of this number is " & myFactorial)
        End If

        Console.WriteLine("Enter a second number")
        myNum2 = Console.ReadLine()





        Console.WriteLine("Number is Prime: " & isPrime(myNum))



        '   Keeping console open
        Console.ReadLine()
    End Sub

    Sub myName()
        Console.WriteLine("You are Steve. ")
        Console.WriteLine("You are still Steve. ")
        Console.WriteLine("You will always be Steve. ")
    End Sub

    Sub myName2(ByVal name As String)
        Console.WriteLine("You are " & name)
        Console.WriteLine("You are still " & name)
        Console.WriteLine("You will always be " & name)
    End Sub


    '   Can be called multiple times
    '   Changes made to procedure affect the result of the calls
    Function OddOrEven(ByVal Int As Integer)
        If Int Mod 2 = 1 Then
            Return "odd"
        Else
            Return "even"
        End If
    End Function

    Function Factorial(ByVal Int As Integer)
        myFactorial = 1
        For index = 1 To Int
            myFactorial = myFactorial * index
        Next
        Return myFactorial
    End Function

    Function InRange(ByVal Int As Integer)
        If Int >= 1 And Int <= 26 Then
            Return True
        Else
            Return True
        End If
    End Function

    Function Letters(num1, num2)
        If InRange(num1) = False Then
            num1 = 1
        Else
            If InRange(num2) = False Then
                num2 = 1
            End If
        End If
    End Function


    Function isPrime(ByVal int As Integer)
        Dim divisions As Integer = 0

        For Index = 2 To (int - 1)
            If int Mod Index = 0 Then
                divisions = divisions + 1
            End If
        Next
        If divisions = 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    'Function RangeOfPrime(num1, num2)
End Module

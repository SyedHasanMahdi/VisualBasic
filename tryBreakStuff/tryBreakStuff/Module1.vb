Module Module1
    '   Title:          tryBreakStuff
    '   Author:         Hasan
    '   Version:        0.1
    '   Date:           18/09/2025
    '   Desc:           Trying to make the program crash so we can practice exception handling

    Sub Main()

        '   Declare numberic variables
        Dim myNum1 As Integer
        Dim myNum2 As Double

        '   Declare an array of size 10
        Dim myArr1(9) As Integer

        '   Capture input from the user, store in the numeric variable
        Console.WriteLine("Enter a integer value for Num 1")
        Try
            myNum1 = Console.ReadLine()
        Catch ex As OverflowException
            Console.WriteLine("Exception for Invalid Cast was caught.")
            myNum1 = 10
        Catch ex As InvalidCastException
            Console.WriteLine("Exception for Overflow was caught.")
            myNum1 = 10
        End Try


        Console.WriteLine("Enter a whole number or decimal for Num2")
        Try
            myNum2 = Console.ReadLine()
        Catch ex As OverflowException
            Console.WriteLine("Exception for Overflow was caught.")
            myNum2 = 2.5
        Catch ex As InvalidCastException
            Console.WriteLine("Exception for Invalid Cast was caught.")
            myNum2 = 2.5
        End Try

        '   Ask the user for another number, limit
        Dim limit As Integer
        Console.WriteLine("Enter a integer number to limit between 1 to 10 inclusive")
        Try
            limit = Console.ReadLine()
        Catch ex As InvalidCastException
            Console.WriteLine("Exception for Invalid Cast was caught.")
            limit = 10
        End Try


        '   Generate random numbers, store in the array
        Randomize()
        Try
            For index = 0 To limit - 1
                myArr1(index) = Rnd() * 100
            Next
        Catch ex As IndexOutOfRangeException
            Console.WriteLine("Exception for Index Out Of Range was caught.")
            limit = 10
            For index = 0 To limit - 1
                myArr1(index) = Rnd() * 100
            Next
        End Try


        '   Declare another variable
        Dim Result As Double

        '   Divide the numerical variables and store the result in the new variable

        Result = myNum1 / myNum2

        Console.WriteLine("Dividing num1 by num2 produces: " & Result)
        '   Output the contents of the array 
        For index = 0 To limit - 1
            Console.WriteLine(myArr1(index))
        Next



    End Sub

End Module

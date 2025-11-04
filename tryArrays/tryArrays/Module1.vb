Module Module1

    Sub Main()
        Dim myStringArr(9) As String

        For counter = 0 To 9
            myStringArr(counter) = ""
        Next
        For counter = 0 To 9

            Console.WriteLine("Please enter the name of the person")
            myStringArr(counter) = Console.ReadLine()
        Next

        For counter = 0 To 9
            Console.WriteLine("the names of the people are: " & myStringArr(counter))
        Next


        Dim myIntArr(9) As Integer

        For counter = 0 To 9
            myIntArr(counter) = 0
        Next
        For counter = 0 To 9

            Console.WriteLine("Please enter the number")
            myIntArr(counter) = Console.ReadLine()
        Next

        Dim smallest As Integer = 100000000
        Dim largest As Integer = -999999999
        Dim average As Integer
        Dim sum As Integer = 0

        For counter = 0 To 9
            If myIntArr(counter) > largest Then
                largest = myIntArr(counter)
            End If
            If myIntArr(counter) < smallest Then
                smallest = myIntArr(counter)
            End If
            sum = sum + myIntArr(counter)
        Next

        average = sum / 10

        Console.WriteLine("the smallest number is " & smallest & ", the largest number is " & largest)
        Console.WriteLine("the average of all numbers is " & average)


        Dim myDoubleArr(9) As Double
        For counter = 0 To 9
            myDoubleArr(counter) = 0
        Next

        For counter = 0 To 9
            Console.WriteLine("Enter a number between -12.8 and 108.4 inclusive")
            myDoubleArr(counter) = Console.ReadLine()

            While myDoubleArr(counter) < -12.8 And myDoubleArr(counter) > 108.4
                Console.WriteLine("Enter a number between -12.8 and 108.4 inclusive")
                myDoubleArr(counter) = Console.ReadLine()
            End While
        Next

        For counter = 9 To 0 Step -1
            If myDoubleArr(counter) Mod 3 = 0 Then
                Console.WriteLine("index number: " & counter & " value: " & myDoubleArr(counter))
            End If
        Next









        Console.ReadLine()
    End Sub

End Module

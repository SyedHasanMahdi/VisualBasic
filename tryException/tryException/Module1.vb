Imports System.Runtime.Remoting.Messaging
Imports Microsoft.VisualBasic.ApplicationServices

Module Module1
    '   Title:          tryException
    '   Author:         Hasan
    '   Version:        0.1
    '   Date:           17/09/2025
    '   Desc:           Trying out some basic exception handling
    Sub Main()


        'Declare an array of User Details
        Dim Users(9) As UserDetails
        Dim tempEyeC As String = ""

        For counter = 0 To 9
            '   Ask the user for the details to store
            Console.WriteLine("Enter the name of user " & counter + 1)
            Users(counter).Name = Console.ReadLine
            Console.WriteLine("Enter the age  of user " & counter + 1)
            Users(counter).Age = Console.ReadLine
            Console.WriteLine("Enter the height  of user " & counter + 1)
            Users(counter).height = Console.ReadLine
            Console.WriteLine("Enter the eye colour of user " & counter + 1)

            '   store eye colour temporarily
            tempEyeC = Console.ReadLine()

            '   Look for the inputted eye colour in the Enum and assign its value to the array
            Select Case LCase(tempEyeC)
                Case = "black"
                    Users(counter).EyeC = Eyes.black
                Case = "blue"
                    Users(counter).EyeC = Eyes.blue
                Case = "brown"
                    Users(counter).EyeC = Eyes.brown
                Case = "green"
                    Users(counter).EyeC = Eyes.green
                Case = "pink"
                    Users(counter).EyeC = Eyes.pink
                Case = "red"
                    Users(counter).EyeC = Eyes.red

            End Select
        Next

        For index = 0 To 9
            Console.WriteLine("User " & index + 1 & " is called " & Users(index).Name)
            Console.WriteLine("They are " & Users(index).Age & " Years old and are " & Users(index).height & "m tall")
            Console.WriteLine("They have an eye colour of " & Users(index).EyeC.ToString
        Next
    End Sub

    Enum Eyes
        black
        blue
        brown
        green
        pink
        red
    End Enum
    Structure UserDetails
        Dim Name As String
        Dim Age As Integer
        Dim height As Double
        Dim EyeC As Eyes
    End Structure
End Module

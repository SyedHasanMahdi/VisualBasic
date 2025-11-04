Module Module1
    '   Title:          tryWeather
    '   Author:         Hasan
    '   Version:        0.1
    '   Date:           08/10/2024
    '   Desc:           Asks questions from user to input data and calculates values
    Sub Main()
        Console.WriteLine("Please enter the temperature in Fahrenheit: ")
        '   Declare the variables required

        Dim TempF As Double = 0
        Dim Raining As Char = ""
        Dim DayTime As Char = ""
        Dim TempC As Double = 0

        '   User inputs data to the program
        TempF = Console.ReadLine()
        Console.WriteLine("Asks the user to enter whether it is raining or not (y/n)")

        Raining = Console.ReadLine()
        Console.WriteLine("Is it daytime or not (y/n)")

        DayTime = Console.ReadLine()

        '   Clear the inputs from the console   
        Console.Clear()

        '   Calculate the temperature in celcius and output it
        TempC = Math.Round(((TempF - 32) / 1.8), 0)
        Console.WriteLine("The temperature in celcius at your location is: " & TempC & " degrees celcius")

        '   Give different responses for each possible case
        If TempC > 28 Then
            Console.Write("It is hot, take some water")
            If Raining = "y" Then
                Console.Write(", take an umbrella since its raining")
                If DayTime = "n" Then
                    Console.Write(", it is dark outside, take a light.")
                Else
                    Console.Write(", its not dark outside, you should take sunglasses.")
                End If
            Else
                Console.Write(", its not raining today, so you dont need an umbrella")
                If DayTime = "n" Then
                    Console.Write(", it is dark outside, take a light.")
                Else
                    Console.Write(", its not dark outside, you should take sunglasses.")
                End If
            End If
        Else
            Console.Write("Its not too hot today")
            If Raining = "y" Then
                Console.Write(", take an umbrella since its raining")
                If DayTime = "n" Then
                    Console.Write(", it is dark outside, take a light.")
                Else
                    Console.Write(", its not dark outside, you should take sunglasses.")
                End If
            Else
                Console.Write(", its not raining today, so you dont need an umbrella")
                If DayTime = "n" Then
                    Console.Write(", it is dark outside, take a light.")
                Else
                    Console.Write(", its not dark outside, you should take sunglasses.")
                End If
            End If

        End If


        '   To keep the console open
        Console.ReadLine()
    End Sub
End Module


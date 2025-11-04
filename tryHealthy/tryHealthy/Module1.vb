Module Module1
    '   Title:          tryHealthy
    '   Author:         Hasan
    '   Version:        0.1
    '   Date:           15/10/2024
    '   Desc:           Calculate a user's BMI and providing matching responses
    Sub Main()
        '   Declare variables required in the program
        Dim Name As String = " "
        Dim Age As Integer = 0
        Dim Ethnicity As String = ""
        Dim weight As Double = 0
        Dim height As Double = 0
        Dim bmi As Double = 0
        Dim calories As Integer = 0
        Dim steps As Integer = 0
        Dim temp As Integer = 0
        Dim Gym As Integer = 0
        Dim StrengthTraining As Integer = 0

        '   Ask users to input personal details
        Console.WriteLine("Please input your Name:")
        Name = Console.ReadLine
        Console.WriteLine("Please input your Age:")
        Age = Console.ReadLine
        Console.WriteLine("Please input your Ethnicity:")
        Ethnicity = Console.ReadLine
        Console.WriteLine("Please input your weight in kilograms:")
        weight = Console.ReadLine
        Console.WriteLine("Please input your height in metres:")
        height = Console.ReadLine
        Console.WriteLine("Please input your Average calorie intake each day:")
        calories = Console.ReadLine
        Console.WriteLine("Please input your average daily steps in a week:")
        steps = Console.ReadLine




        '   Conditional statement for level of gym activity
        Console.WriteLine("Please input the number of days you go to gym on average")
        Gym = Console.ReadLine()
        If Gym > 0 Then
            Console.WriteLine("Enter how many days you do strength training at the gym:")
            StrengthTraining = Console.ReadLine
            If Gym > 3 Then
                Console.WriteLine("You must be very active, well done")
            Else
                Console.WriteLine("Not too bad, you are working on a decent level")
            End If
        End If

        '   Calculating BMI
        bmi = Math.Round((weight / (height ^ 2)), 1)
        Console.WriteLine("Your BMI is: " & bmi)

        '   Giving advice according to BMI

        If bmi >= 25 And bmi < 30 Then
            Console.WriteLine(Name & ", You are Overweight")
            If Ethnicity = "Pakistani" And calories > 3000 Then
                Console.WriteLine("You should consider eating less to not risk Diabetes")
            End If
            If Gym < 3 Then
                Console.WriteLine("You should consider going to the gym more often as you could loose some weight")
            Else
                Console.WriteLine("Dont worry about how much your eating, your just fine")
            End If
        Else
            If bmi > 18.5 And bmi < 25 Then
                Console.WriteLine(Name & ", you are perfectly healthy")
                If Gym < 2 Then
                    Console.WriteLine("It would be a great idea to go to the gym and build some muscle to become even fitter")
                Else
                    Console.WriteLine("Well Done, you are working on improving your fitness")
                    If StrengthTraining < 1 Then
                        Console.WriteLine("You should try strenghening your muscles by some more intense workouts at the gym")
                    End If
                End If
            End If
            If bmi >= 30 Then
                Console.WriteLine(Name & ", You are Obese")
                If Gym < 2 Then
                    Console.WriteLine("PLEASE GO TO THE GYM")
                    If calories > 4000 Then
                        Console.WriteLine("PLEASE EAT LESSS!")
                    End If
                Else
                    Console.WriteLine("Well Done, you are working on improving your fitness")
                    If calories > 4000 Then
                        If Gym > 3 Then
                            Console.WriteLine("Dont worry about how much your eating, your just fine")
                        Else
                            Console.WriteLine("Please eat less if you want the gym to make a difference!")
                        End If
                    End If
                End If
                If bmi <= 18.5 Then
                    Console.WriteLine(Name & ", You are underweight")
                    If calories < 2000 Then
                        Console.WriteLine("You should definetly be eating more")
                    End If
                    If Gym > 0 Then
                        Console.WriteLine("Please try working out, you might gain some muscle mass!")
                    End If
                End If
            End If
            If Age >= 18 Then
                Console.WriteLine("Dont worry too much about your BMI, your still growing!")
            End If
        End If

        '   Keep console open
        Console.ReadLine()

    End Sub

End Module

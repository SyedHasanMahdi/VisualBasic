Module Module1

    Sub Main()
        Dim hour1, minutes1, hour2, minutes2, Time As Integer
        Dim speed1, speed2 As Integer


        Console.WriteLine("Enter the speed of the first clock in number of minutes fast per hour")
        speed1 = Console.ReadLine()
        Console.WriteLine("Enter the speed of the second clock in number of minutes fast per hour")
        speed2 = Console.ReadLine()
        Do Until (speed1 >= 0 And speed1 <= 50000) Or (speed2 >= 0 And speed2 <= 50000)
            Console.WriteLine("Enter the speed of the first clock in number of minutes fast per hour")
            speed1 = Console.ReadLine()
            Console.WriteLine("Enter the speed of the second clock in number of minutes fast per hour")
            speed2 = Console.ReadLine()
        Loop


        Dim Finish As Boolean = False

        While Finish = False
            minutes1 = minutes1 + 60 + speed1
            minutes2 = minutes2 + 60 + speed2
            Time = Time + 1
            If minutes1 >= 1440 Then
                minutes1 = minutes1 - 1440
            End If
            If minutes2 >= 1440 Then
                minutes2 = minutes2 - 1440
            End If
            If minutes1 = minutes2 Then
                Finish = True
            End If
        End While

        Time = Format(Time, "Long Time")
        If minutes1 >= 60 Then
            hour1 = minutes1 \ 60
            minutes1 = minutes1 Mod 60
        End If

        Console.Clear()

        Console.WriteLine("at time, " & hour1 & ":" & minutes1 & " , both clocks match after " & Time & " hours")

        Console.ReadLine()

    End Sub

End Module

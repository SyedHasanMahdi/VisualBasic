Module Module1
    '   Title:          tryCarComputer
    '   Author:         Hasan
    '   Version:        0.1
    '   Date:           01/10/2024
    '   Desc:           Modelling part of a car trips computer

    Dim Kilometers As Double = 0
    Dim Litres As Double = 0
    Dim Miles As Double = 0
    Dim CostPerLitre As Double = 0
    Dim CostPerGallon As Double = 0
    Dim CostPerKilometer As Double = 0
    Dim CostPerMile As Double = 0
    Dim LitrePer100Km As Double = 0
    Dim MilesPerGallon As Double = 0
    Dim Gallon As Double = 0
    Const MilesConv = 0.6214
    Const GallonConv = 0.264

    Sub Main()

        '   Asking for the user to input details about their trip
        Console.WriteLine("You have recently gone on a trip, could you tell us how many kilometers u had travelled.")
        Console.WriteLine("Enter the number of kilometers: ")
        Kilometers = Console.ReadLine()

        Console.WriteLine("Could you also tell us how much fuel was used over the entir trip?")
        Console.WriteLine("Enter the number of litres: ")
        Litres = Console.ReadLine()

        Console.WriteLine("Could you also enter the cost of 1 litre of fuel in Qatari Riyals?")
        Console.WriteLine("Enter the cost of one litre: ")
        CostPerLitre = Console.ReadLine()

        '   Calculating the cost per litreSS
        CostPerKilometer = Math.Round(((Litres * CostPerLitre) / Kilometers), 2)
        '   Calculating cost per mile
        Miles = Kilometers * MilesConv
        CostPerMile = Math.Round(((Litres * CostPerLitre) / Miles), 2)
        '   Calculating how many liters of fuel were used per 100 kilometers
        LitrePer100Km = Math.Round(((Litres / Kilometers) * 100), 2)
        '   Calculating miles per gallon of fuel
        Gallon = Litres * GallonConv
        MilesPerGallon = Math.Round((Miles / Gallon), 2)

        '   Outputting calculated values
        Console.WriteLine("The cost per kilometer travelled was: " & CostPerKilometer & "QAR/Km and the cost per mile was: " & CostPerMile & "QAR / mile")
        Console.WriteLine("Your car used " & LitrePer100Km & " litres per 100km of the journey")
        Console.WriteLine("Your car could travel " & MilesPerGallon & " Miles on 1 gallon of fuel")

        '   Allowing the program to stay open
        Console.ReadLine()


    End Sub



End Module

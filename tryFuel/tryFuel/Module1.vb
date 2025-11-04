Module Module1
    '   Title:          Tryfuel
    '   Author:         
    '   Version:        0.1
    '   Date:           10/09/2023
    '   Description:    Calculate fuel stuff for a car
    Sub Main()
        Dim CostPerLitre As Double = 2.1
        Dim TotalFuel As Integer = 70
        Dim KmPerFillup As Integer = 352
        Dim CostPerKM As Double = 0
        Dim KmPerLitre As Double = 0
        Dim MilesPerGallon As Double = 0
        Dim HundredKmLitre As Double = 0
        '   Declaring Variables

        CostPerKM = Math.Round((KmPerFillup / (CostPerLitre * TotalFuel)), 2)
        KmPerLitre = Math.Round((KmPerFillup / TotalFuel), 2)
        MilesPerGallon = Math.Round((KmPerLitre * 2.352), 2)
        HundredKmLitre = Math.Round((KmPerLitre * 100), 2)

        Console.WriteLine(" The car costs QAR" & CostPerKM & " per kilometre and drives " & KmPerLitre & "km per litre of fuel, which can also be written as " & MilesPerGallon & "miles per gallon" & " and it consumes " & HundredKmLitre & " litres per 100km")
        Console.ReadLine()
    End Sub

End Module

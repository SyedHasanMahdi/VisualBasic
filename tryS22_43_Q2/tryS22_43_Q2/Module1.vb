Module Module1

    Sub Main()
        Dim Balloon1 As Balloon
        Dim colour As String
        Dim defenseItem As String

        Console.WriteLine("Enter a colour followed by the defense item")
        colour = Console.ReadLine()
        defenseItem = Console.ReadLine()
        Balloon1 = New Balloon(colour, defenseItem)

        Balloon1 = Defend(Balloon1)
    End Sub

    Public Function Defend(myBalloon As Balloon)
        Dim OppStrength As Integer
        Console.WriteLine("Enter your opponents strength")
        OppStrength = Console.ReadLine()
        myBalloon.ChangeHealth(-OppStrength)
        myBalloon.getDefenseItem()
        If myBalloon.CheckHealth() Then
            Console.WriteLine("The balloon has no health remaining")
        Else
            Console.WriteLine("The balloon has health remaining")
        End If
        Return myBalloon
    End Function
End Module

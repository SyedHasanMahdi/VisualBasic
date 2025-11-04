Module Module1
    '   Title:          tryCardsChallenge
    '   Author:         Hasan
    '   Version:        0.1
    '   Date:           02/10/2025
    '   Desc:           Enum for suit, face ✔ 
    '                   Class for a card ✔ 
    '                   Class for a hand ( up to 52 cards ) ✔ 
    '                   Method to output details of a card,hand ✔ 
    '                   Method to sort the cards in a hand
    '                   Method to shuffle a hand (random)
    '                   Method to deal cards from a hand to another hand

    Sub Main()
        Dim myDeck As Hand = New Hand(18)

        Console.WriteLine(myDeck)
    End Sub


End Module

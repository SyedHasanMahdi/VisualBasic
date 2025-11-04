Module Module1
    '   Title:          tryCardsWithClasses
    '   Author:         Hasan Mahdi
    '   Version:        0.4
    '   Date:           11/09/2025
    '   Desc:           To use classes to define a deck of cards


    '   Defining a whole deck of cards
    Dim myDeck(51) As Card

    Sub Main()

        'Initialise the deck


    End Sub

    '   Initialize the deck of cards
    Sub init()
        Dim counter As Integer = 0
        '   Initialise the deck of cards
        For suit = 0 To 3
            For face = 0 To 12
                myDeck(counter).suit = suit
                myDeck(counter).face = face
                Console.WriteLine(myDeck(counter).face.ToString & " of " & myDeck(counter).suit.ToString)
                counter = counter + 1
            Next face
        Next suit
    End Sub


    '   Define an enumeration for suits
    Enum Suit
        Spades
        Diamonds
        Clubs
        Hearts
    End Enum

    '   Define an enum for the face values of a card
    Enum Face
        Ace
        Two
        Three
        Four
        Five
        Six
        Seven
        Eight
        Nine
        Ten
        Jack
        Queen
        King
    End Enum

    '   Declaring a record data type
    Structure Card
        Dim suit As Suit
        Dim face As Face
    End Structure





End Module


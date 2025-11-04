Module Module1
    '   Title:          tryCards
    '   Author:         Hasan Mahdi
    '   Version:        0.2
    '   Date:           10/09/2025
    '   Desc:           To simulate a deck of cards

    Sub Main()

        'Dim MySuit As Suit
        'MySuit = Suit.Spades
        'Console.WriteLine(MySuit)  'Returns 0 which is the value of Spades
        'Console.WriteLine(MySuit.ToString)  'Returns the actual value: "Spades"

        '   Declaring a Record of Enum
        Dim myCard As Card
        myCard.suit = Suit.Spades
        myCard.face = Face.Ace
        Console.WriteLine(myCard.face.ToString & " of " & myCard.suit.ToString)
        '   Returns Ace of Spades



        '   Defining a whole deck of cards
        Dim myDeck(51) As Card

        '   Declaring a writer
        Dim writer As IO.StreamWriter
        writer = New IO.StreamWriter("Cards.csv", False)

        Dim counter As Integer = 0
        '   Initialise the deck of cards
        For suit = 0 To 3
            For face = 0 To 12
                myDeck(counter).suit = suit
                myDeck(counter).face = face
                Console.WriteLine(myDeck(counter).face.ToString & " of " & myDeck(counter).suit.ToString)

                'Write the deck of cards to the file
                writer.WriteLine(myDeck(counter).suit.ToString & "," & myDeck(counter).face.ToString)

                counter = counter + 1
            Next face
        Next suit

        Dim Hand(4) As Card
        Dim selection As Integer
        For index = 0 To 4
            Randomize()
            selection = Rnd() * 52
            Hand(index).suit = myDeck(selection).suit
            Hand(index).face = myDeck(selection).face
            myDeck(selection).suit = 0
            myDeck(selection).face = 0
            Console.WriteLine(Hand(index).face.ToString & " of " & Hand(index).suit.ToString)
        Next

        writer.Close()



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

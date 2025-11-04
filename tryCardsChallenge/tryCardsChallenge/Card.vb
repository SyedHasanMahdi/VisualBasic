Public Class Card
    '   Define an enumeration for suits
    Public Enum Suits
        Spades
        Diamonds
        Clubs
        Hearts
    End Enum

    '   Define an enum for the face values of a card
    Public Enum Faces
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

    Private Suit As Suits
    Private Face As Faces

    Public Sub New(Suit As Suits, Face As Faces)
        Me.Suit = Suit
        Me.Face = Face
    End Sub

    Public Overrides Function ToString() As String
        Console.WriteLine("This card is " & Face.ToString & " of " & Suit.ToString)
    End Function

    Public Function retSuit()
        Return Suit
    End Function
    Public Function retFace()
        Return Face
    End Function

End Class

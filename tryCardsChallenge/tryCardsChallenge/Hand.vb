Imports System.Reflection

Public Class Hand

    Private deck(51) As Card
    Private numCards As Integer
    Private fullDeck(51) As Card


    Public Sub New()
        Dim numCards As Integer = 0
        '   Initialise the deck of cards
        For suit = 0 To 3
            For face = 0 To 12
                deck(numCards) = New Card(suit, face)
                numCards = numCards + 1
            Next face
        Next suit
    End Sub

    Public Sub New(numCards As Integer)
        Dim counter As Integer = 0
        For suit = 0 To 3
            For face = 0 To 12
                fullDeck(counter) = New Card(suit, face)
                counter = counter + 1
            Next face
        Next suit

        Me.numCards = numCards
        For counter = 0 To numCards
            deck(counter) = fullDeck(counter)
        Next

    End Sub

    Public Overrides Function ToString() As String
        For counter = 0 To numCards
            Console.WriteLine(deck(counter))
        Next
    End Function

    Public Sub Sort()
        Dim tempCard As Card

        For counter = 0 To 51
            If deck(counter).retSuit > deck(counter + 1).retSuit Or deck(counter).retFace > deck(counter).retFace Then
                tempCard = deck(counter)
                deck(counter) = deck(counter + 1)
                deck(counter + 1) = tempCard
            End If
        Next
    End Sub

    Public Sub getCard(newCard As Card)
        deck(numCards) = newCard
        numCards = numCards + 1
    End Sub

    Public Function DealCard() As Card
        numCards = numCards - 1
        Dim tempCard As Card = deck(numCards)
        Return tempCard
    End Function

End Class

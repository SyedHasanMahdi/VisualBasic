Public Class Cat
    Inherits Animal

    '   Attributes of a cat
    Private numWhiskers As Integer
    Private claws As Boolean

    '   Constructor for a cat
    Public Sub New(colour As String, Weight As Integer, numWhiskers As Integer, claws As Boolean)
        '   Create an object of type animal first
        MyBase.New(4, colour, Weight, True)

        '   Set attributes for the cat
        Me.numWhiskers = numWhiskers
        Me.claws = claws
    End Sub

    Public Overrides Function ToString() As String
        Return "Meow"
    End Function
End Class

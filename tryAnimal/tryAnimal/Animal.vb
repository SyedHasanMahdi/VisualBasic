Public Class Animal
    '   Attributes
    Private numLegs As Integer
    Private colour As String
    Private weight As Integer
    Private tail As Boolean

    '   Constructor
    Public Sub New(numLegs As Integer, colour As String, weight As Integer, tail As Boolean)
        '   When parameter = attribute name then use Me.
        Me.numLegs = numLegs
        Me.colour = colour
        Me.weight = weight
        Me.tail = tail
    End Sub

    '   Helper method to output all of the attributes of animal
    Public Overrides Function ToString() As String
        Dim str As String = " "
        str = "Number of legs: " & numLegs & vbCrLf
        str = str & "Colour: " & colour & vbCrLf
        str = str & "Weight: " & weight & " Kg" & vbCrLf
        If tail Then
            str = str & "This animal has a tail"
        Else
            str = str & "This animal does not have a tail"
        End If

        Return str
    End Function
End Class

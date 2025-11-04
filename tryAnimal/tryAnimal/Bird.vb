Public Class Bird
    Inherits Animal

    Private numFeathers As Integer
    Private Land As Boolean


    Sub New(colour As String, weight As Boolean, numFeathers As Integer, land As Boolean)
        MyBase.New(2, colour, weight, True)
        Me.numFeathers = numFeathers
        Me.Land = land
    End Sub

    Public Overrides Function ToString() As String
        Return "Birrrrrrrrrrd"
    End Function
End Class

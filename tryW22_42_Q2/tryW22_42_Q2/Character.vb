Public Class Character
    Private Name As String
    Private Xcoord As Integer
    Private Ycoord As Integer

    Public Sub New(Name As String, X As Integer, Y As Integer)
        Me.Name = Name
        Me.Xcoord = X
        Me.Ycoord = Y
    End Sub

    Public Function getName()
        Return Name
    End Function
    Public Function getX()
        Return Xcoord
    End Function
    Public Function getY()
        Return Ycoord
    End Function

    Public Sub ChangePosition(Xchange As Integer, Ychange As Integer)
        Xcoord = Xcoord + Xchange
        Ycoord = Ycoord + Ychange
    End Sub
End Class

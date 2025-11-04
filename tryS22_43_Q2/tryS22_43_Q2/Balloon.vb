Public Class Balloon
    Private Health As Integer
    Private Colour As String
    Private DefenceItem As String

    Public Sub New(colour As String, Defence As String)
        Me.Health = 100
        Me.Colour = colour
        Me.DefenceItem = Defence
    End Sub

    Public Function getDefenseItem() As String
        Return DefenceItem
    End Function

    Public Sub ChangeHealth(change As Integer)
        Health = Health + change
    End Sub

    Public Function CheckHealth() As Boolean
        If Health <= 0 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class

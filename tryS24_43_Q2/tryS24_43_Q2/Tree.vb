Public Class Tree
    Private TreeName As String
    Private HeightGrowth As Integer
    Private MaxHeight As Integer
    Private MaxWidth As Integer
    Private Evergreen As String

    Public Sub New(Name As String, height As Integer, maxHeight As Integer, maxWidth As Integer, Evergreen As String)
        Me.TreeName = Name
        Me.HeightGrowth = height
        Me.MaxHeight = maxHeight
        Me.MaxWidth = maxWidth
        Me.Evergreen = Evergreen
    End Sub

    Public Function GetTreeName()
        Return TreeName
    End Function
    Public Function GetGrowth()
        Return HeightGrowth
    End Function
    Public Function GetMaxHeight()
        Return MaxHeight
    End Function
    Public Function GetMaxWidth()
        Return MaxWidth
    End Function
    Public Function GetEvergreen()
        Return Evergreen
    End Function
End Class

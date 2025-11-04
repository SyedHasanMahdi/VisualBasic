Public Class StackInt
    Private Stack(99) As Integer
    Private Top As Integer

    Public Sub New()
        Me.Top = 0
    End Sub

    Public Sub Push(data As Integer)
        If Top <= 99 Then
            Stack(Top) = data
            Top = Top + 1
            Console.WriteLine(data & " has been added to the stack")
        Else
            Console.WriteLine("ITS FULL!!!!! ERROR!!!!!!")
            Console.WriteLine("Data is not added")
        End If
    End Sub

    Public Function Pop() As Integer
        Dim temp As Integer
        temp = Stack(temp)
        Top = Top - 1
        Console.WriteLine(temp & " has been popped!")
        Return temp
    End Function

    Public Sub OutStack()
        For index = 0 To Top - 1
            Console.WriteLine(Stack(index))
        Next
    End Sub

End Class

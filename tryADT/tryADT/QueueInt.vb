Public Class QueueInt
    Private Queue(99) As Integer
    Private Front As Integer
    Private Rear As Integer

    Public Sub New()
        Front = 0
        Rear = 0
    End Sub

    Public Sub Add(data As Integer)
        Queue(Rear) = data
        Rear = Rear + 1
        If Rear = 100 Then
            Rear = 0
        End If
    End Sub

    Public Function Remove()
        Front = Front + 1
        If Front = 99 Then
            Front = 0
        End If
    End Function

    Public Sub OutQueue()
        If Front < Rear Then
            For index = Front To Rear - 1
                Console.WriteLine(Queue(index))
            Next
        Else
            For index = Front - 1 To 99
                Console.WriteLine(Queue(index))
            Next
            For index = 0 To Rear - 1
                Console.WriteLine(Queue(index))
            Next
        End If

    End Sub
End Class

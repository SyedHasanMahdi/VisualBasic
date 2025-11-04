Module Module1

    Sub main()
        Dim stack As New StackInt()

        stack.Push(10)
        stack.Push(20)
        stack.Push(30)

        stack.OutStack()

        stack.Pop()
        stack.OutStack()



        Dim Queue As New QueueInt()

        Queue.Add(10)
        Queue.Add(20)
        Queue.Add(30)

        Queue.OutQueue()

        Queue.Remove()

        Queue.OutQueue()

        Queue.Add(40)
        Queue.OutQueue()

    End Sub

End Module

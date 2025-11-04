Module Module1

    Sub Main()
        ' Overwrites file contents instead of appending
        Dim writer As IO.StreamWriter
        writer = New IO.StreamWriter("text.txt", False)
        Dim myName As String = " "
        For index = 1 To 5
            Console.WriteLine("Please enter a name")
            myName = Console.ReadLine()
            writer.WriteLine(myName)
        Next

        writer.Close()
        Console.ReadLine()


        Console.Clear()
        Dim reader As IO.StreamReader
        reader = New IO.StreamReader("text.txt")
        Dim myLine As String = " "
        While Not reader.EndOfStream
            myLine = reader.ReadLine()
            Console.WriteLine(myLine)
        End While
        reader.Close()





        Console.ReadLine()
        '   Appends instead of overwriting
        ''''''''''''''''Dim writer As IO.StreamWriter
        ''''''''''''''''writer = New IO.StreamWriter("text.txt", True)
        ''''''''''''''''Dim myName As String = " "
        ''''''''''''''''For index = 1 To 5
        ''''''''''''''''    Console.WriteLine("Please enter a name")
        ''''''''''''''''    myName = Console.ReadLine()
        ''''''''''''''''    writer.WriteLine(myName)
        ''''''''''''''''Next

        ''''''''''''''''writer.Close()
    End Sub

End Module

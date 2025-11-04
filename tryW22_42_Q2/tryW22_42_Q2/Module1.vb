Module Module1

    Sub Main()
        Dim Characters(9) As Character
        Dim reader As IO.StreamReader
        reader = New IO.StreamReader("Characters.txt")

        Dim name As String
        Dim x As Integer
        Dim y As Integer

        Dim counter As Integer = 0
        Do Until counter = 9 Or Not reader.EndOfStream

            name = reader.ReadLine()
            x = reader.ReadLine()
            y = reader.ReadLine()
            Characters(counter) = New Character(name, x, y)
            counter = counter + 1
        Loop

        Dim searchName As String
        Console.,

    End Sub

End Module

Module Module1
    '   Title:      tryString - IGCSE
    '   Author:     
    '   Version:    0.1
    '   Date:       10/12/2023
    '   Description:    Working with text
    Sub Main()
        reading()

        Console.ReadLine()

        ' writing()
        Dim str As String = "This is the end."
        '   Len() does: returns the number of characters in a string
        Console.WriteLine(Len(str))
        '   UCase() does: returns the string in upper case
        Console.WriteLine(UCase(str))
        '   LCase() does: returns the string in lower case
        Console.WriteLine(LCase(str))
        '   Left( , X ) does: returns the first X characters from the left
        Console.WriteLine(Left(str, 5))
        '   Right( , X ) does: returns the last X characters from the right but does not reverse the order
        Console.WriteLine(Right(str, 4))

        '   Trim() gets rid of leading and trailing spaces in strings, but does not get rid of spaces between characters / sentence
        Console.WriteLine(Trim("           Hello.       "))

        Console.WriteLine(RTrim("            Hello.    "))

        Console.WriteLine(LTrim("            Hello.    "))

        ' InStr(str1, str2) gives the starting position of str2 in str1
        Console.WriteLine(InStr(str, "end"))
        Console.WriteLine(InStr(str, "is"))

        ' mid(str, start, num): Returns a string of num characters, starting at start, of str
        Console.WriteLine(Mid(str, 3, 4))


        Dim myStr As String = " "
        Console.WriteLine("Please enter some text.")
        myStr = Console.ReadLine()

        For index = 1 To Len(myStr)
            Console.WriteLine(Mid(myStr, index, 1))
        Next index

        Console.ReadLine()
    End Sub

    Sub writing()
        '   Variable used to store some text
        Dim myStr As String = " "

        '   Create a variable that connects to a file
        Dim writer As IO.StreamWriter
        writer = New IO.StreamWriter("text.txt", False)

        '   Ask the user to enter some stuff, store in myStr
        Console.WriteLine("Please enter some text")
        myStr = Console.ReadLine

        '   Write this stuff to a file
        writer.WriteLine(myStr)

        '   Close the writer
        writer.Close()
    End Sub

    Sub reading()
        '   Create a variable to read a file
        Dim reader As IO.StreamReader
        reader = New IO.StreamReader("text2.txt")

        While Not reader.EndOfStream
            Console.WriteLine(reader.ReadLine())
        End While

        reader.Close()
    End Sub
End Module

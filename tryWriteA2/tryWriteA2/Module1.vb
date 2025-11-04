Module Module1

    Sub Main()
        Dim myArr() As String = IO.File.ReadAllLines("mockdata.txt")
        Dim myName As String = ""
        Console.WriteLine("All data has been read.")
        For index = 1 To myArr.Length - 1
            Console.WriteLine("[" & index & "] - " & myArr(index))
        Next index

        ''   Linear search
        ''   Ask the user for a name to find
        'Console.WriteLine("Please enter a name to find:")
        'myName = Console.ReadLine()
        'Dim counter As Integer = 0

        ''   Perform the search
        'While counter < myArr.Length - 1 And myName <> myArr(counter)
        '    counter = counter + 1
        'End While
        SortArr(myArr)
        OutputArr(myArr)
    End Sub

    'Sub SortArr(ByRef arr())
    '    '   Doesnt specify the data type of the array so it can sort any type
    '    '   If one data type isnt specified then none of them need to be specified
    '    Dim var1
    '    Dim var2
    '    Dim temp
    '    '   Swap the contents of two variables

    '    temp = var1
    '    var1 = var2
    '    var2 = temp
    'End Sub

    Sub SortArr(ByRef arr() As String)
        '   Doesnt specify the data type of the array so it can sort any type
        '   If one data type isnt specified then none of them need to be specified
        Dim temp As String
        Dim Size As Integer
        Dim swap As Boolean = True
        Dim counter As Integer = 0
        '   Swap the contents of two variables
        '   So that var1 has the smallet value
        Size = arr.Length
        While swap
            swap = False
            For index = 1 To Size - 2
                If arr(index) > arr(index + 1) Then
                    temp = arr(index)
                    arr(index) = arr(index + 1)
                    arr(index + 1) = temp
                    swap = True
                End If
            Next
            counter = counter + 1
            Size = Size - 1
        End While

        Do
            swap = False
            For index = 1 To Size - 2
                If arr(index) > arr(index + 1) Then
                    temp = arr(index)
                    arr(index) = arr(index + 1)
                    arr(index + 1) = temp
                    swap = True
                End If
            Next
            counter = counter + 1
            Size = Size - 1
        Loop Until swap = False

        For index = 1 To Size - 1
            For index2 = 1 To Size - 2
                If arr(index2) > arr(index2 + 1) Then
                    temp = arr(index2)
                    arr(index2) = arr(index2 + 1)
                    arr(index2 + 1) = temp
                End If
            Next
            counter = counter + 1
        Next

        Console.WriteLine("ALL DATA HAS BEEN SORTED")
        Console.WriteLine(counter)
    End Sub

    Sub OutputArr(arr)
        For index = 1 To arr.Length - 1
            Console.WriteLine("[" & index & "] - " & arr(index))
        Next index
    End Sub
End Module

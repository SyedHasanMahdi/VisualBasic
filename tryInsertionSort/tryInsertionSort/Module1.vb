Imports System.CodeDom.Compiler
Imports System.Deployment.Application

Module Module1

    Sub Main()
        Dim myArr(9) As Integer
        myArr(0) = 17
        myArr(1) = 84
        myArr(2) = 3
        myArr(3) = 5
        myArr(4) = 87
        myArr(5) = 110
        myArr(6) = 24
        myArr(7) = 36
        myArr(8) = 208
        myArr(9) = 19
        myArr(10) = 1

        'Dim index, key, j As Integer

        'For index = 1 To mylist.Length - 1
        '    j = index - 1
        '    key = mylist(index)
        '    While j >= 0 AndAlso mylist(j) > key
        '        mylist(j + 1) = mylist(j)
        '        j = j - 1
        '    End While
        '    mylist(j + 1) = key
        'Next




        'Console.WriteLine("Sorted list:")
        'For index = 0 To 8
        '    Console.WriteLine(mylist(index))
        'Next

        Dim temp As Integer
        Dim x As Integer
        For y = 1 To 10
            x = y - 1
            temp = myArr(1)
            While x >= 0 And myArr(x) > temp
                myArr(x + 1) = myArr(x)
                x = x - 1
            End While
            myArr(x + 1) = temp
        Next y


    End Sub

End Module

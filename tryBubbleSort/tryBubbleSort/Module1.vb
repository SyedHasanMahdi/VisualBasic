Imports System.CodeDom.Compiler

Module Module1
    '   Title:          tryBubbleSort
    '   Author:         Hasan
    '   Version:        0.1
    '   Date:           4/11/2025
    '   Desc:           Trying out bubble sort algorithm

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

        Dim swap As Boolean = True
        Dim temp As Integer

        While swap = True
            swap = False
            For x = 0 To 9
                If myArr(x) > myArr(x + 1) Then
                    '   Swap
                    temp = myArr(x)
                    myArr(x) = myArr(x + 1)
                    myArr(x + 1) = temp
                    swap = True
                End If
            Next x
        End While
    End Sub

End Module

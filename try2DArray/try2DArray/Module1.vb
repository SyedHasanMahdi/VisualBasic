Module module1
    '   title:          try2darray
    '   author:         hasan
    '   version:        0.1
    '   date:           04/02/2025
    '   desc:           trying out some basic 2d array operations


    Sub main()
        Dim myarr(99, 1) As Integer
        Randomize()
        For row = 0 To 99
            For col = 0 To 1
                myarr(row, col) = (Rnd() * 4000) + 1
            Next
        Next

        Console.WriteLine("index" & vbTab & "column 1 " & vbTab & "column 2")
        For index = 0 To 99
            Console.WriteLine(index & vbTab & myarr(index, 0) & vbTab & vbTab & myarr(index, 1))
        Next



        Dim swapped As Boolean
        Dim size As Integer
        Dim temp As Integer
        'size = 100


        'Do
        '    swapped = False
        '    For row = 0 To 98
        '        If myarr(row, 0) < myarr(row + 1, 0) Then
        '            temp = myarr(row, 0)
        '            myarr(row, 0) = myarr(row + 1, 0)
        '            myarr(row + 1, 0) = temp
        '            swapped = True
        '        End If
        '    Next
        '    size = size - 1
        'Loop Until swapped = False Or size = 0

        'size = 100
        'Do
        '    swapped = False
        '    For row = 0 To 98
        '        If myarr(row, 1) > myarr(row + 1, 1) Then
        '            temp = myarr(row, 1)
        '            myarr(row, 1) = myarr(row + 1, 1)
        '            myarr(row + 1, 1) = temp
        '            swapped = True
        '        End If
        '    Next
        '    size = size - 1
        'Loop Until swapped = False Or size = 0

        'Console.WriteLine("index" & vbTab & "column 1 " & vbTab & "column 2")
        'For index = 0 To 99
        '    Console.WriteLine(index & vbTab & myarr(index, 0) & vbTab & vbTab & myarr(index, 1))
        'Next


        Dim inputnum As Integer
        Dim found As Boolean = False
        Console.WriteLine("enter a number")
        inputnum = Console.ReadLine()

        Dim row1 As Integer
        row1 = 0
        size = 100
        While size > 0
            swapped = False
            While swapped = False
                swapped = False
                If myarr(row1, 0) < myarr(row1 + 1, 0) Then
                    temp = myarr(row1 + 1, 0)
                    myarr(row1, 0) = myarr(row1 + 1, 0)
                    myarr(row1 + 1, 0) = temp
                    swapped = True
                End If
                row1 = row1 + 1
            End While
            size = size - 1
        End While

        row1 = 0
        size = 100
        While size > 0
            swapped = False
            While swapped = False
                swapped = false
                If myarr(row1, 1) > myarr(row1 + 1, 1) Then
                    temp = myarr(row1 + 1, 0)
                    myarr(row1, 1) = myarr(row1 + 1, 1)
                    myarr(row1 + 1, 1) = temp
                    swapped = True
                End If
                row1 = row1 + 1
            End While
            size = size - 1
        End While


        Console.WriteLine("index" & vbTab & "column 1 " & vbTab & "column 2")
        For index = 0 To 99
            Console.WriteLine(index & vbTab & myarr(index, 0) & vbTab & vbTab & myarr(index, 1))
        Next


        For row = 0 To 99
            For col = 0 To 1
                If myarr(row, col) = inputnum Then
                    found = True
                    Console.WriteLine("number found at, row: " & row & ", col: " & col)
                End If
            Next
        Next

        If found = False Then
            Console.WriteLine("-1")
        End If

        Dim row2, col2 As Integer
        row2 = 0
        col2 = 0
        found = False
        While row2 < 100 And found = False
            If myarr(row2, 0) = inputnum Or myarr(row2, 1) = inputnum Then
                found = True
                Console.WriteLine("number found at, row: " & row2)
            End If
            row2 = row2 + 1
        End While

        If found = False Then
            Console.WriteLine("-1")
        End If

        Console.ReadLine()
    End Sub

End Module
Module Module1

    Sub Main()
        'Dim myNum As Integer = 0
        'Randomize()

        'For index = 1 To 30
        '    myNum = (Rnd() * 10000) + 1

        '    Console.WriteLine("random number " & index & ": " & myNum)
        'Next


        Dim fname(9), sname(9) As String
        Dim age(9) As Integer
        Dim oldest As Integer = -100
        Dim oldestindex, youngestindex As Integer
        Dim youngest As Integer = 100


        For index = 0 To 9
            Console.WriteLine("enter the first name of index number " & index)
            fname(index) = Console.ReadLine()
            Console.WriteLine("enter the second name of index number " & index)
            sname(index) = Console.ReadLine()
            age(index) = (Rnd() * 84)
            If age(index) > oldest Then
                oldest = index
                oldestindex = index
            End If
            If age(index) < youngest Then
                youngest = age(index)
                youngestindex = index

            End If
        Next

        Console.Clear()

        For index = 0 To 9
            Console.WriteLine("index " & index & " Name: " & fname(index) & " " & sname(index) & ", Age " & age(index))
        Next

        Console.WriteLine("the oldest person is " & fname(oldestindex) & " " & sname(oldestindex) & " with an age of " & age(oldestindex))
        Console.WriteLine("the youngest person is " & fname(youngestindex) & " " & sname(youngestindex) & " with an age of " & age(youngestindex))

        Dim swap As Boolean = True


        While swap

            For index = 0 To fname.Length() - 1
                swap = False
                For index2 = 0 To fname.Length() - 2
                    If fname(index) > fname(index + 1) Then
                        Console.WriteLine("")
                    End If
                Next
            Next

        End While








        Console.ReadLine()
    End Sub

End Module

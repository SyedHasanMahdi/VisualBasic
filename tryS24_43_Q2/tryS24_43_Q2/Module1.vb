
Imports System.IO

Module Module1

    Sub Main()
        Dim Trees() As Tree = ReadData("Trees")
        'For index = 0 To 8
        '    PrintTrees(Trees(index))
        'Next
        ChooseTree(Trees)
    End Sub

    Public Function ReadData(filename As String)
        Dim myTrees(8) As Tree
        Dim reader As IO.StreamReader
        Try
            reader = New IO.StreamReader(filename & ".txt")
        Catch ex As FileNotFoundException
            Console.WriteLine("Error, File not found")
        End Try
        Dim tempTree As String


        For index = 0 To 8
            tempTree = reader.ReadLine()
            Dim currTree() As String = Split(tempTree, ",")
            myTrees(index) = New Tree(currTree(0), currTree(1), currTree(2), currTree(3), currTree(4))
        Next
        reader.Close()
        Return myTrees
    End Function

    Public Sub PrintTrees(Tree As Tree)
        If UCase(Tree.GetEvergreen) = "NO" Then
            Console.WriteLine(Tree.GetTreeName & " has a maximum height " & Tree.GetMaxHeight & ", a maximum width " & Tree.GetMaxWidth & " and grows " & Tree.GetGrowth & "cm a year. It does not lose leaves")
        Else
            Console.WriteLine(Tree.GetTreeName & " has a maximum height " & Tree.GetMaxHeight & ", a maximum width " & Tree.GetMaxWidth & " and grows " & Tree.GetGrowth & "cm a year. It loses its leaves each year")
        End If
    End Sub

    Public Sub ChooseTree(Trees() As Tree)

        Console.WriteLine("Enter the Maximum Height of your tree")
        Dim MaxHeight As String = Console.ReadLine()
        Console.WriteLine("Enter the Maximum Width of your tree")
        Dim MaxWidth As String = Console.ReadLine()
        Console.WriteLine("Do u want an evergreen tree? Enter No or Yes")
        Dim Evergreen As String = Console.ReadLine()

        Dim Matching(8) As Tree
        Dim counter As Integer = 0

        For index = 0 To 8
            If MaxHeight >= Trees(index).GetMaxHeight And MaxWidth >= Trees(index).GetMaxWidth And Trees(index).GetEvergreen = Evergreen Then
                Matching(counter) = Trees(index)
                counter = counter + 1
            End If
        Next
        For index = 0 To counter - 1
            PrintTrees(Matching(index))
        Next
        If counter = 0 Then
            Console.WriteLine("No trees matched ur requirements")
        End If
    End Sub
End Module

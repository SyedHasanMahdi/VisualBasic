Public Class Number
    '   Private - attributes and methods are only accessible within the class
    '   Protected - attributes and methods are accessible in the class and child classes
    '   Public - attributes and methods are accessible across the entire project
    Private value As Integer
    Private isOdd As Boolean
    Private isPrime As Boolean
    Private factorial As Double
    Private sum As Double


    '   Constructor
    Public Sub New(val As Integer)
        value = val
        setIsOdd()
        setFact()
        setSum()
        setIsPrime()
    End Sub

    '   Setters
    Public Sub setIsOdd()
        If value Mod 2 = 1 Then
            isOdd = True
        Else
            isOdd = False
        End If
    End Sub

    Public Sub setFact()
        '   Calculate the factorial of value

        factorial = 1
        For index = 1 To value
            factorial = factorial * index
        Next
    End Sub

    Public Sub setSum()
        sum = 0
        For index = 1 To value
            sum = sum + index
        Next
    End Sub

    Public Sub setIsPrime()
        isPrime = True

        For index = 2 To value / 2
            If value Mod index = 0 Then
                isPrime = False
            End If
        Next
    End Sub

    Public Function getValue() As Integer
        Return value
    End Function
    Public Function getIsOdd() As Boolean
        Return isOdd
    End Function
    Public Function getFact() As Double
        Return factorial
    End Function
    Public Function getSum() As Double
        Return sum
    End Function
    Public Function getIsPrime() As Boolean
        Return isPrime
    End Function
End Class


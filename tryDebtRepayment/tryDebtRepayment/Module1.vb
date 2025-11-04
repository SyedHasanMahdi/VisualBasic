Module Module1
    '   Title:          tryDebtRepayment
    '   Author:         Hasan
    '   Version:        0.1
    '   Date:           12/11/2024
    '   Desc:           Trying out a full olympiad examination activity
    Sub Main()

        Dim Debt As Integer = 100
        Dim Repayment, interest As Integer
        Dim TotalPaidBack, AmountToPay As Double


        Console.WriteLine("Enter the interest rate being used!")
        interest = Console.ReadLine()
        Console.WriteLine("Enter the repayment percentage!")
        Repayment = Console.ReadLine()

        Console.Clear()



        Do Until Debt <= 0
            Debt = Debt + (Debt * (interest / 100))
            Console.WriteLine(Debt)
            AmountToPay = 0

            If (Debt * 0.5) > (Debt * (Repayment / 100)) Then
                AmountToPay = (Debt * 0.5)
                Debt = Debt - AmountToPay
                TotalPaidBack = TotalPaidBack + AmountToPay
            Else
                AmountToPay = Debt * (Repayment / 100)
                Debt = Debt - AmountToPay
                TotalPaidBack = TotalPaidBack + AmountToPay

            End If

        Loop

        Console.WriteLine("The total amount paid back to the lender is: " & TotalPaidBack)


        'Keep console open
        Console.ReadLine()


    End Sub

End Module

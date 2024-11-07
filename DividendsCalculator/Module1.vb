Module Module1

    Sub Main()
        ' Author: Bruno S.
        ' Date: 11/6/2024

        ' write out intro
        Console.WriteLine("Hello! This is the Stock Dividends Calculator")
        Console.WriteLine("----------------------------------------------")

        ' prompt user for stock amount
        Console.WriteLine("Please enter your Stock amount ($) invested per year: ")
        Dim annualStockAmount As Double = Console.ReadLine()

        ' prompt user for divided amount
        Console.WriteLine("Please enter your Dividend amount (%): ")
        Dim dividend As Double = Console.ReadLine()

        ' prompt user for number of years planning to invest
        Console.WriteLine("How many years are you planning to invest?")
        Dim years As Integer = Console.ReadLine()

        ' calculate amounts
        Dim yearlyDividend As Double = 0.0
        Dim runningStockAmount As Double = 0.0

        Console.WriteLine("You plan to invest for " & years & "years.")

        For x = 0 To years - 1

            Console.WriteLine("This is year " & x + 1 & ".")

            Console.WriteLine("Starting amount: " & runningStockAmount)

            yearlyDividend = If(x = 0, annualStockAmount * dividend, runningStockAmount * dividend)

            Console.WriteLine("Dividend amount: " & yearlyDividend)

            runningStockAmount += annualStockAmount + yearlyDividend

            Console.WriteLine("Ending amount: " & runningStockAmount)
            'runningStockAmount += annualStockAmount

            Console.WriteLine()
        Next

        Dim totalCost As Double = years * annualStockAmount

        Console.WriteLine("Total amount spent on stock: " & totalCost)
        Console.WriteLine("Total amount spent from stock dividends: " & totalCost * dividend)

        ' write out outro
        Console.WriteLine("----------------------------------------------\n\n")

    End Sub

End Module

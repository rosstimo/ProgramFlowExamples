Option Strict On
Option Explicit On
Option Compare Text

Module ProgramFlowExamples

    Sub Main()
        Dim userInput As String
        Dim firstNumber As Integer
        Dim secondNumber As Integer = 5
        Dim calculationResult As Integer
        Dim userInputIsValid As Boolean

        'Prompt user for a whole number
        'Repeat until the user provides a valid number or quits
        Do
            'prompt user and display the user input
            userInputIsValid = True
            Console.WriteLine("Please enter a whole number or Q to quit")
            userInput = Console.ReadLine()
            Console.WriteLine($"You entered {userInput}")
            'test the user input
            'on valid input perform the calculation and display the result
            Try
                firstNumber = CInt(userInput)
                calculationResult = firstNumber + secondNumber
                Console.WriteLine($"Result: {firstNumber} + {secondNumber} = {calculationResult}")
            Catch
                If userInput <> "Q" Then
                    userInputIsValid = False
                End If
            End Try
        Loop Until userInputIsValid = True
        'clean exit
        Console.WriteLine("Have a nice day!!!")
        Console.Read()
    End Sub

End Module

Option Strict On
Option Explicit On
Option Compare Text

Module ProgramFlowExamples

    Sub Main()
        Dim userResponse As String
        Dim userNumber As Integer
        Dim secondNumber As Integer = 5
        Dim result As Integer
        Dim isValidNumber As Boolean

        Do
            isValidNumber = True
            Console.WriteLine("Please enter a whole number or Q to quit")
            userResponse = Console.ReadLine()
            Console.WriteLine($"You entered {userResponse}")
            Try
                userNumber = CInt(userResponse)
                result = userNumber + secondNumber
                Console.WriteLine($"Result: {userNumber} + {secondNumber} = {result}")
            Catch
                If userResponse <> "Q" Then
                    isValidNumber = False
                End If
            End Try
        Loop Until isValidNumber = True And (userResponse <> "Q" Or userResponse <> "q")
        Console.WriteLine("Have a nice day!!!")
        Console.Read()
    End Sub

End Module

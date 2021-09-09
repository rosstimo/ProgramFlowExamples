Option Strict On
Option Explicit On

Module ProgramFlowExamples

    Sub Main()
        Dim userResponse As String
        Dim userNumber As Integer
        Dim secondNumber As Integer = 5
        Dim result As Integer
        Dim isValidNumber As Boolean

        Do
            Console.WriteLine("Please enter a whole number or Q to quit")
            userResponse = Console.ReadLine()
            Console.WriteLine($"You entered {userResponse}")

            'If userResponse = "Q" Then
            '    MsgBox("Quitter!")
            'End If

            Try
                userNumber = CInt(userResponse)
                isValidNumber = True
            Catch
                isValidNumber = False
            End Try

        Loop While isValidNumber = False And (userResponse <> "Q" Or userResponse <> "q")

        If userResponse <> "Q" Or userResponse <> "q" Then
            result = userNumber + secondNumber
            Console.WriteLine($"Result: {userNumber} + {secondNumber} = {result}")
        Else
            Console.WriteLine("Have a nice day!!!")
        End If

        Console.Read()

    End Sub

End Module

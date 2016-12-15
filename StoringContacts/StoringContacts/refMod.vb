Imports System.Text.RegularExpressions

Public Module refMod
    Public projectdir As String = System.IO.Directory.GetCurrentDirectory

    Structure Contact
        Dim arrName As String()
        Dim arrAddress As String()
        Dim arrNumber As String()
        Dim arrFamily As String()
    End Structure

    'input validation'

    'check multiple strings
    Public Function isInputInvalid(ByVal ParamArray args() As String) As Boolean
        If args Is Nothing Then 'no args provided
            Console.WriteLine("isInputInvalid : Error no args() param provided")
            Return True
        End If

        For Each arg As String In args 'check generic input
            If arg = Nothing Then 'null
                Console.WriteLine("isInputInvalid : Match on null")
                Return True 'if there are errors
            ElseIf arg.Contains(",") Then 'commas
                Console.WriteLine("isInputInvalid : Match on commas")
                Return True
            ElseIf New Regex("[^a-zA-Z0-9_.,\s-]").IsMatch(arg) Then 'symbols
                Console.WriteLine("isInputInvalid : Match on symbols")
                Return True
            Else
                Continue For
            End If
        Next
        Return False 'if there are not errors
    End Function

    'check a string, optionally specify type of string (from form text fields) to check
    Public Function isInputInvalid(ByVal arg As String, Optional type As String = Nothing) As Boolean
        If type = Nothing Then 'check generic input
            If arg = Nothing Then 'null
                Console.WriteLine("isInputInvalid : Match on null")
                Return True 'if there are errors
            ElseIf arg.Contains(",") Then 'commas
                Console.WriteLine("isInputInvalid : Match on commas")
                Return True
            ElseIf New Regex("[^a-zA-Z0-9_.,\s-]").IsMatch(arg) Then 'symbols
                Console.WriteLine("isInputInvalid : Match on symbols")
                Return True
            End If
            Return False 'if there are not errors

        ElseIf Not type = Nothing Then 'optional type check
            'generic checks
            If arg = Nothing Then 'null
                Console.WriteLine("isInputInvalid : Match on null")
                Return True 'if there are errors
            ElseIf arg.Contains(",") Then 'commas
                Console.WriteLine("isInputInvalid : Match on commas")
                Return True
            ElseIf New Regex("[^a-zA-Z0-9_.,\s-]").IsMatch(arg) Then 'symbols
                Console.WriteLine("isInputInvalid : Match on symbols")
                Return True
            End If

            'type checks
            If type = "name" And New Regex("[0-9]").IsMatch(arg) Then 'numbers
                Return True
            ElseIf New Regex("address-.+").IsMatch(type) Then

            ElseIf type = "phone-number" Then
                If New Regex("[a-zA-Z]").IsMatch(arg) Then 'word characters
                    Return True
                ElseIf arg.Length > 14 Or arg.Length < 8 Then 'length
                    Return True
                End If
            ElseIf type = "family" And New Regex("[0-9]").IsMatch(arg) Then 'numbers
                Return True
            End If
            Return False 'if there are not errors
        End If

        Console.WriteLine("isInputInvalid : Error logic check skipped")
        Return True
    End Function
End Module

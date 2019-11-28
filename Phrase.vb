Module Module1

    Sub Main()
        Dim Alphabets(26), X, Counter As Integer
        Dim Phrase As String
        Dim NextAlpha, Ch As Char

        Phrase = " "
        For Counter = 1 To 26
            Alphabets(Counter) = 0  
        Next
        Counter = 0

        Phrase = Console.ReadLine
        Phrase = UCase(Phrase)

        For Counter = 1 To Len(Phrase)
            NextAlpha = Mid(Phrase, Counter, 1)
            X = Asc(NextAlpha)
            X = X - 64
            Alphabets(X) = Alphabets(X) + 1
        Next

        For Counter = 1 To 26
            Ch = Chr(Counter + 64)
            X = Alphabets(Counter)
            If Alphabets(Counter) > 0 Then
                Console.WriteLine(Ch & " = " & X)
            End If
        Next

        Console.ReadKey()

    End Sub

End Module

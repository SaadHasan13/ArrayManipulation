Module Module1

    Sub Main()
        Dim NamesArray(6), SName As String
        Dim A As Integer
        Dim IsItFound As Boolean
        IsItFound = False

        For A = 1 To 6
            NamesArray(A) = " "
        Next

        For A = 1 To 5
            Console.WriteLine("Enter a name: " & A & " ")
            SName = Console.ReadLine
            NamesArray(A) = SName
        Next

        Console.Write("ENter a sensible name to search for: ")
        SName = Console.ReadLine
        For A = 1 To 5
            If NamesArray(A) = SName Then
                Console.WriteLine(A)
                IsItFound = True
            End If
        Next
        If IsItFound = False Then
            Console.WriteLine("The name you entered was not found. ")
        End If
        Console.ReadKey()


    End Sub

End Module

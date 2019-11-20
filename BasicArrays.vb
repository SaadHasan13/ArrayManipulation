Module Module1

    Sub Main()
        Dim arr(6), I As Integer

        arr(0) = 200
        arr(1) = 400
        arr(2) = 600
        arr(3) = 800
        arr(4) = 1000
        arr(5) = 1200
        arr(6) = 1400

        For I = 1 To 6
            Console.WriteLine("arr " & I & " is " & arr(I))
        Next

        Console.ReadKey()

    End Sub

End Module

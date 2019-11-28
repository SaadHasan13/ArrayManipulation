Module Module1

    Sub Main()
        Dim binArr(8), Denary, I, Remainder As Integer

        Do Until Denary >= 0 And Denary <= 255

            Console.Write("Enter a Denary number between 0 to 255:")
            Denary = Console.ReadLine()

        Loop

        For I = 1 To 8
            binArr(I) = 0 
        Next

        Do While Denary > 0
            I = I + 1
        Remainder = Denary Mod 2
        binArr(I) = Remainder
        
        
            Denary = Denary / 2
        Loop

        For I = 8 To 1 Step -1
            Console.WriteLine(binArr(I))
        Next

        Console.ReadKey()
    End Sub

End Module

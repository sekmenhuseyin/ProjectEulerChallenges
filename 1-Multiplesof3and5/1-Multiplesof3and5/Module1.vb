Module Module1

    Sub Main()
        Dim sum As Integer = 0
        For index = 1 To 999
            If index Mod 3 = 0 Or index Mod 5 = 0 Then sum += index
        Next
        Console.WriteLine(sum)
        Console.ReadLine()

    End Sub

End Module

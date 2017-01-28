Module Module1

    Sub Main()
        Dim max As Int64 = Math.Floor(600851475144 / 2)
        Dim prime As Boolean = True
        For index = 3 To max Step 2
            If 600851475143 Mod index = 0 Then
                If isPrime(index) = True Then Console.WriteLine(index)
            End If

        Next
        Console.WriteLine("-")
        Console.ReadLine()
    End Sub
    Private Function isPrime(num As Integer) As Boolean
        Dim itsPrime As Boolean = True
        For j As Integer = 2 To num - 1
            If num Mod j = 0 Then itsPrime = False : Exit For
        Next
        Return itsPrime
    End Function

End Module

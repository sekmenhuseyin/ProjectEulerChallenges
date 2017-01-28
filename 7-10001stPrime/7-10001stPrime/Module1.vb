Module Module1

    Sub Main()
        Dim sayi As Integer = 0
        For i = 2 To 10000000
            If isPrime(i) = True Then sayi += 1
            If sayi = 10001 Then sayi = i : Exit For

        Next

        Console.WriteLine(sayi)
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

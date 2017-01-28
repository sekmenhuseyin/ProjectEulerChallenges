Module Module1

    Sub Main()
        Dim sonuc As Int64 = 0
        'loop each number descending
        For i As Int64 = 2 To 2000000
            If isPrime(i) Then sonuc += i
        Next
        Console.WriteLine(sonuc)
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

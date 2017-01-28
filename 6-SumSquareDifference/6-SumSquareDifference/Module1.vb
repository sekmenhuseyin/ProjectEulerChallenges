Module Module1

    Sub Main()
        Dim sonuc1, sonuc2 As Integer
        sonuc1 = 0 : sonuc2 = 0
        For index = 1 To 100
            sonuc1 += (index * index)
            sonuc2 += index
        Next
        sonuc2 = sonuc2 * sonuc2

        Console.WriteLine(sonuc2 - sonuc1)
        Console.ReadLine()
    End Sub

End Module

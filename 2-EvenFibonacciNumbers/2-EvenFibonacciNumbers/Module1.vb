Module Module1

    Sub Main()
        Dim first, second, tmp, total As Integer
        total = 0 : first = 1 : second = 2
        While first < 4000000 And second < 4000000
            If second Mod 2 = 0 Then total += second
            tmp = first + second
            first = second
            second = tmp

        End While
        Console.WriteLine(total)
        Console.ReadLine()

    End Sub

End Module

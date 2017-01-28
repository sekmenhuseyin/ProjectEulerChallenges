Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        Dim sonuc As Integer = 1
        For index = 1 To 2000000000
            If isDivisible(index) = True Then sonuc = index : Exit For

        Next

        Console.WriteLine(sonuc)
        Console.ReadLine()
    End Sub
    Private Function isDivisible(num As Integer) As Boolean
        Dim divs As Boolean = True
        For j As Integer = 2 To 20
            If num Mod j <> 0 Then divs = False : Exit For
        Next
        Return divs
    End Function
End Module

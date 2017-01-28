Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        Dim first, second, pal As Integer
        Dim sonuc As Boolean = False
        For first = 999 To 100 Step -1
            For second = 999 To 900 Step -1
                pal = first * second
                If isPalindrome(pal) = True Then Console.WriteLine(pal) : sonuc = True : Exit For
            Next
            If sonuc = True Then Exit For
        Next


        Console.ReadLine()
    End Sub
    Private Function isPalindrome(sayi As Integer) As Boolean
        Dim tmp As String = sayi.ToString()
        For i As Integer = 0 To tmp.Length - 1
            If tmp(i) <> tmp(tmp.Length - 1 - i) Then Return False : Exit For
        Next
        Return True
    End Function
End Module

Module Module1

    Sub Main()
        Dim s As String = "abc"
        Console.WriteLine("Original string= " & s)

        Dim nw As String = StrReverse(s)
        Console.WriteLine("Reverse String= " & nw)

        Console.ReadKey()

    End Sub

End Module

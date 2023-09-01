Module Module1

    Sub Main()

        Dim a() As Integer = {0, 1, 2, 3, 4, 5}

        Console.WriteLine("Original array is: ")
        For Each i As Integer In a
            Console.WriteLine(i)
        Next
        Console.WriteLine()

        Array.Reverse(a)

        Console.WriteLine("Reverse array is: ")
        For Each i As Integer In a
            Console.WriteLine(i)

        Next
        Console.ReadKey()

    End Sub

End Module

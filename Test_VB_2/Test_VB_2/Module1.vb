Module Module1
    Sub Main()
        Dim i As Integer = 10, j As Integer = 20, result As Integer = 0
        result = SumOfNumbers(i, j)
        Console.WriteLine("Result: {0}", result)
        Console.ReadLine()
    End Sub
    Public Function SumOfNumbers(ByVal a As Integer, ByVal b As Integer) As Integer
        Dim x As Integer = a + b
        Return x
    End Function

End Module

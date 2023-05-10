Module Module1
    Sub Main()
        'Do While

        'Dim i As Integer = 1
        'Do
        '    Console.WriteLine("i value: {0}", i)
        '    i += 1
        '    Dim j As Integer = 1
        '    Do
        '        Console.WriteLine("j value: {0}", j)
        '        j += 1
        '    Loop While j < 2
        'Loop While i < 4
        'Console.WriteLine("press enter key to exit...")
        'Console.ReadLine()

        'Dim i As Integer = 1
        'Do
        '    Console.WriteLine("i value: {0}", i)
        '    i += 1
        '    If i = 2 Then Exit Do
        'Loop While i < 4
        'Console.WriteLine("press enter key to exit...")
        'Console.ReadLine()

        'For Each

        'Dim names As String() = New String(2) {"Thoang Tran", "Thoang Tran12", "Thoang Tran123421"}
        'For Each name As String In names
        '    Console.WriteLine(name)
        'Next
        'Console.WriteLine("Press Enter Key to Exit...")
        'Console.ReadLine()

        'Dim names As List(Of String) = New List(Of String)() From {
        '  "Thoang Tran",
        '  "Thoang Tran12324",
        '  "Thoang Tran3412"
        '}
        'For Each name As String In names
        '    Console.WriteLine(name)
        'Next
        'Console.WriteLine("Press Enter Key to Exit")

        'Exit For

        'For i As Integer = 1 To 4
        '    If i = 3 Then Exit For
        '    Console.WriteLine("i value: {0}", i)
        'Next
        'Console.WriteLine("Press Enter Key to Exit...")
        'Console.ReadLine()

        'Exit While

        'Dim j As Integer = 1
        'While j < 4
        '    Console.WriteLine("j value: {0}", j)
        '    j += 1
        '    If j = 2 Then Exit While
        'End While
        'Console.WriteLine("Press Enter Key to Exit...")
        'Console.ReadLine()


        'Exit Do While

        'Dim k As Integer = 1
        'Do
        '    Console.WriteLine("k value: {0}", k)
        '    k += 1
        '    If k = 3 Then Exit Do
        'Loop While k < 4
        'Console.WriteLine("Press Enter Key to Exit...")
        'Console.ReadLine()


        'Continue For

        'For i As Integer = 1 To 4
        '    If i = 3 Then Continue For
        '    Console.WriteLine("i value: {0}", i)
        'Next
        'Console.WriteLine("Press Enter Key to Exit...")
        'Console.ReadLine()

        'Continue While

        'Dim j As Integer = 1
        'While j < 4
        '    j += 1
        '    If j = 2 Then Continue While
        '    Console.WriteLine("j value: {0}", j)
        'End While
        'Console.WriteLine("Press Enter Key to Exit...")
        'Console.ReadLine()


        'Continue Do While

        'Dim k As Integer = 1
        'Do
        '    Console.WriteLine("k value: {0}", k)
        '    k += 1
        '    If k = 2 Then Continue Do
        'Loop While k < 4
        'Console.WriteLine("Press Enter Key to Exit...")
        'Console.ReadLine()

        'Goto For Loop

        '        For i As Integer = 1 To 10 - 1
        '            If i = 5 Then
        '                GoTo endloop
        '            End If
        '            Console.WriteLine("i value: {0}", i)
        '        Next
        'endloop:
        '        Console.WriteLine("The end")
        '        Console.WriteLine("Press Enter Key to Exit...")
        '        Console.ReadLine()


        'Dim number As Integer = Module2.Sum(4, 6)
        'Console.WriteLine(number)
        'Console.ReadLine()
        'Console.ReadKey()

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

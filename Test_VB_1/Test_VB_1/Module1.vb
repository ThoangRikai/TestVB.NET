Module Module1

    Sub Main()

        ''Select Case Example

        'Dim x As Integer = 10, y As Integer = 5
        'Select Case x
        '    Case 10
        '        Console.WriteLine("X Value: 10")
        '        Select Case y
        '            Case 5
        '                Console.WriteLine("Nested Switch Value: 5")
        '                Select Case y - 2
        '                    Case 3
        '                        Console.WriteLine("Another Nested Switch Value: 3")
        '                End Select
        '        End Select
        '    Case 15
        '        Console.WriteLine("X Value: 15")
        '    Case 20
        '        Console.WriteLine("X Value: 20")
        '    Case Else
        '        Console.WriteLine("Not Known")
        'End Select
        'Console.WriteLine("Press Enter Key to Exit...")
        'Console.ReadLine()

        ''For Example

        'For i As Integer = 1 To 4
        '    If i = 3 Then Exit For
        '    Console.WriteLine("i value: {0}", i)
        'Next
        'Console.WriteLine("Press Enter Key to Exit...")
        'Console.ReadLine()

        'For i As Integer = 1 To 4
        '    For j As Integer = i To 3 - 1
        '        Console.WriteLine("i value: {0}, j value: {1}", i, j)
        '    Next
        'Next
        'Console.WriteLine("Press Enter Key to Exit...")
        'Console.ReadLine()

        'while example

        Dim i As Integer = 1
        While i <= 4
            Console.WriteLine("i value: {0}", i)
            i += 1
        End While
        Console.WriteLine("Press Enter Key to Exit...")
        Console.ReadLine()
    End Sub
End Module

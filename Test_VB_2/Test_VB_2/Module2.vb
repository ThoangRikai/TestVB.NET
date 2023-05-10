Module Module2
    Sub Main()
        Console.WriteLine("hello vb.net")

        'Array

        'No For Loop

        'Dim array As Integer() = New Integer(4) {1, 2, 3, 4, 5}
        'Console.WriteLine(array(0))
        'Console.WriteLine(array(1))
        'Console.WriteLine(array(2))
        'Console.WriteLine(array(3))
        'Console.WriteLine(array(4))
        'Console.WriteLine("Press Enter Key to Exit..")
        'Console.ReadLine()

        'For Loop

        'Dim array As Integer() = New Integer(4) {1, 2, 3, 4, 5}
        'For i As Integer = 0 To array.Length - 1
        '    Console.WriteLine(array(i))
        'Next
        'Console.WriteLine("Press Enter Key to Exit...")
        'Console.ReadLine()

        'Foreach Loop

        'Dim array As Integer() = New Integer(4) {1, 2, 3, 4, 5}
        'For Each i As Integer In array
        '    Console.WriteLine(i)
        'Next
        'Console.WriteLine("Press Enter Key to Exit...")
        'Console.ReadLine()

        'Array Class

        Dim arr As Integer() = New Integer(5) {3, 6, 2, 5, 1, 4}
        Console.WriteLine("---Initial Elements---")
        For Each i As Integer In arr
            Console.WriteLine(i)
        Next
        Array.Sort(arr)
        Console.WriteLine("---Elements After Sort---")
        For Each i As Integer In arr
            Console.WriteLine(i)
        Next
        Array.Reverse(arr)
        Console.WriteLine("---Elements After Reverse---")
        For Each i As Integer In arr
            Console.WriteLine(i)
        Next
        Console.WriteLine("Press Enter Key to Exit")
        Console.ReadLine()
    End Sub

End Module

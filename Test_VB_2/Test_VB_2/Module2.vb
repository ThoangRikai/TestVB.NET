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

        'Dim arr As Integer() = New Integer(5) {3, 6, 2, 5, 1, 4}
        'Console.WriteLine("---Initial Elements---")
        'For Each i As Integer In arr
        '    Console.WriteLine(i)
        'Next
        'Array.Sort(arr)
        'Console.WriteLine("---Elements After Sort---")
        'For Each i As Integer In arr
        '    Console.WriteLine(i)
        'Next
        'Array.Reverse(arr)
        'Console.WriteLine("---Elements After Reverse---")
        'For Each i As Integer In arr
        '    Console.WriteLine(i)
        'Next
        'Console.WriteLine("Press Enter Key to Exit")
        'Console.ReadLine()

        'Dimensional Array

        'Dim array2D As Integer(,) = New Integer(2, 1) {{4, 5}, {5, 0}, {3, 1}}
        'For i As Integer = 0 To 3 - 1
        '    For j As Integer = 0 To 2 - 1
        '        Console.WriteLine("a[{0}, {1}] = {2}", i, j, array2D(i, j))
        '    Next
        'Next
        'Console.WriteLine("Press Enter Key to Exit")
        'Console.ReadLine()

        'Jagged Array

        Dim jarray As Integer()() = New Integer(2)() {}
        jarray(0) = New Integer(4) {1, 2, 3, 4, 5}
        jarray(1) = New Integer(2) {10, 20, 30}
        jarray(2) = New Integer() {12, 50, 60, 70, 32}
        Console.WriteLine("---Jagged Array with Single Dimensional Elements---" & vbLf)
        For i As Integer = 0 To jarray.Length - 1
            Console.Write("Element[{0}]: ", i)
            For j As Integer = 0 To jarray(i).Length - 1

                Console.Write("{0}{1}", jarray(i)(j), If(j = (jarray(i).Length - 1), "", " "))
            Next
            Console.WriteLine()
        Next
        Console.WriteLine(vbLf & "Press Enter Key to Exit..")
        Console.ReadLine()
    End Sub

End Module

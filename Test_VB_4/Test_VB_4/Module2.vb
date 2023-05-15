Module Module2
    'String

    'Sub Main()
    '    Dim firstname As String = "Thoang"
    '    Dim lastname As String = "Tran"
    '    Dim location As String = "Danang"
    '    Dim name As String = firstname & " " & lastname
    '    Console.WriteLine(name)
    '    Dim userInfo As String = String.Format("Name: {0}, Location: {1}", name, location)
    '    Console.WriteLine(userInfo)
    '    Console.WriteLine(vbLf & "Press Enter Key to Exit...")
    '    Console.ReadLine()
    'End Sub

    'Split String

    'Sub Main()
    '    Dim msg As String = "Thoang,Viet,Nam"
    '    Dim strarr As String() = msg.Split(","c)
    '    For i As Integer = 0 To strarr.Length - 1
    '        Console.WriteLine(strarr(i))
    '    Next
    '    Console.WriteLine("Press Enter Key to Exit...")
    '    Console.ReadLine()
    'End Sub


    'Concat

    'Sub Main()
    '    Dim msg1 As String = "Welcome to"
    '    Dim msg2 As String = " " & "Rikai"
    '    Console.WriteLine("Message: {0}", String.Concat(msg1, msg2))
    '    Console.WriteLine("Press Enter Key to Exit..")
    '    Console.ReadLine()
    'End Sub

    'Contains

    'Sub Main()
    '    Dim msg As String = "Welcome to Rikai"
    '    Dim subtxt As String = "Rikai"
    '    Console.WriteLine("Does {0} String Contains {1}?: {2}", msg, subtxt, msg.Contains(subtxt))
    '    Dim subtxt1 As String = "rikai"
    '    Console.WriteLine("Does {0} String Contains {1}?: {2}", msg, subtxt, msg.Contains(subtxt1))
    '    Console.WriteLine("Press Enter Key to Exit...")
    '    Console.ReadLine()
    'End Sub

    'Substring

    'Sub Main()
    '    Dim msg As String = "Welcome to Rikai"
    '    Console.WriteLine("Substring: {0}", msg.Substring(5))
    '    Console.WriteLine("Substring with Length: {0}", msg.Substring(3, 7))
    '    Console.WriteLine("Press Enter Key to Exit..")
    '    Console.ReadLine()
    'End Sub

    'Compare String

    'Sub Main()
    '    Dim str1 As String = "Thoang"
    '    Dim str2 As String = "Tran"
    '    Console.WriteLine("Comparision of {0} and {1} Result: {2}", str1, str2, String.Compare(str1, str2))
    '    Console.ReadLine()
    'End Sub


    'Remove String
    'Sub Main()
    '    Dim msg As String = "Welcome to Rikai"
    '    Console.WriteLine("Remove Result: {0}", msg.Remove(5))
    '    Console.WriteLine("Remove with Length: {0}", msg.Remove(3, 7))
    '    Console.WriteLine("Press Enter Key to Exit..")
    '    Console.ReadLine()
    'End Sub


    'Format String
    'Sub Main()
    '    Dim s As String = "Name: {0} {1}, Location: {2}, Age: {3}"
    '    Dim msg As String = String.Format(s, "Thoang", "Tran", "Danang", 23)
    '    Console.WriteLine("Format Result: {0}", msg)
    '    Console.WriteLine("Press Enter Key to Exit..")
    '    Console.ReadLine()
    'End Sub

    'Equal String
    'Sub Main()
    '    Dim fname As String = "Thoang"
    '    Dim lname As String = "thoang"
    '    Console.WriteLine("{0} Equals to {1}? : {2}", fname, lname, fname.Equals(lname, StringComparison.OrdinalIgnoreCase))
    '    Console.WriteLine(vbLf & "Press Enter Key to Exit..")
    '    Console.ReadLine()
    'End Sub

    'Clone String

    'Sub Main()
    '    Dim msg As String = "Welcome to Rikai"
    '    Dim msg1 As String = CStr(msg.Clone())
    '    Console.WriteLine("String: {0}", msg)
    '    Console.WriteLine("Clone String: {0}", msg1)
    '    Console.WriteLine("Reference Equals: {0}", Object.ReferenceEquals(msg, msg1))
    '    Console.WriteLine("Press Enter Key to Exit..")
    '    Console.ReadLine()
    'End Sub

    'Trim String
    Sub main()
        Dim str1 As String = " welcom "
        Dim str2 As String = "   to  "
        Dim str3 As String = "   rikai  "
        Console.WriteLine("before trim: {0} {1} {2}", str1, str2, str3)
        Console.WriteLine("after trim: {0} {1} {2}", str1.Trim(), str2.Trim(), str3.Trim())
        Console.WriteLine("press enter key to exit..")
        Console.ReadLine()
    End Sub


End Module

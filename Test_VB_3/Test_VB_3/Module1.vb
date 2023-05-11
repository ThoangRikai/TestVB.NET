Module Module1

    'Class and Object

    'Sub Main()
    '    Dim user As User = New User("Thoang Tran", 23)
    '    user.GetUserDetails()
    '    Console.WriteLine("Press Enter Key to Exit....")
    '    Console.ReadLine()
    'End Sub

    'Public Class User
    '    Public Property UName As String
    '    Public Property UAge As Integer
    '    Public Sub New(ByVal name As String, ByVal age As Integer)
    '        UName = name
    '        UAge = age
    '    End Sub
    '    Public Sub GetUserDetails()
    '        Console.WriteLine("Name: {0}, Age: {1}", UName, UAge)
    '    End Sub
    'End Class

    'Constructor

    'Class User
    '    Public name, location As String
    '    'Default Constructor

    '    Public Sub New()
    '        name = "thoang tran"
    '        location = "viet nam"
    '    End Sub

    '    'Parameterized Constructor
    '    Public Sub New(ByVal a As String, ByVal b As String)
    '        name = a
    '        location = b
    '    End Sub
    'End Class

    'Sub Main()
    '    ' Default Constructor will be called

    '    Dim user As User = New User()

    '    ' Parameterized Constructor will be called

    '    Dim user1 As User = New User("Thoang Tran", "Viet Nam")
    '    Console.WriteLine(user.name & ", " & user.location)
    '    Console.WriteLine(user1.name & ", " & user1.location)
    '    Console.WriteLine(vbLf & "Press Enter Key to Exit...")
    '    Console.ReadLine()
    'End Sub

    'Constructor Chaining
    'Class User
    '    Public Sub New()
    '        Console.Write("Hi, ")
    '    End Sub
    '    Public Sub New(ByVal a As String)
    '        Me.New()
    '        Console.Write(a)
    '    End Sub
    '    Public Sub New(ByVal a As String, ByVal b As String)
    '        Me.New("welcome")
    '        Console.Write(a & " " & b)
    '    End Sub
    'End Class

    'Sub Main()
    '    Dim user As User = New User(" to ", "VietNam")
    '    Console.WriteLine()
    '    Console.WriteLine("Press Enter Key to Exit...")
    '    Console.ReadLine()
    'End Sub

    'Destructor

    Class User
        Public Sub New()
            Console.WriteLine("An Instance of class created")
        End Sub
        Protected Overrides Sub Finalize()
            Console.WriteLine("An Instance of class destroyed")
        End Sub
    End Class
    Sub Main()
        Details()
        GC.Collect()
        Console.ReadLine()
    End Sub
    Public Sub Details()
        Dim user As User = New User()
    End Sub
End Module

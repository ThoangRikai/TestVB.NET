Module Module1

    'ReadOnly
    'Class User
    '    ' Initialize Read-Only Fields
    '    Public ReadOnly name As String = "Thoang Tran"
    '    Public ReadOnly location As String
    '    Public ReadOnly age As Integer
    '    Public Sub New()
    '        location = "VietNam"
    '        age = 32
    '    End Sub
    'End Class
    'Sub Main()
    '    Dim u As User = New User()

    '    Console.WriteLine("Name: {0}", u.name)
    '    Console.WriteLine("Location: {0}", u.location)
    '    Console.WriteLine("Age: {0}", u.age)
    '    Console.WriteLine("Press Enter Key to Exit..")
    '    Console.ReadLine()
    'End Sub

    'Structure'

    'Structure User
    '    Public Const name As String = "Thoang Tran"
    '    Public age As Integer
    '    Public location As String
    '    Public Sub New(ByVal a As Integer, ByVal b As String)
    '        age = a
    '        location = b
    '    End Sub
    'End Structure

    'Sub Main()
    '    ' Declare object with new keyword
    '    Dim u As User = New User(23, "Viet Nam")
    '    ' Declare object without new keyword
    '    Dim u1 As User
    '    Console.WriteLine("Name: {0}, Age: {1}, Location: {2}", User.name, u.location, u.age)
    '    ' Initialize Fields
    '    u1.location = "Thai Lan"
    '    u1.age = 28
    '    Console.WriteLine("Name: {0}, Age: {1}, Location: {2}", User.name, u1.location, u1.age)
    '    Console.WriteLine("Press Enter Key to Exit..")
    '    Console.ReadLine()
    'End Sub

    'Enum

    'Enum Week
    '    Sunday
    '    Monday
    '    Tuesday
    '    Wednesday
    '    Thursday
    '    Friday
    '    Saturday
    'End Enum
    'Sub Main()
    '    Console.WriteLine("Week Enumeration Values")
    '    For Each w As String In [Enum].GetNames(GetType(Week))
    '        Console.WriteLine(w)
    '    Next
    '    Console.WriteLine("Press Any Key to Exit..")
    '    Console.ReadLine()
    'End Sub

    'Get and Set

    'Class User
    '    Private name As String = "Thoang Tran"
    '    Private location As String
    '    Public Property Uname As String
    '        Get
    '            Return name.ToUpper()
    '        End Get
    '        Set(ByVal value As String)
    '            If value = "Thoang" Then name = value
    '        End Set
    '    End Property
    '    Public Property Ulocation As String
    '        Get
    '            Return location
    '        End Get
    '        Set(ByVal value As String)
    '            location = value
    '        End Set
    '    End Property
    'End Class

    'Sub Main()
    '    Dim u As User = New User()
    '    u.Uname = "Thoang"
    '    u.Ulocation = "Viet Nam"
    '    Console.WriteLine("Name: " & u.Uname)
    '    Console.WriteLine("Location: " & u.Ulocation)
    '    Console.WriteLine("Press Enter Key to Exit..")
    '    Console.ReadLine()
    'End Sub

    'Partial Class
    'Partial Public Class User
    '    Private name As String
    '    Private location As String
    '    Public Sub New(ByVal a As String, ByVal b As String)
    '        Me.name = a
    '        Me.location = b
    '    End Sub
    'End Class

    'Partial Public Class User
    '    Public Sub GetUserDetails()
    '        Console.WriteLine("Name: " & name)
    '        Console.WriteLine("Location: " & location)
    '    End Sub
    'End Class
    'Sub Main()
    '    Dim u As User = New User("Thoang Tran", "Viet Nam")
    '    u.GetUserDetails()
    '    Console.WriteLine("Press Enter Key to Exit..")
    '    Console.ReadLine()
    'End Sub

    Partial Public Class User
        ' Partial Method Declaration
        Partial Private Sub GetUserDetails(ByVal x As String, ByVal y As String)
        End Sub
    End Class

    Partial Public Class User
        Public Sub New(ByVal a As String, ByVal b As String)
            GetUserDetails(a, b)
        End Sub

        ' Partial Method Implementation
        Private Sub GetUserDetails(ByVal x As String, ByVal y As String)
            Console.WriteLine("Name: " & x)
            Console.WriteLine("Location: " & y)
        End Sub
    End Class

    Sub Main()
        Dim u As User = New User("Thoang Tran", "Viet Nam")
        Console.WriteLine("Press Enter Key to Exit..")
        Console.ReadLine()
    End Sub
End Module

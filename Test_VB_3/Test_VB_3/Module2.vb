Module Module2

    'Method

    'Sub Main()
    '    Dim result As String = GetUserDetails("Thoang Tran", 23)
    '    Console.WriteLine(result)
    '    GetDetails()
    '    Console.ReadLine()
    'End Sub
    'Public Sub GetDetails()
    '    Console.WriteLine("Press Key Enter to Exit...")
    'End Sub
    'Public Function GetUserDetails(ByVal name As String, ByVal age As Integer) As String
    '    Dim info As String = String.Format("Name: {0}, Age: {1}", name, age)
    '    Return info
    'End Function

    'Me Keyword

    'Class User
    '    Public name, location As String
    '    Public marks As Long = 470
    '    Public Sub New(ByVal name As String, ByVal location As String)
    '        Me.name = name
    '        Me.location = location
    '    End Sub
    '    Public Sub GetUserDetails()
    '        Console.WriteLine("Name: {0}", name)
    '        Console.WriteLine("Location: ", location)
    '        ' Passing a class instance to the method using this
    '        Console.WriteLine("Marks: {0}", Exams.GetPercentage(Me)
    '    End Sub
    'End Class

    'Class Exams
    '    Public Shared Function GetPercentage(ByVal u As User) As Double
    '        Dim i As Double = (CDbl(470) / 600) * 100
    '        Return i
    '    End Function
    'End Class

    'Sub Main()
    '    Dim u As User = New User("Thoang Tran", "VietNam")
    '    u.GetUserDetails()
    '    Console.WriteLine("Press Enter Key to Exit..")
    '    Console.ReadLine()
    'End Sub


    'Const
    Sub Main()
        ' Constant variables
        Const name As String = "Thoang Tran"
        Const location As String = "Viet Nam"
        Const age As Integer = 23
        Console.WriteLine("Name: {0}", name)
        Console.WriteLine("Location: {0}", location)
        Console.WriteLine("Age: {0}", age)
        Console.WriteLine("Press Enter Key to Exit..")
        Console.ReadLine()
    End Sub
End Module

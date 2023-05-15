Imports System.Text

Module Module3
    'Join
    'Sub main()
    '    Dim sArr As String() = {"Welcome", "to", "Rikai"}
    '    Console.WriteLine("Join with Hypen: {0}", String.Join("-", sArr))
    '    Console.WriteLine("Press enter key to exit..")
    '    Console.ReadLine()
    'End Sub

    'IndexOf
    'Sub Main()
    '    Dim name As String = "Thoang Tran"
    '    Console.WriteLine("Character s Index Position: {0}", name.IndexOf("n"))
    '    Console.WriteLine("Ignore Case: {0}", name.IndexOf("n", StringComparison.OrdinalIgnoreCase))
    '    Console.WriteLine("Change Search Start Position: {0}", name.IndexOf("n", 5))
    '    Console.WriteLine("Press Enter Key to Exit..")
    '    Console.ReadLine()
    'End Sub
    Sub Main()
        Dim sb As StringBuilder = New StringBuilder("Thoang")
        sb.Append(", Tran")
        sb.Append(", Duy")
        sb.AppendLine()
        sb.Append("Welcome to Rikai")
        Console.WriteLine(sb)
        Dim sb1 As StringBuilder = New StringBuilder("Welcome World")
        sb1.Insert(8, "to Rikai ")
        Console.WriteLine(sb1)
        Dim sb2 As StringBuilder = New StringBuilder("Welcome to Rikai")
        sb2.Remove(8, 3)
        Dim sb3 As StringBuilder = New StringBuilder("Welcome to Rikai World")
        sb3.Replace("Rikai", "VB.NET")
        Console.WriteLine(sb3)
        Console.ReadLine()
    End Sub
End Module

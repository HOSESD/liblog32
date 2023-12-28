Public Class Class1
    Dim x As Int64
    Dim y As Int32
    Dim z As Int16
    Dim customvar1 As String
    Dim customvar2 As String
    Dim customvar3 As String
    Public Sub Main()
        'the worlds most useless library
        Console.WriteLine("LibLog32: Loading liblog32")
        Console.WriteLine("Setting values...")
        x = 0
        y = 0
        z = 0
        customvar1 = "string1"
        customvar2 = "string2"
        customvar3 = "string3"
        Console.WriteLine("Init done!")
    End Sub
    Sub LogValues()
        Console.WriteLine(x, y, z, customvar1, customvar2, customvar3)
    End Sub
End Class

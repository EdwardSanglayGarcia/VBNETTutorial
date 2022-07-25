
Public Class Parent
    Public sampleVariable As String
    Public Sub UseSampleVariable()
        Console.WriteLine(sampleVariable)
    End Sub

    Public Overridable Sub SaySomething()
        Console.WriteLine("This is the default")
    End Sub
End Class

Public Class Child : Inherits Parent
    Public Overrides Sub SaySomething()
        Console.WriteLine("This is a child overridden")
    End Sub
End Class
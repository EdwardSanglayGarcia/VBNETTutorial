
Public Class Parent
    Public sampleVariable As String
    Public Sub UseSampleVariable()
        Console.WriteLine(sampleVariable)
    End Sub
End Class

Public Class Child : Inherits Parent

End Class
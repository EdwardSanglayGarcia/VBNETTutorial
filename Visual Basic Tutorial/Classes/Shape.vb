Public Class Shape
    Private nameOfShape As String

    Public Sub New(NameOfString As String)
        Me.nameOfShape = NameOfString
    End Sub

    Public Sub TellMyName()
        Console.WriteLine(nameOfShape)
    End Sub

End Class

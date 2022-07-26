Public Class ClientPhones
    Private FirstPhone As String
    Private SecondPhone As String
    Private ThirdPhone As String

    Public Sub setFirstPhone(value As String)
        FirstPhone = value
    End Sub

    Public Sub setSecondPhone(value As String)
        SecondPhone = value
    End Sub

    Public Sub setThirdPhone(value As String)
        ThirdPhone = value
    End Sub

    Public Function getFirstPhone() As String
        Return FirstPhone
    End Function

    Public Function getSecondPhone() As String
        Return SecondPhone
    End Function

    Public Function getThirdPhone() As String
        Return ThirdPhone
    End Function


End Class

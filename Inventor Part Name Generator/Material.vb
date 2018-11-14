Public Class Material
    Private Property _Name As String
    Private Property _ShortName As String
    Public Sub New(ByVal MaterialName As String, ByVal ShortenedName As String)
        _Name = MaterialName
        _ShortName = ShortenedName
    End Sub
    Public Function Name() As String
        Return _Name
    End Function
    Public Function ShortName() As String
        Return _ShortName
    End Function
End Class

Public Class Sizetype
    Private Property _Type As String
    Private Property _Domain As String
    Public Sub New(ByVal Type As String, ByVal Domain As String)
        _Type = Type
        _Domain = Domain
    End Sub
    Public Function Type() As String
        Return _Type
    End Function
    Public Function Domain() As String
        Return _Domain
    End Function
End Class

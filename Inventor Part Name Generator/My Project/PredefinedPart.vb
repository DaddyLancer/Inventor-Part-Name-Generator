Public Class PredefinedPart
    Public Property _Material As String
    Public Property _ClassType As String
    Public Property _ClassID As String
    Public Property _Manufacturer As String
    Public Property _Dimension As String
    Public Property _PartName As String
    Public Property _FormatString As String
    Private Property _NickName As String

    Public Sub New(ByVal NickName As String, ByVal Optional Name As String = Nothing, ByVal Optional Material As String = Nothing, ByVal Optional ClassType As String = Nothing, ByVal Optional ClassID As String = Nothing, ByVal Optional Manufacturer As String = Nothing, ByVal Optional Dimension As String = Nothing)
        _NickName = NickName
        _Material = Material
        _ClassID = ClassID
        _ClassType = ClassType
        _Manufacturer = Manufacturer
        _Dimension = Dimension
        _PartName = Name
    End Sub
End Class

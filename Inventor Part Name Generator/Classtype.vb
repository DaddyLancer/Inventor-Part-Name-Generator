Public Class Classtype

    Private Property _Name As String
    Public Property _IDs As New List(Of Integer)

    Public Sub New(ByVal ClassName As String)
        _Name = ClassName
    End Sub

    Public Function Name() As String
        Return _Name
    End Function
End Class

Public Class CSize
    Private Property _Value As Double
    Private Property _Unit As String
    Public Sub New(ByVal Value As Double, ByVal Optional Unit As String = "")
        _Value = Value
        _Unit = Unit
    End Sub
    Public Function Value() As Double
        Return _Value
    End Function
    Public Function Unit() As String
        Return _Unit
    End Function

End Class

Public Class Manufacturer
    Private Property _Name As String
    Public Sub New(ByVal ManufacturerName As String)
        _Name = ManufacturerName
    End Sub
    Public Function Name() As String
        Try
            Return _Name
        Catch ex As Exception
            Debug.WriteLine("Error >> {0}", ex.ToString)
        End Try
    End Function

End Class

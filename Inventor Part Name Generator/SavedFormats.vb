Public Class SavedFormats

    Public Property FormatList As List(Of CustomFormat)
    Public ReadOnly Property FormatCount As Integer

    Public Sub New()
        FormatList = New List(Of CustomFormat)
    End Sub

    Public Function Add(ByVal NewFormat As CustomFormat) As Boolean

    End Function

    Public Function Remove(ByVal FormatName As String) As Boolean
        Try
            FormatList.Remove(Find(FormatName))
        Catch ex As Exception

        End Try
    End Function

    Public Function Find(ByVal FormatName As String) As CustomFormat
        Return FormatList.Find(Function(p) p.Name = FormatName)
    End Function
End Class

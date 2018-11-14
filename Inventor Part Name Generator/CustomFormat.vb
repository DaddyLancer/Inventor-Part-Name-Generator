Public Class CustomFormat

    Public Property Name As String
    Public Property FormatString As String
    Public ReadOnly Property CreatedDate As String

    Public Sub New(ByVal NameOfFormat As String, ByVal Formatting As String, ByVal Optional CreationDate As String = "Today")
        Name = NameOfFormat
        FormatString = Formatting
        If CreationDate = "Today" Then
            CreatedDate = Date.Now.ToShortDateString
        End If
    End Sub
End Class

Public Class frmFormattings
    Private Sub frmFormattings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshListings()
        lstvFormats.Items.Item(0).Selected = True
    End Sub

    Private Sub lstvFormats_ItemActivate(sender As Object, e As EventArgs) Handles lstvFormats.ItemActivate
        btnClear.Text = lstvFormats.SelectedItems.ToString
    End Sub

    Private Sub lstvFormats_ColumnWidthChanged(sender As Object, e As ColumnWidthChangedEventArgs) Handles lstvFormats.ColumnWidthChanged
        If Not lstvFormats.Columns(2).Width = 75 Then
            lstvFormats.Columns(2).Width = 75
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        If MsgBox("Clicking YES will delete ALL saved formats." & vbCrLf & "Do you want to proceed?", MsgBoxStyle.YesNo, "Delete all custom formats?") = MsgBoxResult.Yes Then

        End If


    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim SelFormat As String = lstvFormats.SelectedItems.Item(0).Text
        Dim FoundFormat As CustomFormat

        ' FoundFormat = frmGenerator.Formats.Find(Function(p) p.Name = SelFormat)
        'frmGenerator.Formats.Remove(FoundFormat)
        RefreshListings()
        frmGenerator.RefreshListings()

    End Sub

    Public Sub RefreshListings()
        lstvFormats.Items.Clear()

        '  For i = 0 To frmGenerator.Formats.Count - 1
        ' Dim itmStr(3) As String
        'Dim itm As ListViewItem
        'itmStr(0) = frmGenerator.Formats(i).Name
        'itmStr(1) = frmGenerator.Formats(i).FormatString
        'itmStr(2) = frmGenerator.Formats(i).CreatedDate
        'itm = New ListViewItem(itmStr)
        'lstvFormats.Items.Add(itm)
        'Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class

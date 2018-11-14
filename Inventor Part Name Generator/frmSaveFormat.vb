Public Class frmSaveFormat
    Public FormatName As String
    'Dim ExistingNames As List(Of frmGenerator.CFormat)
    ' Dim Formats As List(Of CustomFormat) = frmGenerator.Formats

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        FormatName = txtName.Text
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub


    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        If String.IsNullOrWhiteSpace(txtName.Text) Then
            btnSave.Enabled = False
        Else
            '          For i = 0 To Formats.Count - 1
            '         If txtName.Text.ToLower.Trim = Formats(i).Name.ToLower Then
            '        btnSave.Enabled = False
            '       lblError.Show()
            '      Exit For
            '     Else
            '    lblError.Hide()
            '   btnSave.Enabled = True
            'End If
            '   Next
        End If
    End Sub

    Private Sub frmSaveFormat_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblError.Hide()
    End Sub

End Class
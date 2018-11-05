Public Class frmSaveFormat
    Public FormatName As String
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
            btnSave.Enabled = True
        End If
    End Sub
End Class
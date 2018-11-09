Public Class frmPreferences
    Dim Now As DateTime

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Now = DateTime.Now


        stripTime.Text = Now.ToString(My.Settings.TimeFormat)

    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        My.Settings.DatefieldVisible = chkDatefield.Checked
        My.Settings.ExtrafieldVisible = chkExtrafield.Checked
        My.Settings.RestoreOnStartup = chkRestore.Checked
        My.Settings.LogEntries = chkLog.Checked

        If rbtn12h.Checked = True Then
            My.Settings.TimeFormat = "t"
        ElseIf rbtn24h.Checked = True Then
            My.Settings.TimeFormat = "HH:mm"
        End If

    End Sub

    Private Sub frmPreferences_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chkDatefield.Checked = My.Settings.DatefieldVisible
        chkExtrafield.Checked = My.Settings.ExtrafieldVisible
        chkLog.Checked = My.Settings.LogEntries
        chkRestore.Checked = My.Settings.RestoreOnStartup

        Select Case My.Settings.TimeFormat
            Case "t"
                rbtn12h.Checked = True
            Case "HH:mm"
                rbtn24h.Checked = True
        End Select

    End Sub
End Class
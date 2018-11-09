Public Class frmHotkeys
    Dim FunctionIndex, HotKeyIndex As Integer
    Dim FirstKey As Keys
    Dim depressedKeys As New List(Of Keys)
    Dim FinalKey As Keys
    Dim isPressing As Boolean = False
    Dim HasShift, HasControl, HasAlt As Boolean


    Private Sub frmHotkeys_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FunctionIndex = 0
        HotKeyIndex = 0
    End Sub

    '   Private Sub lstHotkey_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstHotkey.SelectedIndexChanged
    '   If lstHotkey.SelectedIndex <> lstFunction.SelectedIndex Then
    '           lstFunction.SelectedIndex = lstHotkey.SelectedIndex
    '   End If

    '    If lstHotkey.SelectedItem <> "No hotkey set" Then
    '    If lstHotkey.SelectedIndex <> 6 AndAlso lstHotkey.SelectedIndex <> 7 Then
    '    Dim KeyC As New KeysConverter
    '   Dim HotkeySet As New List(Of Keys)
    '   Dim HotkeySetStr As List(Of String) = Split(lstHotkey.SelectedItem, " + ").ToList
    '   For Each entry In HotkeySetStr
    '   If entry = "CTRL" Then
    '                       HotkeySet.Add(Keys.Control)
    '   ElseIf entry = "SHIFT" Then
    '                       HotkeySet.Add(Keys.Shift)
    '   ElseIf entry = "ALT" Then
    '                       HotkeySet.Add(Keys.Alt)
    '   Else
    '   Dim o As Object = KeyC.ConvertFromString(entry)
    '                       HotkeySet.Add(CType(o, Keys))
    '   End If
    '   Next
    '   'HotkeySet = Split(lstHotkey.SelectedItem, " + ").ToList
    '   End If
    '   End If
    '   End Sub

    Private Sub lstFunction_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstFunction.SelectedIndexChanged
        If lstFunction.SelectedIndex <> lstHotkey.SelectedIndex Then
            lstHotkey.SelectedIndex = lstFunction.SelectedIndex
        End If

    End Sub

    Private Sub txtFocused_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFocused.KeyDown
        FirstKey = e.KeyCode

        HasControl = e.Control
        HasShift = e.Shift
        HasAlt = e.Alt

        If (e.KeyCode >= Keys.A AndAlso e.KeyCode <= Keys.Z) Or (e.KeyCode >= Keys.D0 AndAlso e.KeyCode <= Keys.D9) Or (e.KeyCode >= Keys.F1 AndAlso e.KeyCode <= Keys.F12) Or e.KeyCode = 192 Or e.KeyCode = 221 Or e.KeyCode = 222 Then
            'If Not depressedKeys.Contains(e.KeyCode) Then depressedKeys.Add(e.KeyCode)
            Dim DetectedKeys As New List(Of Keys)

            If HasControl Then DetectedKeys.Add(Keys.Control)
            If HasShift Then DetectedKeys.Add(Keys.Shift)
            If HasAlt Then DetectedKeys.Add(Keys.Alt)
            DetectedKeys.Add(e.KeyCode)
            Dim KeyString As String = ""
            For Each PressedKey In DetectedKeys
                Dim strTmp As String
                If PressedKey = Keys.Oem6 Then
                    strTmp = "Å"
                    'cmbKey.SelectedItem = "Å"
                ElseIf PressedKey = Keys.Oem7 Then
                    strTmp = "Ø"
                    'cmbKey.SelectedItem = "Ø"
                ElseIf PressedKey = Keys.Oemtilde Then
                    strTmp = "Æ"
                    'cmbKey.SelectedItem = "Æ"
                Else
                    strTmp = PressedKey.ToString
                    Try
                        cmbKey.SelectedItem = PressedKey.ToString
                    Catch ex As Exception
                    End Try
                End If
                KeyString = KeyString & strTmp & "+"
            Next
            txtFocused.Text = KeyString.Substring(0, KeyString.Length() - 1)
            cmbKey.SelectedItem = txtFocused.Text.Substring(KeyString.Length - 2, 1)
            CTRL.Checked = HasControl
            ALT.Checked = HasAlt
            SHIFT.Checked = HasShift
        End If

    End Sub

    Private Sub txtFocused_KeyUp(sender As Object, e As KeyEventArgs) Handles txtFocused.KeyUp
        If e.Control Then HasControl = False
        If e.Shift Then HasShift = False
        If e.Alt Then HasAlt = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtFocused.Text = "Click here for auto-hotkey input."
        Timer1.Enabled = False
    End Sub

    Private Sub txtFocused_GotFocus(sender As Object, e As EventArgs) Handles txtFocused.GotFocus
        txtFocused.Text = "Enter hotkey now."
    End Sub

    Private Sub txtFocused_LostFocus(sender As Object, e As EventArgs) Handles txtFocused.LostFocus
        Timer1.Enabled = True
    End Sub

End Class
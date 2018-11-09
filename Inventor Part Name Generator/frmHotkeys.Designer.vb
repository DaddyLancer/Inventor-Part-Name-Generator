<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotkeys
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.txtFocused = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.btnSet = New System.Windows.Forms.Button()
        Me.cmbKey = New System.Windows.Forms.ComboBox()
        Me.SHIFT = New System.Windows.Forms.CheckBox()
        Me.ALT = New System.Windows.Forms.CheckBox()
        Me.CTRL = New System.Windows.Forms.CheckBox()
        Me.lstHotkey = New System.Windows.Forms.ListBox()
        Me.lstFunction = New System.Windows.Forms.ListBox()
        Me.Apply = New System.Windows.Forms.Button()
        Me.Done = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtFocused)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnClear)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtDescription)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnSet)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbKey)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SHIFT)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ALT)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CTRL)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lstHotkey)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lstFunction)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Apply)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Done)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Cancel)
        Me.SplitContainer1.Size = New System.Drawing.Size(441, 279)
        Me.SplitContainer1.SplitterDistance = 245
        Me.SplitContainer1.TabIndex = 0
        '
        'txtFocused
        '
        Me.txtFocused.BackColor = System.Drawing.Color.DimGray
        Me.txtFocused.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFocused.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtFocused.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFocused.ForeColor = System.Drawing.Color.PaleTurquoise
        Me.txtFocused.Location = New System.Drawing.Point(260, 74)
        Me.txtFocused.MaxLength = 0
        Me.txtFocused.Multiline = True
        Me.txtFocused.Name = "txtFocused"
        Me.txtFocused.ReadOnly = True
        Me.txtFocused.Size = New System.Drawing.Size(177, 45)
        Me.txtFocused.TabIndex = 1
        Me.txtFocused.Text = "Click here for auto-hotkey input."
        Me.txtFocused.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(381, 41)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(56, 27)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.SystemColors.Control
        Me.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescription.Enabled = False
        Me.txtDescription.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.ForeColor = System.Drawing.Color.DimGray
        Me.txtDescription.Location = New System.Drawing.Point(259, 125)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(177, 117)
        Me.txtDescription.TabIndex = 0
        Me.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSet
        '
        Me.btnSet.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSet.Location = New System.Drawing.Point(321, 41)
        Me.btnSet.Name = "btnSet"
        Me.btnSet.Size = New System.Drawing.Size(56, 27)
        Me.btnSet.TabIndex = 7
        Me.btnSet.Text = "Set"
        Me.btnSet.UseVisualStyleBackColor = True
        '
        'cmbKey
        '
        Me.cmbKey.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbKey.FormattingEnabled = True
        Me.cmbKey.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "Æ", "Ø", "Å", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12"})
        Me.cmbKey.Location = New System.Drawing.Point(259, 41)
        Me.cmbKey.Name = "cmbKey"
        Me.cmbKey.Size = New System.Drawing.Size(54, 27)
        Me.cmbKey.TabIndex = 5
        Me.cmbKey.Text = "F12"
        '
        'SHIFT
        '
        Me.SHIFT.AutoSize = True
        Me.SHIFT.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SHIFT.Location = New System.Drawing.Point(378, 12)
        Me.SHIFT.Name = "SHIFT"
        Me.SHIFT.Size = New System.Drawing.Size(64, 23)
        Me.SHIFT.TabIndex = 4
        Me.SHIFT.Text = "SHIFT"
        Me.SHIFT.UseVisualStyleBackColor = True
        '
        'ALT
        '
        Me.ALT.AutoSize = True
        Me.ALT.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALT.Location = New System.Drawing.Point(326, 12)
        Me.ALT.Name = "ALT"
        Me.ALT.Size = New System.Drawing.Size(51, 23)
        Me.ALT.TabIndex = 3
        Me.ALT.Text = "ALT"
        Me.ALT.UseVisualStyleBackColor = True
        '
        'CTRL
        '
        Me.CTRL.AutoSize = True
        Me.CTRL.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CTRL.Location = New System.Drawing.Point(260, 12)
        Me.CTRL.Name = "CTRL"
        Me.CTRL.Size = New System.Drawing.Size(61, 23)
        Me.CTRL.TabIndex = 2
        Me.CTRL.Text = "CTRL"
        Me.CTRL.UseVisualStyleBackColor = True
        '
        'lstHotkey
        '
        Me.lstHotkey.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstHotkey.Dock = System.Windows.Forms.DockStyle.Left
        Me.lstHotkey.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstHotkey.FormattingEnabled = True
        Me.lstHotkey.ItemHeight = 16
        Me.lstHotkey.Items.AddRange(New Object() {"No hotkey set", "No hotkey set", "ALT+F", "ALT+S", "ALT+L", "ALT+H", "ALT+O", "ALT+F4", "—————————————", "F1", "F2", "F3", "No hotkey set", "No hotkey set", "No hotkey set"})
        Me.lstHotkey.Location = New System.Drawing.Point(133, 0)
        Me.lstHotkey.Name = "lstHotkey"
        Me.lstHotkey.Size = New System.Drawing.Size(120, 245)
        Me.lstHotkey.TabIndex = 1
        '
        'lstFunction
        '
        Me.lstFunction.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstFunction.Dock = System.Windows.Forms.DockStyle.Left
        Me.lstFunction.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstFunction.FormattingEnabled = True
        Me.lstFunction.ItemHeight = 16
        Me.lstFunction.Items.AddRange(New Object() {"File", "-- Manage", "---- Formats", "---- Saved Standards", "---- Generation Logs", "---- Hotkeys", "---- Preferences", "-- Exit", "————————————————", "Help", "-- Part Informations", "-- Formatting", "-- Updates", "-- Feedback", "-- About"})
        Me.lstFunction.Location = New System.Drawing.Point(0, 0)
        Me.lstFunction.Name = "lstFunction"
        Me.lstFunction.Size = New System.Drawing.Size(133, 245)
        Me.lstFunction.TabIndex = 0
        '
        'Apply
        '
        Me.Apply.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Apply.Location = New System.Drawing.Point(200, 3)
        Me.Apply.Name = "Apply"
        Me.Apply.Size = New System.Drawing.Size(75, 23)
        Me.Apply.TabIndex = 2
        Me.Apply.Text = "Apply"
        Me.Apply.UseVisualStyleBackColor = True
        '
        'Done
        '
        Me.Done.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Done.Location = New System.Drawing.Point(281, 3)
        Me.Done.Name = "Done"
        Me.Done.Size = New System.Drawing.Size(75, 23)
        Me.Done.TabIndex = 1
        Me.Done.Text = "Done"
        Me.Done.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(362, 3)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(74, 23)
        Me.Cancel.TabIndex = 0
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 3000
        '
        'frmHotkeys
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(441, 279)
        Me.ControlBox = False
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHotkeys"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Shortcuts"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents lstHotkey As ListBox
    Friend WithEvents lstFunction As ListBox
    Friend WithEvents Apply As Button
    Friend WithEvents Done As Button
    Friend WithEvents Cancel As Button
    Friend WithEvents cmbKey As ComboBox
    Friend WithEvents SHIFT As CheckBox
    Friend WithEvents ALT As CheckBox
    Friend WithEvents CTRL As CheckBox
    Friend WithEvents btnSet As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents txtFocused As TextBox
    Friend WithEvents Timer1 As Timer
End Class

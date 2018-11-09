<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreferences
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
        Me.rbnDateDMY14 = New System.Windows.Forms.RadioButton()
        Me.rbnDateDMY34 = New System.Windows.Forms.RadioButton()
        Me.rbnDateDMY24 = New System.Windows.Forms.RadioButton()
        Me.rbtn12h = New System.Windows.Forms.RadioButton()
        Me.rbtn24h = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.rbnDateDMY22 = New System.Windows.Forms.RadioButton()
        Me.rbnDateDMY32 = New System.Windows.Forms.RadioButton()
        Me.rbnDateDMY12 = New System.Windows.Forms.RadioButton()
        Me.rbnDateDMY44 = New System.Windows.Forms.RadioButton()
        Me.rbnDateDMY42 = New System.Windows.Forms.RadioButton()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stripDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stripTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.chkDatefield = New System.Windows.Forms.CheckBox()
        Me.chkExtrafield = New System.Windows.Forms.CheckBox()
        Me.chkRestore = New System.Windows.Forms.CheckBox()
        Me.chkLog = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'rbnDateDMY14
        '
        Me.rbnDateDMY14.AutoSize = True
        Me.rbnDateDMY14.Checked = True
        Me.rbnDateDMY14.Location = New System.Drawing.Point(3, 3)
        Me.rbnDateDMY14.Name = "rbnDateDMY14"
        Me.rbnDateDMY14.Size = New System.Drawing.Size(97, 17)
        Me.rbnDateDMY14.TabIndex = 1
        Me.rbnDateDMY14.TabStop = True
        Me.rbnDateDMY14.Text = "DD/MM/YYYY"
        Me.rbnDateDMY14.UseVisualStyleBackColor = True
        '
        'rbnDateDMY34
        '
        Me.rbnDateDMY34.AutoSize = True
        Me.rbnDateDMY34.Location = New System.Drawing.Point(133, 3)
        Me.rbnDateDMY34.Name = "rbnDateDMY34"
        Me.rbnDateDMY34.Size = New System.Drawing.Size(97, 17)
        Me.rbnDateDMY34.TabIndex = 2
        Me.rbnDateDMY34.Text = "MM/DD/YYYY"
        Me.rbnDateDMY34.UseVisualStyleBackColor = True
        '
        'rbnDateDMY24
        '
        Me.rbnDateDMY24.AutoSize = True
        Me.rbnDateDMY24.Location = New System.Drawing.Point(3, 49)
        Me.rbnDateDMY24.Name = "rbnDateDMY24"
        Me.rbnDateDMY24.Size = New System.Drawing.Size(95, 17)
        Me.rbnDateDMY24.TabIndex = 3
        Me.rbnDateDMY24.Text = "DD/MM-YYYY"
        Me.rbnDateDMY24.UseVisualStyleBackColor = True
        '
        'rbtn12h
        '
        Me.rbtn12h.AutoSize = True
        Me.rbtn12h.Checked = True
        Me.rbtn12h.Location = New System.Drawing.Point(3, 3)
        Me.rbtn12h.Name = "rbtn12h"
        Me.rbtn12h.Size = New System.Drawing.Size(66, 17)
        Me.rbtn12h.TabIndex = 5
        Me.rbtn12h.TabStop = True
        Me.rbtn12h.Text = "12 hours"
        Me.rbtn12h.UseVisualStyleBackColor = True
        '
        'rbtn24h
        '
        Me.rbtn24h.AutoSize = True
        Me.rbtn24h.Location = New System.Drawing.Point(133, 5)
        Me.rbtn24h.Name = "rbtn24h"
        Me.rbtn24h.Size = New System.Drawing.Size(66, 17)
        Me.rbtn24h.TabIndex = 6
        Me.rbtn24h.Text = "24 hours"
        Me.rbtn24h.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.SplitContainer1)
        Me.GroupBox1.Location = New System.Drawing.Point(216, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(237, 142)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Time and Date format"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 16)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.rbtn12h)
        Me.SplitContainer1.Panel1.Controls.Add(Me.rbtn24h)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.rbnDateDMY22)
        Me.SplitContainer1.Panel2.Controls.Add(Me.rbnDateDMY14)
        Me.SplitContainer1.Panel2.Controls.Add(Me.rbnDateDMY32)
        Me.SplitContainer1.Panel2.Controls.Add(Me.rbnDateDMY34)
        Me.SplitContainer1.Panel2.Controls.Add(Me.rbnDateDMY12)
        Me.SplitContainer1.Panel2.Controls.Add(Me.rbnDateDMY44)
        Me.SplitContainer1.Panel2.Controls.Add(Me.rbnDateDMY42)
        Me.SplitContainer1.Panel2.Controls.Add(Me.rbnDateDMY24)
        Me.SplitContainer1.Size = New System.Drawing.Size(231, 123)
        Me.SplitContainer1.SplitterDistance = 25
        Me.SplitContainer1.TabIndex = 0
        '
        'rbnDateDMY22
        '
        Me.rbnDateDMY22.AutoSize = True
        Me.rbnDateDMY22.Location = New System.Drawing.Point(3, 72)
        Me.rbnDateDMY22.Name = "rbnDateDMY22"
        Me.rbnDateDMY22.Size = New System.Drawing.Size(81, 17)
        Me.rbnDateDMY22.TabIndex = 8
        Me.rbnDateDMY22.Text = "DD/MM-YY"
        Me.rbnDateDMY22.UseVisualStyleBackColor = True
        '
        'rbnDateDMY32
        '
        Me.rbnDateDMY32.AutoSize = True
        Me.rbnDateDMY32.Location = New System.Drawing.Point(133, 26)
        Me.rbnDateDMY32.Name = "rbnDateDMY32"
        Me.rbnDateDMY32.Size = New System.Drawing.Size(83, 17)
        Me.rbnDateDMY32.TabIndex = 5
        Me.rbnDateDMY32.Text = "MM/DD/YY"
        Me.rbnDateDMY32.UseVisualStyleBackColor = True
        '
        'rbnDateDMY12
        '
        Me.rbnDateDMY12.AutoSize = True
        Me.rbnDateDMY12.Location = New System.Drawing.Point(3, 26)
        Me.rbnDateDMY12.Name = "rbnDateDMY12"
        Me.rbnDateDMY12.Size = New System.Drawing.Size(83, 17)
        Me.rbnDateDMY12.TabIndex = 4
        Me.rbnDateDMY12.Text = "DD/MM/YY"
        Me.rbnDateDMY12.UseVisualStyleBackColor = True
        '
        'rbnDateDMY44
        '
        Me.rbnDateDMY44.AutoSize = True
        Me.rbnDateDMY44.Location = New System.Drawing.Point(133, 49)
        Me.rbnDateDMY44.Name = "rbnDateDMY44"
        Me.rbnDateDMY44.Size = New System.Drawing.Size(95, 17)
        Me.rbnDateDMY44.TabIndex = 6
        Me.rbnDateDMY44.Text = "MM/DD-YYYY"
        Me.rbnDateDMY44.UseVisualStyleBackColor = True
        '
        'rbnDateDMY42
        '
        Me.rbnDateDMY42.AutoSize = True
        Me.rbnDateDMY42.Location = New System.Drawing.Point(133, 73)
        Me.rbnDateDMY42.Name = "rbnDateDMY42"
        Me.rbnDateDMY42.Size = New System.Drawing.Size(81, 17)
        Me.rbnDateDMY42.TabIndex = 7
        Me.rbnDateDMY42.Text = "MM/DD-YY"
        Me.rbnDateDMY42.UseVisualStyleBackColor = True
        '
        'btnApply
        '
        Me.btnApply.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnApply.Location = New System.Drawing.Point(216, 157)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(75, 23)
        Me.btnApply.TabIndex = 8
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'btnDone
        '
        Me.btnDone.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDone.Location = New System.Drawing.Point(297, 157)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(75, 23)
        Me.btnDone.TabIndex = 9
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(378, 157)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.stripDate, Me.ToolStripStatusLabel2, Me.stripTime})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 188)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(465, 22)
        Me.StatusStrip1.TabIndex = 11
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(75, 17)
        Me.ToolStripStatusLabel1.Text = "Date Format:"
        '
        'stripDate
        '
        Me.stripDate.Name = "stripDate"
        Me.stripDate.Size = New System.Drawing.Size(65, 17)
        Me.stripDate.Text = "11/08/2018"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(74, 17)
        Me.ToolStripStatusLabel2.Text = "Time Fomat:"
        '
        'stripTime
        '
        Me.stripTime.Name = "stripTime"
        Me.stripTime.Size = New System.Drawing.Size(49, 17)
        Me.stripTime.Text = "5:15 PM"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'chkDatefield
        '
        Me.chkDatefield.AutoSize = True
        Me.chkDatefield.Checked = True
        Me.chkDatefield.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDatefield.Location = New System.Drawing.Point(6, 19)
        Me.chkDatefield.Name = "chkDatefield"
        Me.chkDatefield.Size = New System.Drawing.Size(103, 17)
        Me.chkDatefield.TabIndex = 12
        Me.chkDatefield.Text = "Date field visible"
        Me.chkDatefield.UseVisualStyleBackColor = True
        '
        'chkExtrafield
        '
        Me.chkExtrafield.AutoSize = True
        Me.chkExtrafield.Checked = True
        Me.chkExtrafield.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkExtrafield.Location = New System.Drawing.Point(6, 42)
        Me.chkExtrafield.Name = "chkExtrafield"
        Me.chkExtrafield.Size = New System.Drawing.Size(104, 17)
        Me.chkExtrafield.TabIndex = 13
        Me.chkExtrafield.Text = "Extra field visible"
        Me.chkExtrafield.UseVisualStyleBackColor = True
        '
        'chkRestore
        '
        Me.chkRestore.AutoSize = True
        Me.chkRestore.Checked = True
        Me.chkRestore.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRestore.Location = New System.Drawing.Point(6, 65)
        Me.chkRestore.Name = "chkRestore"
        Me.chkRestore.Size = New System.Drawing.Size(158, 17)
        Me.chkRestore.TabIndex = 14
        Me.chkRestore.Text = "Restore last entry on startup"
        Me.chkRestore.UseVisualStyleBackColor = True
        '
        'chkLog
        '
        Me.chkLog.AutoSize = True
        Me.chkLog.Checked = True
        Me.chkLog.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkLog.Location = New System.Drawing.Point(6, 88)
        Me.chkLog.Name = "chkLog"
        Me.chkLog.Size = New System.Drawing.Size(129, 17)
        Me.chkLog.TabIndex = 15
        Me.chkLog.Text = "Log generated entries"
        Me.chkLog.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.chkDatefield)
        Me.GroupBox2.Controls.Add(Me.chkLog)
        Me.GroupBox2.Controls.Add(Me.chkExtrafield)
        Me.GroupBox2.Controls.Add(Me.chkRestore)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(198, 168)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "General options"
        '
        'frmPreferences
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(465, 210)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPreferences"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Preferences"
        Me.GroupBox1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rbnDateDMY14 As RadioButton
    Friend WithEvents rbnDateDMY34 As RadioButton
    Friend WithEvents rbnDateDMY24 As RadioButton
    Friend WithEvents rbtn12h As RadioButton
    Friend WithEvents rbtn24h As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents rbnDateDMY12 As RadioButton
    Friend WithEvents rbnDateDMY44 As RadioButton
    Friend WithEvents rbnDateDMY32 As RadioButton
    Friend WithEvents rbnDateDMY22 As RadioButton
    Friend WithEvents rbnDateDMY42 As RadioButton
    Friend WithEvents btnApply As Button
    Friend WithEvents btnDone As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents stripDate As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents stripTime As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents chkDatefield As CheckBox
    Friend WithEvents chkExtrafield As CheckBox
    Friend WithEvents chkRestore As CheckBox
    Friend WithEvents chkLog As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
End Class

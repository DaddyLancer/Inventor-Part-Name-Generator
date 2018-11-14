<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SourcePanel
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Entries = New System.Windows.Forms.CheckedListBox()
        Me.EntryCount = New System.Windows.Forms.Label()
        Me.NameInput = New System.Windows.Forms.TextBox()
        Me.SourceLabel = New System.Windows.Forms.Label()
        Me.RemoveAll = New System.Windows.Forms.Button()
        Me.AddToList = New System.Windows.Forms.Button()
        Me.RemoveSelected = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.NameInput)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SourceLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.RemoveAll)
        Me.SplitContainer1.Panel2.Controls.Add(Me.AddToList)
        Me.SplitContainer1.Panel2.Controls.Add(Me.RemoveSelected)
        Me.SplitContainer1.Size = New System.Drawing.Size(439, 200)
        Me.SplitContainer1.SplitterDistance = 190
        Me.SplitContainer1.TabIndex = 0
        '
        'Entries
        '
        Me.Entries.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Entries.FormattingEnabled = True
        Me.Entries.Location = New System.Drawing.Point(0, 0)
        Me.Entries.Name = "Entries"
        Me.Entries.Size = New System.Drawing.Size(190, 179)
        Me.Entries.TabIndex = 0
        '
        'EntryCount
        '
        Me.EntryCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.EntryCount.AutoSize = True
        Me.EntryCount.Location = New System.Drawing.Point(3, 1)
        Me.EntryCount.Name = "EntryCount"
        Me.EntryCount.Size = New System.Drawing.Size(69, 13)
        Me.EntryCount.TabIndex = 1
        Me.EntryCount.Text = "Total Entries:"
        '
        'NameInput
        '
        Me.NameInput.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NameInput.Location = New System.Drawing.Point(6, 29)
        Me.NameInput.Name = "NameInput"
        Me.NameInput.Size = New System.Drawing.Size(164, 20)
        Me.NameInput.TabIndex = 4
        '
        'SourceLabel
        '
        Me.SourceLabel.AutoSize = True
        Me.SourceLabel.Location = New System.Drawing.Point(3, 13)
        Me.SourceLabel.Name = "SourceLabel"
        Me.SourceLabel.Size = New System.Drawing.Size(38, 13)
        Me.SourceLabel.TabIndex = 3
        Me.SourceLabel.Text = "Name:"
        '
        'RemoveAll
        '
        Me.RemoveAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RemoveAll.Location = New System.Drawing.Point(131, 174)
        Me.RemoveAll.Name = "RemoveAll"
        Me.RemoveAll.Size = New System.Drawing.Size(111, 23)
        Me.RemoveAll.TabIndex = 2
        Me.RemoveAll.Text = "Remove All"
        Me.RemoveAll.UseVisualStyleBackColor = True
        '
        'AddToList
        '
        Me.AddToList.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddToList.Image = Global.Inventor_Part_Name_Generator.My.Resources.Resources.Add_16x
        Me.AddToList.Location = New System.Drawing.Point(176, 27)
        Me.AddToList.Name = "AddToList"
        Me.AddToList.Size = New System.Drawing.Size(66, 23)
        Me.AddToList.TabIndex = 1
        Me.AddToList.Text = "Add"
        Me.AddToList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddToList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.AddToList.UseVisualStyleBackColor = True
        '
        'RemoveSelected
        '
        Me.RemoveSelected.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RemoveSelected.Location = New System.Drawing.Point(6, 174)
        Me.RemoveSelected.Name = "RemoveSelected"
        Me.RemoveSelected.Size = New System.Drawing.Size(111, 23)
        Me.RemoveSelected.TabIndex = 0
        Me.RemoveSelected.Text = "Remove Selected"
        Me.RemoveSelected.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer2.IsSplitterFixed = True
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.Entries)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.EntryCount)
        Me.SplitContainer2.Panel2MinSize = 15
        Me.SplitContainer2.Size = New System.Drawing.Size(190, 200)
        Me.SplitContainer2.SplitterDistance = 179
        Me.SplitContainer2.TabIndex = 0
        '
        'SourcePanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "SourcePanel"
        Me.Size = New System.Drawing.Size(439, 200)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Entries As CheckedListBox
    Friend WithEvents EntryCount As Label
    Friend WithEvents NameInput As TextBox
    Friend WithEvents SourceLabel As Label
    Friend WithEvents RemoveAll As Button
    Friend WithEvents AddToList As Button
    Friend WithEvents RemoveSelected As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents SplitContainer2 As SplitContainer
End Class

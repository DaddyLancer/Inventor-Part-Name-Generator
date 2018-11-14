<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFormattings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFormattings))
        Me.lstvFormats = New System.Windows.Forms.ListView()
        Me.ColumnName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnString = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstvFormats
        '
        Me.lstvFormats.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstvFormats.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnName, Me.ColumnString, Me.ColumnDate})
        Me.lstvFormats.FullRowSelect = True
        Me.lstvFormats.GridLines = True
        Me.lstvFormats.Location = New System.Drawing.Point(12, 103)
        Me.lstvFormats.MultiSelect = False
        Me.lstvFormats.Name = "lstvFormats"
        Me.lstvFormats.Size = New System.Drawing.Size(607, 335)
        Me.lstvFormats.TabIndex = 2
        Me.lstvFormats.UseCompatibleStateImageBehavior = False
        Me.lstvFormats.View = System.Windows.Forms.View.Details
        '
        'ColumnName
        '
        Me.ColumnName.Text = "Name"
        Me.ColumnName.Width = 110
        '
        'ColumnString
        '
        Me.ColumnString.Text = "Format String"
        Me.ColumnString.Width = 418
        '
        'ColumnDate
        '
        Me.ColumnDate.Text = "Date"
        Me.ColumnDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnDate.Width = 75
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.Image = Global.Inventor_Part_Name_Generator.My.Resources.Resources.Eraser_16x
        Me.btnDelete.Location = New System.Drawing.Point(524, 70)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(95, 23)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Delete Entry"
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClear.Image = Global.Inventor_Part_Name_Generator.My.Resources.Resources.DeleteTable_16x
        Me.btnClear.Location = New System.Drawing.Point(524, 12)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(95, 23)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Delete ALL"
        Me.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Image = Global.Inventor_Part_Name_Generator.My.Resources.Resources.Output_16x
        Me.btnExport.Location = New System.Drawing.Point(12, 41)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(95, 23)
        Me.btnExport.TabIndex = 5
        Me.btnExport.Text = "Export List"
        Me.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnImport
        '
        Me.btnImport.Image = Global.Inventor_Part_Name_Generator.My.Resources.Resources.Input_16x
        Me.btnImport.Location = New System.Drawing.Point(12, 12)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(95, 23)
        Me.btnImport.TabIndex = 6
        Me.btnImport.Text = "Import List"
        Me.btnImport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Image = Global.Inventor_Part_Name_Generator.My.Resources.Resources.Edit_16x
        Me.btnEdit.Location = New System.Drawing.Point(12, 70)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(95, 23)
        Me.btnEdit.TabIndex = 8
        Me.btnEdit.Text = "Edit format..."
        Me.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.Inventor_Part_Name_Generator.My.Resources.Resources.NewFile_16x
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(524, 41)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "New file"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmFormattings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.lstvFormats)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(647, 488)
        Me.Name = "frmFormattings"
        Me.Text = "List of formats"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstvFormats As ListView
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents ColumnName As ColumnHeader
    Friend WithEvents ColumnString As ColumnHeader
    Friend WithEvents ColumnDate As ColumnHeader
    Friend WithEvents btnExport As Button
    Friend WithEvents btnImport As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents Button1 As Button
End Class

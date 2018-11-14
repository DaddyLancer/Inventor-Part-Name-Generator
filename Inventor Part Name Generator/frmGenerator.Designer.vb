<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGenerator
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
        Me.components = New System.ComponentModel.Container()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFormat = New System.Windows.Forms.TextBox()
        Me.cmbMaterial = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbTypeNum = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbClass = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbManufacturer = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbSize = New System.Windows.Forms.ComboBox()
        Me.btnSaveFormat = New System.Windows.Forms.Button()
        Me.lstFormats = New System.Windows.Forms.ListBox()
        Me.lstParameters = New System.Windows.Forms.ListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbCustom = New System.Windows.Forms.GroupBox()
        Me.btnAddSize = New System.Windows.Forms.Button()
        Me.btnAddManufacturer = New System.Windows.Forms.Button()
        Me.btnAddClassID = New System.Windows.Forms.Button()
        Me.btnAddClass = New System.Windows.Forms.Button()
        Me.btnAddMaterial = New System.Windows.Forms.Button()
        Me.cmbPredefined = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnAddPredefined = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbExtra = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageSavedDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormatsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SavedStandardsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerationLogsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HotkeysToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreferencesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PartInformationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormattingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.UpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FeedbackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.chkAutomatic = New System.Windows.Forms.CheckBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.cmbCustom.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtOutput
        '
        Me.txtOutput.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOutput.Location = New System.Drawing.Point(294, 260)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(410, 20)
        Me.txtOutput.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(291, 244)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Output"
        '
        'txtFormat
        '
        Me.txtFormat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFormat.Location = New System.Drawing.Point(6, 19)
        Me.txtFormat.Name = "txtFormat"
        Me.txtFormat.Size = New System.Drawing.Size(284, 20)
        Me.txtFormat.TabIndex = 4
        Me.txtFormat.Text = "[%CLASS% %CLASSNUM%] - %NAME% (%MATERIAL%)"
        '
        'cmbMaterial
        '
        Me.cmbMaterial.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbMaterial.FormattingEnabled = True
        Me.cmbMaterial.Items.AddRange(New Object() {"N/A", "Aluminum", "Steel", "Stainless Steel", "Spring Steel", "Cast Iron"})
        Me.cmbMaterial.Location = New System.Drawing.Point(9, 124)
        Me.cmbMaterial.Name = "cmbMaterial"
        Me.cmbMaterial.Size = New System.Drawing.Size(234, 21)
        Me.cmbMaterial.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Material:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Class / Type Number:"
        '
        'cmbTypeNum
        '
        Me.cmbTypeNum.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbTypeNum.FormattingEnabled = True
        Me.cmbTypeNum.Items.AddRange(New Object() {"N/A", "471", "472", "6799"})
        Me.cmbTypeNum.Location = New System.Drawing.Point(9, 204)
        Me.cmbTypeNum.Name = "cmbTypeNum"
        Me.cmbTypeNum.Size = New System.Drawing.Size(234, 21)
        Me.cmbTypeNum.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Class / Type:"
        '
        'cmbClass
        '
        Me.cmbClass.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbClass.FormattingEnabled = True
        Me.cmbClass.Items.AddRange(New Object() {"N/A", "DIN", "ISO", "ANSI"})
        Me.cmbClass.Location = New System.Drawing.Point(9, 164)
        Me.cmbClass.Name = "cmbClass"
        Me.cmbClass.Size = New System.Drawing.Size(234, 21)
        Me.cmbClass.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Name:"
        '
        'txtName
        '
        Me.txtName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(9, 32)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(251, 22)
        Me.txtName.TabIndex = 13
        Me.txtName.Text = "Seeger Låsering"
        '
        'btnGenerate
        '
        Me.btnGenerate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenerate.Location = New System.Drawing.Point(584, 286)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(120, 34)
        Me.btnGenerate.TabIndex = 14
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 228)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Manufacturer:"
        '
        'cmbManufacturer
        '
        Me.cmbManufacturer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbManufacturer.FormattingEnabled = True
        Me.cmbManufacturer.Items.AddRange(New Object() {"N/A", "Seeger", "AlfaLaval", "Brd. Klee"})
        Me.cmbManufacturer.Location = New System.Drawing.Point(9, 244)
        Me.cmbManufacturer.Name = "cmbManufacturer"
        Me.cmbManufacturer.Size = New System.Drawing.Size(234, 21)
        Me.cmbManufacturer.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 268)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Size:"
        '
        'cmbSize
        '
        Me.cmbSize.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbSize.FormattingEnabled = True
        Me.cmbSize.Items.AddRange(New Object() {"N/A", "471", "472", "6799"})
        Me.cmbSize.Location = New System.Drawing.Point(9, 284)
        Me.cmbSize.Name = "cmbSize"
        Me.cmbSize.Size = New System.Drawing.Size(234, 21)
        Me.cmbSize.TabIndex = 17
        '
        'btnSaveFormat
        '
        Me.btnSaveFormat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveFormat.Location = New System.Drawing.Point(296, 18)
        Me.btnSaveFormat.Name = "btnSaveFormat"
        Me.btnSaveFormat.Size = New System.Drawing.Size(120, 23)
        Me.btnSaveFormat.TabIndex = 19
        Me.btnSaveFormat.Text = "Save Current Format"
        Me.btnSaveFormat.UseVisualStyleBackColor = True
        '
        'lstFormats
        '
        Me.lstFormats.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstFormats.FormattingEnabled = True
        Me.lstFormats.Location = New System.Drawing.Point(6, 16)
        Me.lstFormats.Name = "lstFormats"
        Me.lstFormats.Size = New System.Drawing.Size(309, 147)
        Me.lstFormats.TabIndex = 20
        '
        'lstParameters
        '
        Me.lstParameters.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstParameters.FormattingEnabled = True
        Me.lstParameters.Items.AddRange(New Object() {"Class", "ClassNum", "Extra", "Material", "Manufacturer", "Size", "Name", "Now", "Date", "Today"})
        Me.lstParameters.Location = New System.Drawing.Point(3, 16)
        Me.lstParameters.Name = "lstParameters"
        Me.lstParameters.Size = New System.Drawing.Size(77, 147)
        Me.lstParameters.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Quick add"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Saved formats"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.lstParameters)
        Me.Panel1.Location = New System.Drawing.Point(6, 45)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(86, 169)
        Me.Panel1.TabIndex = 25
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.lstFormats)
        Me.Panel2.Location = New System.Drawing.Point(98, 45)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(318, 169)
        Me.Panel2.TabIndex = 26
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.txtFormat)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.btnSaveFormat)
        Me.GroupBox1.Location = New System.Drawing.Point(288, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(422, 218)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Formatting"
        '
        'cmbCustom
        '
        Me.cmbCustom.Controls.Add(Me.btnAddSize)
        Me.cmbCustom.Controls.Add(Me.btnAddManufacturer)
        Me.cmbCustom.Controls.Add(Me.btnAddClassID)
        Me.cmbCustom.Controls.Add(Me.btnAddClass)
        Me.cmbCustom.Controls.Add(Me.btnAddMaterial)
        Me.cmbCustom.Controls.Add(Me.cmbPredefined)
        Me.cmbCustom.Controls.Add(Me.Label12)
        Me.cmbCustom.Controls.Add(Me.Label6)
        Me.cmbCustom.Controls.Add(Me.btnAddPredefined)
        Me.cmbCustom.Controls.Add(Me.cmbMaterial)
        Me.cmbCustom.Controls.Add(Me.Label8)
        Me.cmbCustom.Controls.Add(Me.Label3)
        Me.cmbCustom.Controls.Add(Me.cmbSize)
        Me.cmbCustom.Controls.Add(Me.cmbTypeNum)
        Me.cmbCustom.Controls.Add(Me.Label7)
        Me.cmbCustom.Controls.Add(Me.Label4)
        Me.cmbCustom.Controls.Add(Me.cmbManufacturer)
        Me.cmbCustom.Controls.Add(Me.cmbClass)
        Me.cmbCustom.Controls.Add(Me.Label5)
        Me.cmbCustom.Controls.Add(Me.txtName)
        Me.cmbCustom.Location = New System.Drawing.Point(12, 27)
        Me.cmbCustom.Name = "cmbCustom"
        Me.cmbCustom.Size = New System.Drawing.Size(270, 316)
        Me.cmbCustom.TabIndex = 28
        Me.cmbCustom.TabStop = False
        Me.cmbCustom.Text = "Part Information"
        '
        'btnAddSize
        '
        Me.btnAddSize.Image = Global.Inventor_Part_Name_Generator.My.Resources.Resources.Add_thin_10x_16x
        Me.btnAddSize.Location = New System.Drawing.Point(246, 284)
        Me.btnAddSize.Name = "btnAddSize"
        Me.btnAddSize.Size = New System.Drawing.Size(21, 21)
        Me.btnAddSize.TabIndex = 26
        Me.btnAddSize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddSize.UseVisualStyleBackColor = True
        '
        'btnAddManufacturer
        '
        Me.btnAddManufacturer.Image = Global.Inventor_Part_Name_Generator.My.Resources.Resources.Add_thin_10x_16x
        Me.btnAddManufacturer.Location = New System.Drawing.Point(246, 243)
        Me.btnAddManufacturer.Name = "btnAddManufacturer"
        Me.btnAddManufacturer.Size = New System.Drawing.Size(21, 21)
        Me.btnAddManufacturer.TabIndex = 25
        Me.btnAddManufacturer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddManufacturer.UseVisualStyleBackColor = True
        '
        'btnAddClassID
        '
        Me.btnAddClassID.Image = Global.Inventor_Part_Name_Generator.My.Resources.Resources.Add_thin_10x_16x
        Me.btnAddClassID.Location = New System.Drawing.Point(246, 204)
        Me.btnAddClassID.Name = "btnAddClassID"
        Me.btnAddClassID.Size = New System.Drawing.Size(21, 21)
        Me.btnAddClassID.TabIndex = 24
        Me.btnAddClassID.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddClassID.UseVisualStyleBackColor = True
        '
        'btnAddClass
        '
        Me.btnAddClass.Image = Global.Inventor_Part_Name_Generator.My.Resources.Resources.Add_thin_10x_16x
        Me.btnAddClass.Location = New System.Drawing.Point(246, 163)
        Me.btnAddClass.Name = "btnAddClass"
        Me.btnAddClass.Size = New System.Drawing.Size(21, 21)
        Me.btnAddClass.TabIndex = 23
        Me.btnAddClass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddClass.UseVisualStyleBackColor = True
        '
        'btnAddMaterial
        '
        Me.btnAddMaterial.Image = Global.Inventor_Part_Name_Generator.My.Resources.Resources.Add_thin_10x_16x
        Me.btnAddMaterial.Location = New System.Drawing.Point(246, 124)
        Me.btnAddMaterial.Name = "btnAddMaterial"
        Me.btnAddMaterial.Size = New System.Drawing.Size(21, 21)
        Me.btnAddMaterial.TabIndex = 22
        Me.btnAddMaterial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddMaterial.UseVisualStyleBackColor = True
        '
        'cmbPredefined
        '
        Me.cmbPredefined.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbPredefined.FormattingEnabled = True
        Me.cmbPredefined.Items.AddRange(New Object() {"N/A", "Aluminum", "Steel", "Stainless Steel", "Spring Steel", "Cast Iron"})
        Me.cmbPredefined.Location = New System.Drawing.Point(9, 84)
        Me.cmbPredefined.Name = "cmbPredefined"
        Me.cmbPredefined.Size = New System.Drawing.Size(234, 21)
        Me.cmbPredefined.TabIndex = 19
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 68)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 13)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Predefined"
        '
        'btnAddPredefined
        '
        Me.btnAddPredefined.Image = Global.Inventor_Part_Name_Generator.My.Resources.Resources.Add_thin_10x_16x
        Me.btnAddPredefined.Location = New System.Drawing.Point(246, 84)
        Me.btnAddPredefined.Name = "btnAddPredefined"
        Me.btnAddPredefined.Size = New System.Drawing.Size(21, 21)
        Me.btnAddPredefined.TabIndex = 21
        Me.btnAddPredefined.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddPredefined.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 11)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Extra (Custom Info):"
        '
        'cmbExtra
        '
        Me.cmbExtra.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmbExtra.FormattingEnabled = True
        Me.cmbExtra.Items.AddRange(New Object() {"N/A", "471", "472", "6799"})
        Me.cmbExtra.Location = New System.Drawing.Point(9, 27)
        Me.cmbExtra.Name = "cmbExtra"
        Me.cmbExtra.Size = New System.Drawing.Size(251, 21)
        Me.cmbExtra.TabIndex = 22
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(294, 312)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(251, 20)
        Me.DateTimePicker1.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(297, 295)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Date:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(713, 24)
        Me.MenuStrip1.TabIndex = 30
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageSavedDataToolStripMenuItem, Me.PreferencesToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ManageSavedDataToolStripMenuItem
        '
        Me.ManageSavedDataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormatsToolStripMenuItem, Me.SavedStandardsToolStripMenuItem, Me.GenerationLogsToolStripMenuItem, Me.HotkeysToolStripMenuItem})
        Me.ManageSavedDataToolStripMenuItem.Name = "ManageSavedDataToolStripMenuItem"
        Me.ManageSavedDataToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.ManageSavedDataToolStripMenuItem.Text = "Manage"
        '
        'FormatsToolStripMenuItem
        '
        Me.FormatsToolStripMenuItem.Name = "FormatsToolStripMenuItem"
        Me.FormatsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FormatsToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.FormatsToolStripMenuItem.Text = "Formats..."
        '
        'SavedStandardsToolStripMenuItem
        '
        Me.SavedStandardsToolStripMenuItem.Name = "SavedStandardsToolStripMenuItem"
        Me.SavedStandardsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SavedStandardsToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.SavedStandardsToolStripMenuItem.Text = "Saved standards..."
        '
        'GenerationLogsToolStripMenuItem
        '
        Me.GenerationLogsToolStripMenuItem.Name = "GenerationLogsToolStripMenuItem"
        Me.GenerationLogsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.GenerationLogsToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.GenerationLogsToolStripMenuItem.Text = "Generation Logs..."
        '
        'HotkeysToolStripMenuItem
        '
        Me.HotkeysToolStripMenuItem.Name = "HotkeysToolStripMenuItem"
        Me.HotkeysToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.HotkeysToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.HotkeysToolStripMenuItem.Text = "Hotkeys..."
        '
        'PreferencesToolStripMenuItem
        '
        Me.PreferencesToolStripMenuItem.Name = "PreferencesToolStripMenuItem"
        Me.PreferencesToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.PreferencesToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.PreferencesToolStripMenuItem.Text = "Preferences..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(180, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PartInformationsToolStripMenuItem, Me.FormattingToolStripMenuItem, Me.ToolStripSeparator2, Me.UpdatesToolStripMenuItem, Me.FeedbackToolStripMenuItem, Me.ToolStripSeparator3, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'PartInformationsToolStripMenuItem
        '
        Me.PartInformationsToolStripMenuItem.Name = "PartInformationsToolStripMenuItem"
        Me.PartInformationsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.PartInformationsToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.PartInformationsToolStripMenuItem.Text = "Part Informations..."
        '
        'FormattingToolStripMenuItem
        '
        Me.FormattingToolStripMenuItem.Name = "FormattingToolStripMenuItem"
        Me.FormattingToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.FormattingToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.FormattingToolStripMenuItem.Text = "Formatting..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(191, 6)
        '
        'UpdatesToolStripMenuItem
        '
        Me.UpdatesToolStripMenuItem.Name = "UpdatesToolStripMenuItem"
        Me.UpdatesToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.UpdatesToolStripMenuItem.Text = "Updates..."
        '
        'FeedbackToolStripMenuItem
        '
        Me.FeedbackToolStripMenuItem.Name = "FeedbackToolStripMenuItem"
        Me.FeedbackToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.FeedbackToolStripMenuItem.Text = "Feedback..."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(191, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.cmbExtra)
        Me.Panel3.Enabled = False
        Me.Panel3.Location = New System.Drawing.Point(536, 361)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(270, 59)
        Me.Panel3.TabIndex = 32
        Me.Panel3.Visible = False
        '
        'chkAutomatic
        '
        Me.chkAutomatic.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkAutomatic.AutoSize = True
        Me.chkAutomatic.Location = New System.Drawing.Point(584, 326)
        Me.chkAutomatic.Name = "chkAutomatic"
        Me.chkAutomatic.Size = New System.Drawing.Size(120, 17)
        Me.chkAutomatic.TabIndex = 33
        Me.chkAutomatic.Text = "Automatic Generate"
        Me.chkAutomatic.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'frmGenerator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 349)
        Me.Controls.Add(Me.chkAutomatic)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.cmbCustom)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmGenerator"
        Me.Text = "Part Name Generator - Andi Rosenhave"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.cmbCustom.ResumeLayout(False)
        Me.cmbCustom.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtOutput As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFormat As TextBox
    Friend WithEvents cmbMaterial As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbTypeNum As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbClass As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnGenerate As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbManufacturer As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbSize As ComboBox
    Friend WithEvents btnSaveFormat As Button
    Friend WithEvents lstFormats As ListBox
    Friend WithEvents lstParameters As ListBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbCustom As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageSavedDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormatsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SavedStandardsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PreferencesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PartInformationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormattingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents UpdatesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FeedbackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cmbExtra As ComboBox
    Friend WithEvents GenerationLogsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HotkeysToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmbPredefined As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnAddPredefined As Button
    Friend WithEvents btnAddSize As Button
    Friend WithEvents btnAddManufacturer As Button
    Friend WithEvents btnAddClassID As Button
    Friend WithEvents btnAddClass As Button
    Friend WithEvents btnAddMaterial As Button
    Friend WithEvents chkAutomatic As CheckBox
    Friend WithEvents Timer1 As Timer
End Class

Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Xml
Imports System.Xml.Linq
Imports System.Xml.Serialization

Public Class frmGenerator
    Public Sources As New AllSources
    Dim strOutput As String
    Dim FormatPath As String = Application.StartupPath & "\Data\"

    'Public Formats As New List(Of CustomFormat)

    Private Sub frmGenerator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbClass.SelectedIndex = 1
        cmbMaterial.SelectedIndex = 2
        cmbTypeNum.SelectedIndex = 3
        cmbManufacturer.SelectedIndex = 1
        cmbSize.SelectedIndex = 0
        If Directory.Exists(Path.Combine(Application.StartupPath & "\Data\")) = False Then
            Directory.CreateDirectory(FormatPath)
        End If

        If File.Exists(Path.Combine(FormatPath & "Formatlist.xml")) Then
            Sources.LoadFormats()
        Else
            Sources.GenerateDefaultFormat()
        End If

        If File.Exists(Path.Combine(FormatPath & "Sources.xml")) Then
            Sources.LoadSources()
        Else
            Sources.GenerateDefaultSources()
        End If
        RefreshListings()
    End Sub

    Private Sub lstParameters_DoubleClick(sender As Object, e As EventArgs) Handles lstParameters.DoubleClick
        txtFormat.AppendText("%" & lstParameters.SelectedItem.ToString & "%")
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        If String.IsNullOrWhiteSpace(txtName.Text) Then
            btnGenerate.Enabled = False
        Else
            btnGenerate.Enabled = True
        End If
    End Sub

    Private Sub lstFormats_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstFormats.SelectedIndexChanged
        Dim FormatName As String = lstFormats.SelectedItem.ToString
        If Sources.Exists(FormatName) Then
            txtFormat.Text = Sources.FindFormat(FormatName).FormatString
        End If
    End Sub

    Public Function RefreshListings()
        lstFormats.Items.Clear()
        Try
            For Each entry In Sources.Formats
                lstFormats.Items.Add(entry.Name)
            Next
            Return True
        Catch ex As Exception
            Debug.WriteLine(ex.ToString)
            Return False
        End Try

        cmbClass.Items.Clear()
        cmbClass.Items.Add(Sources.ListClassTypes.ToArray)

        cmbManufacturer.Items.Clear()
        cmbManufacturer.Items.Add(Sources.ListManufacturers.ToArray)

        cmbMaterial.Items.Clear()
        cmbMaterial.Items.Add(Sources.ListMaterials.ToArray)

        cmbSize.Items.Clear()
        cmbSize.Items.Add(Sources.ListSizes)

    End Function

#Region "Buttons"
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        'Sources.LoadSources()
        Form1.Show()
    End Sub
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        If Not String.IsNullOrWhiteSpace(txtName.Text) AndAlso Not String.IsNullOrWhiteSpace(txtFormat.Text) Then
            GenerateString(txtName.Text, txtFormat.Text)
        End If
    End Sub
    Private Sub btnSaveFormat_Click(sender As Object, e As EventArgs) Handles btnSaveFormat.Click
        Dim SaveDialog As New frmSaveFormat
        If SaveDialog.ShowDialog = DialogResult.OK Then
            Dim FormatName As String = SaveDialog.FormatName
            Sources.SaveFormat(FormatName, txtFormat.Text)
            lstFormats.Items.Add(FormatName)
        End If
    End Sub
#End Region

#Region "Menu Bar functions"
    Private Sub FormatsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormatsToolStripMenuItem.Click
        frmFormattings.Show()
    End Sub

    Private Sub PreferencesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreferencesToolStripMenuItem.Click
        frmPreferences.Show()
    End Sub

    Private Sub HotkeysToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HotkeysToolStripMenuItem.Click
        frmHotkeys.ShowDialog()
    End Sub

    Private Sub FormattingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormattingToolStripMenuItem.Click
        frmFormatHelp.Show()
    End Sub
    Private Sub SavedStandardsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SavedStandardsToolStripMenuItem.Click
        frmModify.Show()
    End Sub

    Private Sub cmbPredefined_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPredefined.SelectedIndexChanged
        If Sources.Exists(cmbPredefined.Text, "Predefined") Then
            Dim Pred As PredefinedPart
            Pred = Sources.FindPredefined(cmbPredefined.Text)

            If Not IsNothing(Pred._ClassID) Then cmbTypeNum.Text = Pred._ClassID
            If Not IsNothing(Pred._ClassType) Then cmbClass.Text = Pred._ClassType
            If Not IsNothing(Pred._Dimension) Then cmbSize.Text = Pred._Dimension
            If Not IsNothing(Pred._Manufacturer) Then cmbManufacturer.Text = Pred._Manufacturer
            If Not IsNothing(Pred._Material) Then cmbMaterial.Text = Pred._Material
            If Not IsNothing(Pred._PartName) Then txtName.Text = Pred._PartName
            If Not IsNothing(Pred._FormatString) Then txtFormat.Text = Pred._FormatString

        End If
    End Sub

    Private Sub chkAutomatic_CheckedChanged(sender As Object, e As EventArgs) Handles chkAutomatic.CheckedChanged
        If chkAutomatic.Checked = True Then
            Timer1.Enabled = True
        Else
            Timer1.Enabled = False
        End If
    End Sub
#End Region

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not String.IsNullOrWhiteSpace(txtName.Text) AndAlso Not String.IsNullOrWhiteSpace(txtFormat.Text) Then
            GenerateString(txtName.Text, txtFormat.Text)
        End If
    End Sub

    Public Function GenerateString(ByVal PartName As String, ByVal FormatString As String) As String
        Dim strClass, strClassNum, strMaterial, strManufacturer, strFormat, strName, strGenerated, strExtra As String
        strClass = ""
        strClassNum = ""
        strMaterial = ""
        strManufacturer = ""
        strFormat = ""
        strName = ""
        strGenerated = ""
        strExtra = ""

        ' Define variables if they exist
        If Not String.IsNullOrWhiteSpace(cmbClass.SelectedItem.ToString) Then strClass = cmbClass.SelectedItem.ToString
        If Not String.IsNullOrWhiteSpace(cmbTypeNum.SelectedItem.ToString) Then strClassNum = cmbTypeNum.SelectedItem.ToString
        If Not String.IsNullOrWhiteSpace(cmbMaterial.SelectedItem.ToString) Then strMaterial = cmbMaterial.SelectedItem.ToString
        If Not String.IsNullOrWhiteSpace(cmbManufacturer.SelectedItem.ToString) Then strManufacturer = cmbManufacturer.SelectedItem.ToString
        If Not String.IsNullOrWhiteSpace(cmbExtra.SelectedIndex.ToString) Then strExtra = cmbExtra.SelectedItem.ToString

        ' Replace the parameters with data.
        strGenerated = FormatString
        strGenerated = Regex.Replace(strGenerated, "(%[Cc][Ll][Aa][Ss][Ss]%)", strClass)
        strGenerated = Regex.Replace(strGenerated, "(%[Cc][Ll][Aa][Ss][Ss][Nn][Uu][Mm]%)", strClassNum)
        strGenerated = Regex.Replace(strGenerated, "(%[Mm][Aa][Tt][Ee][Rr][Ii][Aa][Ll]%)", strMaterial)
        strGenerated = Regex.Replace(strGenerated, "(%[Nn][Aa][Mm][Ee]%)", PartName)
        strGenerated = Regex.Replace(strGenerated, "(%[Ee][Xx][Tt][Rr][Aa]%)", strExtra)
        strGenerated = Regex.Replace(strGenerated, "(%[Dd][Aa][Tt][Ee]%)", "")
        Return strGenerated
    End Function

    Private Sub btnAddPredefined_Click(sender As Object, e As EventArgs) Handles btnAddPredefined.Click
        Dim _Name As String
        Dim _Material As String
        Dim _Class As String
        Dim _ClassID As String
        Dim _Manufacturer As String
        Dim _Size As String
        Dim _FormatString As String

        If String.IsNullOrWhiteSpace(txtName.Text) Then _Name = Nothing Else _Name = txtName.Text
        If String.IsNullOrWhiteSpace(cmbMaterial.Text) Then _Material = Nothing Else _Material = cmbMaterial.Text
        If String.IsNullOrWhiteSpace(cmbClass.Text) Then _Class = Nothing Else _Class = cmbClass.Text
        If String.IsNullOrWhiteSpace(cmbTypeNum.Text) Then _ClassID = Nothing Else _ClassID = cmbTypeNum.Text
        If String.IsNullOrWhiteSpace(cmbManufacturer.Text) Then _Manufacturer = Nothing Else _Manufacturer = cmbManufacturer.Text
        If String.IsNullOrWhiteSpace(txtFormat.Text) Then _FormatString = Nothing Else _FormatString = txtFormat.Text
        If String.IsNullOrWhiteSpace(cmbSize.Text) Then _Size = Nothing Else _Size = cmbSize.Text

        Dim NewPredefined As New PredefinedPart(cmbPredefined.Text, _Name, _Material, _Class, _ClassID, _Manufacturer, _Size)
        NewPredefined._FormatString = _FormatString
        Sources.PredefinedParts.Add(NewPredefined)
    End Sub


End Class

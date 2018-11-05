Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Xml
Imports System.Xml.Linq
Imports System.Xml.Serialization


Public Class frmGenerator

    Dim strOutput As String
    Dim FormatPath As String = Application.StartupPath & "\Data\Saved Formats"

    Private Sub frmGenerator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbClass.SelectedIndex = 1
        cmbMaterial.SelectedIndex = 2
        cmbTypeNum.SelectedIndex = 3
        cmbManufacturer.SelectedIndex = 1
        cmbSize.SelectedIndex = 0


        If Directory.Exists(FormatPath) = False Then
            Directory.CreateDirectory(FormatPath)
        End If
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim strClass, strClassNum, strMaterial, strManufacturer, strDate, strFormat, strName, strGenerated As String

        ' Define variables if they exist
        If Not String.IsNullOrWhiteSpace(cmbClass.SelectedItem.ToString) Then strClass = cmbClass.SelectedItem.ToString
        If Not String.IsNullOrWhiteSpace(cmbTypeNum.SelectedItem.ToString) Then strClassNum = cmbTypeNum.SelectedItem.ToString
        If Not String.IsNullOrWhiteSpace(cmbMaterial.SelectedItem.ToString) Then strMaterial = cmbMaterial.SelectedItem.ToString
        If Not String.IsNullOrWhiteSpace(cmbManufacturer.SelectedItem.ToString) Then strManufacturer = cmbManufacturer.SelectedItem.ToString

        strFormat = txtFormat.Text
        strName = txtName.Text

        ' Replace the parameters with data.
        strGenerated = strFormat
        strGenerated = Regex.Replace(strGenerated, "(%[Cc][Ll][Aa][Ss][Ss]%)", strClass)
        strGenerated = Regex.Replace(strGenerated, "(%[Cc][Ll][Aa][Ss][Ss][Nn][Uu][Mm]%)", strClassNum)
        strGenerated = Regex.Replace(strGenerated, "(%[Mm][Aa][Tt][Ee][Rr][Ii][Aa][Ll]%)", strMaterial)
        strGenerated = Regex.Replace(strGenerated, "(%[Nn][Aa][Mm][Ee]%)", strName)
        txtOutput.Text = strGenerated

    End Sub

    Private Sub FormattingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormattingToolStripMenuItem.Click
        frmFormatHelp.Show()
    End Sub

    Private Sub lstParameters_DoubleClick(sender As Object, e As EventArgs) Handles lstParameters.DoubleClick
        txtFormat.AppendText("%" & lstParameters.SelectedItem.ToString & "%")
    End Sub

    Private Sub btnSaveFormat_Click(sender As Object, e As EventArgs) Handles btnSaveFormat.Click
        Dim SaveDialog As New frmSaveFormat
        If SaveDialog.ShowDialog = DialogResult.OK Then
            Dim FormatName As String = SaveDialog.FormatName
            Dim FormatString As String = txtFormat.Text


            Dim FilePath As String = Path.Combine(FormatPath, FormatName & ".xml")

            ' Create a new format
            Dim Format As New FormatInformation(FormatName, FormatString)

            ' Create XmlWriterSettings
            Dim settings As XmlWriterSettings = New XmlWriterSettings()
            settings.Indent = True

            ' Create Xml Writer
            Using writer As XmlWriter = XmlWriter.Create(FilePath, settings)
                ' Begin writing
                With writer
                    .WriteStartDocument()
                    .WriteStartElement(FormatName)
                    .WriteElementString("CreationDate", Date.Today.Date)
                    .WriteElementString("FormatString", FormatString)
                    .WriteEndElement()
                    .WriteEndDocument()
                End With
            End Using

        End If
    End Sub

    Class FormatInformation
        Public Sub New(ByVal FormatName As String, ByVal FormatString As String)
            ' Set fields.
            Me._FormatName = FormatName
            Me._FormatString = FormatString
        End Sub

        ' Storage of employee data.
        Public _FormatName As String
        Public _FormatString As String
    End Class

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        If String.IsNullOrWhiteSpace(txtName.Text) Then
            btnGenerate.Enabled = False
        Else
            btnGenerate.Enabled = True
        End If
    End Sub
End Class

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
        Dim strClass, strClassNum, strMaterial, strManufacturer, strDate, strFormat, strName, strGenerated, strExtra As String

        ' Define variables if they exist
        If Not String.IsNullOrWhiteSpace(cmbClass.SelectedItem.ToString) Then strClass = cmbClass.SelectedItem.ToString
        If Not String.IsNullOrWhiteSpace(cmbTypeNum.SelectedItem.ToString) Then strClassNum = cmbTypeNum.SelectedItem.ToString
        If Not String.IsNullOrWhiteSpace(cmbMaterial.SelectedItem.ToString) Then strMaterial = cmbMaterial.SelectedItem.ToString
        If Not String.IsNullOrWhiteSpace(cmbManufacturer.SelectedItem.ToString) Then strManufacturer = cmbManufacturer.SelectedItem.ToString
        If Not String.IsNullOrWhiteSpace(cmbExtra.SelectedIndex.ToString) Then strExtra = cmbExtra.SelectedItem.ToString

        strFormat = txtFormat.Text
        strName = txtName.Text

        ' Replace the parameters with data.
        strGenerated = strFormat
        strGenerated = Regex.Replace(strGenerated, "(%[Cc][Ll][Aa][Ss][Ss]%)", strClass)
        strGenerated = Regex.Replace(strGenerated, "(%[Cc][Ll][Aa][Ss][Ss][Nn][Uu][Mm]%)", strClassNum)
        strGenerated = Regex.Replace(strGenerated, "(%[Mm][Aa][Tt][Ee][Rr][Ii][Aa][Ll]%)", strMaterial)
        strGenerated = Regex.Replace(strGenerated, "(%[Nn][Aa][Mm][Ee]%)", strName)
        strGenerated = Regex.Replace(strGenerated, "(%[Ee][Xx][Tt][Rr][Aa]%)", strExtra)
        strGenerated = Regex.Replace(strGenerated, "(%[Dd][Aa][Tt][Ee]%)", "")
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
            lstFormats.Items.Add(FormatName)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim FilePath As String
            Dim settings As XmlReaderSettings = New XmlReaderSettings()
            Dim FormatName As String
            Dim FormatString As String

            settings.DtdProcessing = DtdProcessing.Parse

            For Each entry In lstFormats.Items
                FilePath = Path.Combine(FormatPath, entry & ".xml")

                Using reader As XmlReader = XmlReader.Create(FilePath, settings)
                    With reader
                        .MoveToContent()
                        While .Read
                            If .IsStartElement Then
                                Select Case .Name
                                    Case "CustomFormat"


                                    Case "FormatName"
                                        FormatName = .ReadElementContentAsString
                                    Case "FormatString"
                                        FormatString = .ReadElementContentAsString
                                    Case "CreationDate"
                                    Case "ID"
                                End Select
                            End If
                            Select Case (reader.NodeType)
                                Case XmlNodeType.Element
                                    Debug.WriteLine("Element: {0}", reader.Name)
                                Case XmlNodeType.Text
                                    Debug.WriteLine("Text: {0}", reader.Value)
                                    '    Case XmlNodeType.
                                    'Debug.WriteLine("Attribute: {0}", reader.a)
                            End Select

                        End While

                        'Dim Format As New FormatInformation(FormatName, FormatString)
                    End With
                End Using

            Next

        Catch ex As Exception

        End Try
    End Sub

    Public Sub LoadXML(reader As XmlReader)
        reader.MoveToContent()

    End Sub


    Class CustomFormats
        Dim _CustomFormats As New List(Of CustomFormats)
        Public Sub ReadFromXml(reader As XmlReader)
            reader.MoveToContent()
            If reader.IsEmptyElement Then
                reader.Read()
                Return
            End If
            reader.Read()

            While Not (reader.EOF)
                If reader.IsStartElement Then
                    If reader.Name = "FormatName" Then
                        'Dim CustomFormat As New CFormat()


                    End If
                End If
            End While

        End Sub
    End Class

    Public Class CFormat
        Public _FormatID As String
        Public _FormatName As String
        Public _FormatString As String
        Public _FormatDate As String

        Public Sub New(ByVal FormatID As String, ByVal FormatName As String, ByVal FormatString As String, ByVal FormatDate As String)
            Me._FormatDate = FormatDate
            Me._FormatID = FormatID
            Me._FormatName = FormatName
            Me._FormatString = FormatString
        End Sub
    End Class

    Class FormatInformation
        Public Sub New(ByVal FormatName As String, ByVal FormatString As String)
            ' Set fields.
            Me._FormatName = FormatName
            Me._FormatString = FormatString
        End Sub

        ' Storage of format data.
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

    Private Sub PreferencesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreferencesToolStripMenuItem.Click
        frmPreferences.Show()
    End Sub

    Private Sub HotkeysToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HotkeysToolStripMenuItem.Click
        frmHotkeys.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lstFormats.Items.Add(txtFormat.Text)
    End Sub
End Class

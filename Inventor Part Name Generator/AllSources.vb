Imports System.Xml
Public Class AllSources

    Dim SourcePath As String = Application.StartupPath & "\Data\Sources.xml"
    Dim FormatPath As String = Application.StartupPath & "\Data\Formatlist.xml"
    Public Property ClassTypes As New List(Of Classtype)
    Public Property Materials As New List(Of Material)
    Public Property SizeTypes As New List(Of Sizetype)
    Public Property Sizes As New List(Of CSize)
    Public Property Manufacturers As New List(Of Manufacturer)
    Public Property Formats As New List(Of CustomFormat)
    Public Property PredefinedParts As New List(Of PredefinedPart)



    Public Function LoadSources()
        Try
            Dim xDoc As XDocument = XDocument.Load(SourcePath)
            Dim xSources As XElement = xDoc.Element("Sources")
            Dim xManufacturers As XElement = xSources.Element("Manufacturers")
            Dim xMaterials As XElement = xSources.Element("Materials")
            Dim xClasses As XElement = xSources.Element("Classes")
            Dim xSizeTypes As XElement = xSources.Element("SizeTypes")
            Dim xSizes As XElement = xSources.Element("Sizes")

            Dim xManu = xManufacturers.Descendants("Name")
            For Each xEle In xManu
                Manufacturers.Add(New Manufacturer(xEle.Value))
            Next

            Dim xMats = xMaterials.Descendants("Material")
            For Each xEle In xMats
                Dim newMat As New Material(xEle.Element("Name").Value, xEle.Element("Short").Value)
                Materials.Add(newMat)
            Next

            Dim xSize = xSizes.Descendants("Size")
            For Each xEle In xSize
                Dim newSize As New CSize(xEle.Element("Dimension").Value, xEle.Element("Unit").Value)
                Sizes.Add(newSize)
            Next

            Dim xSizeType = xSizeTypes.Descendants("SizeType")
            For Each xEle In xSizeType
                Dim newSizeType As New Sizetype(xEle.Element("Type").Value, xEle.Element("Domain").Value)
                SizeTypes.Add(newSizeType)
            Next

            Dim xClass = xClasses.Descendants("Class")
            For Each xEle In xClass
                Dim newClass As New Classtype(xEle.Attribute("Name").Value)
                For Each xID In xEle.Elements("ID")
                    newClass._IDs.Add(xID.Value)
                Next
                ClassTypes.Add(newClass)
            Next

        Catch ex As Exception
            Debug.WriteLine(ex.ToString)
        End Try
    End Function

#Region "List output feed"
    Public Function ListClassTypes() As List(Of String)
        Dim ReturnList As New List(Of String)
        For Each CClass In ClassTypes
            ReturnList.Add(CClass.Name)
        Next
        Return ReturnList
    End Function

    Public Function ListClassIDs(ByVal Optional FromType As String = "all") As List(Of String)
        Dim ReturnList As New List(Of String)

        For Each entry In ClassTypes
            If FromType = "all" Then
                For Each id In entry._IDs
                    ReturnList.Add(id)
                Next
            Else
                For Each id In entry._IDs
                    If entry.Name = FromType Then
                        ReturnList.Add(id)
                    End If
                Next
            End If
        Next
        Return ReturnList
    End Function

    Public Function ListMaterials() As List(Of String)
        Dim ReturnList As New List(Of String)
        For Each entry In Materials
            ReturnList.Add(entry.Name)
        Next
        Return ReturnList
    End Function

    Public Function ListMaterialsShort() As List(Of String)
        Dim ReturnList As New List(Of String)
        For Each entry In Materials
            ReturnList.Add(entry.ShortName)
        Next
        Return ReturnList
    End Function

    Public Function ListManufacturers() As List(Of String)
        Dim ReturnList As New List(Of String)
        Try
            For Each entry In Manufacturers
                ReturnList.Add(entry.Name)
            Next
        Catch ex As Exception
            Debug.WriteLine("Error >> {0}", ex.ToString)
        End Try
        Return ReturnList
    End Function

    Public Function ListSizeTypes(ByVal Optional FromDomain As String = "all") As List(Of String)
        Dim ReturnList As New List(Of String)
        If FromDomain = "all" Then
            For Each entry In SizeTypes
                ReturnList.Add(entry.Type)
            Next
        Else
            For Each entry In SizeTypes
                If entry.Domain = FromDomain Then
                    ReturnList.Add(entry.Type)
                End If
            Next
        End If
        Return ReturnList
    End Function

    Public Function ListSizeDomains() As List(Of String)
        Dim ReturnList As New List(Of String)
        For Each entry In SizeTypes
            ReturnList.Add(entry.Domain)
        Next
        Return ReturnList
    End Function

    Public Function ListSizes(ByVal Optional ByUnit As String = "all") As List(Of String)
        Dim ReturnList As New List(Of String)
        If ByUnit = "all" Then
            For Each entry In Sizes
                ReturnList.Add(entry.Value)
            Next
        Else
            For Each entry In Sizes
                If entry.Unit = ByUnit Then
                    ReturnList.Add(entry.Value)
                End If
            Next
        End If
        Return ReturnList
    End Function

#End Region
#Region "Defaults"

    Public Sub GenerateDefaultFormat()
        Try
            Dim xDoc As New XDocument(
                New XDeclaration("1.0", "utf-8", "yes"),
                New XElement("Formattings",
                             New XElement("CustomFormat",
                                            New XAttribute("name", "Default Format"),
                                            New XElement("FormattingString", "[%CLASS% %CLASSNUM%] - %NAME% (%MATERIAL%)"),
                                            New XElement("CreationDate", "11/8/2018"))))
            xDoc.Save(FormatPath)
        Catch ex As Exception
        End Try
    End Sub
    Public Sub GenerateDefaultSources()
        Try
            Dim xDoc As New XDocument(
                New XDeclaration("1.0", "utf-8", "yes"),
                New XElement("Sources",
                             New XElement("Manufacturers",
                                          New XElement("Name", "Seeger"),
                                          New XElement("Name", "Brd. Klee"),
                                          New XElement("Name", "Sanistål")),
                             New XElement("Materials",
                                          New XElement("Material",
                                                       New XElement("Name", "Stainless Steel"),
                                                       New XElement("Short", "SS")),
                                          New XElement("Material",
                                                       New XElement("Name", "Spring Steel"),
                                                       New XElement("Short", "SprSt")),
                                          New XElement("Material",
                                                       New XElement("Name", "Aluminum"),
                                                       New XElement("Short", "Al"))),
                             New XElement("Classes",
                                          New XElement("Class",
                                                       New XAttribute("Name", "ISO"),
                                                       New XElement("ID", "471"),
                                                       New XElement("ID", "472")),
                                          New XElement("Class",
                                                       New XAttribute("Name", "ANSI")),
                                          New XElement("Class",
                                                       New XAttribute("Name", "DIN"))),
                             New XElement("SizeTypes",
                                          New XElement("SizeType",
                                                       New XElement("Type", "Ø"),
                                                       New XElement("Domain", "")),
                                          New XElement("SizeType",
                                                       New XElement("Type", "RA"),
                                                       New XElement("Domain", "Locking Ring"))),
                             New XElement("Sizes",
                                          New XElement("Size",
                                                       New XElement("Dimension", "10"),
                                                       New XElement("Unit", "mm")),
                                          New XElement("Size",
                                                       New XElement("Dimension", "8"),
                                                       New XElement("Unit", "")))))
            xDoc.Save(SourcePath)
        Catch ex As Exception
        End Try
    End Sub

#End Region
#Region "Utilities"

    Public Function FindFormat(ByVal SearchName As String) As CustomFormat
        Return Formats.Find(Function(p) p.Name = SearchName)
    End Function
    Public Function FindMaterial(ByVal SearchName As String) As Material
        Return Materials.Find(Function(p) p.Name = SearchName)
    End Function
    Public Function FindSizeType(ByVal SearchName As String) As Sizetype
        Return SizeTypes.Find(Function(p) p.Type = SearchName)
    End Function
    Public Function FindManufacturer(ByVal SearchName As String) As Manufacturer
        Return Manufacturers.Find(Function(p) p.Name = SearchName)
    End Function
    Public Function FindClassType(ByVal SearchName As String) As Classtype
        Return ClassTypes.Find(Function(p) p.Name = SearchName)
    End Function
    Public Function FindPredefined(ByVal SearchName As String) As PredefinedPart
        Return PredefinedParts.Find(Function(p) p._PartName = SearchName)
    End Function
    Public Function Exists(ByVal ItemName As String, ByVal Optional type As String = "CustomFormat")
        Select Case type
            Case "CustomFormat"
                If Not IsNothing(FindFormat(ItemName)) Then
                    Return True
                Else
                    Return False
                End If
            Case "Manufaturer"
                If Not IsNothing(FindManufacturer(ItemName)) Then
                    Return True
                Else
                    Return False
                End If
            Case "ClassType"
                If Not IsNothing(FindClassType(ItemName)) Then
                    Return True
                Else
                    Return False
                End If
            Case "SizeType"
                If Not IsNothing(FindSizeType(ItemName)) Then
                    Return True
                Else
                    Return False
                End If
            Case "Materials"
                If Not IsNothing(FindMaterial(ItemName)) Then
                    Return True
                Else
                    Return False
                End If
            Case "Predefined"
                If Not IsNothing(FindPredefined(ItemName)) Then
                    Return True
                Else
                    Return False
                End If
        End Select
    End Function

#End Region
#Region "Formats"

    Public Function LoadFormats()
        Try
            Dim settings As XmlReaderSettings = New XmlReaderSettings()
            settings.CloseInput = True
            Dim doc As XmlDocument = New XmlDocument()
            doc.Load(FormatPath)
            Dim FormatList As XmlNodeList = doc.GetElementsByTagName("CustomFormat")
            For i = 0 To FormatList.Count - 1
                Dim nr As XmlNodeReader = New XmlNodeReader(FormatList(i))
                Dim cName As String = ""
                Dim cString As String = ""
                Dim cCreationDate As String = ""
                Do While nr.Read
                    If nr.HasAttributes Then
                        nr.MoveToAttribute("name")
                        If nr.ReadAttributeValue Then
                            cName = nr.Value
                        End If
                    End If
                    Select Case nr.Name
                        Case "FormattingString"
                            cString = nr.ReadString
                        Case "CreationDate"
                            cCreationDate = nr.ReadString
                    End Select
                Loop
                Dim NewFormat As New CustomFormat(cName, cString, cCreationDate)
                Formats.Add(NewFormat)
            Next
        Catch ex As Exception
        End Try
    End Function

    Public Function SaveFormat(ByVal FormatName As String, ByVal FormatString As String)
        If Not Exists(FormatName) Then
            Try
                Dim CFormatFile As XDocument = XDocument.Load(FormatPath)
                Dim CFormattings As XElement = CFormatFile.Element("Formattings")
                CFormattings.Add(New XElement("CustomFormat",
                                              New XAttribute("name", FormatName),
                                              New XElement("FormattingString", FormatString),
                                              New XElement("CreationDate", Date.Now.ToShortDateString)))
                CFormatFile.Save(FormatPath)
                Dim FormatEntry As New CustomFormat(FormatName, FormatString)
                Formats.Add(FormatEntry)
            Catch ex As Exception
                MsgBox("Something went wrong.." & vbCrLf & vbCrLf & ex.ToString, MsgBoxStyle.Exclamation, "Error saving format.")
            End Try
        End If
    End Function

    Public Function DeleteFormat(ByVal FormatEntry As String)
        Dim FoundFormat As CustomFormat
        If Exists(FormatEntry) Then
            FoundFormat = FindFormat(FormatEntry)

            Dim CFormatFile As XDocument = XDocument.Load(FormatPath)
            Dim CFormattings As XElement = CFormatFile.Element("Formattings")
            Try
                CFormatFile.Descendants("CustomFormat").Where(Function(p) p.Attribute("name").Value = FormatEntry).FirstOrDefault.Remove()
                CFormatFile.Save(FormatPath)
                Formats.Remove(FoundFormat)
                Return True
            Catch ex As Exception
                Return False
            End Try
        Else
            Return False
        End If
    End Function

#End Region


End Class

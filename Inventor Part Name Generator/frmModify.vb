Imports System.ComponentModel

Public Class frmModify
    Dim Manufacturers As New List(Of String)
    Dim Materials As New List(Of String)
    Dim ClassTypes As New List(Of String)
    Dim Sources As AllSources = frmGenerator.Sources
    Dim MaterialPage As SourcePanel
    Dim ClassTypePage As SourcePanel
    Dim ManufacturerPage As SourcePanel

    Private Sub frmModify_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim MaterialTab As New TabPage("Materials") With {.Name = "Materials"}
        Dim ManufacturerTab As New TabPage("Manufacturers") With {.Name = "Manufacturers"}
        Dim ClassTypeTab As New TabPage("Classes") With {.Name = "Classes"}



        'MaterialPage.Entries.Items.AddRange(Sources.ListMaterials.ToArray)
        'ManufacturerPage.Entries.Items.AddRange(Sources.ListManufacturers.ToArray)
        'ClassTypePage.Entries.Items.AddRange(Sources.ListClassTypes.ToArray)
        Try
            Manufacturers = Sources.ListManufacturers
            Materials = Sources.ListMaterials
            ClassTypes = Sources.ListClassTypes
        Catch ex As Exception
            Debug.WriteLine("Error >> {0}", ex.ToString)
        End Try

        MaterialPage = New SourcePanel(Materials)
        ManufacturerPage = New SourcePanel(Manufacturers)
        ClassTypePage = New SourcePanel(ClassTypes)

        MaterialTab.Controls.Add(MaterialPage)
        ManufacturerTab.Controls.Add(ManufacturerPage)
        ClassTypeTab.Controls.Add(ClassTypePage)

        SourceTabs.TabPages.Add(MaterialTab)
        SourceTabs.TabPages.Add(ManufacturerTab)
        SourceTabs.TabPages.Add(ClassTypeTab)

    End Sub

    Private Sub btnSaveClose_Click(sender As Object, e As EventArgs) Handles btnSaveClose.Click
        SaveEntries()
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveEntries()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmModify_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        frmGenerator.cmbManufacturer.Items.Clear()
        frmGenerator.cmbManufacturer.Items.AddRange(Manufacturers.ToArray)
    End Sub

    Private Sub SaveEntries()
        Sources.Manufacturers.Clear()
        Sources.Manufacturers.AddRange(Manufacturers)

        Sources.Materials.Clear()
        Sources.Materials.AddRange(Materials)

        Sources.ClassTypes.Clear()
        Sources.ClassTypes.AddRange(ClassTypes)
    End Sub
End Class
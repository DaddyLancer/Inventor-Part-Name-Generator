Public Class SourcePanel
    Dim SourceListRef As New List(Of String)
    Dim SourceListVal As New List(Of String)
    Public Sub New(ByRef SourceList As List(Of String))
        ' This call is required by the designer.
        InitializeComponent()

        SourceListRef = SourceList
        'SourceListVal = SourceListV
    End Sub

    Private Sub RemoveAll_Click(sender As Object, e As EventArgs) Handles RemoveAll.Click
        If MsgBox("Are you sure you want to delete " & Entries.Items.Count & " entries?", MsgBoxStyle.OkCancel, "Remove all entries?") = MsgBoxResult.Ok Then
            'SourceListRef.Clear()
            Entries.Items.Clear()
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        EntryCount.Text = "Total Entries: " & Entries.Items.Count
    End Sub

    Private Sub RemoveSelected_Click(sender As Object, e As EventArgs) Handles RemoveSelected.Click
        Dim indexes As New List(Of Integer)
        For Each itm In Entries.CheckedItems
            Entries.Items.Remove(itm)
        Next
        'Entries.Items.Remove(Entries.SelectedItems)

        '        For i = 0 To Entries.SelectedItems.Count
        '       SourceListRef.Remove(SourceListRef.Where(Function(x) x.ToString = Entries.SelectedItems.Item(i)).FirstOrDefault)
        '      Next

        Entries.SelectedItems.Clear()
    End Sub

    Private Sub AddToList_Click(sender As Object, e As EventArgs) Handles AddToList.Click
        Dim Exists As Boolean = False

        For Each itm In Entries.Items
            If itm.ToString = NameInput.Text Then
                Exists = True
            End If
        Next

        If Not Exists Then
            Entries.Items.Add(NameInput.Text)
        End If
    End Sub

    Private Sub SourcePanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill
        Entries.Items.AddRange(SourceListRef.ToArray)
    End Sub
End Class

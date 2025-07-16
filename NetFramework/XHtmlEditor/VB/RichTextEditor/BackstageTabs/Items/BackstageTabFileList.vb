Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports C1.Win.InputPanel
Imports C1.Win.Ribbon
Imports RichTextEditor.RichTextEditor

Partial Public Class BackstageTabFileList
    Inherits UserControl

    Private _icons As Dictionary(Of String, Image)

    Public Sub New()
        InitializeComponent()
        BackColor = Color.FromArgb(212, 212, 212)
        _icons = New Dictionary(Of String, Image)()
    End Sub

    Protected Property Caption As String
        Get
            Return lblCaption.Text
        End Get

        Set(ByVal value As String)
            lblCaption.Text = value
        End Set
    End Property

    Public Property Items As List(Of RecentDocumentItem)

    Public Property BackstageView As C1BackstageView

    Public ReadOnly Property Button As BackstageTabButton
        Get
            Return AppMenuTabButton1
        End Get
    End Property

    Public Sub LoadItems(ByVal items As List(Of RecentDocumentItem))
        C1InputPanel1.Items.Clear()
        Me.Items = items
        Dim now As DateTime = DateTime.Now
        Dim pinned As IEnumerable(Of RecentDocumentItem) = items.Where(Function(x) x.Pinned)
        Dim list As IEnumerable(Of RecentDocumentItem) = items.Except(pinned)
        If pinned.Count() > 0 Then
            AddLabel("Pinned")
            For Each item As RecentDocumentItem In pinned
                AddItem(item)
            Next
        End If

        Dim today As IEnumerable(Of RecentDocumentItem) = list.Where(Function(x) x.ItemDate.Day = now.Day AndAlso x.ItemDate.Month = now.Month AndAlso x.ItemDate.Year = now.Year)
        If today.Count() > 0 Then
            AddLabel("Today")
            For Each item As RecentDocumentItem In today.OrderBy(Function(x) x.ItemDate)
                AddItem(item)
            Next
        End If

        Dim later As IEnumerable(Of RecentDocumentItem) = list.Except(today)
        If later.Count() > 0 Then
            AddLabel("Later")
            For Each item As RecentDocumentItem In later.OrderBy(Function(x) x.ItemDate)
                AddItem(item)
            Next
        End If
    End Sub

    Private Sub AddLabel(ByVal text As String)
        Dim label As InputLabel = New InputLabel()
        label.Break = BreakType.Row
        label.Text = text
        label.Font = New Font("Calibri", 14.0F, FontStyle.Regular, GraphicsUnit.Point, 204)
        label.ForeColor = Color.FromArgb(0, 114, 198)
        C1InputPanel1.Items.Add(label)
    End Sub

    Private Sub AddItem(ByVal item As RecentDocumentItem)
        Dim mi As BackstageTabItem = New BackstageTabItem()
        AddHandler mi.Click, AddressOf Me.Mi_Click
        AddHandler mi.PinnedChanged, AddressOf Me.Mi_PinnedChanged
        mi.SetItem(item, GetImage(item))
        Dim ch As InputControlHost = New InputControlHost(mi)
        ch.Width = 370
        ch.Height = 42
        C1InputPanel1.Items.Add(ch)
    End Sub

    Private Function GetImage(ByVal item As RecentDocumentItem) As Image
        Dim ext As String = IO.Path.GetExtension(item.FileName)
        If _icons.ContainsKey(ext) Then
            Return _icons(ext)
        End If

        If IO.File.Exists(item.FileName) Then
            _icons.Add(ext, Icon.ExtractAssociatedIcon(item.FileName).ToBitmap())
            Return _icons(ext)
        End If

        Return Nothing
    End Function

    Protected Function GetElementText(ByVal text As String) As String
        Dim textParts As String() = If(text IsNot Nothing, text.Split(vbLf), New String() {String.Empty})
        Return textParts(0).Trim()
    End Function

    Protected Overridable Sub OnMenuItemClick(ByVal item As BackstageTabItem)
    End Sub

    Protected Overridable Sub OnMenuButtonClick()
    End Sub

    Private Sub Mi_Click(ByVal sender As Object, ByVal e As EventArgs)
        OnMenuItemClick(CType(sender, BackstageTabItem))
        BackstageView.DroppedDown = False
    End Sub

    Private Sub Mi_PinnedChanged(ByVal sender As Object, ByVal e As EventArgs)
        LoadItems(Items)
    End Sub

    Private Sub menuButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AppMenuTabButton1.Click
        OnMenuButtonClick()
        BackstageView.DroppedDown = False
    End Sub
End Class
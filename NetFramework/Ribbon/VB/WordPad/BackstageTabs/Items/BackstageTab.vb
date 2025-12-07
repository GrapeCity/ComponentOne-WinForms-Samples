Imports System.Linq
Imports C1.Win.InputPanel
Imports C1.Win.Ribbon

Public Class BackstageTab

    Private _icons As Dictionary(Of String, Image)

    Public Sub New()
        _icons = New Dictionary(Of String, Image)()
    End Sub

    Public Sub Initilize()
        InitializeComponent()
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
    Public Property Owner As Form1
    Public Property View As C1BackstageView

    Public ReadOnly Property Button As ItemButton
        Get
            Return ItemButton1
        End Get
    End Property

    Public Sub LoadItems(ByVal items As List(Of RecentDocumentItem))
        c1InputPanel1.Items.Clear()
        Me.Items = items
        Dim now = DateTime.Now
        Dim pinned As IEnumerable(Of RecentDocumentItem) = items.Where(Function(x) x.Pinned)
        Dim list As IEnumerable(Of RecentDocumentItem) = items.Except(pinned)

        If pinned.Count() > 0 Then
            AddLabel("Pinned")

            For Each item As RecentDocumentItem In pinned
                AddItem(item)
            Next
        End If

        Dim today As IEnumerable(Of RecentDocumentItem) = list.Where(Function(x) x.LDate.Day = now.Day AndAlso x.LDate.Month = now.Month AndAlso x.LDate.Year = now.Year)

        If today.Count() > 0 Then
            AddLabel("Today")

            For Each item As RecentDocumentItem In today.OrderBy(Function(x) x.LDate)
                AddItem(item)
            Next
        End If

        Dim later As IEnumerable(Of RecentDocumentItem) = list.Except(today)

        If later.Count() > 0 Then
            AddLabel("Later")

            For Each item As RecentDocumentItem In later.OrderBy(Function(x) x.LDate)
                AddItem(item)
            Next
        End If
    End Sub

    Private Sub AddLabel(ByVal text As String)
        Dim label = New InputLabel()
        label.Break = BreakType.Row
        label.Text = text
        label.Font = New Font("Calibri", 14.0F, FontStyle.Regular, GraphicsUnit.Point, 204)
        label.ForeColor = Color.FromArgb(0, 114, 198)
        c1InputPanel1.Items.Add(label)
    End Sub

    Private Sub AddItem(ByVal item As RecentDocumentItem)
        Dim mi As ListItem = New ListItem()
        mi.SetItem(item, GetImage(item))
        AddHandler mi.PinnedChanged, AddressOf Mi_PinnedChanged
        AddHandler mi.Click, AddressOf Mi_Click
        Dim ch = New InputControlHost(mi)
        ch.Width = 370
        ch.Height = 42
        c1InputPanel1.Items.Add(ch)
    End Sub

    Private Function GetImage(ByVal item As RecentDocumentItem) As Image
        Dim ext = System.IO.Path.GetExtension(item.FileName)

        If _icons.ContainsKey(ext) Then
            Return _icons(ext)
        End If

        If System.IO.File.Exists(item.FileName) Then
            _icons.Add(ext, Icon.ExtractAssociatedIcon(item.FileName).ToBitmap())
            Return _icons(ext)
        End If

        Return Nothing
    End Function

    Protected Function GetElementText(ByVal text As String) As String
        Dim textParts As String() = If(text IsNot Nothing, text.Split(vbLf), New String() {String.Empty})
        Return textParts(0).Trim()
    End Function

    Protected Overridable Sub OnMenuItemClick(ByVal item As ListItem)
    End Sub

    Protected Overridable Sub OnMenuButtonClick()
    End Sub

    Private Sub Mi_Click(ByVal sender As Object, ByVal e As EventArgs)
        OnMenuItemClick(CType(sender, ListItem))
        View.DroppedDown = False
    End Sub

    Private Sub Mi_PinnedChanged(ByVal sender As Object, ByVal e As EventArgs)
        LoadItems(Items)
    End Sub

    Private Sub menuButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ItemButton1.Click
        OnMenuButtonClick()
        View.DroppedDown = False
    End Sub
End Class

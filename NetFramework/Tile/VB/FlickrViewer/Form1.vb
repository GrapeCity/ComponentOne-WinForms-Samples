Imports System.ComponentModel
Imports System.Net
Imports System.Xml
Imports C1.Win.C1Tile

Public Class Form1

    Shared flickrUrl As String = "http://api.flickr.com/services/feeds/photos_public.gne"

#Region "** FlickrPhoto"

    Public Class FlickrPhoto
        Public Title As String
        Public ThumbnailUri As String
        Public ContentUri As String
        Public AuthorName As String
        Public AuthorBuddyIconUri As String
        Public ID As String
    End Class

#End Region

#Region "** DownloadItem"

    Public Class DownloadItem

        Private _uri As String
        Private _tile As Tile
        Private _isBuddyIcon As Boolean

        Public Sub New(ByVal aUri As String, ByVal aTile As Tile, ByVal aIsBuddyIcon As Boolean)
            _uri = aUri
            _tile = aTile
            _isBuddyIcon = aIsBuddyIcon
        End Sub

        Public ReadOnly Property Uri() As String
            Get
                Return _uri
            End Get
        End Property

        Public ReadOnly Property Tile() As Tile
            Get
                Return _tile
            End Get
        End Property

        Public ReadOnly Property IsBuddyIcon() As Boolean
            Get
                Return _isBuddyIcon
            End Get
        End Property

    End Class

#End Region

    Dim _outOfTurnItem As DownloadItem
    Dim _downloadQueue As New Queue(Of DownloadItem)()
    Dim _client As WebClient

    Dim _lastError As String
    Dim _targetItem As DownloadItem
    Dim _tags As String

    Public Sub New()
        InitializeComponent()

        _client = New WebClient()
        AddHandler _client.OpenReadCompleted, AddressOf WebClient_OpenReadCompleted
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        flickrTiles.Groups(0).Tiles.Clear(True)
        LoadPhotos(False)
    End Sub

    Private Sub LoadPhotos(ByVal keepExistent As Boolean)
        waitLabel.Visible = True
        Dim uri As String = flickrUrl
        If Not String.IsNullOrEmpty(_tags) Then
            uri += "?tags=" + _tags
        End If
        Dim item As New DownloadItem(uri, Nothing, keepExistent)
        If keepExistent Then
            If _client.IsBusy Then
                _outOfTurnItem = item
                Return
            End If
        Else
            flickrTiles.ScrollOffset = 0
            _downloadQueue.Clear()
            If _client.IsBusy Then
                _client.CancelAsync()
            End If
        End If
        _targetItem = item
        _client.OpenReadAsync(New Uri(uri))
    End Sub

    Private Sub WebClient_OpenReadCompleted(ByVal sender As Object, ByVal e As OpenReadCompletedEventArgs)
        If e.Cancelled Or _targetItem Is Nothing Then
            Return
        End If
        Dim ex As Exception = e.Error
        If ex Is Nothing Then
            Try
                If _targetItem.Tile Is Nothing Then
                    Dim doc As New XmlDocument()
                    doc.Load(e.Result)

                    Dim nt As New NameTable()
                    Dim nm As New XmlNamespaceManager(nt)
                    nm.AddNamespace("ns", "http://www.w3.org/2005/Atom")
                    nm.AddNamespace("flickr", "urn:flickr:user")

                    Dim result As New List(Of FlickrPhoto)()
                    Dim tiles As TileCollection = flickrTiles.Groups(0).Tiles
                    Dim keepExistent As Boolean = _targetItem.IsBuddyIcon

                    For Each node As XmlNode In doc.DocumentElement.SelectNodes("ns:entry", nm)
                        Dim id As String = node.SelectSingleNode("ns:id", nm).InnerText
                        Dim found As Boolean = False
                        If keepExistent Then
                            For Each t As Tile In tiles
                                If CType(t.Tag, FlickrPhoto).ID = id Then
                                    found = True
                                    Exit For
                                End If
                            Next
                        End If
                        If Not found Then
                            Dim photo As New FlickrPhoto()
                            photo.ID = id
                            photo.Title = PrepareTitle(node.SelectSingleNode("ns:title", nm).InnerText)
                            Dim authorNode As XmlNode = node.SelectSingleNode("ns:author", nm)
                            If authorNode IsNot Nothing Then
                                photo.AuthorName = authorNode.SelectSingleNode("ns:name", nm).InnerText
                                photo.AuthorBuddyIconUri = authorNode.SelectSingleNode("flickr:buddyicon", nm).InnerText
                            End If
                            Dim linkNode As XmlNode = node.SelectSingleNode("ns:link[@rel='enclosure']", nm)
                            If linkNode IsNot Nothing Then
                                photo.ContentUri = linkNode.Attributes("href").Value
                                photo.ThumbnailUri = photo.ContentUri.Replace("_b.jpg", "_m.jpg")
                            End If
                            result.Add(photo)
                        End If
                    Next
                    UpdatePhotos(result, tiles, keepExistent)
                Else
                    Dim img As Image = Image.FromStream(e.Result)
                    Dim t As Tile = _targetItem.Tile
                    If Not _targetItem.IsBuddyIcon Then
                        t.Image = img
                    Else
                        t.Image1 = img
                    End If
                End If
            Catch excep As Exception
                ex = excep
            End Try
        End If
        If ex IsNot Nothing AndAlso _targetItem.Tile Is Nothing AndAlso Not _targetItem.IsBuddyIcon Then
            _targetItem = Nothing
            _lastError = ex.Message
            ShowErrorTile()
        Else
            _targetItem = Nothing
            _lastError = Nothing
            If _outOfTurnItem IsNot Nothing Then
                _targetItem = _outOfTurnItem
                _outOfTurnItem = Nothing
            ElseIf _downloadQueue.Count > 0 Then
                _targetItem = _downloadQueue.Dequeue()
            End If
            If _targetItem IsNot Nothing Then
                _client.OpenReadAsync(New Uri(_targetItem.Uri))
            End If
        End If
        waitLabel.Visible = False
    End Sub

    Private Function PrepareTitle(ByVal s As String) As String
        If s IsNot Nothing Then
            Dim n As Int32 = s.IndexOf("#")
            If n >= 0 Then
                s = s.Substring(0, n)
            End If
            n = s.IndexOf(".jpg")
            If n >= 0 Then
                s = s.Substring(0, n)
            End If
        End If
        Return s
    End Function

    Private Sub UpdatePhotos(ByVal photos As List(Of FlickrPhoto), ByVal tiles As TileCollection, ByVal keepExistent As Boolean)
        flickrTiles.BeginUpdate()
        If Not keepExistent Then
            tiles.Clear(True)
        End If
        For Each photo As FlickrPhoto In photos
            Dim t As New Tile()
            t.HorizontalSize = 4
            t.VerticalSize = 3
            t.Template = tempFlickr
            t.Text = photo.Title
            t.Text1 = photo.AuthorName
            t.Tag = photo
            AddHandler t.Click, AddressOf Tile_Click
            If Not String.IsNullOrEmpty(photo.ThumbnailUri) Then
                _downloadQueue.Enqueue(New DownloadItem(photo.ThumbnailUri, t, False))
            End If
            If Not String.IsNullOrEmpty(photo.AuthorBuddyIconUri) Then
                _downloadQueue.Enqueue(New DownloadItem(photo.AuthorBuddyIconUri, t, True))
            End If
            tiles.Add(t)
        Next
        flickrTiles.EndUpdate()
    End Sub

    Private Sub ShowErrorTile()
        _downloadQueue.Clear()
        Dim tiles As TileCollection = flickrTiles.Groups(0).Tiles
        flickrTiles.BeginUpdate()
        tiles.Clear(True)
        Dim t As Tile = New Tile()
        t.HorizontalSize = 4
        t.VerticalSize = 2
        t.Template = tempError
        AddHandler t.Click, AddressOf ErrorTile_Click
        tiles.Add(t)
        flickrTiles.EndUpdate()
    End Sub

    Private Sub ErrorTile_Click(ByVal sender As Object, ByVal e As EventArgs)
        MessageBox.Show(_lastError, "Flickr Viewer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub

    Private Sub setTagButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles setTagButton.Click
        flickrTiles.Focus()
        _tags = tagBox.Text
        LoadPhotos(False)
    End Sub

    Private Sub tagBox_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles tagBox.KeyPress
        If AscW(e.KeyChar) = 13 Then
            setTagButton_Click(sender, EventArgs.Empty)
            e.Handled = True
        ElseIf AscW(e.KeyChar) = 27 Then
            flickrTiles.Focus()
            e.Handled = True
        End If
    End Sub

    Private Sub refreshButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles refreshButton.Click
        flickrTiles.Focus()
        LoadPhotos(False)
    End Sub

    Private Sub loadNewButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles loadNewButton.Click
        flickrTiles.Focus()
        LoadPhotos(_lastError Is Nothing)
    End Sub

    Private Sub Tile_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim t As Tile = CType(sender, Tile)
        Dim photo As FlickrPhoto = CType(t.Tag, FlickrPhoto)
        Dim uri As String = photo.ContentUri
        If Not String.IsNullOrEmpty(uri) Then
            pictureBox.Image = pictureBox.InitialImage
            pictureBox.SizeMode = PictureBoxSizeMode.CenterImage
            imgPanel.Visible = True
            imgPanel.BringToFront()
            titleLabel.Text = photo.Title
            authorLabel.Text = photo.AuthorName
            waitLabel.Visible = True
            pictureBox.LoadAsync(uri)
            tagBox.Enabled = False
            setTagButton.Enabled = False
            refreshButton.Enabled = False
            loadNewButton.Enabled = False
            flickrTiles.Enabled = False
            backButton.Enabled = True
            Me.Focus()
        End If
    End Sub

    Private Sub pictureBox_LoadCompleted(ByVal sender As Object, ByVal e As AsyncCompletedEventArgs) Handles pictureBox.LoadCompleted
        pictureBox.SizeMode = PictureBoxSizeMode.Zoom
        waitLabel.Visible = False
    End Sub

    Private Sub backButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles backButton.Click
        If imgPanel.Visible Then
            tagBox.Enabled = True
            setTagButton.Enabled = True
            refreshButton.Enabled = True
            loadNewButton.Enabled = True
            flickrTiles.Enabled = True
            imgPanel.Visible = False
            flickrTiles.Focus()
        End If
        backButton.Enabled = False
    End Sub

    Private Sub ViewerForm_PreviewKeyDown(ByVal sender As Object, ByVal e As PreviewKeyDownEventArgs) Handles MyBase.PreviewKeyDown
        If e.KeyData = Keys.Back Then
            backButton_Click(sender, EventArgs.Empty)
        End If
    End Sub

End Class

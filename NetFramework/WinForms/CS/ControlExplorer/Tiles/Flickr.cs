using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using System.Xml;

using C1.Win.C1Tile;

namespace ControlExplorer.Tiles
{
    public partial class Flickr : C1DemoForm
    {
        static string flickrUrl = "http://api.flickr.com/services/feeds/photos_public.gne";

        #region ** FlickrPhoto

        public class FlickrPhoto
        {
            public string Title { get; set; }
            public string ThumbnailUri { get; set; }
            public string ContentUri { get; set; }
            public string AuthorName { get; set; }
            public string AuthorBuddyIconUri { get; set; }
            public string ID { get; set; }
        }

        #endregion

        #region ** DownloadItem

        public class DownloadItem
        {
            string _uri;
            Tile _tile;
            bool _isBuddyIcon;

            public DownloadItem(string uri, Tile tile, bool isBuddyIcon)
            {
                _uri = uri;
                _tile = tile;
                _isBuddyIcon = isBuddyIcon;
            }

            public string Uri
            {
                get { return _uri; }
            }

            public Tile Tile
            {
                get { return _tile; }
            }

            public bool IsBuddyIcon
            {
                get { return _isBuddyIcon; }
            }
        }

        #endregion

        DownloadItem _outOfTurnItem;
        Queue<DownloadItem> _downloadQueue = new Queue<DownloadItem>();
        WebClient _client;

        string _lastError;
        DownloadItem _targetItem;
        string _tags;

        public Flickr()
        {
            InitializeComponent();

            _client = new WebClient();
            _client.OpenReadCompleted += WebClient_OpenReadCompleted;
        }

        void Form1_Load(object sender, EventArgs e)
        {
            flickrTiles.Groups[0].Tiles.Clear(true);
            LoadPhotos(false);
        }

        void LoadPhotos(bool keepExistent)
        {
            waitLabel.Visible = true;
            string uri = string.IsNullOrEmpty(_tags) ? flickrUrl : flickrUrl + "?tags=" + _tags;
            DownloadItem item = new DownloadItem(uri, null, keepExistent);
            if (keepExistent)
            {
                if (_client.IsBusy)
                {
                    _outOfTurnItem = item;
                    return;
                }
            }
            else
            {
                _downloadQueue.Clear();
                if (_client.IsBusy)
                {
                    _client.CancelAsync();
                }
            }
            _targetItem = item;
            _client.OpenReadAsync(new Uri(uri));
        }

        void WebClient_OpenReadCompleted(object sender, OpenReadCompletedEventArgs e)
        {
            if (e.Cancelled || _targetItem == null)
            {
                return;
            }
            Exception ex = e.Error;
            if (ex == null)
            {
                try
                {
                    if (_targetItem.Tile == null)
                    {
                        var doc = new XmlDocument();
                        doc.Load(e.Result);

                        var nameTable = new NameTable();
                        var nm = new XmlNamespaceManager(nameTable);
                        nm.AddNamespace("ns", "http://www.w3.org/2005/Atom");
                        nm.AddNamespace("flickr", "urn:flickr:user");

                        List<FlickrPhoto> result = new List<FlickrPhoto>();
                        TileCollection tiles = flickrTiles.Groups[0].Tiles;
                        bool keepExistent = _targetItem.IsBuddyIcon;

                        foreach (XmlNode node in doc.DocumentElement.SelectNodes("ns:entry", nm))
                        {
                            string id = node.SelectSingleNode("ns:id", nm).InnerText;

                            if (keepExistent)
                            {
                                bool found = false;
                                foreach (Tile tile in tiles)
                                {
                                    if (((FlickrPhoto)tile.Tag).ID == id)
                                    {
                                        found = true;
                                        break;
                                    }
                                }
                                if (found)
                                {
                                    continue;
                                }
                            }

                            var photo = new FlickrPhoto();
                            photo.ID = id;
                            photo.Title = PrepareTitle(node.SelectSingleNode("ns:title", nm).InnerText);
                            var authorNode = node.SelectSingleNode("ns:author", nm);
                            if (authorNode != null)
                            {
                                photo.AuthorName = authorNode.SelectSingleNode("ns:name", nm).InnerText;
                                photo.AuthorBuddyIconUri = authorNode.SelectSingleNode("flickr:buddyicon", nm).InnerText;
                            }
                            var linkNode = node.SelectSingleNode("ns:link[@rel='enclosure']", nm);
                            if (linkNode != null)
                            {
                                photo.ContentUri = linkNode.Attributes["href"].Value;
                                photo.ThumbnailUri = photo.ContentUri.Replace("_b.jpg", "_m.jpg");
                            }
                            result.Add(photo);
                        }
                        UpdatePhotos(result, tiles, keepExistent);
                    }
                    else
                    {
                        Image img = Image.FromStream(e.Result);
                        Tile tile = _targetItem.Tile;
                        if (!_targetItem.IsBuddyIcon)
                            tile.Image = img;
                        else
                            tile.Image1 = img;
                    }
                }
                catch (Exception exception)
                {
                    ex = exception;
                }
            }

            if (ex != null && _targetItem.Tile == null && !_targetItem.IsBuddyIcon)
            {
                _targetItem = null;
                _lastError = ex.Message;
                ShowErrorTile();
            }
            else
            {
                _targetItem = null;
                _lastError = null;
                if (_outOfTurnItem != null)
                {
                    _targetItem = _outOfTurnItem;
                    _outOfTurnItem = null;
                }
                else if (_downloadQueue.Count > 0)
                {
                    _targetItem = _downloadQueue.Dequeue();
                }
                if (_targetItem != null)
                {
                    _client.OpenReadAsync(new Uri(_targetItem.Uri));
                }
            }
            waitLabel.Visible = false;
        }

        string PrepareTitle(string s)
        {
            if (s != null)
            {
                int n = s.IndexOf("#");
                if (n >= 0)
                {
                    s = s.Substring(0, n);
                }
                n = s.IndexOf(".jpg");
                if (n >= 0)
                {
                    s = s.Substring(0, n);
                }
            }
            return s;
        }

        void UpdatePhotos(List<FlickrPhoto> photos, TileCollection tiles, bool keepExistent)
        {
            flickrTiles.BeginUpdate();

            if (!keepExistent)
            {
                tiles.Clear(true);
            }

            foreach (FlickrPhoto photo in photos)
            {
                var tile = new Tile();
                tile.HorizontalSize = 4;
                tile.VerticalSize = 3;
                tile.Template = tempFlickr;
                tile.Text = photo.Title;
                tile.Text1 = photo.AuthorName;
                tile.Tag = photo;
                tile.Click += Tile_Click;

                if (!string.IsNullOrEmpty(photo.ThumbnailUri))
                    _downloadQueue.Enqueue(new DownloadItem(photo.ThumbnailUri, tile, false));
                if (!string.IsNullOrEmpty(photo.AuthorBuddyIconUri))
                    _downloadQueue.Enqueue(new DownloadItem(photo.AuthorBuddyIconUri, tile, true));


                tiles.Add(tile);
            }

            flickrTiles.EndUpdate();
        }

        void ShowErrorTile()
        {
            _downloadQueue.Clear();
            try
            {
                TileCollection tiles = flickrTiles.Groups[0].Tiles;
                flickrTiles.BeginUpdate();
                tiles.Clear(true);

                var tile = new Tile();
                tile.HorizontalSize = 4;
                tile.VerticalSize = 2;
                tile.Template = tempError;
                tile.Click += ErrorTile_Click;
                tiles.Add(tile);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            

            flickrTiles.EndUpdate();
        }

        void ErrorTile_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_lastError, "Flickr Viewer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        void setTagButton_Click(object sender, EventArgs e)
        {
            flickrTiles.Focus();
            _tags = tagBox.Text;
            LoadPhotos(false);
        }

        void tagBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 13)
            {
                setTagButton_Click(sender, EventArgs.Empty);
                e.Handled = true;
            }
            else if ((int)e.KeyChar == 27)
            {
                flickrTiles.Focus();
                e.Handled = true;
            }
        }

        void refreshButton_Click(object sender, EventArgs e)
        {
            flickrTiles.Focus();
            LoadPhotos(false);
        }

        void loadNewButton_Click(object sender, EventArgs e)
        {
            flickrTiles.Focus();
            LoadPhotos(_lastError == null);
        }

        void Tile_Click(object sender, EventArgs e)
        {
            Tile tile = sender as Tile;
            if (tile != null)
            {
                FlickrPhoto photo = (FlickrPhoto)tile.Tag;
                string uri = photo.ContentUri;
                if (!string.IsNullOrEmpty(uri))
                {
                    pictureBox.Image = pictureBox.InitialImage;
                    pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
                    imgPanel.Visible = true;
                    imgPanel.BringToFront();
                    titleLabel.Text = photo.Title;
                    authorLabel.Text = photo.AuthorName;
                    waitLabel.Visible = true;
                    pictureBox.LoadAsync(uri);
                    tagBox.Enabled = false;
                    setTagButton.Enabled = false;
                    refreshButton.Enabled = false;
                    loadNewButton.Enabled = false;
                    flickrTiles.Enabled = false;
                    backButton.Enabled = true;
                    this.Focus();
                }
            }
        }

        void pictureBox_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            waitLabel.Visible = false;
        }

        void backButton_Click(object sender, EventArgs e)
        {
            if (imgPanel.Visible)
            {
                tagBox.Enabled = true;
                setTagButton.Enabled = true;
                refreshButton.Enabled = true;
                loadNewButton.Enabled = true;
                flickrTiles.Enabled = true;
                imgPanel.Visible = false;
                flickrTiles.Focus();
            }
            backButton.Enabled = false;
        }

        void ViewerForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Back)
            {
                backButton_Click(sender, EventArgs.Empty);
            }
        }
    }
}

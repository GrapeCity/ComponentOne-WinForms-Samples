using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.DataCollection;

namespace ControlExplorer.DataCollection
{
    public partial class YouTubeChannels : ControlExplorer.C1DemoForm
    {
        private ObservableCollection<YouTubeVideo> _videos;
        // collection view for grouping
        private C1DataCollection<YouTubeVideo> _collectionView;

        public YouTubeChannels()
        {
            InitializeComponent();
            c1FlexGrid1.Tree.Column = 0;
            c1FlexGrid1.Tree.Style = C1.Win.C1FlexGrid.TreeStyleFlags.Symbols;
            c1FlexGrid1.Cols[2].StyleNew.WordWrap = true;
            c1FlexGrid1.Cols[0].Width = 20;
            c1FlexGrid1.Cols[1].Width = 120;
            c1FlexGrid1.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Nodes;
            c1FlexGrid1.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            c1FlexGrid1.DoubleClick += C1FlexGrid1_DoubleClick;
            LoadData();
        }

        private void C1FlexGrid1_DoubleClick(object sender, EventArgs e)
        {
            // open selected video in default browser
            var row = c1FlexGrid1.RowSel;
            if (row >= 0)
            {
                var video = c1FlexGrid1.Rows[row].UserData as YouTubeVideo;
                if (video != null)
                {
                    System.Diagnostics.Process.Start(video.Link);
                }
            }
        }

        internal async void LoadData()
        {
            await UpdateVideos();
        }

        private async Task UpdateVideos()
        {
            try
            {
                // Load video collection
                _videos = new ObservableCollection<YouTubeVideo>((await YouTubeCollectionView.LoadVideosAsync("WinForms", "relevance", null, 50)).Item2);
                // wrap the loaded collection to DataCollection
                _collectionView = new C1DataCollection<YouTubeVideo>(_videos);
                // grouping by ChannelTitle
                // Note: grouping is async
                await _collectionView.GroupAsync(v => v.ChannelTitle);
                // fill FlexGrid with loaded data
                c1FlexGrid1.Rows.RemoveRange(1, c1FlexGrid1.Rows.Count - 1);
                PopulateItemsAndGroups(_collectionView as IDataCollection<object>);
            }
            catch (Exception e)
            {
                System.Diagnostics.Trace.WriteLine(e.Message);
            }
        }

        private void PopulateItemsAndGroups(IDataCollection<object> items)
        {
            // fill unbound data tree
            foreach (var obj in items)
            {
                var group = obj as IDataCollectionGroup<object, object>;
                if (group != null)
                {
                    // create node row
                    var node = c1FlexGrid1.Rows.AddNode(0);
                    node.Row[1] = group.Group;
                    node.Row.Style = c1FlexGrid1.Styles.Alternate;
                    PopulateItemsAndGroups(group.ToDataCollection<YouTubeVideo>());
                }
                else
                {
                    // create standard unbound row
                    var item = obj as YouTubeVideo;
                    int row = c1FlexGrid1.Rows.Count;
                    c1FlexGrid1.Rows.Add();
                    c1FlexGrid1.Rows[row].Style = c1FlexGrid1.Styles.Normal;
                    c1FlexGrid1.Rows[row].UserData = item;
                    c1FlexGrid1[row, 2] = item.Title + "\r\n--\r\n" + item.Description;
                    LoadImage(item.Thumbnail, row, 1);
                }
            }
        }

        private async void LoadImage(string requestUri, int row, int col)
        {
            // show video thumbnail in the specified row and column 
            try
            {
                var client = new HttpClient();
                var response = await client.GetAsync(requestUri);
                var stream = await response.Content.ReadAsStreamAsync();
                var image = Image.FromStream(stream);
                c1FlexGrid1.SetCellImage(row, col, image);
                c1FlexGrid1.Rows[row].Height = image.Height;
            }
            catch { }
        }
    }

    public class YouTubeCollectionView : C1CursorDataCollection<YouTubeVideo>
    {
        private string _q;

        public YouTubeCollectionView()
        {
            PageSize = 20;
        }

        public int PageSize { get; set; }

        public override bool HasMoreItems
        {
            get { return _q != null && base.HasMoreItems; }
        }

        private SemaphoreSlim _searchSemaphore = new SemaphoreSlim(1);

        public async Task SearchAsync(string q)
        {
            //Sets the filter string and wait the Delay time.
            _q = q;
            await Task.Delay(500);
            if (_q != q)//If the text changed means there was another keystroke.
                return;
            try
            {
                await _searchSemaphore.WaitAsync();

                if (_q != q)//If the text changed means there was another keystroke.
                    return;

                await RefreshAsync();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            finally
            {
                _searchSemaphore.Release();
            }
        }

        protected override async Task<Tuple<string, IReadOnlyList<YouTubeVideo>>> GetPageAsync(int startingIndex, string pageToken, int? count = null, IReadOnlyList<C1.DataCollection.SortDescription> sortDescriptions = null, FilterExpression filterExpresssion = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return await LoadVideosAsync(_q, "date", pageToken, PageSize, cancellationToken);
        }

        public static async Task<Tuple<string, IReadOnlyList<YouTubeVideo>>> LoadVideosAsync(string q, string orderBy, string pageToken, int maxResults, CancellationToken cancellationToken = default(CancellationToken))
        {
            q = q ?? "";

            var youtubeUrl = string.Format("https://www.googleapis.com/youtube/v3/search?part=snippet&type=video&q={0}&order={1}&maxResults={2}{3}&key={4}", Uri.EscapeUriString(q), orderBy, maxResults, string.IsNullOrWhiteSpace(pageToken) ? "" : "&pageToken=" + pageToken, "AIzaSyCtwKIq-Td5FBNOlvOiWEJaClRBDyq-ZsU");

            var client = new HttpClient();
            var response = await client.GetAsync(youtubeUrl, cancellationToken);
            if (response.IsSuccessStatusCode)
            {
                var videos = new List<YouTubeVideo>();
                var serializer = new DataContractJsonSerializer(typeof(YouTubeSearchResult));
                var result = serializer.ReadObject(await response.Content.ReadAsStreamAsync()) as YouTubeSearchResult;
                foreach (var item in result.Items)
                {
                    var video = new YouTubeVideo()
                    {
                        Title = item.Snippet.Title,
                        Description = item.Snippet.Description,
                        Thumbnail = item.Snippet.Thumbnails.Default.Url,
                        Link = "http://www.youtube.com/watch?v=" + item.Id.VideoId,
                        ChannelTitle = item.Snippet.ChannelTitle,
                        PublishedAt = DateTime.Parse(item.Snippet.PublishedAt),
                    };
                    videos.Add(video);
                }
                return new Tuple<string, IReadOnlyList<YouTubeVideo>>(result.NextPageToken, videos);
            }
            else
            {
                throw new Exception(await response.Content.ReadAsStringAsync());
            }

        }
    }

    [DataContract]
    public class YouTubeSearchResult
    {
        [DataMember(Name = "nextPageToken")]
        public string NextPageToken { get; set; }
        [DataMember(Name = "items")]
        public YouTubeSearchItemResult[] Items { get; set; }
    }

    [DataContract]
    public class YouTubeSearchItemResult
    {
        [DataMember(Name = "id")]
        public YouTubeVideoId Id { get; set; }
        [DataMember(Name = "snippet")]
        public YouTubeSnippet Snippet { get; set; }
    }

    [DataContract]
    public class YouTubeVideoId
    {
        [DataMember(Name = "videoId")]
        public string VideoId { get; set; }
    }

    [DataContract]
    public class YouTubeSnippet
    {
        [DataMember(Name = "title")]
        public string Title { get; set; }
        [DataMember(Name = "description")]
        public string Description { get; set; }
        [DataMember(Name = "thumbnails")]
        public YouTubeThumbnails Thumbnails { get; set; }
        [DataMember(Name = "channelTitle")]
        public string ChannelTitle { get; set; }
        [DataMember(Name = "publishedAt")]
        public string PublishedAt { get; set; }
    }

    [DataContract]
    public class YouTubeThumbnails
    {
        [DataMember(Name = "default")]
        public YouTubeThumbnail Default { get; set; }
        [DataMember(Name = "medium")]
        public YouTubeThumbnail Medium { get; set; }
        [DataMember(Name = "high")]
        public YouTubeThumbnail High { get; set; }
    }

    [DataContract]
    public class YouTubeThumbnail
    {
        [DataMember(Name = "url")]
        public string Url { get; set; }
    }

    [DataContract]
    public class YouTubeVideo
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Thumbnail { get; set; }
        public string Link { get; set; }
        public string ChannelTitle { get; set; }
        public DateTime PublishedAt { get; set; }

        public string PublishedDay
        {
            get
            {
                return $"{PublishedAt.Date:D}";
            }
        }
    }

}

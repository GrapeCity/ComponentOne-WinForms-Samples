using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using C1.DataCollection;
using C1.Win.DataCollection;
using C1DataCollection101.Resources;

namespace C1DataCollection101.View
{
    public partial class Grouping : UserControl
    {
        Menu _owner;
        private ObservableCollection<YouTubeVideo> _videos;
        private C1DataCollection<YouTubeVideo> _dataCollection;

        public Grouping()
        {
            InitializeComponent();
            lblTitle.Text = AppResources.GroupingTitle;
        }

        internal async void ShowPage(Menu owner)
        {
            _owner = owner;
            await UpdateVideos();
        }

        private async Task UpdateVideos()
        {
            try
            {
                listView1.Visible = false;
                progressBar1.Visible = true;
                _videos = new ObservableCollection<YouTubeVideo>((await YouTubeDataCollection.LoadVideosAsync("WinForms", "relevance", null, 50)).Item2);
                _dataCollection = new C1DataCollection<YouTubeVideo>(_videos);
                await _dataCollection.GroupAsync(v => v.ChannelTitle);
                listView1.SetItemsSource(_dataCollection, "Title", "Thumbnail");
                listView1.Visible = true;
            }
            catch
            {
                MessageBox.Show(AppResources.InternetConnectionError, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                progressBar1.Visible = false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _owner.SelectedSampleViewType = -1;
        }
    }
}

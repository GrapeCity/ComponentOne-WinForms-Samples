using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using C1.DataCollection;
using C1.Win.DataCollection;
using C1DataCollection101.Resources;

namespace C1DataCollection101.View
{
    public partial class Filtering : UserControl
    {
        private C1DataCollection<YouTubeVideo> _dataCollection;
        Menu _owner;

        public Filtering()
        {
            InitializeComponent();
            lblTitle.Text = AppResources.FilteringTitle;
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
                progressBar1.Visible = true;
                youTubeListView1.Visible = false;
                var _videos = new ObservableCollection<YouTubeVideo>((await YouTubeDataCollection.LoadVideosAsync("WinForms", "relevance", null, 50)).Item2);
                _dataCollection = new C1DataCollection<YouTubeVideo>(_videos);
                youTubeListView1.SetItemsSource(_dataCollection, "Title");
                youTubeListView1.Visible = true;
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

        private async void filterTextBox_TextChanged(object sender, EventArgs e)
        {
            await _dataCollection.FilterAsync(filterTextBox.Text);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _owner.SelectedSampleViewType = -1;
        }
    }
}

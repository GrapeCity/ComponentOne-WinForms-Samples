using FlexGridExplorer.Component.SideMenu;
using FlexGridExplorer.Core;
using FlexGridExplorer.Properties;
using FlexGridExplorer.Utility;

namespace FlexGridExplorer
{
    public partial class Form1 : Form
    {
        #region Private Variables
        List<ItemInfo> _samples;
        ItemInfo _selectedSample;

        ISampleLoader _sampleLoader;
        ITileImageGenerator _imageGenerator;
        ISampleNavigator _navigator; 
        #endregion

        public Form1()
        {
            InitializeComponent();

            this.Text = StringsEN.SampleTitle;
            Init();
            LoadSampleData();

            sideBar1.SelectionChanged += OnSideBarSelectionChanged;
            Application.AddMessageFilter(new FocusDismissalFilter(sideBar1));
        }

        private void Init()
        {
            _sampleLoader = new SampleLoader();
            _imageGenerator = new TileImageGenerator();
            _navigator = new SampleNavigator(sampleHost1, tileControl1, sideBar1, _imageGenerator);
        }
        private void LoadSampleData()
        {
            _samples = _sampleLoader.LoadSamples();
            sideBar1.Samples = _samples;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var defaultSample = _samples?.FirstOrDefault();
            if (defaultSample != null)
            {
                _navigator.ShowSample(defaultSample);
            }
        }
        private void OnSideBarSelectionChanged(object sender, SideBarEventArgs e)
        {
            if (e.SelectedSample == null || _selectedSample == e.SelectedSample)
                return;

            _selectedSample = e.SelectedSample;

            Action navigationAction = _selectedSample.Depth switch
            {
                0 => () => _navigator.ShowSample(_selectedSample),

                1 => () => _navigator.ShowTiles(_selectedSample),

                _ => () =>
               {
                   var targetSample = _selectedSample.Items?.FirstOrDefault();
                   if (targetSample != null)
                   {
                       _navigator.ShowTiles(targetSample);
                   }
               }
                ,
            };
            navigationAction();
        }
    }
}

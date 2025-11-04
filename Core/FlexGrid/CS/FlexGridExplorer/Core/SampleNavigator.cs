using FlexGridExplorer.Component;
using FlexGridExplorer.Component.SideMenu;
using FlexGridExplorer.Component.Tile;
using FlexGridExplorer.Utility;

namespace FlexGridExplorer.Core
{
    /// <summary>
    /// Coordinates navigation and view transitions between the sidebar, tile view, and sample viewer
    /// </summary>
    public class SampleNavigator : ISampleNavigator
    {
        #region Private Variables
        readonly SampleViewer _sampleViewer;
        readonly TileControl _tileControl;
        readonly SideBar _sideBar;
        readonly ITileImageGenerator _imageGenerator;
        bool _firstUpdate = true;
        #endregion

        public SampleNavigator(SampleViewer sampleViewer, TileControl tileControl, SideBar sideBar, ITileImageGenerator imageGenerator)
        {
            _sampleViewer = sampleViewer;
            _tileControl = tileControl;
            _sideBar = sideBar;
            _imageGenerator = imageGenerator;
        }

        public void ShowSample(ItemInfo sample)
        {
            _sampleViewer.Sample = sample;
            _sampleViewer.LoadSample();
            ChangeView(false);
        }

        public void ShowTiles(ItemInfo sample)
        {
            _tileControl.Groups.Clear();

            if (sample.Depth == 1)
            {
                var group = new TileGroup(sample.Name);
                foreach (var item in sample.Items)
                    AddToGroup(item, group);
                _tileControl.Groups.Add(group);
            }
            else
            {
                foreach (var item in sample.Items.Where(s => !s.Items.IsNullOrEmpty()))
                {
                    var tileGroup = new TileGroup(item.Name);
                    foreach (var subItem in item.Items)
                        AddToGroup(subItem, tileGroup);
                    _tileControl.Groups.Add(tileGroup);
                }

                var leaves = sample.Items.Where(s => s.Items.IsNullOrEmpty()).ToList();
                if (leaves.Count > 0)
                {
                    var others = new TileGroup("Others");
                    foreach (var leaf in leaves)
                        AddToGroup(leaf, others);
                    _tileControl.Groups.Add(others);
                }
            }

            if (_tileControl.Groups.Count == 1)
                _tileControl.Groups[0].Name = string.Empty;

            ChangeView(true);
            UpdateImages();
        }

        public void ChangeView(bool showTiles)
        {
            _sampleViewer.Visible = !showTiles;
            _tileControl.Visible = showTiles;
        }

        private void AddToGroup(ItemInfo sample, TileGroup group)
        {
            var tile = new TileCard()
            {
                Text = sample.Name,
                Tag = sample,
                Description = string.IsNullOrWhiteSpace(sample.ShortDescription) ? sample.LongDescription.Trim() : sample.LongDescription.Trim()
            };
            tile.Click += (s, e) => _sideBar.SelectSample(sample);
            group.Tiles.Add(tile);
        }

        private void UpdateImages()
        {
            foreach (var group in _tileControl.Groups)
            {
                foreach (var tile in group.Tiles)
                {
                    var sample = tile.Tag as ItemInfo;
                    var size = tile.ImageSize;

                    if (_firstUpdate)
                    {
                        tile.Image = _imageGenerator.GetImage(sample, size);
                        _firstUpdate = false;
                    }
                    else
                    {
                        Task.Run(() =>
                       {
                           var img = _imageGenerator.GetImage(sample, size);
                           if (_tileControl.IsHandleCreated)
                               _tileControl.BeginInvoke(() => tile.SetImage(img));
                       });
                    }
                }
            }
        }
    }
}

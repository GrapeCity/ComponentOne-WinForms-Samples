using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using BaseExplorer.Components;
using BaseExplorer.Model;
using BaseExplorer.Utilities;
using C1.Framework;

namespace BaseExplorer.Core
{
    public class Explorer
    {
        private SampleManager _sampleManager;
        private SideBar _sideBar;
        private SampleHost _sampleHost;
        private TileControl _tileControl;
        private static Explorer _default;
        private string _entryAssembly;
        private Dictionary<string, Image> imgDict = new Dictionary<string, Image>();

        public bool IsInitialized
        {
            get; private set;
        }

        public SampleManager Manager
        {
            get { return _sampleManager; }
            set { _sampleManager = value; }
        }

        public static Explorer Instance
        {
            get
            {
                if (_default == null)
                    _default = new Explorer();
                return _default;
            }
        }

        private Explorer()
        {

        }

        /// <summary>
        /// Initialize the Explorer with the components
        /// </summary>
        /// <param name="filePath">Location of the Explorer Configuration</param>
        /// <param name="sideBar">SideBar displayed in the explorer</param>
        /// <param name="tileControl">TileControl displayed in the explorer</param>
        /// <param name="host">SampleHost displayed in the explorer</param>
        public static void Init(string filePath, SideBar sideBar, SampleHost host, TileControl tileControl)
        {
            Instance._sampleManager = new SampleManager(filePath);
            Instance._sideBar = sideBar;
            Instance._tileControl = tileControl;
            Instance._sampleHost = host;
            sideBar.Samples = Instance.Manager.SampleCollection.Samples.ToList();
            Instance.IsInitialized = true;
        }

        /// <summary>
        /// Changes the view to display the SampleHost 
        /// </summary>
        /// <param name="sample">SampleItem to show in the SampleHost</param>
        public void ShowSample(SampleItem sample, string theme)
        {
            _sampleHost.Sample = sample;
            _sampleHost.Theme = theme;
            _sampleHost.LoadSample();
            ChangeView(false);
        }

        /// <summary>
        /// Changes the view to display the Tiles 
        /// </summary>
        /// <param name="sample"></param>
        public void ShowTiles(SampleItem sample, string theme)
        {
            _tileControl.Groups.Clear();
            _tileControl.Theme = theme;
            if (sample.Depth == 1)
            {
                var group = new TileGroup(sample.Name, theme);
                foreach (var item in sample.Items)
                    AddToGroup(item, group, theme);
                _tileControl.Groups.Add(group);
            }
            else
            {
                foreach (var item in sample.Items.Where(s => !s.Items.IsNullOrEmpty()))
                {
                    var tileGroup = new TileGroup(item.Name, theme);
                    foreach (var subItem in item.Items)
                        AddToGroup(subItem, tileGroup, theme);
                    _tileControl.Groups.Add(tileGroup);
                }

                //Create a single group for samples that are the only child of their parent
                var leaves = sample.Items.Where(s => s.Items.IsNullOrEmpty()).ToList();
                if (leaves.Count > 0)
                {
                    var others = new TileGroup("Others", theme);
                    foreach (var leaf in leaves)
                        AddToGroup(leaf, others, theme);
                    _tileControl.Groups.Add(others);

                }
            }
            if (_tileControl.Groups.Count == 1)
                _tileControl.Groups[0].Name = string.Empty;

            _tileControl.ApplyTheme();

            ChangeView(true);
            UpdateImages();
        }

        private void AddToGroup(SampleItem sample, TileGroup group, string theme)
        {
            var tile = new TileCard()
            {
                Text = sample.Name,
                Image = Properties.Resources.C1_WaterMark,
                Tag = sample,
                Theme = theme,
                Description = string.IsNullOrWhiteSpace(sample.Summary) ? sample.Description.Trim() : sample.Summary.Trim()
            };
            tile.Click += (s, e) => _sideBar.SelectSample(sample);
            group.Tiles.Add(tile);
        }

        bool first = true;

        /// <summary>
        /// Get the tile images asynchronously
        /// </summary>
        private void UpdateImages()
        {
            foreach (var group in _tileControl.Groups)
            {
                foreach (var tile in group.Tiles)
                {
                    if (first)
                    {
                        tile.Image = GetImage(tile.Tag as SampleItem, tile.ImageSize);
                        first = false;
                    }
                    else
                    {
                        Task.Factory.StartNew(() =>
                        {
                            var img = GetImage(tile.Tag as SampleItem, tile.ImageSize);
                            tile.SetImage(img);
                        });
                    }
                }
            }
        }

        private Image GetImage(SampleItem sample, Size imageSize)
        {
            Image image;
            try
            {
                string key = string.Format("{0}_{1}_{2}", sample.TypeName, imageSize.Width, imageSize.Height);
                if (!imgDict.TryGetValue(key, out image))
                {
                    if (string.IsNullOrEmpty(_entryAssembly))
                        _entryAssembly = Assembly.GetEntryAssembly().FullName;
                    var fullName = string.Format("{0},{1}", sample.TypeName, _entryAssembly);
                    Type t = Type.GetType(fullName);
                    if (t == null)
                        image = Properties.Resources.C1_WaterMark;
                    else
                    {
                        using (var view = Activator.CreateInstance(t) as BaseSample)
                        {
                            image = view.GetImage();
                        }
                    }
                    if (image != null)
                    {
                        image = image.GetThumbnailImage(imageSize.Width, imageSize.Height, null, IntPtr.Zero);
                        if(t != null)
                            imgDict.Add(key, image);
                    }
                }
            }
            catch (Exception)
            {
                image = Properties.Resources.C1_WaterMark;
            }
            return image;
        }

        private void ChangeView(bool showTiles)
        {
            _sampleHost.Visible = !showTiles;
            _tileControl.Visible = showTiles;
        }
    }
}

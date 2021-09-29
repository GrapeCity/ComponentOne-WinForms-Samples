using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BaseExplorer.Components;
using BaseExplorer.Model;
using BaseExplorer.Utilities;

namespace BaseExplorer.Core
{
    public class Explorer
    {
        private SampleManager _sampleManager;
        private SideBar _sideBar;
        private SampleHost _sampleHost;
        private Header _header;
        private TileControl _tileControl;
        private static Explorer _default;
        private string _entryAssembly;

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

        public SynchronizationContext SyncContext
        {
            get; private set;
        }

        private Explorer()
        {

        }

        /// <summary>
        /// Initialize the Explorer with the components
        /// </summary>
        /// <param name="filePath">Location of the Explorer Configuration</param>
        /// <param name="sideBar">SideBar displayed in the explorer</param>
        /// <param name="header">Header displayed in the explorer</param>
        /// <param name="tileControl">TileControl displayed in the explorer</param>
        /// <param name="host">SampleHost displayed in the explorer</param>
        public static void Init(string filePath, SideBar sideBar, Header header, TileControl tileControl, SampleHost host)
        {
            Instance._sampleManager = new SampleManager(filePath);
            Instance._header = header;
            Instance._sideBar = sideBar;
            Instance._tileControl = tileControl;
            Instance._sampleHost = host;
            sideBar.Samples = Instance.Manager.SampleCollection.Samples.ToList();
            host.Navigate += (s, e) =>
            {
                SampleItem sampleToNavigate = null;
                switch (e.NavigationDirection)
                {
                    case Direction.Next:
                        sampleToNavigate = Instance.Manager.Next;
                        break;
                    case Direction.Previous:
                        sampleToNavigate = Instance.Manager.Previous;
                        break;
                }
                Instance._sideBar.SelectSample(sampleToNavigate);
            };
            Instance.SyncContext = SynchronizationContext.Current;
            Instance.IsInitialized = true;
        }

        /// <summary>
        /// Changes the view to display the SampleHost 
        /// </summary>
        /// <param name="sample">SampleItem to show in the SampleHost</param>
        public void ShowSample(SampleItem sample)
        {
            _sampleHost.LoadSample(sample);
            _header.SampleTitle = sample.Title;
            ChangeView(false);
        }

        /// <summary>
        /// Changes the view to display the Tiles 
        /// </summary>
        /// <param name="sample"></param>
        public void ShowTiles(SampleItem sample)
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

                //Create a single group for samples that are the only child of their parent
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

        /// <summary>
        /// Deletes the tile images that were added to the temp folder
        /// </summary>
        public void Cleanup()
        {
            try
            {
                if (Directory.Exists(imagesPath))
                    Directory.Delete(imagesPath, true);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }

        }
        private void AddToGroup(SampleItem sample, TileGroup group)
        {
            var tile = new TileView()
            {
                Text = sample.Name,
                Image = Properties.Resources.C1_WaterMark,
                Tag = sample
            };
            tile.Click += (s, e) => _sideBar.SelectSample(sample);
            group.Tiles.Add(tile);
        }

        /// <summary>
        /// Get the tile images asynchronously
        /// </summary>
        private void UpdateImages()
        {
            foreach (var group in _tileControl.Groups)
            {
                foreach (var tile in group.Tiles)
                    {
                    Task.Factory.StartNew(() =>
                    {
                        var img = GetImage(tile.Tag as SampleItem);
                        Explorer.Instance.SyncContext.Post((s) => tile.Image = img, null);
                    });
                }
            }
        }

        string imagesPath = Path.Combine(Path.GetTempPath(), "FlexChartExplorer", "Images");
        private Image GetImage(SampleItem sample)
        {
            Image image = null;
            try
            {
                if (!Directory.Exists(imagesPath))
                    Directory.CreateDirectory(imagesPath);

                var fileName = Path.Combine(imagesPath, string.Format("{0}.png", sample.TypeName));
                if (File.Exists(fileName))
                {
                    using (var stream = new FileStream(fileName, FileMode.Open))
                    {
                        image = Image.FromStream(stream);
                    }
                }
                else
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
                    image.Save(fileName);
                }
            }
            catch (Exception ex)
            {
                image = Properties.Resources.C1_WaterMark;
                System.Diagnostics.Debug.WriteLine(ex.Message);
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

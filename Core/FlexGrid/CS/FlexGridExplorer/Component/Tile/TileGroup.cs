using FlexGridExplorer.Utility;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace FlexGridExplorer.Component.Tile
{
    /// <summary>
    /// Represents a group container that holds and manages a collection of <see cref="TileCard"/> elements
    /// within a <see cref="TileControl"/>.
    /// </summary>
    public partial class TileGroup : UserControl
    {
        #region Private Variables
        Color _hoverColor;
        #endregion

        #region Public Methods
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new string Name
        {
            get { return lblGroupName.Text; }
            set { lblGroupName.Text = value; }
        }

        public ObservableCollection<TileCard> Tiles { get; private set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color HoverColor
        {
            get
            {
                return TileControl != null ? TileControl.HoverColor : _hoverColor;
            }
            set
            {
                if (_hoverColor != value)
                {
                    _hoverColor = value;
                }
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public TileControl TileControl { get; set; }

        public TileGroup()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            Tiles = new ObservableCollection<TileCard>();
            Tiles.CollectionChanged += OnTilesCollectionChanged;
        }

        public TileGroup(string groupName) : this()
        {
            Name = groupName;
            ForeColor = Color.Black;
        }
        #endregion

        private void OnTilesCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {

            if (e.NewItems != null && e.NewItems.Count > 0)
            {
                foreach (TileCard newItem in e.NewItems)
                {
                    newItem.TileGroup = this;
                    flowLayoutPanel1.Controls.Add(newItem);
                }
            }
            if (e.OldItems != null && e.OldItems.Count > 0)
            {
                foreach (TileCard oldItem in e.OldItems)
                    flowLayoutPanel1.Controls.Remove(oldItem);
            }
            if (e.Action == NotifyCollectionChangedAction.Reset)
                flowLayoutPanel1.Controls.Clear(true);

        }

        public override Size GetPreferredSize(Size proposedSize)
        {
            var size = proposedSize;
            if (Parent != null && Tiles.Count > 0)
            {
                var tile = Tiles.First();
                var tileHeight = tile.Height + tile.Margin.Vertical + tile.Padding.Vertical;
                var tileWidth = tile.Width + tile.Margin.Horizontal + tile.Padding.Horizontal;
                var scrollWidth = (Parent as Panel).VerticalScroll.Visible ? SystemInformation.VerticalScrollBarWidth : 0;
                size.Width = Parent.Width - Parent.Margin.Horizontal - Parent.Padding.Horizontal - scrollWidth;
                var colsCount = size.Width / tileWidth;
                var rowCount = Math.Ceiling((double)Tiles.Count / colsCount);
                size.Height = (int)(lblGroupName.Height + tileHeight * rowCount);
            }
            return size;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using BaseExplorer.Utilities;
using BaseExplorer.Core;

namespace BaseExplorer.Components
{
    public partial class TileGroup : UserControl
    {
        public new string Name
        {
            get { return lblGroupName.Text; }
            set { lblGroupName.Text = value; }
        }

        public ObservableCollection<TileCard> Tiles { get; private set; }

        private Color _hoverColor;
        private string _theme;

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

        public TileControl TileControl { get; set; }
        public string Theme
        {
            get
            {
                return _theme;
            }
            set
            {
                if (_theme != value)
                {
                    _theme = value;
                    ApplyTheme();
                }
                else
                {
                    _theme = value;
                }
            }
        }
        //ApplyTheme()

        public TileGroup()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            Tiles = new ObservableCollection<TileCard>();
            Tiles.CollectionChanged += OnTilesCollectionChanged;
        }

        public TileGroup(string groupName, string theme) : this()
        {
            Name = groupName;
            ForeColor = Color.Black;
            Theme = theme;
        }

        public void ApplyTheme()
        {
            ColorPanels(Theme == "Office365White" ? SkinManager.LightBackColor : SkinManager.Office365LightBlack);
            lblGroupName.ForeColor = Theme == "Office365White" ? Color.Black : Color.White;
            
            foreach (TileCard control in flowLayoutPanel1.Controls)
            {
                control.Theme = Theme;
            }
        }

        private void ColorPanels(Color color)
        {
            this.BackColor = color;
            panel1.BackColor = color;
            panel2.BackColor = color;
            lblGroupName.BackColor = color;
            flowLayoutPanel1.BackColor = color;
        }

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
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Reset)
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

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

namespace BaseExplorer.Components
{
    public partial class TileControl : UserControl
    {
        public ObservableCollection<TileGroup> Groups { get; private set; }

        private Color _hoverColor;
        public Color HoverColor
        {
            get
            { return _hoverColor; }
            set
            {
                if (_hoverColor != value)
                {
                    _hoverColor = value;
                }
            }
        }

        public TileControl()
        {
            InitializeComponent();
            Groups = new ObservableCollection<TileGroup>();
            Groups.CollectionChanged += OnGroupsCollectionChanged;
        }

        private void OnGroupsCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.SuspendLayout();
            if (e.NewItems != null && e.NewItems.Count > 0)
            {
                foreach (TileGroup newItem in e.NewItems)
                {
                    newItem.TileControl = this;
                    flowLayoutPanel1.Controls.Add(newItem);
                }
            }

            if (e.OldItems != null && e.OldItems.Count > 0)
            {
                foreach (TileGroup oldItem in e.OldItems)
                    flowLayoutPanel1.Controls.Remove(oldItem);
            }

            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Reset)
                flowLayoutPanel1.Controls.Clear(true);
            this.ResumeLayout();
        }
    }
}

using FlexGridExplorer.Utility;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace FlexGridExplorer.Component.Tile
{
    /// <summary>
    /// Represents a container control that organizes and displays a collection of <see cref="TileGroup"/> elements.
    /// </summary>
    public partial class TileControl : UserControl
    {
        #region Private Varaibles

        Color _hoverColor; 
        #endregion

        #region Public Methods
        public ObservableCollection<TileGroup> Groups { get; private set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            Groups = new ObservableCollection<TileGroup>();
            Groups.CollectionChanged += OnGroupsCollectionChanged;
        } 
        #endregion


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

        //to remove the flickering effect
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
    }
}

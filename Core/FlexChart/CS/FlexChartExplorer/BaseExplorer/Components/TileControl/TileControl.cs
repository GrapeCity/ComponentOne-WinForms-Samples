using System.Drawing;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using BaseExplorer.Utilities;
using BaseExplorer.Core;
using static C1.Util.Win.Win32;
using System.ComponentModel;

namespace BaseExplorer.Components
{
    public partial class TileControl : UserControl
    {
        public ObservableCollection<TileGroup> Groups { get; private set; }

        private Color _hoverColor;
        private string _theme = "Office365White";

        [DefaultValue(typeof(Color), "Empty")]
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

        [DefaultValue("Office365White")]
        public string Theme 
        {
            get
            {
                return _theme;
            }
            set
            {
                if (_theme != value) { 
                    _theme = value;
                    ApplyTheme();
                }
                else
                {
                    _theme = value;
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
            ApplyTheme();
        }

        public void ApplyTheme()
        {
            ColorPanels(Theme == "Office365Black" ? SkinManager.Office365LightBlack : SkinManager.LightBackColor);
            foreach(TileGroup control in flowLayoutPanel1.Controls)
            {
                control.Theme = Theme;
            }
        }

        private void ColorPanels(Color color)
        {
            this.BackColor = color;
            tableLayoutPanel1.BackColor = color;
            flowLayoutPanel1.BackColor = color;
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

using C1.Framework;
using C1.Win.Input;
using FlexGridExplorer.Utility;
using System.ComponentModel;

namespace FlexGridExplorer.Component.SideMenu
{
    /// <summary>
    /// Represents the collapsible sidebar navigation component used to browse and select FlexGrid samples.
    /// </summary>
    public partial class SideBar : UserControl
    {
        #region Private Variables
        C1Button _searchIcon;
        List<ItemInfo> _samples;
        C1Icon _hamburIconOriginal;
        bool _collapsed = false;
        const int ExpandedWidth = 415;
        const int CollapsedWidth = 58;
        #endregion

        #region Public Methods
        public event EventHandler<SideBarEventArgs> SelectionChanged;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool Collapsed
        {
            get { return _collapsed; }
            set
            {
                if (_collapsed != value)
                {
                    _collapsed = value;
                    ExpandCollapseSidebar();
                }
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<ItemInfo> Samples
        {
            get { return _samples; }
            set
            {
                if (value != null)
                {
                    _samples = value;
                    PrepareSideBar();
                }
            }
        }
        public SideBar()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.None;
            InitializeInvisibleSearchIcon();
            this.Load += SideBar_Load;
            searchBar1.TextChangedEvent += SearchBar_TextChanged;
            btnHambur.MouseDown += HamburgerButton_MouseDown;
            btnHambur.MouseUp += HamburgerButton_MouseUp;
            _hamburIconOriginal = IconUtils.HamburgurBig;
            btnHambur.Icon = IconUtils.HamburgurBig;
        }

        #endregion

        #region Internal Methods
        internal void SelectSample(ItemInfo sample)
        {
            if (sample != null)
                treeView.SelectedNode = treeView.FindNode(sample.Guid.ToString());
        } 
        #endregion
        #region Private Methods
        private void PrepareSideBar()
        {
            treeView.Nodes.Clear();
            foreach (var sample in _samples)
                CreateNodes(sample, null);
            if (treeView.Nodes.Count > 0)
                treeView.SelectedNode = treeView.Nodes[0];
        }

        private void CreateNodes(ItemInfo item, StackNodeControl parent = null)
        {
            StackNodeControl node;
            if (parent == null)
                node = treeView.Nodes.Add(item.Guid.ToString(), item.Name);
            else
            {
                node = parent.Nodes.Add(item.Guid.ToString(), item.Name);
                node.IsSearchable = true;
                /*
                 * A node can be searched based on the following parameters
                 * 1. Text of the parent node
                 * 2. Name and Title of the node itself
                 * 3. Keywords defined for the parent node
                 * 4. Keywords defined for the node itself
                 */
                node.SearchString = string.Format("{0} {1}", item.Name, item.Parent.Name);
            }
            node.Tag = item;
            node.Status = item.Status;
            if (!item.Items.IsNullOrEmpty())
            {
                foreach (var child in item.Items)
                    CreateNodes(child, node);
            }
            node.IconKey = item.Icon;
            node.Icon = item.Icon == null ? null : IconUtils.GetIcon(item.Icon);
            node.ExpandedIcon = item.Items == null ? null : IconUtils.ChevronUp;
            node.CollapsedIcon = item.Items == null ? null : IconUtils.ChevronDown;
        }
         
        private void InitializeInvisibleSearchIcon()
        {
            _searchIcon = new C1Button();
            _searchIcon.Cursor = Cursors.Hand;
            _searchIcon.Styles.Border = new Thickness(0, 0, 0, 0);
            _searchIcon.Styles.Default.BackColor = SystemColors.ButtonFace;
            _searchIcon.Styles.Hot.BackColor = SkinManager.HoverBackColor;
            _searchIcon.Styles.Hot.BorderColor = SystemColors.HighlightText;
            _searchIcon.Styles.HotPressed.BackColor = SkinManager.HoverBackColor;
            _searchIcon.TabStop = false;
            _searchIcon.Location = new Point(7, 7);
            _searchIcon.Size = new Size(45, 42);
            _searchIcon.Name = "searchIcon";
            _searchIcon.Icon = IconUtils.Search;
            _searchIcon.Click += SearchIcon_Click;
            _searchIcon.Visible = false;
            panel2.Controls.Add(_searchIcon);
        }

        private void SideBar_Load(object sender, EventArgs e)
        {
            treeView.SelectionChanged += OnSelectionChanged;
        }
        private void OnSelectionChanged(object sender, StackNodeEventArgs e)
        {
            ItemInfo sample = e.Node.Tag as ItemInfo;
            if (sample != null)
            {
                SelectionChanged(this, new SideBarEventArgs(sample));
            }
        }

        private void SearchBar_TextChanged(object sender, string searchText)
        {
            this.Cursor = Cursors.Default;
            treeView.FilterString = searchText;
        }

        private void SearchIcon_Click(object sender, EventArgs e)
        {
            Collapsed = !_collapsed;
            if (sender == _searchIcon && !_collapsed)
            {
                searchBar1.Focus();
                searchBar1.Controls["textBoxExSearch"]?.Focus();
            }
        }
        private void HamburgerButton_MouseUp(object sender, MouseEventArgs e)
        {
            Collapsed = !_collapsed;
            btnHambur.Icon = _hamburIconOriginal;
        }
        private void HamburgerButton_MouseDown(object sender, MouseEventArgs e)
        {
            btnHambur.Icon = IconUtils.HamburgurSmall;
        }
        private void ExpandCollapseSidebar()
        {
            _searchIcon.Visible = !_searchIcon.Visible;
            searchBar1.Visible = !searchBar1.Visible;
            treeView.Collapsed = _collapsed;
            this.Width = _collapsed ? CollapsedWidth : ExpandedWidth;
        }
        #endregion
    } 
}
using C1.Framework;
using C1.Win.Input;
using ControlExplorer.Core;
using ControlExplorer.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ControlExplorer.Controls
{
    public partial class SideBar : UserControl
    {
        #region Private Variables
        private C1Button _searchIcon;
        private List<ItemInfo> _samples;
        private C1Icon _hamburIconOriginal;
        private bool _collapsed = false;
        private const int _expandedWidth = 415;
        private const int _collapsedWidth = 54;
        #endregion

        #region Public Methods
        public event EventHandler<SideBarEventArgs> SelectionChanged;

        [DefaultValue(false)]
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
            searchBar1.TextChangedEvent += SearchBar_TextChanged;
            this.Load += SideBar_Load;
            btnHambur.MouseDown += HamburgerButton_MouseDown;
            btnHambur.MouseUp += HamburgerButton_MouseUp;
            _hamburIconOriginal = ControlIcons.HamburgurBig;
            btnHambur.Icon = ControlIcons.HamburgurBig;
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

            if (!item.Items.IsNullOrEmpty())
            {
                foreach (var child in item.Items)
                    CreateNodes(child, node);
            }
            node.IconKey = item.Icon;
            node.Icon = item.Icon == null ? null : ControlIcons.GetControlIcon(item.Icon);
            node.ExpandedIcon = item.Items == null ? null : ControlIcons.ChevronUp;
            node.CollapsedIcon = item.Items == null ? null : ControlIcons.ChevronDown;
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
            _searchIcon.Icon = ControlIcons.Search;
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
                //Selected item should be the nearest leaf that has an assembly
                SelectionChanged(this, new SideBarEventArgs(ClosestFunctionalLeaf(sample, e)));
            }
        }

        private ItemInfo ClosestFunctionalLeaf(ItemInfo selectedSample, StackNodeEventArgs e)
        {
            ItemInfo selectedItem = selectedSample;
            StackNodeControl selectedNode = e.Node;

            while (selectedItem.AssemblyName.IsNullOrEmpty())
            {
                if (selectedItem.Items.IsNullOrEmpty())
                {
                    selectedItem = selectedItem.Menus.FirstOrDefault();
                }
                else
                {
                    selectedItem = selectedItem.Items.FirstOrDefault();
                }
                // when menus are selected for display, they are not StackNodeControl, so previous node wll be fallback node
                selectedNode = selectedNode.Nodes.FirstOrDefault(node => node.Key == selectedItem.Guid.ToString()) ?? selectedNode;
            }
            treeView.SelectedNode = selectedNode;
            return selectedItem;
        }

        private void SearchBar_TextChanged(object sender, string searchText)
        {
            this.Cursor = Cursors.Default;
            treeView.FilterString = searchText;
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            pbMenu.BackColor = SkinManager.HighLightBackColor;
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            pbMenu.BackColor = Color.Transparent;
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
            btnHambur.Icon = ControlIcons.HamburgurSmall;
        }
        private void ExpandCollapseSidebar()
        {
            _searchIcon.Visible = !_searchIcon.Visible;
            searchBar1.Visible = !searchBar1.Visible;
            treeView.Collapsed = _collapsed;
            this.Width = _collapsed ? _collapsedWidth : _expandedWidth;
            Explorer.TheExplorer.InvalidatePanel();
        }
        #endregion
    }

    public class SideBarEventArgs : EventArgs
    {
        public ItemInfo SelectedSample
        { get; private set; }
        public SideBarEventArgs(ItemInfo sample)
        {
            this.SelectedSample = sample;
        }
    }
}
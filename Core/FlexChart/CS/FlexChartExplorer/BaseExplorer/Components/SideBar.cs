using BaseExplorer.Core;
using BaseExplorer.Model;
using BaseExplorer.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BaseExplorer.Components
{
    public partial class SideBar : UserControl
    {
        public event EventHandler<SideBar2EventArgs> SelectionChanged;
        private PictureBox searchIcon;
        private bool _collapsed = false;
        private string _theme = "Office365White";

        private List<SampleItem> _samples;

        [DefaultValue(null)]
        public List<SampleItem> Samples
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

        [DefaultValue(false)]
        public bool Collapsed
        {
            get { return _collapsed; }
            set
            {
                if(_collapsed != value)
                {
                    _collapsed = value;
                    ExpandCollapseSidebar();
                }
                else
                {
                    _collapsed = value;
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

        public SideBar()
        {
            InitializeComponent();
            InitializeInvisibleSearchIcon();
            this.DoubleBuffered = true; 
            _collapsed = false;
            this.Load += SideBar_Load;
            searchBar1.TextChangedEvent += SearchBar_TextChanged;
        }

        private void InitializeInvisibleSearchIcon()
        {
            searchIcon = new C1.Win.Input.C1PictureBox();
            searchIcon.BackColor = SkinManager.BackColor;
            searchIcon.Location = new Point(20, 12);
            searchIcon.Name = "searchIcon";
            searchIcon.Size = new Size(18, 18);
            searchIcon.TabIndex = 0;
            searchIcon.SizeMode = PictureBoxSizeMode.Zoom;
            searchIcon.Image = Properties.Resources.Search_black;
            searchIcon.Click += ToggleSideBar;
            searchIcon.Visible = false;
            panel2.Controls.Add(searchIcon);
        }

        private void SideBar_Load(object sender, EventArgs e)
        {
            treeView.SelectionChanged += OnSelectionChanged;
        }

        private void OnSelectionChanged(object sender, StackNodeEventArgs e)
        {
            SampleItem sample = e.Node.Tag as SampleItem;
            if (sample != null)
            {
                SelectionChanged(this, new SideBar2EventArgs(sample));
            }
        }

        private void PrepareSideBar()
        {
            treeView.Nodes.Clear();
            foreach (var sample in _samples)
                CreateNodes(sample, null);
            if (treeView.Nodes.Count > 0)
                treeView.SelectedNode = treeView.Nodes[0];
        }

        private void CreateNodes(SampleItem sample, StackNodeControl parent = null)
        {
            StackNodeControl node;
            if (parent == null)
                node = treeView.Nodes.Add(sample.Guid.ToString(), sample.Name);
            else
            {
                node = parent.Nodes.Add(sample.Guid.ToString(), sample.Name);
                node.IsSearchable = true;
                /*
                 * A node can be searched based on the following parameters
                 * 1. Text of the parent node
                 * 2. Name and Title of the node itself
                 * 3. Keywords defined for the parent node
                 * 4. Keywords defined for the node itself
                 */
                node.SearchString = string.Format("{0} {1} {2} {3} {4}", parent.Text, sample.Name, sample.Title, sample.KeyWords, sample.Parent.KeyWords);
            }
            node.Tag = sample;
            node.Status = sample.Status;

            if (!sample.Items.IsNullOrEmpty())
            {
                foreach (var item in sample.Items)
                    CreateNodes(item, node);
            }

            string iconColor = Theme == "Office365Black" ? "white" : "black"; // By default, Theme value null but white theem applied, hence black icons by default 
            node.IconKey = sample.Icon;
            node.CollapsedKey = sample.CollapsedImage;
            node.ExpandedKey = sample.ExpandedImage;
            node.ExpandedImage = sample.ExpandedImage == null ? null : (Image)Properties.Resources.ResourceManager.GetObject($"{sample.ExpandedImage}_{iconColor}");
            node.CollapsedImage = sample.CollapsedImage == null ? null : (Image)Properties.Resources.ResourceManager.GetObject($"{sample.CollapsedImage}_{iconColor}");
            node.Icon = sample.Icon == null ? null : (Image)Properties.Resources.ResourceManager.GetObject($"{sample.Icon}_{iconColor}");
        }


        /// <summary>
        /// Changes the selected node of the TreeView to the given sample. 
        /// </summary>
        /// <param name="sample"></param>
        internal void SelectSample(SampleItem sample)
        {
            if (sample != null)
                treeView.SelectedNode = treeView.FindNode(sample.Guid.ToString());
        }

        private void SearchBar_TextChanged(object sender, string searchText)
        {
            this.Cursor = Cursors.Default;
            treeView.FilterString = searchText;
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            pbMenu.BackColor = Theme == "Office365White" ? SkinManager.HighLightBackColor : SkinManager.Office365Black;
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            pbMenu.BackColor = Theme == "Office365White" ? SkinManager.BackColor : SkinManager.BlackBackColor;
        }

        private void ToggleSideBar(object sender, EventArgs e)
        {
            Collapsed = !_collapsed;
        }

        private void ExpandCollapseSidebar()
        {
            searchIcon.Visible = !searchIcon.Visible;
            searchBar1.Visible = !searchBar1.Visible;

            treeView.Collapsed = _collapsed;

            if (_collapsed)
            {
                this.Width = 48;
            }
            else
            {
                this.Width = 360;
            }
        }

        public void ApplyTheme()
        {
            bool isWhite = Theme == "Office365White";
            ColorPanels(isWhite ? SkinManager.BackColor : SkinManager.BlackBackColor);
            SideBarControlsChanges(isWhite);
            searchBar1.Theme = Theme;
            foreach (StackNodeControl node in treeView.Nodes)
            {
                node.Theme = Theme;// Apply to the parent node
                RecurseNodesAndApply(node, isWhite); // Apply to children and descendents if present 
            }
        }

        private void SideBarControlsChanges(bool isWhite)
        {
            if (isWhite)
            {
                searchIcon.Image = Properties.Resources.Search_black;
                treeView.SelectionForeColor = SystemColors.ControlText;
                pbMenu.Image = Properties.Resources.ham_menu_black;
            }
            else
            {
                searchIcon.Image = Properties.Resources.Search_white;
                treeView.SelectionForeColor = Color.White;
                pbMenu.Image = Properties.Resources.ham_menu_white;
            }
        }

        private void ColorPanels(Color color)
        {
            searchBar1.BackColor = color;
            panel3.BackColor = color;
            panel1.BackColor = color;
            pbMenu.BackColor = color;
            searchIcon.BackColor = color;
            this.BackColor = color;
            treeView.BackColor = color;
            treeView.Controls[0].BackColor = color;
            treeView.HoverBackColor = color;
            treeView.SelectionColor = color;
        }

        private void RecurseNodesAndApply(StackNodeControl node, bool isWhite)
        {
            foreach (StackNodeControl child in node.Nodes) 
            {
                child.Theme = Theme;
                if (!child.Nodes.IsNullOrEmpty())
                {
                    RecurseNodesAndApply(child, isWhite);
                }
            }
        }
    }


    public class SideBar2EventArgs : EventArgs
    {
        public SampleItem SelectedSample
        { get; private set; }
        public SideBar2EventArgs(SampleItem sample)
        {
            this.SelectedSample = sample;
        }

    }
}
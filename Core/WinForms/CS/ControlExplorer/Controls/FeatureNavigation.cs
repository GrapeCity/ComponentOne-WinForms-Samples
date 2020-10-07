using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.Framework;
using C1.Win.TreeView;

namespace ControlExplorer.Controls
{
    // todo:
    // - use C1TreeView
    // - different indent, expand/collapse icons, mouse over, selected styles 
    // - scrolling
    // - new badge
    // - selected control label - padding between icon and image
    public partial class FeatureNavigation : UserControl
    {
        #region fields
        private ControlInfo _control;
        private SampleInfo _selectedItem;
        int _lastDpi = 0;
        C1PathIcon _homeIcon;

        const int iconSize = 16;
        const int titleHeight = 36;
        #endregion

        public FeatureNavigation(ControlInfo info)
        {
            _control = info;
            InitializeComponent();
            _homeIcon = new C1PathIcon();
            _homeIcon.Data = "M12.832,16h-2.666c-0.275,0-0.5-0.224-0.5-0.5v-4.333C9.666,11.075,9.592,11,9.5,11h-3c-0.092,0-0.168,0.075-0.168,0.167V15.5c0,0.276-0.223,0.5-0.5,0.5H3.166C2.523,16,2,15.477,2,14.833V8.667H0.832C0.373,8.667,0,8.292,0,7.833c0-0.221,0.09-0.437,0.246-0.594l7.406-7.101c0.195-0.186,0.5-0.186,0.693,0l7.4,7.093C15.91,7.396,16,7.612,16,7.833c0,0.459-0.375,0.834-0.834,0.834H14v6.166C14,15.477,13.477,16,12.832,16z M10.666,15h2.166C12.924,15,13,14.924,13,14.833V8.167c0-0.276,0.223-0.5,0.5-0.5h1.254L8,1.192L1.246,7.667H2.5c0.275,0,0.5,0.224,0.5,0.5v6.666C3,14.924,3.076,15,3.166,15h2.166v-3.833C5.332,10.523,5.855,10,6.5,10h3c0.643,0,1.166,0.523,1.166,1.167V15z";
            this.btnHome.Icon = _homeIcon;
            LayoutControls();
            loadSamples();
            treeFeatures.Columns[0].CustomContentPresenter = new CustomNode();
            lblSelectedControl.Icon = info.Icon;
            lblSelectedControl.Text = info.Name;
        }

        protected override void RescaleConstantsForDpi(int deviceDpiOld, int deviceDpiNew)
        {
            base.RescaleConstantsForDpi(deviceDpiOld, deviceDpiNew);
            LayoutControls();
        }

        private void LayoutControls()
        {
            int dpi = base.DeviceDpi;
            if (dpi != _lastDpi)
            {
                double scale = (double)dpi / 96;
                this.pnlTitle.Size = new Size(this.Width, (int)(titleHeight * scale));
                var actualIconSize = (int)(iconSize * scale);
                _homeIcon.Size = new Size(actualIconSize, actualIconSize);
            }
            _lastDpi = dpi;
        }

        private void loadSamples()
        {
            if (_control == null)
            {
                return;
            }
            SampleInfo firstItem = null;
            if (!string.IsNullOrEmpty(_control.NewFeatureName))
            {
                // if there is new feature specified in xml, open it instead of first node
                firstItem = _control.Find(_control.NewFeatureName) as SampleInfo;
            }

            if (_control.Features.Count > 0)
            {
                foreach (FeatureInfo sample in _control.Features)
                {
                    if (sample is SampleInfo)
                    {
                        AddItem(sample, treeFeatures.Nodes);
                    }

                    else if (sample is CategoryInfo)
                    {
                        CategoryInfo category = sample as CategoryInfo;
                        var node = AddItem(category, treeFeatures.Nodes);
                        foreach (SampleInfo s in category.Samples)
                        {
                            AddItem(s, node.Nodes);
                        }
                    }
                }
                if (firstItem != null)
                {
                    _selectedItem = firstItem;
                    treeFeatures.Search(firstItem.Name);
                }
                else
                {
                    // select first node
                    var first = treeFeatures.Nodes[0];
                    if (first.Nodes.Count > 0)
                    {
                        first.Expand();
                        _selectedItem = first.Nodes[0].GetValue() as SampleInfo;
                        first.Nodes[0].Selected = true;
                    }
                    else
                    {
                        _selectedItem = first.GetValue() as SampleInfo;
                        first.Selected = true;
                    }
                }
            }
        }

        private C1TreeNode AddItem(FeatureInfo feature, C1TreeNodeCollection nodes)
        {
            var node = nodes.Add(feature);
            return node;
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Explorer.TheExplorer.GoHome();
        }


        public SampleInfo SelectedItem
        {
            get
            {
                return _selectedItem;
            }
            private set
            {
                if (_selectedItem != value)
                {
                    _selectedItem = value;
                }
            }
        }

        private void TreeFeatures_SelectionChanged(object sender, C1.Win.TreeView.C1TreeViewEventArgs e)
        {
            if (e.Node == null || !e.Node.Selected)
                return;
            var newNode = e.Node;
            // collapse previously expanded nodes
            foreach (var n in treeFeatures.Nodes)
            {
                if (n.Expanded && !n.Nodes.Contains(newNode))
                {
                    n.Collapse();
                }
            }
            if (newNode.HasChildren)
            {
                // select first child
                newNode.Expand();
                newNode.Nodes[0].Selected = true;
            }
            else
            {
                SelectedItem = newNode.GetValue() as SampleInfo;
                if (SelectedItem != null)
                {
                    Explorer.TheExplorer.ShowSample(SelectedItem);
                }
            }
        }
    }

    #region CustomPresenter

    public class CustomNode : CustomContentPresenter
    {
        #region private fields

        private TextElement _text;
        private Color _currentBackColor;
        private IconElement _newIcon = null;

        #endregion

        #region ctor

        public CustomNode()
        {
            ShowFocusRectangle = false;

            _text = new TextElement();
            _text.Style = new Style();
            _text.Style.Padding = new Thickness(4);
            Child = _text;
        }

        #endregion

        #region CustomContentPresenter

        public override string ToolTipText
        {
            get
            {
                return ((SampleInfo)Node.GetValue())?.ShortDescription;
            }
        }

        public override void SetFormat(string format)
        {

        }

        public override void SetStyle(TreeNodeCellStyles styles)
        {
            _text.Style.Font = styles.Font;
            if (IsSelected)
            {
                _text.Style.ForeColor = styles.Selected.ForeColor;
                _currentBackColor = _text.Style.BackColor = styles.Selected.BackColor;
            }
            else if (IsHot)
            {
                _text.Style.ForeColor = styles.Hot.ForeColor;
                _currentBackColor = _text.Style.BackColor = styles.Hot.BackColor;
            }
            else
            {
                _text.Style.ForeColor = styles.Default.ForeColor;
                _currentBackColor = _text.Style.BackColor = styles.Default.BackColor;
            }
        }

        public override void SetValue(object value)
        {
            FeatureInfo feature = value as FeatureInfo;
            if (feature.IsNew)
            {
                var size = ScaleToDeviceDPI(new Size(16, 16));
                var icon1 = new C1PolygonIcon();
                List<PointF> points = new List<PointF>();
                points.Add(new PointF(12.115f, 8.084f));
                points.Add(new PointF(14.158f, 6.093f));
                points.Add(new PointF(10.929f, 5.623f));
                points.Add(new PointF(11.322f, 2.681f));
                points.Add(new PointF(9.202f, 3.897f));
                points.Add(new PointF(8.121f, 1.706f));
                points.Add(new PointF(6.807f, 4.367f));
                points.Add(new PointF(3.863f, 2.956f));
                points.Add(new PointF(4.449f, 5.749f));
                points.Add(new PointF(2.083f, 6.093f));
                points.Add(new PointF(3.943f, 7.907f));
                points.Add(new PointF(1.821f, 10.135f));
                points.Add(new PointF(4.857f, 10.462f));
                points.Add(new PointF(4.389f, 13.19f));
                points.Add(new PointF(6.748f, 11.95f));
                points.Add(new PointF(8.016f, 14.296f));
                points.Add(new PointF(9.15f, 11.77f));
                points.Add(new PointF(11.852f, 13.19f));
                points.Add(new PointF(11.332f, 10.157f));
                points.Add(new PointF(13.889f, 9.688f));
                icon1.Points = points.ToArray();
                icon1.IsClosed = true;
                icon1.Color = Color.FromArgb(220, 154, 49);
                icon1.Size = size;
                var icon2 = new C1PathIcon();
                icon2.Data = "M8.121,1.706l1.081,2.191l2.12-1.217l-0.394,2.942l3.229,0.47l-2.043,1.991l1.773,1.604l-2.557,0.469l0.52,3.033L9.15,11.77l-1.135,2.526L6.748,11.95l-2.359,1.24l0.469-2.729l-3.037-0.327l2.123-2.228L2.083,6.093l2.367-0.344L3.863,2.956l2.943,1.411L8.121,1.706 M8.121,0L7.443,1.372L6.461,3.364L4.19,2.275L2.812,1.614L3.125,3.11l0.42,2.008L1.974,5.346l-1.513,0.22l1.095,1.067l1.327,1.294L1.274,9.614L0.22,10.722l1.521,0.163l2.237,0.241l-0.333,1.938L3.387,14.57l1.354-0.712l1.699-0.893l0.912,1.688L8.078,16l0.627-1.396l0.805-1.793l1.991,1.047l1.354,0.712l-0.259-1.507l-0.394-2.298l1.823-0.335l1.504-0.274L14.395,9.13l-1.178-1.066l1.469-1.43l1.095-1.068l-1.513-0.22l-2.492-0.362l0.295-2.202l0.203-1.517l-1.326,0.762L9.523,2.843L8.797,1.372L8.121,0L8.121,0z";
                icon2.Color = Color.White;
                icon2.Size = size;
                var icon = new C1CompositeIcon();
                icon.Size = size;
                icon.Icons.Add(icon2);
                icon.Icons.Add(icon1);
                _newIcon = IconElement.CreateElement(icon);
            }
            _text.Text = value?.ToString();
        }
        #endregion

        #region overrides

        protected override void LayoutChildren(Graphics g)
        {
            // measure size needed to accommodate the children
            Size sz = Size.Empty;
            Element e = Child;

            if (e != null && e.Visible)
            {
                if (e.AutoSize)
                    e.SetDirty();

                // if child is dirty, lay it out now
                if (e.IsDirty)
                    e.Layout(g);

                // compute size needed
                sz.Width = Math.Max(sz.Width, e.Width + e.Height / 2);
                sz.Height = Math.Max(sz.Height, e.Height);
            }

            // auto size element based on children size
            SizeToContent(g, false, sz);

            Rectangle r = ContentBounds;
            r.Width -= e.Height / 2 + 2;
            if (e != null && e.Visible)
                e.SetBounds(g, r);
        }

        public override void Render(Graphics g, Rectangle r)
        {
            if (IsSelected || IsHot)
            {
                using (var brush = new SolidBrush(_currentBackColor))
                {
                    var xview = (XView)HostControl;
                    var bounds = xview.GetBounds(this);
                    g.FillRectangle(brush, bounds);
                }
            }
            base.Render(g, r);
        }
        public override void RenderChildren(Graphics g, Rectangle r)
        {
            base.RenderChildren(g, r);
            if (_newIcon != null)
            {
                if (!this.Node.HasChildren || !this.Node.Expanded)
                {
                    _newIcon.Layout(g);
                    Rectangle rc = new Rectangle(r.X + r.Width - _newIcon.Width - 4, r.Y + 4, _newIcon.Width, _newIcon.Height);
                    _newIcon.Render(g, rc);
                }
            }
        }

        #endregion
    }

    #endregion

}

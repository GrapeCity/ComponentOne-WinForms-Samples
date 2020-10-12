using C1.Framework;
using C1.Win.TreeView;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ControlExplorer.Main
{
    public class FeatureTree : C1TreeView
    {
        #region fields
        private ControlInfo _control;
        private SampleInfo _selectedItem;
        #endregion

        #region events

        public event EventHandler<FeatureTreeEventArgs> ItemClicked;

        protected override void OnSelectionChanged(C1TreeViewEventArgs e)
        {
            base.OnSelectionChanged(e);
            var newNode = e.Node;
            if (SelectedItem == newNode.GetValue())
                return;
            // collapse previously expanded nodes
            foreach (var n in Nodes)
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
                if (ItemClicked != null)
                {
                    ItemClicked(this, new FeatureTreeEventArgs(SelectedItem));
                }
            }
        }

        #endregion

        #region ctor
        public FeatureTree()
        {
            this.AllowEditing = false;
            this.AllowUserToResizeColumns = false;
            this.ExtendLastColumn = true;
            this.SelectionMode = C1TreeViewSelectionMode.Single;
            this.ShowColumnHeaders = false;
            this.Styles.ExpandButtonStyle = ExpandButtonStyle.VS2015;
            this.Styles.ShowLines = false;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Columns[0].CustomContentPresenter = new CustomNode();
        }
        #endregion

        #region properties

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

        public new Color BackColor
        {
            get
            {
                return base.BackColor;
            }
            set
            {
                base.BackColor = value;
                Styles.Default.BackColor = value;
            }
        }

        public new Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }
            set
            {
                base.ForeColor = value;
                Styles.Default.ForeColor = value;
            }
        }

        public Color SelectedBackColor
        {
            get
            {
                return Styles.Selected.BackColor;
            }
            set
            {
                Styles.Selected.BackColor = value;
                Styles.HotSelected.BackColor = value;
                Styles.UnfocusedSelected.BackColor = value;
            }
        }
        public Color SelectedForeColor
        {
            get
            {
                return Styles.Selected.ForeColor;
            }
            set
            {
                Styles.Selected.ForeColor = value;
                Styles.HotSelected.ForeColor = value;
                Styles.UnfocusedSelected.ForeColor = value;
            }
        }
        public Color HoverBackColor
        {
            get
            {
                return Styles.Hot.BackColor;
            }
            set
            {
                Styles.Hot.BackColor = value;
            }
        }
        public Color HoverForeColor
        {
            get
            {
                return Styles.Hot.ForeColor;
            }
            set
            {
                Styles.Hot.ForeColor = value;
            }
        }


        #endregion

        #region methods

        public void loadSamples(ControlInfo control, SampleInfo firstItem = null)
        {
            if (control != null && control != _control)
            {
                _control = control;
                if (_control.Features.Count > 0 )
                {
                    RemoveItems();
                    foreach (FeatureInfo sample in control.Features)
                    {
                        if (sample is SampleInfo)
                        {
                            AddItem(sample, Nodes);
                        }

                        else if (sample is CategoryInfo)
                        {
                            CategoryInfo category = sample as CategoryInfo;
                            var node = Nodes.Add(category);
                            foreach (SampleInfo s in category.Samples)
                            {
                                AddItem(s, node.Nodes);
                            }
                        }
                    }
                    if (firstItem != null)
                    {
                        _selectedItem = firstItem;
                       base.Search(firstItem.Name);
                    }
                    else
                    {
                        // select first node
                        var first = Nodes[0];
                        if (first.HasChildren)
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
            if (ItemClicked != null)
            {
                ItemClicked(this, new FeatureTreeEventArgs(_selectedItem));
            }

        }

        private void AddItem(FeatureInfo feature, C1TreeNodeCollection nodes)
        {
            var node = nodes.Add(feature);
        }

        private void RemoveItems()
        {
            Nodes.Clear();
        }
        #endregion

        #region CustomPresenter

        private class CustomNode : CustomContentPresenter
        {
            #region private fields

            private TextElement _text;
            private Color _currentBackColor;
            private TextElement _newOverlay;

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

            public override string ToolTipText => string.Empty;

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
                SetOverlayStyle();
            }

            public override void SetValue(object value)
            {
                FeatureInfo feature = value as FeatureInfo;
                if ( feature.IsNew)
                {
                    _newOverlay = new TextElement();
                    SetOverlayStyle();
                    _newOverlay.Text = "New!";
                }
                _text.Text = value?.ToString();
            }

            private void SetOverlayStyle()
            {
                if (_newOverlay != null)
                {
                    _newOverlay.Style = _text.Style.Clone();
                    if (_newOverlay.Style.Font != null)
                    {
                        _newOverlay.Style.Font = new Font(_newOverlay.Style.Font, FontStyle.Italic);
                    }
                }
            }
            #endregion

            #region overrided

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
                base.Render(g, r);
                if (IsSelected || IsHot)
                {
                    using (var brush = new SolidBrush(_currentBackColor))
                    {
                        var xview = (XView)HostControl;
                        var bounds = xview.GetBounds(_text);
                        var leftTopX = bounds.X + bounds.Width;
                        var points = new Point[3]
                        {
                            new Point(leftTopX, bounds.Y),
                            new Point(leftTopX + bounds.Height / 2, bounds.Y + bounds.Height / 2),
                            new Point(leftTopX, bounds.Y + bounds.Height - 1)
                        };
                        g.FillPolygon(brush, points);
                    }
                }
            }
            public override void RenderChildren(Graphics g, Rectangle r)
            {
                base.RenderChildren(g, r);
                if (_newOverlay != null && !string.IsNullOrEmpty(_newOverlay.Text))
                {
                    if (!this.Node.HasChildren || !this.Node.Expanded)
                    {
                        _newOverlay.Layout(g);
                        Rectangle rc = new Rectangle(r.X + r.Width - _newOverlay.Width - this.Bounds.Height, r.Y, _newOverlay.Width, _newOverlay.Height);
                        _newOverlay.Render(g, rc);
                    }
                }
            }

            #endregion
        }

        #endregion
    }

    public class FeatureTreeEventArgs : EventArgs
    {
        public SampleInfo Sample { get; private set; }

        public FeatureTreeEventArgs(SampleInfo item)
        {
            Sample = item;
        }
    }
}

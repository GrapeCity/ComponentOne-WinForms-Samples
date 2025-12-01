using Custom_Localization.Models;
using Custom_Localization.Services;
using Custom_Localization.UserControls.Events;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Custom_Localization.UserControls
{
    /// <summary>
    /// The CustomTreeview is used to display hierarchical data in a tree structure with custom rendering.
    /// It was created to provide a custom look and feel for tree views in the application.
    /// Due to the shortcommings of the default TreeView control in WinForms, this custom control allows for enhanced customization 
    /// </summary>
    public partial class CustomTreeView : UserControl
    {

        // Property to be exposed
        private IEnumerable<object> _treeData = Enumerable.Empty<object>();
        private Func<object, TreeNode> _mapper;

        public event EventHandler<SelectedItemChangedEventArgs> TreeNodeSelectedItemChanged;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IEnumerable<object> TreeData
        {
            get => _treeData;
            set
            {
                _treeData = value ?? Enumerable.Empty<object>();
                RefreshTree();
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility (DesignerSerializationVisibility.Hidden)]  
        public Func<object, TreeNode> Mapper
        {
            get => _mapper;
            set
            {
                _mapper = value ?? throw new ArgumentNullException(nameof(value));
                RefreshTree();
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsFirstNodeSelected
        {
            get => treeView1.Nodes.Count > 0 && treeView1.SelectedNode == treeView1.Nodes[0].Nodes[0];
            set
            {
                if (value && treeView1.Nodes[0].Nodes.Count > 0)
                {
                    SelectedTreeNodeChange();
                }
            }
        }


        public CustomTreeView()
        {
            InitializeComponent();

            treeView1.DrawMode = TreeViewDrawMode.OwnerDrawAll;
            treeView1.DrawNode += TreeView1_DrawNode;
            treeView1.NodeMouseClick += TreeView1_NodeMouseClick;
            
        }
        
        private void SelectedTreeNodeChange()
        {
            treeView1.SelectedNode = treeView1.Nodes[0].Nodes[0];
            //treeView1.SelectedNode.EnsureVisible();
        }


        private void TreeView1_NodeMouseClick(object? sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNodeSelectedItemChanged?.Invoke(this, new SelectedItemChangedEventArgs(e.Node));
        }
        private void RefreshTree()
        {
            if (_mapper == null || _treeData == null) return;

            treeView1.BeginUpdate();
            treeView1.Nodes.Clear();

            foreach (var item in _treeData)
            {
                var node = _mapper(item);
                treeView1.Nodes.Add(node);
            }

            treeView1.EndUpdate();
        }

        // Painting Custom tree view
        private void TreeView1_DrawNode(object? sender, DrawTreeNodeEventArgs e)
        {
            TreeView tree = sender as TreeView;
            bool isSelected = (e.State & TreeNodeStates.Selected) == TreeNodeStates.Selected
                   || treeView1.SelectedNode == e.Node;


            Color backColor = isSelected ? ColorTranslator.FromHtml("#F7B1A7") : tree.BackColor;

            using (Brush bgBrush = new SolidBrush(backColor))
                e.Graphics.FillRectangle(bgBrush, e.Bounds);

            // Calculate indentation
            int indent = e.Node.Level * tree.Indent;
            int glyphWidth = 16;

            // Draw glyph if node has children
            if (e.Node.Nodes.Count > 0)
            {
                Rectangle glyphBounds = new Rectangle(
                    e.Bounds.Left + indent + 4,
                    e.Bounds.Top + (e.Bounds.Height - 9) / 2,
                    9,
                    9
                );

                Point[] triangle = e.Node.IsExpanded
                    ? new[] {
                new Point(glyphBounds.Left, glyphBounds.Top),
                new Point(glyphBounds.Right, glyphBounds.Top),
                new Point(glyphBounds.Left + 4, glyphBounds.Bottom)
                      }
                    : new[] {
                new Point(glyphBounds.Left, glyphBounds.Top),
                new Point(glyphBounds.Right, glyphBounds.Top + 4),
                new Point(glyphBounds.Left, glyphBounds.Bottom)
                      };

                using (Brush triangleBrush = new SolidBrush(Color.Black))
                    e.Graphics.FillPolygon(triangleBrush, triangle);
            }

            Rectangle textBounds = new Rectangle(
                e.Bounds.Left + indent + glyphWidth + 2,
                e.Bounds.Top,
                e.Bounds.Width - indent - glyphWidth - 2,
                e.Bounds.Height
            );

            TextRenderer.DrawText(
                e.Graphics,
                e.Node.Text,
                e.Node.NodeFont ?? tree.Font,
                textBounds,
                tree.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Left
            );

            e.DrawDefault = false;
        }
    }
}

using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TreeCheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string localPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string samples = Path.Combine(localPath, "ComponentOne Samples");
            if (Directory.Exists(samples)) localPath = samples;

            AddFolder(localPath, treeView1.Nodes);

            c1FlexGrid1.BeginUpdate();
            AddFolder(localPath, 0);
            c1FlexGrid1.EndUpdate();
        }

        //--------------------------------------------------------------------------------
        #region ** C1FlexGrid code

        void AddFolder(string path, int level)
        {
            int cnt = 0;
            try
            {
                foreach (string file in Directory.GetFiles(path))
                {
                    var node = c1FlexGrid1.Rows.AddNode(level);
                    node.Data = Path.GetFileName(file);
                    node.Checked = C1.Win.FlexGrid.CheckEnum.Unchecked;
                    cnt++;
                    if (cnt > 20) break;
                }
            }
            catch { }
            try
            {
                foreach (string subPath in Directory.GetDirectories(path))
                {
                    var node = c1FlexGrid1.Rows.AddNode(level);
                    node.Data = Path.GetFileName(subPath);
                    node.Checked = C1.Win.FlexGrid.CheckEnum.Unchecked;
                    AddFolder(subPath, level + 1);
                    cnt++;
                    if (cnt > 20) break;
                }
            }
            catch { }
        }

        void c1FlexGrid1_CellChecked(object sender, C1.Win.FlexGrid.RowColEventArgs e)
        {
            // apply check value to all children
            var node = this.c1FlexGrid1.Rows[e.Row].Node;
            UpdateCheckChildren(node);

            // apply check value to parents
            UpdateCheckParent(node);
        }
        void UpdateCheckChildren(C1.Win.FlexGrid.Node node)
        {
            var checkState = node.Checked;
            foreach (C1.Win.FlexGrid.Node child in node.Nodes)
            {
                child.Checked = checkState;
                UpdateCheckChildren(child);
            }
        }
        void UpdateCheckParent(C1.Win.FlexGrid.Node node)
        {
            // get this node's parent
            var parent = node.Parent;
            if (parent != null)
            {
                // count checked/unchecked children 
                int cntChecked = 0;
                int cntUnchecked = 0;
                int cntGrayed = 0;
                foreach (C1.Win.FlexGrid.Node child in parent.Nodes)
                {
                    switch (child.Checked)
                    {
                        case C1.Win.FlexGrid.CheckEnum.Checked:
                            cntChecked++;
                            break;
                        case C1.Win.FlexGrid.CheckEnum.Unchecked:
                            cntUnchecked++;
                            break;
                        case C1.Win.FlexGrid.CheckEnum.Grayed:
                            cntGrayed++;
                            break;
                    }
                }

                // update parent's check state
                if (cntGrayed > 0 || (cntChecked > 0 && cntUnchecked > 0))
                {
                    parent.Checked = C1.Win.FlexGrid.CheckEnum.Grayed;
                }
                else if (cntChecked > 0 && cntUnchecked == 0)
                {
                    parent.Checked = C1.Win.FlexGrid.CheckEnum.Checked;
                }
                else if (cntUnchecked > 0 && cntChecked == 0)
                {
                    parent.Checked = C1.Win.FlexGrid.CheckEnum.Unchecked;
                }

                // update grandparent as well
                UpdateCheckParent(parent);
            }
        }

        #endregion

        //--------------------------------------------------------------------------------
        #region ** TreeView code

        void AddFolder(string path, TreeNodeCollection nodes)
        {
            int cnt = 0;
            try
            {
                foreach (string file in Directory.GetFiles(path))
                {
                    var node = nodes.Add(Path.GetFileName(file));
                    node.Checked = false;
                    cnt++;
                    if (cnt > 20) break;
                }
            }
            catch { }
            try
            {
                foreach (string subPath in Directory.GetDirectories(path))
                {
                    var node = nodes.Add(Path.GetFileName(subPath));
                    node.Checked = false;
                    AddFolder(subPath, node.Nodes);
                    cnt++;
                    if (cnt > 20) break;
                }
            }
            catch { }
        }

        bool _updating;
        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (!_updating)
            {
                _updating = true;

                // apply check value to all children
                var node = e.Node;
                var c = node.Checked;
                ApplyCheck(node, c);

                // apply check value to parents
                while (node.Parent != null)
                {
                    node = node.Parent;
                    node.Checked = c;
                }
                _updating = false;
            }
        }
        void ApplyCheck(TreeNode node, bool c)
        {
            foreach (TreeNode child in node.Nodes)
            {
                child.Checked = c;
                ApplyCheck(child, c);
            }
        }
        #endregion
    }
}

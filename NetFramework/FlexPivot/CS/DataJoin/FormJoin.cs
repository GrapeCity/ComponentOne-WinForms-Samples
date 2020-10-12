using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.DataEngine;

namespace DataJoin
{
    public partial class FormJoin : Form
    {
        private List<TreeNode> _tableNodes = new List<TreeNode>();
        public FormJoin()
        {
            InitializeComponent();
            _imageList.Images.Add(Properties.Resources.table_22x16);
            _imageList.Images.Add(Properties.Resources.column_22x16);
            // bold font for table nodes
            tvTables.Font = new System.Drawing.Font(Font, FontStyle.Bold);
        }

        // gets or sets C1DataEngine tables to join
        public dynamic[] Tables { get; set; }

        // gets or sets selected field names to join
        public string[] SelectedFields { get; set; }

        // gets settings object for join
        public Dictionary<string, object> JoinSettings { get; private set; }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ShowTables();
        }

        // saves user choices
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            SelectedFields = GetCheckedNodes();
            JoinSettings = GetJoinSettings();
        }

        // shows table fields in the tree view
        private void ShowTables()
        {
            TreeNode root = ShowTable(null, Tables[0]);
            ShowTable(root.Nodes[1], Tables[1]);
            ShowTable(root.Nodes[2], Tables[2]);
            CheckNodes();
            tvTables.AfterCheck += tvTables_AfterCheck;
            tvTables.SelectedNode = root;
            tvTables.ExpandAll();
            root.EnsureVisible();
        }

        // shows a table in the tree view
        private TreeNode ShowTable(TreeNode parent, dynamic table)
        {
            TreeNode nt = new TreeNode(table.Table.Name, 0, 0);
            nt.Name = nt.Text;
            nt.Tag = table;
            nt.Checked = true;
            // gets the table as a dictionary of properties
            var props = (IDictionary<string, Object>)table;
            foreach (var prop in props)
            {
                // create a node if the property is a column
                if (prop.Value != null && (prop.Value.GetType() == typeof(Column)))
                {
                    Column col = (Column)prop.Value;
                    TreeNode nc = new TreeNode(col.Name, 1, 1);
                    nc.Name = nc.Text;
                    nc.Tag = col;
                    nc.NodeFont = Font;
                    nt.Nodes.Add(nc);
                }
            }
            // add the table node to the tree view
            // and check referenced nodes
            if (parent != null)
            {
                parent.Nodes.Add(nt);
                parent.Checked = true;
            }
            else
                tvTables.Nodes.Add(nt);

            nt.Nodes[0].Checked = true;
            _tableNodes.Add(nt);
            return nt;
        }

        // creates a settings object to build a join query
        private Dictionary<string, object> GetJoinSettings()
        {
            var settings = new Dictionary<string, object>();
            foreach (TreeNode node in _tableNodes)
            {
                Columns cols = GetSelectedColumns(node);
                if ((object)cols != null)
                    settings[node.Text] = cols;
            }
            return settings;
        }

        // gets selected columns for a table node
        private Columns GetSelectedColumns(TreeNode node)
        {
            Columns cols = null;
            for (int i = 0; i < node.Nodes.Count; i++)
            {
                TreeNode cn = node.Nodes[i];
                // add a selected column to the collection
                if (cn.Checked) 
                {
                    // do not add relationship column to result by default
                    if (node.Parent != null && cn == node.Nodes[0])
                        continue;
                    cols += (Column)cn.Tag;
                }
            }
            if (node.Parent != null)
            {
                // if no result columns are selected, add a relationship column
                if ((object)cols == null)
                    cols += (Column)node.Nodes[0].Tag;
                // add a relation between the tables
                cols |= (Column)node.Parent.Tag == (Column)node.Nodes[0].Tag;
            }
            return cols;
        }

        // gets paths of the selected nodes
        private string[] GetCheckedNodes()
        {
            List<string> nodes = new List<string>();
            GetCheckedNodes(tvTables.Nodes, nodes);
            return nodes.ToArray();
        }

        // adds path of the selected nodes to the list
        private void GetCheckedNodes(TreeNodeCollection nodes, List<string> checkedNodes)
        {
            foreach (TreeNode node in nodes)
            {
                if (node.Checked)
                    checkedNodes.Add(node.FullPath);
                GetCheckedNodes(node.Nodes, checkedNodes);
            }
        }

        // checks tree view nodes by the selected paths
        private void CheckNodes()
        {
            if (SelectedFields == null)
                return;
            foreach (string path in SelectedFields)
                GetNode(path).Checked = true;
        }

        // gets a tree view node by path
        private TreeNode GetNode(string fullPath)
        {
            TreeNode node = null;
            string[] names = fullPath.Split(tvTables.PathSeparator.ToCharArray());
            TreeNodeCollection nodes = tvTables.Nodes;
            foreach (string name in names)
            {
                node = nodes.Find(name, false)[0];
                nodes = node.Nodes;
            }
            return node;
        }

        // validates check state of a node
        // referenced nodes must always be checked
        private void tvTables_AfterCheck(object sender, TreeViewEventArgs e)
        {
            tvTables.AfterCheck -= tvTables_AfterCheck;
            if (e.Node.Nodes.Count > 0)
                e.Node.Checked = true;
            else if (e.Node.Parent != null && e.Node.Parent.Nodes[0] == e.Node)
                e.Node.Checked = true;
            tvTables.AfterCheck += tvTables_AfterCheck;
        }
    }
}

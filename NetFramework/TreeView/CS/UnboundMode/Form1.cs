using C1.Win.TreeView;
using System;
using System.Windows.Forms;

namespace UnboundMode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            c1DockingTab1.SelectedIndex = 0;
            c1TreeView1.Expanding += C1TreeView1_Expanding;
        }

        private void C1TreeView1_Expanding(object sender, C1TreeViewCancelEventArgs e)
        {
            foreach (var node in e.Node.Nodes)
            {
                GenerateChildNodes(node);
                node.Collapse(true);
            }
        }

        private void btnGenerateTree_Click(object sender, EventArgs e)
        {
            GenerateTreeView();
            ResetColumnsInCombobox();
        }

        private void GenerateTreeView()
        {
            c1TreeView1.Columns.Clear();
            c1TreeView1.Nodes.Clear();

            for (var i = 0; i < nudColumnsCount.Value; i++)
            {
                var column = new C1TreeColumn();
                column.HeaderText = string.Format("Column {0}", i);
                column.AutoWidth = false;
                column.Width = 200;
                c1TreeView1.Columns.Add(column);
            }

            for (var i = 0; i < nudRootNodesCount.Value; i++)
            {
                var node = new C1TreeNode(string.Format("Node 0.{0}", i));
                c1TreeView1.Nodes.Add(node);
                GenerateChildNodes(node);
                node.Collapse(true);           
            }
        }

        private void GenerateChildNodes(C1TreeNode parentNode)
        {
            if (!parentNode.HasChildren && nudLevelsCount.Value > parentNode.Level)
            {
                for (var i = 0; i < nudNodesCount.Value; i++)
                {
                    var node = new C1TreeNode(string.Format("Node {0}.{1}.{2}", parentNode.Level + 1, parentNode.ParentCollection.IndexOf(parentNode), i));
                    parentNode.Nodes.Add(node);
                }
            }
        }    

        private void ResetColumnsInCombobox()
        {
            cmbSelectedColumn.Items.Clear();
            for(var i =0; i < c1TreeView1.Columns.Count; i++)
                cmbSelectedColumn.Items.Add(c1TreeView1.Columns[i].HeaderText);
            if (cmbSelectedColumn.Items.Count > 0)
                cmbSelectedColumn.SelectedIndex = 0;
        }

        private void btnAddNewColumn_Click(object sender, EventArgs e)
        {
            var addForm = new AddNewColumnForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                var column = new C1TreeColumn();
                column.Name = addForm.ColumnName;
                column.HeaderText = addForm.ColumnHeaderText;
                column.DisplayFieldName = addForm.ColumnDisplayFieldName;
                c1TreeView1.Columns.Add(column);
                ResetColumnsInCombobox();
            }
        }

        private void btnRemoveColumn_Click(object sender, EventArgs e)
        {
            var index = cmbSelectedColumn.SelectedIndex;
            if (index > -1 && c1TreeView1.Columns.Count > index)
            {
                c1TreeView1.Columns.RemoveAt(index);
                ResetColumnsInCombobox();
            }
        }

        private void c1TreeView1_SelectionChanged(object sender, C1TreeViewEventArgs e)
        {
            pgNode.SelectedObject = e.Node;
        }

        private void cmbSelectedColumn_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = cmbSelectedColumn.SelectedIndex;
            if (index > -1 && c1TreeView1.Columns.Count > index)
            {
                pgColumn.SelectedObject = c1TreeView1.Columns[index];
            }
        }

        private void btnRemoveSelectedNodes_Click(object sender, EventArgs e)
        {
            foreach(var node in c1TreeView1.SelectedNodes)
            {
                node.ParentCollection.Remove(node);
            }
        }

        private void btnClearTree_Click(object sender, EventArgs e)
        {
            c1TreeView1.Columns.Clear();
            c1TreeView1.Nodes.Clear();
        }
    }
}
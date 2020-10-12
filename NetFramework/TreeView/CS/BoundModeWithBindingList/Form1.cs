using C1.Win.TreeView;
using SamplesData;
using System;
using System.Windows.Forms;

namespace BoundModeWithBindingList
{
    public partial class Form1 : Form
    {
        public Form1()
        {            
            InitializeComponent();
            imageList1.Images.Add(Properties.Resources._1);
            imageList1.Images.Add(Properties.Resources._2);
            imageList1.Images.Add(Properties.Resources._3);
            c1DockingTab1.SelectedIndex = 0;
            ResetDataInTreeView();
            ResetColumnsInCombobox();            
        }

        private void btnResetData_Click(object sender, EventArgs e)
        {
            ResetDataInTreeView();
            ResetColumnsInCombobox();
        }

        private void ResetDataInTreeView()
        {
            c1TreeView1.Columns.Clear();
            c1TreeView1.BindingInfo.DataSource = null;

            c1TreeView1.BindingInfo.DataMember = "\\ProductsGroups\\Products";            
            var column = new C1TreeColumn();
            column.HeaderText = "Name";
            c1TreeView1.Columns.Add(column);

            column = new C1TreeColumn();
            column.DisplayFieldName = "CountOfProducts";
            column.HeaderText = "Products in store";
            column.AutoWidth = false;
            column.Width = 100;
            c1TreeView1.Columns.Add(column);

            column = new C1TreeColumn();
            column.DisplayFieldName = "\\\\Price";
            column.HeaderText = "Price";
            column.Width = 200;            
            c1TreeView1.Columns.Add(column);

            c1TreeView1.BindingInfo.DataSource = StoreCollection.GetData();

            c1TreeView1.Nodes[0].Images.Add(0);
            c1TreeView1.Nodes[1].Images.Add(1);
            c1TreeView1.Nodes[2].Images.Add(2);
        }

        private void ResetColumnsInCombobox()
        {
            cmbSelectedColumn.Items.Clear();
            for(var i =0; i < c1TreeView1.Columns.Count; i++)
                cmbSelectedColumn.Items.Add(string.Format("{0} {1}", i, c1TreeView1.Columns[i].HeaderText));
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
    }
}
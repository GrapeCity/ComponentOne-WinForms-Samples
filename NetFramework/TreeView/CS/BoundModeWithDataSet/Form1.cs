using C1.Win.TreeView;
using SamplesData;
using System;
using System.Data;
using System.Windows.Forms;

namespace BoundModeWithDataSet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

            c1TreeView1.BindingInfo.DataMember = "Employees";
            var column = new C1TreeColumn();
            column.DisplayFieldName = "Post\\Post\\Post";
            column.HeaderText = "Post";
            c1TreeView1.Columns.Add(column);
            column = new C1TreeColumn();
            column.DisplayFieldName = "FirstName\\FirstName\\FirstName";
            column.HeaderText = "First name";
            c1TreeView1.Columns.Add(column);
            column = new C1TreeColumn();
            column.DisplayFieldName = "LastName\\LastName\\LastName";
            column.HeaderText = "Last name";
            c1TreeView1.Columns.Add(column);
            c1TreeView1.BindingInfo.KeyField = "ID";
            c1TreeView1.BindingInfo.ParentKeyField = "ChiefID";
            c1TreeView1.BindingInfo.DataSource = Initilize();
        }

        private void ResetColumnsInCombobox()
        {
            cmbSelectedColumn.Items.Clear();
            for (var i = 0; i < c1TreeView1.Columns.Count; i++)
                cmbSelectedColumn.Items.Add(string.Format("{0} {1}", i, c1TreeView1.Columns[i].HeaderText));
            if (cmbSelectedColumn.Items.Count > 0)
                cmbSelectedColumn.SelectedIndex = 0;
        }

        public BindingSource Initilize()
        {        
            var bindingSource = new BindingSource();
            bindingSource.DataSource = EmployeesSelfRefDataSet.GetData();
            bindingSource.DataMember = "Employees";
            return bindingSource;
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
using C1.Win.Input.MultiColumnCombo;
using MultiColumnComboExplorer.Data;
using System;
using System.Data;
using System.Windows.Forms;

namespace MultiColumnComboExplorer.Samples
{
    public partial class EmbeddedEditorInTreeView : UserControl
    {
        public EmbeddedEditorInTreeView()
        {
            InitializeComponent();
        }

        private void EmbeddedEditorInTreeView_Load(object sender, EventArgs e)
        {
            DataTable categoriesTable = DataSource.GetRows("Select * from Categories", "Categories");
            DataTable productsTable = DataSource.GetRows("Select * from Products", "Products");
            DataTable suppliersTable = DataSource.GetRows("Select * from Suppliers", "Suppliers");

            DataSet treeViewDataSet = new DataSet();
            treeViewDataSet.Tables.Add(categoriesTable);
            treeViewDataSet.Tables.Add(productsTable);
            treeViewDataSet.Relations.Add(categoriesTable.Columns["CategoryID"], productsTable.Columns["CategoryID"]);

            // C1MultiColumnCombo as supplier editor
            C1MultiColumnCombo supplierEditor = new()
            {
                DataSource = suppliersTable,
                ValueMember = "SupplierID",
                DisplayMember = "CompanyName"
            };
            supplierEditor.Columns[0].Visible = false;

            // set data to treeview            
            c1TreeView1.BindingInfo.DataMemberPath[0] = "Categories";
            c1TreeView1.BindingInfo.DataMemberPath[1] = "Products";
            c1TreeView1.ExtendLastColumn = false;
            //c1TreeView1.BindingInfo.KeyField = "CategoryID";
            c1TreeView1.BindingInfo.DataSource = treeViewDataSet;
            c1TreeView1.Columns[0].DisplayMemberPath[0] = "CategoryName";
            c1TreeView1.Columns[0].DisplayMemberPath[1] = "ProductName";
            c1TreeView1.Columns.Add(new C1.Win.TreeView.C1TreeColumn
            {
                DisplayFieldName = "Description\\SupplierID",
                HeaderText = "Description \\ Supplier",
                AutoWidth = true,
            });
            c1TreeView1.AllowEditing = true;
            c1TreeView1.Columns[1].Editor = supplierEditor;
            c1TreeView1.CellBeginEdit += C1TreeView1_CellBeginEdit;
        }

        private void C1TreeView1_CellBeginEdit(object sender, C1.Win.TreeView.C1TreeViewNodeCellCancelEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.Node.Level == 0)
                e.Cancel = true;
        }
    }
}

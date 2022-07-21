using System;
using System.Data;
using System.Windows.Forms;
using TreeViewExplorer.Data;

namespace TreeViewExplorer.Samples
{
    public partial class CustomNodes : UserControl
    {
        public CustomNodes()
        {
            InitializeComponent();
        }

        private void CustomNodes_Load(object sender, EventArgs e)
        {
            // fill data
            var ds = new DataSet();
            ds.Tables.Add(DataSource.GetRows("Select * from categories", "categories"));
            ds.Tables.Add(DataSource.GetRows("Select * from products", "products"));
            ds.Relations.Add("CategoriesProducts", ds.Tables["categories"].Columns["CategoryID"], ds.Tables["products"].Columns["CategoryID"]);
            // set data to treeview
            c1TreeView1.BindingInfo.DataMemberPath[0] = "categories";
            c1TreeView1.BindingInfo.DataMemberPath[1] = "products";            
            c1TreeView1.BindingInfo.DataSource = ds;
            // set custom nodes
            c1TreeView1.Columns[0].CustomContentPresenter = new CategoryCustomNode();
            c1TreeView1.Columns[1].CustomContentPresenter = new ProductCustomNode();
        }
    }
}

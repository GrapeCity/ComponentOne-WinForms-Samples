using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CustomNodes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // fill data
            productsTableAdapter1.Fill(dataSet11.Products);
            categoriesTableAdapter1.Fill(dataSet11.Categories);
            // set data to treeview            
            c1TreeView1.BindingInfo.DataMember = "Categories\\Products";
            c1TreeView1.BindingInfo.KeyField = "CategoryID\\CategoryID";
            c1TreeView1.BindingInfo.DataSource = dataSet11;
            // set custom nodes
            c1TreeView1.Columns[0].CustomContentPresenter = new CategoryCustomNode();
            c1TreeView1.Columns[1].CustomContentPresenter = new ProductCustomNode();
        }
    }
}

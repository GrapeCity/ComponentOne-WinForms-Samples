using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GaugeDemo
{
    public partial class PageDataBound : BaseGaugePage
    {
        public PageDataBound()
        {
            InitializeComponent();

            DataSet productsDataSet = new DataSet("ProductsDataSet");
            productsDataSet.ReadXml(@"products.xml", System.Data.XmlReadMode.Auto);
            dataGridView1.DataSource = productsDataSet;
            dataGridView1.DataMember = "Products";

            c1LinearGauge1.DataBindings.Add(new Binding(
                "MorePointersValue_0", productsDataSet, "Products.ReorderLevel"));
            c1LinearGauge1.DataBindings.Add(new Binding(
                "MorePointersValue_1", productsDataSet, "Products.UnitsOnOrder"));

            c1LinearGauge1.DataSource = productsDataSet;
            c1LinearGauge1.DataField = "Products.UnitsInStock";

            DataGridViewColumnCollection coll = dataGridView1.Columns;
            coll[0].Width = 70;
            coll[1].Width = 80;
            coll[2].Width = 80;
            coll[3].Width = 80;
        }
    }
}

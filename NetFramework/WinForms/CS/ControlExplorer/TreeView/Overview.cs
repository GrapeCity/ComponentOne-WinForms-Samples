using C1.Win.TreeView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlExplorer.TreeView
{
    public partial class Overview : C1DemoForm
    {
        public Overview()
        {
            InitializeComponent();
            SetupTreeView();
        }

        private void SetupTreeView()
        {
            c1TreeView1.DataMember = "\\Companies\\Products";
            C1TreeColumn column = c1TreeView1.Columns[0];
            column.HeaderText = "Name";

            column = new C1TreeColumn();
            column.DisplayFieldName = string.Format("\\\\Quantity");
            column.HeaderText = "Quantity";
            column.AutoWidth = false;
            column.Width = 50;
            c1TreeView1.Columns.Add(column);

            column = new C1TreeColumn();
            column.DisplayFieldName = string.Format("\\\\Price");
            column.HeaderText = "Price";
            column.Width = 200;
            c1TreeView1.Columns.Add(column);

            c1TreeView1.DataSource = GetProducts();

            c1TreeView1.ApplyNodeStyles += C1TreeView1_ApplyNodeStyles;
        }
        

        private void C1TreeView1_ApplyNodeStyles(object sender, C1TreeViewNodeStylesEventArgs e)
        {
            if (e.Node.Level == 0)
            {
                e.NodeStyles.Font = new Font(e.NodeStyles.Font, FontStyle.Bold);
            }
            else if (e.Node.Level == 1)
            {
                e.NodeStyles.Font = new Font(e.NodeStyles.Font, FontStyle.Italic);
            }
        }

        public static BindingList<ProductType> GetProducts()
        {
            BindingList<ProductType> productsTypes = new BindingList<ProductType>();

            productsTypes.Add(new ProductType("Motherboard"));
            productsTypes[0].Companies.Add(new Company("Geopbyte"));
            productsTypes[0].Companies[0].Products.Add(new Product("GP-P102X-Full", 6, 9999.95));
            productsTypes[0].Companies[0].Products.Add(new Product("GP-P103X-Mini", 3, 5999.95));
            productsTypes[0].Companies[0].Products.Add(new Product("GP-P104X-Pro", 5, 14999.95));
            productsTypes[0].Companies.Add(new Company("SUSA"));
            productsTypes[0].Companies[1].Products.Add(new Product("Chronos D6", 4, 15000));
            productsTypes[0].Companies[1].Products.Add(new Product("Zeus Z8", 1, 14000));
            productsTypes[0].Companies[1].Products.Add(new Product("Hercules I2", 6, 13000));
            productsTypes[0].Companies.Add(new Company("MacroPlanet"));
            productsTypes[0].Companies[2].Products.Add(new Product("Earth III", 3, 9999.95));
            productsTypes[0].Companies[2].Products.Add(new Product("Mars IV", 2, 15000));
            productsTypes[0].Companies[2].Products.Add(new Product("Jupiter V", 8, 19000));

            productsTypes.Add(new ProductType("CPU"));
            productsTypes[1].Companies.Add(new Company("Clever"));
            productsTypes[1].Companies[0].Products.Add(new Product("Nucleus n3", 1, 1999.99));
            productsTypes[1].Companies[0].Products.Add(new Product("Nucleus n5", 1, 5000));
            productsTypes[1].Companies[0].Products.Add(new Product("Nucleus n7", 1, 8000));
            productsTypes[1].Companies[0].Products.Add(new Product("Radon R7", 1, 27000));
            productsTypes[1].Companies.Add(new Company("Simple Hardware"));
            productsTypes[1].Companies[1].Products.Add(new Product("FX S", 2, 1000));
            productsTypes[1].Companies[1].Products.Add(new Product("FX M", 2, 2000));
            productsTypes[1].Companies[1].Products.Add(new Product("FX L", 2, 3000));

            productsTypes.Add(new ProductType("GPU"));
            productsTypes[2].Companies.Add(new Company("Nitro Vision"));
            productsTypes[2].Companies[0].Products.Add(new Product("Edison 3800FX", 3, 50000));
            productsTypes[2].Companies.Add(new Company("Simple Hardware"));
            productsTypes[2].Companies[1].Products.Add(new Product("Anger 7800", 2, 4999.95));
            productsTypes[2].Companies[1].Products.Add(new Product("Anger 8800", 2, 19999.95));
            productsTypes[2].Companies[1].Products.Add(new Product("Anger 9800 Pro", 2, 20000));

            productsTypes.Add(new ProductType("RAM"));
            productsTypes[3].Companies.Add(new Company("KingRuleZ"));
            productsTypes[3].Companies[0].Products.Add(new Product("DDR4 Micro 8GB", 4, 3900));
            productsTypes[3].Companies[0].Products.Add(new Product("DDR4 Micro 16GB", 2, 4900));
            productsTypes[3].Companies[0].Products.Add(new Product("DDR4 Micro 32 GB", 1, 7800.95));

            productsTypes.Add(new ProductType("HDD"));
            productsTypes[4].Companies.Add(new Company("StarGate"));
            productsTypes[4].Companies[0].Products.Add(new Product("Lemuria 1000", 10, 4500));
            productsTypes[4].Companies[0].Products.Add(new Product("Lemuria 2000", 10, 5000));
            productsTypes[4].Companies[0].Products.Add(new Product("Lemuria 6000", 10, 18000));
            productsTypes[4].Companies.Add(new Company("Eastern Analog"));
            productsTypes[4].Companies[1].Products.Add(new Product("Yellow", 4, 9999.99));
            productsTypes[4].Companies[1].Products.Add(new Product("Purple", 2, 11000));
            productsTypes[4].Companies[1].Products.Add(new Product("Gray", 10, 12500));

            productsTypes.Add(new ProductType("PSU"));
            productsTypes[5].Companies.Add(new Company("Breeze"));
            productsTypes[5].Companies[0].Products.Add(new Product("Icicle", 193, 3099));
            productsTypes[5].Companies[0].Products.Add(new Product("IceFloe", 72, 3900));
            productsTypes[5].Companies[0].Products.Add(new Product("Iceberg", 4, 5000));

            return productsTypes;
        }
    }
}

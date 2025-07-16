using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.FlexGrid;

namespace RightToLeft
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // get data
            var sql = @"
                    SELECT DISTINCT Categories.CategoryName,
	                    Products.SupplierID,
	                    Products.ProductName,
	                    Products.QuantityPerUnit,
	                    Products.UnitPrice
                    FROM 
	                    (Products INNER JOIN Categories
	                    ON Categories.CategoryID = Products.CategoryID);";
            //sql = new OleDbDataAdapter("select * from products", GetConnectionString());
            //sql = new OleDbDataAdapter("select PRODUCTID, PRODUCTNAME from products WHERE PRODUCTID <= 3", GetConnectionString());
            var da = new OleDbDataAdapter(sql, GetConnectionString());
            var dt = new DataTable();
            da.Fill(dt);

            // bind grids
            dataGridView1.DataSource = dt;
            _flex.DataSource = dt;

            // configure FlexGrid
            _flex.Styles.Normal.Trimming = StringTrimming.EllipsisCharacter;
            _flex.Cols["CategoryName"].ComboList = "Yes|No|Sometimes";
            _flex.Cols["ProductName"].ComboList = "|Yes|No|Sometimes";
            for (int i = (int)CellStyleEnum.Subtotal0; i <= (int)CellStyleEnum.Subtotal5; i++)
            {
                _flex.Styles[(CellStyleEnum)i].BackColor = SystemColors.Control;
            }
        }

        // get data from default location
        static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }

        // handle toolstrip commands
        void _btnRightToLeft_Click(object sender, EventArgs e)
        {
            // change RightToLeft on the form; both grids will pick it up automatically
            this.RightToLeft = _btnRightToLeft.Checked
                ? System.Windows.Forms.RightToLeft.Yes
                : System.Windows.Forms.RightToLeft.No;
        }
        void _btnScrollHome_Click(object sender, EventArgs e)
        {
            _flex.ScrollPosition = Point.Empty;
        }
        void _btnSelectHome_Click(object sender, EventArgs e)
        {
            _flex.Select(1, 1, true);
        }
        void _btnSelectEnd_Click(object sender, EventArgs e)
        {
            _flex.Select(_flex.Rows.Count - 1, _flex.Cols.Count - 1, true);
        }
        void _btnRenderMode_Click(object sender, EventArgs e)
        {
            _flex.UseCompatibleTextRendering = !_btnRenderMode.Checked;
        }
        void _btnOutlineTree_Click(object sender, EventArgs e)
        {
            _flex.BeginUpdate();

            _flex.Subtotal(AggregateEnum.Clear);
            if (_btnOutlineTree.Checked)
            {
                _flex.Tree.Style = TreeStyleFlags.Complete;
                _flex.Tree.Column = 1;
                _flex.Tree.Indent = 20;
                _flex.Tree.LineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                _flex.Tree.LineColor = Color.Red;
                _flex.AllowMerging = AllowMergingEnum.Nodes;
                _flex.Subtotal(AggregateEnum.None, 0, "CategoryName", "CategoryName");
                _flex.Subtotal(AggregateEnum.None, 1, "SupplierID", "CategoryName");
                _flex.Subtotal(AggregateEnum.None, 2, "ProductName", "CategoryName");
                _flex.AutoSizeCol(_flex.Tree.Column);
            }

            _flex.EndUpdate();
        }
        void _btnBelow_Click(object sender, EventArgs e)
        {
            _flex.SubtotalPosition = _btnBelow.Checked
                ? SubtotalPositionEnum.BelowData
                : SubtotalPositionEnum.AboveData;

            // rebuild the tree if necessary
            if (_btnOutlineTree.Checked)
            {
                _btnOutlineTree.PerformClick();
                _btnOutlineTree.PerformClick();
            }
        }
        void _btnPrint_Click(object sender, EventArgs e)
        {
            _flex.PrintGrid("RTL Test", PrintGridFlags.ShowPreviewDialog);
        }
        void _btnCellLabels_Click(object sender, EventArgs e)
        {
            _flex.ShowCellLabels = _btnCellLabels.Checked;
        }
    }
}

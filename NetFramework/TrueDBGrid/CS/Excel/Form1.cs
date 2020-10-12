using System;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using C1.Win.C1TrueDBGrid;
using C1.Win.C1TrueDBGrid.Excel;
using System.Drawing;

namespace Excel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string conn = GetConnectionString();
            string sql = @"select c.CompanyName, a.OrderDate, a.ShipName, a.Freight, a.ShipCountry, d.ProductName, b.UnitPrice, Quantity, Discount 
from Orders a, [Order Details] b, Customers c, Products d 
where a.OrderID = b.OrderID and a.CustomerID = c.CustomerID and b.ProductID = d.ProductID";
            System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            c1TrueDBGrid1.DataSource = dt;
            foreach (C1DisplayColumn col in c1TrueDBGrid1.Splits[0].DisplayColumns)
            {
                col.AutoSize();
                if (col.Name == "Freight")
                    col.DataColumn.NumberFormat = "Currency";
                else if (col.Name == "ShipCountry")
                    col.Merge = ColumnMergeEnum.Free;
                else if (col.Name == "UnitPrice")
                    col.DataColumn.NumberFormat = "$0.00";
                else if (col.Name == "Discount")
                    col.DataColumn.NumberFormat = "Percent";
            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = GetFileName();
                c1TrueDBGrid1.SaveExcel(fileName, "GridDataSheet");
                Process.Start(fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            try
            {
                c1TrueDBGrid2.LoadExcel(GetFileName(), "GridDataSheet");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string GetFileName()
        {
            return Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "GridData.xlsx");
        }

        static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }
    }
}

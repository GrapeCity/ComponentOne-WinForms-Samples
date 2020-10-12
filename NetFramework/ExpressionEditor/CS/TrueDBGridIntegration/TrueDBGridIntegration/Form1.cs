using System;
using System.Data;
using System.Windows.Forms;
using C1.Win.ExpressionEditor;
using C1.Win.C1TrueDBGrid;
using System.Data.OleDb;

namespace TrueDBGridIntegration
{
    public partial class Form1 : Form
    {
        private string _expressionColumnName = "Expression";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            c1TrueDBGrid1.DataSource = GetDataSource();

            // add a calculated column
            c1TrueDBGrid1.Columns.Add(new C1DataColumn(_expressionColumnName, typeof(object)));
            c1TrueDBGrid1.Splits[0].DisplayColumns[_expressionColumnName].Visible = true;
            c1TrueDBGrid1.Splits[0].DisplayColumns[_expressionColumnName].Locked = true;
            // allow editing expression in run-time (expression icon in column header)
            c1TrueDBGrid1.Splits[0].DisplayColumns[_expressionColumnName].AllowExpressionEditing = true;
            // set expression
            c1TrueDBGrid1.Columns[_expressionColumnName].Expression = "[UnitPrice] * [UnitsInStock]";
        }
        
        #region DataSource
        private DataTable GetDataSource()
        {
            string rs = "select ProductName, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel from Products;";
            string cn = GetConnectionString();
            OleDbDataAdapter da = new OleDbDataAdapter(rs, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }
        #endregion
    }
}
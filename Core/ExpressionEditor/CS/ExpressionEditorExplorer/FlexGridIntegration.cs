using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace FlexGridIntegration
{
    public partial class FlexGridIntegration : UserControl
    {
        private string _expressionColumnName = "Expression";

        public FlexGridIntegration()
        {
            InitializeComponent();            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            c1FlexGrid1.DataSource = GetDataSource();

            // add a calculated column
            var column = c1FlexGrid1.Cols.Add();
            // the Name property for expression column should be set
            column.Name = _expressionColumnName;
            column.DataType = typeof(object);
            column.Caption = _expressionColumnName;
            column.AllowEditing = false;
            // allow editing expression in run-time (expression icon in column header)
            column.AllowExpressionEditing = true;
            // set expression
            column.Expression = "[UnitPrice] * [UnitsInStock]";
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

        private void c1FlexGrid1_Paint(object sender, PaintEventArgs e)
        {
            this.toolStripStatusLabel2.Text = c1FlexGrid1.Cols[c1FlexGrid1.Cols.Count - 1].Expression;
        }
    }
}

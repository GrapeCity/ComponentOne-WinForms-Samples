using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Collections;
using System.Collections.Generic;
using C1.ExpressionEditor.Engine;

namespace FlexGridIntegrationCustomFunction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            c1FlexGrid1.DataSource = GetDataSource();

            // add new custom function "Discount10"
            List<ExpressionItem> items = new List<ExpressionItem>();
            items.Add(new ExpressionItem("Discount10", "Discount10()", ItemType.MathFuncs));
            expressionEditorCollection1.AddFunction(items, (args)=>Convert.ToDouble(args[0]) * 0.9 , 1, 1);

            // add a calculated column
            var column = c1FlexGrid1.Cols.Add();
            column.Name = "DiscountPrice";
            column.DataType = typeof(object);
            column.Caption = "DiscountPrice";
            column.AllowEditing = false;
            column.AllowExpressionEditing = true;
            // set expression
            column.Expression = "Discount10([UnitPrice])";
            column.Format = "F2";
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

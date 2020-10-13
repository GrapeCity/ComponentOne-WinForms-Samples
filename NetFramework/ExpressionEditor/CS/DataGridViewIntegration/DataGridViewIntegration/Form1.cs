using System;
using System.Data;
using System.Windows.Forms;
using C1.Win.ExpressionEditor;
using System.Data.OleDb;

namespace DataGridViewIntegration
{
    public partial class Form1 : Form
    {
        private string _columnName;
        private ExpressionEditorForm _dialog;

        public Form1()
        {
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetDataSource();
            dataGridView1.UpdateExpression("Expression", "[UnitPrice] * [UnitsInStock]");
            dataGridView1.Columns.Add("EmptyExpression", "EmptyExpression");
        }

        private void OpenExpressionEditorDialog(string columnName)
        {
            _columnName = columnName;
            
            if (_dialog == null)
            {
                _dialog = new ExpressionEditorForm();
                _dialog.Apply += _dialog_Apply;
            }
            // set data for ExpressionEditorForm dialog
            _dialog.Text = string.Format("Edit expression of '{0}' column", columnName);
            _dialog.DataSource = dataGridView1.DataSource;
            _dialog.Expression = dataGridView1.GetExpression(columnName);

            _dialog.ShowDialog();
            if (_dialog.DialogResult == DialogResult.OK)
            {
                // update expression and evaluate it
                dataGridView1.UpdateExpression(columnName, _dialog.Expression);
                dataGridView1.Evaluate(columnName);
            }
        }
        // The Apply button was clicked
        private void _dialog_Apply(object sender, EventArgs e)
        {
            // update expression and evaluate it
            dataGridView1.UpdateExpression(_columnName, _dialog.Expression);
            dataGridView1.Evaluate(_columnName);
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var column = dataGridView1.Columns[e.ColumnIndex];
            if (!column.IsDataBound)
                OpenExpressionEditorDialog(column.Name);
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
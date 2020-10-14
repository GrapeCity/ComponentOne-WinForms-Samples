using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace ExpressionEditorExplorer.Samples
{
    using C1.Win.ExpressionEditor;
    using ExpressionEditorExplorer.Data;
    using System.Drawing;

    public partial class DataGridViewIntegration : UserControl
    {
        private string _columnName;
        private ExpressionEditorForm _dialog;


        public DataGridViewIntegration()
        {
            InitializeComponent();            
        }

        private void DataGridViewIntegration_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                // Set first columns for evaluate expression
                var expressionColumns = new List<string>() { "EmptyExpression", "Expression" };
                expressionColumns.ToList()
                    .ForEach(x =>
                    {
                        dataGridView1.Columns.Add(x, x);
                        dataGridView1.Columns[x].DefaultCellStyle.ForeColor = Color.FromArgb(204,153,102);
                    });

                // Set data source
                dataGridView1.DataSource = DataSources.GetDataSource(); ;

                // Evaluate expression column
                dataGridView1.UpdateExpression("Expression", "[UnitPrice] * [UnitsInStock]");
            }
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
            _dialog.StartPosition = FormStartPosition.CenterScreen;

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
    }
}
using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;


namespace ExpressionEditorExplorer.Samples
{
    public partial class DataBinding : UserControl
    {
        private BindingSource _data;
        public DataBinding()
        {
            InitializeComponent();
        }

        private void Evaluate()
        {
            // check if there are no errors in ExpressionEditor
            if (c1ExpressionEditor1.IsValid)
            {
                // set ItemContext - data row which needs to be calculated
                var table = _data.DataSource as DataTable;
                c1ExpressionEditor1.ItemContext = table.Rows[_data.Position];
                object result;
                // try to evaluate expression
                if (c1ExpressionEditor1.TryEvaluate(out result))
                    textBox1.Text = result.ToString();
                else
                    textBox1.Text = c1ExpressionEditor1.GetErrors()[0].ToString();
            }
        }

        private void UpdateButtons()
        {
            button2.Enabled = _data.Position != 0;
            button1.Enabled = _data.Position < _data.Count - 1;
        }

        private void DataBinding_Load(object sender, EventArgs e)
        {
            _data = new BindingSource();
            _data.DataSource = ExpressionEditorExplorer.Data.DataSources.GetProducts();
            _data.PositionChanged += _data_PositionChanged;
            
            c1ExpressionEditor1.DataSource = _data;
            c1ExpressionEditor1.IntelliErrorsEnabled = false;

            Evaluate();
        }

        private void _data_PositionChanged(object sender, EventArgs e)
        {
            Evaluate();
        }

        private void c1ExpressionEditor1_ExpressionChanged(object sender, EventArgs e)
        {
            Evaluate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_data.Position < _data.Count - 1)
                _data.Position++;
            UpdateButtons();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_data.Position > 0)
                _data.Position--;
            UpdateButtons();
        }
    }
}

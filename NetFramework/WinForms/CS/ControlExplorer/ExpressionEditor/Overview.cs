using System;
using System.Data;

namespace ControlExplorer.ExpressionEditor
{
    public partial class Overview : C1DemoForm
    {
        private DataTable _dataSource;

        public Overview()
        {
            InitializeComponent();

            AddPropertyHeader("Layout");
            AddProperty("ShowErrorBox", c1ExpressionEditor1);

            AddPropertyHeader("Syntax");
            AddProperty("SyntaxHighlighting", c1ExpressionEditor1);
            AddProperty("UnderlineErrors", c1ExpressionEditor1);

            AddPropertyHeader("IntelliSense");
            AddProperty("IntelliAutoCompletionEnabled", c1ExpressionEditor1);
            AddProperty("IntelliDescriptionEnabled", c1ExpressionEditor1);
            AddProperty("IntelliErrorsEnabled", c1ExpressionEditor1);
            AddProperty("IntelliSyntaxHighlightingEnabled", c1ExpressionEditor1);
                        
            BindData();
            AttachEvents();

            c1ExpressionEditor1.Expression = "[Variable1] + [Variable2]";
        }

        private void Evaluate()
        {
            if (c1ExpressionEditor1.IsValid)
            {
                object result;
                if (c1ExpressionEditor1.TryEvaluate(out result))
                    textBoxResult.Text = result.ToString();
                else
                    textBoxResult.Text = c1ExpressionEditor1.GetErrors()[0].ToString();
            }
        }
        
        private void BindData()
        {
            _dataSource = GetDataSource();

            c1ExpressionEditor1.DataSource = _dataSource;
            c1ExpressionEditor1.ItemContext = _dataSource.Rows[0];

            textBoxVariable1.DataSource = _dataSource;
            textBoxVariable1.DataType = typeof(int);
            textBoxVariable1.DataField = "Variable1";

            textBoxVariable2.DataSource = _dataSource;
            textBoxVariable2.DataType = typeof(int);
            textBoxVariable2.DataField = "Variable2";
        }

        private DataTable GetDataSource()
        {
            DataTable dt = new DataTable("DemoTable");
            dt.Columns.Add("Variable1", typeof(int));
            dt.Columns.Add("Variable2", typeof(int));
            dt.Rows.Add(new object[2] { 1, 2 });
            return dt;
        }

        private void AttachEvents()
        {
            _dataSource.ColumnChanged += _dataSource_ColumnChanged;
            c1ExpressionEditor1.ExpressionChanged += C1ExpressionEditor1_ExpressionChanged;
        }

        private void DetachEvents()
        {
            _dataSource.ColumnChanged -= _dataSource_ColumnChanged;
            c1ExpressionEditor1.ExpressionChanged -= C1ExpressionEditor1_ExpressionChanged;
        }

        private void C1ExpressionEditor1_ExpressionChanged(object sender, EventArgs e)
        {
            Evaluate();
        }

        private void _dataSource_ColumnChanged(object sender, DataColumnChangeEventArgs e)
        {
            Evaluate();
        }
    }
}

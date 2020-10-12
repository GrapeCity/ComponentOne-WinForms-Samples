using System;

namespace ControlExplorer.ExpressionEditor
{
    public partial class GridIntegration : C1DemoForm
    {
        private string _expression;
        private bool _allowExpressionEditing;
        private bool _init;
        private string _expressionColumnName = "Expression";

        public GridIntegration()
        {
            InitializeComponent();

            _expression = "[UnitPrice] * [UnitsInStock]";
            _allowExpressionEditing = true;

            AddProperty("AllowExpressionEditing", this);
            AddProperty("Expression", this);
        }
        
        public string Expression
        {
            get
            {
                return _expression;
            }
            set
            {
                _expression = value;
                if (_init)
                    c1FlexGrid1.Cols[_expressionColumnName].Expression = value;
            }
        }
        
        public bool AllowExpressionEditing
        {
            get
            {
                return _allowExpressionEditing;
            }
            set
            {
                _allowExpressionEditing = value;
                if (_init)
                    c1FlexGrid1.Cols[_expressionColumnName].AllowExpressionEditing = value;
            }
        }

        private void GridIntegration_Load(object sender, EventArgs e)
        {
            c1FlexGrid1.DataSource = DemoDataSource("SELECT ProductName, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel FROM Products", true);

            var column = c1FlexGrid1.Cols.Add();

            column.Name = _expressionColumnName;
            column.DataType = typeof(object);
            column.Caption = _expressionColumnName;
            column.AllowEditing = false;
            column.AllowExpressionEditing = AllowExpressionEditing;
            column.Expression = Expression;

            _init = true;
        }
    }
}

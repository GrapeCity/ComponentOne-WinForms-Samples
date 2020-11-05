using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace ExpressionEditorExplorer.Samples
{
    using ExpressionEditorExplorer.Data;
    using System.Linq;
    public partial class FlexGridIntegration : UserControl
    {
        private string _expressionColumnName = "Expression";

        public FlexGridIntegration()
        {
            InitializeComponent();            
        }
        
        private void FlexGridIntegration_Load(object sender, EventArgs e)
        {
            // Set data source
            c1FlexGrid1.DataSource = DataSources.GetProducts(); 

            // Add a calculated column
            var expressionColumn = c1FlexGrid1.Cols.Insert(1); 

            // The Name property for expression column should be set
            expressionColumn.Name = _expressionColumnName;
            expressionColumn.DataType = typeof(object);
            expressionColumn.Caption = _expressionColumnName;
            expressionColumn.AllowEditing = false;
            // Allow editing expression in run-time (expression icon in column header)
            expressionColumn.AllowExpressionEditing = true;
            expressionColumn.Style.ForeColor = Color.FromArgb(102, 51, 0);

            // Set expression
            expressionColumn.Expression = "[UnitPrice] * [UnitsInStock]";
            c1FlexGrid1.AutoSizeCols();
        }

        private void c1FlexGrid1_Paint(object sender, PaintEventArgs e)
        {
            this.toolStripStatusLabel2.Text = c1FlexGrid1.Cols[c1FlexGrid1.Cols.Count - 1].Expression;
        }
    }
}

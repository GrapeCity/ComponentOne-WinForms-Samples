using C1.CalcEngine;
using C1.CalcEngine.ExcelEngine;
using C1.Win.C1FlexGrid;
using System;
using System.Linq;
using System.Data;
using System.Collections.Generic;

namespace ControlExplorer.CalcEngine
{
    public partial class ExcelEngineDemo : C1DemoForm
    {
        private const string с_abc = "ABCDEF";
        private const string с_formula = "=Sum(sheet1!{0}) + Sum(sheet2!{1})";

        private C1CalcEngine _calcEngine;        

        public ExcelEngineDemo()
        {
            InitializeComponent();

            // Create C1CalcEngine instance with ExcelEngine
            _calcEngine = new C1CalcEngine(new ExcelEngine());

            // Set data source for the first grid.
            var data1 = GetDataTable("Sheet1");
            sheet1.DataSource = data1;
            for (int i = 1; i <= 80; i++)
                sheet1.Rows[i][0] = i;
            sheet1.AutoSizeCol(0);

            // Configure the second grid.
            LoadUnboundGrid(sheet2);
            
            // Set engine data source.
            _calcEngine.DataSource = new List<IDataSheet> { data1, sheet2 };

            // Select some cells.
            this.sheet1.Select(1, 1, 2, 2);
            sheet2.Select(3, 2, 5, 3);
        }

        // Evaluates the expression.
        private void Evaluate()
        {
            // Set the expression.
            _calcEngine.Expression = formula1.Expression;
            // Try to evaluate the expression.
            if (_calcEngine.TryEvaluate(out object result))
            {
                // Evaluation is successful. Show evaluation result.
                formula1.Result = result.ToString();
            }
            else
            {
                // Evaluation is failed. Show error message.
                formula1.Result = _calcEngine.GetErrors().FirstOrDefault()?.FullMessage ?? "";
            }
        }

        private void UpdateExpression()
        {
            // Is the expression the default expression.
            bool reset = Equals(formula1.DefaultExpression, formula1.Expression);

            // Set the expression using a predefined format.
            formula1.DefaultExpression = string.Format(с_formula, GetMark(sheet1), GetMark(sheet2));

            // Reset expression to default value.
            if (reset)
            {
                formula1.ResetExpression();
                Evaluate();
            }
        }

        private string GetMark(C1FlexGrid grid)
        {
            var sel = grid.Selection;
            return string.Format("{0}{1}:{2}{3}", с_abc[sel.LeftCol - 1], sel.TopRow, с_abc[sel.RightCol - 1], sel.BottomRow);
        }

        // Creates a data source.
        private SheetTable GetDataTable(string sheetName)
        {
            var table = new SheetTable();
            table.Name = sheetName;
            foreach (var c in с_abc)
                table.Columns.Add(c.ToString(), typeof(int));
            for (int i = 0; i < 80; i++)
                table.Rows.Add(new object[] { i * 2, i * 3, i * 4, i * 5, i * 6, i * 7 });
            return table;
        }

        // Configures the unbound grid.
        private void LoadUnboundGrid(C1FlexGrid grid)
        {
            grid.Rows.Count = 81;
            grid.Cols.Count = 7;
            for (int i = 1; i <= с_abc.Length; i++)
                grid.Rows[0][i] = с_abc[i - 1];
            for (int i = 1; i <= 80; i++)
                grid.Rows[i][0] = i;
            for (int i = 0; i < 80; i++)
                for (int j = 1; j <= с_abc.Length; j++)
                    grid.Rows[i + 1][j] = i * j;
        }

        protected override void OnThemeApplied() => formula1.ApplyTheme();

        // Handlers
        private void ExcelEngineDemo_Load(object sender, EventArgs e) => Evaluate();
        private void flexGridSheet1_SelChange(object sender, EventArgs e) => UpdateExpression();
        private void flexGridSheet2_SelChange(object sender, EventArgs e) => UpdateExpression();
        private void formula1_Evaluate(object sender, EventArgs e) => Evaluate();
    }

    public class ExcelFlexGrid : C1FlexGrid, IDataSheet
    {
        public object GetValue(int col, int row) => Rows[row + 1][col + 1];
    }

    public class SheetTable : DataTable, IDataSheet
    {
        public string Name
        {
            get => TableName;
            set => TableName = value;
        }

        public object GetValue(int col, int row)
        {
            return Rows[row][col];
        }
    }
}

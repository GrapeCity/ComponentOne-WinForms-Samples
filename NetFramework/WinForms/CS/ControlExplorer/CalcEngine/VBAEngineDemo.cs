using System;
using System.Linq;
using C1.CalcEngine;
using C1.CalcEngine.VBAEngine;

namespace ControlExplorer.CalcEngine
{
    public partial class VBAEngineDemo : C1DemoForm
    {
        private C1CalcEngine _calcEngine;

        public VBAEngineDemo()
        {
            InitializeComponent();

            // Create C1CalcEngine instance with VBAEngine
            _calcEngine = new C1CalcEngine(new VBAEngine());

            // Set data source
            c1FlexGrid1.DataSource = _calcEngine.DataSource = new Prod[]
                {
                    new Prod { Product = "Chai", Qnt = 18, Price = 18.1 },
                    new Prod { Product = "Pavlova", Qnt = 11, Price =  17.45 },
                    new Prod { Product = "Sir Rodney's Marmalade", Qnt = 1, Price = 40 },
                    new Prod { Product = "Ipoh Coffee", Qnt = 10, Price = 14.0 },
                    new Prod { Product = "Mascarpone Fabioli", Qnt = 16, Price = 32.0 },
                    new Prod { Product = "Schoggi Schokolade", Qnt = 12, Price = 43.9 },
                };
        }

        // Evaluates all the expressions.
        private void EvaluateAll()
        {
            formula1.Result = Evaluate(formula1.Expression);
            formula2.Result = Evaluate(formula2.Expression);
            formula3.Result = Evaluate(formula3.Expression);
        }

        // Evaluates the specified expression and returns the result or error message.
        private string Evaluate(string formula)
        {
            // Set current row index of the data source.
            _calcEngine.CurrentIndex = c1FlexGrid1.Selection.TopRow - 1;
            // Set the expression.
            _calcEngine.Expression = formula;
            return _calcEngine.TryEvaluate(out object result) ? result.ToString() : _calcEngine.GetErrors().FirstOrDefault()?.FullMessage ?? "";
        }

        // Handlers
        private void c1FlexGrid1_SelChange(object sender, EventArgs e) => EvaluateAll();
        private void formula1_Evaluate(object sender, EventArgs e) => formula1.Result = Evaluate(formula1.Expression);
        private void formula2_Evaluate(object sender, EventArgs e) => formula2.Result = Evaluate(formula2.Expression);
        private void formula3_Evaluate(object sender, EventArgs e) => formula3.Result = Evaluate(formula3.Expression);
    }

    public class Prod
    {
        public string Product { get; set; }
        public int Qnt { get; set; }
        public double Price { get; set; }
    }
}

using System;
using System.Linq;
using System.Windows.Forms;
using C1.CalcEngine;
using C1.CalcEngine.VBAEngine;

namespace VBAEngine
{
    public partial class Form1 : Form
    {
        private C1CalcEngine _calcEngine;

        public Form1()
        {
            InitializeComponent();

            _calcEngine = new C1CalcEngine(new C1.CalcEngine.VBAEngine.VBAEngine());
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

        private void c1FlexGrid1_SelChange(object sender, EventArgs e)
        {
            _calcEngine.CurrentIndex = c1FlexGrid1.Selection.TopRow - 1;
            labelRes1.Text = Evaluate(textBox1.Text);
            labelRes2.Text = Evaluate(textBox2.Text);
            labelRes3.Text = Evaluate(textBox3.Text);
        }

        private string Evaluate(string formula)
        {
            _calcEngine.Expression = formula;
            return _calcEngine.TryEvaluate(out object result) ? result.ToString() : _calcEngine.GetErrors().FirstOrDefault()?.FullMessage ?? "";
        }

    }

    public class Prod
    { 
        public string Product { get; set; }
        public int Qnt { get; set; }
        public double Price { get; set; }
    }
}

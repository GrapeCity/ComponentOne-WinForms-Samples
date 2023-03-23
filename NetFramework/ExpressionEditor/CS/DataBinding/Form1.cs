using System;
using System.Windows.Forms;

namespace DataBinding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Evaluate()
        {
            // check if there are no errors in ExpressionEditor
            if (c1ExpressionEditor1.IsValid)
            {
                // set ItemContext - data row which needs to be calculated
                c1ExpressionEditor1.ItemContext = this.c1NWindDataSet.Products.Rows[c1DbNavigator1.Position];
                object result;
                // try to evaluate expression
                if (c1ExpressionEditor1.TryEvaluate(out result))
                    textBox1.Text = result.ToString();
                else
                    textBox1.Text = c1ExpressionEditor1.GetErrors()[0].ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'c1NWindDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.c1NWindDataSet.Products);
        }

        private void c1ExpressionEditor1_ExpressionChanged(object sender, EventArgs e)
        {
            Evaluate();
        }

        private void c1DbNavigator1_PositionChanged(object sender, EventArgs e)
        {
            Evaluate();
        }
    }
}

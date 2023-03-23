using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeparateControls
{
    public partial class Form1 : Form
    {
        private Data _data;

        public Form1()
        {
            InitializeComponent();
            // init demo data
            _data = new Data()
            {
                Variable1 = 1,
                Variable2 = 2,
                Variable3 = 3,
                Variable4 = 4,
                Variable5 = 5
            };
            // bind data with controls
            BindData();
            AttachEvents();
        }

        #region Init
        private void AttachEvents()
        {
            _data.ValueChanged += Evaluate;
            dropDownExpression1.ExpressionChanged += Evaluate;
        }

        private void DetachEvents()
        {
            _data.ValueChanged -= Evaluate;
            dropDownExpression1.ExpressionChanged -= Evaluate;
        }

        private void BindData()
        {
            dropDownExpression1.DataSource = _data;

            c1TextBox1.DataSource = _data;
            c1TextBox1.DataType = typeof(int);
            c1TextBox1.DataField = "Variable1";

            c1TextBox2.DataSource = _data;
            c1TextBox2.DataType = typeof(int);
            c1TextBox2.DataField = "Variable2";

            c1TextBox3.DataSource = _data;
            c1TextBox3.DataType = typeof(int);
            c1TextBox3.DataField = "Variable3";

            c1TextBox4.DataSource = _data;
            c1TextBox4.DataType = typeof(int);
            c1TextBox4.DataField = "Variable4";

            c1TextBox5.DataSource = _data;
            c1TextBox5.DataType = typeof(int);
            c1TextBox5.DataField = "Variable5";
        }
        #endregion

        private void Evaluate(object sender, EventArgs e)
        {
            textResult.Text = dropDownExpression1.GetResult().ToString();
        }
    }
}

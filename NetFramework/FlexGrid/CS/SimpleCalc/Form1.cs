using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimpleCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTable _dtEngine = new DataTable();
        private void _flex_OwnerDrawCell(object sender, C1.Win.FlexGrid.OwnerDrawCellEventArgs e)
        {
            string text = _flex[e.Row, e.Col] as string;
            if (text != null && text.StartsWith("="))
            {
                try
                {
                    // use DataTable to compute expression result
                    object value = _dtEngine.Compute(text.Substring(1), string.Empty);
                    e.Text = value.ToString();
                }
                catch (Exception x)
                {
                    e.Text = "Error in formula: " + x.Message;
                }
                e.Graphics.FillRectangle(Brushes.Beige, e.Bounds);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _flex[1, 1] = "Strig"; _flex[1, 2] = "Hello";
            _flex[2, 1] = "Value"; _flex[2, 2] = 123;
            _flex[3, 1] = "Expression"; _flex[3, 2] = "=1+2+3";
        }
    }
}
using C1.Win.C1Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace RangeSliders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            c1NumericEdit1.Value = c1RangeSlider1.LowerValue;
            c1NumericEdit2.Value = c1RangeSlider1.UpperValue;

            GraphicsPath lowerArrow = new GraphicsPath();
            lowerArrow.AddPolygon(new Point[] { 
                               new Point(0, 0),
                               new Point(10, 0),
                               new Point(15, 15),
                               new Point(10, 30),
                               new Point(0, 30),
                               new Point(5, 15)
                           });

            GraphicsPath upperArrow = new GraphicsPath();
            upperArrow.AddPolygon(new Point[] { 
                               new Point(15, 0),
                               new Point(5, 0),
                               new Point(0, 15),
                               new Point(5, 30),
                               new Point(15, 30),
                               new Point(10, 15)
                           });

            c1RangeSlider2.LowerThumbPath = lowerArrow;
            c1RangeSlider2.UpperThumbPath = upperArrow;
        }

        private void c1RangeSlider1_LowerValueChanged(object sender, EventArgs e)
        {
            c1NumericEdit1.Value = c1RangeSlider2.LowerValue = ((C1RangeSlider)sender).LowerValue;
        }

        private void c1RangeSlider1_UpperValueChanged(object sender, EventArgs e)
        {
            c1NumericEdit2.Value = c1RangeSlider2.UpperValue = ((C1RangeSlider)sender).UpperValue;
        }

        private void c1RangeSlider2_LowerValueChanged(object sender, EventArgs e)
        {
            c1NumericEdit1.Value = c1RangeSlider1.LowerValue = ((C1RangeSlider)sender).LowerValue;
        }

        private void c1RangeSlider2_UpperValueChanged(object sender, EventArgs e)
        {
            c1NumericEdit2.Value = c1RangeSlider1.UpperValue = ((C1RangeSlider)sender).UpperValue;
        }

        private void c1NumericEdit1_ValueChanged(object sender, EventArgs e)
        {
            c1RangeSlider2.LowerValue = c1RangeSlider1.LowerValue = ((IConvertible)((C1NumericEdit)sender).Value).ToDouble(null);
        }

        private void c1NumericEdit2_ValueChanged(object sender, EventArgs e)
        {
            c1RangeSlider2.UpperValue = c1RangeSlider1.UpperValue = ((IConvertible)((C1NumericEdit)sender).Value).ToDouble(null);
        }

        private void c1ComboBox1_ValueChanged(object sender, EventArgs e)
        {
            c1RangeSlider2.VisualStyle = c1RangeSlider1.VisualStyle = (VisualStyle)Enum.Parse(typeof(VisualStyle), ((IConvertible)((C1ComboBox)sender).Value).ToString(null));
        }
    }
}
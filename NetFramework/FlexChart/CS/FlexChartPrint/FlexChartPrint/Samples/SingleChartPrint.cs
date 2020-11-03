using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using C1.Win.Chart;
using C1.Chart.Printing;

namespace FlexChartPrint.Samples
{
    public partial class SingleChartPrint : BaseChartPrint
    {
        public SingleChartPrint()
        {
            InitializeComponent();

            comboPrintScale.Items.Clear();
            comboPrintScale.Items.AddRange(Enum.GetNames(typeof(ChartPrinter.PrintScale)));
            comboPrintScale.SelectedIndex = 0;

            chkPreview.Checked = true;            
            DrawingRectangle = new Rectangle(100, 200, 400, 400);
        }

        protected override string Title
        {
            get { return "Single Page Printing"; }
        }

        private void btnPrint_Click(object sender, System.EventArgs e)
        {
            ChartPrinter chartPrinter = new ChartPrinter(BaseSample.FlexChart, true);

            if (BaseSample.pageSets == null)
                BaseSample.pageSets = new PageSettings() { Landscape = true };

            chartPrinter.PageSettingsProp = BaseSample.pageSets;

            if (BaseSample.prnSets != null)
            {
                chartPrinter.PrintSettingsProp = BaseSample.prnSets;
            }

            ChartPrinter.PrintScale pscale = 
                (ChartPrinter.PrintScale)Enum.Parse(typeof(ChartPrinter.PrintScale), comboPrintScale.SelectedItem as string);
            chartPrinter.UseGrayScale = chkGrayScale.Checked;
            bool usePrintPreview = chkPreview.Checked;
            bool printAsBitmap = false;
            chartPrinter.PrintCtrl(pscale, DrawingRectangle, BaseSample.pageSets, printAsBitmap, usePrintPreview);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DrawingRectangle = Rectangle.Empty;
        }

        private void comboPrintScale_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BaseSample != null)
            {
                ComboBox cb = sender as ComboBox;
                BaseSample.FlexChart.Header.Content = cb.Text;
            }
        }

        protected override void OnBaseSampleUpdated()
        {
            if (BaseSample != null)
            {
                base.OnBaseSampleUpdated();
                BaseSample.FlexChart.Header.Content = comboPrintScale.Text;
            }
        }

        #region DrawingRectangle
        private Rectangle DrawingRectangle
        {
            get
            {
                return new Rectangle(getValue(txtX), getValue(txtY),
                    getValue(txtWidth), getValue(txtHeight));
            }

            set
            {
                setValue(txtX, value.X);
                setValue(txtY, value.Y);
                setValue(txtWidth, value.Width);
                setValue(txtHeight, value.Height);
            }
        }

        private int getValue(TextBox tb)
        {
            return tb.Tag == null ? 0 : (int)tb.Tag;
        }

        private void setValue(TextBox tb, int val)
        {
            tb.Text = val.ToString();
            tb.Tag = val;
        }

        private void NumerTextValidate(object sender, CancelEventArgs e)
        {
            TextBox tb = sender as TextBox;
            foreach (char c in tb.Text.ToCharArray())
            {
                if (!char.IsDigit(c))
                {
                    e.Cancel = true;
                    MessageBox.Show("Invalid value specified. Only digits permitted",
                        "Invalid " + tb.Name.Substring(3));
                    break;
                }
            }

            int value = 0;
            if (int.TryParse(tb.Text, out value))
            {
                if (value > 10000)
                {
                    e.Cancel = true;
                    MessageBox.Show("Invalid value specified.  Value must be <= 10000.",
                        "Invalid " + tb.Name.Substring(3));
                }
                else
                {
                    tb.Tag = value;
                }
            }
        }
        #endregion
    }
}

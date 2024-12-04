using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BaseExplorer;
using C1.Win.Chart;
using C1.Chart.Printing;

namespace FlexChartExplorer.Samples
{
    public partial class SinglePagePrintControl : UserControl
    {
        private ButtonEx btnPrint, btnClear;
        private CheckBoxEx chkGrayScale, chkPreview;
        private ComboBoxEx comboPrintScale;
        private LabelEx labX, labY, labWidth, labHeight;
        private TextBox txtX, txtY, txtWidth, txtHeight;
        public FlexChart FlexChart { get; set; }
        public PageSettings PageSets { get; set; }
        public PrinterSettings PrinterSets { get; set; }
        public SinglePagePrintControl(FlexChart flexChart)
        {
            InitializeComponent();
            this.FlexChart = flexChart;

            comboPrintScale = ControlFactory.EnumBasedCombo(typeof(ChartPrinter.PrintScale), "PrintScale");
            comboPrintScale.Location = new Point(15, 17);
            labX = new LabelEx("X:") { Location = new Point(188, 17) };
            txtX = new TextBox() { Bounds = new Rectangle(211, 17, 50, 21) };
            labWidth = new LabelEx("Width:") { Location = new Point(280, 17) };
            txtWidth = new TextBox() { Bounds = new Rectangle(330, 17, 50, 21) };

            chkGrayScale = new CheckBoxEx("Use GrayScale") { Location = new Point(15, 65) };
            labY = new LabelEx("Y:") { Location = new Point(188, 65) };
            txtY = new TextBox() { Bounds = new Rectangle(211, 65, 50, 21) };
            labHeight = new LabelEx("Height") { Location = new Point(280, 65) };
            txtHeight = new TextBox() { Bounds = new Rectangle(330, 65, 50, 21) };

            chkPreview = new CheckBoxEx("Preview") { Location = new Point(15, 113), Checked = true };
            btnClear = new ButtonEx("Clear") { Bounds = new Rectangle(188, 113, 100, 25) };

            btnPrint = new ButtonEx("Print") { Bounds = new Rectangle(15, 160, 100, 25) };

            comboPrintScale.SelectedIndexChanged += (s, e) => { FlexChart.Header.Content = comboPrintScale.Text; };
            txtX.Validating += NumerTextValidate;
            txtY.Validating += NumerTextValidate;
            txtWidth.Validating += NumerTextValidate;
            txtHeight.Validating += NumerTextValidate;
            btnPrint.Click += btnPrint_Click;
            btnClear.Click += btnClear_Click;

            this.Controls.Add(comboPrintScale);
            this.Controls.Add(labX);
            this.Controls.Add(txtX);
            this.Controls.Add(labWidth);
            this.Controls.Add(txtWidth);
            this.Controls.Add(chkGrayScale);
            this.Controls.Add(labY);
            this.Controls.Add(txtY);
            this.Controls.Add(labHeight);
            this.Controls.Add(txtHeight);
            this.Controls.Add(chkPreview);
            this.Controls.Add(btnClear);
            this.Controls.Add(btnPrint);
            DrawingRectangle = new Rectangle(100, 200, 400, 400);
            FlexChart.Header.Content = "PrintScale: None";
        }
        private void btnPrint_Click(object sender, System.EventArgs e)
        {
            ChartPrinter chartPrinter = new ChartPrinter(FlexChart, true);

            if (PageSets == null)
                PageSets = new PageSettings() { Landscape = true };

            chartPrinter.PageSettingsProp = PageSets;

            if (PrinterSets != null)
            {
                chartPrinter.PrintSettingsProp = PrinterSets;
            }
            ChartPrinter.PrintScale pscale = 
                (ChartPrinter.PrintScale)Enum.Parse(typeof(ChartPrinter.PrintScale), comboPrintScale.SelectedItem.DisplayText);
            chartPrinter.UseGrayScale = chkGrayScale.Checked;
            bool usePrintPreview = chkPreview.Checked;
            bool printAsBitmap = false;
            chartPrinter.PrintCtrl(pscale, DrawingRectangle, PageSets, printAsBitmap, usePrintPreview);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DrawingRectangle = Rectangle.Empty;
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

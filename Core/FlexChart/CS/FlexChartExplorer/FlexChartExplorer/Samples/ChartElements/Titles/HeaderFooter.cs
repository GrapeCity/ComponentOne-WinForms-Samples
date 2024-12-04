using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.Chart;
using C1.Win.Chart;
using BaseExplorer;
using FlexChartExplorer.Data;
using System.IO;
using BaseExplorer.CustomControls;

namespace FlexChartExplorer.Samples
{
    public partial class HeaderFooter : FlexChartBaseSample
    {
        private LabelEx _lHeader, _lFooter;
        private TextBoxEx _tHeader, _tFooter;
        private ComboBoxEx _cbAlignment;
        private LabelEx _lblAlignment;
        private CheckBoxEx _chbBorder;
        private FlexChart flexChart1;

        public HeaderFooter()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            this.flexChart1.ChartType = ChartType.Column;
            this.flexChart1.DataSource = SalesDataSource.GetCountrySales();
            this.flexChart1.BindingX = "Name";
            this.flexChart1.Series.Add(new Series { Name="Sales", Binding = "Sales" });

            this.flexChart1.Header.Content = "Product Sales";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;
            this.flexChart1.Header.BorderStyle.StrokeColor = Color.Black;
            
            this.flexChart1.Footer.Style.Font = StyleInfo.ChartHeaderFont;
            this.flexChart1.Footer.BorderStyle.StrokeColor = Color.Black;
            
            this.flexChart1.Rendered += (s, e) =>
            {
                _tHeader.Text = flexChart1.Header.Content;
                _tFooter.Text = flexChart1.Footer.Content;
                _cbAlignment.SelectedIndex = (int)flexChart1.Header.HorizontalAlignment;
            };
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;
            
            _lHeader = new LabelEx("Header:");
            _tHeader = new TextBoxEx { ForeColor = Color.DimGray, AutoSize = false };
            _tHeader.TextChanged += (s, e) => { flexChart1.Header.Content = _tHeader.Text; };

            _lFooter = new LabelEx("Footer:");
            _tFooter = new TextBoxEx { AutoSize = false, ForeColor = Color.DimGray };
            _tFooter.TextChanged += (s, e) => { flexChart1.Footer.Content = _tFooter.Text; };

            _cbAlignment = ControlFactory.EnumBasedCombo(typeof(HorizontalAlignment), "Alignment");
            _cbAlignment.SelectedIndexChanged += (s, e) => 
            {
                flexChart1.Header.HorizontalAlignment = flexChart1.Footer.HorizontalAlignment = (HorizontalAlignment)Enum.Parse(typeof(HorizontalAlignment), _cbAlignment.SelectedItem.DisplayText);
            };

            _chbBorder = new CheckBoxEx("Border");
            _chbBorder.CheckedChanged += (s, e) => { flexChart1.Header.Border = flexChart1.Footer.Border = _chbBorder.Checked; };

            _lblAlignment = new LabelEx("Alignment:");

            this.pnlControls.Controls.Add(_lHeader);
            this.pnlControls.Controls.Add(_tHeader);
            this.pnlControls.Controls.Add(_lFooter);
            this.pnlControls.Controls.Add(_tFooter);
            this.pnlControls.Controls.Add(_lblAlignment);
            this.pnlControls.Controls.Add(_cbAlignment);
            this.pnlControls.Controls.Add(_chbBorder);
        }
        public override Image GetImage(int width = 200, int height = 200)
        {
            Bitmap bmp;
            using(var ms = new MemoryStream())
            {
                flexChart1.SaveImage(ms, ImageFormat.Png, flexChart1.Width, flexChart1.Height);
                bmp = new Bitmap(ms);
            }
            return bmp;
        }
    }
}

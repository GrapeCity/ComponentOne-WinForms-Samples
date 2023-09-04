using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.Win.Chart;
using System.Drawing.Drawing2D;
using C1.Chart;
using System.IO;

namespace FlexChart101.Samples
{
    public partial class LegendAndTitles : UserControl
    {
        public LegendAndTitles()
        {
            InitializeComponent();
            InitializeControls();

            SetupChart();
        }

        void SetupChart()
        {
            flexChart1.BeginUpdate();

            flexChart1.Series.Clear();

            // Add 2 data series
            var s1 = new Series();
            s1.Binding = s1.Name = "DomesticSales";
            s1.LegendGroup = "Sales";
            flexChart1.Series.Add(s1);

            var s2 = new Series();
            s2.Binding = s2.Name = "DomesticExpenses";
            s2.LegendGroup = "Expenses";
            flexChart1.Series.Add(s2);

            var s3 = new Series();
            s3.Binding = s3.Name = "ExportSales";
            s3.LegendGroup = "Sales";
            flexChart1.Series.Add(s3);

            var s4 = new Series();
            s4.Binding = s4.Name = "ExportExpenses";
            s4.LegendGroup = "Expenses";
            flexChart1.Series.Add(s4);

            // Set x-binding and add data to the chart
            flexChart1.BindingX = "Country";
            flexChart1.DataSource = new[]
            {
                new { Country = "UK", DomesticSales = 5, DomesticExpenses = 4, ExportSales = 6, ExportExpenses = 5},
                new { Country = "USA", DomesticSales = 7, DomesticExpenses = 6, ExportSales = 3, ExportExpenses = 2},
                new { Country = "Germany", DomesticSales = 8, DomesticExpenses = 5, ExportSales = 10, ExportExpenses = 6},
                new { Country = "Japan", DomesticSales = 12, DomesticExpenses = 8, ExportSales = 10, ExportExpenses = 7},
            };

            // Add header and footer
            flexChart1.Header.Content = "Sample Chart";
            flexChart1.Footer.Content = "copyright © Mescius, Inc.";
            flexChart1.AxisX.Title = "Country";
            flexChart1.AxisY.Title = "Amount";
            flexChart1.Legend.Position = Position.Right;
            flexChart1.Legend.GroupHeaderStyle.Font = new Font(FontFamily.GenericSansSerif, 14);

            flexChart1.Header.Style.Font = flexChart1.Footer.Style.Font = new Font(FontFamily.GenericSansSerif, 20);
            flexChart1.Header.Style.FillColor = flexChart1.Footer.Style.FillColor = Color.DimGray;
            flexChart1.AxisX.Style.Font = flexChart1.AxisY.Style.Font = new Font(FontFamily.GenericSansSerif, 10);
            flexChart1.EndUpdate();
        }

        public class DataItem
        {
            public int Amount { get; set; }
            public string Month { get; set; }

        }

        private void InitializeControls()
        {
            //Set localized text
            baseSample1.lblTitle.Text = Localizer.GetItem("legendandtitles", "title");
            baseSample1.pDescription.Height = 90;
            baseSample1.tbDescription.Rtf = Localizer.GetItem("legendandtitles", "description").MakeRtf();

            baseSample1.tbCode.Text = @"// Add header, footer and legend options
flexChart1.Header.Content = ""Sample Chart"";
flexChart1.Footer.Content = ""copyright (c) ComponentOne"";
flexChart1.AxisX.Title = ""Country"";
flexChart1.AxisY.Title = ""Amount"";
flexChart1.Legend.Position = Position.Right;
foreach (Series ser in flexChart1.Series)
   ser.LegendGroup = (ser.Name.IndexOf(""Sales"") > -1) ? ""Sales"" : ""Expenses"";";

            flexChart1 = baseSample1.flexChart1;

            Label lblHeader = new Label()
            {
                Text = "Header: ",
                ForeColor = Color.DimGray,
                TextAlign = ContentAlignment.MiddleRight,
                Width = 70
            };

            TextBox tbHeader = new TextBox()
            {
                Text = "Sample Chart",
                BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D,
                ForeColor = Color.DimGray,
                Width = 100
            };
            tbHeader.TextChanged += tbHeader_TextChanged;

            Label lblFooter = new Label()
            {
                Text = "Footer: ",
                ForeColor = Color.DimGray,
                TextAlign = ContentAlignment.MiddleRight,
                Width = 70
            };

            TextBox tbFooter = new TextBox()
            {
                Text = "copyright © Mescius, Inc.",
                BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D,
                ForeColor = Color.DimGray,
                Width = 150,
            };
            tbFooter.TextChanged += tbFooter_TextChanged;

            Label lblAxisXTitle = new Label()
            {
                Text = "AxisX title: ",
                ForeColor = Color.DimGray,
                TextAlign = ContentAlignment.MiddleRight,
                Width = 70
            };
            TextBox tbAxisXTitle = new TextBox()
            {
                Text = "Country",
                BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D,
                ForeColor = Color.DimGray,
                Width = 100
            };
            tbAxisXTitle.TextChanged += tbAxisXTitle_TextChanged;

            Label lblAxisYTitle = new Label()
            {
                Text = "AxisY title: ",
                ForeColor = Color.DimGray,
                TextAlign = ContentAlignment.MiddleRight,
                Width = 70
            };
            TextBox tbAxisYTitle = new TextBox()
            {
                Text = "Amount",
                BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D,
                ForeColor = Color.DimGray,
                Width = 100
            };
            tbAxisYTitle.TextChanged += tbAxisYTitle_TextChanged;

            Label lblLegend = new Label()
            {
                Text = "Legend: ",
                ForeColor = Color.DimGray,
                TextAlign = ContentAlignment.MiddleRight,
                Margin = new Padding(50,0,0,0),
                Width = 70
            };
            ComboBox cbLegend = new ComboBox()
            {
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.DimGray,
                DropDownStyle = ComboBoxStyle.DropDownList,
                Width = 100
            };

            foreach (var item in Enum.GetValues(typeof(C1.Chart.Position)))
                cbLegend.Items.Add(new ComboBoxItem("Legend") { Text = ((C1.Chart.Position)item).ToString(), Value = (int)item });
            cbLegend.SelectedIndexChanged += cbLegend_SelectedIndexChanged;
            cbLegend.SelectedIndex = 1;

            CheckBox cbReversed = new CheckBox()
            {
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.DimGray,
                Text = "Reversed",
                Checked = false
            };
            CheckBox cbGrouped = new CheckBox()
            {
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.DimGray,
                Text = "Grouped",
                Checked = true
            };
            cbReversed.CheckedChanged += cbReversed_CheckedChanged;
            cbGrouped.CheckedChanged += cbGrouped_CheckedChanged;

            baseSample1.pControls.SetFlowBreak(cbGrouped, true);
            baseSample1.pControls.SetFlowBreak(cbLegend, true);
            baseSample1.pControls.SetFlowBreak(tbAxisYTitle, true);
            baseSample1.pControls.SetFlowBreak(tbAxisXTitle, true);
            baseSample1.pControls.SetFlowBreak(tbFooter, true);
            baseSample1.pControls.SetFlowBreak(tbHeader, true);

            baseSample1.pControls.Controls.Add(lblHeader);
            baseSample1.pControls.Controls.Add(tbHeader);
            baseSample1.pControls.Controls.Add(lblFooter);
            baseSample1.pControls.Controls.Add(tbFooter);
            baseSample1.pControls.Controls.Add(lblAxisXTitle);
            baseSample1.pControls.Controls.Add(tbAxisXTitle);
            baseSample1.pControls.Controls.Add(lblAxisYTitle);
            baseSample1.pControls.Controls.Add(tbAxisYTitle);
            baseSample1.pControls.Controls.Add(lblLegend);
            baseSample1.pControls.Controls.Add(cbLegend);
            baseSample1.pControls.Controls.Add(cbReversed);
            baseSample1.pControls.Controls.Add(cbGrouped);            
        }

        void cbReversed_CheckedChanged(object sender, EventArgs e)
        {
            flexChart1.Legend.Reversed = (sender as CheckBox).Checked;
        }

        void cbGrouped_CheckedChanged(object sender, EventArgs e)
        {
            bool grouped = (sender as CheckBox).Checked;

            foreach (Series ser in flexChart1.Series)
                ser.LegendGroup = grouped ? ((ser.Name.IndexOf("Sales") > -1) ? "Sales" : "Expenses") : null;
        }

        void cbLegend_SelectedIndexChanged(object sender, EventArgs e)
        {
            flexChart1.Legend.Position = (C1.Chart.Position)Enum.Parse(typeof(C1.Chart.Position), ((sender as ComboBox).SelectedItem as ComboBoxItem).Text);
        }

        private void tbAxisYTitle_TextChanged(object sender, EventArgs e)
        {
            flexChart1.AxisY.Title = (sender as TextBox).Text;
        }

        private void tbAxisXTitle_TextChanged(object sender, EventArgs e)
        {
            flexChart1.AxisX.Title = (sender as TextBox).Text;
        }

        private void tbFooter_TextChanged(object sender, EventArgs e)
        {
            flexChart1.Footer.Content = (sender as TextBox).Text;
        }

        void tbHeader_TextChanged(object sender, EventArgs e)
        {
            flexChart1.Header.Content = (sender as TextBox).Text;
        }
    }
}

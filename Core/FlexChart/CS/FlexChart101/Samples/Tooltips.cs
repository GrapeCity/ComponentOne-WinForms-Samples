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

namespace FlexChart101.Samples
{
    public partial class Tooltips : UserControl
    {
        public Tooltips()
        {
            InitializeComponent();
            InitializeControls();

            SetupChart();
        }

        void SetupChart()
        {
            flexChart1.BeginUpdate();

            flexChart1.Series.Clear();

            // Add data series
            var s1 = new Series();
            s1.Binding = s1.Name = "Sales";
            flexChart1.Series.Add(s1);

            var s2 = new Series();
            s2.Binding = s2.Name = "Expenses";
            flexChart1.Series.Add(s2);

            // Set x-binding and add data to the chart
            flexChart1.BindingX = "Country";
            flexChart1.DataSource = new[]
            {
                new { Country = "UK", Sales = 5, Expenses = 4},
                new { Country = "USA", Sales = 7, Expenses = 3},
                new { Country = "Germany", Sales = 8, Expenses = 5},
                new { Country = "Japan", Sales = 12, Expenses = 8},
            };

            // Set tooltip
            flexChart1.ToolTip.Content = "{seriesName}\r\n{x}-{y}";

            flexChart1.EndUpdate();
        }

        private void InitializeControls()
        {
            // Set localized text
            baseSample1.lblTitle.Text = Localizer.GetItem("tooltips", "title");
            baseSample1.pDescription.Height = 180;
            baseSample1.tbDescription.Rtf = Localizer.GetItem("tooltips", "description").MakeRtf();

            baseSample1.tbCode.Text = @"// Set tooltip
flexChart1.ToolTip.Content = ""{seriesName}\r\n{x}-{y}"";";

            flexChart1 = baseSample1.flexChart1;
            baseSample1.pControls.Visible = false;

        }
    }
}

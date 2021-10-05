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
    public partial class CustomizingAxes : UserControl
    {
        public CustomizingAxes()
        {
            InitializeComponent();
            InitializeControls();

            SetupChart();
        }

        void SetupChart()
        {
            flexChart1.BeginUpdate();

            flexChart1.Series.Clear();

            // Add 3 data series
            var s1 = new Series();
            s1.Binding = s1.Name = "March";
            flexChart1.Series.Add(s1);

            var s2 = new Series();
            s2.Binding = s2.Name = "April";
            flexChart1.Series.Add(s2);

            var s3 = new Series();
            s3.Binding = s3.Name = "May";
            flexChart1.Series.Add(s3);

            // Set x-binding and add data to the chart
            flexChart1.BindingX = "Fruit";
            flexChart1.DataSource = DataCreator.CreateFruit();

            // Set axis properties
            flexChart1.AxisY.Min = 0;
            flexChart1.AxisY.Max = 10;
            flexChart1.AxisY.AxisLine = true;
            flexChart1.AxisY.Labels = false;
            flexChart1.AxisY.MajorGrid = false;
            flexChart1.AxisY.MajorTickMarks = C1.Chart.TickMark.Outside;

            flexChart1.EndUpdate();
        }

        private void InitializeControls()
        {
            //Set localized text
            baseSample1.lblTitle.Text = Localizer.GetItem("customizingaxes", "title");
            baseSample1.pDescription.Height = 120;
            baseSample1.tbDescription.Rtf = Localizer.GetItem("customizingaxes", "description").MakeRtf();

            baseSample1.tbCode.Text = @"// Set axis properties
flexChart1.AxisY.AxisLine = true;
flexChart1.AxisY.Labels = false;
flexChart1.AxisY.MajorGrid = false;
flexChart1.AxisY.MajorTickMarks = C1.Chart.TickMark.Outside;
flexChart1.AxisY.Min = 0;
flexChart1.AxisY.Max = 10;";

            flexChart1 = baseSample1.flexChart1;
            baseSample1.pControls.Visible = false;
        }
    }
}

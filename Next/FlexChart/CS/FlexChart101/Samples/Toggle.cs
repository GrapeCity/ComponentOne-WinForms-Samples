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
    public partial class Toggle : UserControl
    {
        public Toggle()
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

            flexChart1.LegendToggle = true;

            flexChart1.EndUpdate();
        }

        private void chb_CheckedChanged(object sender, EventArgs e)
        {
            var chb = (sender as CheckBox);
            if (chb == null) return;
            var serie = flexChart1.Series.FirstOrDefault(x => x.Name == chb.Text);
            if (serie == null) return;
            else serie.Visibility = chb.Checked 
                    ? C1.Chart.SeriesVisibility.Visible 
                    : C1.Chart.SeriesVisibility.Legend;
        }

        private void InitializeControls()
        {
            #region Init controls

            //Set localized text
            baseSample1.lblTitle.Text = Localizer.GetItem("toggle", "title");
            baseSample1.pDescription.Height = 200;
            baseSample1.tbDescription.Rtf = Localizer.GetItem("toggle", "description").MakeRtf();

            baseSample1.tbCode.Text = @"//FlexChart LegendToggle property
flexChart1.LegendToggle = true;

//OR you can change visibility manually
serie.Visibility = C1.Chart.SeriesVisibility.Legend;";

            flexChart1 = baseSample1.flexChart1;

            chbMarch = new CheckBox()
            {
                Text = "March",
                Location = new Point(40, 5),
                FlatStyle = FlatStyle.Flat,
                Checked = true
            };
            chbMarch.CheckedChanged += chb_CheckedChanged;

            chbApril = new CheckBox()
            {
                Text = "April",
                Location = new Point(chbMarch.Right + 10, 5),
                FlatStyle = FlatStyle.Flat,
                Checked = true
            };
            chbApril.CheckedChanged += chb_CheckedChanged;

            chbMay = new CheckBox()
            {
                Text = "May",
                Location = new Point(chbApril.Right, 5),
                FlatStyle = FlatStyle.Flat,
                Checked = true
            };
            chbMay.CheckedChanged += chb_CheckedChanged;

            baseSample1.pControls.Controls.Add(chbMarch);
            baseSample1.pControls.Controls.Add(chbApril);
            baseSample1.pControls.Controls.Add(chbMay);
            #endregion
        }
    }
}

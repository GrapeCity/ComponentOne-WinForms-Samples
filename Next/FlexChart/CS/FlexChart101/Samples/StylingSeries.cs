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
    public partial class StylingSeries : UserControl
    {
        public StylingSeries()
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

            flexChart1.EndUpdate();
        }

        private void cbPalette_SelectedIndexChanged(object sender, EventArgs e)
        {
            flexChart1.Palette = (C1.Chart.Palette)Enum.Parse(typeof(C1.Chart.Palette), (cbPalette.SelectedItem as ComboBoxItem).Text);
        }

        private void InitializeControls()
        {
            #region Init controls

            // Set localized text
            baseSample1.lblTitle.Text = Localizer.GetItem("stylingseries", "title");
            baseSample1.pDescription.Height = 100;
            baseSample1.tbDescription.Rtf = Localizer.GetItem("stylingseries", "description").MakeRtf();

            baseSample1.tbCode.Text = @"// Set FlexChart.Palette property
flexChart1.Palette = C1.Chart.Palette.Dark;

// OR you can set up style manually
var s1 = new Series();
s1.Style.Fill = new SolidBrush(Color.Yellow);
s1.Style.Stroke = new SolidBrush(Color.Blue);
s1.Style.StrokeWidth = 1;";

            flexChart1 = baseSample1.flexChart1;

            // Initialize Palette combo box
            cbPalette = new ComboBox()
            {
                Width = 150,
                Dock = DockStyle.Top,
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.DimGray,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cbPalette.SelectedIndexChanged += cbPalette_SelectedIndexChanged;

            baseSample1.pControls.Controls.Add(cbPalette);
            #endregion
            foreach (var item in Enum.GetValues(typeof(C1.Chart.Palette)))
                cbPalette.Items.Add(new ComboBoxItem("Palette ") { Text = ((C1.Chart.Palette)item).ToString(), Value = (int)item });
            cbPalette.SelectedIndex = 0;
        }
    }
}

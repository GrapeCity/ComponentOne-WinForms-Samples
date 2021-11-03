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
using C1.Win.Chart.Interaction;

namespace LineMarkerExplorer.Samples
{
    public partial class Introduction : UserControl
    {
        protected LineMarker lineMarker;
        public Introduction()
        {
            InitializeComponent();
            InitializeControls();

            SetupChart();

            Disposed += Introduction_Disposed;
        }

        void Introduction_Disposed(object sender, EventArgs e)
        {
            lineMarker.Remove();
        }

        void SetupChart()
        {
            flexChart1 = baseSample1.flexChart1;

            var rnd = new Random();
            var pointsCount = rnd.Next(1, 30);

            var pointsList = new List<DataItem>();

            DateTime startDate = new DateTime(DateTime.Now.Year - 1, 1, 1);
            for (DateTime date = startDate; date.Month < startDate.AddMonths(2).Month; date += TimeSpan.FromDays(1.0))
            {
                pointsList.Add(new DataItem()
                {
                    Date = date,
                    Input = rnd.Next(1, 9),
                    Output = rnd.Next(10, 19)
                });
            }

            flexChart1.BeginUpdate();
            flexChart1.Series.Clear();
            flexChart1.ChartType = C1.Chart.ChartType.Line;

            flexChart1.BindingX = "Date";

            var outputSerie = new Series() { Name = "Output", Binding = "Output" };
            outputSerie.Style.StrokeColor = Color.FromArgb(255, 251, 178, 88);
            flexChart1.Series.Add(outputSerie);

            var inputSerie = new Series() { Name = "Input", Binding = "Input" };
            inputSerie.Style.StrokeColor = Color.FromArgb(255, 136, 189, 230);
            flexChart1.Series.Add(inputSerie);

            flexChart1.DataSource = pointsList.ToArray();

            flexChart1.EndUpdate();

            flexChart1.Rendered += flexChart1_Rendered;
        }

        void flexChart1_Rendered(object sender, RenderEventArgs e)
        {
            if (lineMarker == null)
            {
                lineMarker = new LineMarker(flexChart1);
                lineMarker.LineWidth = 2;
                lineMarker.DragThreshold = 10;
                lineMarker.Content = "Output={Output}\nInput={Input}";
                lineMarker.VerticalPosition = 0.5;
                lineMarker.HorizontalPosition = 0.5;

                cbLines.SelectedIndex = 3;
                cbInteraction.SelectedIndex = 1;
                cbAlignment.SelectedIndex = 0;               
            }
        }
        class DataItem
        {
            public int Input { get; set; }
            public int Output { get; set; }
            public DateTime Date { get; set; }
        }

        private void cbLines_SelectedIndexChanged(object sender, EventArgs e)
        {
            lineMarker.Lines = (LineMarkerLines)Enum.Parse(typeof(LineMarkerLines), (cbLines.SelectedItem as ComboBoxItem).Text);
        }

        private void cbAlignment_SelectedIndexChanged1(object sender, EventArgs e)
        {
            lineMarker.Alignment = (LineMarkerAlignment)Enum.Parse(typeof(LineMarkerAlignment), (cbAlignment.SelectedItem as ComboBoxItem).Text);
        }

        private void cbInteraction_SelectedIndexChanged(object sender, EventArgs e)
        {
            lineMarker.Interaction = (LineMarkerInteraction)Enum.Parse(typeof(LineMarkerInteraction), (cbInteraction.SelectedItem as ComboBoxItem).Text);
        }

        private void InitializeControls()
        {

            #region Init controls

            //Set localized text
            baseSample1.lblTitle.Text = Localizer.GetItem("introduction", "title");
            baseSample1.tbDescription.Rtf = Localizer.GetItem("introduction", "description").MakeRtf();

            //Init ChartType combobox
            cbLines = new ComboBox()
            {
                Size = new Size(200, 21),
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.DimGray
            };
            cbLines.SelectedIndexChanged += cbLines_SelectedIndexChanged;

            //Init Palette combobox
            cbInteraction = new ComboBox()
            {
                Size = new Size(200, 21),
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.DimGray
            };
            cbInteraction.SelectedIndexChanged += cbInteraction_SelectedIndexChanged;

            //Init Stacked combobox
            cbAlignment = new ComboBox()
            {
                Size = new Size(200, 21),
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.DimGray
            };
            cbAlignment.SelectedIndexChanged += cbAlignment_SelectedIndexChanged1;

            baseSample1.pControls.Controls.Add(cbLines);
            baseSample1.pControls.Controls.Add(cbInteraction);
            baseSample1.pControls.Controls.Add(cbAlignment);
            #endregion

            foreach (var item in Enum.GetValues(typeof(LineMarkerLines)))
                cbLines.Items.Add(new ComboBoxItem("Lines") { Text = ((LineMarkerLines)item).ToString(), Value = (int)item });

            foreach (var item in Enum.GetValues(typeof(LineMarkerInteraction)))
                cbInteraction.Items.Add(new ComboBoxItem("Interaction") { Text = ((LineMarkerInteraction)item).ToString(), Value = (int)item });

            foreach (var item in Enum.GetValues(typeof(LineMarkerAlignment)))
                cbAlignment.Items.Add(new ComboBoxItem("Alignment") { Text = ((LineMarkerAlignment)item).ToString(), Value = (int)item });
        }
    }
}

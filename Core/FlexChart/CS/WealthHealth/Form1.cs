using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WealthHealth.Model;

namespace WealthHealth
{
    public partial class Form1 : Form
    {
        WealthHealth.Services.DataService dataService;
        int year = 1800;
        Font yearFont;
        SolidBrush yearBrush;
        Dictionary<string, SolidBrush> dataBrushes = new Dictionary<string, SolidBrush>();
        Dictionary<string, SolidBrush> selDataBrushes = new Dictionary<string, SolidBrush>();
        Dictionary<string, SolidBrush> opaqDataBrushes = new Dictionary<string, SolidBrush>();

        Timer timer;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataService = new WealthHealth.Services.DataService();

            // year watermark
            yearFont = new Font( flexChart1.Font.FontFamily, 120);
            yearBrush = new SolidBrush(Color.FromArgb(0x2000916f));

            // custom brushes for data
            dataBrushes.Add("Sub-Saharan Africa", new SolidBrush(Color.FromArgb(0x7F1F77B4)));
            dataBrushes.Add("South Asia", new SolidBrush(Color.FromArgb(0x7FFF7F0E)));
            dataBrushes.Add("Middle East & North Africa", new SolidBrush(Color.FromArgb(0x7F2CA02C)));
            dataBrushes.Add("America", new SolidBrush(Color.FromArgb(0x7FD62728)));
            dataBrushes.Add("Europe & Central Asia", new SolidBrush(Color.FromArgb(0x7F9467BD)));
            dataBrushes.Add("East Asia & Pacific", new SolidBrush(Color.FromArgb(0x7F8C564B)));

            selDataBrushes.Add("Sub-Saharan Africa", new SolidBrush(Color.FromArgb(0x2F1F77B4)));
            selDataBrushes.Add("South Asia", new SolidBrush(Color.FromArgb(0x2FFF7F0E)));
            selDataBrushes.Add("Middle East & North Africa", new SolidBrush(Color.FromArgb(0x2F2CA02C)));
            selDataBrushes.Add("America", new SolidBrush(Color.FromArgb(0x2FD62728)));
            selDataBrushes.Add("Europe & Central Asia", new SolidBrush(Color.FromArgb(0x2F9467BD)));
            selDataBrushes.Add("East Asia & Pacific", new SolidBrush(Color.FromArgb(0x2F8C564B)));

            opaqDataBrushes.Add("Sub-Saharan Africa", new SolidBrush(Color.FromArgb(0xFF, 0x1F, 0x77, 0xB4)));
            opaqDataBrushes.Add("South Asia", new SolidBrush(Color.FromArgb(0xFF, 0xFF, 0x7F, 0x0E)));
            opaqDataBrushes.Add("Middle East & North Africa", new SolidBrush(Color.FromArgb(0xFF, 0x2C, 0xA0, 0x2C)));
            opaqDataBrushes.Add("America", new SolidBrush(Color.FromArgb(0xFF, 0xD6, 0x27, 0x28)));
            opaqDataBrushes.Add("Europe & Central Asia", new SolidBrush(Color.FromArgb(0xFF, 0x94, 0x67, 0xBD)));
            opaqDataBrushes.Add("East Asia & Pacific", new SolidBrush(Color.FromArgb(0xFF, 0x8C, 0x56, 0x4B)));

            // timer for animation
            timer = new Timer() { Interval = 50 };
            timer.Tick += Timer_Tick;

            UpdateTrackingText();

            // setup chart
            flexChart1.BeginUpdate();
            flexChart1.Series.Clear();

            flexChart1.Binding = "LifeExpectancy,Population";
            flexChart1.BindingX = "Income";
            flexChart1.ChartType = C1.Chart.ChartType.Bubble;
            var ser = new C1.Win.Chart.Series();
            ser.SymbolStyle.Stroke = Brushes.Transparent;
            ser.SymbolRendering += Ser_SymbolRendering;
            flexChart1.Series.Add(ser);

            flexChart1.Options.BubbleMaxSize = 100;

            flexChart1.AxisX.LogBase = 10;
            flexChart1.AxisX.Min = 300;
            flexChart1.AxisX.Max = 100000;
            flexChart1.AxisX.Title = "income per capita (inflation-adjusted US dollars)";

            flexChart1.AxisY.Min = 20;
            flexChart1.AxisY.Max = 85;
            flexChart1.AxisY.Title = "life expectancy (years)";

            flexChart1.Rendering += FlexChart1_Rendering;
            flexChart1.ToolTip.Content = "{Country}\n{PopulationMillions}";

            flexChart1.SelectionMode = C1.Chart.ChartSelectionMode.Point;
            flexChart1.SelectionStyle.StrokeWidth = 3;
            flexChart1.SelectionStyle.StrokeColor = Color.DarkBlue;

            flexChart1.SelectionChanged += (s, a) => UpdateTrackingText();

            UpdateData();
            flexChart1.EndUpdate();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (trackBar1.Value == trackBar1.Maximum)
                StopAnimation();
            else
                trackBar1.Value += 1;
        }

        private void FlexChart1_Rendering(object sender, C1.Win.Chart.RenderEventArgs e)
        {
            if (e.Graphics == null)
                return;

            // render year watermark
            var plotRect = flexChart1.PlotRect;
            var s = year.ToString();
            var sz = e.Graphics.MeasureString(s, yearFont, new PointF(), StringFormat.GenericTypographic);
            e.Graphics.DrawString( s, yearFont, yearBrush, plotRect.Right - sz.Width, 
                plotRect.Bottom - sz.Height, StringFormat.GenericTypographic);
        }

        private void Ser_SymbolRendering(object sender, C1.Win.Chart.RenderSymbolEventArgs e)
        {
            var item = (DataItem)e.Item;
            // set symbol color based on country region
            if (flexChart1.SelectedIndex >= 0)
            {
                if (flexChart1.SelectedIndex == e.Index)
                    e.Engine.SetFill(dataBrushes[item.Region]);
                else
                    e.Engine.SetFill(selDataBrushes[item.Region]);
            }
            else
                e.Engine.SetFill(dataBrushes[item.Region]);
        }

        void UpdateData()
        {
            string selectedCountry = GetSelectedCountry();
            var data = dataService.GetDataByYear(year);
            flexChart1.BeginUpdate();
            flexChart1.DataSource = data;
            // index of country may be different 
            if (selectedCountry != null)
                flexChart1.SelectedIndex = data.IndexOf(data.Find( item=>item.Country == selectedCountry));
            flexChart1.EndUpdate();
        }

        void UpdateTrackingText()
        {
            textBox3.Text = flexChart1.SelectedIndex >= 0 ? 
                string.Format("Now tracking: {0}", GetSelectedCountry()) :
                "Try clicking a bubble to track a country's evolution through the animation.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
                StopAnimation();
            else
                StartAnimation();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            year = trackBar1.Value;
            UpdateData();
        }

        void StartAnimation()
        {
            timer.Start();
            button1.Text = "Stop";
        }

        void StopAnimation()
        {
            timer.Stop();
            button1.Text = "Start";
        }

        string GetSelectedCountry()
        {
            return flexChart1.SelectedIndex >= 0 ? ((List<DataItem>)flexChart1.DataSource)[flexChart1.SelectedIndex].Country : null;
        }
    }
}

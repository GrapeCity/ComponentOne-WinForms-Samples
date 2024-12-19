using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Windows.Forms;
using C1.Chart;
using C1.Win.Chart;
using BaseExplorer;

namespace FlexChartExplorer.Samples
{
    public partial class Animation : FlexChartBaseSample
    {
        IDataSource data;

        public Animation()
        {
            InitializeComponent();
            Load += Animation_Load;
        }

        private void Animation_Load(object sender, EventArgs e)
        {
            ((FlexChart)Chart).AnimationSettings = AnimationSettings.All;
            data.NewData();
        }

        protected override void InitializeControls()
        {
            var chart = new FlexChart() { Dock = DockStyle.Fill };
            data = new PointDataSource(chart);
            data.NewData();
            Chart = chart;

            LabelEx lblChartType = new LabelEx("Chart Type:");
            pnlControls.Controls.Add(lblChartType);

            var cbChartType = new ComboBoxEx("Chart Type");
            cbChartType.ItemsDataSource = new ChartType[] { ChartType.Column, ChartType.Bar, ChartType.Line, ChartType.LineSymbols, ChartType.Scatter, ChartType.Area, ChartType.Spline, ChartType.SplineSymbols, ChartType.SplineArea, ChartType.Step };
            cbChartType.SelectedIndex = 0;
            cbChartType.SelectedIndexChanged += (s, a) => chart.ChartType = (ChartType)Enum.Parse(typeof(ChartType), cbChartType.SelectedItem.DisplayText);
            pnlControls.Controls.Add(cbChartType);

            LabelEx lblStacking = new LabelEx("Stacking:");
            pnlControls.Controls.Add(lblStacking);

            var cbStacking = new ComboBoxEx("Stacking");
            cbStacking.ItemsDataSource = Enum.GetNames(typeof(Stacking));
            cbStacking.SelectedIndex = 0;
            cbStacking.SelectedIndexChanged += (s, a) => chart.Stacking = (Stacking)Enum.Parse(typeof(Stacking), cbStacking.SelectedItem.DisplayText);
            pnlControls.Controls.Add(cbStacking);

            LabelEx lblRenderMode = new LabelEx("RenderMode:");
            pnlControls.Controls.Add(lblRenderMode);

            var cbRenderMode = new ComboBoxEx("RenderMode");
            cbRenderMode.ItemsDataSource = Enum.GetNames(typeof(RenderMode));
            cbRenderMode.SelectedIndex = 0;
            cbRenderMode.SelectedIndexChanged += (s, a) => chart.RenderMode = (RenderMode)Enum.Parse(typeof(RenderMode), cbRenderMode.SelectedItem.DisplayText);
            pnlControls.SetFlowBreak(cbRenderMode, true);
            pnlControls.Controls.Add(cbRenderMode);

            var btnNew = new ButtonEx("New Data");
            btnNew.Click += (s, a) => data.NewData();
            pnlControls.Controls.Add(btnNew);

            var btnUpdate = new ButtonEx("Update");
            btnUpdate.Click += (s, a) => data.UpdateData();
            pnlControls.Controls.Add(btnUpdate);

            var btnAddSeries = new ButtonEx("+ Series");
            btnAddSeries.Click += (s, a) => data.AddSeries();
            pnlControls.Controls.Add(btnAddSeries);

            var btnRemoveSeries = new ButtonEx("- Series");
            btnRemoveSeries.Click += (s, a) =>
            {
                var cnt = chart.Series.Count;
                if (cnt > 0)
                    chart.Series.RemoveAt(cnt - 1);
            };
            pnlControls.Controls.Add(btnRemoveSeries);

            var btnAddPoint = new ButtonEx("+ Point");
            btnAddPoint.Click += (s, a) => data.AddPoint();
            pnlControls.Controls.Add(btnAddPoint);

            var btnRemovePoint = new ButtonEx("- Point");
            btnRemovePoint.Click += (s, a) => data.RemovePoint();
            pnlControls.Controls.Add(btnRemovePoint);
        }
    }


    #region Data

    interface IDataSource
    {
        void NewData();
        void UpdateData();

        void AddSeries();

        void AddPoint();
        void RemovePoint();
    }

    class PointDataSource : IDataSource
    {
        protected static Random rnd = new Random();
        protected FlexChart chart;
        protected int nser;
        protected int npts;

        public PointDataSource(FlexChart chart, int nser = 3, int npts = 10)
        {
            this.chart = chart;
            this.nser = nser;
            this.npts = npts;
        }

        public void NewData()
        {
            chart.BeginUpdate();
            chart.AxisX.LabelAngle = 0;
            chart.DataSource = null;
            chart.Series.Clear();
            for (var i = 0; i < nser; i++)
                chart.Series.Add(CreateSeries(npts, i.ToString()));
            chart.EndUpdate();
        }

        public void UpdateData()
        {
            var nser = chart.Series.Count;
            for (var i = 0; i < nser; i++)
                UpdateSeries(chart.Series[i], npts);
        }

        public void AddSeries()
        {
            chart.Series.Add(CreateSeries(npts, chart.Series.Count.ToString()));
        }

        public void AddPoint()
        {
            var max = (1 + (int)(rnd.NextDouble() * 5)) * 100;
            foreach (var ser in chart.Series)
            {
                var col = (ObservableCollection<PointF>)ser.DataSource;
                col.Add(new PointF(col.Count, (float)rnd.NextDouble() * max));
            }
        }

        public void RemovePoint()
        {
            foreach (var ser in chart.Series)
            {
                var col = (IList)ser.DataSource;
                if (col.Count > 0)
                    col.RemoveAt(col.Count - 1);
            }
        }

        public Series CreateSeries(int npts, string name)
        {
            var max = (1 + (int)(rnd.NextDouble() * 5)) * 100;

            return new Series()
            {
                Binding = "Y",
                BindingX = "X",
                DataSource = Create( npts, max),
                Name = name
            };
        }

        public void UpdateSeries(Series ser, int npts)
        {
            var max = (1 + (int)(rnd.NextDouble() * 5)) * 100;
            ser.DataSource = Create( npts, max);
        }

        ObservableCollection<PointF> Create(int npts, float max = 100)
        {
            var pts = new PointF[npts];

            for (var i = 0; i < npts; i++)
                pts[i] = new PointF(i, (int)(rnd.NextDouble() * max));

            return new ObservableCollection<PointF>(pts);
        }
    }

    #endregion
}

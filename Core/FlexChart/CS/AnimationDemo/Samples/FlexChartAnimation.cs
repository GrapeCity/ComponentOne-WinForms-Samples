using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using C1.Chart;
using C1.Win.Chart;

namespace Samples
{
    public partial class FlexChartAnimation : UserControl
    {
        FlexChart chart;
        IDataSource data;

        public FlexChartAnimation()
        {
            InitializeComponent();
        }

        private void FlexChartAnimation_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;

            chart = new FlexChart() { Dock = DockStyle.Fill };
            tableLayoutPanel1.SetRow(chart, 1);
            tableLayoutPanel1.SetColumn(chart, 0);
            tableLayoutPanel1.Controls.Add(chart);

            cbChartType.DataSource = new ChartType[] { ChartType.Column, ChartType.Bar, ChartType.Line, ChartType.LineSymbols, ChartType.Scatter, ChartType.Area, ChartType.Spline, ChartType.SplineSymbols, ChartType.SplineArea, ChartType.Step };
            cbChartType.SelectedValueChanged += (s, a) => chart.ChartType = (ChartType)Enum.Parse(typeof(ChartType), cbChartType.SelectedItem.ToString());

            cbStacking.DataSource = Enum.GetNames(typeof(Stacking));
            cbStacking.SelectedValueChanged += (s, a) => chart.Stacking = (Stacking)Enum.Parse(typeof(Stacking), cbStacking.SelectedItem.ToString());

            cbRenderMode.DataSource = Enum.GetNames(typeof(RenderMode));
            cbRenderMode.SelectedValueChanged += (s, a) => chart.RenderMode = (RenderMode)Enum.Parse(typeof(RenderMode), cbRenderMode.SelectedItem.ToString());

            cbAnimation.DataSource = Enum.GetNames(typeof(AnimationSettings));
            cbAnimation.SelectedValueChanged += (s, a) =>
            {
                chart.AnimationSettings = (AnimationSettings)Enum.Parse(typeof(AnimationSettings), cbAnimation.SelectedItem.ToString());
                propertyGrid1.Enabled = (chart.AnimationSettings & (AnimationSettings.Load | AnimationSettings.AxesLoad))  != 0;
                propertyGrid2.Enabled = (chart.AnimationSettings & (AnimationSettings.Update | AnimationSettings.AxesUpdate)) != 0;
            };
            cbAnimation.SelectedIndex = cbAnimation.Items.Count - 1;

            propertyGrid1.SelectedObject = chart.AnimationLoad;
            propertyGrid2.SelectedObject = chart.AnimationUpdate;

            data = new PointDataSource(chart);
            data.NewData();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            data.NewData();
        }

        private void btnAddSeries_Click(object sender, EventArgs e)
        {
            data.AddSeries();
        }

        private void btnAddPoint_Click(object sender, EventArgs e)
        {
            data.AddPoint();
        }

        private void btnRemoveSeries_Click(object sender, EventArgs e)
        {
            var cnt = chart.Series.Count;
            if (cnt > 0)
                chart.Series.RemoveAt(cnt - 1);
        }

        private void btnRemovePoint_Click(object sender, EventArgs e)
        {
            data.RemovePoint();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            data.UpdateData();
        }
    }

    public enum DataShape
    {
        Line,
        Sin,
        Random,
        Ellipse,
        Spiral,
        Grid
    }

    interface IDataSource
    {
        void NewData();
        void UpdateData();

        void AddSeries();

        void AddPoint();
        void RemovePoint();
    }

    class BaseDataSource
    {
        protected static Random rnd = new Random();

        protected FlexChart chart;
        protected int nser;
        protected int npts;
    }

    class PointDataSource : BaseDataSource, IDataSource
    {
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
                DataSource = DataHelper.Create(DataShape.Random, npts, max),
                Name = name
            };
        }

        public void UpdateSeries(Series ser, int npts)
        {
            var max = (1 + (int)(rnd.NextDouble() * 5)) * 100;
            ser.DataSource = DataHelper.Create(DataShape.Random, npts, max);
        }
    }

    public class DataItem
    {
        public string Name { get; set; }
        public double Q1 { get; set; }
        public double Q2 { get; set; }
        public double Q3 { get; set; }
        public double Q4 { get; set; }
    }

    class ItemDataSource : BaseDataSource, IDataSource
    {
        DataItem CreateItem(double max)
        {
            return new DataItem()
            {
                Name = "cat" + rnd.Next(1, 999).ToString(),
                Q1 = rnd.NextDouble() * max,
                Q2 = rnd.NextDouble() * max,
                Q3 = rnd.NextDouble() * max,
                Q4 = rnd.NextDouble() * max,
            };
        }

        Series CreateSeries(string name)
        {
            return new Series()
            {
                Binding = name,
                Name = name
            };
        }

        ObservableCollection<DataItem> CreateCollection()
        {
            var list = new ObservableCollection<DataItem>();
            var max = (1 + (int)(rnd.NextDouble() * 5)) * 100;
            for (var i = 0; i < npts; i++)
                list.Add(CreateItem(max));
            return list;
        }

        public ItemDataSource(FlexChart chart, int npts = 5)
        {
            this.chart = chart;
            this.npts = npts;
            this.nser = 2;
        }

        public void NewData()
        {
            chart.BeginUpdate();

            chart.AxisX.LabelAngle = 90;

            chart.Series.Clear();
            for (var i = 1; i <= nser; i++)
                chart.Series.Add(CreateSeries("Q" + i.ToString()));
            chart.BindingX = "Name";
            chart.DataSource = CreateCollection();

            chart.EndUpdate();
        }

        public void UpdateData()
        {
            chart.DataSource = CreateCollection();
        }

        public void AddSeries()
        {
            var cnt = chart.Series.Count;
            if (cnt < 4)
                chart.Series.Add(CreateSeries("Q" + cnt.ToString()));
        }

        public void AddPoint()
        {
            var max = (1 + (int)(rnd.NextDouble() * 5)) * 100;
            var col = chart.DataSource as ObservableCollection<DataItem>;

            if (col == null)
                return;

            if (col.Count > 0)
                col.Insert(rnd.Next(0, col.Count - 1), CreateItem(max));
            else
                col.Add(CreateItem(max));
        }

        public void RemovePoint()
        {
            var col = (ObservableCollection<DataItem>)chart.DataSource;
            if (col.Count > 0)
                col.RemoveAt(col.Count - 1);
        }

        public void UpdateSeries(Series ser, int npts)
        {
            var max = (1 + (int)(rnd.NextDouble() * 5)) * 100;
            var list = new ObservableCollection<DataItem>();
            for (var i = 0; i < npts; i++)
                list.Add(CreateItem(max));
            ser.DataSource = list;
        }
    }

    class DataHelper
    {
        static Random rnd = new Random();

        public static ObservableCollection<PointF> Create(DataShape shape, int npts, float max = 100)
        {
            var pts = new PointF[npts];

            Func<int, PointF> f = null;

            switch (shape)
            {
                case DataShape.Line:
                    f = (i) => new PointF(i, i);
                    break;
                case DataShape.Sin:
                    f = (i) => new PointF(i, (float)Math.Sin(0.1 * i));
                    break;
                case DataShape.Random:
                    f = (i) => new PointF(i, (int)(rnd.NextDouble() * max));
                    break;
                case DataShape.Ellipse:
                    f = (i) => new PointF((float)Math.Sin((2 * Math.PI * i) / npts), (float)Math.Cos((2 * Math.PI * i) / npts));
                    break;
                case DataShape.Spiral:
                    f = (i) => new PointF(i * (float)Math.Sin((4 * Math.PI * i) / npts), i * (float)Math.Cos((4 * Math.PI * i) / npts));
                    break;
                case DataShape.Grid:
                    var l = (int)Math.Sqrt(npts);
                    f = (i) => new PointF(i % l, (int)(i / l));
                    break;
            }

            for (var i = 0; i < npts; i++)
                pts[i] = f(i);

            return new ObservableCollection<PointF>(pts);
        }
    }
}

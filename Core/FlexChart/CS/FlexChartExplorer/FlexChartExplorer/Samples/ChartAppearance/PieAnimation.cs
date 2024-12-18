using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using C1.Chart;
using C1.Win.Chart;
using FlexChartExplorer.Data;
using BaseExplorer;

namespace FlexChartExplorer.Samples
{
    public partial class PieAnimation : FlexChartBaseSample
    {
        FlexPie fpie;

        public PieAnimation()
        {
            InitializeComponent();
            Load += PieAnimation_Load;
        }

        private void PieAnimation_Load(object sender, EventArgs e)
        {
            fpie.AnimationSettings = AnimationSettings.All;
            NewData();
        }

        protected override void SetupChart()
        {
            fpie = new FlexPie() { Dock = DockStyle.Fill};
            fpie.Legend.Position = Position.Right;
            fpie.DataLabel.Content = "{Value}";
            Chart = fpie;
            NewData();
        }

        protected override void InitializeControls()
        {
            fpie = new FlexPie() { Dock = DockStyle.Fill };
            Chart = fpie;

            pnlControls.Controls.Add(new LabelEx("Inner Radius:"));
            var numInnerRadius = new NumericUpDownEx() { Minimum = 0, Maximum = (float)0.9M, Increment = new decimal(new int[] { 1, 0, 0, 65536 }), Value = 0 };
            numInnerRadius.ValueChanged += (s, a) => fpie.InnerRadius = Convert.ToSingle(numInnerRadius.Value);
            pnlControls.Controls.Add(numInnerRadius);

            pnlControls.Controls.Add(new LabelEx("Offset:"));
            var numOffset = new NumericUpDownEx() { Minimum = (float)0.0M, Maximum = (float)1.0M, Increment = new decimal(new int[] { 1, 0, 0, 65536 }), Value = 0 };
            numOffset.ValueChanged += (s, a) => fpie.Offset = Convert.ToSingle(numOffset.Value);
            pnlControls.Controls.Add(numOffset);

            var cbLabels = new CheckBoxEx("Show Labels");
            cbLabels.CheckedChanged += (s,a) => fpie.DataLabel.Position = cbLabels.Checked ? PieLabelPosition.Center : PieLabelPosition.None;
            pnlControls.SetFlowBreak(cbLabels, true);
            pnlControls.Controls.Add(cbLabels);

            var btnNew = new ButtonEx("New Data");
            btnNew.Click += (s, a) => NewData();
            pnlControls.Controls.Add(btnNew);

            var btnUpdate = new ButtonEx("Update");
            btnUpdate.Click += (s, a) => UpdateData();
            pnlControls.Controls.Add(btnUpdate);

            var btnAddPoint = new ButtonEx("+ Point");
            btnAddPoint.Click += (s, a) => AddPoint();
            pnlControls.Controls.Add(btnAddPoint);

            var btnRemovePoint = new ButtonEx("- Point");
            btnRemovePoint.Click += (s, a) => RemovePoint();
            pnlControls.Controls.Add(btnRemovePoint);
        }

        #region Data

        Random rnd = new Random();

        void NewData(int npts = 6)
        {
            var data = new ObservableCollection<DataItem>();

            for (var i = 0; i < npts; i++)
                data.Add(new DataItem { Value = rnd.Next(1, 10), Name = "Item " + i.ToString() });

            fpie.BeginUpdate();
            fpie.Binding = "Value";
            fpie.BindingName = "Name";

            fpie.DataSource = data;
            fpie.EndUpdate();
        }

        void AddPoint()
        {
            var data = fpie.DataSource as ObservableCollection<DataItem>;
            if (data != null)
                data.Add(new DataItem { Value = rnd.Next(1, 10), Name = "Item " + data.Count.ToString() });
        }

        void RemovePoint()
        {
            var data = fpie.DataSource as ObservableCollection<DataItem>;
            if (data != null && data.Count > 0)
                data.RemoveAt(data.Count - 1);
        }

        void UpdateData()
        {
            fpie.BeginUpdate();

            var data = fpie.DataSource as ObservableCollection<DataItem>;
            if (data != null)
            {
                var npts = data.Count;

                for (var i = 0; i < npts; i++)
                    data[i].Value = rnd.Next(1, 10);
            }

            fpie.EndUpdate();
        }

        public class DataItem : INotifyPropertyChanged
        {
            string name;
            double value;

            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    if (name != value)
                    {
                        name = value;
                        OnPropertyChanged("Name");
                    }
                }
            }

            public double Value
            {
                get
                {
                    return value;
                }
                set
                {
                    if (this.value != value)
                    {
                        this.value = value;
                        OnPropertyChanged("Value");
                    }
                }
            }

            public event PropertyChangedEventHandler PropertyChanged;

            void OnPropertyChanged(string propertyName)
            {
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}

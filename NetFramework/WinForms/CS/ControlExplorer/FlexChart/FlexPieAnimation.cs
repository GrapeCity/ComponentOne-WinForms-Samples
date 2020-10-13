using System;
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

namespace ControlExplorer.FlexChart
{
    public partial class FlexPieAnimation : C1DemoForm
    {
        FlexPie chart;

        public FlexPieAnimation()
        {
            InitializeComponent();
        }

        private void FlexPieAnimation_Load(object sender, EventArgs e)
        {
            chart = new FlexPie() { Dock = DockStyle.Fill };
            chart.DataLabel.Content = "{Value}";
            chart.DataLabel.Position = PieLabelPosition.Center;

            tableLayoutPanel1.SetRow(chart, 1);
            tableLayoutPanel1.SetColumn(chart, 1);
            tableLayoutPanel1.Controls.Add(chart);

            AddProperty("Position", chart.DataLabel, "Data Label Position");

            chart.AnimationSettings = AnimationSettings.All;

            NewData();
        }

        private void New_Click(object sender, EventArgs e)
        {
            NewData();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            chart.BeginUpdate();

            var data = chart.DataSource as ObservableCollection<DataItem>;
            if (data != null)
            {
                var npts = data.Count;

                for (var i = 0; i < npts; i++)
                    data[i].Value = rnd.Next(1, 10);
            }

            chart.EndUpdate();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            var data = chart.DataSource as ObservableCollection<DataItem>;
            if (data != null)
                data.Add(new DataItem { Value = rnd.Next(1, 10), Name = "Item " + data.Count.ToString() });
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            var data = chart.DataSource as ObservableCollection<DataItem>;
            if (data != null && data.Count > 0)
                data.RemoveAt(data.Count - 1);
        }

        #region Data

        Random rnd = new Random();

        void NewData(int npts = 6)
        {
            var data = new ObservableCollection<DataItem>();

            for (var i = 0; i < npts; i++)
                data.Add(new DataItem { Value = rnd.Next(1, 10), Name = "Item " + i.ToString() });

            chart.BeginUpdate();
            chart.Binding = "Value";
            chart.BindingName = "Name";

            chart.DataSource = data;
            chart.EndUpdate();
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

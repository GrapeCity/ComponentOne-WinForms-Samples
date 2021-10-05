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
using C1.Chart;
using C1.Chart.Annotation;
using C1.Win.Chart.Annotation;

namespace DataManipulation
{
    public partial class TopN : UserControl
    {
        TopNFilter _filter = new TopNFilter();
        public TopN()
        {
            InitializeComponent();
            InitializeControls();

            InitializeFilter();
            InitializeChart();
        }

        void InitializeFilter()
        {
            var dataSource = TopNDataCreator.SmartPhoneVendors();

            _filter.Bindings = new string[] { "Shipments" };
            _filter.SortType = SortType.Descending;
            _filter.SortOrder = true;
            _filter.Source = dataSource;

            _filter.PropertyChanged += (o, e) =>
            {
                if (e.PropertyName == "DataSource")
                {
                    flexChart1.DataSource = _filter.DataSource;
                }
            };
        }

        void InitializeChart()
        {
            flexChart1.BeginUpdate();
            flexChart1.Header.Content = "2016 Top 10 smartphone vendors";
            flexChart1.Header.Style.Font = new Font(FontFamily.GenericSansSerif, 15);
            flexChart1.BindingX = "Name";
            flexChart1.Binding = "Shipments";
            flexChart1.LegendToggle = true;
            this.flexChart1.Series.Clear();
            this.flexChart1.Series.Add(new C1.Win.Chart.Series() { Name = "Shipments", Binding = "Shipments" });
            flexChart1.DataSource = _filter.DataSource;
            flexChart1.EndUpdate();
            flexChart1.SeriesVisibilityChanged += (o, e) =>
            {
                Queue<string> bindings = new Queue<string>();
                foreach (var s in flexChart1.Series)
                {
                    if (s.Visibility == SeriesVisibility.Visible)
                    {
                        bindings.Enqueue(s.Binding);
                    }
                }
                _filter.Bindings = bindings.ToArray();
            };
            
        }
        
        private void InitializeControls()
        {
            // Set localized content
            baseSample1.lblTitle.Text = Localizer.GetItem("topn", "title");
            baseSample1.tbDescription.Rtf = Localizer.GetItem("topn", "description").MakeRtf();
            flexChart1 = baseSample1.flexChart1;

            // Initialize the Top-N combobox
            Queue<ComboBoxItem> cboItems = new Queue<ComboBoxItem>();
            cboItems.Enqueue(new ComboBoxItem("Shows All", null));
            for (int i = 1; i < 10; i++)
            {
                cboItems.Enqueue(new ComboBoxItem("Top " + i, i));
            }
            cboTopN = new ComboBox()
            {
                Size = new Size(200, 21),
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.DimGray,
                DataSource = cboItems.ToArray(),
                DisplayMember = "Name"
            };
            this.cboTopN.SelectedIndexChanged += (o, e) =>
            {
                if (cboTopN.SelectedIndex == 0)
                {
                    _filter.TopNEnabled = false;
                }
                else
                {
                    _filter.TopNEnabled = true;
                    _filter.TopNCount = Convert.ToInt32((this.cboTopN.SelectedItem as ComboBoxItem).Value);
                }
            };
            baseSample1.pControls.Controls.Add(cboTopN);

            // Initialize the "Show Others" checkbox
            chkShowOthers = new CheckBox()
            {
                Text = "Show Others",
                FlatStyle = FlatStyle.Flat,
                Checked = false
            };
            chkShowOthers.CheckedChanged += (o, e) =>
            {
                _filter.ShowOther = this.chkShowOthers.Checked;
            };
            baseSample1.pControls.Controls.Add(chkShowOthers);
        }
    }
}

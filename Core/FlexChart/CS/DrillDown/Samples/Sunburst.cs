using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DrillDown.Samples
{
    public partial class Sunburst : UserControl
    {
        SunburstDrillDownManager manager;
        public Sunburst()
        {
            InitializeComponent();
            InitializeControls();
            SetupChart();
        }

        void SetupChart()
        {
            Queue<string> drilldownPath = new Queue<string>();
            foreach (var p in typeof(Item).GetProperties())
            {
                if (p.PropertyType == typeof(string))
                {
                    drilldownPath.Enqueue(p.Name);
                }
            }
            List<Item> items = DataService.Instance.GetData(500);
            manager = new SunburstDrillDownManager(DataService.Instance.GetSunburstData());

            sunburst1 = new C1.Win.Chart.Sunburst();
            sunburst1.BeginUpdate();
            sunburst1.Dock = DockStyle.Fill;
            sunburst1.DataSource = manager.CurrentItems;
            sunburst1.Binding = "Value";
            sunburst1.BindingName = string.Join(",", manager.DrillDownPath);
            sunburst1.ChildItemsPath = "Items";
            sunburst1.DataLabel.Position = C1.Chart.PieLabelPosition.Center;
            sunburst1.DataLabel.Border = true;
            sunburst1.DataLabel.Content = "{name} | {y}";
            sunburst1.Drilldown = true;
            sunburst1.EndUpdate();

            baseSample1.pChart.Controls.Clear();
            baseSample1.pChart.Controls.Add(sunburst1);
        }

        private void InitializeControls()
        {
            //Set localized content
            baseSample1.lblTitle.Text = Localizer.GetItem("sunburst", "title");
            baseSample1.tbDescription.Rtf = Localizer.GetItem("sunburst", "description").MakeRtf();
            
        }
        
    }
}

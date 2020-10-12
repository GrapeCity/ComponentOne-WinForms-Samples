using System;

namespace ControlExplorer.GanttView
{
    public partial class GanttViewDemo : C1DemoForm
    {
        public GanttViewDemo()
        {
            InitializeComponent();
        }

        private void GanttViewDemo_Load(object sender, EventArgs e)
        {
            c1GanttView1.LoadXml(AppDomain.CurrentDomain.BaseDirectory + "GanttView\\ganttview.xml");
            
            // demo properties
            AddProperty("ShowNonworkingTime", c1GanttView1);
            AddProperty("ShowStartFinish", c1GanttView1);
            AddProperty("ShowToday", c1GanttView1);
            AddProperty("ShowToolbar", c1GanttView1);
        }
    }
}

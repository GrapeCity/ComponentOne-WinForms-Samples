using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Ribbon;

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

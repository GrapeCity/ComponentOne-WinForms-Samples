using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GanttViewTestProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.c1GanttView1.Project.StartDate = this.c1GanttView1.Tasks[1].Start.Value;
        }

        private void btnZoomSelectedTask_Click(object sender, EventArgs e)
        {
            c1GanttView1.ZoomTask(c1GanttView1.SelectedTask);
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            c1GanttView1.ZoomOut();
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            c1GanttView1.ZoomIn();
        }

        private void btnZoomEntireProject_Click(object sender, EventArgs e)
        {
            c1GanttView1.ZoomEntireProject();
        }

        private void c1GanttView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (c1GanttView1.SelectedTask == null || !c1GanttView1.SelectedTask.Initialized)
                btnZoomSelectedTask.Enabled = false;
            else
                btnZoomSelectedTask.Enabled = true;
        }
    }
}

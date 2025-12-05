using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using C1.Win.GanttView;

namespace HowToDoItInCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadXml_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.DefaultExt = ".xml";
                dlg.Filter = "XML files|*.xml|All files|*.*";
                dlg.Title = "Load Gantt View From Xml File";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        gv.LoadXml(dlg.FileName);
                    }
                    catch
                    {
                        MessageBox.Show("Bad C1GanttView XML.", dlg.Title);
                    }
                }
            }
        }

        private void btnSaveXml_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.DefaultExt = ".xml";
                dlg.FileName = "gantt";
                dlg.Filter = "XML files|*.xml|All files|*.*";
                dlg.Title = "Save Gantt View As Xml File";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    gv.SaveXml(dlg.FileName);
                }
            }
        }

        private void btnAddPredecessor_Click(object sender, EventArgs e)
        {
            // find task1 and task2
            Task task1 = gv.Tasks.Search("Task 1");
            Task task2 = gv.Tasks.Search("Task 2");

            if (task1 != null && task2 != null && task2.Predecessors.Count == 0)
            {
                // switch to auto-scheduling mode
                task2.Mode = TaskMode.Automatic;

                Predecessor p = new Predecessor();
                p.PredecessorTask = task1;
                task2.Predecessors.Add(p);

                // restore the manual mode
                task2.Mode = TaskMode.Manual;
            }
        }

        private void btnAddResource_Click(object sender, EventArgs e)
        {
            // add the new Resource object
            Resource r = null;
            if (gv.Resources.Count == 0)
            {
                r = new Resource();
                r.Name = "Resource 1";
                r.Cost = 300m;
                gv.Resources.Add(r);
            }

            // find task1
            Task task1 = gv.Tasks.Search("Task 1");
            if (task1 != null && r != null && task1.ResourceRefs.Count == 0)
            {
                // add a resource reference to the task
                ResourceRef rRef = new ResourceRef();
                rRef.Resource = r;
                rRef.Amount = 0.5;
                task1.ResourceRefs.Add(rRef);
            }
        }

        private void btnTimescale_Click(object sender, EventArgs e)
        {
            ScaleTier st = gv.Timescale.TopTier;
            st.Units = TimescaleUnits.ThirdsOfMonths;
            st.Format = "sd";
            st.Visible = true;
            btnRemoveTopLevel.Enabled = true;
            btnAddTopLevel.Enabled = false;
        }

        private void btnRemoveTopLevel_Click(object sender, EventArgs e)
        {
            gv.Timescale.TopTier.Visible = false;
            btnAddTopLevel.Enabled = true;
            btnRemoveTopLevel.Enabled = false;
        }

        private void btnInsertTask_Click(object sender, EventArgs e)
        {
            TaskCollection tasks = gv.Tasks;
            int index = gv.Tasks.IndexOf("Task 2");
            if (index >= 0)
            {
                // create a new task
                Task t = new Task();
                tasks.Insert(index, t);
                t.Mode = TaskMode.Automatic;
                t.Name = "New Task";
                t.Start = new DateTime(2012, 6, 25);
                t.Duration = 3;

                btnMove.Enabled = true;
                btnDelete.Enabled = true;
                btnInsertTask.Enabled = false;
            }
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            TaskCollection tasks = gv.Tasks;
            int index = tasks.IndexOf("New Task");
            if (index >= 0)
            {
                Task t = tasks[index];
                tasks.RemoveAt(index);
                tasks.Insert(0, t);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            TaskCollection tasks = gv.Tasks;

            // find NewTask
            int index = gv.Tasks.IndexOf("New Task");
            if (index >= 0)
            {
                // delete and dispose the new task
                Task t = tasks[index];
                tasks.RemoveAt(index);
                t.Dispose();

                btnInsertTask.Enabled = true;
                btnMove.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void chkShowDuration_CheckedChanged(object sender, EventArgs e)
        {
            TaskPropertyColumn durationCol = gv.Columns.Search(TaskProperty.Duration);
            TaskPropertyColumn unitsCol = gv.Columns.Search(TaskProperty.DurationUnits);
            if (durationCol != null && unitsCol != null)
            {
                bool visible = chkShowDuration.Checked;
                durationCol.Visible = visible;
                unitsCol.Visible = visible;
            }
        }

        private void btnChangeBarStyle_Click(object sender, EventArgs e)
        {
            BarStyle bs = gv.GetPredefinedBarStyle(BarType.ManualTask);
            bs.BarColor = Color.LightCoral;
            gv.BarStyles.Add(bs);
        }

        private void btnChangeTaskStyle_Click(object sender, EventArgs e)
        {
            Task task3 = gv.Tasks.Search("Task 3");
            if (task3 != null)
            {
                BarStyle bs = gv.GetPredefinedBarStyle(BarType.ManualTask);
                bs.BarColor = Color.Green;
                bs.BarShape = BarShape.MiddleBar;
                bs.StartShape = 19;
                bs.EndShape = 19;
                task3.BarStyles.Add(bs);
            }
        }
    }
}

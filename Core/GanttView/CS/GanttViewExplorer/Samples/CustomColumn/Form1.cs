using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using C1.Win.GanttView;

namespace CustomColumn
{
    public partial class Form1 : UserControl
    {
        bool _updating;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gv.Tasks.ListChanged += new ListChangedEventHandler(TasksResources_ListChanged);
            gv.Resources.ListChanged += new ListChangedEventHandler(TasksResources_ListChanged);
            UpdateCost();
        }

        void TasksResources_ListChanged(object sender, ListChangedEventArgs e)
        {
            UpdateCost();
        }

        void UpdateCost()
        {
            if (!_updating)
            {
                _updating = true;
                foreach (Task task in gv.Tasks)
                {
                    if (task.Initialized)
                    {
                        decimal total = 0m;
                        double duration = task.GetDurationInDays();
                        if (double.IsNaN(duration))
                            duration = 0;
                        foreach (ResourceRef rr in task.ResourceRefs)
                        {
                            Resource r = rr.Resource;
                            if (r != null)
                            {
                                total += Convert.ToDecimal(rr.Amount * duration) * r.Cost;
                            }
                        }
                        task.SetFieldValue("ActualCost", total);
                    }
                }
                _updating = false;
            }
        }
    }
}

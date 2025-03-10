using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CustomTaskInfoDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void c1GanttView1_ShowDialog(object sender, C1.Win.C1GanttView.ShowDialogEventArgs e)
        {
            if (e.DialogType == C1.Win.C1GanttView.DialogType.TaskInfo)
            {
                TaskInfoDialog dlg = new TaskInfoDialog(c1GanttView1);
                e.Dialog = dlg;
            }
        }
    }
}

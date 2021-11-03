using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CustomTaskInfoDialog
{
    public partial class Form1 : UserControl
    {
        public Form1()
        {
            InitializeComponent();
            c1GanttView1.EnablePrinting = true;
        }

        private void c1GanttView1_ShowDialog(object sender, C1.Win.GanttView.ShowDialogEventArgs e)
        {
            TaskInfoDialog dlg = new TaskInfoDialog(c1GanttView1);
            e.Dialog = dlg;
        }
    }
}

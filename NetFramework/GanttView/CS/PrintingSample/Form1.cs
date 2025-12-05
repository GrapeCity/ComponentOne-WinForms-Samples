using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;
using C1.C1Preview;
using C1.Win.GanttView;
using C1.Win.GanttView.Printing;
using C1.Win.C1Preview;

namespace PrintingSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ganttView.PrintInfo.CurrentPageSettings.Landscape = false;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ganttView.PrintInfo.Print("CustomStyle.c1d");
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            ganttView.PrintInfo.Preview("PrintStyles\\CustomStyle.c1d");
        }

        private void ganttView_BeforePrintPreview(object sender, CancelEventArgs e)
        {
            if (ganttView.PrintInfo.PreviewHelper.C1PrintPreviewDialog is C1.Win.RibbonPreview.C1RibbonPreviewDialog)
                (ganttView.PrintInfo.PreviewHelper.C1PrintPreviewDialog as C1.Win.RibbonPreview.C1RibbonPreviewDialog).RibbonElements.FileOpen.Visible = false;
        }
    }
}

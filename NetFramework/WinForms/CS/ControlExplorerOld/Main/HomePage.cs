using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace ControlExplorer.Main
{
    public partial class HomePage : C1DemoForm
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void c1SuperLabel1_LinkClicked(object sender, C1.Win.C1SuperTooltip.C1SuperLabelLinkClickedEventArgs e)
        {
            //launch highlight links
            MainForm main = (MainForm)this.ParentForm;
            if(e.HRef.Equals("c1editor"))
            {
                main.LoadPage("ControlExplorer.Editor.RTFEditor", "RTF Editor", "ComponentOne Editor for Winforms now supports loading and saving RTF files, into the Editor document. Any XHTML content rendered into the control can now be saved directly to the RTF format.");
            }
            else if(e.HRef.Equals("c1ganttview"))
            {
                main.LoadPage("ControlExplorer.GanttView.GanttViewDemo", "ComponentOne GanttView Overview", "ComponentOne GanttView for WinForms delivers a Microsoft Project-like user experience for project management. It provides a graphical diagram of a schedule that helps to plan, coordinate, and track specific tasks in a project. Manage your projects effectively and efficiently with added support for constraints, dependencies, resources, styles and more.");
            }
            else if (e.HRef.Equals("more"))
            {
                Process.Start("http://www.componentone.com/SuperProducts/StudioWinForms/What%27s+New/");
            }
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            //c1SuperLabel1.Text = ControlExplorer.Properties.Resources.HomePage;
        }
    }
}

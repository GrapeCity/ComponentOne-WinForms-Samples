using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Win.Command;

namespace CommandExplorer.Samples
{
    public partial class Docking : UserControl
    {
        public Docking()
        {
            InitializeComponent();
            object[] fields = Enum.GetValues(typeof(DockingStyle))
                      .Cast<object>()
                      .ToArray();
            this.cmbDockingStyle.Items.AddRange(fields);
            this.cmbDockingStyle.SelectedIndex = 0;
        }

        private void c1CommandHolder1_CommandClick(object sender, CommandClickEventArgs e)
        {
            if (e.Command == c1Command_ViewErrorList)
            {
                c1TabPage_ErrorList.DockTo(c1DockingTab1);
            }
            else if (e.Command == c1Command_ViewOutput)
            {
                c1TabPage_Output.Visible = true;
            }
            else if (e.Command == c1Command_ViewProperties)
            {
                c1TabPage_Properties.DockTo(c1DockingTab1);
            }
            else if (e.Command == c1Command_ViewServerExplorer)
            {
                c1TabPage_ServerExplorer.DockTo(c1DockingTab1);
            }
            else if (e.Command == c1Command_ViewSolutionExplorer)
            {
                c1TabPage_SolutionExplorer.DockTo(c1DockingTab1);
            }
            else if (e.Command == c1Command_ViewStartPage)
            {
                c1TabPage_StartPage.DockTo(c1DockingTab1);
            }
            else if (e.Command == c1Command_ViewTaskList)
            {
                c1TabPage_TaskList.DockTo(c1DockingTab1);
            }
            else if (e.Command == c1Command_ViewToolbox)
            {
                c1TabPage_Toolbox.DockTo(c1DockingTab1);
            }
            else if (e.Command == c1Command_Save)
            {
                c1CommandHolder1.LayoutSaveInAppConfig();
            }
        }

        private void cmbDockingStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            DockingStyle value = (DockingStyle)cmbDockingStyle.SelectedItem;
            c1CommandDock1.DockingStyle = value;
            c1CommandDock2.DockingStyle = value;
            c1CommandDock3.DockingStyle = value;
            c1CommandDock4.DockingStyle = value;
        }
    }
}

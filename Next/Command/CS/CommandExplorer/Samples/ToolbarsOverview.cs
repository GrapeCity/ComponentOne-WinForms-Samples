﻿using System;
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
    public partial class ToolbarsOverview : Form
    {
        public ToolbarsOverview()
        {
            TopLevel = false;
            TopMost = false;
            ControlBox = false;
            FormBorderStyle = FormBorderStyle.None;
            SizeGripStyle = SizeGripStyle.Hide;
            InitializeComponent();  
        }

        private void c1CommandHolder1_CommandClick(object sender, CommandClickEventArgs e)
        {
            //c1command click event
            label1.Text = e.Command.Text + " clicked";
        }

        private void c1Command_NavBarNormal_Click(object sender, ClickEventArgs e)
        {
            //toggle checked menu items so only 1 is checked at all times
            c1Command_NavBarNormal.Checked = false;
            c1Command_NavBarMinimized.Checked = false;
            c1Command_NavBarOff.Checked = false;

            C1Command c = (C1Command)sender;
            c.Checked = true;
        }

        private void c1Command_ToolbarFile_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            //toggle visibilities of toolbars
            c1ToolBar_File.Visible = c1Command_ToolbarFile.Checked;
            c1ToolBar_Format.Visible = c1Command_ToolbarFormat.Checked;
            c1ToolBar_Edit.Visible = c1Command_ToolbarEdit.Checked;
            c1ToolBar_Tools.Visible = c1Command_ToolbarTools.Checked;
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            //show context menu by code
            if (e.Button == MouseButtons.Right)
            {
                c1ContextMenu1.ShowContextMenu(label1, e.Location);
            }
        }

        private void c1Command_AlignCenter_Click(object sender, ClickEventArgs e)
        {
            //toggle checked buttons so only 1 is checked at all times
            c1Command_AlignCenter.Checked = false;
            c1Command_AlignLeft.Checked = false;
            c1Command_AlignRight.Checked = false;
            c1Command_Justify.Checked = false;

            C1Command c = (C1Command)sender;
            c.Checked = true;
        }

        private void c1CommandHolder1_CustomizationStarted(object sender, EventArgs e)
        {
            //run-time customization
        }
    }
}

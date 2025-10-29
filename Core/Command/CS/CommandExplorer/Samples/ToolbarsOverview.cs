// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

using C1.Win.Command;
using CommandExplorer.Controls;
using CommandExplorer.Data;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CommandExplorer.Samples
{
    public partial class ToolbarsOverview : UserControl
    {
        public ToolbarsOverview()
        {
            InitializeComponent();
            ToolbarsOverview_Load();
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

        private void c1Command_UseMnemonics_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            c1ToolBar_Edit.UseMnemonic = e.NewValue;
            c1ToolBar_File.UseMnemonic = e.NewValue;
            c1ToolBar_Format.UseMnemonic = e.NewValue;
            c1ToolBar_Tools.UseMnemonic = e.NewValue;
            mnemonicsPanel.Visible = e.NewValue;
        }

        private void ToolbarsOverview_Load()
        {
            SuspendLayout();
            mnemonicsPanel.SuspendLayout();
            int scrollbarWidth = SystemInformation.VerticalScrollBarWidth;
            foreach (MnemonicInfo info in MnemonicInfoDataSource.AllItems)
            {
                var container = new Panel
                {
                    Location = new Point(0, 23),
                    Margin = new Padding(0),
                    Padding = new Padding(5),
                    Size = new Size(mnemonicsPanel.Width - scrollbarWidth, 46),
                    TabIndex = 1,
                };
                var mnemonicLabel = new MnemonicLabel
                {
                    Dock = DockStyle.Fill,
                    AutoSize = true,
                    Location = new Point(25, 5),
                    Margin = new Padding(10, 0, 0, 0),
                    TabIndex = 1,
                    Text = info.Text,
                };
                var iconPanel = new Panel
                {
                    Dock = DockStyle.Left,
                    Margin = new Padding(0),
                    TabIndex = 0,
                    TabStop = false,
                    Padding = new Padding(10),
                    Size = new Size(46, 46),
                };
                var icon = new PictureBox
                {
                    BackgroundImageLayout = ImageLayout.Stretch,
                    BackgroundImage = info.Image,
                    Size = new Size(26, 26),
                    Margin = new Padding(0),
                    TabIndex = 0,
                    TabStop = false
                };
                iconPanel.Controls.Add(icon);

                container.Controls.Add(mnemonicLabel);
                container.Controls.Add(iconPanel);

                mnemonicsPanel.Controls.Add(container);
            }
            mnemonicsPanel.ResumeLayout();
            ResumeLayout(false);
        }
    }
}

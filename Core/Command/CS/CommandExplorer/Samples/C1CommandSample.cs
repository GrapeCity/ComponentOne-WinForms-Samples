using C1.Win.Command;
using CommandExplorer.Properties;
using System;
using System.Windows.Forms;

namespace CommandExplorer.Samples
{
    public partial class C1CommandSample : UserControl
    {
        private int counter = 0;
        private bool isProcessingClick = false;

        public C1CommandSample()
        {
            InitializeComponent();
            InitializeCommandProperties();
            SetText();
        }

        private void InitializeCommandProperties()
        {
            clickCommand.Name = "clickCommand";
            clickCommand.Enabled = true;
            clickCommand.Visible = true;
            clickCommand.Shortcut = Shortcut.CtrlC;
            clickCommand.Click += (s, e) =>
            {
                // Prevent double-increment when command is attached to both parent and CommandLinks
                if (isProcessingClick) return;

                isProcessingClick = true;
                counter++;
                Label_NumberCounter.Text = $"{counter}";

                // Reset flag after current Windows message cycle completes
                BeginInvoke(() => isProcessingClick = false);
            };
        }

        /// <summary>
        /// Attaches or detaches a command to a control and optionally its CommandLinks
        /// </summary>
        private void SetCommandToControl(Control control, C1.Win.Command.C1Command? command, bool includeCommandLinks = false)
        {
            //attach/detach command to control
            c1CommandHolder1.SetC1Command(control, command);

            if (!includeCommandLinks) return;

            var commandLinksProperty = control.GetType().GetProperty("CommandLinks");
            if (commandLinksProperty?.GetValue(control) is System.Collections.IEnumerable commandLinks)
            {
                foreach (C1CommandLink link in commandLinks)
                {
                    //attach/detach command to each CommandLink
                    link.Command = command;
                }
            }
        }

        /// <summary>
        /// Shows context menu on right-click
        /// </summary>
        private void ShowContextMenuOnRightClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                c1ContextMenu1.ShowContextMenu((Control)sender, e.Location);
            }
        }

        private void chkDisableCommand_CheckedChanged(object sender, EventArgs e)
        {
            clickCommand.Enabled = !chkDisableCommand.Checked;
        }

        private void cbMainMenu_CheckedChanged(object sender, EventArgs e)
        {
            var command = cbMainMenu.Checked ? clickCommand : null;
            SetCommandToControl(c1MainMenu1, command, includeCommandLinks: true);
        }

        private void cbToolBar_CheckedChanged(object sender, EventArgs e)
        {
            var command = cbToolBar.Checked ? clickCommand : null;
            SetCommandToControl(c1ToolBar1, command, includeCommandLinks: true);
        }

        private void cbDockingTab_CheckedChanged(object sender, EventArgs e)
        {
            var command = cbDockingTab.Checked ? clickCommand : null;
            SetCommandToControl(c1DockingTab1, command);
            c1DockingTab1.Enabled = cbDockingTab.Checked;
        }

        private void cbContextMenu_CheckedChanged(object sender, EventArgs e)
        {
            var command = cbContextMenu.Checked ? clickCommand : null;
            foreach (C1CommandLink link in c1ContextMenu1.CommandLinks)
            {
                link.Command = command;
            }
        }

        private void contextualMenuPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ShowContextMenuOnRightClick(sender, e);
        }
        private void Label_ContextMenuDesc_MouseDown(object sender, MouseEventArgs e)
        {
            ShowContextMenuOnRightClick(sender, e);
        }

        private void SetText()
        {
            Label_CommandDesc.Text = Resources.Label_CommandDesc;
            Label_ContextMenuDesc.Text = Resources.Label_ContextMenuDesc;
            Label_ContextMenu.Text = Resources.Label_ContextMenu;
            Label_Counter.Text = Resources.Label_Counter;
            Label_DisableDesc.Text = Resources.Label_DisableDesc;
            Label_MainMenu.Text = Resources.Label_MainMenu;
            Label_SampleDescription.Text = Resources.Label_SampleDescription;
            Label_ToolBar.Text = Resources.Label_ToolBar;
            Label_Welcome.Text = Resources.Label_Welcome;

            cbContextMenu.Text = Resources.CheckBox_ContextMenu_Text;
            cbDockingTab.Text = Resources.CheckBox_DockingTab_Text;
            cbMainMenu.Text = Resources.CheckBox_MainMenu_Text; 
            cbToolBar.Text = Resources.CheckBox_ToolBar_Text;   
            chkDisableCommand.Text = Resources.CheckBox_Disable_Text;

            toolTip1.SetToolTip(chkDisableCommand, Resources.ToolTip_Disable);
            toolTip1.SetToolTip(cbMainMenu, Resources.ToolTip_MainMenu);
            toolTip1.SetToolTip(cbToolBar, Resources.ToolTip_ToolBar);
            toolTip1.SetToolTip(cbDockingTab, Resources.ToolTip_DockingTab);
            toolTip1.SetToolTip(cbContextMenu, Resources.ToolTip_ContextMenu);
        }
    }
}

using C1.Win.Command.HamburgerMenu;
using C1.Win.Themes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HamburgerMenuExplorer.Samples
{
    public partial class Layout : UserControl
    {
        public Layout()
        {
            InitializeComponent();
            InitHamburgerMenu();
            InitToolStrip();
        }

        private void InitToolStrip()
        {
            ExpandedMode[] expandedModes = Enum.GetValues<ExpandedMode>();
            foreach (ExpandedMode value in expandedModes)
            {
                ToolStripButton item = new ToolStripButton(value.ToString());
                if (value is ExpandedMode.Overlay)
                {
                    item.Checked = true;
                }
                
                item.Click += ExpandedMode_Click;
                toolStripDropDownButton1.DropDownItems.Add(item);
            }

            CollapsedMode[] collapsedModes = Enum.GetValues<CollapsedMode>();
            foreach (CollapsedMode value in collapsedModes)
            {
                ToolStripButton item = new ToolStripButton(value.ToString());
                if (value is CollapsedMode.IconsOnly)
                {
                    item.Checked = true;
                }

                item.Click += CollapsedMode_Click;
                toolStripDropDownButton2.DropDownItems.Add(item);
            }

            RightToLeft[] rtls = Enum.GetValues<RightToLeft>();
            foreach (RightToLeft rtl in rtls)
            {
                ToolStripButton item = new ToolStripButton(rtl.ToString());
                if (rtl is RightToLeft.No)
                {
                    item.Checked = true;
                }

                item.Click += RightToLeft_Click;
                toolStripDropDownButton3.DropDownItems.Add(item);
            }

            DockStyle[] dockStyles = Enum.GetValues<DockStyle>();
            foreach (DockStyle dockStyle in dockStyles)
            {
                ToolStripButton item = new ToolStripButton(dockStyle.ToString());
                if (dockStyle is DockStyle.Fill)
                {
                    item.Checked = true;
                }

                item.Click += DockStyle_Click;
                toolStripDropDownButton4.DropDownItems.Add(item);
            }
        }

        private void ExpandedMode_Click(object sender, EventArgs e)
        {
            if (sender is not ToolStripButton btn)
            {
                return;
            }

            foreach (ToolStripButton item in toolStripDropDownButton1.DropDownItems)
            {
                item.Checked = false;
            }

            btn.Checked = true;
            c1HamburgerMenu1.ExpandedMode = Enum.Parse<ExpandedMode>(btn.Text);
        }

        private void CollapsedMode_Click(object sender, EventArgs e)
        {
            if (sender is not ToolStripButton btn)
            {
                return;
            }

            foreach (ToolStripButton item in toolStripDropDownButton2.DropDownItems)
            {
                item.Checked = false;
            }

            btn.Checked = true;
            c1HamburgerMenu1.CollapsedMode = Enum.Parse<CollapsedMode>(btn.Text);
        }

        private void RightToLeft_Click(object sender, EventArgs e)
        {
            if (sender is not ToolStripButton btn)
            {
                return;
            }

            foreach (ToolStripButton item in toolStripDropDownButton3.DropDownItems)
            {
                item.Checked = false;
            }

            btn.Checked = true;
            c1HamburgerMenu1.RightToLeft = Enum.Parse<RightToLeft>(btn.Text);
        }

        private void DockStyle_Click(object sender, EventArgs e)
        {
            if (sender is not ToolStripButton btn)
            {
                return;
            }

            foreach (ToolStripButton item in toolStripDropDownButton4.DropDownItems)
            {
                item.Checked = false;
            }

            btn.Checked = true;
            c1HamburgerMenu1.Dock = Enum.Parse<DockStyle>(btn.Text);
            switch(c1HamburgerMenu1.Dock)
            {
                case DockStyle.Left:
                case DockStyle.Right:
                    c1HamburgerMenu1.Width = 300;
                    break;
                case DockStyle.Top:
                case DockStyle.Bottom:
                    c1HamburgerMenu1.Height = 300;
                    break;
                case DockStyle.None:
                    c1HamburgerMenu1.Width = 300;
                    c1HamburgerMenu1.Height = 500;
                    break;
            }
        }

        private void InitHamburgerMenu()
        {
            foreach (C1HamburgerMenuItem item in c1HamburgerMenu1.Items)
            {
                InitHamburgerMenu(item);
            }

            c1HamburgerMenu1.IsExpanded = true;
        }

        private void InitHamburgerMenu(C1.Win.Command.HamburgerMenu.C1HamburgerMenuItem item)
        {
            for (int i = 1; i <= 4; i++)
                item.Items.Add(CreateItem($"Item {i}"));
        }

        private C1HamburgerMenuItem CreateItem(string text)
        {
            return new C1HamburgerMenuItem()
            {
                Text = text,
                ToolTipText = text
            };
        }

        private void expandeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            c1HamburgerMenu1.IsExpanded = true;
        }

        private void collapseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            c1HamburgerMenu1.IsExpanded = false;
        }

        internal void ApplyTheme(C1.Win.Themes.C1Theme theme)
        {
            C1ThemeController.ApplyThemeToControlTree(this, theme);
        }
    }
}

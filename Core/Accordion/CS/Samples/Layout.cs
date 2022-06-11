using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.Win.Accordion;

namespace AccordionExplorer.Samples
{
    public partial class Layout : UserControl
    {
        public Layout()
        {
            InitializeComponent();
            InitAccordion();
            InitToolStrip();
        }

        private void InitToolStrip()
        {
            var directions = Enum.GetValues<ExpandDirection>();
            foreach (var value in directions)
            {
                var item = new ToolStripButton(value.ToString());
                if (value is ExpandDirection.Down)
                    item.Checked = true;

                item.Click += ExpandDirection_Click;
                toolStripDropDownButton1.DropDownItems.Add(item);
            }

            var rtls = Enum.GetValues<RightToLeft>();
            foreach (var rtl in rtls)
            {
                var item = new ToolStripButton(rtl.ToString());
                if (rtl is RightToLeft.No)
                    item.Checked = true;

                item.Click += RightToLeft_Click;
                toolStripDropDownButton2.DropDownItems.Add(item);
            }

            var dockStyles = Enum.GetValues<DockStyle>();
            foreach (var dockStyle in dockStyles)
            {
                var item = new ToolStripButton(dockStyle.ToString());
                if (dockStyle is DockStyle.Fill)
                    item.Checked = true;

                item.Click += DockStyle_Click;
                toolStripDropDownButton3.DropDownItems.Add(item);
            }
        }

        private void ExpandDirection_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripButton btn)
            {
                foreach(ToolStripButton item in toolStripDropDownButton1.DropDownItems)
                    item.Checked = false;
                btn.Checked = true;
                c1Accordion1.ExpandDirection = Enum.Parse<ExpandDirection>(btn.Text);
            }
        }
        private void RightToLeft_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripButton btn)
            {
                foreach (ToolStripButton item in toolStripDropDownButton2.DropDownItems)
                    item.Checked = false;
                btn.Checked = true;
                c1Accordion1.RightToLeft = Enum.Parse<RightToLeft>(btn.Text);
            }
        }
        private void DockStyle_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripButton btn)
            {
                foreach (ToolStripButton item in toolStripDropDownButton3.DropDownItems)
                    item.Checked = false;
                btn.Checked = true;
                c1Accordion1.Dock = Enum.Parse<DockStyle>(btn.Text);
                switch(c1Accordion1.Dock)
                {
                    case DockStyle.Left:
                    case DockStyle.Right:
                        c1Accordion1.Width = 300;
                        break;
                    case DockStyle.Top:
                    case DockStyle.Bottom:
                        c1Accordion1.Height = 300;
                        break;
                    case DockStyle.None:
                        c1Accordion1.Width = 300;
                        c1Accordion1.Height = 500;
                        break;
                }
            }
        }

        private void InitAccordion()
        {
            foreach (var page in c1Accordion1.Pages)
                InitPage(page);
            c1Accordion1.ExpandAll();
        }

        private void InitPage(C1.Win.Accordion.C1AccordionPage page)
        {
            for (int i = 3; i >= 0; i--)
                page.Content.Controls.Add(CreateButton($"{page.Name} item {i}"));

            page.ContentHeight = page.Content.Controls[0].Bounds.Bottom + 1;
        }

        private RadioButton CreateButton(string text)
        {
            var btn = new RadioButton()
            {
                Text = text,
                AutoSize = true,
                Dock = DockStyle.Top,
                Appearance = Appearance.Button,
                FlatStyle = FlatStyle.Flat,
                TextAlign = ContentAlignment.MiddleLeft,
                BackColor = SystemColors.Window,
                Padding = new Padding(20, 0, 0, 0)
            };
            btn.FlatAppearance.BorderColor = SystemColors.Window;
            btn.FlatAppearance.CheckedBackColor = SystemColors.ControlDark;
            return btn;
        }

        private void expandeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            c1Accordion1.ExpandAll();
        }

        private void collapseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            c1Accordion1.CollapseAll();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //c1Accordion1.Orientation = Orientation.Horizontal;
        }
    }
}

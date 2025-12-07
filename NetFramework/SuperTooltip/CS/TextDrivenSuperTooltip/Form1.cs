using System;
using System.IO;
using System.Xml;
using System.Reflection;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.SuperTooltip;

namespace TextDrivenSuperTooltip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadTooltips(c1SuperTooltip1, "tooltips.xml");
        }

        void LoadTooltips(C1SuperTooltip tt, string resName)
        {
            // look for resource
            Assembly asm = Assembly.GetExecutingAssembly();
            foreach (string rn in asm.GetManifestResourceNames())
            {
                if (rn.EndsWith(resName))
                {
                    using (Stream s = asm.GetManifestResourceStream(rn))
                    {
                        // load xml content
                        XmlDocument doc = new XmlDocument();
                        doc.Load(s);
                        foreach (XmlNode node in doc.SelectNodes("Tooltips/Tooltip"))
                        {
                            // assign tooltip dynamically
                            string ctlName = node.Attributes["control"].Value;
                            Control ctl = FindControl(ctlName, this);
                            if (ctl != null)
                            {
                                tt.SetToolTip(ctl, node.InnerXml);
                            }
                            else
                            {
                                ToolStripItem item = FindToolStripItem(ctlName, this);
                                if (item != null)
                                {
                                    tt.SetToolTip(item, node.InnerXml);
                                }
                            }
                        }
                    }
                }
            }
        }
        Control FindControl(string ctlName, Control ctl)
        {
            if (ctl.Name == ctlName)
                return ctl;

            foreach (Control child in ctl.Controls)
            {
                Control c = FindControl(ctlName, child);
                if (c != null)
                    return c;
            }
            return null;
        }
        ToolStripItem FindToolStripItem(string itemName, Control ctl)
        {
            foreach (Control child in ctl.Controls)
            {
                ToolStrip ts = child as ToolStrip;
                if (ts != null)
                {
                    ToolStripItem item = FindToolStripItem(itemName, ts.Items);
                    if (item != null)
                        return item;
                }
            }
            return null;
        }
        ToolStripItem FindToolStripItem(string itemName, ToolStripItemCollection items)
        {
            foreach (ToolStripItem item in items)
            {
                if (item.Name == itemName)
                    return item;

                ToolStripMenuItem mi = item as ToolStripMenuItem;
                if (mi != null)
                {
                    ToolStripItem subItem = FindToolStripItem(itemName, mi.DropDownItems);
                    if (subItem != null)
                        return subItem;
                }
            }
            return null;
        }
    }
}
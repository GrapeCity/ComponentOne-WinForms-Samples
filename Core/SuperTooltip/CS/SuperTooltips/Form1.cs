using System;
using System.Reflection;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.SuperTooltip;

namespace SuperTooltips
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
            AddTipsToToolStrip(toolStrip1);
            AddTipsToTreeView(treeView1);
            AddToolboxTips(_groupToolBox.Controls);
        }

        private void AddTipsToToolStrip(ToolStrip toolStrip)
        {
            // Disable default tooltips
            toolStrip.ShowItemToolTips = false;

            // Attach MouseEnter event for ToolStripButtons with tooltips
            foreach (ToolStripItem item in toolStrip.Items)
            {
                if (item is ToolStripButton button && !string.IsNullOrEmpty(button.ToolTipText))
                {
                    button.MouseEnter -= ToolStripButton_MouseEnter;
                    button.MouseEnter += ToolStripButton_MouseEnter;
                }
            }
        }

        // Event handler for MouseEnter on ToolStripButton
        private void ToolStripButton_MouseEnter(object sender, EventArgs e)
        {
            if (sender is ToolStripButton button && !string.IsNullOrEmpty(button.ToolTipText))
            {
                // Build tooltip content using a single StringBuilder
                var tip = new StringBuilder("<table><tr>");

                if (button.Image != null)
                {
                    string imageName = button.Name + ".Image";
                    tip.AppendFormat("<td><img src='res://{0}'></td>", imageName);
                }

                tip.AppendFormat("<td style='font:bold 11pt Segoe UI'>{0}</td></tr></table>",
                    System.Web.HttpUtility.HtmlEncode(button.ToolTipText));

                // Add help section for buttons except 'helpToolStripButton'
                if (button != this.helpToolStripButton)
                {
                    tip.Append("<hr noshade size=1 color=lightBlue>");
                    tip.Append("<table><tr><td><img src='res://helpToolStripButton.Image'></td>");
                    tip.Append("<td>Press <b>F1</b> for more help.</td></tr></table>");
                }

                // Assign tooltip dynamically
                C1SuperTooltip1.SetToolTip(button.Owner, tip.ToString());
            }
        }

        // add Html toolips to nodes in a TreeView
        private void AddTipsToTreeView(TreeView treeView)
        {
            // always show the same image
            ShowSameImage(treeView.Nodes);

            // do not show the default tooltips
            treeView.ShowNodeToolTips = false;

            // attach mouse event handler
            treeView1.MouseMove += new MouseEventHandler(treeView1_MouseMove);
        }
        private void ShowSameImage(TreeNodeCollection nodes)
        {
            if (nodes != null)
            {
                foreach (TreeNode node in nodes)
                {
                    node.SelectedImageIndex = node.ImageIndex;
                    ShowSameImage(node.Nodes);
                }
            }
        }

        // update tooltip as the mouse moves
        TreeNode _lastNode = null;
        void treeView1_MouseMove(object sender, MouseEventArgs e)
        {
            TreeView tv = sender as TreeView;
            TreeViewHitTestInfo hti = tv.HitTest(e.X, e.Y);
            if (hti.Node != _lastNode)
            {
                // save new node
                _lastNode = hti.Node;

                // mouse is over a new node, update tip
                string text = null;
                if (hti.Node != null)
                {
                    // build tip
                    StringBuilder tip = new StringBuilder();
                    if (hti.Node.Parent != null)
                    {
                        tip.AppendFormat("<div style='font:bold 11pt Segoe UI'>{0}/{1}</div>",
                            hti.Node.Parent.Text, hti.Node.Text);
                        tip.AppendFormat("Click this node to see the <b>{0}</b> options.",
                            hti.Node.Text);
                    }
                    else
                    {
                        tip.AppendFormat("<div style='font:bold 14pt Segoe UI'>{0} Options</div>",
                            hti.Node.Text);
                    }

                    // append general 'get help' tip
                    tip.Append("</div><hr noshade size=1 color=lightBlue>");
                    tip.AppendFormat("<table><tr><td><img src='{0}'><td>{1}</table>",
                        "res://helpToolStripButton.Image",
                        "Press <b>F1</b> for more help.");

                    text = tip.ToString();
                }

                // update tip
                C1SuperTooltip1.SetToolTip(tv, text);
            }
        }

        private void AddToolboxTips(System.Collections.IList controls)
        {
            foreach (Control ctl in controls)
            {
                // get control information
                Type t = ctl.GetType();
                string name = t.FullName.Substring(t.Namespace.Length + 1);
                string version = t.Assembly.GetName().Version.ToString();
                string author = "unknown";
                string category = ".NET Component";
                string description = name;
                object[] att = t.GetCustomAttributes(typeof(DescriptionAttribute), true);
                if (att.Length > 0)
                    description = ((DescriptionAttribute)att[0]).Description;
                att = t.Assembly.GetCustomAttributes(typeof(AssemblyCompanyAttribute), true);
                if (att.Length > 0)
                    author = ((AssemblyCompanyAttribute)att[0]).Company;

                // build tooltip
                StringBuilder tip = new StringBuilder();
                tip.AppendFormat(
                    "<div style='width:300px'>" +
                    "<p><b>{0}</b></p>" +
                    "Version {1} from {2}<br>" +
                    "{3}<br><br>" +
                    "{4} </div>" ,
                    name, version, author, category, description);
                att = t.Assembly.GetCustomAttributes(typeof(System.Security.AllowPartiallyTrustedCallersAttribute), true);
                if (att.Length > 0)
                {
                    tip.Append("<hr>" +
                        "<table><tr>" +
                        "<td><img src='res://security.png'></td>" +
                        "<td>Allows partially trusted callers.</td>" +
                        "</tr></table>");
                }

                // assign tooltip
                C1SuperTooltip1.SetToolTip(ctl, tip.ToString());
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            toolStripButton1.Checked = !toolStripButton1.Checked;
            C1SuperTooltip1.IsBalloon = toolStripButton1.Checked;
        }
    }
}
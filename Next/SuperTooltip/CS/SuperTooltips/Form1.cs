using System;
using System.Reflection;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.SuperTooltip;

namespace C1SuperTooltips
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

        // add Html tooltips to items in a toolstrip
        private void AddTipsToToolStrip(ToolStrip toolStrip)
        {
            // do not show the default tooltips
            toolStrip.ShowItemToolTips = false;

            // att Html tooltips to each item in the toolStrip
            foreach (ToolStripItem item in toolStrip.Items)
            {
                // get tooltip text
                string text = item.ToolTipText;
                if (text != null && text.Length > 0)
                {
                    // get tooltip image
                    string image = string.Empty;
                    if (item.Image != null)
                    {
                        string imageName = item.Name + ".Image";
                        image = "res://" + imageName;
                    }

                    // build tip
                    StringBuilder tip = new StringBuilder();
                    tip.AppendFormat("<table><tr><td><img src='{0}'><td style='font:bold 11pt Segoe UI'>{1}</table>",
                        image,
                        System.Web.HttpUtility.HtmlEncode(text));

                    // append general 'get help' tip
                    if (item != this.helpToolStripButton)
                    {
                        tip.Append("</div><hr noshade size=1 color=lightBlue>");
                        tip.AppendFormat("<table><tr><td><img src='{0}'><td>{1}</table>",
                            "res://helpToolStripButton.Image",
                            "Press <b>F1</b> for more help.");
                    }

                    // assign tooltip to item
                    C1SuperTooltip1.SetToolTip(item, tip.ToString());
                }
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
using C1.Win.TreeView;
using FlexGrid_Selection.Helper_Classes;
using System.Diagnostics;
using System.Drawing.Drawing2D;

namespace FlexGrid_Selection
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();

            topicDescriptionLabel.LinkClicked += (s, e) =>
            {
                if (e.Link.LinkData is string targetUrl && !string.IsNullOrWhiteSpace(targetUrl))
                {
                    LinkClicked(targetUrl);
                }
            };

            githubLinkLabel.LinkClicked += (s, e) =>
            {
                LinkClicked(TopicLinks.Github);
            };

            documentationLinkLabel.LinkClicked += (s, e) =>
            {
                LinkClicked(TopicLinks.Documentation);
            };

            var timer = new System.Threading.Timer(_ => {
                if (!this.IsDisposed && this.IsHandleCreated)
                    this.BeginInvoke(new Action(() => this.Refresh()));
            }, null, 0, 50);

            this.FormClosed += (s, e) => timer.Dispose();
        }

        private void About_Load(object sender, EventArgs e)
        {
            if (c1TreeView1.Nodes.Count > 0)
            {
                c1TreeView1.Nodes[0].Selected = true;
            }
        }

        private void c1TreeView1_SelectionChanged(object sender, C1TreeViewEventArgs e)
        {
            topicDescriptionLabel.Links.Clear();

            if (c1TreeView1.Nodes[0].Selected)
            {
                SetTopicDetails(
                    headerText: e.Node.GetValue().ToString(),
                    descriptionText: "The ClipboardCopyMode property allows you to specify whether to include row headers, column headers, or data when copying content, though merged cells are not supported.",
                    linkWord: "ClipboardCopyMode",
                    linkUrl: TopicLinks.ClipboardCopyMode,
                    image: Properties.Resources.ClipboardCopyMode);
            }
            else if (c1TreeView1.Nodes[1].Selected)
            {
                SetTopicDetails(
                    headerText: e.Node.GetValue().ToString(),
                    descriptionText: "FlexGrid, by default, allows to select a continuous batch of cells using mouse or keyboard and entire row or column by clicking the corresponding header. However, the default behavior can be changed to allow selection in units of cell, row, column etc. by using SelectionMode property of the C1FlexGrid class.",
                    linkWord: "SelectionMode",
                    linkUrl: TopicLinks.SelectionMode,
                    image: Properties.Resources.selectionMode);
            }
            else
            {
                SetTopicDetails(
                    headerText: e.Node.GetValue().ToString(),
                    descriptionText: "The Aggregate property uses the AggregateEnum enumeration to apply functions like Average, Sum, Min, Max, Count, and CountDistinct on cell ranges. It also supports statistical operations such as Std, Var, StdPop, and VarPop for standard deviation and variance.",
                    linkWord: "AggregateEnum",
                    linkUrl: TopicLinks.AggregateEnum,
                    image: Properties.Resources.aggregateMode);
            }

            this.Refresh();
        }

        private void SetTopicDetails(string headerText, string descriptionText, string linkWord, string linkUrl, Image image)
        {
            topicHeaderLabel.Text = headerText;
            topicDescriptionLabel.Text = descriptionText;
            AddLinkToDescription(linkWord, linkUrl);
            c1PictureBox1.Image = image;
        }

        private void AddLinkToDescription(string linkWord, string linkUrl)
        {
            if (string.IsNullOrEmpty(linkWord)) return;

            int index = topicDescriptionLabel.Text.IndexOf(linkWord);
            if (index >= 0)
            {
                topicDescriptionLabel.Links.Add(index, linkWord.Length, linkUrl);
            }
        }

        private void LinkClicked(string url)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to open the webpage: {ex.Message}");
            }
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            if (sender is Panel panel)
            {
                int cornerRadius = 10;
                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddArc(0, 0, cornerRadius * 2, cornerRadius * 2, 180, 90);
                    path.AddLine(cornerRadius, 0, panel.Width, 0);
                    path.AddLine(panel.Width, 0, panel.Width, panel.Height);
                    path.AddLine(panel.Width, panel.Height, 0, panel.Height);
                    path.AddLine(0, panel.Height, 0, cornerRadius);
                    panel.Region = new Region(path);
                }
            }
        }
    }
}

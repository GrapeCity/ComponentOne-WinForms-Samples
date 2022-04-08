using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace GaugeDemo
{
    public partial class Form1 : Form
    {
        private bool _gridHidden;

        public Form1()
        {
            InitializeComponent();

            TreeNode node = AddCase(samplesTree.Nodes, "PageRoot1", "Samples");
            TreeNodeCollection nodes = node.Nodes;

            AddCase(nodes, "PageGageDial", "Gage Dial");
            AddCase(nodes, "PageLogarithmic", "Logarithmic 1");
            AddCase(nodes, "PageLogScale", "Logarithmic 2");
            AddCase(nodes, "PageYandexGauge", "Yandex Gauge");
            AddCase(nodes, "PageHelical", "Helical Gauge");
            AddCase(nodes, "PageInclined", "Inclined");
            AddCase(nodes, "PageSlidingScale", "Sliding Scale");
            AddCase(nodes, "PageIntervalWidth", "Fixed Interval Width");
            AddCase(nodes, "PageClock", "Clock");
            AddCase(nodes, "PageSwissRailwayClock", "Swiss Railway Clock");
            AddCase(nodes, "PageEqualizer", "Equalizer");
            AddCase(nodes, "PageCarDashboard", "Car Dashboard");
            AddCase(nodes, "PageHypotrochoid", "Hypotrochoid");
            AddCase(nodes, "PageLituus", "Lituus Progress Bar");
            AddCase(nodes, "PageCircularProgress", "Circular Progress Bar");
            AddCase(nodes, "PageMultithreaded", "Multi-Threaded");
            AddCase(nodes, "PageDataBound", "Data Bound");
            AddCase(nodes, "PageInteractive", "Interactive");
            AddCase(nodes, "PageKnob", "Knob");
            AddCase(nodes, "PageKnob2", "Double Knob");
            AddCase(nodes, "PageRuler", "Ruler Gauge");
            AddCase(nodes, "PageTrackBar", "Track Bar");
            AddCase(nodes, "PageBulletGraph", "Bullet Graph");

            //nodes = samplesTree.Nodes["Samples 2"].Nodes;

            samplesTree.ExpandAll();
        }

        private static TreeNode AddCase(TreeNodeCollection nodes, string className, string text)
        {
            TreeNode node = new TreeNode(text);
            node.Tag = className;
            nodes.Add(node);
            return node;
        }

        private void samplesTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            hsButton.Visible = false;
            Control.ControlCollection controls = hostPanel.Controls;
            if (controls.Count == 1)
            {
                BaseGaugePage oldPage = (BaseGaugePage)controls[0];
                controls.Clear();
                oldPage.Dispose();
            }
            if (e.Node.Tag != null)
            {
                string className = (string)e.Node.Tag;
                Assembly asm = Assembly.GetExecutingAssembly();
                Type classType = asm.GetType("GaugeDemo." + className);
                ConstructorInfo ci = classType.GetConstructor(new Type[0]);
                BaseGaugePage page = (BaseGaugePage)ci.Invoke(null);
                if (!(page is BasePageNoGrid))
                {
                    hsButton.Visible = true;
                    if (_gridHidden)
                    {
                        page.gridPanel.Visible = false;
                        page.splitter1.Visible = false;
                    }
                }
                page.captionLabel.Text = e.Node.Text;
                page.captionLabel.Visible = true;
                page.Dock = DockStyle.Fill;
                controls.Add(page);
            }
        }

        private void hsButton_Click(object sender, EventArgs e)
        {
            Control.ControlCollection controls = hostPanel.Controls;
            if (controls.Count == 1)
            {
                BaseGaugePage page = (BaseGaugePage)controls[0];
                if (!(page is BasePageNoGrid))
                {
                    if (!_gridHidden)
                    {
                        page.gridPanel.Visible = false;
                        page.splitter1.Visible = false;
                        hsButton.Text = "show";
                        _gridHidden = true;
                    }
                    else
                    {
                        page.splitter1.Visible = true;
                        page.gridPanel.Visible = true;
                        hsButton.Text = "hide";
                        _gridHidden = false;
                    }
                }
            }
        }
    }
}

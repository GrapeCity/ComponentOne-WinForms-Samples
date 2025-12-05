using C1.Win.Gauge;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SampleExplorer
{
    public partial class BulletGraph : UserControl
    {
        private List<C1BulletGraph> _graphs = new List<C1BulletGraph>();
        private bool _showScaleLabels = true;
        private bool _showScaleMarks = true;
        private bool _showValueText = false;

        public BulletGraph()
        {
            InitializeComponent();
        }

        [DefaultValue(true)]
        public bool ShowScaleLabels
        {
            get { return _showScaleLabels; }
            set
            {
                if (_showScaleLabels != value)
                {
                    _showScaleLabels = value;
                    foreach (var graph in _graphs)
                        graph.GraphScale.ShowLabels = _showScaleLabels;

                }
            }
        }

        [DefaultValue(true)]
        public bool ShowScaleMarks
        {
            get { return _showScaleMarks; }
            set
            {
                if (_showScaleMarks != value)
                {
                    _showScaleMarks = value;
                    foreach (var graph in _graphs)
                        graph.GraphScale.ShowMarks = _showScaleMarks;

                }
            }
        }

        [DefaultValue(false)]
        public bool ShowValueText
        {
            get { return _showValueText; }
            set
            {
                if (_showValueText != value)
                {
                    _showValueText = value;
                    foreach (var graph in _graphs)
                        graph.ShowValue = _showValueText;
                }
            }
        }


        private void BulletGraph_Load(object sender, EventArgs e)
        {
            _graphs.AddRange(new C1BulletGraph[] {
                c1BulletGraph1,
                c1BulletGraph2,
                c1BulletGraph3,
                c1BulletGraph4,
                c1BulletGraph5,
                c1BulletGraph6,
                c1BulletGraph7,
                c1BulletGraph8,
                c1BulletGraph9,
                c1BulletGraph10,
            });
            Controls.Add(new Splitter() { Dock = DockStyle.Right });
            PropertyGrid propertyGrid = new PropertyGrid() { Dock = DockStyle.Right, Width = Width / 5, MinimumSize = new Size(100, 100) };
            Controls.Add(propertyGrid);
            C1BulletGraph prevBulletGraph = c1BulletGraph1;
            Color prevBackColor = c1BulletGraph1.BackColor;
            EventHandler bulletGraph_Click = (sender, e) => 
            {
                C1BulletGraph bg = sender as C1BulletGraph;
                prevBulletGraph.BackColor = prevBackColor;
                prevBulletGraph = bg;
                bg.BackColor = Color.LightSkyBlue;
                propertyGrid.SelectedObject = bg;
            };
            foreach (var bulletGraph in _graphs)
                bulletGraph.Click += bulletGraph_Click;
            bulletGraph_Click(c1BulletGraph1, null);
        }
    }
}

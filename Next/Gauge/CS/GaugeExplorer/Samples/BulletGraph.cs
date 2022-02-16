using System;
using System.Collections.Generic;
using C1.Win.Gauge;
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
        }
    }
}

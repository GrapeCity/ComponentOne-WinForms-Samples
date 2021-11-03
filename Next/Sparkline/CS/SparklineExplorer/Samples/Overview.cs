using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SparklineExplorer.Samples
{
    public partial class Overview : UserControl
    {
        private SampleData _sampleData = new SampleData();
        public Overview()
        {
            InitializeComponent();
            cmbSparklineType.SelectedIndex = 0;
            c1Sparkline1.Data = _sampleData.DefaultData;
            c1Sparkline1.DisplayXAxis = chkDisplayXAxis.Checked;
        }

        private void btnNewData_Click(object sender, EventArgs e)
        {
            int cnt = 12;
            double[] vals = new double[cnt];
            Random rnd = new Random();
            for (int i = 0; i < cnt; i++)
            {
                vals[i] = rnd.Next(-50, 50);
            }
            c1Sparkline1.Data = vals;
        }

        private void chkDisplayXAxis_CheckedChanged(object sender, EventArgs e)
        {
            c1Sparkline1.DisplayXAxis = chkDisplayXAxis.Checked;

        }

        private void cmbSparklineType_SelectedIndexChanged(object sender, EventArgs e)
        {
            C1.Win.Sparkline.SparklineType type = C1.Win.Sparkline.SparklineType.Line;
            switch (cmbSparklineType.SelectedIndex)
            {
                case 1:
                    type = C1.Win.Sparkline.SparklineType.Column;
                    break;
                case 2:
                    type = C1.Win.Sparkline.SparklineType.WinLoss;
                    break;
            }
            c1Sparkline1.SparklineType = type;
        }
    }
}

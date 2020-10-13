using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Win7Pack;

namespace ControlExplorer.Win7Pack
{
    public partial class ProgressIndicatorDemo : Form
    {
        public ProgressIndicatorDemo()
        {
            InitializeComponent();

            // init progress indicator
            c1TaskbarButton1.ProgressIndicator.Value = trackBar1.Value;
            c1TaskbarButton1.ProgressIndicator.Show();
        }

        private void progressCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (progressCheckBox.Checked)
                c1TaskbarButton1.ProgressIndicator.Show();
            else
                c1TaskbarButton1.ProgressIndicator.Hide();
        }

        private void progressRadioButton_Click(object sender, EventArgs e)
        {
            switch (((RadioButton)sender).Text)
            {
                case "Normal":
                    c1TaskbarButton1.ProgressIndicator.State = TaskbarProgressState.Normal;
                    break;
                case "Error":
                    c1TaskbarButton1.ProgressIndicator.State = TaskbarProgressState.Error;
                    break;
                case "Paused":
                    c1TaskbarButton1.ProgressIndicator.State = TaskbarProgressState.Paused;
                    break;
                case "Marquee":
                    c1TaskbarButton1.ProgressIndicator.State = TaskbarProgressState.Indeterminate;
                    break;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            c1TaskbarButton1.ProgressIndicator.Value = trackBar1.Value;
            progressBar1.Value = trackBar1.Value;
        }
    }
}

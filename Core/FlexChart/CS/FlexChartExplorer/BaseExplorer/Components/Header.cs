using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaseExplorer.Components
{
    public partial class Header : UserControl
    {
        public Image Logo
        {
            get { return pbLogo.Image; }
            set { pbLogo.Image = value; }
        }

        public string AppTitle
        {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }

        public string SampleTitle
        {
            get { return lblHeader.Text; }
            set { lblHeader.Text = value; }
        }

        public int LeftPanelWidth
        { get { return pnlAppTitle.Width; } }

        public int RightPanelWidth
        { get { return pnlSampleTitle.Width; } }

        public Color AppTitleBackColor
        {
            get { return pnlAppTitle.BackColor; }
            set { pnlAppTitle.BackColor = value; }
        }
        public Color SampleTitleBackColor
        {
            get { return pnlSampleTitle.BackColor; }
            set { pnlSampleTitle.BackColor = value; }
        }

        public Color AppTitleForeColor
        {
            get { return lblTitle.ForeColor; }
            set { lblTitle.ForeColor = value; }
        }

        public Color SampleTitleForeColor
        {
            get { return lblHeader.ForeColor; }
            set
            {
                lblHeader.ForeColor = value;
            }
        }

        public Header()
        {
            InitializeComponent();
            AutoSize = true;
        }

        private void pnlAppTitle_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(Pens.Black, 0, 0, pnlAppTitle.Right, pnlAppTitle.Top);
        }
    }
}

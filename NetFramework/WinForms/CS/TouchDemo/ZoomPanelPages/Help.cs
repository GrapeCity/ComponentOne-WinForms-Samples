using C1.Win.TouchToolKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TouchDemo.C1ZoomPanelPages
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
            button1.Click += button1_Click;
            C1ZoomPanel1.ZoomFactorChanged += C1ZoomPanel1_ZoomFactorChanged;
        }

        public C1ZoomPanel C1ZoomPanel
        {
            get
            {
                return C1ZoomPanel1;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            toolStripStatusLabel1.Text = " ZoomFactor:" + (C1ZoomPanel1.ZoomFactor * 100).ToString() + "%";
            
            base.OnLoad(e);
        }

        int id = 1;
        void C1ZoomPanel1_ZoomFactorChanged(object sender, EventArgs e)
        {
            listBox1.Items.Add(id.ToString() + " ZoomFactor:" + (C1ZoomPanel1.ZoomFactor * 100).ToString() + "%");
            toolStripStatusLabel1.Text = " ZoomFactor:" + (C1ZoomPanel1.ZoomFactor * 100).ToString() + "%";
            id++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            id = 0;
            listBox1.Items.Clear();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
        }
    }
}

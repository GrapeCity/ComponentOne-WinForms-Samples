using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace TouchToolKitDemo
{
    public partial class FirstViewPage : UserControl
    {
        public FirstViewPage()
        {
            InitializeComponent();

            this.Load += new System.EventHandler(this.FirstViewPage_Load);
            //product_link1.LinkClicked += new LinkLabelLinkClickedEventHandler(product_link1_LinkClicked);
        }

        private void FirstViewPage_Load(object sender, EventArgs e)
        {
            // Set the background of the label to transparent, with respect to the PictureBox control
            mainvisual.Controls.Add(product3);
        }

        private void product_link1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Link to product information from the first view
            //System.Diagnostics.Process.Start("");
        }
    }
}

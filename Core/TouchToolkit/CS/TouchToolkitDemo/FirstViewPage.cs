using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace TouchToolkitDemo
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
            // ラベルの背景をPictureBoxコントロールに対して透過にする
            //mainvisual.Controls.Add(product1);
            mainvisual.Controls.Add(product2);
            mainvisual.Controls.Add(product3);
            //mainvisual.Controls.Add(product_body);
            //mainvisual.Controls.Add(product_link1);
            //mainvisual.Controls.Add(product_title);
        }

        private void product_link1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // ファーストビューから製品情報へのリンク
            //System.Diagnostics.Process.Start("");
        }
    }
}

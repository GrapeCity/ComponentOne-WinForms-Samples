using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ControlExplorer.SuperTooltip
{
    public partial class HtmlFeatures : C1DemoForm
    {
        public HtmlFeatures()
        {
            InitializeComponent();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
            {
                c1SuperLabel3.Text = c1SuperTooltip1.GetToolTip(rb);
                richTextBox1.Text = c1SuperTooltip1.GetToolTip(rb);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            splitContainer2.Panel2Collapsed = !checkBox1.Checked;
        }

        private void c1SuperLabel3_LinkClicked(object sender, C1.Win.C1SuperTooltip.C1SuperLabelLinkClickedEventArgs e)
        {
           Process.Start(e.HRef);
        }

        private void c1SuperTooltip1_Popup(object sender, C1.Win.C1SuperTooltip.PopupEventArgs e)
        {
            e.Text = "<b>C1SuperTooltip</b>" + e.Text;
        }

        private void HtmlFeatures_Load(object sender, EventArgs e)
        {
            c1SuperLabel3.Text = c1SuperTooltip1.GetToolTip(radioButton1);
            richTextBox1.Text = c1SuperTooltip1.GetToolTip(radioButton1);
        }

    }
}

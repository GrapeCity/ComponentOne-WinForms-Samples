using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransposedGrid
{
    public partial class AboutFlexGridModalForm : Form
    {
        public AboutFlexGridModalForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://developer.mescius.com/componentone/docs/win/online-flexgrid/overview.html";
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // This ensures it opens in the default web browser
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open the webpage: " + ex.Message);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://developer.mescius.com/componentone/docs/win/online-flexgrid/key-features.html";
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // This ensures it opens in the default web browser
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open the webpage: " + ex.Message);
            }
        }



    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BaseExplorer.Components;
using System.IO;

namespace FlexChartExplorer.Samples
{
    public partial class Home : BaseSample
    {
        public string Description
        {
            get
            {
                return this.rtbDescription.Rtf;
            }
            set
            {
                try
                {
                    this.rtbDescription.Rtf = value;
                }
                catch (ArgumentException)
                {
                    this.rtbDescription.Text = value;
                }
            }
        }
        public Home()
        {
            InitializeComponent();
            InitializeControls();
            try
            {
                var baseDir = AppDomain.CurrentDomain.BaseDirectory;
                var descPath = Path.Combine(baseDir, "Descriptions\\home.rtf");
                this.Description = File.ReadAllText(descPath);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InitializeControls()
        {
            rtbDescription = new RichTextBox()
            {
                BorderStyle = BorderStyle.None,
                ReadOnly = true,
                BackColor = Color.White,
                Dock = DockStyle.Fill,
                Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)))
            };
            pnlMain.Controls.Add(rtbDescription);
            pnlControls.Visible = false;
            ShowDescriptionPanel = false;
        }
    }
}

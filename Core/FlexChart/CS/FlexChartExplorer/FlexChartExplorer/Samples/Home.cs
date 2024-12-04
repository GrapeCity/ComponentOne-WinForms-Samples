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
using BaseExplorer.Core;
using C1.Framework;
using System.Drawing.Drawing2D;

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
            this.DoubleBuffered = true;
            try
            {
                var baseDir = AppDomain.CurrentDomain.BaseDirectory;
                var descPath = Path.Combine(baseDir, "Descriptions\\home.rtf");
                Description = File.ReadAllText(descPath);
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
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI Variable", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)))
            };
            pnlMain.Controls.Add(rtbDescription);
            pnlControls.Visible = false;
            ShowDescriptionPanel = false;
        }

        public override void RootPanelPaint(object sender, PaintEventArgs e)
        {
            if (Theme == "Office365White")
            {
                this.BackColor = SkinManager.LightBackColor;
            }
            else
            {
                pnlMain.BackColor = SkinManager.Office365LightBlack;
              
            }
        }

        public override void ReapplyProperties()
        {
            if (Theme == "Office365White")
            {
                pnlMain.BackColor = SkinManager.LightBackColor;
                rtbDescription.BackColor = SkinManager.LightBackColor;
                rtbDescription.ForeColor = SkinManager.Office365Black;
            }
            else
            {
                pnlMain.BackColor = SkinManager.Office365LightBlack;
                rtbDescription.BackColor = SkinManager.Office365LightBlack;
                rtbDescription.ForeColor = Color.White;
            }
        }
    }
}

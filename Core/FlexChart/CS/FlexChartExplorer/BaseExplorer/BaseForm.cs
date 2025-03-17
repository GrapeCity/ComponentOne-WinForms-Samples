using BaseExplorer.Components;
using BaseExplorer.Core;
using BaseExplorer.Model;
using System;
using System.Windows.Forms;
using C1.Win.Themes;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Drawing;
using C1.Win.Input;
using System.Security.Cryptography;

namespace BaseExplorer
{
    public abstract partial class BaseForm : Form
    {
        private SampleItem selectedSample;
        private string _currentTheme = "Office365White";

        public BaseForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Load += OnLoad;
            this.btnToggleTheme.ImageList = this.imageList1;
            this.btnToggleTheme.ImageIndex = 1;
            ApplyTheme(_currentTheme);
        }

        private void OnLoad(object sender, EventArgs e)
        {
            var filePath = GetConfigLocation();
            sideBarOptions.SelectionChanged += OnSideBarSelectionChanged;
            Explorer.Init(filePath, this.sideBarOptions, this.sampleHost21, this.tileControl1);
        }


        private void OnSideBarSelectionChanged(object sender, SideBar2EventArgs e)
        {
            if (e.SelectedSample == null || selectedSample == e.SelectedSample)
                return;
            selectedSample = e.SelectedSample;
            switch (selectedSample.Depth)
            {
                case 0:
                    Explorer.Instance.ShowSample(selectedSample, _currentTheme);
                    break;
                case 1:
                case 2:
                    Explorer.Instance.ShowTiles(selectedSample, _currentTheme);
                    break;
                default:
                    Explorer.Instance.ShowTiles(selectedSample.Items[0], _currentTheme);
                    break;
            }
        }

        private void PaintPanel(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                int cornerRadius = 7;
                GraphicsPath path = new GraphicsPath();

                path.AddArc(0, 0, cornerRadius * 2, cornerRadius * 2, 180, 90); // Quarter-circle arc for upper-left
                path.AddLine(cornerRadius, 0, panel.Width, 0);                   // Top edge
                path.AddLine(panel.Width, 0, panel.Width, panel.Height);          // Right edge
                path.AddLine(panel.Width, panel.Height, 0, panel.Height);         // Bottom edge
                path.AddLine(0, panel.Height, 0, cornerRadius);                   // Left edge

                Color color = _currentTheme == "Office365White" ? SkinManager.HighLightBackColor : SkinManager.BlackBackColor;
                using (Pen borderPen = new Pen(color, 2))
                {
                    g.DrawPath(borderPen, path);
                }

                color = _currentTheme == "Office365White" ? SkinManager.LightBackColor : SkinManager.Office365LightBlack;
                using (Brush whiteBrush = new SolidBrush(color))
                {
                    g.FillPath(whiteBrush, path);
                }
            }
        }

        public void _toggleBtn_Click(object sender, EventArgs e)
        {
            var currentTheme = C1ThemeController.ApplicationTheme;
            if (currentTheme == "Office365White")
            {
                _currentTheme = "Office365Black";
            }
            else
            {
                _currentTheme = "Office365White";
            }
            ApplyTheme(_currentTheme);
        }

        private void ApplyTheme(string theme)
        {
            // Apply theme to sample panel only
            C1ThemeController.ApplyThemeToControlTree(this.panel1, C1ThemeController.GetThemeByName(theme, false), null, true);

            //Set specific colors based on theme
            ColorPanels(theme == "Office365White" ? SkinManager.LightBackColor : SkinManager.Office365LightBlack);

            if ((selectedSample == null ? 0 : selectedSample.Depth) == 0) 
            {
                // Set theme in other sample controls 
                sampleHost21.Theme = theme;
            }
            else
            {
                // Set theme in tile control
                tileControl1.Theme = theme;
            }     

            // Sidebar custom skin handling 
            sideBarOptions.Theme = theme;

            // Update the theme for toggle button
            this.btnToggleTheme.ImageIndex = _currentTheme == "Office365Black" ? 0 : 1;
            C1ThemeController.ApplicationTheme = theme;
        }

        private void ColorPanels(Color color)
        {
            panel1.BackColor = color;
            panel2.BackColor = color;
            panel4.BackColor = color;
        }


        /// <summary>
        /// Override this in the child class to provide location of the explorer configuration file
        /// </summary>
        /// <returns>location of the explorer configuration file</returns>
        protected abstract string GetConfigLocation();

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // WS_EX_COMPOSITED
                return cp;
            }
        }
    }
}

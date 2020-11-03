using C1.Win.Chart;
using FlexChart101.Samples;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace FlexChart101
{
    public partial class MainForm : Form
    {
        #region const
        Color MENU_BACK_COLOR = System.Drawing.Color.FromArgb(249, 249, 249);
        Color MENU_ONOVER_COLOR = System.Drawing.Color.FromArgb(21, 164, 250);
        Color MENU_SELECTED_COLOR = System.Drawing.Color.FromArgb(230, 230, 230);
        int MENU_BUTTON_HEIGHT = 30;
        #endregion

        Image _menuButtonImage;

        string[] menuButtons = { "GETTING STARTED", "CHART TYPES", "MIXED TYPES", 
                                   "LEGEND AND TITLES", "TOOLTIPS", "STYLING SERIES",
                                   "CUSTOMIZING AXES", "SELECTION MODES", "TOGGLE",
                                   "DYNAMIC", "FUNNEL"
                               };
        public MainForm()
        {
            InitializeComponent();

            InitializeMenu();
        }

        private void InitializeMenu()
        {
            panelLinks.BackColor = MENU_BACK_COLOR;

            var top = 20;
            foreach (var item in menuButtons)
            {
                var newButton = new Button()
                {
                    Text = item,
                    Font = new Font("Calibri", 10, FontStyle.Bold),
                    ForeColor = Color.FromArgb(64, 64, 64),
                    TextAlign = ContentAlignment.MiddleLeft,
                    Width = panelLinks.Width - 2,
                    Height = MENU_BUTTON_HEIGHT,
                    Top = top,
                    FlatStyle = FlatStyle.Flat,
                    Left = 1
                };
                top += MENU_BUTTON_HEIGHT;
                newButton.FlatAppearance.BorderSize = 0;
                newButton.FlatAppearance.MouseOverBackColor = MENU_ONOVER_COLOR;
                newButton.Padding = new Padding(15, 0, 0, 0);
                newButton.Click += button1_Click;
                panelLinks.Controls.Add(newButton);

                // Initialize button style image
                _menuButtonImage = new Bitmap(panelLinks.Width + 15, MENU_BUTTON_HEIGHT + 1);
                using (Graphics g = Graphics.FromImage(_menuButtonImage))
                {
                    g.Clear(MENU_SELECTED_COLOR);
                    g.FillRectangle(new SolidBrush(MENU_ONOVER_COLOR), 0, 0, 7, MENU_BUTTON_HEIGHT);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Open first link
            if (panelLinks.Controls[0] is Button)
                (panelLinks.Controls[0] as Button).PerformClick();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var clickedButton = (sender as Button);
            panelMain.Controls.Clear();
            Control newControl;
            var str = clickedButton.Text;
            switch (str)
            {
                case "GETTING STARTED": newControl = new GettingStarted(); break;
                case "CHART TYPES": newControl = new ChartTypes(); break;
                case "MIXED TYPES": newControl = new MixedChartTypes(); break;
                case "LEGEND AND TITLES": newControl = new LegendAndTitles(); break;
                case "TOOLTIPS": newControl = new Tooltips(); break;
                case "STYLING SERIES": newControl = new StylingSeries(); break;
                case "CUSTOMIZING AXES": newControl = new CustomizingAxes(); break;
                case "SELECTION MODES": newControl = new SelectionModes(); break;
                case "TOGGLE": newControl = new Toggle(); break;
                case "DYNAMIC": newControl = new Dynamic(); break;
                case "FUNNEL": newControl = new FunnelChart(); break;
                default: newControl = new ChartTypes(); break;
            }

            newControl.Dock = DockStyle.Fill;
            panelMain.Controls.Add(newControl);

            // Paint selection button color
            foreach (Button item in panelLinks.Controls)
                item.Image = null;

            clickedButton.Image = _menuButtonImage;
        }

        private void panelLinks_Paint(object sender, PaintEventArgs e)
        {
            using (var pen = new Pen(new SolidBrush(Color.DarkGray)))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, panelLinks.Width - 1, panelLinks.Height - 1);
            }
        }
    }
}

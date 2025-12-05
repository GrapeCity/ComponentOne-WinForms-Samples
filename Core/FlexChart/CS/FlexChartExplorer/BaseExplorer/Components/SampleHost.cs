using BaseExplorer.Core;
using BaseExplorer.Model;
using BaseExplorer.Utilities;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using System.Drawing.Drawing2D;
using C1.Win.Themes;
using System.ComponentModel;

namespace BaseExplorer.Components
{
    public partial class SampleHost : UserControl
    {
        SampleManager samplesManager;
        Label _tabSelected;
        private string _theme = "Office365White";

        public SampleHost()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);

            _tabSelected = lblDemo;

            lblDemo.MouseEnter += OnMouseEnter;
            lblDemo.MouseLeave += OnMouseLeave;

            lblInfo.MouseEnter += OnMouseEnter;
            lblInfo.MouseLeave += OnMouseLeave;
        }

        [DefaultValue(null)]
        public SampleItem Sample { get; set; }

        [DefaultValue("Office365White")]
        public string Theme
        {
            get
            {
                return _theme;
            }
            set
            {
                if (_theme != value && Sample != null)
                {
                    _theme = value;
                    LoadSample();
                    ApplyTheme();
                }
                else
                {
                    _theme = value;
                }


            }
        }

        /// <summary>
        /// Load the given sample into view
        /// </summary>
        /// <param name="sample"></param>
        public void LoadSample()
        {
            this.SuspendDrawing();

            lblTitle.Text = Sample.Name;
            try
            {
                if (samplesManager == null)
                    samplesManager = Explorer.Instance.Manager;
                var fullName = string.Format("{0},{1}", Sample.TypeName, Assembly.GetEntryAssembly().FullName);

                Type t = Type.GetType(fullName);
                //Check if type is null or not
                if (t == null)
                {
                    MessageBox.Show($"Could not load type: {Sample.TypeName}");
                    return;
                }
                var view = Activator.CreateInstance(t) as BaseSample;
                //Checking for null before operations
                if (view == null)
                {
                    MessageBox.Show($"Could not instantiate {t.FullName} as BaseSample");
                    return;
                }
                pnlDemo.Controls.Clear(true);
                pnlDemo.Controls.Add(view);

                view.Theme = Theme;
                view.Dock = DockStyle.Fill;
                if (Sample.Description == "" || Sample.TypeName == "")
                {
                    flowLayoutPanel1.Visible = false;
                    pnlDemo.Visible = true;
                    descPnl.Visible = false;
                    // Home falls in this category: No descirption, sample is just a rich text and not chart
                    // For this, theme is applied but the skin kept as in Figma, hence the reapply method here 
                    pnlViewer.BackColor = Color.Transparent;
                    view.ReapplyProperties();
                }
                else
                {
                    flowLayoutPanel1.Visible = true;
                    if (_tabSelected == lblDemo)
                    {
                        pnlDemo.Visible = true;
                        descPnl.Visible = false;
                        if (Sample.Name != "Home" && Theme != null)
                            C1ThemeController.ApplyThemeToControlTree(view, C1ThemeController.GetThemeByName(Theme, false), null, true);
                    }
                    else
                    {
                        pnlDemo.Visible = false;
                        descPnl.Visible = true;
                        richTextBox1.Rtf = Sample.Description.Trim().MakeRtf();
                        ColorInfoSection();
                        pnlViewer.Controls.Add(descPnl);
                    }
                }
                ApplyTheme();
            }
            catch (TargetInvocationException ex)
            {
                //specifically catching reflection errors
                Exception innerEx = ex.InnerException ?? ex;
                MessageBox.Show($"Reflection error: {innerEx.Message}\nStack trace: {innerEx.StackTrace}");
            }
            catch (Exception ex)
            {
                //General fallback
                Exception innerEx = ex.InnerException ?? ex;
                MessageBox.Show($"Unexpected error: {innerEx.Message}\nStack trace: {innerEx.StackTrace}");
            }

            this.ResumeDrawing();
        }

        private void ColorInfoSection()
        {
            if (Theme == "Office365White")
            {
                descPnl.BackColor = SkinManager.LightBackColor;
                richTextBox1.BackColor = SkinManager.LightBackColor;
                richTextBox1.ForeColor = SystemColors.ControlText;
            }
            else
            {
                descPnl.BackColor = SkinManager.Office365LightBlack;
                richTextBox1.BackColor = SkinManager.Office365LightBlack;
                richTextBox1.ForeColor = Color.White;
            }
        }

        public void ApplyTheme()
        {
            ColorPanels(Theme == "Office365Black" ? SkinManager.Office365LightBlack : SkinManager.LightBackColor);
        }

        private void ColorPanels(Color color)
        {
            BackColor = color;
            tableLayoutPanel1.BackColor = color;
            pnlViewer.BackColor = color;
            pnlDemo.BackColor = color;
            flowLayoutPanel1.BackColor = color;
        }

        private void LabelPaint(object sender, PaintEventArgs e)
        {
            Label label = sender as Label;
            int indicator_width = 16;
            if (label == _tabSelected)
            {
                using (Pen bluePen = new Pen(SkinManager.Indicator, 3))
                {
                    bluePen.StartCap = LineCap.Round;
                    bluePen.EndCap = LineCap.Round;
                    bluePen.LineJoin = LineJoin.Round;

                    int underlineY = label.Height - 6;
                    e.Graphics.DrawLine(bluePen, label.Width / 2 - indicator_width / 2, underlineY, label.Width / 2 + indicator_width / 2, underlineY);
                }
            }
        }

        private void LabelClick(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != _tabSelected)
            {
                _tabSelected = clickedLabel;
                lblDemo.Invalidate();
                lblInfo.Invalidate();
            }
            LoadSample();
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            Label tab = sender as Label;
            this.Cursor = Cursors.Hand;
            tab.BackColor = _theme == "Office365White" ? SkinManager.HighLightBackColor : SkinManager.Office365Black;
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            Label tab = sender as Label;
            this.Cursor = Cursors.Default;
            tab.BackColor = Color.Transparent;
        }

        private void OnContentsResized(object sender, ContentsResizedEventArgs e)
        {
            this.Height = Math.Min(e.NewRectangle.Height + 20, 350);
        }
    }
}

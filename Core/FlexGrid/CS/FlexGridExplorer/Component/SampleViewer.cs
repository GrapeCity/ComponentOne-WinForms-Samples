using C1.Win.Input;
using FlexGridExplorer.Properties;
using FlexGridExplorer.Utility;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.ComponentModel;

namespace FlexGridExplorer.Component
{
    /// <summary>
    /// Represents the main viewer control responsible for displaying demo samples
    /// and their corresponding descriptions within the FlexGrid Explorer application.
    /// </summary>
    public partial class SampleViewer : UserControl
    {
        #region Private Variables
        C1Label _tabSelected;
        #endregion
        public SampleViewer()
        {
            InitializeComponent();

            lblInfo.Text = StringsEN.TxtInfo;
            lblDemo.Text = StringsEN.TxtDemo;

            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);

            _tabSelected = lblDemo;

            subscribeMethods();
        }

        private void subscribeMethods()
        {
            lblDemo.MouseEnter += OnMouseEnter;
            lblDemo.MouseLeave += OnMouseLeave;

            lblInfo.MouseEnter += OnMouseEnter;
            lblInfo.MouseLeave += OnMouseLeave;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ItemInfo Sample { get; set; }


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
                string typeName = string.Format("{0},{1}", Sample.TypeName, Assembly.GetEntryAssembly().FullName);
                Type t = Type.GetType(typeName);
                var view = Activator.CreateInstance(t) as Control;
                pnlDemo.Controls.Clear(true);
                pnlDemo.Controls.Add(view);

                view.Dock = DockStyle.Fill;

                if (Sample.Name == "Home")
                {
                    view.Padding = new Padding(13, 0, 0, 0);
                    pnlViewer.Controls.Add(view);
                    flowLayoutPanel1.Visible = false;
                    pnlDemo.Visible = false;
                    pnlDesc.Visible = false;
                }
                else
                {
                    flowLayoutPanel1.Visible = true;

                    bool isDemoTabSelected = _tabSelected == lblDemo;
                    pnlDemo.Visible = isDemoTabSelected;
                    pnlDesc.Visible = !isDemoTabSelected;
                    if (!isDemoTabSelected)
                        sampleDesc.Text = Sample.LongDescription; ;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.ResumeDrawing();
        }

        private void LabelPaint(object sender, PaintEventArgs e)
        {
            C1Label label = sender as C1Label;
            int indicator_width = 16;
            if (label == _tabSelected)
            {
                using (Pen bluePen = new Pen(SkinManager.HighlighterColor, 3))
                {
                    bluePen.StartCap = LineCap.Round;
                    bluePen.EndCap = LineCap.Round;
                    bluePen.LineJoin = LineJoin.Round;

                    int underlineY = label.Height - 2;
                    e.Graphics.DrawLine(bluePen, label.Width / 2 - indicator_width / 2, underlineY, label.Width / 2 + indicator_width / 2, underlineY);
                }
            }
        }

        private void LabelClick(object sender, EventArgs e)
        {
            C1Label clickedLabel = sender as C1Label;

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
            C1Label tab = sender as C1Label;
            this.Cursor = Cursors.Hand;
            tab.BackColor = SkinManager.HighLightBackColor;
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            C1Label tab = sender as C1Label;
            this.Cursor = Cursors.Default;
            tab.BackColor = Color.Transparent;
        }

        private void OnContentsResized(object sender, ContentsResizedEventArgs e)
        {
            this.Height = Math.Min(e.NewRectangle.Height + 20, 350);
        }

        //to remove the flickering effect
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

    }
}

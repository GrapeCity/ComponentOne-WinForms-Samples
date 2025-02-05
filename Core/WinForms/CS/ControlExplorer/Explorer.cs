using C1.Win.Ribbon;
using ControlExplorer.Controls;
using ControlExplorer.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace ControlExplorer
{
    public partial class Explorer : C1RibbonForm
    {
        #region Static Variables
        public static string HomeTitle = "Control Explorer";
        public static string HomeControlTitle = "New Controls && Features";
        public static string SuiteDescription = "Deliver complete desktop applications in less time with 120+ UI controls. ComponentOne WinForms controls come packed with lightning-fast data management and data visualization controls, easy-to-use designers, and modern themes to help you build beautiful Windows applications.";
        #endregion

        #region Private Variables
        private bool _isExpanded = true;
        private List<ItemInfo> _samples;
        private ItemInfo _selectedSample;
        #endregion
        public static Explorer TheExplorer { get; private set; }
        public Explorer()
        {
            InitializeComponent();
            TheExplorer = this;
            SampleManager sampleManager = new SampleManager();
            _samples = sampleManager.ItemCollection.Items.ToList();
            sidebar.SelectionChanged += OnSideBarSelectionChanged;
            sidebar.Samples = _samples;
            homePageControl1.Samples = _samples;
            panel1.Paint += Panel1_Paint;
            panel1.BackColor = SkinManager.HomeBackColor;
            ShowHomePage();
            Application.AddMessageFilter(new ClickOutsideFilter(sidebar));
        }
        public void ShowControl(ItemInfo info, Boolean isSidebarEvent)
        {
            {
                try
                {
                    this.Cursor = Cursors.AppStarting;
                    LockWindowUpdate(Handle);
                    demoViewer1.Padding = new Padding(40, 20, 40, 20);
                    ShowSample(info, isSidebarEvent);
                }
                finally
                {
                    LockWindowUpdate(IntPtr.Zero);
                    this.Cursor = Cursors.Default;
                }
            }
        }

        public void ChangeSideBarSelection(ItemInfo info)
        {
            var treeView = sidebar.Controls.Find("treeView", true).First() as StackTreeControl;
            treeView.SelectedNode = treeView.FindNode(info.Guid.ToString());
        }

        public void ShowSample(ItemInfo info, Boolean isSidebarEvent)
        {
            if (info != null)
            {
                try
                {
                    this.Cursor = Cursors.AppStarting;
                    LockWindowUpdate(Handle);
                    this.demoViewer1.Show(info, isSidebarEvent);
                    this.homePageControl1.Visible = false;
                    this.demoViewer1.Visible = true;
                }
                finally
                {
                    LockWindowUpdate(IntPtr.Zero);
                    this.Cursor = Cursors.Default;
                }
            }
        }
        public void InvalidatePanel()
        {
            panel1.PerformLayout();
            panel1.Invalidate();
        }

        #region Private Methods 
        private void ShowHomePage()
        {
            homePageControl1.Visible = true;
            demoViewer1.Visible = false;
        }

        private void OnSideBarSelectionChanged(object sender, SideBarEventArgs e)
        {
            if (e.SelectedSample == null || _selectedSample == e.SelectedSample)
                return;
            _selectedSample = e.SelectedSample;
            if (_selectedSample.Name == "Home")
            {
                ShowHomePage();
            }
            else
            {
                ShowControl(_selectedSample, true);
            }
        }
        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            int cornerRadius = 15;
            int borderThickness = 1;
            Color borderColor = Color.White;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(borderThickness / 2, borderThickness / 2, cornerRadius * 2, cornerRadius * 2, 180, 90);

                path.AddLine(cornerRadius + borderThickness / 2, borderThickness / 2, panel1.Width - borderThickness, borderThickness / 2);
                path.AddLine(panel1.Width - borderThickness, borderThickness / 2, panel1.Width - borderThickness, panel1.Height - borderThickness);
                path.AddLine(panel1.Width - borderThickness, panel1.Height - borderThickness, borderThickness / 2, panel1.Height - borderThickness);
                path.AddLine(borderThickness / 2, panel1.Height - borderThickness, borderThickness / 2, cornerRadius + borderThickness / 2);

                panel1.Region = new Region(path);

                using (Pen borderPen = new Pen(borderColor, borderThickness))
                {
                    borderPen.Alignment = PenAlignment.Center;
                    e.Graphics.DrawPath(borderPen, path);
                }
            }
        }

        #endregion

        [System.Runtime.InteropServices.DllImport("user32.dll", ExactSpelling = true)]
        internal static extern bool LockWindowUpdate(IntPtr hWndLock);
    }
}

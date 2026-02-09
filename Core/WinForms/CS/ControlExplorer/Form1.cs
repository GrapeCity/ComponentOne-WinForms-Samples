// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

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
    public partial class Explorer : Form
    {
        #region Static Variables
        public static string HomeTitle = Resources.StringEN.HomeTitle;
        public static string HomeControlTitle = Resources.StringEN.HomeControlTitle;
        public static string SuiteDescription = Resources.StringEN.SuiteDescription;
        #endregion

        #region Private Variables
        private readonly List<ItemInfo> _samples;
        private ItemInfo _selectedSample;
        #endregion
        public static Explorer TheExplorer { get; private set; }
        public Explorer()
        {
            InitializeComponent();
            TheExplorer = this;
            Text = Resources.StringEN.Text;
            SampleManager sampleManager = new SampleManager();
            _samples = sampleManager.ItemCollection.Items.ToList();
            sideBar1.SelectionChanged += OnSideBarSelectionChanged;
            sideBar1.Samples = _samples;
            homePageControl1.Samples = _samples;
            panel1.Resize += Panel1_Resize;
            panel1.BackColor = SkinManager.HomeBackColor;
            ShowHomePage();
            Application.AddMessageFilter(new ClickOutsideFilter(sideBar1));
            ApplyRoundedCorners(panel1);
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
            var treeView = sideBar1.Controls.Find("treeView", true).First() as StackTreeControl;
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
        private void Panel1_Resize(object sender, EventArgs e)
        {
            ApplyRoundedCorners(panel1);
        }

        private void ApplyRoundedCorners(Control ctrl)
        {
            int borderThickness = 1;
            int radius = 15;
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(borderThickness / 2, borderThickness / 2, radius * 2, radius * 2, 180, 90);
                path.AddLine(radius + borderThickness / 2, borderThickness / 2, ctrl.Width - borderThickness, borderThickness / 2);
                path.AddLine(ctrl.Width - borderThickness, borderThickness / 2, ctrl.Width - borderThickness, ctrl.Height - borderThickness);
                path.AddLine(ctrl.Width - borderThickness, ctrl.Height - borderThickness, borderThickness / 2, ctrl.Height - borderThickness);
                path.AddLine(borderThickness / 2, ctrl.Height - borderThickness, borderThickness / 2, radius + borderThickness / 2);
                path.CloseFigure();
                ctrl.Region = new Region(path);
            }
        }
        #endregion

        [System.Runtime.InteropServices.DllImport("user32.dll", ExactSpelling = true)]
        internal static extern bool LockWindowUpdate(IntPtr hWndLock);
    }
}

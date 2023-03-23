using BaseExplorer.Core;
using BaseExplorer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace BaseExplorer
{
    public abstract partial class BaseForm : Form
    {
        private SampleItem selectedSample;
        public BaseForm()
        {
            InitializeComponent();
            this.Load += OnLoad;
            this.SizeChanged += (s,e)=> splitContainer1.SplitterDistance = this.header1.LeftPanelWidth;
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            InitializeStyles();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            sideBar1.SelectionChanged += OnSideBarSelectionChanged;
            var filePath = GetConfigLocation();
            Explorer.Init(filePath, this.sideBar1, this.header1, this.tileControl1, this.sampleHost1);
        }

        private void OnSideBarSelectionChanged(object sender, Components.SideBarEventArgs e)
        {
            if (e.SelectedSample == null || selectedSample == e.SelectedSample)
                return;
            selectedSample = e.SelectedSample;
            header1.SampleTitle = selectedSample.Title;
            switch (selectedSample.Depth)
            {
                case 0:
                    Explorer.Instance.ShowSample(selectedSample);
                    break;
                case 1:
                case 2:
                    Explorer.Instance.ShowTiles(selectedSample);
                    break;
                default:
                    header1.SampleTitle = selectedSample.Items[0].Title;
                    Explorer.Instance.ShowTiles(selectedSample.Items[0]);
                    break;
            }

        }

        /// <summary>
        /// Override this in the child class to provide location of the explorer configuration file
        /// </summary>
        /// <returns>location of the explorer configuration file</returns>
        protected abstract string GetConfigLocation();

        private void InitializeStyles()
        {
            //Header
            header1.Logo = Properties.Resources.C1;
            header1.SampleTitleForeColor = SkinManager.PrimaryTextColor;

            header1.SampleTitleBackColor = SkinManager.PrimaryColor;

            //TileControl
            tileControl1.BackColor = SkinManager.PrimaryBackColor;
            tileControl1.HoverColor = Color.FromArgb(64, 99, 99);

            sideBar1.treeView.SelectionColor = ControlPaint.Light(SkinManager.PrimaryLightColor);
            sideBar1.treeView.SelectionForeColor = SkinManager.PrimaryTextColor;
        }
    }
}

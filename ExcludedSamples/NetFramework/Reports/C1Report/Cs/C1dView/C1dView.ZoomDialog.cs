using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Preview;

namespace C1dView
{
    public partial class ZoomDialog : Form
    {
        public ZoomDialog()
        {
            InitializeComponent();

            this.numZoom.ValueChanged += (s, e) =>
                {
                    if (!Updating)
                    {
                        PreviewPane.ZoomFactor = (double)numZoom.Value / 100d;
                        UpdateFromPreview();
                    }
                };
            this.numCols.ValueChanged += (s, e) =>
                {
                    if (!Updating)
                    {
                        PreviewPane.ZoomMode = ZoomModeEnum.WholePage;
                        PreviewPane.Cols = (int)numCols.Value;
                        UpdateFromPreview();
                    }
                };
            this.numRows.ValueChanged += (s, e) =>
                {
                    if (!Updating)
                    {
                        PreviewPane.ZoomMode = ZoomModeEnum.WholePage;
                        PreviewPane.Continuous = false;
                        PreviewPane.Rows = (int)numRows.Value;
                        UpdateFromPreview();
                    }
                };
            this.chkFacing.CheckedChanged += (s, e) =>
                {
                    if (!Updating)
                    {
                        PreviewPane.ZoomMode = ZoomModeEnum.WholePage;
                        PreviewPane.PageLayout = this.chkFacing.Checked ? PageLayoutEnum.Facing : PageLayoutEnum.Normal;
                        UpdateFromPreview();
                    }
                };
            this.chkContinuous.CheckedChanged += (s, e) =>
                {
                    if (!Updating)
                    {
                        PreviewPane.Continuous = this.chkContinuous.Checked;
                        UpdateFromPreview();
                    }
                };
            this.rbt100.CheckedChanged += (s, e) =>
                {
                    if (!Updating && rbt100.Checked)
                    {
                        PreviewPane.ZoomMode = ZoomModeEnum.ActualSize;
                        UpdateFromPreview();
                    }
                };
            this.rbtFitWindow.CheckedChanged += (s, e) =>
                {
                    if (!Updating && rbtFitWindow.Checked)
                    {
                        PreviewPane.ZoomMode = ZoomModeEnum.WholePage;
                        UpdateFromPreview();
                    }
                };
            this.rbtFitWidth.CheckedChanged += (s, e) =>
                {
                    if (!Updating && rbtFitWidth.Checked)
                    {
                        PreviewPane.ZoomMode = ZoomModeEnum.PageWidth;
                        UpdateFromPreview();
                    }
                };
            this.rbtFitTextWidth.CheckedChanged += (s, e) =>
                {
                    if (!Updating && rbtFitTextWidth.Checked)
                    {
                        PreviewPane.ZoomMode = ZoomModeEnum.TextWidth;
                        UpdateFromPreview();
                    }
                };

            this.btnOk.Click += (s, e) =>
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                };
        }

        public C1.Win.C1Preview.C1PreviewPane PreviewPane { get; set; }

        private bool Updating { get; set; }

        protected override void OnShown(EventArgs e)
        {
            UpdateLimits();
            UpdateFromPreview();
            base.OnShown(e);
        }

        private void UpdateLimits()
        {
            if (PreviewPane == null || Updating)
                return;
            try
            {
                Updating = true;
                numZoom.Minimum = (int)Math.Round(PreviewPane.MinZoomFactor * 100);
                numZoom.Maximum = (int)Math.Round(PreviewPane.MaxZoomFactor * 100);
            }
            finally
            {
                Updating = false;
            }
        }

        private void UpdateFromPreview()
        {
            if (PreviewPane == null || Updating)
                return;
            try
            {
                Updating = true;
                numZoom.Value = (int)Math.Round(PreviewPane.ZoomFactor * 100);
                numCols.Value = PreviewPane.Cols;
                numRows.Value = PreviewPane.Rows;
                chkFacing.Checked = PreviewPane.PageLayout == C1.Win.C1Preview.PageLayoutEnum.Facing;
                chkContinuous.Checked = PreviewPane.Continuous;
                rbt100.Checked = PreviewPane.ZoomFactor == 1;
                rbtFitWindow.Checked = PreviewPane.ZoomMode == C1.Win.C1Preview.ZoomModeEnum.WholePage;
                rbtFitWidth.Checked = PreviewPane.ZoomMode == C1.Win.C1Preview.ZoomModeEnum.PageWidth;
                rbtFitTextWidth.Checked = PreviewPane.ZoomMode == C1.Win.C1Preview.ZoomModeEnum.TextWidth;
            }
            finally
            {
                Updating = false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Win.TouchToolKit;
using TouchToolkitExplorer.C1ZoomPages.Help_Forms;

namespace TouchToolkitExplorer.C1ZoomPages
{
    public partial class MiscFeatureDemo : DemoBase
    {
        public MiscFeatureDemo()
        {
            InitializeComponent();
            InitializeDemo();
        }

        private void InitializeDemo()
        {
            this.Title = "Misc Features";
            this.Description = "In this page you can try a few features.";

            NoneFullScreenRadioButton.Checked = true;
            MiddleCenterRadioButton.Checked = true;
            layoutButton.Click += layoutButton_Click;

            TileRadioButton.Checked = true;
            backcolorPreviewPanel.BackColor = SystemColors.Control;
            backgroundButton.Click += backgroundButton_Click;
            TileRadioButton.CheckedChanged += BackgroundImageLayoutRadioButton_CheckedChanged;
            NoneBackgroundImagRadioButton.CheckedChanged += BackgroundImageLayoutRadioButton_CheckedChanged;
            stretchRadioButton.CheckedChanged += BackgroundImageLayoutRadioButton_CheckedChanged;
            zoomRadioButton.CheckedChanged += BackgroundImageLayoutRadioButton_CheckedChanged;
            centerRadioButton.CheckedChanged += BackgroundImageLayoutRadioButton_CheckedChanged;
            bcButton.Click+=bcButton_Click;
            biButton.Click+=biButton_Click;

            keepAspectRationButton.Click += keepAspectRationButton_Click;
        }

        #region Layout

        private void layoutButton_Click(object sender, EventArgs e)
        {
            using (MiscFeatureForm form = new MiscFeatureForm())
            {
                form.Text = "Full Screen Form";
                C1Zoom C1Zoom = new C1Zoom();
                C1Zoom.FullScreenMode = GetFullScreenMode();
                C1Zoom.InnerPanelLayoutMode = GetInnerPanelLayoutMode();
                C1Zoom.Target = form;
                C1Zoom.ControlBars.Add(new C1.Win.TouchToolKit.ControlBar() { Content = typeof(ControlBarUserControl03), Opacity = 1, DockPosition = ContentAlignment.TopRight });
                form.ShowDialog(this);
            }
        }

        private FullScreenMode GetFullScreenMode()
        {
            if (NoneFullScreenRadioButton.Checked)
            {
                return FullScreenMode.None;
            }
            else if (FullScreenRadioButton.Checked)
            {
                return FullScreenMode.FullScreen;
            }
            else
            {
                return FullScreenMode.FullScreenWithTaskBar;
            }
        }

        private InnerPanelLayoutMode GetInnerPanelLayoutMode()
        {
            if (MiddleCenterRadioButton.Checked)
            {
                return InnerPanelLayoutMode.MiddleCenter;
            }
            else
            {
                return InnerPanelLayoutMode.None;
            }
        }

        private void NoneInnerPanelLayout_Click(object sender, EventArgs e)
        {
            if (!LeftLayoutRadioButton.Checked)
            {
                LeftLayoutRadioButton.Checked = true;
            }
        }

        private void MiddleCenterInnerPanelLayout_Click(object sender, EventArgs e)
        {
            if (!MiddleCenterRadioButton.Checked)
            {
                MiddleCenterRadioButton.Checked = true;
            }
        }

        #endregion

        #region Custom Background

        C1Zoom _C1ZoomForBackground = new C1Zoom();

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            using (MiscFeatureForm form = new MiscFeatureForm())
            {
                form.Text = "Custom Background Form";
                _C1ZoomForBackground.Target = form;
                form.ShowDialog(this);
            }
        }

        private void BackgroundImageLayoutRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (TileRadioButton.Checked)
            {
                _C1ZoomForBackground.BackgroundImageLayout = ImageLayout.Tile;
            }
            else if (NoneBackgroundImagRadioButton.Checked)
            {
                _C1ZoomForBackground.BackgroundImageLayout = ImageLayout.None;
            }
            else if (stretchRadioButton.Checked)
            {
                _C1ZoomForBackground.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else if (zoomRadioButton.Checked)
            {
                _C1ZoomForBackground.BackgroundImageLayout = ImageLayout.Zoom;
            }
            else if (centerRadioButton.Checked)
            {
                _C1ZoomForBackground.BackgroundImageLayout = ImageLayout.Center;
            }
            backcolorPreviewPanel.BackgroundImageLayout = _C1ZoomForBackground.BackgroundImageLayout;
        }

        private void bcButton_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (DialogResult.OK == dialog.ShowDialog())
            {
                _C1ZoomForBackground.BackColor = dialog.Color;
                backcolorPreviewPanel.BackColor = dialog.Color;
            }
        }

        private void biButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (DialogResult.OK == dialog.ShowDialog())
            {
                Bitmap bitmap = null;
                try
                {
                    bitmap = new Bitmap(dialog.FileName);
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("This is not a suitable file.");
                    return;
                }
                if (backcolorPreviewPanel.BackgroundImage != null)
                {
                    _C1ZoomForBackground.BackgroundImage = null;
                    backcolorPreviewPanel.BackgroundImage.Dispose();
                    backcolorPreviewPanel.BackgroundImage = null;
                }
                _C1ZoomForBackground.BackgroundImage = bitmap;
                backcolorPreviewPanel.BackgroundImage = bitmap;
            }
        }

        #endregion

        #region KeepAspectRatio

        private void keepAspectRationButton_Click(object sender, EventArgs e)
        {
            using (MiscFeatureForm form = new MiscFeatureForm())
            {
                form.Text = "KeepAspectRatio Form";
                C1Zoom C1Zoom = new C1Zoom();
                C1Zoom.KeepAspectRatio = KeepAspectRatioCheckBox.Checked;
                C1Zoom.Target = form;
                form.ShowDialog(this);
            }
        }

        #endregion
    }
}

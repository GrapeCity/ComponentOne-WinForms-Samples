using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Win.TouchToolKit;

namespace ClickOnceDemo.C1MagnifyPages
{
    public partial class C1MagnifyCommon : DemoBase
    {
        public C1MagnifyCommon()
        {
            InitializeComponent();
            InitializeDemo();
        }

        private void InitializeDemo()
        {
            this.Title = "C1Magnify";
            this.Description = "This page shows C1Magnify.\n  -After long tap, a magnifier will popup above the finger, and shows the info around the finger.";

            moveLeftDownRadioButton.CheckedChanged += MoveMessageRadioButton_CheckedChanged;
            moveNoneRadioButton.CheckedChanged += MoveMessageRadioButton_CheckedChanged;
            moveRadioButton.CheckedChanged += MoveMessageRadioButton_CheckedChanged;

            closeLeftRadioButton.CheckedChanged += CloseMessageRadioButton_CheckedChanged;
            closeNoneRadioButton.CheckedChanged += CloseMessageRadioButton_CheckedChanged;
            closeRightRadioButton.CheckedChanged += CloseMessageRadioButton_CheckedChanged;

            circleRadioButton.CheckedChanged += ShapeRadioButton_CheckedChanged;
            rectangleRadioButton.CheckedChanged += ShapeRadioButton_CheckedChanged;
            roundedRectangleRadioButton.CheckedChanged += ShapeRadioButton_CheckedChanged;

            lightRadioButton.CheckedChanged += borderBackgroundModeRadioButton1_CheckedChanged;
            darkRadioButton.CheckedChanged += borderBackgroundModeRadioButton1_CheckedChanged;
            customRadioButton.CheckedChanged += borderBackgroundModeRadioButton1_CheckedChanged;

            ShowCursorCheckbox.DataBindings.Add("Checked",C1Magnify1,"ShowCursor");
            IsHorizontalRailEnabledCheckBox.DataBindings.Add("Checked", C1Magnify1, "IsHorizontalRailEnabled");
            IsVerticalRailEnalbedCheckBox.DataBindings.Add("Checked", C1Magnify1, "IsVerticalRailEnabled");

            if (C1Magnify1.BorderBackground != null)
            {
                pictureBox1.Image = C1Magnify1.BorderBackground;
            }
            else
            {
                C1Magnify1.BorderBackground = pictureBox1.Image;
            }

            borderWidthTrackBar.ValueChanged+=borderWidthTrackBar_ValueChanged;
            PopupDelayTrackBar.ValueChanged+=PopupDelayTrackBar_ValueChanged;
            sizeTrackBar.ValueChanged+=sizeTrackBar_ValueChanged;
            zoomfactorTrackBar.ValueChanged+=zoomfactorTrackBar_ValueChanged;
        }

        private void CloseMessageRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (closeLeftRadioButton.Checked)
            {
                C1Magnify1.MessageWhenClose = MessageWhenClose.LeftClick;
            }
            else if (closeNoneRadioButton.Checked)
            {
                C1Magnify1.MessageWhenClose = MessageWhenClose.None;
            }
            else if (closeRightRadioButton.Checked)
            {
                C1Magnify1.MessageWhenClose = MessageWhenClose.RightClick;
            }
        }

        private void MoveMessageRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (moveLeftDownRadioButton.Checked)
            {
                C1Magnify1.MessageWhenMove = MessageWhenMove.LeftDown;
            }
            else if (moveNoneRadioButton.Checked)
            {
                C1Magnify1.MessageWhenMove = MessageWhenMove.None;
            }
            else if (moveRadioButton.Checked)
            {
                C1Magnify1.MessageWhenMove = MessageWhenMove.Move;
            }
        }

        private void PopupDelayTrackBar_ValueChanged(object sender, EventArgs e)
        {
            popupDelayLabel.Text = PopupDelayTrackBar.Value.ToString() + "ms";
            C1Magnify1.PopupDelay = PopupDelayTrackBar.Value;
        }

        private void ShapeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (circleRadioButton.Checked)
            {
                C1Magnify1.Shape = MagnifierShape.Circle;
            }
            else if (rectangleRadioButton.Checked)
            {
                C1Magnify1.Shape = MagnifierShape.Rectangle;
            }
            else if (roundedRectangleRadioButton.Checked)
            {
                C1Magnify1.Shape = MagnifierShape.RoundedRectangle;
            }
        }

        private void sizeTrackBar_ValueChanged(object sender, EventArgs e)
        {
            C1Magnify1.Size = new Size(sizeTrackBar.Value*100, sizeTrackBar.Value*100);
            sizeLabel.Text = "(" + (sizeTrackBar.Value * 100).ToString() + "," + (sizeTrackBar.Value * 100).ToString() + ")";
        }

        private void zoomfactorTrackBar_ValueChanged(object sender, EventArgs e)
        {
            C1Magnify1.ZoomFactor = zoomfactorTrackBar.Value;
            zoomFactorLabel.Text = (zoomfactorTrackBar.Value * 100).ToString() + "%";
        }

        private void borderBackgroundModeRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (lightRadioButton.Checked)
            {
                C1Magnify1.BorderBackgroundMode = BorderBackground.Light;
                customBackgroundSetting.Visible = false;
            }
            else if (darkRadioButton.Checked)
            {
                C1Magnify1.BorderBackgroundMode = BorderBackground.Dark;
                customBackgroundSetting.Visible = false;
            }
            else if (customRadioButton.Checked)
            {
                C1Magnify1.BorderBackgroundMode = BorderBackground.Custom;
                customBackgroundSetting.Visible = true;
            }
        }

        private void SelectImageButton_Click(object sender, EventArgs e)
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
                if (C1Magnify1.BorderBackground != null)
                {
                    C1Magnify1.BorderBackground.Dispose();
                    C1Magnify1.BorderBackground = null;
                }
                C1Magnify1.BorderBackground = bitmap;
                pictureBox1.Image = bitmap;
            }
        }

        private void borderWidthTrackBar_ValueChanged(object sender, EventArgs e)
        {
            C1Magnify1.BorderWidth = borderWidthTrackBar.Value;
            borderWidthlabel.Text = C1Magnify1.BorderWidth.ToString();
        }
    }
}

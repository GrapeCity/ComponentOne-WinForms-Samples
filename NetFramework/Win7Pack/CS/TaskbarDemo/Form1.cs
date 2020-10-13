using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Win7Pack;

namespace TaskbarDemo
{
    public partial class Form1 : Form
    {
        private int _pos;
        private int _lastPos;

        public Form1()
        {
            InitializeComponent();
        }

        private void overlayRadioButton_Click(object sender, EventArgs e)
        {
            switch (((RadioButton)sender).Text)
            {
                case "None":
                    taskbarButton.OverlayIcon = null;
                    break;
                case "Error":
                    taskbarButton.OverlayIcon = Properties.Resources.Error;
                    break;
                case "Info":
                    taskbarButton.OverlayIcon = Properties.Resources.Info;
                    break;
                case "Warning":
                    taskbarButton.OverlayIcon = Properties.Resources.Warn;
                    break;
            }
        }

        private void progressCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (progressCheckBox.Checked)
                taskbarButton.ProgressIndicator.Show();
            else
                taskbarButton.ProgressIndicator.Hide();
        }

        private void progressRadioButton_Click(object sender, EventArgs e)
        {
            switch (((RadioButton)sender).Text)
            {
                case "Normal":
                    taskbarButton.ProgressIndicator.State = TaskbarProgressState.Normal;
                    break;
                case "Error":
                    taskbarButton.ProgressIndicator.State = TaskbarProgressState.Error;
                    break;
                case "Paused":
                    taskbarButton.ProgressIndicator.State = TaskbarProgressState.Paused;
                    break;
                case "Marquee":
                    taskbarButton.ProgressIndicator.State = TaskbarProgressState.Indeterminate;
                    break;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            taskbarButton.ProgressIndicator.Value = trackBar1.Value;
            progressBar1.Value = trackBar1.Value;
        }

        private void clipCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            taskbarButton.Thumbnail.ClipControl = clipCheckBox.Checked ? pictureBox1 : null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _lastPos = imLarge.Images.Count - 1;
            pictureBox1.Image = imLarge.Images[0];
            UpdateButtons();
        }

        private void btnFirstImage_Click(object sender, EventArgs e)
        {
            MoveFirst();
        }

        private void btnLastImage_Click(object sender, EventArgs e)
        {
            MoveLast();
        }

        private void btnPrevImage_Click(object sender, EventArgs e)
        {
            MovePrevious();
        }

        private void btnNextImage_Click(object sender, EventArgs e)
        {
            MoveNext();
        }

        private void tm_ThumbButtonClick(object sender, ThumbButtonEventArgs e)
        {
            switch (e.Button.Name)
            {
                case "FirstImage":
                    MoveFirst();
                    break;
                case "PrevImage":
                    MovePrevious();
                    break;
                case "NextImage":
                    MoveNext();
                    break;
                case "LastImage":
                    MoveLast();
                    break;
                case "ToggleView":
                    clipCheckBox.Checked = !clipCheckBox.Checked;
                    break;
            }
        }

        private void UpdateButtons()
        {
            pictureBox1.Image = imLarge.Images[_pos];

            string s = imLarge.Images.Keys[_pos];
            labImageCaption.Text = s;
            taskbarButton.Thumbnail.Tooltip = s;

            bool notFirst = _pos > 0;
            bool notLast = _pos < _lastPos;

            btnFirstImage.Enabled = notFirst;
            btnPrevImage.Enabled = notFirst;
            btnNextImage.Enabled = notLast;
            btnLastImage.Enabled = notLast;

            ThumbButtonCollection buttons = taskbarButton.Thumbnail.Buttons;
            buttons.BeginUpdate();
            buttons["FirstImage"].Enabled = notFirst;
            buttons["PrevImage"].Enabled = notFirst;
            buttons["NextImage"].Enabled = notLast;
            buttons["LastImage"].Enabled = notLast;
            buttons.EndUpdate();
        }

        private void MoveFirst()
        {
            _pos = 0;
            UpdateButtons();
        }

        private void MoveLast()
        {
            _pos = _lastPos;
            UpdateButtons();
        }

        private void MovePrevious()
        {
            if (_pos > 0)
            {
                --_pos;
                UpdateButtons();
            }
        }

        private void MoveNext()
        {
            if (_pos < _lastPos)
            {
                ++_pos;
                UpdateButtons();
            }
        }
    }
}

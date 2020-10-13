using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Win7Pack;

namespace ControlExplorer.Win7Pack
{
    public partial class ThumbnailButtonDemo : Form
    {
        private int _pos;
        private int _lastPos;

        public ThumbnailButtonDemo()
        {
            InitializeComponent();
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

        private void ThumbnailButtonDemo_Load(object sender, EventArgs e)
        {
            _lastPos = imLarge.Images.Count - 1;
            pictureBox1.Image = imLarge.Images[0];
            UpdateButtons();
        }
    }
}

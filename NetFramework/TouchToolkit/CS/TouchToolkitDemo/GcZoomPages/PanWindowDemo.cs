using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClickOnceDemo.C1ZoomPages.Help_Forms;
using C1.Win.TouchToolKit;

namespace ClickOnceDemo.C1ZoomPages
{
    public partial class PanWindowDemo : DemoBase
    {
        private FormStartPosition _formStartPosition;
        private Size _size;
        private Point _location;
        private string _selectedMethodName;

        public PanWindowDemo()
        {
            InitializeComponent();
            InitializeDemo();
        }

        private void InitializeDemo()
        {
            this.Title = "Pan Window";
            this.Description = @"This page is used to show pan window. User can use pan window to see whole form, and scroll the owner form quickly by click/drag mouse or finger.";

            noPRadioButton.Checked = true;
            ManualRadioButton.Checked = true;
            formStartPositionGroupBox.Visible = false;
            sizePanel.Visible = false;
            locationPanel.Visible = false;
            locationErrorLabel.Visible = false;
            sizeErrorLabel.Visible = false;
            _formStartPosition = FormStartPosition.Manual;
            _size = new System.Drawing.Size(200, 200);
            _location = new Point(200, 200);
            _selectedMethodName = noPRadioButton.Text;

            lsRadioButton.CheckedChanged += MethodRadioButton_CheckedChanged;
            ssRadioButton.CheckedChanged += MethodRadioButton_CheckedChanged;
            lRadioButton.CheckedChanged += MethodRadioButton_CheckedChanged;
            sRadioButton.CheckedChanged += MethodRadioButton_CheckedChanged;
            noPRadioButton.CheckedChanged += MethodRadioButton_CheckedChanged;

            ManualRadioButton.CheckedChanged += FormStartPositionRadioButton_CheckedChanged;
            CenterParentRadioButton.CheckedChanged += FormStartPositionRadioButton_CheckedChanged;
            CenterScreenRadioButton.CheckedChanged += FormStartPositionRadioButton_CheckedChanged;
            WindowsDefaultBoundsRadioButton.CheckedChanged += FormStartPositionRadioButton_CheckedChanged;
            WindowsDefaultLocationRadioButton.CheckedChanged += FormStartPositionRadioButton_CheckedChanged;

            wTextBox.Validated += SizeTextBox_Validated;
            hTextBox.Validated += SizeTextBox_Validated;
            xTextBox.Validated += LocationTextBox_Validated;
            xTextBox.Validated += LocationTextBox_Validated;
        }

        private void MethodRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ssRadioButton.Checked)
            {
                formStartPositionGroupBox.Visible = true;
                sizePanel.Visible = true;
                locationPanel.Visible = false;
                _selectedMethodName = ssRadioButton.Text;
            }
            else if (lsRadioButton.Checked)
            {
                formStartPositionGroupBox.Visible = false;
                sizePanel.Visible = true;
                locationPanel.Visible = true;
                _selectedMethodName = lsRadioButton.Text;
            }
            else if (lRadioButton.Checked)
            {
                formStartPositionGroupBox.Visible = false;
                sizePanel.Visible = false;
                locationPanel.Visible = true;
                _selectedMethodName = lRadioButton.Text;
            }
            else if (sRadioButton.Checked)
            {
                formStartPositionGroupBox.Visible = true;
                sizePanel.Visible = false;
                locationPanel.Visible = false;
                _selectedMethodName = sRadioButton.Text;
            }
            else if (noPRadioButton.Checked)
            {
                formStartPositionGroupBox.Visible = false;
                sizePanel.Visible = false;
                locationPanel.Visible = false;
                _selectedMethodName = noPRadioButton.Text;
            }
        }

        private void FormStartPositionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ManualRadioButton.Checked)
            {
                _formStartPosition = FormStartPosition.Manual;
            }
            else if (CenterParentRadioButton.Checked)
            {
                _formStartPosition = FormStartPosition.CenterParent;
            }
            else if (CenterScreenRadioButton.Checked)
            {
                _formStartPosition = FormStartPosition.CenterScreen;
            }
            else if (WindowsDefaultBoundsRadioButton.Checked)
            {
                _formStartPosition = FormStartPosition.WindowsDefaultBounds;
            }
            else if (WindowsDefaultLocationRadioButton.Checked)
            {
                _formStartPosition = FormStartPosition.WindowsDefaultLocation;
            }
        }

        private void LocationTextBox_Validated(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(xTextBox.Text);
                int y = Convert.ToInt32(yTextBox.Text);
                _location = new Point(x, y);
                locationErrorLabel.Visible = false;
            }
            catch (Exception)
            {
                locationErrorLabel.Visible = true;
            }
        }

        private void SizeTextBox_Validated(object sender, EventArgs e)
        {
            try
            {
                int w = Convert.ToInt32(wTextBox.Text);
                int h = Convert.ToInt32(hTextBox.Text);
                _size = new Size(w, h);
                sizeErrorLabel.Visible = false;
            }
            catch (Exception)
            {
                sizeErrorLabel.Visible = true;
            }
        }

        private void formButton_Click(object sender, EventArgs e)
        {
            if (!locationErrorLabel.Visible && !sizeErrorLabel.Visible)
            {
                using (PanWindowForm form = new PanWindowForm(_selectedMethodName, _size, _location, _formStartPosition))
                {
                    form.StartPosition = FormStartPosition.CenterParent;
                    form.ShowDialog(this);
                    // The _C1Zoom will auto detach when the Form dispose.
                    //_C1Zoom.SetEnabled(form, false);
                }
            }
        }
    }
}

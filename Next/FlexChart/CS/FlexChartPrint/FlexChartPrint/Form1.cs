using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FlexChartPrint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // initially Single Page Printing
            btnSinglePage_Click(btnSinglePage, new EventArgs());
        }

        private void btnSinglePage_Click(object sender, EventArgs e)
        {
            if (baseSample1.Title != "Single Page Printing")
            {
                (sender as SampleButton).Selected = true;
                baseSample1.PanelControl = new Samples.SingleChartPrint();
            }
        }

        private void btnMultiPage_Click(object sender, EventArgs e)
        {
            if (baseSample1.Title != "Multiple Page Printing")
            {
                (sender as SampleButton).Selected = true;
                baseSample1.PanelControl = new Samples.MultiChartPrint();
            }
        }
    }

    public class SampleButton : Button
    {
        static SampleButton selectedButton = null;
        Color backColorSelected = Color.FromArgb(0xff,0xe6,0xe6,0xe6);
        Color backColorOriginal = Color.FromArgb(0xff,0xf9,0xf9,0xf9);
        Color backColorHighlight = Color.FromArgb(0xff,0x13,0x98,0xe8);
        SolidBrush highlightBrush = null;

        public SampleButton()
        {
            highlightBrush = new SolidBrush(backColorHighlight);
            ForeColor = Color.FromArgb(0xff,0x33,0x33,0x33);
        }

        public bool Selected
        {
            get { return selectedButton == this; }
            set
            {
                if (selectedButton != this)
                {
                    if (selectedButton != null)
                    {
                        selectedButton.Invalidate();
                        selectedButton.BackColor = backColorOriginal;
                        selectedButton.FlatAppearance.MouseOverBackColor = backColorHighlight;
                    }
                    selectedButton = this;
                    BackColor = backColorSelected;
                    FlatAppearance.MouseOverBackColor = backColorSelected;
                }
            }
        }

        protected override void OnClick(EventArgs e)
        {
            if (!Selected)
            {
                Selected = true;
                base.OnClick(e);
            }
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            if (!Selected) 
                BackColor = backColorHighlight;
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            OnMouseLeave(e);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            if (!Selected) BackColor = backColorHighlight;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            BackColor = Selected ? backColorSelected : backColorOriginal;
        }

        protected override void OnBackColorChanged(EventArgs e)
        {
            base.OnBackColorChanged(e);
            FlatAppearance.BorderColor = BackColor;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            if (Selected)
            {
                Rectangle rect = new Rectangle(0, 1, 7, Height-1);
                pevent.Graphics.FillRectangle(highlightBrush, rect);
            }
        }
    }
}

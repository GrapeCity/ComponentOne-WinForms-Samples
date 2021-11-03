using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BaseExplorer.Model;
using BaseExplorer.Utilities;
using System.Reflection;
using BaseExplorer.Core;
using System.Threading;

namespace BaseExplorer.Components
{
    public partial class SampleHost : UserControl
    {
        SampleManager samplesManager;

        public event EventHandler<NavigateEventArgs> Navigate;
        string previousArrow = Char.ConvertFromUtf32(0xEC52);
        string nextArrow = Char.ConvertFromUtf32(0xEBE7);

        public SampleHost()
        {
            InitializeComponent();
            this.btnNextArrow.Text = nextArrow;
            this.btnPrevArrow.Text = previousArrow;
            descPanel.Visible = false;
            btnInfo.MouseEnter += DescPanel_MouseEnter;
            descPanel.MouseLeave += DescPanel_MouseLeave;

            btnNext.Click += OnNextClick;
            btnNextArrow.Click += OnNextClick;
            btnPrevious.Click += OnPreviousClick;
            btnPrevArrow.Click += OnPreviousClick;
            btnNext.MouseEnter += OnMouseEnter;
            btnNextArrow.MouseEnter += OnMouseEnter;
            btnPrevious.MouseEnter += OnMouseEnter;
            btnPrevArrow.MouseEnter += OnMouseEnter;

            btnNext.MouseLeave += OnMouseLeave;
            btnNextArrow.MouseLeave += OnMouseLeave;
            btnPrevious.MouseLeave += OnMouseLeave;
            btnPrevArrow.MouseLeave += OnMouseLeave;

            btnNext.Paint += (s, e) =>
            {
                e.Graphics.DrawLine(Pens.Gray, 0, 0, 0, btnNext.Bottom);
            };
        }

        /// <summary>
        /// Load the given sample into view
        /// </summary>
        /// <param name="sample"></param>
        public void LoadSample(SampleItem sample)
        {
            try
            {
                if(samplesManager == null)
                    samplesManager = BaseExplorer.Core.Explorer.Instance.Manager;
                samplesManager.Current = sample;
                var fullName = string.Format("{0},{1}", sample.TypeName, Assembly.GetEntryAssembly().FullName);
                Type t = Type.GetType(fullName);
                var view = Activator.CreateInstance(t) as BaseSample;
                if (view.ShowDescriptionPanel)
                {
                    panelInfo.Visible = true;
                    descPanel.Content = sample.Description.Trim().MakeRtf();
                }
                else
                    panelInfo.Visible = false;
                view.Dock = DockStyle.Fill;
                //Remove and dispose the existing loaded sample from the view to avoid memory leaks.
                pnlViewer.Controls.Clear(true);
                pnlViewer.Controls.Add(view);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Update Next/Previous samples
                btnNext.Visible = btnNextArrow.Visible = samplesManager.Next != null;
                btnPrevious.Visible = btnPrevArrow.Visible = samplesManager.Previous != null;
                if (samplesManager.Next != null)
                    btnNext.Text =  samplesManager.Next.Title;
                if (samplesManager.Previous != null)
                    btnPrevious.Text = samplesManager.Previous.Title;
            }
        }

        private void DescPanel_MouseLeave(object sender, EventArgs e)
        {
            Thread.Sleep(500);
            descPanel.Visible = false;
            descPanel.SendToBack();
        }

        private void DescPanel_MouseEnter(object sender, EventArgs e)
        {
            Thread.Sleep(500);
            descPanel.Visible = true;
            descPanel.BringToFront();
        }

        private void OnNextClick(object sender, EventArgs e)
        {
            OnSampleLoaded(Direction.Next);
        }

        private void OnPreviousClick(object sender, EventArgs e)
        {
            OnSampleLoaded(Direction.Previous);
        }

        private void OnSampleLoaded(Direction direction)
        {
            if (Navigate != null)
                Navigate(this, new NavigateEventArgs(direction));
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn.Tag.ToString() == "Next")
                btnNext.BackColor = btnNextArrow.BackColor = Color.Gainsboro;
            else
                btnPrevious.BackColor = btnPrevArrow.BackColor = Color.Gainsboro;

        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn.Tag.ToString() == "Next")
                btnNext.BackColor = btnNextArrow.BackColor = Color.Transparent;
            else
                btnPrevious.BackColor = btnPrevArrow.BackColor = Color.Transparent;
        }

        private void pnlViewer_Paint(object sender, PaintEventArgs e)
        {
            var rect = new Rectangle(0,0,rootPanel.Width,pnlViewer.Height + panelInfo.Height -1);
            e.Graphics.DrawRectangle(Pens.LightGray, rect);
        }

        private void SampleHost_SizeChanged(object sender, EventArgs e)
        {
            descPanel.Width = Width;
        }

        private void OnPaintPanelInfo(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(Pens.LightGray, 0, panelInfo.Height / 2, panelInfo.Width, panelInfo.Height / 2);
        }
    }

    public class NavigateEventArgs : EventArgs
    {
        public Direction NavigationDirection { get; set; }

        public NavigateEventArgs(Direction dir)
        {
            this.NavigationDirection = dir;
        }
    }


    public enum Direction
    {
        First,
        Next,
        Last,
        Previous
    }
}

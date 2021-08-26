using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Gauge;

namespace GaugeDemo
{
    public partial class BaseGaugePage : UserControl
    {
        private ToolStripMenuItem _resetMenuItem;
        private ToolStripMenuItem _categorizedMenuItem;
        private ToolStripMenuItem _alphabeticMenuItem;
        private ToolStripMenuItem _descriptionMenuItem;
        private Random _random;

        public BaseGaugePage()
        {
            InitializeComponent();
            gaugeGrid.ContextMenuStrip = CreateMenuStrip();
            _random = new Random();
        }

        //----------------------------------------------------------------------
        #region ** private

        private ContextMenuStrip CreateMenuStrip()
        {
            ContextMenuStrip result = new ContextMenuStrip();
            ToolStripSeparator separator1 = new ToolStripSeparator();
            ToolStripSeparator separator2 = new ToolStripSeparator();
            _resetMenuItem = new ToolStripMenuItem();
            _descriptionMenuItem = new ToolStripMenuItem();
            _categorizedMenuItem = new ToolStripMenuItem();
            _alphabeticMenuItem = new ToolStripMenuItem();
            result.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                _resetMenuItem, separator1, _categorizedMenuItem, _alphabeticMenuItem,
                separator2, _descriptionMenuItem });
            _resetMenuItem.Text = "&Reset";
            _categorizedMenuItem.Text = "&Categorized";
            _alphabeticMenuItem.Text = "&Alphabetic";
            _descriptionMenuItem.Text = "&Description";
            result.Opening += new CancelEventHandler(contextMenu_Opening);
            _resetMenuItem.Click += new System.EventHandler(resetMenuItem_Click);
            _categorizedMenuItem.Click += new System.EventHandler(categorizedMenuItem_Click);
            _alphabeticMenuItem.Click += new System.EventHandler(alphabeticMenuItem_Click);
            _descriptionMenuItem.Click += new System.EventHandler(descriptionMenuItem_Click);
            return result;
        }

        private void contextMenu_Opening(object sender, CancelEventArgs e)
        {
            bool resetEnabled = false;
            GridItem item = gaugeGrid.SelectedGridItem;
            if (item != null && item.GridItemType == GridItemType.Property)
            {
                GridItem parent = item.Parent;
                PropertyDescriptor pd = item.PropertyDescriptor;
                if (parent.GridItemType == GridItemType.Root || parent.GridItemType == GridItemType.Category)
                    resetEnabled = pd.CanResetValue(gaugeGrid.SelectedObject);
                else if (parent.GridItemType == GridItemType.Property)
                    resetEnabled = pd.CanResetValue(parent.Value);
            }
            _resetMenuItem.Enabled = resetEnabled;
            _descriptionMenuItem.Checked = gaugeGrid.HelpVisible;
            _categorizedMenuItem.Checked = gaugeGrid.PropertySort == PropertySort.CategorizedAlphabetical;
            _alphabeticMenuItem.Checked = gaugeGrid.PropertySort == PropertySort.Alphabetical;
        }

        private void resetMenuItem_Click(object sender, System.EventArgs e)
        {
            GridItem item = gaugeGrid.SelectedGridItem;
            if (item != null && item.GridItemType == GridItemType.Property)
            {
                GridItem parent = item.Parent;
                PropertyDescriptor pd = item.PropertyDescriptor;
                object obj = null;
                object rootObj = gaugeGrid.SelectedObject;
                PropertyDescriptor rootPd = null;
                if (parent.GridItemType == GridItemType.Root || parent.GridItemType == GridItemType.Category)
                    obj = rootObj;
                else if (parent.GridItemType == GridItemType.Property)
                {
                    rootPd = parent.PropertyDescriptor;
                    obj = parent.Value;
                }
                if (obj != null)
                {
                    pd.ResetValue(obj);
                }
                gaugeGrid.Refresh();
            }
        }

        private void descriptionMenuItem_Click(object sender, System.EventArgs e)
        {
            gaugeGrid.HelpVisible = !gaugeGrid.HelpVisible;
        }

        private void categorizedMenuItem_Click(object sender, System.EventArgs e)
        {
            gaugeGrid.PropertySort = PropertySort.CategorizedAlphabetical;
        }

        private void alphabeticMenuItem_Click(object sender, System.EventArgs e)
        {
            gaugeGrid.PropertySort = PropertySort.Alphabetical;
        }

        private void gaugeGrid_SelectedObjectsChanged(object sender, EventArgs e)
        {
            string s = string.Empty;
            object obj = gaugeGrid.SelectedObject;
            if (obj != null)
            {
                string name = obj.GetType().ToString();
                int n = name.LastIndexOf('.');
                if (n != -1)
                {
                    s = name.Substring(n + 1) + " properties:";
                }
            }
            objectLabel.Text = s;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!IsDisposed && Visible)
            {
                OnTimer();
            }
        }

        #endregion

        internal void UpdateValue(C1GaugeBase gauge, double step)
        {
            double v = gauge.Value;
            double min, max;
            if (gauge.IsLogarithmic)
            {
                double logLogBase = Math.Log(gauge.LogarithmicBase);
                min = Math.Max(Math.Log(gauge.Minimum) / logLogBase, Math.Log(v) / logLogBase - step);
                max = Math.Min(Math.Log(gauge.Maximum) / logLogBase, Math.Log(v) / logLogBase + step);
                gauge.Value = Math.Exp((_random.NextDouble() * (max - min) + min) * logLogBase);
            }
            else
            {
                min = Math.Max(gauge.Minimum, v - step);
                max = Math.Min(gauge.Maximum, v + step);
                gauge.Value = _random.NextDouble() * (max - min) + min;
            }
        }

        internal void UpdateValue(C1GaugeBase gauge, int pointerIndex, double step)
        {
            double v = gauge.MorePointers[pointerIndex].Value;
            double min = Math.Max(gauge.Minimum, v - step);
            double max = Math.Min(gauge.Maximum, v + step);
            gauge.MorePointers[pointerIndex].Value = _random.NextDouble() * (max - min) + min;
        }

        internal void UpdateValue(C1GaugeBase gauge, string pointerName, double step, double min, double max)
        {
            C1GaugePointer pointer = gauge.MorePointers[pointerName];
            min = Math.Max(min, pointer.Value - step);
            max = Math.Min(max, pointer.Value + step);
            pointer.Value = _random.NextDouble() * (max - min) + min;
        }

        protected virtual void OnTimer()
        {
        }
    }
}

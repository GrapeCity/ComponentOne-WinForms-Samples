using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using C1.Win.Gauge;

namespace GaugeDemo
{
    public partial class PageRuler : BaseGaugePage
    {
        private C1GaugePointer _leftPointer, _hangingPointer, _firstLinePointer, _rIndentPointer;
        private Cursor _oldCursor;

        public PageRuler()
        {
            InitializeComponent();

            _leftPointer = rulerGauge.MorePointers["LeftIndent"];
            _hangingPointer = rulerGauge.MorePointers["HangingIndent"];
            _firstLinePointer = rulerGauge.MorePointers["FirstLineIndent"];
            _rIndentPointer = rulerGauge.MorePointers["RightIndent"];

            richTextBox1.SelectAll();
        }

        private void c1Gauge1_Resize(object sender, EventArgs e)
        {
            rulerGauge.Maximum = c1Gauge1.Width - (rulerGauge.Viewport.MarginX * 2) + rulerGauge.Minimum;
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            int n = richTextBox1.SelectionIndent;
            _firstLinePointer.Value = n;
            n += richTextBox1.SelectionHangingIndent;
            _leftPointer.Value = Math.Max(n, 0);
            _rIndentPointer.Value = richTextBox1.RightMargin - richTextBox1.SelectionRightIndent;
        }

        private void rulerGauge_PointerDragMove(object sender, PointerDragEventArgs e)
        {
            e.Pointer.UpdateValue(Math.Max(e.NewValue, 0), 10);
            if (e.Pointer.Name == "LeftIndent")
            {
                _firstLinePointer.Value = Math.Max(e.Pointer.Value - richTextBox1.SelectionHangingIndent, 0);
            }
            else if (e.Pointer.Name == "RightIndent")
            {
                if (Convert.ToInt32(e.Pointer.Value) > richTextBox1.RightMargin)
                {
                    e.Pointer.Value = richTextBox1.RightMargin;
                }
            }
        }

        private void rulerGauge_PointerValueChanged(object sender, PointerValueChangedEventArgs e)
        {
            switch (e.Pointer.Name)
            {
                case "LeftIndent":
                    _hangingPointer.Value = e.Pointer.Value;
                    break;
                case "HangingIndent":
                    _leftPointer.Value = e.Pointer.Value;
                    break;
                case "RightMargin":
                    _rIndentPointer.Value = e.Pointer.Value - richTextBox1.SelectionRightIndent;
                    break;
            }
        }

        private void rulerGauge_PointerDragEnd(object sender, PointerDragEventArgs e)
        {
            int m, n = Convert.ToInt32(e.Pointer.Value);
            switch (e.Pointer.Name)
            {
                case "LeftIndent":
                    m = richTextBox1.SelectionHangingIndent;
                    n -= m;
                    if (n >= 0)
                    {
                        richTextBox1.SelectionIndent = n;
                        richTextBox1.SelectionHangingIndent = m;
                    }
                    else
                    {
                        richTextBox1.SelectionIndent = 0;
                        richTextBox1.SelectionHangingIndent += n;
                    }
                    _firstLinePointer.Value = richTextBox1.SelectionIndent;
                    break;
                case "FirstLineIndent":
                    m = richTextBox1.SelectionHangingIndent + richTextBox1.SelectionIndent - n;
                    richTextBox1.SelectionIndent = n;
                    richTextBox1.SelectionHangingIndent = m;
                    break;
                case "HangingIndent":
                    richTextBox1.SelectionHangingIndent = n - richTextBox1.SelectionIndent;
                    break;
                case "RightIndent":
                    m = Math.Max(richTextBox1.RightMargin - n, 0);
                    richTextBox1.SelectionRightIndent = m;
                    _rIndentPointer.Value = richTextBox1.RightMargin - m;
                    break;
                case "RightMargin":
                    m = richTextBox1.SelectionRightIndent;
                    richTextBox1.RightMargin = n;
                    richTextBox1.SelectionRightIndent = m;
                    break;
            }
        }

        private void rulerGauge_ItemStateChanged(object sender, ItemEventArgs e)
        {
            C1GaugePointer p = e.Item as C1GaugePointer;
            if (p != null)
            {
                if (p.Name == "RightMargin")
                {
                    if (e.ItemHot || e.ItemPressed)
                    {
                        if (_oldCursor == null)
                        {
                            _oldCursor = c1Gauge1.Cursor;
                            c1Gauge1.Cursor = Cursors.SizeWE;
                        }
                    }
                    else if (_oldCursor != null)
                    {
                        c1Gauge1.Cursor = _oldCursor;
                        _oldCursor = null;
                    }
                }
                else
                {
                    c1Gauge1.BeginUpdate();
                    if (e.ItemHot || e.ItemPressed)
                    {
                        p.Border.CommonBorderName = "Hot";
                        p.Filling.CommonFillingName = "Hot";
                    }
                    else
                    {
                        p.Border.CommonBorderName = "Normal";
                        p.Filling.CommonFillingName = "Normal";
                    }
                    c1Gauge1.EndUpdate();
                }
            }
        }

        private void rulerGauge_ItemMouseEnter(object sender, ItemEventArgs e)
        {
            C1GaugePointer p = e.Item as C1GaugePointer;
            if (p != null)
            {
                switch (p.Name)
                {
                    case "LeftIndent":
                        toolTip1.SetToolTip(c1Gauge1, "Left Indent");
                        break;
                    case "FirstLineIndent":
                        toolTip1.SetToolTip(c1Gauge1, "First Line Indent");
                        break;
                    case "HangingIndent":
                        toolTip1.SetToolTip(c1Gauge1, "Hanging Indent");
                        break;
                    case "RightIndent":
                        toolTip1.SetToolTip(c1Gauge1, "Right Indent");
                        break;
                    case "RightMargin":
                        toolTip1.SetToolTip(c1Gauge1, "Right Margin");
                        break;
                }
            }
        }

        private void rulerGauge_ItemMouseLeave(object sender, ItemEventArgs e)
        {
            if (e.Item is C1GaugePointer)
            {
                toolTip1.SetToolTip(c1Gauge1, "");
            }
        }
    }
}

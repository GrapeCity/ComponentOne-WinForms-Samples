using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Gauge;

namespace GaugeDemo
{
    public partial class PageKnob2 : BaseGaugePage
    {
        private int _lastV1, _lastV2, _v;

        public PageKnob2()
        {
            InitializeComponent();
        }

        private void DoStep(int stepCount)
        {
            _v += stepCount;
            C1GaugeCaption vLabel = (C1GaugeCaption)c1Gauge1.CoverShapes[0];
            vLabel.Text = _v.ToString();
        }

        private void c1RadialGauge1_PointerDragMove(object sender, PointerDragEventArgs e)
        {
            SetNewValue1(e.NewValue);
        }

        private void SetNewValue1(double newValue)
        {
            double min = c1RadialGauge1.Minimum;
            double max = c1RadialGauge1.Maximum;
            double alpha = (newValue - min) / (max - min);
            if (alpha < 0.33)
            {
                c1RadialGauge1.Minimum = min - 18;
                c1RadialGauge1.Maximum = max - 18;
            }
            else if (alpha > 0.66)
            {
                c1RadialGauge1.Maximum = max + 18;
                c1RadialGauge1.Minimum = min + 18;
            }
            c1RadialGauge1.Pointer.UpdateValue(newValue, 1.0);

            int v = (int)c1RadialGauge1.Pointer.Value;
            if (v != _lastV1)
            {
                DoStep(v - _lastV1);
                _lastV1 = v;
            }
        }

        private void c1RadialGauge2_PointerDragMove(object sender, PointerDragEventArgs e)
        {
            SetNewValue2(e.NewValue);
        }
        private void SetNewValue2(double newValue)
        {
            double min = c1RadialGauge2.Minimum;
            double max = c1RadialGauge2.Maximum;
            double alpha = (newValue - min) / (max - min);
            if (alpha < 0.33)
            {
                c1RadialGauge2.Minimum = min - 36;
                c1RadialGauge2.Maximum = max - 36;
            }
            else if (alpha > 0.66)
            {
                c1RadialGauge2.Maximum = max + 36;
                c1RadialGauge2.Minimum = min + 36;
            }
            c1RadialGauge2.Pointer.UpdateValue(newValue, 1.0);

            int v = (int)c1RadialGauge2.Pointer.Value;
            if (v != _lastV2)
            {
                DoStep((v - _lastV2) * 10);
                _lastV2 = v;
            }
        }

        private void c1Gauge1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert)
                SetNewValue2(c1RadialGauge2.Pointer.Value + 1.0);
            else if (e.KeyCode == Keys.Delete)
                SetNewValue2(c1RadialGauge2.Pointer.Value - 1.0);
            else if (e.KeyCode == Keys.PageUp)
                SetNewValue1(c1RadialGauge1.Pointer.Value + 1.0);
            else if (e.KeyCode == Keys.PageDown)
                SetNewValue1(c1RadialGauge1.Pointer.Value - 1.0);
        }
    }
}

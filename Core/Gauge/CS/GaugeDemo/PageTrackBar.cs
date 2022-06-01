using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.Gauge;

namespace GaugeDemo
{
    public partial class PageTrackBar : BaseGaugePage
    {
       private long _pressedTick;
       private int _pressedButton;

        public PageTrackBar()
        {
            InitializeComponent();
        }

        private void c1LinearGauge1_PointerDragMove(object sender, PointerDragEventArgs e)
        {
            e.Pointer.UpdateValue(e.NewValue, 1.0);
        }

        protected override void OnTimer()
        {
            if (_pressedButton > 0)
            {
                long newTick = DateTime.UtcNow.Ticks;
                if (newTick - _pressedTick > 3000000)
                {
                    c1LinearGauge1.Pointer.IncValue(_pressedButton == 1 ? -1 : 1, 5.0);
                    _pressedTick += 2000000;
                }
            }
        }

        private void c1LinearGauge1_ItemMouseUp(object sender, ItemMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _pressedButton = 0;
            }
        }

        private void c1LinearGauge1_ItemMouseDown(object sender, ItemMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                C1GaugePointer pointer = c1LinearGauge1.Pointer;
                if (e.Item is C1GaugeRange)
                {
                    pointer.Value = pointer.GetValueAt(e.X, e.Y);
                }
                else if (e.Item is C1GaugeSingleMark)
                {
                    _pressedTick = DateTime.UtcNow.Ticks + 3000000;
                    switch (((C1GaugeSingleMark)e.Item).Name)
                    {
                        case "minusButton":
                            if (pointer.Value > 0.0)
                                pointer.IncValue(-1, 5.0);
                            else
                                pointer.Value = double.NaN;
                            _pressedButton = 1;
                            break;
                        case "plusButton":
                            if (!double.IsNaN(pointer.Value))
                                pointer.IncValue(1, 5.0);
                            else
                                pointer.Value = 0.0;
                            _pressedButton = 2;
                            break;
                        case "offMark":
                            pointer.Value = double.NaN;
                            break;
                    }
                }
            }
        }

        private void c1LinearGauge1_ItemStateChanged(object sender, ItemEventArgs e)
        {
            if (e.Item is C1GaugePointer)
            {
                C1GaugePointer po = e.Item as C1GaugePointer;
                c1Gauge1.BeginUpdate();
                if (e.ItemHot || e.ItemPressed)
                    po.Filling.CommonFillingName = "hotPointer";
                else
                    po.Filling.CommonFillingName = "normalPointer";
                c1Gauge1.EndUpdate(200);
            }
            else if (e.Item is C1GaugeSingleMark)
            {
                C1GaugeSingleMark sm = e.Item as C1GaugeSingleMark;
                if (sm.Name == "minusButton" || sm.Name == "plusButton")
                {
                    c1Gauge1.BeginUpdate();
                    if (e.ItemPressed)
                        sm.Filling.CommonFillingName = "pressedButton";
                    else if (e.ItemHot)
                        sm.Filling.CommonFillingName = "hotButton";
                    else
                        sm.Filling.CommonFillingName = "normalButton";
                    if (e.ItemPressed)
                        sm.Gradient.CommonGradientName = "pressed";
                    else
                        sm.Gradient.CommonGradientName = "normal";
                    c1Gauge1.EndUpdate(150);
                }
            }
        }
    }
}

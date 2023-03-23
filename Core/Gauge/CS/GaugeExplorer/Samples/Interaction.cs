using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Win.Gauge;

namespace SampleExplorer
{
    public partial class Interaction : UserControl
    {
        public Interaction()
        {
            InitializeComponent();
        }

        #region "Knob" RadialGauge
        int snapInterval = 10;
        private void c1RadialGauge1_PointerDragMove(object sender, C1.Win.Gauge.PointerDragEventArgs e)
        {
            e.Pointer.UpdateValue(e.NewValue, snapInterval);
        }
        public int SnapInterval
        {
            get { return snapInterval; }
            set
            {
                snapInterval = value;
            }
        }
        #endregion

        #region LinearGauge
        private void c1LinearGauge1_PointerDragMove(object sender, C1.Win.Gauge.PointerDragEventArgs e)
        {
            e.Pointer.UpdateValue(e.NewValue, 1.0);
        }

        #endregion

        private void c1LinearGauge1_ItemStateChanged(object sender, C1.Win.Gauge.ItemEventArgs e)
        {
            if (e.Item is C1GaugePointer)
            {
                C1GaugePointer po = e.Item as C1GaugePointer;
                c1Gauge1.BeginUpdate();
                if (e.ItemHot || e.ItemPressed)
                {
                    po.Filling.CommonFillingName = "hotPointer";
                    po.Border.CommonBorderName = "hotButton";
                }
                else
                {
                    po.Filling.CommonFillingName = "normalPointer";
                    po.Border.CommonBorderName = "normalButton";
                }
                c1Gauge1.EndUpdate(200);
            }
            else if (e.Item is C1GaugeSingleMark)
            {
                C1GaugeSingleMark sm = e.Item as C1GaugeSingleMark;
                C1GaugeSingleLabel sl = null;
                if (sm.Name == "minusButton")
                    sl = (C1GaugeSingleLabel)e.Gauge.Decorators["minusLabel"];
                else if (sm.Name == "plusButton")
                    sl = (C1GaugeSingleLabel)e.Gauge.Decorators["plusLabel"];
                else
                    return;
                c1Gauge1.BeginUpdate();

                sl.Color = Color.Black;
                if (e.ItemPressed)
                {
                    sm.Filling.CommonFillingName = "pressedButton";
                    sm.Border.CommonBorderName = "pressedButton";
                }
                else if (e.ItemHot)
                {
                    sm.Filling.CommonFillingName = "hotButton";
                    sm.Border.CommonBorderName = "hotButton";
                }
                else
                {
                    sm.Filling.CommonFillingName = "normalButton";
                    sm.Border.CommonBorderName = "normalButton";
                    sl.Color = Color.FromArgb(255, 68, 68, 68);
                }
                c1Gauge1.EndUpdate(200);
            }
        }

        private void c1LinearGauge1_ItemMouseDown(object sender, C1.Win.Gauge.ItemMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                C1GaugePointer pointer = c1LinearGauge1.Pointer;
                if (e.Item is C1GaugeRange)
                {
                    pointer.Value = pointer.GetValueAt(e.X, e.Y, false);
                }
                else if (e.Item is C1GaugeSingleMark)
                {
                    switch (((C1GaugeSingleMark)e.Item).Name)
                    {
                        case "minusButton":
                            pointer.IncValue(-1, 5.0);
                            break;

                        case "plusButton":
                            pointer.IncValue(1, 5.0);
                            break;
                    }
                }
            }
        }
    }
}

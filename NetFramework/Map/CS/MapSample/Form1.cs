using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using C1.FlexMap;
using C1.Win.Interop;
using C1.Win.Map;
using MapSample.Layers;
using VectorLayer = C1.Win.Map.VectorLayer;
using VectorPlacemark = C1.Win.Map.VectorPlacemark;
using VectorPolyline = C1.Win.Map.VectorPolyline;

namespace MapSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            SetTooTip();
        }

        private void SetTooTip()
        {
            foreach (TabPage tabpage in tcMaps.TabPages)
            {
                if (tabpage.Controls.Count == 0) continue;
                var mapControl = tabpage.Controls[0] as MapUserControl;
                if (mapControl != null)
                {
                    mapControl.ToolTip = toolTip1;
                }
            }
        }
    }
}

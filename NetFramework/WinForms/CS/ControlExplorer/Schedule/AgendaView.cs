using C1.C1Schedule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ControlExplorer.Schedule
{
    public partial class AgendaView : ControlExplorer.C1DemoForm
    {
        public AgendaView()
        {
            InitializeComponent();
            this.c1Schedule1.DataStorage.Import(AppDomain.CurrentDomain.BaseDirectory + "Schedule\\C1Schedule.xml", FileFormatEnum.XML);
            this.c1AgendaView1.Rows.DefaultSize = -1;
            AddProperty("ShowEmptyDays", c1AgendaView1);
            AddProperty("ViewType", c1AgendaView1);
        }
    }
}

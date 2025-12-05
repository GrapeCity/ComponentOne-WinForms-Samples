using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DashboardModel;
using C1.Win.Gauge;

namespace DashboardWinForms
{
    public partial class BulletGraphs : UserControl
    {

        UnitConverter unitConv = new UnitConverter();
        BarColorConverter colorConv = new BarColorConverter();
        BadValueConverter badConv = new BadValueConverter();
        GoodValueConverter goodConv = new GoodValueConverter();

        public BulletGraphs()
        {
            InitializeComponent();
            Layout += (s, ev) => MakeLayout();
        }

        public List<SaleGoalItem> Source
        {
            set
            {
                if (value == null || value.Count == 0)
                {
                    Controls.Clear();
                    return;
                }
                SuspendLayout();
                for (int i = Controls.Count; i < value.Count; i++)
                    Controls.Add(new C1BulletGraph());
                C1BulletGraph g = null;
                for (int i = 0; i < Controls.Count; i++)
                {
                    var item = value[i];
                    g = (C1BulletGraph)Controls[i];
                    g.GraphScale.ShowLabels = false;
                    g.Caption.Text = item.Name;
                    g.Caption.Alignment = StringAlignment.Center;
                    g.Caption.Position = BulletGraphCaptionPosition.Left;
                    g.Value = (double)unitConv.Convert(item.Sales, null, null, null);
                    g.Target = (double)unitConv.Convert(item.Goal, null, null, null);
                    g.Bad.From = 0;
                    g.Bad.To = (double)badConv.Convert(item.Goal, null, null, null);
                    g.Good.From = 0;
                    g.Good.To = (double)goodConv.Convert(item.Goal, null, null, null);
                    g.Text = item.Name;
                    g.Styles.Ranges.Value.Color = (Color)colorConv.Convert(item.CompletePrecent, null, null, null);

                }
                g.GraphScale.ShowLabels = true;
                ResumeLayout();
                MakeLayout();
            }
        }

        private void MakeLayout()
        {
            if (Controls.Count == 0)
                return;
            int mul = (Height - 20) / Controls.Count;
            for (int i = 0; i < Controls.Count; i++)
            {
                var g = (C1BulletGraph)Controls[i];
                g.Top = i * mul;
                g.Left = 0;
                g.Height = mul + 10;
                g.Width = Width - g.Left;
            }
        }

    }
}

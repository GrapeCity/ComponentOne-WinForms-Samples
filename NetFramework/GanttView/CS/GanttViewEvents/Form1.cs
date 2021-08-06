using C1.Win.C1GanttView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GanttViewEvents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            c1GanttView1.Timescale.MiddleTier.Format = "";
            c1GanttView1.Project.StartDate = this.c1GanttView1.Tasks[1].Start.Value;
            c1GanttView1.DragNotificationControl = new DragNotificationCtrl(c1GanttView1);
            c1GanttView1.PaintDay += Gv_PaintDay;
            c1GanttView1.ZoomFactorChanged += Gv_ZoomFactorChanged;
            c1GanttView1.BeforeEditTask += Gv_AfterEditTask;
        }

        private void Gv_PaintDay(object sender, PaintDayEventArgs e)
        {
            if (e.Task == c1GanttView1.SelectedTask)
                e.BackColor = Color.LightYellow;
            else if (e.Task == null)
            {
                if (e.Tier == c1GanttView1.Timescale.BottomTier)
                {
                    e.BackColor = Color.LightGray;
                    e.ForeColor = Color.Blue;
                }
                else if (e.Tier == c1GanttView1.Timescale.MiddleTier)
                {
                    using (Brush brush = new SolidBrush(Color.LightSteelBlue))
                    {
                        e.Graphics.FillRectangle(brush, e.Rectangle);
                    }
                    string beg = e.DateTime.Date.ToString("MMM,dd");
                    StringFormat f = new StringFormat(StringFormatFlags.NoWrap) { Alignment = StringAlignment.Center, Trimming = StringTrimming.EllipsisCharacter };
                    if (e.EndDateTime.Date - e.DateTime.Date > new TimeSpan(1, 0, 0, 0))
                    {
                        string end = e.EndDateTime.Date.AddDays(-1).ToString("MMM,dd");
                        e.Graphics.DrawString(beg + "-" + end, Font, new SolidBrush(Color.Black), e.Rectangle, f);
                    }
                    else
                        e.Graphics.DrawString(beg, Font, new SolidBrush(Color.Black), e.Rectangle, f);
                }
            }
        }

        private void Gv_AfterEditTask(object sender, CancelTaskArgs e)
        {
            if (e.Task?.Deadline != null)
            {
                e.Cancel = true;
            }
        }

        private void Gv_ZoomFactorChanged(object sender, EventArgs e)
        {
            c1GanttView1.Timescale.MiddleTier.Format = "";
        }

    }

    internal class DragNotificationCtrl : DragNotificationBase
    {
        C1GanttView _owner;
        BaseTask _task;

        public DragNotificationCtrl(C1GanttView owner) : base()
        {
            _owner = owner;
        }

        public override void EndDrag(BaseTask task)
        {

        }

        public override Size GetSize()
        {
            return new Size(150, 50);
        }

        public override bool StartDrag(BaseTask task)
        {
            _task = task;
            return _task?.Deadline != null;
        }

        public override void UpdateDates(DateTime? start, DateTime? finish, double duration, DurationUnits units)
        {
        }

        public override void UpdatePercent(double p, DateTime finish)
        {
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.Yellow);
            var size = GetSize();
            var rect = new Rectangle(0, 0, size.Width - 1, size.Height - 1);
            g.DrawRectangle(new Pen(Color.Gray), rect);
            g.DrawString("You should not change this task!", _owner.Font, Brushes.Black, rect, new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
        }

        public override bool AllowLinkMode => _task?.Deadline == null;
    }

}

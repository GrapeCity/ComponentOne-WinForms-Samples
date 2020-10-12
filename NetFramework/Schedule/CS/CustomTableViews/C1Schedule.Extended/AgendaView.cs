using C1.C1Schedule;
using C1.Win.C1FlexGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace C1.Win.C1Schedule
{
    // todo:
    // - add properties for Start and End dates, to allow date range different from Scheduler dates
    // - filter by appointment owner or resources?
    // - view title?

    /// <summary>
    /// Determines view type for Agenda View.
    /// </summary>
    public enum AgendaViewType
    {
        /// <summary>
        /// Show agenda for current day.
        /// </summary>
        Today,
        /// <summary>
        /// Show agenda for next 7 days, starting from the current day.
        /// </summary>
        Week,
        /// <summary>
        /// Show agenda for date range.
        /// </summary>
        DateRange
    }

    /// <summary>
    /// Represents a view that displays appointments grouped by date in a table, single row for appointment.
    /// </summary>
    public class C1AgendaView : BaseTableView
    {
        //------------------------------------------------
        #region ** Fields
        private bool _showEmptyDays = false;
        private AgendaViewType _viewType = AgendaViewType.Week;
        private DayCollection _days;
        private DateTime _start;
        private DateTime _end;
        #endregion

        //------------------------------------------------
        #region ** Initializing
        /// <summary>
        /// Initializes the new instance of the <see cref="AgendaView"/> class.
        /// </summary>
        public C1AgendaView() : base()
        {
            this.DrawMode = DrawModeEnum.OwnerDraw;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Rows.Fixed = 0; // no column headers
            this.SelectionMode = SelectionModeEnum.Row;
            this.AllowDelete = false;
            this.AllowEditing = false;
            this.AllowMerging = AllowMergingEnum.Custom;
            this.Clear();
            this.Cols.Count = 3;
            Cols[0].DataType = typeof(string);
            Cols[0].TextAlign = TextAlignEnum.LeftCenter;
            Cols[0].Width = 78;
            Cols[1].Width = 5; // column to show appointment busy status, only background without text
            Cols[2].DataType = typeof(string);
            Cols[2].StarWidth = "*";
            Tree.Style = TreeStyleFlags.Leaf;
            Tree.Column = 0;
            Tree.Indent = 0;
        }
        #endregion

        //------------------------------------------------
        #region ** Object Model
        /// <summary>
        /// Specifies current view type.
        /// </summary>
        [DefaultValue(AgendaViewType.Week)]
        public AgendaViewType ViewType
        {
            get { return _viewType; }
            set
            {
                if (_viewType != value)
                {
                    _viewType = value;
                    RefreshView();
                }
            }
        }

        /// <summary>
        /// Specifies whether days without events should be displayed.
        /// </summary>
        [DefaultValue(false)]
        public bool ShowEmptyDays
        {
            get { return _showEmptyDays; }
            set
            {
                if (_showEmptyDays != value)
                {
                    _showEmptyDays = value;
                    RefreshView();
                }
            }
        }
        #endregion

        //------------------------------------------------
        #region ** Overrides
        protected override void OnOwnerDrawCell(OwnerDrawCellEventArgs e)
        {
            // highlight appointment busy status and label
            if (e.Col == 1)
            {
                Appointment app = Rows[e.Row].UserData as Appointment;
                if (app != null && app.BusyStatus != null)
                {
                    // Draw the background.
                    e.Graphics.FillRectangle(app.BusyStatus.Brush.Brush, e.Bounds);
                    // Let the grid draw the border.
                    e.DrawCell(DrawCellFlags.Border);
                    // We' re done drawing this cell.
                    e.Handled = true;
                }
            }
            if (e.Col == 2)
            {
                Appointment app = Rows[e.Row].UserData as Appointment;
                if (app != null && app.Label != null)
                {
                    // Draw the background.
                    e.Graphics.FillRectangle(app.Label.Brush.Brush, e.Bounds);

                    e.Style.ForeColor = System.Drawing.Color.Black;
                    // Let the grid draw the content and border.
                    e.DrawCell(DrawCellFlags.Border | DrawCellFlags.Content);

                    // We' re done drawing this cell.
                    e.Handled = true;
                }
            }
            base.OnOwnerDrawCell(e);
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            RefreshView();
        }

        internal override void AttachScheduler(C1Schedule owner)
        {
            base.AttachScheduler(owner);
            _days = new DayCollection(owner.CalendarInfo);
            RefreshView();
        }

        internal override void DetachScheduler()
        {
            base.DetachScheduler();
            if (_days != null)
            {
                _days.Dispose();
                _days = null;
            }
        }

        protected override void RefreshView()
        {
            if (!Visible || Schedule == null)
            {
                // only refresh when not hidden
                return;
            }
            // clear previous information
            _days.Clear();
            // get new days
            _start = DateTime.Today;
            _end = _start;
            switch (_viewType)
            {
                case AgendaViewType.DateRange:
                    _start = Schedule.CalendarInfo.FirstDate;
                    _end = Schedule.CalendarInfo.LastDate;
                    break;
                case AgendaViewType.Week:
                    _end = _start.AddDays(7);
                    break;
            }
            // get days
            _days.FillDayCollection(_start, _end);
            // fill days with appointments
            var apps = Schedule.DataStorage.AppointmentStorage.Appointments.GetOccurrences(_start, _end.AddDays(1));
            foreach (Appointment app in apps)
            {
                _days.AddAppointment(app);
            }

            Redraw = false;

            // clear rows and merged ranges
            MergedRanges.Clear();
            Rows.RemoveRange(0, Rows.Count);

            // re-fill grid with data
            // fill rows
            var start = _start;
            while (start <= _end)
            {
                var day = _days[start];
                if (_showEmptyDays || day.HasActivity)
                {
                    var dayRow = Rows.Add();
                    dayRow.IsNode = true;
                    dayRow.UserData = day;
                    dayRow[0] = GetDayDescription(day.Date);
                    dayRow.Style = this.Styles[CellStyleEnum.Subtotal0];
                    CellRange rg = GetCellRange(dayRow.Index, 0, dayRow.Index, 2);
                    MergedRanges.Add(rg);
                    if (day.HasActivity)
                    {
                        var appointments = day.Appointments;
                        appointments.Sort(Schedule.AppointmentComparison);
                        for (int i = 0; i < appointments.Count; i++)
                        {
                            Appointment app = appointments[i];
                            var row = Rows.Add();
                            row.UserData = app;
                            row[2] = app.Subject;
                            if (!string.IsNullOrEmpty(app.Location))
                            {
                                row[2] += " (" + app.Location + ")";
                            }
                            if (app.AllDayEvent)
                            {
                                row[0] = "All day";
                            }
                            else
                            {
                                if (app.Start.Date == start)
                                {
                                    // short appointment
                                    row[0] = app.Start.ToShortTimeString();
                                    if (app.End.AddMilliseconds(-1).Date == start)
                                    {
                                        row[0] += "-" + app.End.ToShortTimeString();
                                    }
                                }
                                else if (app.End.AddMilliseconds(-1).Date == start)
                                {
                                    row[0] = "ends " + app.End.ToShortTimeString();
                                }
                            }
                        }
                    }
                    else
                    {
                        dayRow[0] += ":  No events";
                    }
                }
                start = start.AddDays(1);
            }
            Redraw = true;

            if (_viewType == AgendaViewType.DateRange && Rows.Count > 2)
            {
                // scroll to current date (or first day with activity if current date is invisible)
                var day = _days[DateTime.Today];
                if (!_showEmptyDays)
                {
                    while (!day.HasActivity && day.Date <= _end)
                    {
                        day = _days[day.Date.AddDays(1)];
                    }
                }
                if (day != null)
                {
                    for (int i = 0; i < Rows.Count; i++)
                    {
                        if (Rows[i].UserData.Equals(day))
                        {
                            TopRow = i;
                            break;
                        }
                    }
                }
            }
        }

        private string GetDayDescription(DateTime date)
        {
            date = date.Date;
            if (date == DateTime.Today)
                return "Today";
            if (date == DateTime.Today.AddDays(1))
                return "Tomorrow";
            return date.ToShortDateString();

        }
        #endregion
    }
}

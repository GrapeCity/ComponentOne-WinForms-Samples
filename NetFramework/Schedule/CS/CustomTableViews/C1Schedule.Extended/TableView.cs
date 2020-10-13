using C1.C1Schedule;
using C1.Win.C1FlexGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

// add to blueprint or requirements:
// - column filters and sorting works good, no need to add it to context menus or dialogs (leave it up to application if it needs to change default view settings)

// todo:
// - filter by appointment owner or resources?

namespace C1.Win.C1Schedule
{
    /// <summary>
    /// Represents a view that displays appointments in a table, single row for appointment.
    /// </summary>
    public class C1TableView : BaseTableView
    {
        //------------------------------------------------
        #region ** Fields
        DataTable _table;

        // todo: public property to allow change field settings both at design-time and run time.
        AppointmentFields _fields =  new AppointmentFields();
        Dictionary<string, AppointmentField> _currentFields;

        // flags to avoid recurring data updates
        private bool _synchronizing = false; // synchronizing data between view and Scheduler
        private bool _deleting = false; // deleting either appointment or table row

        private bool _active = false;

        // filter appointment to the same date range as in owning Scheduler control
        private DateTime _start = DateTime.Today.AddYears(-1);
        private DateTime _end = DateTime.Today.AddYears(1);

        #endregion

        //------------------------------------------------
        #region ** Initializing
        /// <summary>
        /// Initializes the new instance of the <see cref="TableView"/> class.
        /// </summary>
        public C1TableView() : base()
        {
            this.AllowFiltering = true;
            this.AutoGenerateColumns = true;

            // group by recurrence
            var recField = _fields["Recurrence"];
            recField.GroupIndex = 0;
            recField.Sort = SortFlags.Descending;

            // To group by more columns, change corresponding field settings accordingly as shown below
            // var catField = _fields["Categories"];
            // catField.GroupIndex = 1;
            // catField.Sort = SortFlags.Ascending;

            base.NullEmptyString = "(none)";

            _fields.FieldChanged += (sender, e) => RefreshView();
        }

        public override void EndInit()
        {
            base.EndInit();

            if (BindingContext != null && _table == null)
            {
                // creating datasource before setting BindingContext won't fill column info correctly
                RefreshView();
            }
        }
        #endregion

        //------------------------------------------------
        #region ** Object Model
        /// <summary>
        /// Gets or sets a <see cref="Boolean"/> value specifying whether this view should be filtered to only show active appointments.
        /// </summary>
        [DefaultValue(false)]
        public bool Active
        {
            get { return _active; }
            set
            {
                if (_active != value)
                {
                    _active = value;
                    _table.Rows.Clear();
                    OnAppointmentsLoaded();
                }
            }
        }
        #endregion

        //------------------------------------------------
        #region ** Overrides
        protected override void OnGridChanged(object sender, GridChangedEventArgs e)
        {
            if (e.GridChangedType == GridChangedTypeEnum.RowAdded)
            {
                this.ApplyFilters();
            }
            base.OnGridChanged(sender, e);
        }

        internal override void AttachScheduler(C1Schedule owner)
        {
            base.AttachScheduler(owner);
            _start = owner.CalendarInfo.FirstDate;
            _end = owner.CalendarInfo.LastDate;
            OnAppointmentsLoaded();
        }

        internal override void DetachScheduler()
        {
            if (!IsDisposed)
            {
                this.DataSource = null;
                _table.RowChanged -= Table_RowChanged;
                _table.RowDeleting -= Table_RowDeleting;
                _table = null;
            }

            base.DetachScheduler();
        }

        protected override void OnAppointmentAdded(AppointmentEventArgs e)
        {
            var rows = _table.Select("Id='" + e.Appointment.Key[0].ToString() + "'");
            if (rows == null || rows.Length == 0)
            {
                AddDataRow(e.Appointment);
            }
        }

        protected override void OnAppointmentChanged(AppointmentEventArgs e)
        {
            var rows = _table.Select("Id='" + e.Appointment.Key[0].ToString() + "'");
            if (rows != null && rows.Length > 0)
            {
                SetRow(e.Appointment, rows[0]);
            }
        }

        protected override void OnAppointmentDeleted(AppointmentEventArgs e)
        {
            if (_deleting)
                return;
            _deleting = true;
            var rows = _table.Select("Id='" + e.Appointment.Key[0].ToString() + "'");
            if ( rows != null && rows.Length > 0)
            {
                _table.Rows.Remove(rows[0]);
            }
            _deleting = false;
        }

        protected override void OnAppointmentsLoaded()
        {
            if (_table != null)
            {
                _table.Rows.Clear();
                foreach (var app in Schedule.DataStorage.AppointmentStorage.Appointments)
                {
                    AddDataRow(app);
                }
            }
        }

        protected override void OnValidateEdit(ValidateEditEventArgs e)
        {
            var col = this.Cols[e.Col];
            if (col.Name == "End")
            {
                var end = ((DateTimePicker)this.Editor).Value;
                var start = (DateTime)this[e.Row, "Start"];
                if ( end < start)
                {
                    MessageBox.Show("Appointment end time should be greater or equal than appointment start.");
                    e.Cancel = true;
                }
            }
            base.OnValidateEdit(e);
        }

        protected override void RefreshView()
        {
            bool needFill = Rows.Count > 0;
            var oldTable = _table;
            _currentFields = _fields.GetFieldsForView();

            // fill DataTable to use as DataSource
            DataTable table = new DataTable();

            foreach (var field in _currentFields.Values)
            {
                var c = table.Columns.Add(field.Name, field.DataType);
                c.Caption = field.Caption;
            }
            // Id is primary key
            var col = table.Columns["Id"];
            col.Unique = true;
            table.PrimaryKey = new DataColumn[] { col };

            table.RowChanged += Table_RowChanged;
            table.RowDeleting += Table_RowDeleting;
            _table = table;
            this.DataSource = table;

            // cleanup old table
            if (oldTable != null)
            {
                oldTable.RowChanged -= Table_RowChanged;
                oldTable.RowDeleting -= Table_RowDeleting;
                oldTable.Clear();
            }

            // more settings for autogenerated FlexGrid columns
            foreach (Column flexCol in Cols)
            {
                var field = _currentFields[flexCol.Name];
                flexCol.Visible = field.Visible;
                flexCol.AllowEditing = !field.ReadOnly;
                if (flexCol.DataType == typeof(DateTime))
                {
                    // allow showing and editing time part
                    flexCol.Format = "g";
                }
                if (flexCol.Name == "Icon")
                {
                    flexCol.ImageAndText = false;
                    flexCol.ImageMap = Icons; // set dictionary with images
                    flexCol.AllowFiltering = C1FlexGrid.AllowFiltering.None;
                    flexCol.Width = Rows[0].HeightDisplay;
                }
                if (flexCol.Name == "Subject")
                {
                    flexCol.StarWidth = "*";
                }
                if (flexCol.Name == "Start")
                {
                    flexCol.Sort = SortFlags.Ascending;
                }
            }

            // set grouping based on fields
            GroupDescriptions = null;
            Dictionary<int, AppointmentField> fieldsForGrouping = new Dictionary<int, AppointmentField>();
            foreach (var f in _currentFields.Values)
            {
                if (f.GroupIndex >= 0)
                {
                    fieldsForGrouping.Add(f.GroupIndex, f);
                }
            }
            // add fields which only need sort to the end of collection
            foreach (var f in _currentFields.Values)
            {
                if (f.GroupIndex == -1 && f.Sort != SortFlags.None)
                {
                    fieldsForGrouping.Add(fieldsForGrouping.Count, f);
                }
            }
            var groups = new List<GroupDescription>();
            // loop by index to add groups in correct order
            for (int i = 0; i < fieldsForGrouping.Count; i++)
            {
                if (fieldsForGrouping.ContainsKey(i))
                {
                    var field = fieldsForGrouping[i];
                    Column groupCol = Cols[field.Name];
                    groups.Add(new GroupDescription(
                        field.Name, 
                        field.Sort == SortFlags.Ascending ? ListSortDirection.Ascending : ListSortDirection.Descending, 
                        field.GroupIndex >= 0));
                }
            }
            if (groups.Count > 0)
            {
                GroupDescriptions = groups;
                // insert unbound column for grouping
                var column = Cols.Insert(0);
                column.TextAlign = TextAlignEnum.LeftCenter;
                //      column.Visible = false;
                column.Width = 1;
            }

            if (_fields.ContainsKey("RecurrencePattern") && _fields["RecurrencePattern"].GroupIndex == -1)
            {
                this.AutoSizeCol(Cols["RecurrencePattern"].Index, 50);
            }
            this.Sort(SortFlags.UseColSort, 0, Cols.Count - 1);

            if (needFill)
            {
                OnAppointmentsLoaded();
            }
        }
        #endregion

        //------------------------------------------------
        #region ** Implementation
        // propagate removing to Scheduler
        private void Table_RowDeleting(object sender, DataRowChangeEventArgs e)
        {
            if (_deleting)
                return;
            _deleting = true;
            // remove appointment
            var app = GetRowAppointment(e.Row);
            if (app != null)
            {
                Schedule.RemoveAppointment(app);
            }
            _deleting = false;
        }

        // propagate changes to Scheduler
        private void Table_RowChanged(object sender, DataRowChangeEventArgs e)
        {
            // update appointment
            var app = GetRowAppointment(e.Row);
            if (app != null)
            {
                SetAppointment(app, e.Row);
            }
        }

        // create new DataRow for added appointment and add it to data source
        private void AddDataRow(Appointment app)
        {
            // filter out all appointments out of Scheduler's date range
            var start = _active ? DateTime.Today : _start; // for active view only show appointments starting from the current date
            if (app.RecurrenceState == RecurrenceStateEnum.Master)
            {
                // if there are no occurrences in next yer, consider it already ended
                var appList = Schedule.DataStorage.AppointmentStorage.Appointments.GetOccurrences(app, start, _end.AddDays(1));
                if (appList.Count == 0)
                {
                    return;
                }
            }
            else if (app.End <= start || app.Start > _end)
            {
                return;
            }
            DataRow row = _table.NewRow();
            SetRow(app, row);
            _table.Rows.Add(row);
        }

        // set DataRow fields by Appointment properties
        private void SetRow(Appointment app, DataRow row)
        {
            if (_synchronizing)
                return;
            _synchronizing = true;
            foreach (var field in _currentFields.Values)
            {
                switch (field.Name)
                {
                    case "Icon":
                        row["Icon"] = app.RecurrenceState == RecurrenceStateEnum.NotRecurring ? "appointment" : "recurrence";
                        break;
                    case "RecurrencePattern":
                        row["RecurrencePattern"] = app.RecurrenceState != RecurrenceStateEnum.NotRecurring ? app.GetRecurrencePattern().GetDescription(Schedule.CalendarInfo) : "";
                        break;
                    case "Recurrence":
                        if (app.RecurrenceState != RecurrenceStateEnum.NotRecurring)
                        {
                            row["Recurrence"] = app.GetRecurrencePattern().RecurrenceType.ToString();
                        }
                        break;
                    case "Id":
                        row["Id"] = app.Key[0];
                        break;
                    case "Categories":
                    case "Resources":
                    case "Links":
                        string description = field.GetPropertyValue(app).ToString();
                        if ( description.Length > 1)
                        {
                            description = description.Substring(0, description.Length - 2);
                            row[field.Name] = description;
                        }
                        break;
                    case "Status":
                    case "Label":
                        row[field.Name] = field.GetPropertyValue(app)?.ToString();
                        break;
                    default:
                        row[field.Name] = field.GetPropertyValue(app);
                        break;
                }
            }
            _synchronizing = false;
        }

        // set Appointment properties by DataRow fields (only update properties which can be edited in the current view)
        private void SetAppointment(Appointment app, DataRow row)
        {
            if (_synchronizing)
                return;
            _synchronizing = true;
            var start = _currentFields.ContainsKey("Start")? (DateTime)row["Start"] : app.Start;
            foreach (var field in _currentFields.Values)
            {
                if (!field.ReadOnly)
                {
                    switch (field.Name)
                    {
                        case "Start":
                            if (app.Start != start)
                            {
                                app.Start = start;
                                row["End"] = app.End;
                            }
                            break;
                        case "End":
                            if (app.Start != start)
                            {
                                app.End = (DateTime)row["End"];
                            }
                            break;
                        default:
                            field.SetPropertyValue(app, row[field.Name]);
                            break;
                    }
                }
            }
            _synchronizing = false;
        }
        #endregion
    }
}

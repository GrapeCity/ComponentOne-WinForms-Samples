using C1.C1Schedule;
using C1.Win.C1FlexGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

// todo:
// - filter by appointment owner or resources?

namespace C1.Win.C1Schedule
{
    /// <summary>
    /// Grid control used as a base for different table views.
    /// </summary>
    public class BaseTableView : C1.Win.C1FlexGrid.C1FlexGrid
    {
        //------------------------------------------------
        #region ** Initializing
        // icons to use in grids
        protected static Dictionary<string, Image> Icons = new Dictionary<string, Image>();
        static BaseTableView()
        {
            var appImage = C1.Framework.ResourceLoader.GetImage(typeof(C1Schedule).Assembly, "newApp.png");
            Icons.Add("appointment", appImage);
            var recImage = C1.Framework.ResourceLoader.GetImage(typeof(C1Schedule).Assembly, "cycling.png");
            Icons.Add("recurrence", recImage);
        }

        /// <summary>
        /// Initializes the new instance of the <see cref="BaseTableView"/> class.
        /// </summary>
        public BaseTableView() : base()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseTableView));
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // BaseTableView
            // 
            this.AutoGenerateColumns = false;
            this.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Nodes;
            this.Cols.Fixed = 0;
            this.SelectionMode = SelectionModeEnum.RowRange;
            this.AllowDelete = true;
            this.Rows.DefaultSize = 20;
            this.ShowThemedHeaders = ShowThemedHeadersEnum.Both;
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        //------------------------------------------------
        #region ** Parent C1Schedule control
        C1Schedule _schedule;

        /// <summary>
        /// Gets or sets the <see cref="C1Schedule"/> control which data should be reflected in the current view.
        /// </summary>
        [Category("Behavior")]
        [Description("The reference to the C1Schedule control associated with this view.")]
        [DefaultValue(null)]
        public C1Schedule Schedule
        { 
            get { return _schedule; }
            set
            {
                if (_schedule == value)
                {
                    return;
                }
                if (_schedule != null)
                {
                    DetachScheduler();
                }
                if (value != null)
                {
                    AttachScheduler(value);
                }
            }
        }

        internal virtual void AttachScheduler(C1Schedule owner)
        {
            _schedule = owner;
            _schedule.AppointmentAdded += _schedule_AppointmentAdded;
            _schedule.AppointmentDeleted += _schedule_AppointmentDeleted;
            _schedule.AppointmentChanged += _schedule_AppointmentChanged;
            _schedule.AppointmentsLoaded += _schedule_AppointmentsLoaded;
        }

        private void _schedule_AppointmentsLoaded(object sender, EventArgs e)
        {
            OnAppointmentsLoaded();
        }

        private void _schedule_AppointmentChanged(object sender, AppointmentEventArgs e)
        {
            OnAppointmentChanged(e);
        }

        private void _schedule_AppointmentDeleted(object sender, AppointmentEventArgs e)
        {
            OnAppointmentDeleted(e);
        }

        private void _schedule_AppointmentAdded(object sender, AppointmentEventArgs e)
        {
            OnAppointmentAdded(e);
        }

        internal virtual void DetachScheduler()
        {
            if (_schedule != null)
            {
                _schedule.AppointmentAdded -= _schedule_AppointmentAdded;
                _schedule.AppointmentDeleted -= _schedule_AppointmentDeleted;
                _schedule.AppointmentChanged -= _schedule_AppointmentChanged;
                _schedule.AppointmentsLoaded -= _schedule_AppointmentsLoaded;
            }
            _schedule = null;
        }
        #endregion

        //------------------------------------------------
        #region ** protected
        protected virtual void RefreshView()
        {
            // does nothing here
        }

        protected virtual void OnAppointmentAdded(AppointmentEventArgs e)
        {
            RefreshView();
        }

        protected virtual void OnAppointmentDeleted(AppointmentEventArgs e)
        {
            RefreshView();
        }

        protected virtual void OnAppointmentChanged(AppointmentEventArgs e)
        {
            RefreshView();
        }

        protected virtual void OnAppointmentsLoaded()
        {
            RefreshView();
        }

        /// <summary>
        /// Returns the <see cref="Appointment"/> object associated with the specified FlexGrid row index in the current view.
        /// </summary>
        /// <param name="row">The row index.</param>
        /// <returns>The <see cref="Appointment"/> object.</returns>
        protected Appointment GetRowAppointment(int row)
        {
            if ( row < 0)
            {
                return null;
            }
            var gridRow = Rows[row];
            Appointment app = gridRow.UserData as Appointment;
            if ( app != null)
            {
                return app;
            }
            DataRowView drv = (DataRowView)gridRow.DataSource;
            if (drv == null)
            {
                // possible for group rows
                return null;
            }
            object key = drv["Id"];
            if (key.GetType() != typeof(Guid))
            {
                return null;
            }
            app = Schedule.DataStorage.AppointmentStorage.Appointments[(Guid)key];
            return app;
        }

        /// <summary>
        /// Returns the <see cref="Appointment"/> object associated with the specified row in the current view.
        /// </summary>
        /// <param name="row">The row index.</param>
        /// <returns>The <see cref="Appointment"/> object.</returns>
        protected Appointment GetRowAppointment(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            object key = row["Id"];
            if (key.GetType() != typeof(Guid))
            {
                return null;
            }
            Appointment app = Schedule.DataStorage.AppointmentStorage.Appointments[(Guid)key];
            return app;
        }
        #endregion

        //------------------------------------------------
        #region ** Selection
        private List<Appointment> _selectedApps = new List<Appointment>();
        /// <summary>
        /// Gets the <see cref="List{Appointment}"/> object containing 
        /// the list of the currently selected <see cref="Appointment"/> objects.
        /// </summary>
        [
        Browsable(false),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),
        ]
        public List<Appointment> SelectedAppointments
        {
            get
            {
                return _selectedApps;
            }
        }

        /// <summary>
        /// Occurs when the list of selected appointments is changed.
        /// </summary>
        public event EventHandler SelectedAppointmentsChanged;
        internal void OnSelectedAppointmentsChanged(EventArgs args)
        {
            if (SelectedAppointmentsChanged != null)
            {
                SelectedAppointmentsChanged(this, args);
            }
        }

        protected override void OnSelChange(EventArgs e)
        {
            base.OnSelChange(e);
            // find selected appointments
            List<Appointment> appsForSelect = new List<Appointment>();
            var range = Selection;
            for (int i = range.TopRow; i <= range.BottomRow; i++)
            {
                Appointment app = this.GetRowAppointment(i);
                if (app != null)
                {
                    appsForSelect.Add(app);
                }
            }
            bool needUpdate = _selectedApps.Count != appsForSelect.Count;
            if (!needUpdate)
            {
                foreach (var app in appsForSelect)
                {
                    if ( !_selectedApps.Contains(app))
                    {
                        needUpdate = true;
                        break;
                    }
                }
            }
            if (needUpdate)
            {
                _selectedApps.Clear();
                _selectedApps.AddRange(appsForSelect);
                OnSelectedAppointmentsChanged(null);
            }
        }
        #endregion

        //------------------------------------------------
        #region ** Overrides
        // set selection
        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (Visible)
            {
                OnSelChange(null);
            }
        }

        // open appointment form on double click
        protected override void OnBeforeDoubleClick(BeforeMouseDownEventArgs e)
        {
            Appointment app = GetRowAppointment(HitTest(new Point(e.X, e.Y)).Row);
            if (app != null)
            {
                Schedule.EditAppointment(app);
                e.Cancel = true;
            }
            base.OnBeforeDoubleClick(e);
        }
        #endregion

        //------------------------------------------------
        #region ** Disposing
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            if (_schedule != null)
            {
                // detach
                DetachScheduler();
            }
        }
        #endregion

        //------------------------------------------------
        #region ** Hidden FlexGrid Properties
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public new bool AllowEditing
        {
            get
            {
                return base.AllowEditing;
            }
            set
            {
                base.AllowEditing = value;
            }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public new AllowMergingEnum AllowMerging
        {
            get
            {
                return base.AllowMerging;
            }
            set
            {
                base.AllowMerging = value;
            }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public new bool AutoGenerateColumns
        {
            get
            {
                return base.AutoGenerateColumns;
            }
            set
            {
                base.AutoGenerateColumns = value;
            }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public new string ColumnInfo
        {
            get
            {
                return base.ColumnInfo;
            }
            set
            {
                base.ColumnInfo = value;
            }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public new DrawModeEnum DrawMode
        {
            get
            {
                return base.DrawMode;
            }
            set
            {
                base.DrawMode = value;
            }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new RowCollection Rows
        {
            get
            {
                return base.Rows;
            }
        }
        #endregion

    }
}

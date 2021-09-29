using C1.C1Schedule;
using C1.Win.Schedule;
using C1.Win.Themes;
using ScheduleExplorer.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ScheduleExplorer.Samples
{
    public partial class C1ScheduleDemo : UserControl
    {
        private DataTable _appointmentsDataTable;

        public C1ScheduleDemo()
        {
            InitializeComponent();

            // fill combo for selecting group page size
            cmbGroupPageSize.Items.Add(1);
            cmbGroupPageSize.Items.Add(2);
            cmbGroupPageSize.Items.Add(3);
            cmbGroupPageSize.Items.Add(4);
            cmbGroupPageSize.Items.Add(5);

            cmbGroupPageSize.SelectedIndex = 1;
        }

        public virtual void ApplyTheme(C1Theme theme)
        {
        }

        private void C1ScheduleDemo_Load(object sender, EventArgs e)
        {
            // get database connection string
            DataSource.GetConnectionString();

            // open connection
            DataSource.OpenConnection();

            // assign mapping and data source to AppointmentStorage
            c1Schedule1.DataStorage.AppointmentStorage.Mappings.IdMapping.MappingName = "Id";
            c1Schedule1.DataStorage.AppointmentStorage.Mappings.Body.MappingName = "Body";
            c1Schedule1.DataStorage.AppointmentStorage.Mappings.Start.MappingName = "Start";
            c1Schedule1.DataStorage.AppointmentStorage.Mappings.End.MappingName = "End";
            c1Schedule1.DataStorage.AppointmentStorage.Mappings.Location.MappingName = "Location";
            c1Schedule1.DataStorage.AppointmentStorage.Mappings.Subject.MappingName = "Subject";
            c1Schedule1.DataStorage.AppointmentStorage.Mappings.AppointmentProperties.MappingName = "Properties";

            c1Schedule1.DataStorage.AppointmentStorage.DataMember = "Appointments";

            var sql = @"SELECT Id, Body, End, Location, Start, Subject, Properties FROM Appointments";

            _appointmentsDataTable = DataSource.GetRows(sql);

            if (_appointmentsDataTable != null)
            {
                c1Schedule1.DataStorage.AppointmentStorage.DataSource = _appointmentsDataTable;

                _appointmentsDataTable.AcceptChanges();
            }

            // assign mapping and data source to ContactStorage
            c1Schedule1.DataStorage.ContactStorage.Mappings.IndexMapping.MappingName = "EmployeeID";
            c1Schedule1.DataStorage.ContactStorage.Mappings.TextMapping.MappingName = "FirstName";

            c1Schedule1.DataStorage.ContactStorage.DataMember = "Appointees";

            sql = @"SELECT EmployeeID, LastName, FirstName FROM Employees";

            c1Schedule1.DataStorage.ContactStorage.DataSource = DataSource.GetRows(sql);

            // close connection
            DataSource.CloseConnection();

            // set correct MenuCaption for contacts
            foreach (Contact cnt in c1Schedule1.DataStorage.ContactStorage.Contacts)
            {
                var dt = c1Schedule1.DataStorage.ContactStorage.DataSource as DataTable;
                var rows = dt.Select(string.Format("EmployeeID={0}", (int)cnt.Key[0]));

                if (rows != null && rows.Length > 0)
                {
                    var row = rows[0];
                    cnt.MenuCaption = row["FirstName"].ToString() + " " + row["LastName"].ToString();
                }
            }

            this.VisibleChanged += C1ScheduleDemo_VisibleChanged;

            string customThemePath = @"e:\!_111\123.c1themez";
            C1Theme theme = new C1Theme();
            theme.Load(customThemePath);
            c1Schedule1.ThemeChanged(theme);
        }

        private void C1ScheduleDemo_VisibleChanged(object sender, EventArgs e)
        {
            if (!Visible && _appointmentsDataTable != null)
            {
                // get DataTable changes
                var changes = _appointmentsDataTable.GetChanges();

                if (changes?.Rows?.Count > 0)
                {

                    
                    // NOTE: uncomment the next code to save changes into the database!


                    /*
                      
                    DataSource.OpenConnection();

                    // get changed rows
                    for (int i = 0; i < changes.Rows.Count; i++)
                    {
                        var row = changes.Rows[i];

                        switch (row.RowState)
                        {
                            case DataRowState.Deleted: // when row removed
                                // get deleted row
                                var deleteSQL = string.Format("DELETE FROM appointments WHERE id='{0}'", row["id", DataRowVersion.Original].ToString().ToUpper());
                                DataSource.DeleteRow(deleteSQL);
                                break;

                            case DataRowState.Modified: // when row modified
                                var updateSQL = @"UPDATE appointments SET body=@body, end=@end, location=@location, start=@start, subject=@subject, properties=@properties WHERE id=@id";
                                DataSource.QueryAppointments(updateSQL, row);
                                break;

                            case DataRowState.Added: // when row inserted
                                var insertSQL = @"INSERT INTO appointments (id, body, end, location, start, subject, properties) VALUES (@id, @body, @end, @location, @start, @subject, @properties)";
                                DataSource.QueryAppointments(insertSQL, row);
                                break;
                        }
                    }

                    DataSource.CloseConnection();
                     
                     */
                }
            }
        }

        private void _DayView_Click(object sender, EventArgs e)
        {
            // Switch to the DayView.
            c1Schedule1.ViewType = ScheduleViewEnum.DayView;
        }

        private void _workWeek_Click(object sender, EventArgs e)
        {
            // Switch to the WorkWeekView.
            c1Schedule1.ViewType = ScheduleViewEnum.WorkWeekView;
        }

        private void _week_Click(object sender, EventArgs e)
        {
            // Switch to the WeekView.
            c1Schedule1.ViewType = ScheduleViewEnum.WeekView;
        }

        private void _month_Click(object sender, EventArgs e)
        {
            // Switch to the MonthView.
            c1Schedule1.ViewType = ScheduleViewEnum.MonthView;
        }

        private void _timeLine_Click(object sender, EventArgs e)
        {
            // Switch to the TimeLineView.
            c1Schedule1.ViewType = ScheduleViewEnum.TimeLineView;
        }

        private void _today_Click(object sender, EventArgs e)
        {
            // Go to today date.
            c1Schedule1.GoToDate(DateTime.Today);
        }

        private void showEmptyGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            c1Schedule1.ShowEmptyGroupItem = showEmptyGroupToolStripMenuItem.CheckState == CheckState.Checked;
        }

        private void cmbGroupPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            // update group page size
            c1Schedule1.GroupPageSize = (int)cmbGroupPageSize.SelectedItem;
        }

        private void noneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // remove C1Schedule grouping
            c1Schedule1.GroupBy = "";
            contactToolStripMenuItem.Checked = false;
            categoryToolStripMenuItem.Checked = false;
            resourceToolStripMenuItem.Checked = false;
        }

        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // group C1Schedule by appointment contacts
            c1Schedule1.GroupBy = "Contact";
            noneToolStripMenuItem.Checked = false;
            categoryToolStripMenuItem.Checked = false;
            resourceToolStripMenuItem.Checked = false;
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // group C1Schedule by appointment categories
            c1Schedule1.GroupBy = "Category";
            noneToolStripMenuItem.Checked = false;
            contactToolStripMenuItem.Checked = false;
            resourceToolStripMenuItem.Checked = false;
        }

        private void resourceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // group C1Schedule by appointment resources
            c1Schedule1.GroupBy = "Resource";
            noneToolStripMenuItem.Checked = false;
            contactToolStripMenuItem.Checked = false;
            categoryToolStripMenuItem.Checked = false;
        }
    }
}

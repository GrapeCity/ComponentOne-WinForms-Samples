namespace DataBinding
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            C1.Win.GanttView.BarStyle barStyle1 = new C1.Win.GanttView.BarStyle();
            C1.Win.GanttView.TaskPropertyColumn taskPropertyColumn1 = new C1.Win.GanttView.TaskPropertyColumn();
            C1.Win.GanttView.TaskPropertyColumn taskPropertyColumn2 = new C1.Win.GanttView.TaskPropertyColumn();
            C1.Win.GanttView.TaskPropertyColumn taskPropertyColumn3 = new C1.Win.GanttView.TaskPropertyColumn();
            C1.Win.GanttView.TaskPropertyColumn taskPropertyColumn4 = new C1.Win.GanttView.TaskPropertyColumn();
            C1.Win.GanttView.TaskPropertyColumn taskPropertyColumn5 = new C1.Win.GanttView.TaskPropertyColumn();
            C1.Win.GanttView.TaskPropertyColumn taskPropertyColumn6 = new C1.Win.GanttView.TaskPropertyColumn();
            C1.Win.GanttView.TaskPropertyColumn taskPropertyColumn7 = new C1.Win.GanttView.TaskPropertyColumn();
            C1.Win.GanttView.TaskPropertyColumn taskPropertyColumn8 = new C1.Win.GanttView.TaskPropertyColumn();
            C1.Win.GanttView.TaskPropertyColumn taskPropertyColumn9 = new C1.Win.GanttView.TaskPropertyColumn();
            C1.Win.GanttView.TaskPropertyColumn taskPropertyColumn10 = new C1.Win.GanttView.TaskPropertyColumn();
            C1.Win.GanttView.TaskPropertyColumn taskPropertyColumn11 = new C1.Win.GanttView.TaskPropertyColumn();
            C1.Win.GanttView.TaskPropertyColumn taskPropertyColumn12 = new C1.Win.GanttView.TaskPropertyColumn();
            C1.Win.GanttView.TaskPropertyColumn taskPropertyColumn13 = new C1.Win.GanttView.TaskPropertyColumn();
            C1.Win.GanttView.TaskPropertyColumn taskPropertyColumn14 = new C1.Win.GanttView.TaskPropertyColumn();
            C1.Win.GanttView.Task task1 = new C1.Win.GanttView.Task();
            C1.Win.GanttView.Resource resource1 = new C1.Win.GanttView.Resource();
            C1.Win.GanttView.Resource resource2 = new C1.Win.GanttView.Resource();
            C1.Win.GanttView.Resource resource3 = new C1.Win.GanttView.Resource();
            C1.Win.GanttView.Resource resource4 = new C1.Win.GanttView.Resource();
            this.c1GanttView1 = new C1.Win.GanttView.C1GanttView();
            this.c1NwindDataSet1 = new DataBinding.C1NwindDataSet();
            this.calendarsTableAdapter1 = new DataBinding.C1NwindDataSetTableAdapters.CalendarsTableAdapter();
            this.propertiesTableAdapter1 = new DataBinding.C1NwindDataSetTableAdapters.PropertiesTableAdapter();
            this.resourcesTableAdapter1 = new DataBinding.C1NwindDataSetTableAdapters.ResourcesTableAdapter();
            this.tasksTableAdapter1 = new DataBinding.C1NwindDataSetTableAdapters.TasksTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.c1GanttView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1GanttView1.DataStorage.CalendarStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1GanttView1.DataStorage.PropertyStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1GanttView1.DataStorage.ResourceStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1GanttView1.DataStorage.TasksStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1NwindDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1GanttView1
            // 
            this.c1GanttView1.BackColor = System.Drawing.SystemColors.Window;
            this.c1GanttView1.BarStyles.Add(barStyle1);
            taskPropertyColumn1.ID = 460962824;
            taskPropertyColumn1.Property = C1.Win.GanttView.TaskProperty.Mode;
            taskPropertyColumn2.ID = 833503351;
            taskPropertyColumn2.Property = C1.Win.GanttView.TaskProperty.Name;
            taskPropertyColumn3.ID = 1893399974;
            taskPropertyColumn3.Property = C1.Win.GanttView.TaskProperty.Duration;
            taskPropertyColumn3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            taskPropertyColumn4.ID = 2088347062;
            taskPropertyColumn4.Property = C1.Win.GanttView.TaskProperty.DurationUnits;
            taskPropertyColumn5.ID = 1770681967;
            taskPropertyColumn5.Property = C1.Win.GanttView.TaskProperty.Start;
            taskPropertyColumn6.ID = 1353400856;
            taskPropertyColumn6.Property = C1.Win.GanttView.TaskProperty.Finish;
            taskPropertyColumn7.ID = 327624968;
            taskPropertyColumn7.Property = C1.Win.GanttView.TaskProperty.PercentComplete;
            taskPropertyColumn7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            taskPropertyColumn8.ID = 1802186475;
            taskPropertyColumn8.Property = C1.Win.GanttView.TaskProperty.ConstraintType;
            taskPropertyColumn9.ID = 664387641;
            taskPropertyColumn9.Property = C1.Win.GanttView.TaskProperty.ConstraintDate;
            taskPropertyColumn10.ID = 1817613588;
            taskPropertyColumn10.Property = C1.Win.GanttView.TaskProperty.Predecessors;
            taskPropertyColumn11.ID = 1830602282;
            taskPropertyColumn11.Property = C1.Win.GanttView.TaskProperty.Deadline;
            taskPropertyColumn12.ID = 79646123;
            taskPropertyColumn12.Property = C1.Win.GanttView.TaskProperty.Calendar;
            taskPropertyColumn13.ID = 1310716901;
            taskPropertyColumn13.Property = C1.Win.GanttView.TaskProperty.ResourceNames;
            taskPropertyColumn14.ID = 1688300557;
            taskPropertyColumn14.Property = C1.Win.GanttView.TaskProperty.Notes;
            this.c1GanttView1.Columns.Add(taskPropertyColumn1);
            this.c1GanttView1.Columns.Add(taskPropertyColumn2);
            this.c1GanttView1.Columns.Add(taskPropertyColumn3);
            this.c1GanttView1.Columns.Add(taskPropertyColumn4);
            this.c1GanttView1.Columns.Add(taskPropertyColumn5);
            this.c1GanttView1.Columns.Add(taskPropertyColumn6);
            this.c1GanttView1.Columns.Add(taskPropertyColumn7);
            this.c1GanttView1.Columns.Add(taskPropertyColumn8);
            this.c1GanttView1.Columns.Add(taskPropertyColumn9);
            this.c1GanttView1.Columns.Add(taskPropertyColumn10);
            this.c1GanttView1.Columns.Add(taskPropertyColumn11);
            this.c1GanttView1.Columns.Add(taskPropertyColumn12);
            this.c1GanttView1.Columns.Add(taskPropertyColumn13);
            this.c1GanttView1.Columns.Add(taskPropertyColumn14);
            // 
            // 
            // 
            // 
            // 
            // 
            this.c1GanttView1.DataStorage.CalendarStorage.DataMember = "Calendars";
            this.c1GanttView1.DataStorage.CalendarStorage.DataSource = this.c1NwindDataSet1;
            // 
            // 
            // 
            // 
            // 
            // 
            this.c1GanttView1.DataStorage.CalendarStorage.Mappings.CalendarID.MappingName = "CalendarID";
            // 
            // 
            // 
            this.c1GanttView1.DataStorage.CalendarStorage.Mappings.Data.MappingName = "Data";
            // 
            // 
            // 
            this.c1GanttView1.DataStorage.CalendarStorage.Mappings.IdMapping.MappingName = "Id";
            // 
            // 
            // 
            this.c1GanttView1.DataStorage.CalendarStorage.Mappings.Name.MappingName = "Name";
            // 
            // 
            // 
            this.c1GanttView1.DataStorage.PropertyStorage.DataMember = "Properties";
            this.c1GanttView1.DataStorage.PropertyStorage.DataSource = this.c1NwindDataSet1;
            // 
            // 
            // 
            this.c1GanttView1.DataStorage.PropertyStorage.Key.MappingName = "Key";
            // 
            // 
            // 
            this.c1GanttView1.DataStorage.PropertyStorage.Value.MappingName = "Value";
            // 
            // 
            // 
            this.c1GanttView1.DataStorage.ResourceStorage.DataMember = "Resources";
            this.c1GanttView1.DataStorage.ResourceStorage.DataSource = this.c1NwindDataSet1;
            // 
            // 
            // 
            // 
            // 
            // 
            this.c1GanttView1.DataStorage.ResourceStorage.Mappings.Cost.MappingName = "Cost";
            // 
            // 
            // 
            this.c1GanttView1.DataStorage.ResourceStorage.Mappings.IdMapping.MappingName = "Id";
            // 
            // 
            // 
            this.c1GanttView1.DataStorage.ResourceStorage.Mappings.Name.MappingName = "Name";
            // 
            // 
            // 
            this.c1GanttView1.DataStorage.ResourceStorage.Mappings.Notes.MappingName = "Notes";
            // 
            // 
            // 
            this.c1GanttView1.DataStorage.ResourceStorage.Mappings.ResourceID.MappingName = "ResourceID";
            // 
            // 
            // 
            this.c1GanttView1.DataStorage.ResourceStorage.Mappings.ResourceType.MappingName = "ResourceType";
            // 
            // 
            // 
            this.c1GanttView1.DataStorage.ResourceStorage.Mappings.UnitOfMeasure.MappingName = "UnitOfMeasure";
            // 
            // 
            // 
            this.c1GanttView1.DataStorage.TasksStorage.DataMember = "Tasks";
            this.c1GanttView1.DataStorage.TasksStorage.DataSource = this.c1NwindDataSet1;
            // 
            // 
            // 
            // 
            // 
            // 
            this.c1GanttView1.DataStorage.TasksStorage.Mappings.CalendarID.MappingName = "CalendarID";
            // 
            // 
            // 
            this.c1GanttView1.DataStorage.TasksStorage.Mappings.Parts.MappingName = "Parts";
            // 
            // 
            // 
            this.c1GanttView1.DataStorage.TasksStorage.Mappings.ConstraintDate.MappingName = "ConstraintDate";
            // 
            // 
            // 
            this.c1GanttView1.DataStorage.TasksStorage.Mappings.ConstraintType.MappingName = "ConstraintType";
            // 
            // 
            // 
            this.c1GanttView1.DataStorage.TasksStorage.Mappings.CustomFields.MappingName = "CustomFields";
            // 
            // 
            // 
            this.c1GanttView1.DataStorage.TasksStorage.Mappings.Deadline.MappingName = "Deadline";
            // 
            // 
            // 
            this.c1GanttView1.DataStorage.TasksStorage.Mappings.Duration.MappingName = "Duration";
            // 
            // 
            // 
            this.c1GanttView1.DataStorage.TasksStorage.Mappings.DurationUnits.MappingName = "DurationUnits";
            // 
            // 
            // 
            this.c1GanttView1.DataStorage.TasksStorage.Mappings.Finish.MappingName = "Finish";
            // 
            // 
            // 
            this.c1GanttView1.DataStorage.TasksStorage.Mappings.HideBar.MappingName = "HideBar";
            // 
            // 
            // 
            this.c1GanttView1.DataStorage.TasksStorage.Mappings.IdMapping.MappingName = "Id";
            // 
            // 
            // 
            this.c1GanttView1.DataStorage.TasksStorage.Mappings.Initialized.MappingName = "Initialized";
            // 
            // 
            // 
            this.c1GanttView1.DataStorage.TasksStorage.Mappings.Mode.MappingName = "Mode";
            // 
            // 
            // 
            this.c1GanttView1.DataStorage.TasksStorage.Mappings.Name.MappingName = "Name";
            // 
            // 
            // 
            this.c1GanttView1.DataStorage.TasksStorage.Mappings.NextID.MappingName = "NextID";
            // 
            // 
            // 
            this.c1GanttView1.DataStorage.TasksStorage.Mappings.Notes.MappingName = "Notes";
            // 
            // 
            // 
            this.c1GanttView1.DataStorage.TasksStorage.Mappings.OutlineParentID.MappingName = "OutlineParentID";
            // 
            // 
            // 
            this.c1GanttView1.DataStorage.TasksStorage.Mappings.PercentComplete.MappingName = "PercentComplete";
            // 
            // 
            // 
            this.c1GanttView1.DataStorage.TasksStorage.Mappings.Predecessors.MappingName = "Predecessors";
            // 
            // 
            // 
            this.c1GanttView1.DataStorage.TasksStorage.Mappings.Resources.MappingName = "Resources";
            // 
            // 
            // 
            this.c1GanttView1.DataStorage.TasksStorage.Mappings.Start.MappingName = "Start";
            // 
            // 
            // 
            this.c1GanttView1.DataStorage.TasksStorage.Mappings.Summary.MappingName = "Summary";
            // 
            // 
            // 
            this.c1GanttView1.DataStorage.TasksStorage.Mappings.TaskID.MappingName = "TaskID";
            this.c1GanttView1.DefaultWorkingTimes.Interval_1.Empty = false;
            this.c1GanttView1.DefaultWorkingTimes.Interval_1.From = new System.DateTime(1, 1, 1, 9, 0, 0, 0);
            this.c1GanttView1.DefaultWorkingTimes.Interval_1.To = new System.DateTime(1, 1, 1, 13, 0, 0, 0);
            this.c1GanttView1.DefaultWorkingTimes.Interval_2.Empty = false;
            this.c1GanttView1.DefaultWorkingTimes.Interval_2.From = new System.DateTime(1, 1, 1, 14, 0, 0, 0);
            this.c1GanttView1.DefaultWorkingTimes.Interval_2.To = new System.DateTime(1, 1, 1, 18, 0, 0, 0);
            this.c1GanttView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1GanttView1.EnablePrinting = true;
            this.c1GanttView1.GridWidth = 369;
            this.c1GanttView1.Location = new System.Drawing.Point(0, 0);
            this.c1GanttView1.Name = "c1GanttView1";
            this.c1GanttView1.PrintInfo.LegendTextAreaWidth = 2F;
            this.c1GanttView1.PrintInfo.PrintType = C1.Win.GanttView.Printing.PrintType.General;
            this.c1GanttView1.PrintInfo.StyleSource = "General.c1d";
            task1.ID = 1482860220;
            task1.Mode = C1.Win.GanttView.TaskMode.Automatic;
            task1.Name = "Project Summary Task";
            task1.NextID = 0;
            this.c1GanttView1.ProjectSummary = task1;
            resource1.ID = 1065548974;
            resource1.Name = "Resource 1";
            resource1.NextID = 0;
            resource2.ID = 737702317;
            resource2.Name = "Resource 2";
            resource2.NextID = 0;
            resource3.ID = 499183821;
            resource3.Name = "Resource 3";
            resource3.NextID = 0;
            resource4.ID = 622525569;
            resource4.Name = "Resource 4";
            resource4.NextID = 0;
            this.c1GanttView1.Resources.AddRange(new C1.Win.GanttView.Resource[] {
            resource1,
            resource2,
            resource3,
            resource4});
            this.c1GanttView1.Size = new System.Drawing.Size(924, 456);
            this.c1GanttView1.StartDate = new System.DateTime(2015, 3, 23, 0, 0, 0, 0);
            this.c1GanttView1.TabIndex = 0;
            this.c1GanttView1.Timescale.BottomTier.Align = C1.Win.GanttView.ScaleLabelAlignment.Center;
            this.c1GanttView1.Timescale.BottomTier.Format = "w";
            this.c1GanttView1.Timescale.BottomTier.Visible = true;
            this.c1GanttView1.Timescale.MiddleTier.Format = "nnnn d";
            this.c1GanttView1.Timescale.MiddleTier.Units = C1.Win.GanttView.TimescaleUnits.Weeks;
            this.c1GanttView1.Timescale.MiddleTier.Visible = true;
            // 
            // c1NwindDataSet1
            // 
            this.c1NwindDataSet1.DataSetName = "C1NwindDataSet";
            this.c1NwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // calendarsTableAdapter1
            // 
            this.calendarsTableAdapter1.ClearBeforeFill = true;
            // 
            // propertiesTableAdapter1
            // 
            this.propertiesTableAdapter1.ClearBeforeFill = true;
            // 
            // resourcesTableAdapter1
            // 
            this.resourcesTableAdapter1.ClearBeforeFill = true;
            // 
            // tasksTableAdapter1
            // 
            this.tasksTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 456);
            this.Controls.Add(this.c1GanttView1);
            this.Name = "Form1";
            this.Text = "C1GanttView Data Binding Demo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1GanttView1.DataStorage.CalendarStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1GanttView1.DataStorage.PropertyStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1GanttView1.DataStorage.ResourceStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1GanttView1.DataStorage.TasksStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1GanttView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1NwindDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.GanttView.C1GanttView c1GanttView1;
        private C1NwindDataSet c1NwindDataSet1;
        private C1NwindDataSetTableAdapters.CalendarsTableAdapter calendarsTableAdapter1;
        private C1NwindDataSetTableAdapters.PropertiesTableAdapter propertiesTableAdapter1;
        private C1NwindDataSetTableAdapters.ResourcesTableAdapter resourcesTableAdapter1;
        private C1NwindDataSetTableAdapters.TasksTableAdapter tasksTableAdapter1;
    }
}


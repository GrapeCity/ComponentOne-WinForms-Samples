namespace ControlExplorer.CalendarView
{
    partial class Overview
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
            this.c1CalendarView1 = new C1.Win.Calendar.C1CalendarView();
            this.SuspendLayout();
            // 
            // c1CalendarView1
            // 
            this.c1CalendarView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1CalendarView1.CalendarDimensions = 6;
            this.c1CalendarView1.FirstDayOfWeek = System.DayOfWeek.Sunday;
            this.c1CalendarView1.Location = new System.Drawing.Point(0, 0);
            this.c1CalendarView1.MaxDate = new System.DateTime(9999, 12, 31, 0, 0, 0, 0);
            this.c1CalendarView1.MinDate = new System.DateTime(((long)(0)));
            this.c1CalendarView1.Name = "c1CalendarView1";
            this.c1CalendarView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.c1CalendarView1.Size = new System.Drawing.Size(415, 366);
            this.c1CalendarView1.TabIndex = 0;
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 366);
            this.Controls.Add(this.c1CalendarView1);
            this.Name = "Overview";
            this.Text = "Overview";
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.Calendar.C1CalendarView c1CalendarView1;      
    }
}
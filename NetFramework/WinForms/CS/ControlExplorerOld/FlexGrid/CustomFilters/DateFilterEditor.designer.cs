namespace ControlExplorer.FlexGrid.CustomFilters
{
    partial class DateFilterEditor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._chkCalendar = new System.Windows.Forms.CheckBox();
            this._calendar = new System.Windows.Forms.MonthCalendar();
            this._chkYesterday = new System.Windows.Forms.CheckBox();
            this._chkEarlierThisWeek = new System.Windows.Forms.CheckBox();
            this._chkLastWeek = new System.Windows.Forms.CheckBox();
            this._chkLongAgo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // _chkCalendar
            // 
            this._chkCalendar.AutoSize = true;
            this._chkCalendar.Location = new System.Drawing.Point(2, 0);
            this._chkCalendar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._chkCalendar.Name = "_chkCalendar";
            this._chkCalendar.Size = new System.Drawing.Size(134, 17);
            this._chkCalendar.TabIndex = 0;
            this._chkCalendar.Text = "Filter by a specific date";
            this._chkCalendar.UseVisualStyleBackColor = true;
            this._chkCalendar.CheckedChanged += new System.EventHandler(this._chkCalendar_CheckedChanged);
            // 
            // _calendar
            // 
            this._calendar.Location = new System.Drawing.Point(16, 20);
            this._calendar.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this._calendar.MaxSelectionCount = 30;
            this._calendar.Name = "_calendar";
            this._calendar.ShowToday = false;
            this._calendar.TabIndex = 1;
            this._calendar.TitleBackColor = System.Drawing.SystemColors.ControlDark;
            this._calendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this._calendar_DateSelected);
            // 
            // _chkYesterday
            // 
            this._chkYesterday.AutoSize = true;
            this._chkYesterday.Location = new System.Drawing.Point(2, 175);
            this._chkYesterday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._chkYesterday.Name = "_chkYesterday";
            this._chkYesterday.Size = new System.Drawing.Size(73, 17);
            this._chkYesterday.TabIndex = 0;
            this._chkYesterday.Text = "Yesterday";
            this._chkYesterday.UseVisualStyleBackColor = true;
            // 
            // _chkEarlierThisWeek
            // 
            this._chkEarlierThisWeek.AutoSize = true;
            this._chkEarlierThisWeek.Location = new System.Drawing.Point(2, 209);
            this._chkEarlierThisWeek.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._chkEarlierThisWeek.Name = "_chkEarlierThisWeek";
            this._chkEarlierThisWeek.Size = new System.Drawing.Size(97, 17);
            this._chkEarlierThisWeek.TabIndex = 0;
            this._chkEarlierThisWeek.Text = "Earlier this year";
            this._chkEarlierThisWeek.UseVisualStyleBackColor = true;
            // 
            // _chkLastWeek
            // 
            this._chkLastWeek.AutoSize = true;
            this._chkLastWeek.Location = new System.Drawing.Point(2, 192);
            this._chkLastWeek.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._chkLastWeek.Name = "_chkLastWeek";
            this._chkLastWeek.Size = new System.Drawing.Size(75, 17);
            this._chkLastWeek.TabIndex = 0;
            this._chkLastWeek.Text = "Last week";
            this._chkLastWeek.UseVisualStyleBackColor = true;
            // 
            // _chkLongAgo
            // 
            this._chkLongAgo.AutoSize = true;
            this._chkLongAgo.Location = new System.Drawing.Point(2, 226);
            this._chkLongAgo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._chkLongAgo.Name = "_chkLongAgo";
            this._chkLongAgo.Size = new System.Drawing.Size(99, 17);
            this._chkLongAgo.TabIndex = 0;
            this._chkLongAgo.Text = "A long time ago";
            this._chkLongAgo.UseVisualStyleBackColor = true;
            // 
            // DateFilterEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this._chkCalendar);
            this.Controls.Add(this._calendar);
            this.Controls.Add(this._chkYesterday);
            this.Controls.Add(this._chkEarlierThisWeek);
            this.Controls.Add(this._chkLastWeek);
            this.Controls.Add(this._chkLongAgo);
            this.Name = "DateFilterEditor";
            this.Size = new System.Drawing.Size(250, 248);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox _chkCalendar;
        private System.Windows.Forms.MonthCalendar _calendar;
        private System.Windows.Forms.CheckBox _chkYesterday;
        private System.Windows.Forms.CheckBox _chkLastWeek;
        private System.Windows.Forms.CheckBox _chkEarlierThisWeek;
        private System.Windows.Forms.CheckBox _chkLongAgo;
    }
}

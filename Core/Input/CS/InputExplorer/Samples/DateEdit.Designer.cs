
using System;
using System.Drawing;

namespace InputExplorer.Samples
{
    partial class DateEdit
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
            components = new System.ComponentModel.Container();
            
            this.c1DateEdit1 = new C1.Win.Calendar.C1DateEdit();
            this.c1DateEdit2 = new C1.Win.Calendar.C1DateEdit();
            this.c1Label1 = new C1.Win.Input.C1Label();
            this.c1Label2 = new C1.Win.Input.C1Label();
            
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.SuspendLayout();

            // 
            // c1Label1
            // 
            this.c1Label1.Location = new System.Drawing.Point(7, 0);
            this.c1Label1.Name = "c1Label1";
            this.c1Label1.Size = new System.Drawing.Size(200, 25);
            this.c1Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.c1Label1.Text = "Default settings";

            // 
            // c1DateEdit1
            // 
            this.c1DateEdit1.Location = new System.Drawing.Point(7, 28);
            this.c1DateEdit1.Name = "c1DateEdit1";
            this.c1DateEdit1.Size = new System.Drawing.Size(170, 25);
            this.c1DateEdit1.TabIndex = 7;
            this.c1DateEdit1.CultureInfo = System.Globalization.CultureInfo.InvariantCulture;
            this.c1DateEdit1.Value = DateTime.Now;
            // 
            // c1Label2
            // 
            this.c1Label2.Location = new System.Drawing.Point(7, 65);
            this.c1Label2.Name = "c1Label2";
            this.c1Label2.Size = new System.Drawing.Size(200, 50);
            this.c1Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.c1Label2.Text = "Customize date and time format,\ncustomize editor and calendar view";

            // 
            // c1DateEdit2
            // 
            this.c1DateEdit2.Location = new System.Drawing.Point(7, 118);
            this.c1DateEdit2.Name = "c1DateEdit2";
            this.c1DateEdit2.Size = new System.Drawing.Size(170, 25);
            this.c1DateEdit2.TabIndex = 8;
            this.c1DateEdit2.CultureInfo = System.Globalization.CultureInfo.InvariantCulture;
            this.c1DateEdit2.Value = DateTime.Now;
            this.c1DateEdit2.DropDownAlign = C1.Framework.DropDownAlignment.Center;
            this.c1DateEdit2.GapHeight = -60;
            this.c1DateEdit2.CultureInfo = System.Globalization.CultureInfo.InvariantCulture;
            this.c1DateEdit2.Value = DateTime.Now;
            this.c1DateEdit2.DisplayFormat.FormatType = C1.Win.Input.FormatType.MonthAndDay;
            this.c1DateEdit2.EditFormat.FormatType = C1.Win.Input.FormatType.LongDateShortTime;
            
            this.c1DateEdit2.Calendar.TodayFormat = "&Current day: {}";
            this.c1DateEdit2.Calendar.CaptionFormat = "MM /yy";
            this.c1DateEdit2.Calendar.PeriodSelectionType = C1.CalendarView.SelectionType.List;
            this.c1DateEdit2.Calendar.DayTitlePosition = C1.CalendarView.Position.Left;
            this.c1DateEdit2.Calendar.CalendarDimensions = 2;
            this.c1DateEdit2.Styles.Editor.Focused.ForeColor = Color.Blue;
            this.c1DateEdit2.Styles.Calendar.Common.BackColor = Color.White;
            this.c1DateEdit2.Styles.Calendar.Day.Ordinary.ForeColor = Color.Black;
            this.c1DateEdit2.Styles.Calendar.Day.Weekend.ForeColor = Color.DarkGreen;
            this.c1DateEdit2.Styles.Calendar.Day.Weekend.BackColor = Color.LightGreen;
            this.c1DateEdit2.Styles.Calendar.Day.Bolded.ForeColor = Color.Blue;
            this.c1DateEdit2.Styles.Calendar.Day.Bolded.BackColor = Color.LightBlue;
            this.c1DateEdit2.Styles.Calendar.Day.Today.ForeColor = Color.Orange;
            this.c1DateEdit2.Styles.Calendar.Titles.Weekend.ForeColor = Color.DarkGreen;
            this.c1DateEdit2.Styles.Calendar.Titles.Weekend.BackColor = Color.LightGreen;
            this.c1DateEdit2.Styles.Calendar.Titles.Day.ForeColor = Color.Black;
            this.c1DateEdit2.Styles.Calendar.Titles.Day.Font = new Font("Segoue UI", 9, FontStyle.Bold);

            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Right;
            this.propertyGrid1.Location = new System.Drawing.Point(320, 0);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.SelectedObject = this.c1DateEdit1;
            this.propertyGrid1.Size = new System.Drawing.Size(350, 454);
            this.propertyGrid1.TabIndex = 6;

            // 
            // DateEdit
            // 
            this.Controls.Add(this.c1Label1);
            this.Controls.Add(this.c1DateEdit1);
            this.Controls.Add(this.c1Label2);
            this.Controls.Add(this.c1DateEdit2);
            this.Controls.Add(this.propertyGrid1);
            this.Name = "DateEdit";
            this.Size = new System.Drawing.Size(564, 600);
            this.ResumeLayout(false);
            this.AutoScaleDimensions = new System.Drawing.SizeF(96, 96);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        }

        #endregion
        private C1.Win.Input.C1Label c1Label1;
        private C1.Win.Calendar.C1DateEdit c1DateEdit1;
        private C1.Win.Input.C1Label c1Label2;
        private C1.Win.Calendar.C1DateEdit c1DateEdit2;
        private C1.Win.Input.C1Label c1Label3;
        private C1.Win.Calendar.C1DateEdit c1DateEdit3;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
    }
}

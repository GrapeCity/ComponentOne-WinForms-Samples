
using System.Drawing;

namespace InputExplorer.Samples
{
    partial class CalendarView
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
            
            this.c1CalendarView1 = new C1.Win.Calendar.C1CalendarView();
            this.c1CalendarView2 = new C1.Win.Calendar.C1CalendarView();
            this.c1Label1 = new C1.Win.Input.C1Label();
            this.c1Label2 = new C1.Win.Input.C1Label();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.SuspendLayout();

            // 
            // c1Label1
            // 
            this.c1Label1.Location = new Point(7, 0);
            this.c1Label1.Name = "c1Label1";
            this.c1Label1.Size = new Size(200, 50);
            this.c1Label1.TextAlign = ContentAlignment.MiddleLeft;
            this.c1Label1.Text = "Use local culture settings,\n set single or annual special dates, \nselect one or more days";

            // 
            // c1CalendarView1
            // 
            this.c1CalendarView1.Location = new Point(7, 53);
            this.c1CalendarView1.Name = "c1CalendarView1";
            this.c1CalendarView1.Size = new Size(210, 180);
            this.c1CalendarView1.TabIndex = 7;
            this.c1CalendarView1.ShowToday = false;
            this.c1CalendarView1.CurrentCulture = new System.Globalization.CultureInfo("ja-JP");
            this.c1CalendarView1.DisabledDates = disabledDates;
            this.c1CalendarView1.BoldedDates = bolderDates;
            this.c1CalendarView1.AnnuallyBoldedDates = annualyDates;
            this.c1CalendarView1.MaxSelectionCount = 5;
            this.c1CalendarView1.SelectionRule = C1.CalendarView.SelectionRule.EnumerationSameDay;

            // 
            // c1Label2
            // 
            this.c1Label2.Location = new Point(7, 245);
            this.c1Label2.Name = "c1Label2";
            this.c1Label2.Size = new Size(200, 25);
            this.c1Label2.TextAlign = ContentAlignment.MiddleLeft;
            this.c1Label2.Text = "Customize the calendar appearance";

            // 
            // c1CalendarView2
            // 
            this.c1CalendarView2.Location = new Point(7, 273);
            this.c1CalendarView2.Name = "c1CalendarView2";
            this.c1CalendarView2.Size = new Size(500, 200);
            this.c1CalendarView2.TabIndex = 8;
            this.c1CalendarView2.CalendarDimensions = 2;
            this.c1CalendarView2.ShowWeekNumbers = false;
            this.c1CalendarView2.ShowArrowButtons = false;
            this.c1CalendarView2.DisabledDates = disabledDates;
            this.c1CalendarView2.BoldedDates = bolderDates;
            this.c1CalendarView2.AnnuallyBoldedDates = annualyDates;
            this.c1CalendarView2.TodayFormat = "&Current day: {}";
            this.c1CalendarView2.CaptionFormat = "MM /yy";
            this.c1CalendarView2.PeriodSelectionType = C1.CalendarView.SelectionType.List;
            this.c1CalendarView2.DayTitlePosition = C1.CalendarView.Position.Left;
            this.c1CalendarView2.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            this.c1CalendarView2.Styles.Common.BackColor = Color.White;
            this.c1CalendarView2.Styles.Day.Ordinary.ForeColor = Color.Black;
            this.c1CalendarView2.Styles.Day.Weekend.ForeColor = Color.DarkGreen;
            this.c1CalendarView2.Styles.Day.Weekend.BackColor = Color.LightGreen;
            this.c1CalendarView2.Styles.Day.Bolded.ForeColor = Color.Blue;
            this.c1CalendarView2.Styles.Day.Bolded.BackColor = Color.LightBlue;
            this.c1CalendarView2.Styles.Day.Disabled.BackColor = Color.LightGray;
            this.c1CalendarView2.Styles.Day.Disabled.ForeColor = Color.DarkGray;
            this.c1CalendarView2.Styles.Day.Today.ForeColor = Color.Orange;
            this.c1CalendarView2.Styles.Titles.Weekend.ForeColor = Color.DarkGreen;
            this.c1CalendarView2.Styles.Titles.Weekend.BackColor = Color.LightGreen;
            this.c1CalendarView2.Styles.Titles.Day.ForeColor = Color.Black;
            this.c1CalendarView2.Styles.Titles.Day.Font = new Font("Segoue UI", 9, FontStyle.Bold);
            
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Anchor = System.Windows.Forms.AnchorStyles.Right|System.Windows.Forms.AnchorStyles.Top;
            this.propertyGrid1.Location = new Point(200, 0);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.SelectedObject = this.c1CalendarView1;
            this.propertyGrid1.Size = new Size(350, 260);
            this.propertyGrid1.TabIndex = 6;


            // 
            // CalendarView
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.c1Label1);
            this.Controls.Add(this.c1CalendarView1);
            this.Controls.Add(this.c1Label2);
            this.Controls.Add(this.c1CalendarView2);
            this.Controls.Add(this.propertyGrid1);
            this.Name = "CalendarView";
            this.Size = new Size(564, 600);
            this.ResumeLayout(false);

        }

        #endregion

      
        private C1.Win.Input.C1Label c1Label1;
        private C1.Win.Calendar.C1CalendarView c1CalendarView1;
        private C1.Win.Input.C1Label c1Label2;
        private C1.Win.Calendar.C1CalendarView c1CalendarView2;  
        private System.Windows.Forms.PropertyGrid propertyGrid1;
    }
}

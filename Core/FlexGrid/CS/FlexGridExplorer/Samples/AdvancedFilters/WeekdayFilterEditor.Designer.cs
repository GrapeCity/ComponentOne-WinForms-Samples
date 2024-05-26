using System.Windows.Forms;

namespace FlexGridExplorer.Samples.AdvancedFilters
{
    partial class WeekdayFilterEditor
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
            chkSun = new CheckBox();
            chkSat = new CheckBox();
            chkFri = new CheckBox();
            chkThu = new CheckBox();
            chkWed = new CheckBox();
            chkTue = new CheckBox();
            chkMon = new CheckBox();
            SuspendLayout();
            // 
            // chkSun
            // 
            chkSun.AutoSize = true;
            chkSun.Location = new System.Drawing.Point(12, 121);
            chkSun.Margin = new Padding(2, 2, 2, 2);
            chkSun.Name = "chkSun";
            chkSun.Size = new System.Drawing.Size(65, 19);
            chkSun.TabIndex = 13;
            chkSun.Text = "Sunday";
            chkSun.UseVisualStyleBackColor = true;
            // 
            // chkSat
            // 
            chkSat.AutoSize = true;
            chkSat.Location = new System.Drawing.Point(12, 102);
            chkSat.Margin = new Padding(2, 2, 2, 2);
            chkSat.Name = "chkSat";
            chkSat.Size = new System.Drawing.Size(72, 19);
            chkSat.TabIndex = 12;
            chkSat.Text = "Saturday";
            chkSat.UseVisualStyleBackColor = true;
            // 
            // chkFri
            // 
            chkFri.AutoSize = true;
            chkFri.Location = new System.Drawing.Point(12, 84);
            chkFri.Margin = new Padding(2, 2, 2, 2);
            chkFri.Name = "chkFri";
            chkFri.Size = new System.Drawing.Size(58, 19);
            chkFri.TabIndex = 11;
            chkFri.Text = "Friday";
            chkFri.UseVisualStyleBackColor = true;
            // 
            // chkThu
            // 
            chkThu.AutoSize = true;
            chkThu.Location = new System.Drawing.Point(12, 66);
            chkThu.Margin = new Padding(2, 2, 2, 2);
            chkThu.Name = "chkThu";
            chkThu.Size = new System.Drawing.Size(74, 19);
            chkThu.TabIndex = 10;
            chkThu.Text = "Thursday";
            chkThu.UseVisualStyleBackColor = true;
            // 
            // chkWed
            // 
            chkWed.AutoSize = true;
            chkWed.Location = new System.Drawing.Point(12, 47);
            chkWed.Margin = new Padding(2, 2, 2, 2);
            chkWed.Name = "chkWed";
            chkWed.Size = new System.Drawing.Size(87, 19);
            chkWed.TabIndex = 9;
            chkWed.Text = "Wednesday";
            chkWed.UseVisualStyleBackColor = true;
            // 
            // chkTue
            // 
            chkTue.AutoSize = true;
            chkTue.Location = new System.Drawing.Point(12, 29);
            chkTue.Margin = new Padding(2, 2, 2, 2);
            chkTue.Name = "chkTue";
            chkTue.Size = new System.Drawing.Size(69, 19);
            chkTue.TabIndex = 8;
            chkTue.Text = "Tuesday";
            chkTue.UseVisualStyleBackColor = true;
            // 
            // chkMon
            // 
            chkMon.AutoSize = true;
            chkMon.Location = new System.Drawing.Point(12, 10);
            chkMon.Margin = new Padding(2, 2, 2, 2);
            chkMon.Name = "chkMon";
            chkMon.Size = new System.Drawing.Size(70, 19);
            chkMon.TabIndex = 7;
            chkMon.Text = "Monday";
            chkMon.UseVisualStyleBackColor = true;
            // 
            // WeekdayFilterEditor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(chkSun);
            Controls.Add(chkSat);
            Controls.Add(chkFri);
            Controls.Add(chkThu);
            Controls.Add(chkWed);
            Controls.Add(chkTue);
            Controls.Add(chkMon);
            Margin = new Padding(2, 2, 2, 2);
            Name = "WeekdayFilterEditor";
            Size = new System.Drawing.Size(100, 151);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkSun;
        private CheckBox chkSat;
        private CheckBox chkFri;
        private CheckBox chkThu;
        private CheckBox chkWed;
        private CheckBox chkTue;
        private CheckBox chkMon;
    }
}

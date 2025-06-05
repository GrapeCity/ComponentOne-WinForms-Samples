using System.Windows.Forms;

namespace AdvancedFiltering
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
            this.chkSun = new System.Windows.Forms.CheckBox();
            this.chkSat = new System.Windows.Forms.CheckBox();
            this.chkFri = new System.Windows.Forms.CheckBox();
            this.chkThu = new System.Windows.Forms.CheckBox();
            this.chkWed = new System.Windows.Forms.CheckBox();
            this.chkTue = new System.Windows.Forms.CheckBox();
            this.chkMon = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkSun
            // 
            this.chkSun.AutoSize = true;
            this.chkSun.Location = new System.Drawing.Point(15, 199);
            this.chkSun.Name = "chkSun";
            this.chkSun.Size = new System.Drawing.Size(70, 19);
            this.chkSun.TabIndex = 13;
            this.chkSun.Text = "Sunday";
            this.chkSun.UseVisualStyleBackColor = true;
            // 
            // chkSat
            // 
            this.chkSat.AutoSize = true;
            this.chkSat.Location = new System.Drawing.Point(15, 168);
            this.chkSat.Name = "chkSat";
            this.chkSat.Size = new System.Drawing.Size(77, 19);
            this.chkSat.TabIndex = 12;
            this.chkSat.Text = "Saturday";
            this.chkSat.UseVisualStyleBackColor = true;
            // 
            // chkFri
            // 
            this.chkFri.AutoSize = true;
            this.chkFri.Location = new System.Drawing.Point(15, 137);
            this.chkFri.Name = "chkFri";
            this.chkFri.Size = new System.Drawing.Size(62, 19);
            this.chkFri.TabIndex = 11;
            this.chkFri.Text = "Friday";
            this.chkFri.UseVisualStyleBackColor = true;
            // 
            // chkThu
            // 
            this.chkThu.AutoSize = true;
            this.chkThu.Location = new System.Drawing.Point(15, 106);
            this.chkThu.Name = "chkThu";
            this.chkThu.Size = new System.Drawing.Size(79, 19);
            this.chkThu.TabIndex = 10;
            this.chkThu.Text = "Thursday";
            this.chkThu.UseVisualStyleBackColor = true;
            // 
            // chkWed
            // 
            this.chkWed.AutoSize = true;
            this.chkWed.Location = new System.Drawing.Point(15, 75);
            this.chkWed.Name = "chkWed";
            this.chkWed.Size = new System.Drawing.Size(93, 19);
            this.chkWed.TabIndex = 9;
            this.chkWed.Text = "Wednesday";
            this.chkWed.UseVisualStyleBackColor = true;
            // 
            // chkTue
            // 
            this.chkTue.AutoSize = true;
            this.chkTue.Location = new System.Drawing.Point(15, 44);
            this.chkTue.Name = "chkTue";
            this.chkTue.Size = new System.Drawing.Size(75, 19);
            this.chkTue.TabIndex = 8;
            this.chkTue.Text = "Tuesday";
            this.chkTue.UseVisualStyleBackColor = true;
            // 
            // chkMon
            // 
            this.chkMon.AutoSize = true;
            this.chkMon.Location = new System.Drawing.Point(15, 13);
            this.chkMon.Name = "chkMon";
            this.chkMon.Size = new System.Drawing.Size(73, 19);
            this.chkMon.TabIndex = 7;
            this.chkMon.Text = "Monday";
            this.chkMon.UseVisualStyleBackColor = true;
            // 
            // WeekdayFilterEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.chkSun);
            this.Controls.Add(this.chkSat);
            this.Controls.Add(this.chkFri);
            this.Controls.Add(this.chkThu);
            this.Controls.Add(this.chkWed);
            this.Controls.Add(this.chkTue);
            this.Controls.Add(this.chkMon);
            this.Name = "WeekdayFilterEditor";
            this.Size = new System.Drawing.Size(125, 230);
            this.ResumeLayout(false);
            this.PerformLayout();

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

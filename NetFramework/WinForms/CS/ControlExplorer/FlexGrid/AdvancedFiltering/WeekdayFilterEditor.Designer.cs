using System.Windows.Forms;

namespace ControlExplorer.FlexGrid.AdvancedFiltering
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
            components = new System.ComponentModel.Container();
            this.chkSun = new System.Windows.Forms.CheckBox();
            this.chkSat = new System.Windows.Forms.CheckBox();
            this.chkFri = new System.Windows.Forms.CheckBox();
            this.chkThu = new System.Windows.Forms.CheckBox();
            this.chkWed = new System.Windows.Forms.CheckBox();
            this.chkTue = new System.Windows.Forms.CheckBox();
            this.chkMon = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkSO
            // 
            this.chkSun.AutoSize = true;
            this.chkSun.Location = new System.Drawing.Point(15, 151);
            this.chkSun.Name = "chkSun";
            this.chkSun.Size = new System.Drawing.Size(62, 17);
            this.chkSun.TabIndex = 13;
            this.chkSun.Text = "Sunday";
            this.chkSun.UseVisualStyleBackColor = true;
            // 
            // chkSA
            // 
            this.chkSat.AutoSize = true;
            this.chkSat.Location = new System.Drawing.Point(15, 128);
            this.chkSat.Name = "chkSat";
            this.chkSat.Size = new System.Drawing.Size(68, 17);
            this.chkSat.TabIndex = 12;
            this.chkSat.Text = "Saturday";
            this.chkSat.UseVisualStyleBackColor = true;
            // 
            // chkFR
            // 
            this.chkFri.AutoSize = true;
            this.chkFri.Location = new System.Drawing.Point(15, 105);
            this.chkFri.Name = "chkFri";
            this.chkFri.Size = new System.Drawing.Size(54, 17);
            this.chkFri.TabIndex = 11;
            this.chkFri.Text = "Friday";
            this.chkFri.UseVisualStyleBackColor = true;
            // 
            // chkTH
            // 
            this.chkThu.AutoSize = true;
            this.chkThu.Location = new System.Drawing.Point(15, 82);
            this.chkThu.Name = "chkThu";
            this.chkThu.Size = new System.Drawing.Size(70, 17);
            this.chkThu.TabIndex = 10;
            this.chkThu.Text = "Thursday";
            this.chkThu.UseVisualStyleBackColor = true;
            // 
            // chkWED
            // 
            this.chkWed.AutoSize = true;
            this.chkWed.Location = new System.Drawing.Point(15, 59);
            this.chkWed.Name = "chkWed";
            this.chkWed.Size = new System.Drawing.Size(83, 17);
            this.chkWed.TabIndex = 9;
            this.chkWed.Text = "Wednesday";
            this.chkWed.UseVisualStyleBackColor = true;
            // 
            // chkTU
            // 
            this.chkTue.AutoSize = true;
            this.chkTue.Location = new System.Drawing.Point(15, 36);
            this.chkTue.Name = "chkTue";
            this.chkTue.Size = new System.Drawing.Size(67, 17);
            this.chkTue.TabIndex = 8;
            this.chkTue.Text = "Tuesday";
            this.chkTue.UseVisualStyleBackColor = true;
            // 
            // chkMO
            // 
            this.chkMon.AutoSize = true;
            this.chkMon.Location = new System.Drawing.Point(15, 13);
            this.chkMon.Name = "chkMon";
            this.chkMon.Size = new System.Drawing.Size(64, 17);
            this.chkMon.TabIndex = 7;
            this.chkMon.Text = "Monday";
            this.chkMon.UseVisualStyleBackColor = true;
            // 
            // WeekdayFilterEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkSun);
            this.Controls.Add(this.chkSat);
            this.Controls.Add(this.chkFri);
            this.Controls.Add(this.chkThu);
            this.Controls.Add(this.chkWed);
            this.Controls.Add(this.chkTue);
            this.Controls.Add(this.chkMon);
            this.Name = "WeekdayFilterEditor";
            this.Size = new System.Drawing.Size(125, 189);
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

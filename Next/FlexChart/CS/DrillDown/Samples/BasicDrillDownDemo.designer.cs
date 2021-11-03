using System.Drawing;
using System.Windows.Forms;

namespace DrillDown.Samples
{
    partial class BasicDrillDownDemo
    {
        private C1.Win.Chart.FlexChart flexChart1;
        private ComboBox cbAggregateType;
        private ComboBox cbChartType;
        private ComboBox cbGroupBy;
        private CheckBox chkEnableDrill;
        private C1.Win.Chart.FlexPie flexPie1;
        private FlowLayoutPanel pnlNavBar;

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
            this.baseSample1 = new BaseSample();
            this.SuspendLayout();
            // 
            // baseSample1
            // 
            this.baseSample1.Dock = DockStyle.Fill;
            this.baseSample1.Font = new Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.baseSample1.Location = new Point(0, 0);
            this.baseSample1.Name = "baseSample1";
            this.baseSample1.Size = new Size(815, 551);
            this.baseSample1.TabIndex = 0;
            // 
            // Introduction
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            this.Controls.Add(this.baseSample1);
            this.Font = new Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = Color.LightGray;
            this.Name = "Introduction";
            this.Size = new Size(815, 551);

            this.ResumeLayout(false);
        }

        #endregion

        private BaseSample baseSample1;

    }
}

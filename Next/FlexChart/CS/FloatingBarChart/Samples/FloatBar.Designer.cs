using C1.Win.Chart;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace FloatingBarChart.Samples
{
    partial class FloatBar
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private FlexChart flexChart1;

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
            this.baseSample1 = new FloatingBarChart.Samples.BaseSample();
            this.SuspendLayout();
            // 
            // baseSample1
            // 
            this.baseSample1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseSample1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.baseSample1.Location = new System.Drawing.Point(0, 0);
            this.baseSample1.Name = "baseSample1";
            this.baseSample1.Size = new System.Drawing.Size(815, 551);
            this.baseSample1.TabIndex = 0;
            // 
            // Introduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.baseSample1);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Name = "Introduction";
            this.Size = new System.Drawing.Size(815, 551);

            this.ResumeLayout(false);

        }

        #endregion

        private BaseSample baseSample1;

    }
}

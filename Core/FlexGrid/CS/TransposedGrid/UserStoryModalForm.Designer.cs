﻿namespace TransposedGrid
{
    partial class UserStoryModalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserStoryModalForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            label7 = new Label();
            label9 = new Label();
            label6 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(20, 37);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(879, 50);
            label1.TabIndex = 0;
            label1.Text = "Simplify Analysis Through FlexGrid Transposition";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(20, 152);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(160, 40);
            label2.TabIndex = 1;
            label2.Text = "User Story:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(28, 117);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(1060, 2);
            label3.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 210);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.MaximumSize = new Size(1056, 160);
            label5.Name = "label5";
            label5.Size = new Size(1049, 64);
            label5.TabIndex = 7;
            label5.Text = "As a stakeholder or analyst reviewing the performance report for Dragon Group of Hotels, I want the data to be transposed, So that the analysis becomes more comprehensible and actionable. ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(14, 322);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(205, 40);
            label4.TabIndex = 8;
            label4.Text = "Problem Story";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 523);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.MaximumSize = new Size(1056, 160);
            label7.Name = "label7";
            label7.Size = new Size(0, 32);
            label7.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(20, 395);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.MaximumSize = new Size(1056, 160);
            label9.Name = "label9";
            label9.Size = new Size(1035, 128);
            label9.TabIndex = 12;
            label9.Text = resources.GetString("label9.Text");
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 650);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.MaximumSize = new Size(1056, 160);
            label6.Name = "label6";
            label6.Size = new Size(1047, 128);
            label6.TabIndex = 13;
            label6.Text = resources.GetString("label6.Text");
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlDarkDark;
            label8.Location = new Point(20, 578);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(264, 40);
            label8.TabIndex = 14;
            label8.Text = "Benefit Hypothesis";
            // 
            // UserStoryModalForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 816);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(5);
            Name = "UserStoryModalForm";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Story for FlexGrid Transpose";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label7;
        private Label label9;
        private Label label6;
        private Label label8;
    }
}
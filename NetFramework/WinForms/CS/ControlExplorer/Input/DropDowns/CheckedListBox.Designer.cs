﻿namespace ControlExplorer.Input.DropDowns
{
    partial class CheckedListBox
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.IntegralHeight = false;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Comprehensive",
            "Liability",
            "Collision",
            "Extra Options"});
            this.checkedListBox1.Location = new System.Drawing.Point(0, 0);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(102, 64);
            this.checkedListBox1.TabIndex = 0;
            // 
            // CheckedListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(102, 64);
            this.Controls.Add(this.checkedListBox1);
            this.MinimumSize = new System.Drawing.Size(100, 0);
            this.Name = "CheckedListBox";
            this.Options = ((C1.Win.C1Input.DropDownFormOptionsFlags)(((C1.Win.C1Input.DropDownFormOptionsFlags.Focusable | C1.Win.C1Input.DropDownFormOptionsFlags.AlwaysPostChanges)
                        | C1.Win.C1Input.DropDownFormOptionsFlags.AutoResize)));
            this.Text = "CheckedListBox";
            this.Open += new System.EventHandler(this.CheckedListBox_Open);
            this.PostChanges += new System.EventHandler(this.CheckedListBox_PostChanges);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}
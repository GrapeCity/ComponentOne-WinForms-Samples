namespace InputExplorer.Samples.DropDowns
{
    partial class CheckedList
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
            checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            checkedListBox1.CheckOnClick = true;
            checkedListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.IntegralHeight = false;
            checkedListBox1.Items.AddRange(new object[] { "Comprehensive", "Liability", "Collision", "Extra Options" });
            checkedListBox1.Location = new System.Drawing.Point(0, 0);
            checkedListBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new System.Drawing.Size(173, 128);
            checkedListBox1.TabIndex = 0;
            checkedListBox1.SelectedIndexChanged += this.checkedListBox1_SelectedIndexChanged;
            // 
            // CheckedList
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(checkedListBox1);
            Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            MinimumSize = new System.Drawing.Size(167, 0);
            Name = "CheckedList";
            Size = new System.Drawing.Size(173, 128);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;

    }
}

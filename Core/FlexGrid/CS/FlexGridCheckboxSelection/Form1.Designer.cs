namespace FlexGridCheckboxSelection
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
            c1FlexGrid1 = new C1FlexGrid();
            txtSelectedCount = new RichTextBox();
            cbHeaderCol = new C1.Win.Input.C1CheckBox();
            cbGroupedData = new C1.Win.Input.C1CheckBox();
            panel1 = new DashedBorderPanel();
            ((ISupportInitialize)c1FlexGrid1).BeginInit();
            ((ISupportInitialize)cbHeaderCol).BeginInit();
            ((ISupportInitialize)cbGroupedData).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // c1FlexGrid1
            // 
            c1FlexGrid1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            c1FlexGrid1.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            c1FlexGrid1.Location = new Point(27, 143);
            c1FlexGrid1.Margin = new Padding(4, 5, 4, 5);
            c1FlexGrid1.Name = "c1FlexGrid1";
            c1FlexGrid1.Size = new Size(1172, 773);
            c1FlexGrid1.TabIndex = 0;
            c1FlexGrid1.AfterSelChange += c1FlexGrid1_AfterSelChange;
            // 
            // txtSelectedCount
            // 
            txtSelectedCount.BackColor = SystemColors.Control;
            txtSelectedCount.BorderStyle = BorderStyle.None;
            txtSelectedCount.Location = new Point(27, 87);
            txtSelectedCount.Margin = new Padding(4, 5, 4, 5);
            txtSelectedCount.Name = "txtSelectedCount";
            txtSelectedCount.ReadOnly = true;
            txtSelectedCount.Size = new Size(886, 47);
            txtSelectedCount.TabIndex = 8;
            txtSelectedCount.Text = "";
            // 
            // cbHeaderCol
            // 
            cbHeaderCol.AutoSize = true;
            cbHeaderCol.Checked = true;
            cbHeaderCol.CheckState = CheckState.Checked;
            cbHeaderCol.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbHeaderCol.Location = new Point(207, 38);
            cbHeaderCol.Name = "cbHeaderCol";
            cbHeaderCol.RightToLeft = RightToLeft.Yes;
            cbHeaderCol.Size = new Size(27, 27);
            cbHeaderCol.TabIndex = 9;
            cbHeaderCol.Value = true;
            cbHeaderCol.CheckedChanged += cbHeaderCol_CheckedChanged;
            // 
            // cbGroupedData
            // 
            cbGroupedData.AutoSize = true;
            cbGroupedData.Checked = true;
            cbGroupedData.CheckState = CheckState.Checked;
            cbGroupedData.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbGroupedData.Location = new Point(23, 38);
            cbGroupedData.Name = "cbGroupedData";
            cbGroupedData.RightToLeft = RightToLeft.Yes;
            cbGroupedData.Size = new Size(27, 27);
            cbGroupedData.TabIndex = 10;
            cbGroupedData.Value = true;
            cbGroupedData.CheckedChanged += cbGroupedData_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(cbGroupedData);
            panel1.Controls.Add(cbHeaderCol);
            panel1.Controls.Add(txtSelectedCount);
            panel1.Controls.Add(c1FlexGrid1);
            panel1.Location = new Point(77, 61);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1229, 969);
            panel1.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1383, 1065);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(1396, 1093);
            Name = "Form1";
            Load += Form1_Load;
            ((ISupportInitialize)c1FlexGrid1).EndInit();
            ((ISupportInitialize)cbHeaderCol).EndInit();
            ((ISupportInitialize)cbGroupedData).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private C1.Win.FlexGrid.C1FlexGrid c1FlexGrid1;
        private RichTextBox txtSelectedCount;
        private C1.Win.Input.C1CheckBox cbHeaderCol;
        private C1.Win.Input.C1CheckBox cbGroupedData;
        private DashedBorderPanel panel1;
    }
}

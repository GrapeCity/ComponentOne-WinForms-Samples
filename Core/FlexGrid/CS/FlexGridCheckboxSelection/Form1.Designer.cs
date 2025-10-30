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
            lblDesc = new C1.Win.Input.C1Label();
            txtSelectedCount = new RichTextBox();
            cbHeaderCol = new C1.Win.Input.C1CheckBox();
            cbGroupedData = new C1.Win.Input.C1CheckBox();
            panel1 = new DashedBorderPanel();
            ((ISupportInitialize)c1FlexGrid1).BeginInit();
            ((ISupportInitialize)lblDesc).BeginInit();
            ((ISupportInitialize)cbHeaderCol).BeginInit();
            ((ISupportInitialize)cbGroupedData).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // c1FlexGrid1
            // 
            c1FlexGrid1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            c1FlexGrid1.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            c1FlexGrid1.Location = new Point(19, 86);
            c1FlexGrid1.Name = "c1FlexGrid1";
            c1FlexGrid1.Size = new Size(821, 380);
            c1FlexGrid1.TabIndex = 0;
            c1FlexGrid1.AfterSelChange += c1FlexGrid1_AfterSelChange;
            // 
            // lblDesc
            // 
            lblDesc.Location = new Point(54, 41);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(860, 59);
            lblDesc.TabIndex = 7;
            lblDesc.Text = "c1Label1";
            // 
            // txtSelectedCount
            // 
            txtSelectedCount.BackColor = SystemColors.Control;
            txtSelectedCount.BorderStyle = BorderStyle.None;
            txtSelectedCount.Location = new Point(19, 52);
            txtSelectedCount.Name = "txtSelectedCount";
            txtSelectedCount.ReadOnly = true;
            txtSelectedCount.Size = new Size(620, 28);
            txtSelectedCount.TabIndex = 8;
            txtSelectedCount.Text = "";
            // 
            // cbHeaderCol
            // 
            cbHeaderCol.AutoSize = true;
            cbHeaderCol.Checked = true;
            cbHeaderCol.CheckState = CheckState.Checked;
            cbHeaderCol.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbHeaderCol.Location = new Point(145, 23);
            cbHeaderCol.Name = "cbHeaderCol";
            cbHeaderCol.RightToLeft = RightToLeft.Yes;
            cbHeaderCol.Size = new Size(19, 19);
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
            cbGroupedData.Location = new Point(16, 23);
            cbGroupedData.Name = "cbGroupedData";
            cbGroupedData.RightToLeft = RightToLeft.Yes;
            cbGroupedData.Size = new Size(19, 19);
            cbGroupedData.TabIndex = 10;
            cbGroupedData.Value = true;
            cbGroupedData.CheckedChanged += cbGroupedData_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderColor = Color.Gray;
            panel1.BorderDashStyle = DashStyle.Dash;
            panel1.BorderThickness = 1.5F;
            panel1.Controls.Add(cbGroupedData);
            panel1.Controls.Add(cbHeaderCol);
            panel1.Controls.Add(txtSelectedCount);
            panel1.Controls.Add(c1FlexGrid1);
            panel1.Location = new Point(54, 121);
            panel1.Name = "panel1";
            panel1.Size = new Size(860, 497);
            panel1.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 639);
            Controls.Add(lblDesc);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(984, 678);
            Name = "Form1";
            Load += Form1_Load;
            ((ISupportInitialize)c1FlexGrid1).EndInit();
            ((ISupportInitialize)lblDesc).EndInit();
            ((ISupportInitialize)cbHeaderCol).EndInit();
            ((ISupportInitialize)cbGroupedData).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private C1.Win.FlexGrid.C1FlexGrid c1FlexGrid1;
        private C1.Win.Input.C1Label lblDesc;
        private RichTextBox txtSelectedCount;
        private C1.Win.Input.C1CheckBox cbHeaderCol;
        private C1.Win.Input.C1CheckBox cbGroupedData;
        private DashedBorderPanel panel1;
    }
}

namespace CVForm
{
    partial class CVForm
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
            this.lCheckList = new C1.Win.Input.C1CheckList();
            this.flGroupBox = new System.Windows.Forms.GroupBox();
            this.fnTextBox = new C1.Win.C1Input.C1TextBox();
            this.lnTextBox = new C1.Win.C1Input.C1TextBox();
            this.basicGroupBox = new System.Windows.Forms.GroupBox();
            this.aLabel = new C1.Win.C1Input.C1Label();
            this.aNumericEdit = new C1.Win.C1Input.C1NumericEdit();
            this.tlp = new System.Windows.Forms.TableLayoutPanel();
            this.amGroupBox = new System.Windows.Forms.GroupBox();
            this.amRichTextBox = new System.Windows.Forms.RichTextBox();
            this.skillsGroupBox = new System.Windows.Forms.GroupBox();
            this.skillsCheckList = new C1.Win.Input.C1CheckList();
            this.flGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fnTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnTextBox)).BeginInit();
            this.basicGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNumericEdit)).BeginInit();
            this.tlp.SuspendLayout();
            this.amGroupBox.SuspendLayout();
            this.skillsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lCheckList
            // 
            this.lCheckList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lCheckList.Location = new System.Drawing.Point(3, 17);
            this.lCheckList.Name = "lCheckList";
            this.lCheckList.Size = new System.Drawing.Size(276, 194);
            this.lCheckList.TabIndex = 0;
            this.lCheckList.Text = "c1CheckList1";
            // 
            // flGroupBox
            // 
            this.flGroupBox.Controls.Add(this.lCheckList);
            this.flGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flGroupBox.Location = new System.Drawing.Point(3, 322);
            this.flGroupBox.Name = "flGroupBox";
            this.flGroupBox.Size = new System.Drawing.Size(282, 214);
            this.flGroupBox.TabIndex = 1;
            this.flGroupBox.TabStop = false;
            this.flGroupBox.Text = "Languages";
            // 
            // fnTextBox
            // 
            this.fnTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fnTextBox.DisplayFormat.EmptyAsNull = true;
            this.fnTextBox.DisplayFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType | C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) 
            | C1.Win.C1Input.FormatInfoInheritFlags.CalendarType)));
            this.fnTextBox.DisplayFormat.NullText = "First Name";
            this.fnTextBox.Location = new System.Drawing.Point(6, 19);
            this.fnTextBox.Name = "fnTextBox";
            this.fnTextBox.Size = new System.Drawing.Size(270, 19);
            this.fnTextBox.TabIndex = 2;
            this.fnTextBox.Tag = null;
            // 
            // lnTextBox
            // 
            this.lnTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnTextBox.DisplayFormat.EmptyAsNull = true;
            this.lnTextBox.DisplayFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType | C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) 
            | C1.Win.C1Input.FormatInfoInheritFlags.CalendarType)));
            this.lnTextBox.DisplayFormat.NullText = "Last Name";
            this.lnTextBox.Location = new System.Drawing.Point(6, 43);
            this.lnTextBox.Name = "lnTextBox";
            this.lnTextBox.Size = new System.Drawing.Size(270, 19);
            this.lnTextBox.TabIndex = 3;
            this.lnTextBox.Tag = null;
            // 
            // basicGroupBox
            // 
            this.basicGroupBox.Controls.Add(this.aLabel);
            this.basicGroupBox.Controls.Add(this.aNumericEdit);
            this.basicGroupBox.Controls.Add(this.fnTextBox);
            this.basicGroupBox.Controls.Add(this.lnTextBox);
            this.basicGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.basicGroupBox.Location = new System.Drawing.Point(3, 3);
            this.basicGroupBox.Name = "basicGroupBox";
            this.basicGroupBox.Size = new System.Drawing.Size(282, 94);
            this.basicGroupBox.TabIndex = 4;
            this.basicGroupBox.TabStop = false;
            // 
            // aLabel
            // 
            this.aLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aLabel.Location = new System.Drawing.Point(6, 69);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(51, 13);
            this.aLabel.TabIndex = 5;
            this.aLabel.Tag = null;
            this.aLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.aLabel.Value = "Age:";
            // 
            // aNumericEdit
            // 
            this.aNumericEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aNumericEdit.ImagePadding = new System.Windows.Forms.Padding(0);
            this.aNumericEdit.Location = new System.Drawing.Point(63, 67);
            this.aNumericEdit.Name = "aNumericEdit";
            this.aNumericEdit.Size = new System.Drawing.Size(213, 19);
            this.aNumericEdit.TabIndex = 4;
            this.aNumericEdit.Tag = null;
            this.aNumericEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.aNumericEdit.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.aNumericEdit.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.UpDown;
            // 
            // tlp
            // 
            this.tlp.ColumnCount = 2;
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp.Controls.Add(this.skillsGroupBox, 0, 1);
            this.tlp.Controls.Add(this.amGroupBox, 1, 0);
            this.tlp.Controls.Add(this.flGroupBox, 0, 2);
            this.tlp.Controls.Add(this.basicGroupBox, 0, 0);
            this.tlp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp.Location = new System.Drawing.Point(0, 0);
            this.tlp.Name = "tlp";
            this.tlp.RowCount = 3;
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp.Size = new System.Drawing.Size(576, 539);
            this.tlp.TabIndex = 5;
            // 
            // amGroupBox
            // 
            this.amGroupBox.Controls.Add(this.amRichTextBox);
            this.amGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.amGroupBox.Location = new System.Drawing.Point(291, 3);
            this.amGroupBox.Name = "amGroupBox";
            this.tlp.SetRowSpan(this.amGroupBox, 3);
            this.amGroupBox.Size = new System.Drawing.Size(282, 533);
            this.amGroupBox.TabIndex = 6;
            this.amGroupBox.TabStop = false;
            this.amGroupBox.Text = "About me";
            // 
            // amRichTextBox
            // 
            this.amRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.amRichTextBox.Location = new System.Drawing.Point(3, 17);
            this.amRichTextBox.Name = "amRichTextBox";
            this.amRichTextBox.Size = new System.Drawing.Size(276, 513);
            this.amRichTextBox.TabIndex = 0;
            this.amRichTextBox.Text = "";
            // 
            // skillsGroupBox
            // 
            this.skillsGroupBox.Controls.Add(this.skillsCheckList);
            this.skillsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skillsGroupBox.Location = new System.Drawing.Point(3, 103);
            this.skillsGroupBox.Name = "skillsGroupBox";
            this.skillsGroupBox.Size = new System.Drawing.Size(282, 213);
            this.skillsGroupBox.TabIndex = 1;
            this.skillsGroupBox.TabStop = false;
            this.skillsGroupBox.Text = "Skills";
            // 
            // skillsCheckList
            // 
            this.skillsCheckList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skillsCheckList.Location = new System.Drawing.Point(3, 17);
            this.skillsCheckList.Name = "skillsCheckList";
            this.skillsCheckList.Size = new System.Drawing.Size(276, 193);
            this.skillsCheckList.TabIndex = 1;
            this.skillsCheckList.Text = "c1CheckList1";
            // 
            // CVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 539);
            this.Controls.Add(this.tlp);
            this.Name = "CVForm";
            this.Text = "CV";
            this.flGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fnTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnTextBox)).EndInit();
            this.basicGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNumericEdit)).EndInit();
            this.tlp.ResumeLayout(false);
            this.amGroupBox.ResumeLayout(false);
            this.skillsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.Input.C1CheckList lCheckList;
        private System.Windows.Forms.GroupBox flGroupBox;
        private C1.Win.C1Input.C1TextBox fnTextBox;
        private C1.Win.C1Input.C1TextBox lnTextBox;
        private System.Windows.Forms.GroupBox basicGroupBox;
        private C1.Win.C1Input.C1Label aLabel;
        private C1.Win.C1Input.C1NumericEdit aNumericEdit;
        private System.Windows.Forms.TableLayoutPanel tlp;
        private System.Windows.Forms.GroupBox amGroupBox;
        private System.Windows.Forms.RichTextBox amRichTextBox;
        private System.Windows.Forms.GroupBox skillsGroupBox;
        private C1.Win.Input.C1CheckList skillsCheckList;
    }
}


// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

namespace MultiSelectExplorer.Samples.Designer
{
    partial class DesignerControl
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
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            pnlMain = new System.Windows.Forms.Panel();
            btnConfirmSelection = new C1.Win.Input.C1Button();
            _multiSelect = new C1.Win.Input.C1MultiSelect();
            lblMultiSelectMemberTitle = new C1.Win.Input.C1Label();
            btnResetEventControl = new C1.Win.Input.C1Button();
            propertyGridMultiSelect = new System.Windows.Forms.PropertyGrid();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnConfirmSelection).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_multiSelect).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lblMultiSelectMemberTitle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnResetEventControl).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Location = new System.Drawing.Point(0, 0);
            splitContainer1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(pnlMain);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(propertyGridMultiSelect);
            splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            splitContainer1.Size = new System.Drawing.Size(1332, 825);
            splitContainer1.SplitterDistance = 882;
            splitContainer1.SplitterWidth = 6;
            splitContainer1.TabIndex = 0;
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(btnConfirmSelection);
            pnlMain.Controls.Add(_multiSelect);
            pnlMain.Controls.Add(lblMultiSelectMemberTitle);
            pnlMain.Controls.Add(btnResetEventControl);
            pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlMain.Location = new System.Drawing.Point(0, 0);
            pnlMain.Margin = new System.Windows.Forms.Padding(2);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new System.Drawing.Size(882, 825);
            pnlMain.TabIndex = 5;
            // 
            // btnConfirmSelection
            // 
            btnConfirmSelection.Location = new System.Drawing.Point(450, 128);
            btnConfirmSelection.Name = "btnConfirmSelection";
            btnConfirmSelection.Size = new System.Drawing.Size(231, 58);
            btnConfirmSelection.Styles.Corners = new C1.Framework.Corners(1, 1, 1, 1);
            btnConfirmSelection.Styles.Default.BackColor = System.Drawing.SystemColors.Highlight;
            btnConfirmSelection.Styles.Default.BorderColor = System.Drawing.SystemColors.Highlight;
            btnConfirmSelection.Styles.Default.ForeColor = System.Drawing.Color.White;
            btnConfirmSelection.Styles.Hot.BackColor = System.Drawing.Color.FromArgb(30, 144, 235);
            btnConfirmSelection.Styles.HotPressed.BackColor = System.Drawing.Color.FromArgb(176, 226, 255);
            btnConfirmSelection.Styles.HotPressed.BorderColor = System.Drawing.Color.SkyBlue;
            btnConfirmSelection.TabIndex = 3;
            btnConfirmSelection.Text = "c1Button2";
            btnConfirmSelection.Click += btnConfirmSelection_Click;
            // 
            // _multiSelect
            // 
            _multiSelect.AutoSize = false;
            _multiSelect.Location = new System.Drawing.Point(15, 60);
            _multiSelect.Name = "_multiSelect";
            _multiSelect.Size = new System.Drawing.Size(666, 50);
            _multiSelect.Styles.DropDown.Corners = new C1.Framework.Corners(0, 0, 4, 4);
            _multiSelect.TabIndex = 1;
            // 
            // lblMultiSelectMemberTitle
            // 
            lblMultiSelectMemberTitle.AutoSize = true;
            lblMultiSelectMemberTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblMultiSelectMemberTitle.Location = new System.Drawing.Point(8, 18);
            lblMultiSelectMemberTitle.Name = "lblMultiSelectMemberTitle";
            lblMultiSelectMemberTitle.Size = new System.Drawing.Size(94, 33);
            lblMultiSelectMemberTitle.TabIndex = 4;
            lblMultiSelectMemberTitle.Text = "c1Label1";
            // 
            // btnResetEventControl
            // 
            btnResetEventControl.Location = new System.Drawing.Point(14, 128);
            btnResetEventControl.Name = "btnResetEventControl";
            btnResetEventControl.Size = new System.Drawing.Size(196, 58);
            btnResetEventControl.Styles.Corners = new C1.Framework.Corners(1, 1, 1, 1);
            btnResetEventControl.Styles.Default.BackColor = System.Drawing.Color.White;
            btnResetEventControl.Styles.Default.BorderColor = System.Drawing.SystemColors.Highlight;
            btnResetEventControl.Styles.Default.ForeColor = System.Drawing.SystemColors.Highlight;
            btnResetEventControl.Styles.Hot.BackColor = System.Drawing.SystemColors.Highlight;
            btnResetEventControl.Styles.Hot.ForeColor = System.Drawing.Color.White;
            btnResetEventControl.TabIndex = 2;
            btnResetEventControl.Text = "c1Button1";
            btnResetEventControl.Click += btnResetEventControl_Click;
            // 
            // propertyGridMultiSelect
            // 
            propertyGridMultiSelect.BackColor = System.Drawing.SystemColors.Control;
            propertyGridMultiSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            propertyGridMultiSelect.Location = new System.Drawing.Point(0, 25);
            propertyGridMultiSelect.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            propertyGridMultiSelect.Name = "propertyGridMultiSelect";
            propertyGridMultiSelect.SelectedObject = _multiSelect;
            propertyGridMultiSelect.Size = new System.Drawing.Size(444, 800);
            propertyGridMultiSelect.TabIndex = 0;
            propertyGridMultiSelect.PropertyValueChanged += propertyGridMultiSelect_PropertyValueChanged;
            // 
            // DesignerControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            Name = "DesignerControl";
            Size = new System.Drawing.Size(1332, 825);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnConfirmSelection).EndInit();
            ((System.ComponentModel.ISupportInitialize)_multiSelect).EndInit();
            ((System.ComponentModel.ISupportInitialize)lblMultiSelectMemberTitle).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnResetEventControl).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private C1.Win.Input.C1MultiSelect _multiSelect;
        private C1.Win.Input.C1Button btnConfirmSelection;
        private C1.Win.Input.C1Button btnResetEventControl;
        private C1.Win.Input.C1Label lblMultiSelectMemberTitle;
        private System.Windows.Forms.PropertyGrid propertyGridMultiSelect;
        private System.Windows.Forms.Panel pnlMain;
    }
}

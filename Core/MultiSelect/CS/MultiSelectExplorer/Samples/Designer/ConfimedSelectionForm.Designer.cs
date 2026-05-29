// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

namespace MultiSelectExplorer.Samples.Designer
{
    partial class ConfimedSelectionForm
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
            lblSelectedMemberTitle = new C1.Win.Input.C1Label();
            btnCancel = new C1.Win.Input.C1Button();
            btnAddMember = new C1.Win.Input.C1Button();
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)lblSelectedMemberTitle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCancel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAddMember).BeginInit();
            SuspendLayout();
            // 
            // lblSelectedMemberTitle
            // 
            lblSelectedMemberTitle.AutoSize = true;
            lblSelectedMemberTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblSelectedMemberTitle.Location = new System.Drawing.Point(30, 15);
            lblSelectedMemberTitle.Name = "lblSelectedMemberTitle";
            lblSelectedMemberTitle.Size = new System.Drawing.Size(62, 21);
            lblSelectedMemberTitle.TabIndex = 0;
            lblSelectedMemberTitle.Text = "c1Label1";
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(34, 103);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(88, 28);
            btnCancel.Styles.Corners = new C1.Framework.Corners(1, 1, 1, 1);
            btnCancel.Styles.Default.BackColor = System.Drawing.Color.White;
            btnCancel.Styles.Default.BorderColor = System.Drawing.SystemColors.Highlight;
            btnCancel.Styles.Default.ForeColor = System.Drawing.SystemColors.Highlight;
            btnCancel.Styles.Hot.BackColor = System.Drawing.SystemColors.Highlight;
            btnCancel.Styles.Hot.ForeColor = System.Drawing.Color.White;
            btnCancel.Styles.HotPressed.BackColor = System.Drawing.Color.FromArgb(30, 144, 235);
            btnCancel.Styles.HotPressed.BorderColor = System.Drawing.SystemColors.Highlight;
            btnCancel.Styles.HotPressed.ForeColor = System.Drawing.Color.White;
            btnCancel.TabIndex = 2;
            btnCancel.Text = "c1Button1";
            btnCancel.Click += btnAddMember_Click;
            // 
            // btnAddMember
            // 
            btnAddMember.Location = new System.Drawing.Point(161, 103);
            btnAddMember.Name = "btnAddMember";
            btnAddMember.Size = new System.Drawing.Size(88, 28);
            btnAddMember.Styles.Corners = new C1.Framework.Corners(1, 1, 1, 1);
            btnAddMember.Styles.Default.BackColor = System.Drawing.SystemColors.Highlight;
            btnAddMember.Styles.Default.BorderColor = System.Drawing.SystemColors.Highlight;
            btnAddMember.Styles.Default.ForeColor = System.Drawing.Color.White;
            btnAddMember.Styles.Hot.BackColor = System.Drawing.Color.FromArgb(30, 144, 235);
            btnAddMember.Styles.HotPressed.BackColor = System.Drawing.Color.FromArgb(30, 144, 235);
            btnAddMember.Styles.HotPressed.BorderColor = System.Drawing.SystemColors.Highlight;
            btnAddMember.TabIndex = 3;
            btnAddMember.Text = "c1Button2";
            btnAddMember.Click += btnConfirmSelection_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            richTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            richTextBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            richTextBox1.Location = new System.Drawing.Point(30, 51);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new System.Drawing.Size(219, 35);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // ConfimedSelectionForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(286, 158);
            Controls.Add(richTextBox1);
            Controls.Add(btnAddMember);
            Controls.Add(btnCancel);
            Controls.Add(lblSelectedMemberTitle);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            Name = "ConfimedSelectionForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "ConfimedSelectionForm";
            ((System.ComponentModel.ISupportInitialize)lblSelectedMemberTitle).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCancel).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAddMember).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private C1.Win.Input.C1Label lblSelectedMemberTitle;
        private C1.Win.Input.C1Button btnCancel;
        private C1.Win.Input.C1Button btnAddMember;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
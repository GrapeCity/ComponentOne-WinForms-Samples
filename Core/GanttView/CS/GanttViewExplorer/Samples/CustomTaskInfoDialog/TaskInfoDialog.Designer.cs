namespace CustomTaskInfoDialog
{
    partial class TaskInfoDialog
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            cbTask = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            tbTaskName = new System.Windows.Forms.TextBox();
            tbResource = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            tbStart = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            tbDuration = new System.Windows.Forms.TextBox();
            tbPercentComplete = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(13, 67);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(90, 20);
            label1.TabIndex = 0;
            label1.Text = "Task Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(13, 96);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(77, 20);
            label2.TabIndex = 0;
            label2.Text = "Resource:";
            // 
            // cbTask
            // 
            cbTask.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbTask.FormattingEnabled = true;
            cbTask.Location = new System.Drawing.Point(91, 12);
            cbTask.Name = "cbTask";
            cbTask.Size = new System.Drawing.Size(209, 28);
            cbTask.TabIndex = 1;
            cbTask.SelectedIndexChanged += cbTask_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(13, 20);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(45, 20);
            label3.TabIndex = 2;
            label3.Text = "Task:";
            // 
            // tbTaskName
            // 
            tbTaskName.Location = new System.Drawing.Point(91, 59);
            tbTaskName.Name = "tbTaskName";
            tbTaskName.ReadOnly = true;
            tbTaskName.Size = new System.Drawing.Size(209, 27);
            tbTaskName.TabIndex = 3;
            // 
            // tbResource
            // 
            tbResource.Location = new System.Drawing.Point(91, 88);
            tbResource.Name = "tbResource";
            tbResource.ReadOnly = true;
            tbResource.Size = new System.Drawing.Size(209, 27);
            tbResource.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(13, 126);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(47, 20);
            label4.TabIndex = 0;
            label4.Text = "Start:";
            // 
            // tbStart
            // 
            tbStart.Location = new System.Drawing.Point(91, 118);
            tbStart.Name = "tbStart";
            tbStart.ReadOnly = true;
            tbStart.Size = new System.Drawing.Size(209, 27);
            tbStart.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(12, 153);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(75, 20);
            label5.TabIndex = 0;
            label5.Text = "Duration:";
            // 
            // tbDuration
            // 
            tbDuration.Location = new System.Drawing.Point(91, 147);
            tbDuration.Name = "tbDuration";
            tbDuration.ReadOnly = true;
            tbDuration.Size = new System.Drawing.Size(209, 27);
            tbDuration.TabIndex = 3;
            // 
            // tbPercentComplete
            // 
            tbPercentComplete.Location = new System.Drawing.Point(91, 176);
            tbPercentComplete.Name = "tbPercentComplete";
            tbPercentComplete.ReadOnly = true;
            tbPercentComplete.Size = new System.Drawing.Size(209, 27);
            tbPercentComplete.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.Location = new System.Drawing.Point(13, 184);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(97, 20);
            label6.TabIndex = 0;
            label6.Text = "% Complete:";
            // 
            // TaskInfoDialog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(312, 209);
            Controls.Add(tbPercentComplete);
            Controls.Add(tbDuration);
            Controls.Add(tbStart);
            Controls.Add(tbResource);
            Controls.Add(tbTaskName);
            Controls.Add(label3);
            Controls.Add(cbTask);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TaskInfoDialog";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Task Infomation";
            Load += TaskInfoDialog_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTask;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTaskName;
        private System.Windows.Forms.TextBox tbResource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDuration;
        private System.Windows.Forms.TextBox tbPercentComplete;
        private System.Windows.Forms.Label label6;
    }
}
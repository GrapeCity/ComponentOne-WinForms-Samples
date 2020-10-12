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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTask = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTaskName = new System.Windows.Forms.TextBox();
            this.tbResource = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbStart = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDuration = new System.Windows.Forms.TextBox();
            this.tbPercentComplete = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Task Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Resource:";
            // 
            // cbTask
            // 
            this.cbTask.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTask.FormattingEnabled = true;
            this.cbTask.Location = new System.Drawing.Point(91, 12);
            this.cbTask.Name = "cbTask";
            this.cbTask.Size = new System.Drawing.Size(209, 23);
            this.cbTask.TabIndex = 1;
            this.cbTask.SelectedIndexChanged += new System.EventHandler(this.cbTask_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Task:";
            // 
            // tbTaskName
            // 
            this.tbTaskName.Location = new System.Drawing.Point(91, 59);
            this.tbTaskName.Name = "tbTaskName";
            this.tbTaskName.ReadOnly = true;
            this.tbTaskName.Size = new System.Drawing.Size(209, 23);
            this.tbTaskName.TabIndex = 3;
            // 
            // tbResource
            // 
            this.tbResource.Location = new System.Drawing.Point(91, 88);
            this.tbResource.Name = "tbResource";
            this.tbResource.ReadOnly = true;
            this.tbResource.Size = new System.Drawing.Size(209, 23);
            this.tbResource.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Start:";
            // 
            // tbStart
            // 
            this.tbStart.Location = new System.Drawing.Point(91, 118);
            this.tbStart.Name = "tbStart";
            this.tbStart.ReadOnly = true;
            this.tbStart.Size = new System.Drawing.Size(209, 23);
            this.tbStart.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Duration:";
            // 
            // tbDuration
            // 
            this.tbDuration.Location = new System.Drawing.Point(91, 147);
            this.tbDuration.Name = "tbDuration";
            this.tbDuration.ReadOnly = true;
            this.tbDuration.Size = new System.Drawing.Size(209, 23);
            this.tbDuration.TabIndex = 3;
            // 
            // tbPercentComplete
            // 
            this.tbPercentComplete.Location = new System.Drawing.Point(91, 176);
            this.tbPercentComplete.Name = "tbPercentComplete";
            this.tbPercentComplete.ReadOnly = true;
            this.tbPercentComplete.Size = new System.Drawing.Size(209, 23);
            this.tbPercentComplete.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "% Complete:";
            // 
            // TaskInfoDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 209);
            this.Controls.Add(this.tbPercentComplete);
            this.Controls.Add(this.tbDuration);
            this.Controls.Add(this.tbStart);
            this.Controls.Add(this.tbResource);
            this.Controls.Add(this.tbTaskName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbTask);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TaskInfoDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Task Infomation";
            this.Load += new System.EventHandler(this.TaskInfoDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
namespace FilterDate
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            this.deStartDate = new C1.Win.Calendar.C1DateEdit();
            this.deEndDate = new C1.Win.Calendar.C1DateEdit();
            this.lStartDate = new C1.Win.C1Input.C1Label();
            this.lEndDate = new C1.Win.C1Input.C1Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.deStartDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deEndDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lStartDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lEndDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // deStartDate
            // 
            this.deStartDate.AllowSpinLoop = false;
            this.deStartDate.Calendar.DayNameLength = 1;
            this.deStartDate.Location = new System.Drawing.Point(74, 6);
            this.deStartDate.Name = "deStartDate";
            this.deStartDate.Size = new System.Drawing.Size(200, 18);
            this.deStartDate.TabIndex = 0;
            this.deStartDate.Tag = null;
            this.deStartDate.ValueChanged += new System.EventHandler(this.de_ValueChanged);
            // 
            // deEndDate
            // 
            this.deEndDate.AllowSpinLoop = false;
            this.deEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deEndDate.Calendar.DayNameLength = 1;
            this.deEndDate.Location = new System.Drawing.Point(481, 6);
            this.deEndDate.Name = "deEndDate";
            this.deEndDate.Size = new System.Drawing.Size(200, 18);
            this.deEndDate.TabIndex = 0;
            this.deEndDate.Tag = null;
            this.deEndDate.ValueChanged += new System.EventHandler(this.de_ValueChanged);
            // 
            // lStartDate
            // 
            this.lStartDate.AutoSize = true;
            this.lStartDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lStartDate.Location = new System.Drawing.Point(12, 9);
            this.lStartDate.Name = "lStartDate";
            this.lStartDate.Size = new System.Drawing.Size(56, 13);
            this.lStartDate.TabIndex = 1;
            this.lStartDate.Tag = null;
            this.lStartDate.Text = "Start date:";
            this.lStartDate.TextDetached = true;
            // 
            // lEndDate
            // 
            this.lEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lEndDate.AutoSize = true;
            this.lEndDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lEndDate.Location = new System.Drawing.Point(422, 9);
            this.lEndDate.Name = "lEndDate";
            this.lEndDate.Size = new System.Drawing.Size(53, 13);
            this.lEndDate.TabIndex = 2;
            this.lEndDate.Tag = null;
            this.lEndDate.Text = "End date:";
            this.lEndDate.TextDetached = true;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(12, 30);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.Size = new System.Drawing.Size(669, 359);
            this.dgvData.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 401);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.lStartDate);
            this.Controls.Add(this.lEndDate);
            this.Controls.Add(this.deStartDate);
            this.Controls.Add(this.deEndDate);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.deStartDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deEndDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lStartDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lEndDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private C1.Win.Calendar.C1DateEdit deStartDate;
        private C1.Win.Calendar.C1DateEdit deEndDate;
        private C1.Win.C1Input.C1Label lStartDate;
        private C1.Win.C1Input.C1Label lEndDate;
        private System.Windows.Forms.DataGridView dgvData;
    }
}


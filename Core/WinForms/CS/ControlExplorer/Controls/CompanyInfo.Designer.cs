namespace ControlExplorer.Controls
{
    partial class CompanyInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyInfo));
            companyLogoPicBox = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            lblPhoneNo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)companyLogoPicBox).BeginInit();
            SuspendLayout();
            // 
            // companyLogoPicBox
            // 
            companyLogoPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            companyLogoPicBox.Image = (System.Drawing.Image)resources.GetObject("companyLogoPicBox.Image");
            companyLogoPicBox.Location = new System.Drawing.Point(39, 18);
            companyLogoPicBox.Name = "companyLogoPicBox";
            companyLogoPicBox.Size = new System.Drawing.Size(244, 63);
            companyLogoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            companyLogoPicBox.TabIndex = 0;
            companyLogoPicBox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(39, 91);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(58, 15);
            label1.TabIndex = 1;
            label1.Text = "2013.1.1.1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(38, 114);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(188, 15);
            label2.TabIndex = 2;
            label2.Text = "©MESCIUS inc. All rights reserved.";
            // 
            // lblPhoneNo
            // 
            lblPhoneNo.AutoSize = true;
            lblPhoneNo.Location = new System.Drawing.Point(43, 138);
            lblPhoneNo.Name = "lblPhoneNo";
            lblPhoneNo.Size = new System.Drawing.Size(38, 15);
            lblPhoneNo.TabIndex = 3;
            lblPhoneNo.Text = "label3";
            // 
            // CompanyInfo
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(lblPhoneNo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(companyLogoPicBox);
            Name = "CompanyInfo";
            Size = new System.Drawing.Size(320, 178);
            ((System.ComponentModel.ISupportInitialize)companyLogoPicBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox companyLogoPicBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPhoneNo;
    }
}

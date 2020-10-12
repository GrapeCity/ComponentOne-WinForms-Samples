namespace MaterialDesign.Controls
{
    partial class AppRibbonPanel
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
            this.c1CheckBox1 = new C1.Win.C1Input.C1CheckBox();
            this.c1CheckBox2 = new C1.Win.C1Input.C1CheckBox();
            this.c1CheckBox3 = new C1.Win.C1Input.C1CheckBox();
            this.c1Label1 = new C1.Win.C1Input.C1Label();
            ((System.ComponentModel.ISupportInitialize)(this.c1CheckBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CheckBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CheckBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1CheckBox1
            // 
            this.c1CheckBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c1CheckBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1CheckBox1.Checked = true;
            this.c1CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.c1CheckBox1.Location = new System.Drawing.Point(26, 84);
            this.c1CheckBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.c1CheckBox1.Name = "c1CheckBox1";
            this.c1CheckBox1.Size = new System.Drawing.Size(474, 39);
            this.c1CheckBox1.TabIndex = 0;
            this.c1CheckBox1.Text = "  Ribbon header row";
            this.c1CheckBox1.UseVisualStyleBackColor = true;
            this.c1CheckBox1.Value = true;
            // 
            // c1CheckBox2
            // 
            this.c1CheckBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c1CheckBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1CheckBox2.Checked = true;
            this.c1CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.c1CheckBox2.Location = new System.Drawing.Point(26, 133);
            this.c1CheckBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.c1CheckBox2.Name = "c1CheckBox2";
            this.c1CheckBox2.Size = new System.Drawing.Size(474, 39);
            this.c1CheckBox2.TabIndex = 1;
            this.c1CheckBox2.Text = "  Ribbon tabs";
            this.c1CheckBox2.UseVisualStyleBackColor = true;
            this.c1CheckBox2.Value = true;
            // 
            // c1CheckBox3
            // 
            this.c1CheckBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c1CheckBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1CheckBox3.Location = new System.Drawing.Point(26, 182);
            this.c1CheckBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.c1CheckBox3.Name = "c1CheckBox3";
            this.c1CheckBox3.Size = new System.Drawing.Size(474, 39);
            this.c1CheckBox3.TabIndex = 2;
            this.c1CheckBox3.Text = "  QAT menu";
            this.c1CheckBox3.UseVisualStyleBackColor = true;
            this.c1CheckBox3.Value = null;
            // 
            // c1Label1
            // 
            this.c1Label1.AutoSize = true;
            this.c1Label1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1Label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.c1Label1.Location = new System.Drawing.Point(26, 23);
            this.c1Label1.Name = "c1Label1";
            this.c1Label1.Size = new System.Drawing.Size(162, 30);
            this.c1Label1.TabIndex = 3;
            this.c1Label1.Tag = null;
            this.c1Label1.Text = "Ribbon settings";
            this.c1Label1.TextDetached = true;
            // 
            // AppRibbonPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.c1Label1);
            this.Controls.Add(this.c1CheckBox3);
            this.Controls.Add(this.c1CheckBox2);
            this.Controls.Add(this.c1CheckBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AppRibbonPanel";
            this.Size = new System.Drawing.Size(543, 531);
            ((System.ComponentModel.ISupportInitialize)(this.c1CheckBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CheckBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CheckBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1Input.C1CheckBox c1CheckBox1;
        private C1.Win.C1Input.C1CheckBox c1CheckBox2;
        private C1.Win.C1Input.C1CheckBox c1CheckBox3;
        private C1.Win.C1Input.C1Label c1Label1;
    }
}

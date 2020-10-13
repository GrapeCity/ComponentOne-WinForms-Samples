namespace PowerQueryConnection
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
            this._c1FlexPivotPage = new C1.Win.FlexPivot.FlexPivotPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonGetData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._c1FlexPivotPage)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _c1FlexPivotPage
            // 
            this._c1FlexPivotPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this._c1FlexPivotPage.Location = new System.Drawing.Point(0, 47);
            this._c1FlexPivotPage.Margin = new System.Windows.Forms.Padding(2);
            this._c1FlexPivotPage.Name = "_c1FlexPivotPage";
            this._c1FlexPivotPage.Size = new System.Drawing.Size(925, 507);
            this._c1FlexPivotPage.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonGetData);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 47);
            this.panel1.TabIndex = 2;
            // 
            // buttonGetData
            // 
            this.buttonGetData.Location = new System.Drawing.Point(12, 12);
            this.buttonGetData.Name = "buttonGetData";
            this.buttonGetData.Size = new System.Drawing.Size(242, 23);
            this.buttonGetData.TabIndex = 0;
            this.buttonGetData.Text = "Get data from Power Query";
            this.buttonGetData.UseVisualStyleBackColor = true;
            this.buttonGetData.Click += new System.EventHandler(this.buttonGetData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 554);
            this.Controls.Add(this._c1FlexPivotPage);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import From Power Query";
            ((System.ComponentModel.ISupportInitialize)(this._c1FlexPivotPage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.FlexPivot.FlexPivotPage _c1FlexPivotPage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonGetData;
        private System.Windows.Forms.Label label1;
    }
}


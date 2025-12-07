namespace CustomColumns
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
            this._c1FlexPivotPage = new C1.Win.FlexPivot.FlexPivotPage();
            this._chkCustomColumns = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this._c1FlexPivotPage)).BeginInit();
            this.SuspendLayout();
            // 
            // _c1FlexPivotPage
            // 
            this._c1FlexPivotPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this._c1FlexPivotPage.Location = new System.Drawing.Point(0, 25);
            this._c1FlexPivotPage.Margin = new System.Windows.Forms.Padding(2);
            this._c1FlexPivotPage.Name = "_c1FlexPivotPage";
            this._c1FlexPivotPage.Size = new System.Drawing.Size(774, 514);
            this._c1FlexPivotPage.TabIndex = 0;
            // 
            // _chkCustomColumns
            // 
            this._chkCustomColumns.AutoSize = true;
            this._chkCustomColumns.Checked = true;
            this._chkCustomColumns.CheckState = System.Windows.Forms.CheckState.Checked;
            this._chkCustomColumns.Dock = System.Windows.Forms.DockStyle.Top;
            this._chkCustomColumns.Location = new System.Drawing.Point(0, 0);
            this._chkCustomColumns.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._chkCustomColumns.Name = "_chkCustomColumns";
            this._chkCustomColumns.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this._chkCustomColumns.Size = new System.Drawing.Size(774, 25);
            this._chkCustomColumns.TabIndex = 1;
            this._chkCustomColumns.Text = "Add Custom Calculated Columns to the FlexPivot Output Table";
            this._chkCustomColumns.UseVisualStyleBackColor = true;
            this._chkCustomColumns.CheckedChanged += new System.EventHandler(this._chkCustomColumns_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 539);
            this.Controls.Add(this._c1FlexPivotPage);
            this.Controls.Add(this._chkCustomColumns);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom Columns";
            ((System.ComponentModel.ISupportInitialize)(this._c1FlexPivotPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.FlexPivot.FlexPivotPage _c1FlexPivotPage;
        private System.Windows.Forms.CheckBox _chkCustomColumns;
    }
}


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
            this._c1OlapPage = new C1.Win.Olap.C1OlapPage();
            this._chkCustomColumns = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this._c1OlapPage)).BeginInit();
            this.SuspendLayout();
            // 
            // _c1OlapPage
            // 
            this._c1OlapPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this._c1OlapPage.Location = new System.Drawing.Point(0, 31);
            this._c1OlapPage.Margin = new System.Windows.Forms.Padding(2);
            this._c1OlapPage.Name = "_c1OlapPage";
            this._c1OlapPage.Size = new System.Drawing.Size(732, 474);
            this._c1OlapPage.TabIndex = 0;
            // 
            // _chkCustomColumns
            // 
            this._chkCustomColumns.AutoSize = true;
            this._chkCustomColumns.Checked = true;
            this._chkCustomColumns.CheckState = System.Windows.Forms.CheckState.Checked;
            this._chkCustomColumns.Dock = System.Windows.Forms.DockStyle.Top;
            this._chkCustomColumns.Location = new System.Drawing.Point(0, 0);
            this._chkCustomColumns.Name = "_chkCustomColumns";
            this._chkCustomColumns.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this._chkCustomColumns.Size = new System.Drawing.Size(732, 31);
            this._chkCustomColumns.TabIndex = 1;
            this._chkCustomColumns.Text = "Add Custom Calculated Columns to the OLAP Output Table";
            this._chkCustomColumns.UseVisualStyleBackColor = true;
            this._chkCustomColumns.CheckedChanged += new System.EventHandler(this._chkCustomColumns_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 505);
            this.Controls.Add(this._c1OlapPage);
            this.Controls.Add(this._chkCustomColumns);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this._c1OlapPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.Olap.C1OlapPage _c1OlapPage;
        private System.Windows.Forms.CheckBox _chkCustomColumns;
    }
}


namespace DataEngineQueries
{
    partial class FlexPivotForm
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
            ((System.ComponentModel.ISupportInitialize)(this._c1FlexPivotPage)).BeginInit();
            this.SuspendLayout();
            // 
            // _c1FlexPivotPage
            // 
            this._c1FlexPivotPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this._c1FlexPivotPage.Location = new System.Drawing.Point(0, 0);
            this._c1FlexPivotPage.Margin = new System.Windows.Forms.Padding(2);
            this._c1FlexPivotPage.Name = "_c1FlexPivotPage";
            this._c1FlexPivotPage.Size = new System.Drawing.Size(808, 560);
            this._c1FlexPivotPage.TabIndex = 1;
            // 
            // FlexPivotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 560);
            this.Controls.Add(this._c1FlexPivotPage);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.MinimizeBox = false;
            this.Name = "FlexPivotForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Join Query Data Analysis";
            ((System.ComponentModel.ISupportInitialize)(this._c1FlexPivotPage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.FlexPivot.FlexPivotPage _c1FlexPivotPage;
    }
}
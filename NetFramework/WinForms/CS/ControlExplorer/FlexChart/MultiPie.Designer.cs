namespace ControlExplorer.FlexChart
{
    partial class MultiPie
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
            this.cmbChartTypes = new C1.Win.C1Input.C1ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.cmbChartTypes)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbChartTypes
            // 
            this.cmbChartTypes.AllowSpinLoop = false;
            this.cmbChartTypes.GapHeight = 0;
            this.cmbChartTypes.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cmbChartTypes.ItemsDisplayMember = "";
            this.cmbChartTypes.ItemsValueMember = "";
            this.cmbChartTypes.Location = new System.Drawing.Point(12, 12);
            this.cmbChartTypes.Name = "cmbChartTypes";
            this.cmbChartTypes.Size = new System.Drawing.Size(335, 18);
            this.cmbChartTypes.TabIndex = 0;
            this.cmbChartTypes.Tag = null;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbChartTypes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1085, 41);
            this.panel1.TabIndex = 1;
            // 
            // MultiPie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 728);
            this.Controls.Add(this.panel1);
            this.Name = "MultiPie";
            ((System.ComponentModel.ISupportInitialize)(this.cmbChartTypes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1Input.C1ComboBox cmbChartTypes;
        private System.Windows.Forms.Panel panel1;
    }
}

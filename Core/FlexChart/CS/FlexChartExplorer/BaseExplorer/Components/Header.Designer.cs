namespace BaseExplorer.Components
{
    partial class Header
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
            this.rootView = new System.Windows.Forms.TableLayoutPanel();
            this.pnlAppTitle = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlSampleTitle = new System.Windows.Forms.TableLayoutPanel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.rootView.SuspendLayout();
            this.pnlAppTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlSampleTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // rootView
            // 
            this.rootView.AutoSize = true;
            this.rootView.BackColor = System.Drawing.Color.Transparent;
            this.rootView.ColumnCount = 2;
            this.rootView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 275F));
            this.rootView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rootView.Controls.Add(this.pnlAppTitle, 0, 0);
            this.rootView.Controls.Add(this.pnlSampleTitle, 1, 0);
            this.rootView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootView.Location = new System.Drawing.Point(0, 0);
            this.rootView.Margin = new System.Windows.Forms.Padding(0);
            this.rootView.Name = "rootView";
            this.rootView.RowCount = 1;
            this.rootView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rootView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.rootView.Size = new System.Drawing.Size(739, 50);
            this.rootView.TabIndex = 0;
            // 
            // pnlAppTitle
            // 
            this.pnlAppTitle.AutoSize = true;
            this.pnlAppTitle.Controls.Add(this.lblTitle);
            this.pnlAppTitle.Controls.Add(this.pbLogo);
            this.pnlAppTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAppTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlAppTitle.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAppTitle.Name = "pnlAppTitle";
            this.pnlAppTitle.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.pnlAppTitle.Size = new System.Drawing.Size(275, 50);
            this.pnlAppTitle.TabIndex = 3;
            this.pnlAppTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAppTitle_Paint);
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbLogo.Image = global::BaseExplorer.Properties.Resources.C1_Hex;
            this.pbLogo.Location = new System.Drawing.Point(0, 4);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(42, 42);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // pnlSampleTitle
            // 
            this.pnlSampleTitle.AutoSize = true;
            this.pnlSampleTitle.BackColor = System.Drawing.Color.Transparent;
            this.pnlSampleTitle.ColumnCount = 1;
            this.pnlSampleTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlSampleTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlSampleTitle.Controls.Add(this.lblHeader, 0, 0);
            this.pnlSampleTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSampleTitle.Location = new System.Drawing.Point(275, 0);
            this.pnlSampleTitle.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSampleTitle.Name = "pnlSampleTitle";
            this.pnlSampleTitle.Padding = new System.Windows.Forms.Padding(5);
            this.pnlSampleTitle.RowCount = 1;
            this.pnlSampleTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlSampleTitle.Size = new System.Drawing.Size(464, 50);
            this.pnlSampleTitle.TabIndex = 1;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.Location = new System.Drawing.Point(8, 5);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(448, 40);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Header";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(42, 4);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(233, 42);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "FlexChart Explorer";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Header
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.rootView);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Header";
            this.Size = new System.Drawing.Size(739, 50);
            this.rootView.ResumeLayout(false);
            this.rootView.PerformLayout();
            this.pnlAppTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlSampleTitle.ResumeLayout(false);
            this.pnlSampleTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel rootView;
        private System.Windows.Forms.Panel pnlAppTitle;
        private System.Windows.Forms.TableLayoutPanel pnlSampleTitle;
        private System.Windows.Forms.Label lblHeader;
        public System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblTitle;
    }
}

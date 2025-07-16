namespace ControlExplorer.DataFilter
{
    partial class Overview
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.c1DataFilter1 = new C1.Win.DataFilter.C1DataFilter();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.c1FlexGrid1 = new C1.Win.FlexGrid.C1FlexGrid();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1DataFilter1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.c1DataFilter1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 1237);
            this.panel1.TabIndex = 0;
            // 
            // c1DataFilter1
            // 
            this.c1DataFilter1.AutoGenerateFilters = true;
            this.c1DataFilter1.DataMember = null;
            this.c1DataFilter1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1DataFilter1.HeaderText = "Filter";
            this.c1DataFilter1.Location = new System.Drawing.Point(0, 0);
            this.c1DataFilter1.Name = "c1DataFilter1";
            this.c1DataFilter1.Size = new System.Drawing.Size(245, 1237);
            this.c1DataFilter1.TabIndex = 0;
            this.c1DataFilter1.Text = "c1DataFilter1";
            this.c1DataFilter1.FilterAutoGenerating += new System.EventHandler<C1.DataFilter.FilterAutoGeneratingEventArgs>(this.c1DataFilter1_FilterAutoGenerating);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(245, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 1237);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.c1FlexGrid1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(248, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1457, 1237);
            this.panel2.TabIndex = 2;
            // 
            // c1FlexGrid1
            // 
            this.c1FlexGrid1.AllowDelete = true;
            this.c1FlexGrid1.AllowEditing = false;
            this.c1FlexGrid1.ColumnInfo = "1,1,0,0,0,95,Columns:";
            this.c1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1FlexGrid1.Location = new System.Drawing.Point(0, 0);
            this.c1FlexGrid1.Name = "c1FlexGrid1";
            this.c1FlexGrid1.Rows.Count = 1;
            this.c1FlexGrid1.Rows.DefaultSize = 30;
            this.c1FlexGrid1.ShowThemedHeaders = C1.Win.FlexGrid.ShowThemedHeadersEnum.None;
            this.c1FlexGrid1.Size = new System.Drawing.Size(1457, 1237);
            this.c1FlexGrid1.TabIndex = 0;
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1705, 1237);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Name = "Overview";
            this.Text = "Overview";
            this.Load += new System.EventHandler(this.Overview_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1DataFilter1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel2;
        private C1.Win.FlexGrid.C1FlexGrid c1FlexGrid1;
        private C1.Win.DataFilter.C1DataFilter c1DataFilter1;
    }
}
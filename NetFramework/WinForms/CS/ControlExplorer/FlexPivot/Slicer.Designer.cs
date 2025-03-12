namespace ControlExplorer.FlexPivot
{
    partial class Slicer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Slicer));
            C1.DataEngine.Workspace workspace2 = C1.Win.FlexPivot.C1FlexPivotPanel.CreateWorkspace();
            this.panel2 = new System.Windows.Forms.Panel();
            this.c1FlexPivotGrid1 = new C1.Win.FlexPivot.C1FlexPivotGrid();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.c1FlexPivotPanel1 = new C1.Win.FlexPivot.C1FlexPivotPanel();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.c1FlexPivotSlicer1 = new C1.Win.FlexPivot.C1FlexPivotSlicer();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexPivotGrid1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexPivotPanel1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexPivotSlicer1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.c1FlexPivotGrid1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(322, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(478, 450);
            this.panel2.TabIndex = 5;
            // 
            // c1FlexPivotGrid1
            // 
            this.c1FlexPivotGrid1.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.FixedOnly;
            this.c1FlexPivotGrid1.AllowMergingFixed = C1.Win.C1FlexGrid.AllowMergingEnum.Default;
            this.c1FlexPivotGrid1.ColumnInfo = "10,1,0,0,0,95,Columns:0{Width:95;}\t";
            this.c1FlexPivotGrid1.DataSource = this.c1FlexPivotPanel1;
            this.c1FlexPivotGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1FlexPivotGrid1.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw;
            this.c1FlexPivotGrid1.Location = new System.Drawing.Point(0, 0);
            this.c1FlexPivotGrid1.Name = "c1FlexPivotGrid1";
            this.c1FlexPivotGrid1.Rows.DefaultSize = -1;
            this.c1FlexPivotGrid1.Size = new System.Drawing.Size(478, 450);
            this.c1FlexPivotGrid1.StyleInfo = resources.GetString("c1FlexPivotGrid1.StyleInfo");
            this.c1FlexPivotGrid1.SubtotalBackground = System.Drawing.Color.Empty;
            this.c1FlexPivotGrid1.SubtotalForeground = System.Drawing.Color.Empty;
            this.c1FlexPivotGrid1.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(180, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 450);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.splitter2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 450);
            this.panel1.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.c1FlexPivotPanel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 156);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(180, 294);
            this.panel4.TabIndex = 2;
            // 
            // c1FlexPivotPanel1
            // 
            this.c1FlexPivotPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1FlexPivotPanel1.Location = new System.Drawing.Point(0, 0);
            this.c1FlexPivotPanel1.Name = "c1FlexPivotPanel1";
            this.c1FlexPivotPanel1.Size = new System.Drawing.Size(180, 294);
            this.c1FlexPivotPanel1.TabIndex = 0;
            workspace2.AutoSave = true;
            workspace2.KeepFiles = C1.DataEngine.KeepFileType.Results;
            this.c1FlexPivotPanel1.Workspace = workspace2;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(0, 120);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(180, 3);
            this.splitter2.TabIndex = 1;
            this.splitter2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.c1FlexPivotSlicer1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 153);
            this.panel3.TabIndex = 0;
            // 
            // c1FlexPivotSlicer1
            // 
            this.c1FlexPivotSlicer1.DataSource = this.c1FlexPivotPanel1;
            this.c1FlexPivotSlicer1.Dock = System.Windows.Forms.DockStyle.Fill;            
            this.c1FlexPivotSlicer1.FieldName = null;
            this.c1FlexPivotSlicer1.Location = new System.Drawing.Point(0, 0);
            this.c1FlexPivotSlicer1.Name = "c1FlexPivotSlicer1";
            this.c1FlexPivotSlicer1.ShowSelectAll = true;
            this.c1FlexPivotSlicer1.Size = new System.Drawing.Size(180, 120);
            this.c1FlexPivotSlicer1.TabIndex = 0;
            this.c1FlexPivotSlicer1.Text = "c1FlexPivotSlicer1";
            // 
            // C1FlexPivotPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Name = "C1FlexPivotPreview";
            this.Text = "C1FlexPivotPreview";
            this.panel2.ResumeLayout(false);
            this.Load += new System.EventHandler(this.Slicer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexPivotGrid1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexPivotPanel1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexPivotSlicer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private C1.Win.FlexPivot.C1FlexPivotGrid c1FlexPivotGrid1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private C1.Win.FlexPivot.C1FlexPivotPanel c1FlexPivotPanel1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel panel3;
        private C1.Win.FlexPivot.C1FlexPivotSlicer c1FlexPivotSlicer1;
    }
}
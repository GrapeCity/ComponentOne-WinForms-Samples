namespace GridRendererDemo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.c1FlexGrid1 = new C1.Win.FlexGrid.C1FlexGrid();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this._pgDesignTime = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.c1FlexGrid5 = new C1.Win.FlexGrid.C1FlexGrid();
            this.c1FlexGrid4 = new C1.Win.FlexGrid.C1FlexGrid();
            this.c1FlexGrid3 = new C1.Win.FlexGrid.C1FlexGrid();
            this.c1FlexGrid2 = new C1.Win.FlexGrid.C1FlexGrid();
            this._pgRunTime = new System.Windows.Forms.TabPage();
            this._btnEditRenderer = new System.Windows.Forms.Button();
            this.gridRenderer1 = new GridRenderer.GridRenderer(this.components);
            this.gridRenderer2 = new GridRenderer.GridRenderer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this._pgDesignTime.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid2)).BeginInit();
            this._pgRunTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // c1FlexGrid1
            // 
            this.c1FlexGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.c1FlexGrid1.BorderStyle = C1.Win.FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D;
            this.c1FlexGrid1.ColumnInfo = "10,1,0,0,0,85,Columns:";
            this.c1FlexGrid1.Location = new System.Drawing.Point(8, 6);
            this.c1FlexGrid1.Name = "c1FlexGrid1";
            this.c1FlexGrid1.Rows.DefaultSize = 17;
            this.c1FlexGrid1.Size = new System.Drawing.Size(562, 332);
            this.c1FlexGrid1.TabIndex = 0;
            this.c1FlexGrid1.VisualStyle = C1.Win.FlexGrid.VisualStyle.Office2007Blue;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this._pgDesignTime);
            this.tabControl1.Controls.Add(this._pgRunTime);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(674, 399);
            this.tabControl1.TabIndex = 1;
            // 
            // _pgDesignTime
            // 
            this._pgDesignTime.Controls.Add(this.tableLayoutPanel1);
            this._pgDesignTime.Location = new System.Drawing.Point(4, 22);
            this._pgDesignTime.Name = "_pgDesignTime";
            this._pgDesignTime.Padding = new System.Windows.Forms.Padding(3);
            this._pgDesignTime.Size = new System.Drawing.Size(666, 373);
            this._pgDesignTime.TabIndex = 1;
            this._pgDesignTime.Text = "Design time";
            this._pgDesignTime.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.c1FlexGrid5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.c1FlexGrid4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.c1FlexGrid3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.c1FlexGrid2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(660, 367);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // c1FlexGrid5
            // 
            this.c1FlexGrid5.BorderStyle = C1.Win.FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D;
            this.c1FlexGrid5.ColumnInfo = "10,1,0,0,0,85,Columns:";
            this.c1FlexGrid5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1FlexGrid5.Location = new System.Drawing.Point(333, 186);
            this.c1FlexGrid5.Name = "c1FlexGrid5";
            this.gridRenderer1.SetRenderer(this.c1FlexGrid5, true);
            this.c1FlexGrid5.Rows.DefaultSize = 17;
            this.c1FlexGrid5.Size = new System.Drawing.Size(324, 178);
            this.c1FlexGrid5.TabIndex = 4;
            this.c1FlexGrid5.VisualStyle = C1.Win.FlexGrid.VisualStyle.Office2007Blue;
            // 
            // c1FlexGrid4
            // 
            this.c1FlexGrid4.BorderStyle = C1.Win.FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D;
            this.c1FlexGrid4.ColumnInfo = "10,1,0,0,0,85,Columns:";
            this.c1FlexGrid4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1FlexGrid4.Location = new System.Drawing.Point(333, 3);
            this.c1FlexGrid4.Name = "c1FlexGrid4";
            this.gridRenderer1.SetRenderer(this.c1FlexGrid4, true);
            this.c1FlexGrid4.Rows.DefaultSize = 17;
            this.c1FlexGrid4.Size = new System.Drawing.Size(324, 177);
            this.c1FlexGrid4.TabIndex = 3;
            this.c1FlexGrid4.VisualStyle = C1.Win.FlexGrid.VisualStyle.Office2007Blue;
            // 
            // c1FlexGrid3
            // 
            this.c1FlexGrid3.BorderStyle = C1.Win.FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D;
            this.c1FlexGrid3.ColumnInfo = "10,1,0,0,0,85,Columns:";
            this.c1FlexGrid3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1FlexGrid3.Location = new System.Drawing.Point(3, 186);
            this.c1FlexGrid3.Name = "c1FlexGrid3";
            this.gridRenderer1.SetRenderer(this.c1FlexGrid3, true);
            this.c1FlexGrid3.Rows.DefaultSize = 17;
            this.c1FlexGrid3.Size = new System.Drawing.Size(324, 178);
            this.c1FlexGrid3.TabIndex = 2;
            this.c1FlexGrid3.VisualStyle = C1.Win.FlexGrid.VisualStyle.Office2007Blue;
            // 
            // c1FlexGrid2
            // 
            this.c1FlexGrid2.BorderStyle = C1.Win.FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D;
            this.c1FlexGrid2.ColumnInfo = "10,1,0,0,0,85,Columns:";
            this.c1FlexGrid2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1FlexGrid2.Location = new System.Drawing.Point(3, 3);
            this.c1FlexGrid2.Name = "c1FlexGrid2";
            this.gridRenderer1.SetRenderer(this.c1FlexGrid2, true);
            this.c1FlexGrid2.Rows.DefaultSize = 17;
            this.c1FlexGrid2.Size = new System.Drawing.Size(324, 177);
            this.c1FlexGrid2.TabIndex = 1;
            this.c1FlexGrid2.VisualStyle = C1.Win.FlexGrid.VisualStyle.Office2007Blue;
            // 
            // _pgRunTime
            // 
            this._pgRunTime.Controls.Add(this._btnEditRenderer);
            this._pgRunTime.Controls.Add(this.c1FlexGrid1);
            this._pgRunTime.Location = new System.Drawing.Point(4, 22);
            this._pgRunTime.Name = "_pgRunTime";
            this._pgRunTime.Padding = new System.Windows.Forms.Padding(3);
            this._pgRunTime.Size = new System.Drawing.Size(578, 373);
            this._pgRunTime.TabIndex = 0;
            this._pgRunTime.Text = "Run time";
            this._pgRunTime.UseVisualStyleBackColor = true;
            // 
            // _btnEditRenderer
            // 
            this._btnEditRenderer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnEditRenderer.Location = new System.Drawing.Point(460, 344);
            this._btnEditRenderer.Name = "_btnEditRenderer";
            this._btnEditRenderer.Size = new System.Drawing.Size(110, 23);
            this._btnEditRenderer.TabIndex = 1;
            this._btnEditRenderer.Text = "Edit &Renderer...";
            this._btnEditRenderer.UseVisualStyleBackColor = true;
            this._btnEditRenderer.Click += new System.EventHandler(this._btnEditRenderer_Click);
            // 
            // gridRenderer1
            // 
            this.gridRenderer1.Palette = resources.GetString("gridRenderer1.Palette");
            // 
            // gridRenderer2
            // 
            this.gridRenderer2.Palette = resources.GetString("gridRenderer2.Palette");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 399);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1FlexGrid: Custom Renderers";
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this._pgDesignTime.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid2)).EndInit();
            this._pgRunTime.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.FlexGrid.C1FlexGrid c1FlexGrid1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage _pgRunTime;
        private System.Windows.Forms.Button _btnEditRenderer;
        private System.Windows.Forms.TabPage _pgDesignTime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private C1.Win.FlexGrid.C1FlexGrid c1FlexGrid5;
        private C1.Win.FlexGrid.C1FlexGrid c1FlexGrid4;
        private C1.Win.FlexGrid.C1FlexGrid c1FlexGrid3;
        private C1.Win.FlexGrid.C1FlexGrid c1FlexGrid2;
        private GridRenderer.GridRenderer gridRenderer1;
        private GridRenderer.GridRenderer gridRenderer2;
    }
}


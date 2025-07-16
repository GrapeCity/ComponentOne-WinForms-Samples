namespace ControlExplorer.FlexPivot
{
    partial class TopN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopN));
            this.c1FlexPivotGrid1 = new C1.Win.FlexPivot.C1FlexPivotGrid();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.c1ThemeController1 = new C1.Win.Themes.C1ThemeController();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexPivotGrid1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1FlexPivotGrid1
            // 
            this.c1FlexPivotGrid1.AllowMerging = C1.Win.FlexGrid.AllowMergingEnum.FixedOnly;
            this.c1FlexPivotGrid1.AllowMergingFixed = C1.Win.FlexGrid.AllowMergingEnum.Default;
            this.c1FlexPivotGrid1.ColumnInfo = "10,1,0,0,0,-1,Columns:0{Width:125;}\t";
            this.c1FlexPivotGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1FlexPivotGrid1.DrawMode = C1.Win.FlexGrid.DrawModeEnum.OwnerDraw;
            this.c1FlexPivotGrid1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.c1FlexPivotGrid1.Location = new System.Drawing.Point(0, 0);
            this.c1FlexPivotGrid1.Name = "c1FlexPivotGrid1";
            this.c1FlexPivotGrid1.ShowThemedHeaders = C1.Win.FlexGrid.ShowThemedHeadersEnum.None;
            this.c1FlexPivotGrid1.Size = new System.Drawing.Size(2468, 1513);
            this.c1FlexPivotGrid1.StyleInfo = resources.GetString("c1FlexPivotGrid1.StyleInfo");
            this.c1FlexPivotGrid1.SubtotalBackground = System.Drawing.Color.Empty;
            this.c1FlexPivotGrid1.SubtotalForeground = System.Drawing.Color.Empty;
            this.c1FlexPivotGrid1.TabIndex = 0;
            this.c1ThemeController1.SetTheme(this.c1FlexPivotGrid1, "(default)");
            this.c1FlexPivotGrid1.Tree.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.c1FlexPivotGrid1.VisualStyle = C1.Win.FlexGrid.VisualStyle.Custom;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(17, 16);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(143, 32);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "All products";
            this.c1ThemeController1.SetTheme(this.radioButton1, "(default)");
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(223, 16);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(168, 32);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "Top 3 products";
            this.c1ThemeController1.SetTheme(this.radioButton2, "(default)");
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(428, 16);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(202, 32);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.Text = "Bottom 3 products";
            this.c1ThemeController1.SetTheme(this.radioButton3, "(default)");
            this.radioButton3.UseVisualStyleBackColor = false;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 1513);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2468, 74);
            this.panel1.TabIndex = 4;
            this.c1ThemeController1.SetTheme(this.panel1, "(default)");
            // 
            // TopN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(2468, 1587);
            this.Controls.Add(this.c1FlexPivotGrid1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TopN";
            this.Text = "Top N Sample";
            this.c1ThemeController1.SetTheme(this, "(default)");
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexPivotGrid1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.Themes.C1ThemeController c1ThemeController1;
        private C1.Win.FlexPivot.C1FlexPivotGrid c1FlexPivotGrid1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Panel panel1;
    }
}


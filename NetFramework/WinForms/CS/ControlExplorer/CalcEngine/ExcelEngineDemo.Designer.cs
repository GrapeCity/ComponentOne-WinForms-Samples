namespace ControlExplorer.CalcEngine
{
    partial class ExcelEngineDemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcelEngineDemo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.formula1 = new ControlExplorer.CalcEngine.Formula();
            this.c1DockingTab1 = new C1.Win.Command.C1DockingTab();
            this.c1DockingTabPage1 = new C1.Win.Command.C1DockingTabPage();
            this.sheet1 = new C1.Win.FlexGrid.C1FlexGrid();
            this.c1DockingTabPage2 = new C1.Win.Command.C1DockingTabPage();
            this.sheet2 = new ControlExplorer.CalcEngine.ExcelFlexGrid();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).BeginInit();
            this.c1DockingTab1.SuspendLayout();
            this.c1DockingTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sheet1)).BeginInit();
            this.c1DockingTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sheet2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.formula1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 28);
            this.panel1.TabIndex = 1;
            // 
            // formula1
            // 
            this.formula1.DefaultExpression = "=Sum(sheet1!{0}) + Sum(sheet2!{1})";
            this.formula1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formula1.EngineType = ControlExplorer.CalcEngine.EngineType.Excel;
            this.formula1.Expression = "=Sum(sheet1!{0}) + Sum(sheet2!{1})";
            this.formula1.Location = new System.Drawing.Point(0, 0);
            this.formula1.Name = "formula1";
            this.formula1.Padding = new System.Windows.Forms.Padding(2);
            this.formula1.Result = "";
            this.formula1.Size = new System.Drawing.Size(967, 28);
            this.formula1.TabIndex = 26;
            this.formula1.Evaluate += new System.EventHandler(this.formula1_Evaluate);
            // 
            // c1DockingTab1
            // 
            this.c1DockingTab1.Controls.Add(this.c1DockingTabPage1);
            this.c1DockingTab1.Controls.Add(this.c1DockingTabPage2);
            this.c1DockingTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1DockingTab1.Location = new System.Drawing.Point(0, 28);
            this.c1DockingTab1.Name = "c1DockingTab1";
            this.c1DockingTab1.ShowToolTips = true;
            this.c1DockingTab1.Size = new System.Drawing.Size(967, 539);
            this.c1DockingTab1.TabIndex = 2;
            // 
            // c1DockingTabPage1
            // 
            this.c1DockingTabPage1.Controls.Add(this.sheet1);
            this.c1DockingTabPage1.Location = new System.Drawing.Point(1, 24);
            this.c1DockingTabPage1.Name = "c1DockingTabPage1";
            this.c1DockingTabPage1.Size = new System.Drawing.Size(965, 514);
            this.c1DockingTabPage1.TabIndex = 0;
            this.c1DockingTabPage1.Text = "Sheet 1";
            this.c1DockingTabPage1.ToolTipText = "Bound Grid";
            // 
            // sheet1
            // 
            this.sheet1.BackColor = System.Drawing.Color.White;
            this.sheet1.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            this.sheet1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sheet1.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.sheet1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.sheet1.Location = new System.Drawing.Point(0, 0);
            this.sheet1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.sheet1.Name = "sheet1";
            this.sheet1.ShowThemedHeaders = C1.Win.FlexGrid.ShowThemedHeadersEnum.None;
            this.sheet1.Size = new System.Drawing.Size(965, 514);
            this.sheet1.StyleInfo = resources.GetString("sheet1.StyleInfo");
            this.sheet1.TabIndex = 16;
            this.sheet1.Tree.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.sheet1.VisualStyle = C1.Win.FlexGrid.VisualStyle.Custom;
            this.sheet1.SelChange += new System.EventHandler(this.flexGridSheet1_SelChange);
            // 
            // c1DockingTabPage2
            // 
            this.c1DockingTabPage2.Controls.Add(this.sheet2);
            this.c1DockingTabPage2.Location = new System.Drawing.Point(1, 24);
            this.c1DockingTabPage2.Name = "c1DockingTabPage2";
            this.c1DockingTabPage2.Size = new System.Drawing.Size(965, 514);
            this.c1DockingTabPage2.TabIndex = 1;
            this.c1DockingTabPage2.Text = "Sheet 2";
            this.c1DockingTabPage2.ToolTipText = "Unbound Grid";
            // 
            // sheet2
            // 
            this.sheet2.BackColor = System.Drawing.Color.White;
            this.sheet2.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            this.sheet2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sheet2.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.sheet2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.sheet2.Location = new System.Drawing.Point(0, 0);
            this.sheet2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.sheet2.Name = "sheet2";
            this.sheet2.ShowThemedHeaders = C1.Win.FlexGrid.ShowThemedHeadersEnum.None;
            this.sheet2.Size = new System.Drawing.Size(965, 514);
            this.sheet2.StyleInfo = resources.GetString("sheet2.StyleInfo");
            this.sheet2.TabIndex = 21;
            this.sheet2.Tree.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.sheet2.VisualStyle = C1.Win.FlexGrid.VisualStyle.Custom;
            this.sheet2.SelChange += new System.EventHandler(this.flexGridSheet2_SelChange);
            // 
            // ExcelEngineDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 567);
            this.Controls.Add(this.c1DockingTab1);
            this.Controls.Add(this.panel1);
            this.Name = "ExcelEngineDemo";
            this.Text = "ExcelEngine Sample";
            this.Load += new System.EventHandler(this.ExcelEngineDemo_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).EndInit();
            this.c1DockingTab1.ResumeLayout(false);
            this.c1DockingTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sheet1)).EndInit();
            this.c1DockingTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sheet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private C1.Win.Command.C1DockingTab c1DockingTab1;
        private C1.Win.Command.C1DockingTabPage c1DockingTabPage1;
        private C1.Win.FlexGrid.C1FlexGrid sheet1;
        private C1.Win.Command.C1DockingTabPage c1DockingTabPage2;
        private ExcelFlexGrid sheet2;
        private Formula formula1;
    }
}

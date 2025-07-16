namespace GroupPanel
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
            this.groupPanel = new C1.Win.FlexGrid.C1FlexGridGroupPanel();
            this.flexGrid = new C1.Win.FlexGrid.C1FlexGrid();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.themeController = new C1.Win.Themes.C1ThemeController();
            ((System.ComponentModel.ISupportInitialize)(this.flexGrid)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.themeController)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel
            // 
            this.groupPanel.AutoSize = true;
            this.groupPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel.FlexGrid = this.flexGrid;
            this.groupPanel.Name = "groupPanel";
            this.groupPanel.TabIndex = 0;
            this.themeController.SetTheme(this.groupPanel, "(default)");
            // 
            // flexGrid
            // 
            this.flexGrid.BackColor = System.Drawing.Color.White;
            this.flexGrid.BorderStyle = C1.Win.FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.flexGrid.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.flexGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flexGrid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.flexGrid.Name = "flexGrid";
            this.flexGrid.Rows.DefaultSize = 23;
            this.flexGrid.ShowThemedHeaders = C1.Win.FlexGrid.ShowThemedHeadersEnum.None;
            this.flexGrid.StyleInfo = resources.GetString("c1FlexGrid1.StyleInfo");
            this.flexGrid.TabIndex = 0;
            this.themeController.SetTheme(this.flexGrid, "(default)");
            this.flexGrid.Tree.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.Controls.Add(this.groupPanel, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.flexGrid, 0, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.TabIndex = 1;
            this.themeController.SetTheme(this.tableLayoutPanel, "(default)");
            // 
            // themeController
            // 
            this.themeController.Theme = "Office365Green";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Name = "Form1";
            this.Text = "C1FlexGrid: Group Panel";
            this.themeController.SetTheme(this, "(default)");
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flexGrid)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.themeController)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.FlexGrid.C1FlexGridGroupPanel groupPanel;
        private C1.Win.FlexGrid.C1FlexGrid flexGrid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private C1.Win.Themes.C1ThemeController themeController;
    }
}


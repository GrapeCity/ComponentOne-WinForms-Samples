namespace ControlExplorer.FlexGrid
{
    partial class ColumnSizingMethods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColumnSizingMethods));
            this.flexGrid = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.cmbMethod = new System.Windows.Forms.ComboBox();
            this.label = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.flexGrid)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // flexGrid
            // 
            this.flexGrid.BackColor = System.Drawing.Color.White;
            this.flexGrid.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.flexGrid.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.flexGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flexGrid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.flexGrid.Location = new System.Drawing.Point(0, 34);
            this.flexGrid.Name = "flexGrid";
            this.flexGrid.Rows.DefaultSize = 22;
            this.flexGrid.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None;
            this.flexGrid.Size = new System.Drawing.Size(1135, 595);
            this.flexGrid.StyleInfo = resources.GetString("flexGrid.StyleInfo");
            this.flexGrid.TabIndex = 1;
            this.flexGrid.Tree.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            // 
            // cmbMethod
            // 
            this.cmbMethod.FormattingEnabled = true;
            this.cmbMethod.Location = new System.Drawing.Point(103, 6);
            this.cmbMethod.Name = "cmbGroup";
            this.cmbMethod.Size = new System.Drawing.Size(232, 21);
            this.cmbMethod.TabIndex = 2;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(17, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(76, 13);
            this.label.TabIndex = 3;
            this.label.Text = "Sizing method:";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.cmbMethod);
            this.panel.Controls.Add(this.label);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1135, 34);
            this.panel.TabIndex = 4;
            // 
            // ColumnSizingOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 629);
            this.Controls.Add(this.flexGrid);
            this.Controls.Add(this.panel);
            this.Name = "ColumnSizingOptions";
            this.Text = "ColumnSizingOptions";
            this.Load += new System.EventHandler(this.ColumnSizingOptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flexGrid)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        private C1.Win.C1FlexGrid.C1FlexGrid flexGrid;
        private System.Windows.Forms.ComboBox cmbMethod;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Panel panel;

        #endregion
    }
}
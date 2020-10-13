namespace ControlExplorer.FlexGrid
{
    partial class GroupDescriptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupDescriptions));
            this.flexGrid = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.flexGrid)).BeginInit();
            this.panel1.SuspendLayout();
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
            // cmbGroup
            // 
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(77, 6);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(232, 21);
            this.cmbGroup.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Group By:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbGroup);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1135, 34);
            this.panel1.TabIndex = 4;
            // 
            // GroupDescriptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 629);
            this.Controls.Add(this.flexGrid);
            this.Controls.Add(this.panel1);
            this.Name = "GroupDescriptions";
            this.Text = "GroupDescriptions";
            ((System.ComponentModel.ISupportInitialize)(this.flexGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1FlexGrid.C1FlexGrid flexGrid;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}
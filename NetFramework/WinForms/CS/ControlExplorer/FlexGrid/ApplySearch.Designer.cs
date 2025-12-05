namespace ControlExplorer.FlexGrid
{
    partial class ApplySearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplySearch));
            this.cmbHlMode = new System.Windows.Forms.ComboBox();
            this.label = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.cmbTemplates = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.c1FlexGridSearchPanel1 = new C1.Win.FlexGrid.C1FlexGridSearchPanel();
            this.flexGrid = new C1.Win.FlexGrid.C1FlexGrid();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flexGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbHlMode
            // 
            this.cmbHlMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHlMode.FormattingEnabled = true;
            this.cmbHlMode.Location = new System.Drawing.Point(104, 6);
            this.cmbHlMode.Name = "cmbHlMode";
            this.cmbHlMode.Size = new System.Drawing.Size(120, 21);
            this.cmbHlMode.TabIndex = 2;
            this.cmbHlMode.SelectedIndexChanged += new System.EventHandler(this.cmbHlMode_SelectedIndexChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(17, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(81, 13);
            this.label.TabIndex = 3;
            this.label.Text = "Highlight Mode:";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.cmbTemplates);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.cmbFilter);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.cmbHlMode);
            this.panel.Controls.Add(this.label);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1499, 34);
            this.panel.TabIndex = 4;
            // 
            // cmbTemplates
            // 
            this.cmbTemplates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTemplates.FormattingEnabled = true;
            this.cmbTemplates.Items.AddRange(new object[] {
            "\"a\"\"B\"",
            "123",
            "\"V\"-\"c\"-\"O\"",
            "+\"Ma\"-\"d\"",
            "+\"r\"\"oD\"",
            "\"g p\"\"- 5\""});
            this.cmbTemplates.Location = new System.Drawing.Point(589, 6);
            this.cmbTemplates.Name = "cmbTemplates";
            this.cmbTemplates.Size = new System.Drawing.Size(120, 21);
            this.cmbTemplates.TabIndex = 4;
            this.cmbTemplates.SelectedIndexChanged += new System.EventHandler(this.cmbTemplates_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(487, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search Templates:";
            // 
            // cmbFilter
            // 
            this.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Items.AddRange(new object[] {
            "Enabled",
            "Disabled"});
            this.cmbFilter.Location = new System.Drawing.Point(328, 6);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(120, 21);
            this.cmbFilter.TabIndex = 4;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Filter Results:";
            // 
            // c1FlexGridSearchPanel1
            // 
            this.c1FlexGridSearchPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.c1FlexGridSearchPanel1.Location = new System.Drawing.Point(0, 34);
            this.c1FlexGridSearchPanel1.Name = "c1FlexGridSearchPanel1";
            this.c1FlexGridSearchPanel1.SearchMode = C1.Win.FlexGrid.SearchMode.Always;
            this.c1FlexGridSearchPanel1.Size = new System.Drawing.Size(1499, 30);
            this.c1FlexGridSearchPanel1.TabIndex = 5;
            // 
            // flexGrid
            // 
            this.flexGrid.BackColor = System.Drawing.Color.White;
            this.flexGrid.BorderStyle = C1.Win.FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.flexGrid.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.flexGrid.ColumnPickerInfo.SearchMode = C1.Win.FlexGrid.ColumnPickerSearchMode.None;
            this.flexGrid.ColumnPickerInfo.ShowColumnMenuItem = false;
            this.flexGrid.ColumnPickerInfo.ShowToolButton = false;
            this.flexGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flexGrid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.flexGrid.Location = new System.Drawing.Point(0, 64);
            this.flexGrid.Name = "flexGrid";
            this.flexGrid.Rows.DefaultSize = 22;
            this.flexGrid.ShowThemedHeaders = C1.Win.FlexGrid.ShowThemedHeadersEnum.None;
            this.flexGrid.Size = new System.Drawing.Size(1499, 828);
            this.flexGrid.StyleInfo = resources.GetString("flexGrid.StyleInfo");
            this.flexGrid.TabIndex = 1;
            this.flexGrid.Tree.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            // 
            // ApplySearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1499, 892);
            this.Controls.Add(this.flexGrid);
            this.Controls.Add(this.c1FlexGridSearchPanel1);
            this.Controls.Add(this.panel);
            this.Name = "ApplySearch";
            this.Text = "ColumnSizingOptions";
            this.Load += new System.EventHandler(this.ApplySearch_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flexGrid)).EndInit();
            this.ResumeLayout(false);

        }

        private C1.Win.FlexGrid.C1FlexGrid flexGrid;
        private System.Windows.Forms.ComboBox cmbHlMode;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Panel panel;

        #endregion

        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTemplates;
        private C1.Win.FlexGrid.C1FlexGridSearchPanel c1FlexGridSearchPanel1;
        private System.Windows.Forms.Label label2;
    }
}
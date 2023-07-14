namespace FlexGridExplorer.Samples
{
    partial class HoverStyle
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
            this.c1FlexGrid1 = new C1.Win.FlexGrid.C1FlexGrid();
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cbHoverMode = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.cbSelectMode = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClearFilters = new System.Windows.Forms.ToolStripButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).BeginInit();
            this.tsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // c1FlexGrid1
            // 
            this.c1FlexGrid1.AllowFiltering = true;
            this.c1FlexGrid1.AllowResizing = C1.Win.FlexGrid.AllowResizingEnum.Both;
            this.c1FlexGrid1.ColumnContextMenuEnabled = true;
            this.c1FlexGrid1.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            this.c1FlexGrid1.ColumnPickerInfo.SearchMode = C1.Win.FlexGrid.ColumnPickerSearchMode.Highlight;
            this.c1FlexGrid1.ColumnPickerInfo.ShowToolButton = true;
            this.c1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1FlexGrid1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.c1FlexGrid1.Location = new System.Drawing.Point(0, 66);
            this.c1FlexGrid1.Name = "c1FlexGrid1";
            this.c1FlexGrid1.Size = new System.Drawing.Size(1016, 694);
            this.c1FlexGrid1.TabIndex = 6;
            this.c1FlexGrid1.Tree.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            // 
            // tsMenu
            // 
            this.tsMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.cbHoverMode,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.cbSelectMode,
            this.toolStripSeparator2,
            this.btnClearFilters});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(999, 25);
            this.tsMenu.TabIndex = 2;
            this.tsMenu.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(76, 22);
            this.toolStripLabel1.Text = "Hover Mode:";
            // 
            // cmbHoverMode
            // 
            this.cbHoverMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHoverMode.Name = "cmbHoverMode";
            this.cbHoverMode.Size = new System.Drawing.Size(121, 25);
            this.cbHoverMode.SelectedIndexChanged += new System.EventHandler(this.cbHoverMode_SelectedIndexChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(75, 22);
            this.toolStripLabel2.Text = "Select Mode:";
            // 
            // cmbSelectMode
            // 
            this.cbSelectMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectMode.Name = "cmbSelectMode";
            this.cbSelectMode.Size = new System.Drawing.Size(121, 25);
            this.cbSelectMode.SelectedIndexChanged += new System.EventHandler(this.cbSelectMode_SelectedIndexChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnClearFilters
            // 
            this.btnClearFilters.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnClearFilters.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Size = new System.Drawing.Size(84, 22);
            this.btnClearFilters.Text = "Hover Color...";
            this.btnClearFilters.ToolTipText = "Clear All Filters";
            this.btnClearFilters.Click += new System.EventHandler(this.btnClearFilters_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 0;
            // 
            // HoverStyle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.c1FlexGrid1);
            this.Controls.Add(this.tsMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "HoverStyle";
            this.Size = new System.Drawing.Size(999, 777);
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).EndInit();
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.FlexGrid.C1FlexGrid c1FlexGrid1;
        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton btnClearFilters;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cbHoverMode;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox cbSelectMode;
    }
}

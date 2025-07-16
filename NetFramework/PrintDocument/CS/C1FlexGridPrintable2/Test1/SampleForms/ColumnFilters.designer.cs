namespace ColumnFilters
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
            this._tab = new System.Windows.Forms.TabControl();
            this._pgDefault = new System.Windows.Forms.TabPage();
            this._flexDefault = new C1.Win.FlexGrid.C1FlexGrid();
            this._pgCustomize = new System.Windows.Forms.TabPage();
            this._flexCustom = new C1.Win.FlexGrid.C1FlexGrid();
            this._pgGroup = new System.Windows.Forms.TabPage();
            this._flexGroup = new C1.Win.FlexGrid.C1FlexGrid();
            this._pgBigger = new System.Windows.Forms.TabPage();
            this._flexBigger = new C1.Win.FlexGrid.C1FlexGrid();
            this._pgStyles = new System.Windows.Forms.TabPage();
            this._flexStyles = new C1.Win.FlexGrid.C1FlexGrid();
            this._pgSearch = new System.Windows.Forms.TabPage();
            this._lblSearchCount = new System.Windows.Forms.Label();
            this._flexSearch = new C1.Win.FlexGrid.C1FlexGrid();
            this._searchBox = new ColumnFilters.SearchBox();
            this._pgHelp = new System.Windows.Forms.TabPage();
            this._rtfHelp = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this._status = new System.Windows.Forms.ToolStripStatusLabel();
            this._showFilter = new System.Windows.Forms.ToolStripStatusLabel();
            this._tab.SuspendLayout();
            this._pgDefault.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._flexDefault)).BeginInit();
            this._pgCustomize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._flexCustom)).BeginInit();
            this._pgGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._flexGroup)).BeginInit();
            this._pgBigger.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._flexBigger)).BeginInit();
            this._pgStyles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._flexStyles)).BeginInit();
            this._pgSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._flexSearch)).BeginInit();
            this._pgHelp.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _tab
            // 
            this._tab.Controls.Add(this._pgDefault);
            this._tab.Controls.Add(this._pgCustomize);
            this._tab.Controls.Add(this._pgGroup);
            this._tab.Controls.Add(this._pgBigger);
            this._tab.Controls.Add(this._pgStyles);
            this._tab.Controls.Add(this._pgSearch);
            this._tab.Controls.Add(this._pgHelp);
            this._tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tab.Location = new System.Drawing.Point(0, 0);
            this._tab.Name = "_tab";
            this._tab.SelectedIndex = 0;
            this._tab.Size = new System.Drawing.Size(730, 430);
            this._tab.TabIndex = 3;
            this._tab.SelectedIndexChanged += new System.EventHandler(this._tab_SelectedIndexChanged);
            // 
            // _pgDefault
            // 
            this._pgDefault.Controls.Add(this._flexDefault);
            this._pgDefault.Location = new System.Drawing.Point(4, 24);
            this._pgDefault.Name = "_pgDefault";
            this._pgDefault.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._pgDefault.Size = new System.Drawing.Size(722, 402);
            this._pgDefault.TabIndex = 0;
            this._pgDefault.Tag = "Default filters created by setting _flex.AllowFiltering = true (move mouse over c" +
                "olumn headers to set).";
            this._pgDefault.Text = "Default Filter";
            this._pgDefault.UseVisualStyleBackColor = true;
            // 
            // _flexDefault
            // 
            this._flexDefault.BorderStyle = C1.Win.FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D;
            this._flexDefault.ColumnInfo = "10,1,0,0,0,110,Columns:0{Width:31;}\t";
            this._flexDefault.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flexDefault.Location = new System.Drawing.Point(4, 4);
            this._flexDefault.Name = "_flexDefault";
            this._flexDefault.Rows.DefaultSize = 22;
            this._flexDefault.Size = new System.Drawing.Size(714, 394);
            this._flexDefault.StyleInfo = resources.GetString("_flexDefault.StyleInfo");
            this._flexDefault.TabIndex = 0;
            this._flexDefault.VisualStyle = C1.Win.FlexGrid.VisualStyle.System;
            // 
            // _pgCustomize
            // 
            this._pgCustomize.Controls.Add(this._flexCustom);
            this._pgCustomize.Location = new System.Drawing.Point(4, 24);
            this._pgCustomize.Name = "_pgCustomize";
            this._pgCustomize.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._pgCustomize.Size = new System.Drawing.Size(717, 405);
            this._pgCustomize.TabIndex = 4;
            this._pgCustomize.Tag = "Filters applied to specific columns and created in code.";
            this._pgCustomize.Text = "Customize Filters";
            this._pgCustomize.UseVisualStyleBackColor = true;
            // 
            // _flexCustom
            // 
            this._flexCustom.BorderStyle = C1.Win.FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D;
            this._flexCustom.ColumnInfo = "10,1,0,0,0,110,Columns:0{Width:31;}\t";
            this._flexCustom.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flexCustom.Location = new System.Drawing.Point(4, 4);
            this._flexCustom.Name = "_flexCustom";
            this._flexCustom.Rows.DefaultSize = 22;
            this._flexCustom.Size = new System.Drawing.Size(716, 399);
            this._flexCustom.StyleInfo = resources.GetString("_flexCustom.StyleInfo");
            this._flexCustom.TabIndex = 1;
            this._flexCustom.VisualStyle = C1.Win.FlexGrid.VisualStyle.Office2007Blue;
            // 
            // _pgGroup
            // 
            this._pgGroup.Controls.Add(this._flexGroup);
            this._pgGroup.Location = new System.Drawing.Point(4, 24);
            this._pgGroup.Name = "_pgGroup";
            this._pgGroup.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._pgGroup.Size = new System.Drawing.Size(717, 405);
            this._pgGroup.TabIndex = 1;
            this._pgGroup.Tag = "Filtering and grouping working together.";
            this._pgGroup.Text = "Filter and Group";
            this._pgGroup.UseVisualStyleBackColor = true;
            // 
            // _flexGroup
            // 
            this._flexGroup.BorderStyle = C1.Win.FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D;
            this._flexGroup.ColumnInfo = "10,1,0,0,0,110,Columns:0{Width:31;}\t";
            this._flexGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flexGroup.Location = new System.Drawing.Point(4, 4);
            this._flexGroup.Name = "_flexGroup";
            this._flexGroup.Rows.DefaultSize = 22;
            this._flexGroup.Size = new System.Drawing.Size(716, 399);
            this._flexGroup.StyleInfo = resources.GetString("_flexGroup.StyleInfo");
            this._flexGroup.TabIndex = 1;
            this._flexGroup.VisualStyle = C1.Win.FlexGrid.VisualStyle.Office2007Blue;
            // 
            // _pgBigger
            // 
            this._pgBigger.Controls.Add(this._flexBigger);
            this._pgBigger.Location = new System.Drawing.Point(4, 24);
            this._pgBigger.Name = "_pgBigger";
            this._pgBigger.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._pgBigger.Size = new System.Drawing.Size(717, 405);
            this._pgBigger.TabIndex = 3;
            this._pgBigger.Tag = "Filtering applied to a slightly larger table.";
            this._pgBigger.Text = "Bigger Table";
            this._pgBigger.UseVisualStyleBackColor = true;
            // 
            // _flexBigger
            // 
            this._flexBigger.BorderStyle = C1.Win.FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D;
            this._flexBigger.ColumnInfo = "10,1,0,0,0,110,Columns:0{Width:31;}\t";
            this._flexBigger.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flexBigger.Location = new System.Drawing.Point(4, 4);
            this._flexBigger.Name = "_flexBigger";
            this._flexBigger.Rows.DefaultSize = 22;
            this._flexBigger.Size = new System.Drawing.Size(716, 399);
            this._flexBigger.StyleInfo = resources.GetString("_flexBigger.StyleInfo");
            this._flexBigger.TabIndex = 1;
            this._flexBigger.VisualStyle = C1.Win.FlexGrid.VisualStyle.Office2007Blue;
            // 
            // _pgStyles
            // 
            this._pgStyles.Controls.Add(this._flexStyles);
            this._pgStyles.Location = new System.Drawing.Point(4, 24);
            this._pgStyles.Name = "_pgStyles";
            this._pgStyles.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._pgStyles.Size = new System.Drawing.Size(717, 405);
            this._pgStyles.TabIndex = 6;
            this._pgStyles.Tag = "Use the filter to apply styles instead of hiding rows.";
            this._pgStyles.Text = "Style Filter";
            this._pgStyles.UseVisualStyleBackColor = true;
            // 
            // _flexStyles
            // 
            this._flexStyles.BorderStyle = C1.Win.FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D;
            this._flexStyles.ColumnInfo = "10,1,0,0,0,110,Columns:0{Width:31;}\t";
            this._flexStyles.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flexStyles.Location = new System.Drawing.Point(4, 4);
            this._flexStyles.Name = "_flexStyles";
            this._flexStyles.Rows.DefaultSize = 22;
            this._flexStyles.Size = new System.Drawing.Size(716, 399);
            this._flexStyles.StyleInfo = resources.GetString("_flexStyles.StyleInfo");
            this._flexStyles.TabIndex = 1;
            this._flexStyles.VisualStyle = C1.Win.FlexGrid.VisualStyle.Office2007Blue;
            // 
            // _pgSearch
            // 
            this._pgSearch.BackColor = System.Drawing.Color.Transparent;
            this._pgSearch.Controls.Add(this._lblSearchCount);
            this._pgSearch.Controls.Add(this._flexSearch);
            this._pgSearch.Controls.Add(this._searchBox);
            this._pgSearch.Location = new System.Drawing.Point(4, 24);
            this._pgSearch.Name = "_pgSearch";
            this._pgSearch.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._pgSearch.Size = new System.Drawing.Size(717, 405);
            this._pgSearch.TabIndex = 2;
            this._pgSearch.Tag = "Global iTunes-style search implemented with a GridColumnFilter.";
            this._pgSearch.Text = "iTunes Search";
            this._pgSearch.UseVisualStyleBackColor = true;
            // 
            // _lblSearchCount
            // 
            this._lblSearchCount.AutoSize = true;
            this._lblSearchCount.Location = new System.Drawing.Point(226, 12);
            this._lblSearchCount.Name = "_lblSearchCount";
            this._lblSearchCount.Size = new System.Drawing.Size(0, 15);
            this._lblSearchCount.TabIndex = 3;
            // 
            // _flexSearch
            // 
            this._flexSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._flexSearch.BorderStyle = C1.Win.FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D;
            this._flexSearch.ColumnInfo = "10,1,0,0,0,110,Columns:0{Width:31;}\t";
            this._flexSearch.Location = new System.Drawing.Point(3, 37);
            this._flexSearch.Name = "_flexSearch";
            this._flexSearch.Rows.DefaultSize = 22;
            this._flexSearch.Size = new System.Drawing.Size(716, 365);
            this._flexSearch.StyleInfo = resources.GetString("_flexSearch.StyleInfo");
            this._flexSearch.TabIndex = 1;
            this._flexSearch.VisualStyle = C1.Win.FlexGrid.VisualStyle.Office2007Blue;
            // 
            // _searchBox
            // 
            this._searchBox.AutoSize = true;
            this._searchBox.Delay = 500;
            this._searchBox.Location = new System.Drawing.Point(7, 7);
            this._searchBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._searchBox.Name = "_searchBox";
            this._searchBox.Size = new System.Drawing.Size(211, 24);
            this._searchBox.TabIndex = 2;
            this._searchBox.Search += new System.EventHandler(this._searchBox_Search);
            // 
            // _pgHelp
            // 
            this._pgHelp.Controls.Add(this._rtfHelp);
            this._pgHelp.Location = new System.Drawing.Point(4, 24);
            this._pgHelp.Name = "_pgHelp";
            this._pgHelp.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._pgHelp.Size = new System.Drawing.Size(717, 405);
            this._pgHelp.TabIndex = 5;
            this._pgHelp.Tag = "Quick tips on filtering.";
            this._pgHelp.Text = "Help";
            this._pgHelp.UseVisualStyleBackColor = true;
            // 
            // _rtfHelp
            // 
            this._rtfHelp.BackColor = System.Drawing.SystemColors.Window;
            this._rtfHelp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._rtfHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this._rtfHelp.Location = new System.Drawing.Point(4, 4);
            this._rtfHelp.Name = "_rtfHelp";
            this._rtfHelp.ReadOnly = true;
            this._rtfHelp.Size = new System.Drawing.Size(715, 398);
            this._rtfHelp.TabIndex = 0;
            this._rtfHelp.Text = "";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._status,
            this._showFilter});
            this.statusStrip1.Location = new System.Drawing.Point(0, 430);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.ShowItemToolTips = true;
            this.statusStrip1.Size = new System.Drawing.Size(730, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // _status
            // 
            this._status.Name = "_status";
            this._status.Size = new System.Drawing.Size(699, 17);
            this._status.Spring = true;
            this._status.Text = "Ready";
            this._status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _showFilter
            // 
            this._showFilter.Image = ((System.Drawing.Image)(resources.GetObject("_showFilter.Image")));
            this._showFilter.Name = "_showFilter";
            this._showFilter.Size = new System.Drawing.Size(16, 17);
            this._showFilter.ToolTipText = "Show Currently Active Filters";
            this._showFilter.Click += new System.EventHandler(this._showFilter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(730, 452);
            this.Controls.Add(this._tab);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1FlexGrid: Column Filters";
            this._tab.ResumeLayout(false);
            this._pgDefault.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._flexDefault)).EndInit();
            this._pgCustomize.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._flexCustom)).EndInit();
            this._pgGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._flexGroup)).EndInit();
            this._pgBigger.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._flexBigger)).EndInit();
            this._pgStyles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._flexStyles)).EndInit();
            this._pgSearch.ResumeLayout(false);
            this._pgSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._flexSearch)).EndInit();
            this._pgHelp.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl _tab;
        private System.Windows.Forms.TabPage _pgDefault;
        private C1.Win.FlexGrid.C1FlexGrid _flexDefault;
        private System.Windows.Forms.TabPage _pgGroup;
        private C1.Win.FlexGrid.C1FlexGrid _flexGroup;
        private System.Windows.Forms.TabPage _pgSearch;
        private C1.Win.FlexGrid.C1FlexGrid _flexSearch;
        private System.Windows.Forms.TabPage _pgBigger;
        private C1.Win.FlexGrid.C1FlexGrid _flexBigger;
        private System.Windows.Forms.TabPage _pgCustomize;
        private C1.Win.FlexGrid.C1FlexGrid _flexCustom;
        private SearchBox _searchBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel _status;
        private System.Windows.Forms.ToolStripStatusLabel _showFilter;
        private System.Windows.Forms.TabPage _pgHelp;
        private System.Windows.Forms.RichTextBox _rtfHelp;
        private System.Windows.Forms.Label _lblSearchCount;
        private System.Windows.Forms.TabPage _pgStyles;
        private C1.Win.FlexGrid.C1FlexGrid _flexStyles;

    }
}


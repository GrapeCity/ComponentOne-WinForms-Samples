namespace ColumnPicker
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.c1Ribbon1 = new C1.Win.Ribbon.C1Ribbon();
            this.ribbonApplicationMenu1 = new C1.Win.Ribbon.RibbonApplicationMenu();
            this.ribbonBottomToolBar1 = new C1.Win.Ribbon.RibbonBottomToolBar();
            this.ribbonConfigToolBar1 = new C1.Win.Ribbon.RibbonConfigToolBar();
            this.ribbonQat1 = new C1.Win.Ribbon.RibbonQat();
            this.ribbonTab1 = new C1.Win.Ribbon.RibbonTab();
            this.ribbonGroup1 = new C1.Win.Ribbon.RibbonGroup();
            this.cmbTheme = new C1.Win.Ribbon.RibbonComboBox();
            this.ribbonGroup2 = new C1.Win.Ribbon.RibbonGroup();
            this.rbCreateBands = new C1.Win.Ribbon.RibbonButton();
            this.rbRemoveBands = new C1.Win.Ribbon.RibbonButton();
            this.ribbonTopToolBar1 = new C1.Win.Ribbon.RibbonTopToolBar();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.c1NWindDataSet = new ColumnPicker.C1NWindDataSet();
            this.ordersTableAdapter = new ColumnPicker.C1NWindDataSetTableAdapters.OrdersTableAdapter();
            this.c1FlexGridBandedView1 = new C1.Win.FlexGrid.C1FlexGridBandedView();
            this.c1ThemeController1 = new C1.Win.Themes.C1ThemeController();
            this.c1FlexGrid1 = new C1.Win.FlexGrid.C1FlexGrid();
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1NWindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGridBandedView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1Ribbon1
            // 
            this.c1Ribbon1.ApplicationMenuHolder = this.ribbonApplicationMenu1;
            this.c1Ribbon1.BottomToolBarHolder = this.ribbonBottomToolBar1;
            this.c1Ribbon1.ConfigToolBarHolder = this.ribbonConfigToolBar1;
            this.c1Ribbon1.HideTabHeaderRow = true;
            this.c1Ribbon1.Location = new System.Drawing.Point(0, 0);
            this.c1Ribbon1.Name = "c1Ribbon1";
            this.c1Ribbon1.QatHolder = this.ribbonQat1;
            this.c1Ribbon1.Size = new System.Drawing.Size(1016, 77);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab1);
            this.c1ThemeController1.SetTheme(this.c1Ribbon1, "(default)");
            this.c1Ribbon1.TopToolBarHolder = this.ribbonTopToolBar1;
            this.c1Ribbon1.ViewMode = C1.Win.Ribbon.ViewMode.Simplified;
            // 
            // ribbonApplicationMenu1
            // 
            this.ribbonApplicationMenu1.Name = "ribbonApplicationMenu1";
            this.ribbonApplicationMenu1.Visible = false;
            // 
            // ribbonBottomToolBar1
            // 
            this.ribbonBottomToolBar1.Name = "ribbonBottomToolBar1";
            // 
            // ribbonConfigToolBar1
            // 
            this.ribbonConfigToolBar1.Name = "ribbonConfigToolBar1";
            // 
            // ribbonQat1
            // 
            this.ribbonQat1.Name = "ribbonQat1";
            this.ribbonQat1.Visible = false;
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Groups.Add(this.ribbonGroup1);
            this.ribbonTab1.Groups.Add(this.ribbonGroup2);
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Text = "Tab";
            // 
            // ribbonGroup1
            // 
            this.ribbonGroup1.Items.Add(this.cmbTheme);
            this.ribbonGroup1.Name = "ribbonGroup1";
            this.ribbonGroup1.Text = "Styles";
            // 
            // cmbTheme
            // 
            this.cmbTheme.Label = "Theme";
            this.cmbTheme.Name = "cmbTheme";
            this.cmbTheme.SelectedIndexChanged += new System.EventHandler(this.cmbTheme_SelectedIndexChanged);
            // 
            // ribbonGroup2
            // 
            this.ribbonGroup2.Items.Add(this.rbCreateBands);
            this.ribbonGroup2.Items.Add(this.rbRemoveBands);
            this.ribbonGroup2.Name = "ribbonGroup2";
            this.ribbonGroup2.Text = "Group";
            // 
            // rbCreateBands
            // 
            this.rbCreateBands.IconSet.Add(new C1.Framework.C1BitmapIcon("NewWindow", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "Preset_SmallImages", 274));
            this.rbCreateBands.IconSet.Add(new C1.Framework.C1BitmapIcon("NewWindow", new System.Drawing.Size(20, 20), System.Drawing.Color.Transparent, "Preset_MediumImages", 274));
            this.rbCreateBands.IconSet.Add(new C1.Framework.C1BitmapIcon("NewWindow", new System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, "Preset_LargeImages", 177));
            this.rbCreateBands.Name = "rbCreateBands";
            this.rbCreateBands.Text = "Create column bands";
            this.rbCreateBands.Click += new System.EventHandler(this.rbCreateBands_Click);
            // 
            // rbRemoveBands
            // 
            this.rbRemoveBands.IconSet.Add(new C1.Framework.C1BitmapIcon("Delete", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "Preset_SmallImages", 115));
            this.rbRemoveBands.IconSet.Add(new C1.Framework.C1BitmapIcon("Delete", new System.Drawing.Size(20, 20), System.Drawing.Color.Transparent, "Preset_MediumImages", 115));
            this.rbRemoveBands.IconSet.Add(new C1.Framework.C1BitmapIcon("Delete", new System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, "Preset_LargeImages", 67));
            this.rbRemoveBands.Name = "rbRemoveBands";
            this.rbRemoveBands.Text = "Remove column bands";
            this.rbRemoveBands.Click += new System.EventHandler(this.rbRemoveBands_Click);
            // 
            // ribbonTopToolBar1
            // 
            this.ribbonTopToolBar1.Name = "ribbonTopToolBar1";
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.c1NWindDataSet;
            // 
            // c1NWindDataSet
            // 
            this.c1NWindDataSet.DataSetName = "C1NWindDataSet";
            this.c1NWindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // c1FlexGridBandedView1
            // 
            this.c1FlexGridBandedView1.BandsColumnsRelation = C1.Win.FlexGrid.BandsColumnsRelation.BandsBeforeColumns;
            this.c1FlexGridBandedView1.ColumnContextMenuEnabled = true;
            // 
            // c1FlexGrid1
            // 
            this.c1FlexGrid1.ColumnContextMenuEnabled = true;
            this.c1FlexGrid1.ColumnInfo = resources.GetString("c1FlexGrid1.ColumnInfo");
            this.c1FlexGrid1.ColumnPickerInfo.SearchMode = C1.Win.FlexGrid.ColumnPickerSearchMode.Highlight;
            this.c1FlexGrid1.ColumnPickerInfo.ShowColumnMenuItem = true;
            this.c1FlexGrid1.ColumnPickerInfo.ShowToolButton = true;
            this.c1FlexGrid1.DataSource = this.ordersBindingSource;
            this.c1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1FlexGrid1.Location = new System.Drawing.Point(0, 77);
            this.c1FlexGrid1.Name = "c1FlexGrid1";
            this.c1FlexGrid1.Rows.Count = 1;
            this.c1FlexGrid1.Size = new System.Drawing.Size(1016, 683);
            this.c1FlexGrid1.TabIndex = 1;
            this.c1ThemeController1.SetTheme(this.c1FlexGrid1, "(default)");
            this.c1FlexGrid1.AllowEditing = false;
            this.c1FlexGrid1.Tree.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 760);
            this.Controls.Add(this.c1FlexGrid1);
            this.Controls.Add(this.c1Ribbon1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Column Picker Sample";
            this.c1ThemeController1.SetTheme(this, "(default)");
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1NWindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGridBandedView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.Ribbon.C1Ribbon c1Ribbon1;
        private C1.Win.Ribbon.RibbonApplicationMenu ribbonApplicationMenu1;
        private C1.Win.Ribbon.RibbonBottomToolBar ribbonBottomToolBar1;
        private C1.Win.Ribbon.RibbonConfigToolBar ribbonConfigToolBar1;
        private C1.Win.Ribbon.RibbonQat ribbonQat1;
        private C1.Win.Ribbon.RibbonTab ribbonTab1;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup1;
        private C1.Win.Ribbon.RibbonTopToolBar ribbonTopToolBar1;
        private C1.Win.Ribbon.RibbonComboBox cmbTheme;
        private C1.Win.Themes.C1ThemeController c1ThemeController1;
        private C1.Win.FlexGrid.C1FlexGrid c1FlexGrid1;
        private C1NWindDataSet c1NWindDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private C1NWindDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup2;
        private C1.Win.Ribbon.RibbonButton rbCreateBands;
        private C1.Win.Ribbon.RibbonButton rbRemoveBands;
        private C1.Win.FlexGrid.C1FlexGridBandedView c1FlexGridBandedView1;
    }
}


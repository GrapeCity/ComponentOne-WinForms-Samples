namespace CustomAutoSearch
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
            C1.Win.TreeView.C1TreeColumn c1TreeColumn2 = new C1.Win.TreeView.C1TreeColumn();
            this.c1Ribbon1 = new C1.Win.Ribbon.C1Ribbon();
            this.ribbonApplicationMenu1 = new C1.Win.Ribbon.RibbonApplicationMenu();
            this.ribbonBottomToolBar1 = new C1.Win.Ribbon.RibbonBottomToolBar();
            this.ribbonConfigToolBar1 = new C1.Win.Ribbon.RibbonConfigToolBar();
            this.ribbonQat1 = new C1.Win.Ribbon.RibbonQat();
            this.ribbonTab1 = new C1.Win.Ribbon.RibbonTab();
            this.ribbonGroup1 = new C1.Win.Ribbon.RibbonGroup();
            this.ribbonCmbThemes = new C1.Win.Ribbon.RibbonComboBox();
            this.ribbonGroup2 = new C1.Win.Ribbon.RibbonGroup();
            this.ribbonTextBox1 = new C1.Win.Ribbon.RibbonTextBox();
            this.ribbonTopToolBar1 = new C1.Win.Ribbon.RibbonTopToolBar();
            this.c1ThemeController1 = new C1.Win.Themes.C1ThemeController();
            this.c1TreeView1 = new C1.Win.TreeView.C1TreeView();
            this.dataSet1 = new CustomAutoSearch.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.territoriesTableAdapter = new CustomAutoSearch.DataSet1TableAdapters.TerritoriesTableAdapter();
            this.regionTableAdapter = new CustomAutoSearch.DataSet1TableAdapters.RegionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TreeView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // c1Ribbon1
            // 
            this.c1Ribbon1.ApplicationMenuHolder = this.ribbonApplicationMenu1;
            this.c1Ribbon1.AutoSizeElement = C1.Framework.AutoSizeElement.Width;
            this.c1Ribbon1.BottomToolBarHolder = this.ribbonBottomToolBar1;
            this.c1Ribbon1.ConfigToolBarHolder = this.ribbonConfigToolBar1;
            this.c1Ribbon1.Location = new System.Drawing.Point(0, 0);
            this.c1Ribbon1.Name = "c1Ribbon1";
            this.c1Ribbon1.QatHolder = this.ribbonQat1;
            this.c1Ribbon1.Size = new System.Drawing.Size(683, 143);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab1);
            this.c1ThemeController1.SetTheme(this.c1Ribbon1, "(default)");
            this.c1Ribbon1.TopToolBarHolder = this.ribbonTopToolBar1;
            // 
            // ribbonApplicationMenu1
            // 
            this.ribbonApplicationMenu1.Name = "ribbonApplicationMenu1";
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
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Groups.Add(this.ribbonGroup1);
            this.ribbonTab1.Groups.Add(this.ribbonGroup2);
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Text = "Styles";
            // 
            // ribbonGroup1
            // 
            this.ribbonGroup1.Items.Add(this.ribbonCmbThemes);
            this.ribbonGroup1.Name = "ribbonGroup1";
            this.ribbonGroup1.Text = "Theme";
            // 
            // ribbonCmbThemes
            // 
            this.ribbonCmbThemes.DropDownStyle = C1.Win.Ribbon.RibbonComboBoxStyle.DropDownList;
            this.ribbonCmbThemes.Name = "ribbonCmbThemes";
            this.ribbonCmbThemes.SelectedIndexChanged += new System.EventHandler(this.ribbonCmbThemes_SelectedIndexChanged);
            // 
            // ribbonGroup2
            // 
            this.ribbonGroup2.Items.Add(this.ribbonTextBox1);
            this.ribbonGroup2.Name = "ribbonGroup2";
            this.ribbonGroup2.Text = "AutoSearch";
            // 
            // ribbonTextBox1
            // 
            this.ribbonTextBox1.Label = "Search";
            this.ribbonTextBox1.Name = "ribbonTextBox1";
            this.ribbonTextBox1.TextChanged += new System.EventHandler(this.ribbonTextBox1_TextChanged);
            // 
            // ribbonTopToolBar1
            // 
            this.ribbonTopToolBar1.Name = "ribbonTopToolBar1";
            // 
            // c1TreeView1
            // 
            c1TreeColumn2.DisplayFieldName = "RegionDescription\\TerritoryDescription";
            c1TreeColumn2.HeaderText = "Region";
            c1TreeColumn2.Name = "Region";
            this.c1TreeView1.Columns.Add(c1TreeColumn2);
            this.c1TreeView1.BindingInfo.DataMember = null;
            this.c1TreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1TreeView1.BindingInfo.KeyField = null;
            this.c1TreeView1.Location = new System.Drawing.Point(0, 143);
            this.c1TreeView1.Name = "c1TreeView1";
            this.c1TreeView1.BindingInfo.ParentKeyField = null;
            this.c1TreeView1.ShowColumnHeaders = false;
            this.c1TreeView1.Size = new System.Drawing.Size(683, 355);
            this.c1TreeView1.TabIndex = 1;
            this.c1ThemeController1.SetTheme(this.c1TreeView1, "(default)");
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataMember = "Territories";
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            // 
            // territoriesTableAdapter
            // 
            this.territoriesTableAdapter.ClearBeforeFill = true;
            // 
            // regionTableAdapter
            // 
            this.regionTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 498);
            this.Controls.Add(this.c1TreeView1);
            this.Controls.Add(this.c1Ribbon1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Name = "MainForm";
            this.Text = "Form1";
            this.c1ThemeController1.SetTheme(this, "(default)");
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TreeView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
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
        private C1.Win.Themes.C1ThemeController c1ThemeController1;
        private C1.Win.Ribbon.RibbonComboBox ribbonCmbThemes;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup2;
        private C1.Win.Ribbon.RibbonTextBox ribbonTextBox1;
        private C1.Win.TreeView.C1TreeView c1TreeView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1TableAdapters.TerritoriesTableAdapter territoriesTableAdapter;
        private DataSet1TableAdapters.RegionTableAdapter regionTableAdapter;
    }
}


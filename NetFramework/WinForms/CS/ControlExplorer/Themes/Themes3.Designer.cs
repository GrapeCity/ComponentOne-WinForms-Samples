namespace ControlExplorer.Themes
{
    partial class Themes3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Themes3));
            C1.Framework.C1PathIcon c1PathIcon10 = new C1.Framework.C1PathIcon();
            C1.Framework.C1CompositeIcon c1CompositeIcon5 = new C1.Framework.C1CompositeIcon();
            this.c1FlexGrid1 = new C1.Win.FlexGrid.C1FlexGrid();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.c1DemoDataSet = new ControlExplorer.C1DemoDataSet();
            this.employeesTableAdapter = new ControlExplorer.C1DemoDataSetTableAdapters.EmployeesTableAdapter();
            this.c1ThemeController1 = new C1.Win.Themes.C1ThemeController();
            this.c1Ribbon1 = new C1.Win.Ribbon.C1Ribbon();
            this.ribbonApplicationMenu1 = new C1.Win.Ribbon.RibbonApplicationMenu();
            this.ribbonBottomToolBar1 = new C1.Win.Ribbon.RibbonBottomToolBar();
            this.ribbonConfigToolBar1 = new C1.Win.Ribbon.RibbonConfigToolBar();
            this.ribbonQat1 = new C1.Win.Ribbon.RibbonQat();
            this.tab1 = new C1.Win.Ribbon.RibbonTab();
            this.ribbonGroup1 = new C1.Win.Ribbon.RibbonGroup();
            this.ribbonButton2 = new C1.Win.Ribbon.RibbonButton();
            this.ribbonButton1 = new C1.Win.Ribbon.RibbonButton();
            this.ribbonGroup3 = new C1.Win.Ribbon.RibbonGroup();
            this.ribbonComboBox1 = new C1.Win.Ribbon.RibbonComboBox();
            this.ribbonGroup4 = new C1.Win.Ribbon.RibbonGroup();
            this.ribbonToolBar1 = new C1.Win.Ribbon.RibbonToolBar();
            this.ribbonComboBox2 = new C1.Win.Ribbon.RibbonComboBox();
            this.rbtnClearFilter1 = new C1.Win.Ribbon.RibbonButton();
            this.ribbonToolBar2 = new C1.Win.Ribbon.RibbonToolBar();
            this.ribbonDatePicker1 = new C1.Win.Ribbon.RibbonDatePicker();
            this.rbtnClearFilter2 = new C1.Win.Ribbon.RibbonButton();
            this.ribbonToolBar3 = new C1.Win.Ribbon.RibbonToolBar();
            this.ribbonNumericBox1 = new C1.Win.Ribbon.RibbonNumericBox();
            this.rbtnClearFilter3 = new C1.Win.Ribbon.RibbonButton();
            this.ribbonTab2 = new C1.Win.Ribbon.RibbonTab();
            this.ribbonGroup2 = new C1.Win.Ribbon.RibbonGroup();
            this.ribbonColorPicker1 = new C1.Win.Ribbon.RibbonColorPicker();
            this.ribbonFontComboBox1 = new C1.Win.Ribbon.RibbonFontComboBox();
            this.ribbonTopToolBar1 = new C1.Win.Ribbon.RibbonTopToolBar();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DemoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1FlexGrid1
            // 
            this.c1FlexGrid1.ColumnInfo = resources.GetString("c1FlexGrid1.ColumnInfo");
            this.c1FlexGrid1.DataSource = this.employeesBindingSource;
            this.c1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1FlexGrid1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.c1FlexGrid1.Location = new System.Drawing.Point(0, 0);
            this.c1FlexGrid1.Name = "c1FlexGrid1";
            this.c1FlexGrid1.Rows.Count = 1;
            this.c1FlexGrid1.ShowThemedHeaders = C1.Win.FlexGrid.ShowThemedHeadersEnum.None;
            this.c1FlexGrid1.Size = new System.Drawing.Size(1036, 503);
            this.c1FlexGrid1.TabIndex = 0;
            this.c1ThemeController1.SetTheme(this.c1FlexGrid1, "(default)");
            this.c1FlexGrid1.Tree.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.c1DemoDataSet;
            // 
            // c1DemoDataSet
            // 
            this.c1DemoDataSet.DataSetName = "C1DemoDataSet";
            this.c1DemoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
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
            this.c1Ribbon1.Size = new System.Drawing.Size(1036, 157);
            this.c1Ribbon1.Tabs.Add(this.tab1);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab2);
            this.c1ThemeController1.SetTheme(this.c1Ribbon1, "(default)");
            this.c1Ribbon1.TopToolBarHolder = this.ribbonTopToolBar1;
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
            // tab1
            // 
            this.tab1.Groups.Add(this.ribbonGroup1);
            this.tab1.Groups.Add(this.ribbonGroup3);
            this.tab1.Groups.Add(this.ribbonGroup4);
            this.tab1.Name = "tab1";
            this.tab1.Text = "Home";
            // 
            // ribbonGroup1
            // 
            this.ribbonGroup1.Items.Add(this.ribbonButton2);
            this.ribbonGroup1.Items.Add(this.ribbonButton1);
            this.ribbonGroup1.Name = "ribbonGroup1";
            this.ribbonGroup1.Text = "Zoom";
            // 
            // ribbonButton2
            // 
            this.ribbonButton2.IconSet.Add(new C1.Framework.C1BitmapIcon("ZoomOut", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "Preset_SmallImages", 510));
            this.ribbonButton2.Name = "ribbonButton2";
            this.ribbonButton2.Text = "Zoom Out";
            this.ribbonButton2.Click += new System.EventHandler(this.ribbonButton2_Click);
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.IconSet.Add(new C1.Framework.C1BitmapIcon("ZoomIn", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "Preset_SmallImages", 509));
            this.ribbonButton1.Name = "ribbonButton1";
            this.ribbonButton1.Text = "Zoom In";
            this.ribbonButton1.Click += new System.EventHandler(this.ribbonButton1_Click);
            // 
            // ribbonGroup3
            // 
            this.ribbonGroup3.IconSet.Add(new C1.Framework.C1BitmapIcon("Themes", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "Preset_SmallImages", 462));
            this.ribbonGroup3.Items.Add(this.ribbonComboBox1);
            this.ribbonGroup3.Name = "ribbonGroup3";
            this.ribbonGroup3.Text = "Theme";
            // 
            // ribbonComboBox1
            // 
            this.ribbonComboBox1.Label = "Theme:";
            this.ribbonComboBox1.Name = "ribbonComboBox1";
            this.ribbonComboBox1.TextAreaWidth = 180;
            this.ribbonComboBox1.SelectedIndexChanged += new System.EventHandler(this.ribbonComboBox1_SelectedIndexChanged);
            // 
            // ribbonGroup4
            // 
            this.ribbonGroup4.IconSet.Add(new C1.Framework.C1BitmapIcon("AdvancedFilter", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "Preset_SmallImages", 4));
            this.ribbonGroup4.Items.Add(this.ribbonToolBar1);
            this.ribbonGroup4.Items.Add(this.ribbonToolBar2);
            this.ribbonGroup4.Items.Add(this.ribbonToolBar3);
            this.ribbonGroup4.Name = "ribbonGroup4";
            this.ribbonGroup4.Text = "Filters";
            // 
            // ribbonToolBar1
            // 
            this.ribbonToolBar1.Items.Add(this.ribbonComboBox2);
            this.ribbonToolBar1.Items.Add(this.rbtnClearFilter1);
            this.ribbonToolBar1.MarginBottom = 1;
            this.ribbonToolBar1.MarginTop = 0;
            this.ribbonToolBar1.Name = "ribbonToolBar1";
            // 
            // ribbonComboBox2
            // 
            this.ribbonComboBox2.Label = "Last name:";
            this.ribbonComboBox2.LabelWidth = 78;
            this.ribbonComboBox2.Name = "ribbonComboBox2";
            this.ribbonComboBox2.TextAreaWidth = 90;
            this.ribbonComboBox2.TextChanged += new System.EventHandler(this.ribbonComboBox2_TextChanged);
            // 
            // rbtnClearFilter1
            // 
            this.rbtnClearFilter1.Enabled = false;
            this.rbtnClearFilter1.IconSet.Add(new C1.Framework.C1BitmapIcon("ClearFilter", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "Preset_SmallImages", 69));
            this.rbtnClearFilter1.Name = "rbtnClearFilter1";
            this.rbtnClearFilter1.ShowInMore = false;
            this.rbtnClearFilter1.Click += new System.EventHandler(this.rbtnClearFilter1_Click);
            // 
            // ribbonToolBar2
            // 
            this.ribbonToolBar2.Items.Add(this.ribbonDatePicker1);
            this.ribbonToolBar2.Items.Add(this.rbtnClearFilter2);
            this.ribbonToolBar2.MarginBottom = 1;
            this.ribbonToolBar2.MarginTop = 0;
            this.ribbonToolBar2.Name = "ribbonToolBar2";
            // 
            // ribbonDatePicker1
            // 
            this.ribbonDatePicker1.Label = "Birth date:";
            this.ribbonDatePicker1.LabelWidth = 78;
            this.ribbonDatePicker1.Name = "ribbonDatePicker1";
            this.ribbonDatePicker1.TextAreaWidth = 80;
            this.ribbonDatePicker1.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.ribbonDatePicker1.ValueChanged += new System.EventHandler(this.ribbonDatePicker1_ValueChanged);
            // 
            // rbtnClearFilter2
            // 
            this.rbtnClearFilter2.Enabled = false;
            this.rbtnClearFilter2.IconSet.Add(new C1.Framework.C1BitmapIcon("ClearFilter", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "Preset_SmallImages", 69));
            this.rbtnClearFilter2.Name = "rbtnClearFilter2";
            this.rbtnClearFilter2.ShowInMore = false;
            this.rbtnClearFilter2.Click += new System.EventHandler(this.rbtnClearFilter2_Click);
            // 
            // ribbonToolBar3
            // 
            this.ribbonToolBar3.Items.Add(this.ribbonNumericBox1);
            this.ribbonToolBar3.Items.Add(this.rbtnClearFilter3);
            this.ribbonToolBar3.MarginBottom = 1;
            this.ribbonToolBar3.MarginTop = 0;
            this.ribbonToolBar3.Name = "ribbonToolBar3";
            // 
            // ribbonNumericBox1
            // 
            this.ribbonNumericBox1.Label = "Employee Id:";
            this.ribbonNumericBox1.LabelWidth = 78;
            this.ribbonNumericBox1.Name = "ribbonNumericBox1";
            this.ribbonNumericBox1.TextAreaWidth = 87;
            this.ribbonNumericBox1.ValueChanged += new System.EventHandler(this.ribbonNumericBox1_ValueChanged);
            // 
            // rbtnClearFilter3
            // 
            this.rbtnClearFilter3.Enabled = false;
            this.rbtnClearFilter3.IconSet.Add(new C1.Framework.C1BitmapIcon("ClearFilter", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "Preset_SmallImages", 69));
            this.rbtnClearFilter3.Name = "rbtnClearFilter3";
            this.rbtnClearFilter3.ShowInMore = false;
            this.rbtnClearFilter3.Click += new System.EventHandler(this.rbtnClearFilter3_Click);
            // 
            // ribbonTab2
            // 
            this.ribbonTab2.Groups.Add(this.ribbonGroup2);
            this.ribbonTab2.Name = "ribbonTab2";
            this.ribbonTab2.Text = "Text";
            // 
            // ribbonGroup2
            // 
            this.ribbonGroup2.Items.Add(this.ribbonColorPicker1);
            this.ribbonGroup2.Items.Add(this.ribbonFontComboBox1);
            this.ribbonGroup2.Name = "ribbonGroup2";
            this.ribbonGroup2.Text = "Font";
            // 
            // ribbonColorPicker1
            //
            c1PathIcon10.AllowSmoothing = false;
            c1PathIcon10.Color = System.Drawing.Color.Red;
            c1PathIcon10.Data = "M-2.7755575615628892e-17,18.89795939167988 h24 v5.142857098579968 h-24 z";
            c1PathIcon10.Size = new System.Drawing.Size(16, 16);
            c1PathIcon10.ViewBox = new System.Drawing.Rectangle(0, 0, 24, 24);
            c1PathIcon10.Stroke = System.Drawing.Color.Empty;
            c1CompositeIcon5.Icons.Add(new C1.Framework.C1BitmapIcon("FontColor", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "Preset_SmallImages", -1));
            c1CompositeIcon5.Icons.Add(c1PathIcon10);
            c1CompositeIcon5.Size = new System.Drawing.Size(16, 16);
            this.ribbonColorPicker1.IconSet.Add(c1CompositeIcon5);
            this.ribbonColorPicker1.Name = "ribbonColorPicker1";
            this.ribbonColorPicker1.SelectedColorChanged += new System.EventHandler(this.ribbonColorPicker1_SelectedColorChanged);
            // 
            // ribbonFontComboBox1
            // 
            this.ribbonFontComboBox1.Name = "ribbonFontComboBox1";
            this.ribbonFontComboBox1.SelectedIndexChanged += new System.EventHandler(this.ribbonFontComboBox1_SelectedIndexChanged);
            // 
            // ribbonTopToolBar1
            // 
            this.ribbonTopToolBar1.Name = "ribbonTopToolBar1";
            // 
            // Themes3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 503);
            this.Controls.Add(this.c1Ribbon1);
            this.Controls.Add(this.c1FlexGrid1);
            this.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.Name = "Themes3";
            this.Text = "Themes3";
            this.c1ThemeController1.SetTheme(this, "(default)");
            this.Load += new System.EventHandler(this.Themes3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DemoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.FlexGrid.C1FlexGrid c1FlexGrid1;
        private C1DemoDataSet c1DemoDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private C1DemoDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private C1.Win.Themes.C1ThemeController c1ThemeController1;
        private C1.Win.Ribbon.C1Ribbon c1Ribbon1;
        private C1.Win.Ribbon.RibbonApplicationMenu ribbonApplicationMenu1;
        private C1.Win.Ribbon.RibbonConfigToolBar ribbonConfigToolBar1;
        private C1.Win.Ribbon.RibbonQat ribbonQat1;
        private C1.Win.Ribbon.RibbonTab tab1;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup1;
        private C1.Win.Ribbon.RibbonTab ribbonTab2;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup2;
        private C1.Win.Ribbon.RibbonButton ribbonButton1;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup3;
        private C1.Win.Ribbon.RibbonComboBox ribbonComboBox1;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup4;
        private C1.Win.Ribbon.RibbonColorPicker ribbonColorPicker1;
        private C1.Win.Ribbon.RibbonFontComboBox ribbonFontComboBox1;
        private C1.Win.Ribbon.RibbonBottomToolBar ribbonBottomToolBar1;
        private C1.Win.Ribbon.RibbonTopToolBar ribbonTopToolBar1;
        private C1.Win.Ribbon.RibbonComboBox ribbonComboBox2;
        private C1.Win.Ribbon.RibbonDatePicker ribbonDatePicker1;
        private C1.Win.Ribbon.RibbonNumericBox ribbonNumericBox1;
        private C1.Win.Ribbon.RibbonButton rbtnClearFilter1;
        private C1.Win.Ribbon.RibbonButton rbtnClearFilter2;
        private C1.Win.Ribbon.RibbonButton rbtnClearFilter3;
        private C1.Win.Ribbon.RibbonButton ribbonButton2;
        private C1.Win.Ribbon.RibbonToolBar ribbonToolBar1;
        private C1.Win.Ribbon.RibbonToolBar ribbonToolBar2;
        private C1.Win.Ribbon.RibbonToolBar ribbonToolBar3;
    }
}
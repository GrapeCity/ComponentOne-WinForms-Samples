namespace HoverStyle
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
            C1.Framework.C1CompositeIcon c1CompositeIcon1 = new C1.Framework.C1CompositeIcon();
            C1.Framework.C1PathIcon c1PathIcon1 = new C1.Framework.C1PathIcon();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.c1Ribbon1 = new C1.Win.Ribbon.C1Ribbon();
            this.ribbonApplicationMenu1 = new C1.Win.Ribbon.RibbonApplicationMenu();
            this.ribbonBottomToolBar1 = new C1.Win.Ribbon.RibbonBottomToolBar();
            this.rbHoverMode = new C1.Win.Ribbon.RibbonComboBox();
            this.rbSelectMode = new C1.Win.Ribbon.RibbonComboBox();
            this.rbHoverColor = new C1.Win.Ribbon.RibbonColorPicker();
            this.ribbonConfigToolBar1 = new C1.Win.Ribbon.RibbonConfigToolBar();
            this.ribbonQat1 = new C1.Win.Ribbon.RibbonQat();
            this.ribbonTopToolBar1 = new C1.Win.Ribbon.RibbonTopToolBar();
            this.cmbTheme = new C1.Win.Ribbon.RibbonComboBox();
            this.c1FlexGrid1 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.c1ThemeController1 = new C1.Win.C1Themes.C1ThemeController();
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1Ribbon1
            // 
            this.c1Ribbon1.ApplicationMenuHolder = this.ribbonApplicationMenu1;
            this.c1Ribbon1.BottomToolBarHolder = this.ribbonBottomToolBar1;
            this.c1Ribbon1.ConfigToolBarHolder = this.ribbonConfigToolBar1;
            this.c1Ribbon1.HideTabHeaderRow = true;
            this.c1Ribbon1.Location = new System.Drawing.Point(0, 0);
            this.c1Ribbon1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c1Ribbon1.Name = "c1Ribbon1";
            this.c1Ribbon1.QatHolder = this.ribbonQat1;
            this.c1Ribbon1.Size = new System.Drawing.Size(1351, 80);
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
            this.ribbonBottomToolBar1.HorizontalAlignment = C1.Win.Ribbon.ToolBarHorizontalAlignment.Left;
            this.ribbonBottomToolBar1.Items.Add(this.rbHoverMode);
            this.ribbonBottomToolBar1.Items.Add(this.rbSelectMode);
            this.ribbonBottomToolBar1.Items.Add(this.rbHoverColor);
            this.ribbonBottomToolBar1.Name = "ribbonBottomToolBar1";
            // 
            // rbHoverMode
            // 
            this.rbHoverMode.DropDownStyle = C1.Win.Ribbon.RibbonComboBoxStyle.DropDownList;
            this.rbHoverMode.Label = " Hover Mode:";
            this.rbHoverMode.Name = "rbHoverMode";
            this.rbHoverMode.ToolTip = "Hover Mode";
            this.rbHoverMode.SelectedIndexChanged += new System.EventHandler(this.rbHoverMode_SelectedIndexChanged);
            // 
            // rbSelectMode
            // 
            this.rbSelectMode.DropDownStyle = C1.Win.Ribbon.RibbonComboBoxStyle.DropDownList;
            this.rbSelectMode.Label = " Select Mode:";
            this.rbSelectMode.Name = "rbSelectMode";
            this.rbSelectMode.ToolTip = "Select Mode";
            this.rbSelectMode.SelectedIndexChanged += new System.EventHandler(this.rbSelectMode_SelectedIndexChanged);
            // 
            // rbHoverColor
            // 
            this.rbHoverColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbHoverColor.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            c1PathIcon1.AllowSmoothing = false;
            c1PathIcon1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            c1PathIcon1.Data = "M-2.7755575615628892e-17,18.89795939167988 h24 v5.142857098579968 h-24 z";
            c1PathIcon1.Size = new System.Drawing.Size(16, 16);
            c1PathIcon1.Stroke = System.Drawing.Color.Empty;
            c1PathIcon1.ViewBox = new System.Drawing.Rectangle(0, 0, 24, 24);
            c1CompositeIcon1.Icons.Add(new C1.Framework.C1BitmapIcon("FontColor", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "Preset_SmallImages", -1));
            c1CompositeIcon1.Icons.Add(c1PathIcon1);
            c1CompositeIcon1.Size = new System.Drawing.Size(16, 16);
            this.rbHoverColor.IconSet.Add(c1CompositeIcon1);
            this.rbHoverColor.Name = "rbHoverColor";
            this.rbHoverColor.Text = "Hover Color";
            this.rbHoverColor.ToolTip = "Hover Color";
            this.rbHoverColor.SelectedColorChanged += new System.EventHandler(this.rbHoverColor_SelectedColorChanged);
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
            // ribbonTopToolBar1
            // 
            this.ribbonTopToolBar1.Items.Add(this.cmbTheme);
            this.ribbonTopToolBar1.Name = "ribbonTopToolBar1";
            // 
            // cmbTheme
            // 
            this.cmbTheme.Label = "Theme";
            this.cmbTheme.Name = "cmbTheme";
            this.cmbTheme.SelectedIndexChanged += new System.EventHandler(this.cmbTheme_SelectedIndexChanged);
            // 
            // c1FlexGrid1
            // 
            this.c1FlexGrid1.AllowFiltering = true;
            this.c1FlexGrid1.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Both;
            this.c1FlexGrid1.ColumnContextMenuEnabled = true;
            this.c1FlexGrid1.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            this.c1FlexGrid1.ColumnPickerInfo.SearchMode = C1.Win.C1FlexGrid.ColumnPickerSearchMode.Highlight;
            this.c1FlexGrid1.ColumnPickerInfo.ShowToolButton = true;
            this.c1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1FlexGrid1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.c1FlexGrid1.Location = new System.Drawing.Point(0, 80);
            this.c1FlexGrid1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c1FlexGrid1.Name = "c1FlexGrid1";
            this.c1FlexGrid1.Size = new System.Drawing.Size(1351, 846);
            this.c1FlexGrid1.TabIndex = 6;
            this.c1ThemeController1.SetTheme(this.c1FlexGrid1, "(default)");
            this.c1FlexGrid1.Tree.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 926);
            this.Controls.Add(this.c1FlexGrid1);
            this.Controls.Add(this.c1Ribbon1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hover Style";
            this.c1ThemeController1.SetTheme(this, "(default)");
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.Ribbon.C1Ribbon c1Ribbon1;
        private C1.Win.Ribbon.RibbonApplicationMenu ribbonApplicationMenu1;
        private C1.Win.Ribbon.RibbonBottomToolBar ribbonBottomToolBar1;
        private C1.Win.Ribbon.RibbonConfigToolBar ribbonConfigToolBar1;
        private C1.Win.Ribbon.RibbonQat ribbonQat1;
        private C1.Win.Ribbon.RibbonTopToolBar ribbonTopToolBar1;
        private C1.Win.C1Themes.C1ThemeController c1ThemeController1;
        private C1.Win.Ribbon.RibbonComboBox cmbTheme;
        private C1.Win.Ribbon.RibbonComboBox rbHoverMode;
        private C1.Win.Ribbon.RibbonComboBox rbSelectMode;
        private C1.Win.Ribbon.RibbonColorPicker rbHoverColor;
        private C1.Win.C1FlexGrid.C1FlexGrid c1FlexGrid1;
    }
}


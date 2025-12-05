namespace ControlExplorer.FlexGrid
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            C1.Framework.C1CompositeIcon c1CompositeIcon1 = new C1.Framework.C1CompositeIcon();
            C1.Framework.C1PathIcon c1PathIcon1 = new C1.Framework.C1PathIcon();
            this.c1FlexGrid1 = new C1.Win.FlexGrid.C1FlexGrid();
            this.c1Ribbon1 = new C1.Win.Ribbon.C1Ribbon();
            this.ribbonApplicationMenu1 = new C1.Win.Ribbon.RibbonApplicationMenu();
            this.ribbonBottomToolBar1 = new C1.Win.Ribbon.RibbonBottomToolBar();
            this.rbHoverMode = new C1.Win.Ribbon.RibbonComboBox();
            this.rbSelectMode = new C1.Win.Ribbon.RibbonComboBox();
            this.rbHoverColor = new C1.Win.Ribbon.RibbonColorPicker();
            this.ribbonConfigToolBar1 = new C1.Win.Ribbon.RibbonConfigToolBar();
            this.ribbonQat1 = new C1.Win.Ribbon.RibbonQat();
            this.ribbonTopToolBar1 = new C1.Win.Ribbon.RibbonTopToolBar();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1FlexGrid1
            // 
            this.c1FlexGrid1.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            this.c1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1FlexGrid1.Location = new System.Drawing.Point(0, 32);
            this.c1FlexGrid1.Name = "c1FlexGrid1";
            this.c1FlexGrid1.Size = new System.Drawing.Size(1482, 860);
            this.c1FlexGrid1.TabIndex = 0;
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
            this.c1Ribbon1.Size = new System.Drawing.Size(1482, 32);
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
            this.rbHoverMode.Label = " Hover Style:";
            this.rbHoverMode.Name = "rbHoverMode";
            this.rbHoverMode.ToolTip = "Hover Style";
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
            this.rbHoverColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rbHoverColor.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            c1PathIcon1.AllowSmoothing = false;
            c1PathIcon1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
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
            this.ribbonConfigToolBar1.Visible = false;
            // 
            // ribbonQat1
            // 
            this.ribbonQat1.Name = "ribbonQat1";
            this.ribbonQat1.Visible = false;
            // 
            // ribbonTopToolBar1
            // 
            this.ribbonTopToolBar1.Name = "ribbonTopToolBar1";
            this.ribbonTopToolBar1.Visible = false;
            // 
            // HoverStyle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1482, 892);
            this.Controls.Add(this.c1FlexGrid1);
            this.Controls.Add(this.c1Ribbon1);
            this.Name = "HoverStyle";
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.FlexGrid.C1FlexGrid c1FlexGrid1;
        private C1.Win.Ribbon.C1Ribbon c1Ribbon1;
        private C1.Win.Ribbon.RibbonApplicationMenu ribbonApplicationMenu1;
        private C1.Win.Ribbon.RibbonBottomToolBar ribbonBottomToolBar1;
        private C1.Win.Ribbon.RibbonConfigToolBar ribbonConfigToolBar1;
        private C1.Win.Ribbon.RibbonQat ribbonQat1;
        private C1.Win.Ribbon.RibbonTopToolBar ribbonTopToolBar1;
        private C1.Win.Ribbon.RibbonComboBox rbHoverMode;
        private C1.Win.Ribbon.RibbonComboBox rbSelectMode;
        private C1.Win.Ribbon.RibbonColorPicker rbHoverColor;
    }
}
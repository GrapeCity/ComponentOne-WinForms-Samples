namespace DataCollectionShowcase
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            c1Ribbon1 = new C1.Win.Ribbon.C1Ribbon();
            ribbonApplicationMenu1 = new C1.Win.Ribbon.RibbonApplicationMenu();
            ribbonBottomToolBar1 = new C1.Win.Ribbon.RibbonBottomToolBar();
            ribbonConfigToolBar1 = new C1.Win.Ribbon.RibbonConfigToolBar();
            ribbonQat1 = new C1.Win.Ribbon.RibbonQat();
            ribbonTab1 = new C1.Win.Ribbon.RibbonTab();
            ribbonGroup1 = new C1.Win.Ribbon.RibbonGroup();
            sortButton = new C1.Win.Ribbon.RibbonButton();
            ribbonGroup2 = new C1.Win.Ribbon.RibbonGroup();
            txtFilter = new C1.Win.Ribbon.RibbonTextBox();
            ribbonTopToolBar1 = new C1.Win.Ribbon.RibbonTopToolBar();
            c1FlexGrid1 = new C1.Win.FlexGrid.C1FlexGrid();
            ((System.ComponentModel.ISupportInitialize)c1Ribbon1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1FlexGrid1).BeginInit();
            SuspendLayout();
            // 
            // c1Ribbon1
            // 
            c1Ribbon1.ApplicationMenuHolder = ribbonApplicationMenu1;
            c1Ribbon1.BottomToolBarHolder = ribbonBottomToolBar1;
            c1Ribbon1.ConfigToolBarHolder = ribbonConfigToolBar1;
            c1Ribbon1.Location = new Point(0, 0);
            c1Ribbon1.Name = "c1Ribbon1";
            c1Ribbon1.QatHolder = ribbonQat1;
            c1Ribbon1.Size = new Size(1034, 89);
            c1Ribbon1.Tabs.Add(ribbonTab1);
            c1Ribbon1.TopToolBarHolder = ribbonTopToolBar1;
            c1Ribbon1.ViewMode = C1.Win.Ribbon.ViewMode.Simplified;
            // 
            // ribbonApplicationMenu1
            // 
            ribbonApplicationMenu1.Name = "ribbonApplicationMenu1";
            ribbonApplicationMenu1.Visible = false;
            // 
            // ribbonBottomToolBar1
            // 
            ribbonBottomToolBar1.Name = "ribbonBottomToolBar1";
            ribbonBottomToolBar1.Visible = false;
            // 
            // ribbonConfigToolBar1
            // 
            ribbonConfigToolBar1.Name = "ribbonConfigToolBar1";
            ribbonConfigToolBar1.Visible = false;
            // 
            // ribbonQat1
            // 
            ribbonQat1.MenuVisible = false;
            ribbonQat1.Name = "ribbonQat1";
            ribbonQat1.Visible = false;
            // 
            // ribbonTab1
            // 
            ribbonTab1.Groups.Add(ribbonGroup1);
            ribbonTab1.Groups.Add(ribbonGroup2);
            ribbonTab1.Name = "ribbonTab1";
            ribbonTab1.Text = "Action";
            // 
            // ribbonGroup1
            // 
            ribbonGroup1.Items.Add(sortButton);
            ribbonGroup1.Name = "ribbonGroup1";
            ribbonGroup1.Text = "Sort";
            // 
            // sortButton
            // 
            sortButton.IconSet.Add(new C1.Framework.C1BitmapIcon("SortAscending", new Size(32, 32), Color.Transparent, "Preset_LargeImages", 293));
            sortButton.Name = "sortButton";
            sortButton.ToolTip = "Sort DataCollection by the First Name";
            sortButton.Click += sortButton_Click;
            // 
            // ribbonGroup2
            // 
            ribbonGroup2.Items.Add(txtFilter);
            ribbonGroup2.Name = "ribbonGroup2";
            ribbonGroup2.Text = "Filter";
            // 
            // txtFilter
            // 
            txtFilter.Label = "Filter by: ";
            txtFilter.Name = "txtFilter";
            txtFilter.ToolTip = "Perform full text filtering in the underlying DataCollection";
            txtFilter.TextChanged += txtFilter_TextChanged;
            // 
            // ribbonTopToolBar1
            // 
            ribbonTopToolBar1.Enabled = false;
            ribbonTopToolBar1.Name = "ribbonTopToolBar1";
            ribbonTopToolBar1.Visible = false;
            // 
            // c1FlexGrid1
            // 
            c1FlexGrid1.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            c1FlexGrid1.Dock = DockStyle.Fill;
            c1FlexGrid1.Location = new Point(0, 89);
            c1FlexGrid1.Name = "c1FlexGrid1";
            c1FlexGrid1.Size = new Size(1034, 740);
            c1FlexGrid1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 829);
            Controls.Add(c1FlexGrid1);
            Controls.Add(c1Ribbon1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Showcase";
            ((System.ComponentModel.ISupportInitialize)c1Ribbon1).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1FlexGrid1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private C1.Win.Ribbon.RibbonButton sortButton;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup2;
        private C1.Win.Ribbon.RibbonTextBox txtFilter;
        private C1.Win.FlexGrid.C1FlexGrid c1FlexGrid1;
    }
}

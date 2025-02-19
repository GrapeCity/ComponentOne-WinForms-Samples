namespace FlexGridExplorer.Samples
{
    partial class ColumnFooters
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
            c1Ribbon1 = new C1.Win.Ribbon.C1Ribbon();
            ribbonApplicationMenu1 = new C1.Win.Ribbon.RibbonApplicationMenu();
            ribbonBottomToolBar1 = new C1.Win.Ribbon.RibbonBottomToolBar();
            ribbonConfigToolBar1 = new C1.Win.Ribbon.RibbonConfigToolBar();
            ribbonQat1 = new C1.Win.Ribbon.RibbonQat();
            ribbonTab1 = new C1.Win.Ribbon.RibbonTab();
            ribbonGroup1 = new C1.Win.Ribbon.RibbonGroup();
            rcbFixFooter = new C1.Win.Ribbon.RibbonCheckBox();
            ribbonGroup2 = new C1.Win.Ribbon.RibbonGroup();
            rcbColumn = new C1.Win.Ribbon.RibbonComboBox();
            ribbonGroup3 = new C1.Win.Ribbon.RibbonGroup();
            ribbonToolBar1 = new C1.Win.Ribbon.RibbonToolBar();
            rtbCaption = new C1.Win.Ribbon.RibbonTextBox();
            ribbonLabel1 = new C1.Win.Ribbon.RibbonLabel();
            rcbAggregate = new C1.Win.Ribbon.RibbonComboBox();
            ribbonLabel2 = new C1.Win.Ribbon.RibbonLabel();
            rtbExpression = new C1.Win.Ribbon.RibbonTextBox();
            ribbonTopToolBar1 = new C1.Win.Ribbon.RibbonTopToolBar();
            panel1 = new System.Windows.Forms.Panel();
            flexGrid = new C1.Win.FlexGrid.C1FlexGrid();
            ((System.ComponentModel.ISupportInitialize)c1Ribbon1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)flexGrid).BeginInit();
            SuspendLayout();
            // 
            // c1Ribbon1
            // 
            c1Ribbon1.ApplicationMenuHolder = ribbonApplicationMenu1;
            c1Ribbon1.BottomToolBarHolder = ribbonBottomToolBar1;
            c1Ribbon1.ConfigToolBarHolder = ribbonConfigToolBar1;
            c1Ribbon1.Location = new System.Drawing.Point(0, 0);
            c1Ribbon1.Name = "c1Ribbon1";
            c1Ribbon1.QatHolder = ribbonQat1;
            c1Ribbon1.Size = new System.Drawing.Size(1063, 89);
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
            // 
            // ribbonConfigToolBar1
            // 
            ribbonConfigToolBar1.Name = "ribbonConfigToolBar1";
            // 
            // ribbonQat1
            // 
            ribbonQat1.Name = "ribbonQat1";
            ribbonQat1.Visible = false;
            // 
            // ribbonTab1
            // 
            ribbonTab1.Groups.Add(ribbonGroup1);
            ribbonTab1.Groups.Add(ribbonGroup2);
            ribbonTab1.Groups.Add(ribbonGroup3);
            ribbonTab1.Name = "ribbonTab1";
            ribbonTab1.Text = "Properties";
            // 
            // ribbonGroup1
            // 
            ribbonGroup1.Items.Add(rcbFixFooter);
            ribbonGroup1.Name = "ribbonGroup1";
            ribbonGroup1.Text = "Footer";
            // 
            // rcbFixFooter
            // 
            rcbFixFooter.Name = "rcbFixFooter";
            rcbFixFooter.Text = "Fix Footer";
            // 
            // ribbonGroup2
            // 
            ribbonGroup2.Items.Add(rcbColumn);
            ribbonGroup2.Name = "ribbonGroup2";
            ribbonGroup2.Text = "Column";
            // 
            // rcbColumn
            // 
            rcbColumn.Label = "Column";
            rcbColumn.Name = "rcbColumn";
            // 
            // ribbonGroup3
            // 
            ribbonGroup3.Items.Add(ribbonToolBar1);
            ribbonGroup3.Name = "ribbonGroup3";
            ribbonGroup3.Text = "Footers Properties";
            // 
            // ribbonToolBar1
            // 
            ribbonToolBar1.Items.Add(rtbCaption);
            ribbonToolBar1.Items.Add(ribbonLabel1);
            ribbonToolBar1.Items.Add(rcbAggregate);
            ribbonToolBar1.Items.Add(ribbonLabel2);
            ribbonToolBar1.Items.Add(rtbExpression);
            ribbonToolBar1.Name = "ribbonToolBar1";
            // 
            // rtbCaption
            // 
            rtbCaption.Label = "Caption";
            rtbCaption.Name = "rtbCaption";
            rtbCaption.TextAreaWidth = 100;
            // 
            // ribbonLabel1
            // 
            ribbonLabel1.Name = "ribbonLabel1";
            ribbonLabel1.Text = "  ";
            // 
            // rcbAggregate
            // 
            rcbAggregate.Label = "Aggregate";
            rcbAggregate.Name = "rcbAggregate";
            rcbAggregate.TextAreaWidth = 100;
            // 
            // ribbonLabel2
            // 
            ribbonLabel2.Name = "ribbonLabel2";
            ribbonLabel2.Text = "  ";
            // 
            // rtbExpression
            // 
            rtbExpression.Label = "Expression";
            rtbExpression.Name = "rtbExpression";
            rtbExpression.TextAreaWidth = 100;
            // 
            // ribbonTopToolBar1
            // 
            ribbonTopToolBar1.Name = "ribbonTopToolBar1";
            ribbonTopToolBar1.Visible = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(flexGrid);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(0, 89);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1063, 725);
            panel1.TabIndex = 1;
            // 
            // flexGrid
            // 
            flexGrid.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            flexGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            flexGrid.Location = new System.Drawing.Point(0, 0);
            flexGrid.Name = "flexGrid";
            flexGrid.Size = new System.Drawing.Size(1063, 725);
            flexGrid.TabIndex = 0;
            // 
            // ColumnFooters
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(c1Ribbon1);
            Name = "ColumnFooters";
            Size = new System.Drawing.Size(1063, 814);
            Load += ColumnFooters_Load;
            ((System.ComponentModel.ISupportInitialize)c1Ribbon1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)flexGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private C1.Win.Ribbon.RibbonButton ribbonButton1;
        private C1.Win.Ribbon.C1Ribbon c1Ribbon1;
        private C1.Win.Ribbon.RibbonApplicationMenu ribbonApplicationMenu1;
        private C1.Win.Ribbon.RibbonBottomToolBar ribbonBottomToolBar1;
        private C1.Win.Ribbon.RibbonConfigToolBar ribbonConfigToolBar1;
        private C1.Win.Ribbon.RibbonQat ribbonQat1;
        private C1.Win.Ribbon.RibbonTab ribbonTab1;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup1;
        private C1.Win.Ribbon.RibbonCheckBox rcbFixFooter;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup2;
        private C1.Win.Ribbon.RibbonComboBox rcbColumn;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup3;
        private C1.Win.Ribbon.RibbonTextBox rtbCaption;
        private C1.Win.Ribbon.RibbonComboBox rcbAggregate;
        private C1.Win.Ribbon.RibbonTextBox rtbExpression;
        private C1.Win.Ribbon.RibbonTopToolBar ribbonTopToolBar1;
        private C1.Win.Ribbon.RibbonToolBar ribbonToolBar1;
        private System.Windows.Forms.Panel panel1;
        private C1.Win.FlexGrid.C1FlexGrid flexGrid;
        private C1.Win.Ribbon.RibbonLabel ribbonLabel1;
        private C1.Win.Ribbon.RibbonLabel ribbonLabel2;
    }
}

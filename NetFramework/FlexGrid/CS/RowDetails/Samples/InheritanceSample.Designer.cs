namespace RowDetails.Samples
{
    partial class InheritanceSample
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InheritanceSample));
            this.flexGrid = new C1.Win.FlexGrid.C1FlexGrid();
            this.themeController = new C1.Win.Themes.C1ThemeController();
            ((System.ComponentModel.ISupportInitialize)(this.flexGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.themeController)).BeginInit();
            this.SuspendLayout();
            // 
            // flexGrid
            // 
            this.flexGrid.AllowEditing = false;
            this.flexGrid.BackColor = System.Drawing.Color.White;
            this.flexGrid.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            this.flexGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flexGrid.EditOptions = ((C1.Win.FlexGrid.EditFlags)((((((C1.Win.FlexGrid.EditFlags.AutoSearch | C1.Win.FlexGrid.EditFlags.CycleOnDoubleClick) 
            | C1.Win.FlexGrid.EditFlags.MultiCheck) 
            | C1.Win.FlexGrid.EditFlags.UseNumericEditor) 
            | C1.Win.FlexGrid.EditFlags.ExitOnLeftRightKeys) 
            | C1.Win.FlexGrid.EditFlags.EditOnRequest)));
            this.flexGrid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.flexGrid.Location = new System.Drawing.Point(0, 0);
            this.flexGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flexGrid.Name = "flexGrid";
            this.flexGrid.ShowThemedHeaders = C1.Win.FlexGrid.ShowThemedHeadersEnum.None;
            this.flexGrid.Size = new System.Drawing.Size(700, 523);
            this.flexGrid.StyleInfo = resources.GetString("flexGrid.StyleInfo");
            this.flexGrid.TabIndex = 0;
            this.themeController.SetTheme(this.flexGrid, "(default)");
            this.flexGrid.Tree.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            // 
            // InheritanceSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flexGrid);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Name = "InheritanceSample";
            this.Size = new System.Drawing.Size(700, 523);
            this.themeController.SetTheme(this, "(default)");
            this.Load += new System.EventHandler(this.InheritanceSample_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flexGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.themeController)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.FlexGrid.C1FlexGrid flexGrid;
        private C1.Win.Themes.C1ThemeController themeController;
    }
}

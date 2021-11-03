namespace ControlExplorer.Controls
{
    partial class FeatureNavigation
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
            C1.Win.TreeView.C1TreeColumn c1TreeColumn1 = new C1.Win.TreeView.C1TreeColumn();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblSelectedControl = new C1.Win.Input.C1Label();
            this.btnHome = new C1.Win.Input.C1Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.treeFeatures = new C1.Win.TreeView.C1TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeFeatures)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.lblSelectedControl);
            this.pnlTitle.Controls.Add(this.btnHome);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(215, 36);
            this.pnlTitle.TabIndex = 0;
            // 
            // lblSelectedControl
            // 
            this.lblSelectedControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSelectedControl.Font = new System.Drawing.Font("Trebuchet MS", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSelectedControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.lblSelectedControl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSelectedControl.Location = new System.Drawing.Point(36, 0);
            this.lblSelectedControl.Name = "lblSelectedControl";
            this.lblSelectedControl.Size = new System.Drawing.Size(179, 36);
            this.lblSelectedControl.Styles.Default.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.lblSelectedControl.TabIndex = 1;
            this.lblSelectedControl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSelectedControl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.lblSelectedControl.UseMnemonic = true;
            // 
            // btnHome
            // 
            this.btnHome.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(36, 36);
            this.btnHome.Styles.Border = new C1.Framework.Thickness(0, 0, 0, 0);
            this.btnHome.Styles.Default.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.btnHome.Styles.Default.ForeColor = System.Drawing.Color.White;
            this.btnHome.Styles.Hot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(159)))));
            this.btnHome.Styles.Hot.ForeColor = System.Drawing.Color.White;
            this.btnHome.Styles.HotPressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnHome.Styles.HotPressed.ForeColor = System.Drawing.Color.White;
            this.btnHome.TabIndex = 0;
            this.btnHome.UseMnemonic = true;
            this.btnHome.Click += new System.EventHandler(this.Home_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Trebuchet MS", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 36);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(34, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(215, 36);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "FEATURES";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // treeFeatures
            // 
            this.treeFeatures.AllowUserToResizeColumns = false;
            this.treeFeatures.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(243)))));
            this.treeFeatures.BorderStyle = System.Windows.Forms.BorderStyle.None;
            // 
            // 
            // 
            this.treeFeatures.ButtonImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.treeFeatures.ButtonImageList.ImageSize = new System.Drawing.Size(16, 16);
            // 
            // 
            // 
            this.treeFeatures.CheckImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.treeFeatures.CheckImageList.ImageSize = new System.Drawing.Size(16, 16);
            c1TreeColumn1.DisplayFieldName = null;
            c1TreeColumn1.HeaderText = "Column1";
            c1TreeColumn1.Name = "Column1";
            c1TreeColumn1.Styles.Default.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            c1TreeColumn1.Styles.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            c1TreeColumn1.Styles.Hot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(225)))));
            c1TreeColumn1.Styles.Hot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            c1TreeColumn1.Styles.HotSelected.BackColor = System.Drawing.Color.White;
            c1TreeColumn1.Styles.HotSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            c1TreeColumn1.Styles.Selected.BackColor = System.Drawing.Color.White;
            c1TreeColumn1.Styles.Selected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            c1TreeColumn1.Styles.UnfocusedSelected.BackColor = System.Drawing.Color.White;
            c1TreeColumn1.Styles.UnfocusedSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.treeFeatures.Columns.Add(c1TreeColumn1);
            this.treeFeatures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeFeatures.Location = new System.Drawing.Point(0, 72);
            this.treeFeatures.Name = "treeFeatures";
            this.treeFeatures.ShowColumnHeaders = false;
            this.treeFeatures.Size = new System.Drawing.Size(215, 368);
            this.treeFeatures.Styles.Border = 0;
            this.treeFeatures.Styles.Default.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.treeFeatures.Styles.ExpandButtonStyle = C1.Win.TreeView.ExpandButtonStyle.Windows10;
            this.treeFeatures.Styles.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.treeFeatures.Styles.Hot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(225)))));
            this.treeFeatures.Styles.Hot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.treeFeatures.Styles.HotSelected.BackColor = System.Drawing.Color.White;
            this.treeFeatures.Styles.HotSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.treeFeatures.Styles.Selected.BackColor = System.Drawing.Color.White;
            this.treeFeatures.Styles.Selected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.treeFeatures.Styles.ShowLines = false;
            this.treeFeatures.Styles.UnfocusedSelected.BackColor = System.Drawing.Color.White;
            this.treeFeatures.Styles.UnfocusedSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.treeFeatures.TabIndex = 2;
            this.treeFeatures.SelectionChanged += new C1.Win.TreeView.C1TreeViewEventHandler(this.TreeFeatures_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 368);
            this.panel1.TabIndex = 3;
            // 
            // FeatureNavigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(243)))));
            this.Controls.Add(this.treeFeatures);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlTitle);
            this.Name = "FeatureNavigation";
            this.Size = new System.Drawing.Size(215, 440);
            this.pnlTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeFeatures)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitle;
        private C1.Win.TreeView.C1TreeView treeFeatures;
        private C1.Win.Input.C1Button btnHome;
        private C1.Win.Input.C1Label lblSelectedControl;
        private System.Windows.Forms.Panel panel1;
    }
}

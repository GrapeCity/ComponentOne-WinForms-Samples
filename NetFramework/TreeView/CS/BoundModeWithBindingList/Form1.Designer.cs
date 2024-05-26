namespace BoundModeWithBindingList
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
            this.components = new System.ComponentModel.Container();
            C1.Win.TreeView.C1TreeColumn c1TreeColumn1 = new C1.Win.TreeView.C1TreeColumn();
            this.c1ThemeController1 = new C1.Win.C1Themes.C1ThemeController();
            this.panel1 = new System.Windows.Forms.Panel();
            this.c1DockingTab1 = new C1.Win.C1Command.C1DockingTab();
            this.c1DockingTabPage1 = new C1.Win.C1Command.C1DockingTabPage();
            this.pgTreeView = new System.Windows.Forms.PropertyGrid();
            this.c1TreeView1 = new C1.Win.TreeView.C1TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnResetData = new C1.Win.C1Input.C1Button();
            this.c1DockingTabPage2 = new C1.Win.C1Command.C1DockingTabPage();
            this.pgColumn = new System.Windows.Forms.PropertyGrid();
            this.cmbSelectedColumn = new C1.Win.C1Input.C1ComboBox();
            this.c1Label1 = new C1.Win.C1Input.C1Label();
            this.btnAddNewColumn = new C1.Win.C1Input.C1Button();
            this.btnRemoveColumn = new C1.Win.C1Input.C1Button();
            this.c1DockingTabPage3 = new C1.Win.C1Command.C1DockingTabPage();
            this.pgNode = new System.Windows.Forms.PropertyGrid();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).BeginInit();
            this.c1DockingTab1.SuspendLayout();
            this.c1DockingTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1TreeView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnResetData)).BeginInit();
            this.c1DockingTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSelectedColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddNewColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoveColumn)).BeginInit();
            this.c1DockingTabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // c1ThemeController1
            // 
            this.c1ThemeController1.Theme = "Office365White";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(137)))), ((int)(((byte)(91)))));
            this.panel1.Controls.Add(this.c1DockingTab1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 459);
            this.panel1.TabIndex = 1;
            this.c1ThemeController1.SetTheme(this.panel1, "(default)");
            // 
            // c1DockingTab1
            // 
            this.c1DockingTab1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.c1DockingTab1.Controls.Add(this.c1DockingTabPage1);
            this.c1DockingTab1.Controls.Add(this.c1DockingTabPage2);
            this.c1DockingTab1.Controls.Add(this.c1DockingTabPage3);
            this.c1DockingTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1DockingTab1.Location = new System.Drawing.Point(0, 0);
            this.c1DockingTab1.Name = "c1DockingTab1";
            this.c1DockingTab1.SelectedIndex = 2;
            this.c1DockingTab1.Size = new System.Drawing.Size(312, 459);
            this.c1DockingTab1.TabIndex = 0;
            this.c1DockingTab1.TabsSpacing = 7;
            this.c1DockingTab1.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2007;
            this.c1ThemeController1.SetTheme(this.c1DockingTab1, "(default)");
            // 
            // c1DockingTabPage1
            // 
            this.c1DockingTabPage1.CaptionText = "TreeView";
            this.c1DockingTabPage1.Controls.Add(this.pgTreeView);
            this.c1DockingTabPage1.Controls.Add(this.btnResetData);
            this.c1DockingTabPage1.Location = new System.Drawing.Point(1, 24);
            this.c1DockingTabPage1.Name = "c1DockingTabPage1";
            this.c1DockingTabPage1.Size = new System.Drawing.Size(310, 434);
            this.c1DockingTabPage1.TabIndex = 0;
            this.c1DockingTabPage1.Text = "TreeView";
            // 
            // pgTreeView
            // 
            this.pgTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgTreeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(137)))), ((int)(((byte)(91)))));
            this.pgTreeView.CategoryForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pgTreeView.CommandsActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.pgTreeView.CommandsBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(137)))), ((int)(((byte)(91)))));
            this.pgTreeView.CommandsDisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.pgTreeView.CommandsForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pgTreeView.CommandsLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.pgTreeView.HelpBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(137)))), ((int)(((byte)(91)))));
            this.pgTreeView.HelpForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pgTreeView.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(137)))), ((int)(((byte)(91)))));
            this.pgTreeView.Location = new System.Drawing.Point(13, 78);
            this.pgTreeView.Name = "pgTreeView";
            this.pgTreeView.SelectedObject = this.c1TreeView1;
            this.pgTreeView.Size = new System.Drawing.Size(286, 345);
            this.pgTreeView.TabIndex = 1;
            this.c1ThemeController1.SetTheme(this.pgTreeView, "(default)");
            this.pgTreeView.ViewBackColor = System.Drawing.Color.DarkSeaGreen;
            this.pgTreeView.ViewForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            // 
            // c1TreeView1
            // 
            this.c1TreeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(137)))), ((int)(((byte)(91)))));
            c1TreeColumn1.DisplayFieldName = null;
            c1TreeColumn1.HeaderText = "Column1";
            c1TreeColumn1.Name = "Column1";
            this.c1TreeView1.Columns.Add(c1TreeColumn1);
            this.c1TreeView1.BindingInfo.DataMember = null;
            this.c1TreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1TreeView1.ImageList = this.imageList1;
            this.c1TreeView1.BindingInfo.KeyField = null;
            this.c1TreeView1.Location = new System.Drawing.Point(0, 0);
            this.c1TreeView1.Name = "c1TreeView1";
            this.c1TreeView1.BindingInfo.ParentKeyField = null;
            this.c1TreeView1.Size = new System.Drawing.Size(527, 459);
            this.c1TreeView1.TabIndex = 0;
            this.c1ThemeController1.SetTheme(this.c1TreeView1, "(default)");
            this.c1TreeView1.SelectionChanged += new C1.Win.TreeView.C1TreeViewEventHandler(this.c1TreeView1_SelectionChanged);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnResetData
            // 
            this.btnResetData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetData.Location = new System.Drawing.Point(13, 15);
            this.btnResetData.Name = "btnResetData";
            this.btnResetData.Size = new System.Drawing.Size(115, 46);
            this.btnResetData.TabIndex = 0;
            this.btnResetData.Text = "Reset data";
            this.c1ThemeController1.SetTheme(this.btnResetData, "(default)");
            this.btnResetData.UseVisualStyleBackColor = true;
            this.btnResetData.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.btnResetData.Click += new System.EventHandler(this.btnResetData_Click);
            // 
            // c1DockingTabPage2
            // 
            this.c1DockingTabPage2.Controls.Add(this.pgColumn);
            this.c1DockingTabPage2.Controls.Add(this.cmbSelectedColumn);
            this.c1DockingTabPage2.Controls.Add(this.c1Label1);
            this.c1DockingTabPage2.Controls.Add(this.btnAddNewColumn);
            this.c1DockingTabPage2.Controls.Add(this.btnRemoveColumn);
            this.c1DockingTabPage2.Location = new System.Drawing.Point(1, 24);
            this.c1DockingTabPage2.Name = "c1DockingTabPage2";
            this.c1DockingTabPage2.Size = new System.Drawing.Size(310, 434);
            this.c1DockingTabPage2.TabIndex = 1;
            this.c1DockingTabPage2.Text = "Columns";
            // 
            // pgColumn
            // 
            this.pgColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgColumn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(137)))), ((int)(((byte)(91)))));
            this.pgColumn.CategoryForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pgColumn.CommandsActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.pgColumn.CommandsBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(137)))), ((int)(((byte)(91)))));
            this.pgColumn.CommandsDisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.pgColumn.CommandsForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pgColumn.CommandsLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.pgColumn.HelpBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(137)))), ((int)(((byte)(91)))));
            this.pgColumn.HelpForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pgColumn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(137)))), ((int)(((byte)(91)))));
            this.pgColumn.Location = new System.Drawing.Point(13, 99);
            this.pgColumn.Name = "pgColumn";
            this.pgColumn.Size = new System.Drawing.Size(285, 324);
            this.pgColumn.TabIndex = 4;
            this.c1ThemeController1.SetTheme(this.pgColumn, "(default)");
            this.pgColumn.ViewBackColor = System.Drawing.Color.DarkSeaGreen;
            this.pgColumn.ViewForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            // 
            // cmbSelectedColumn
            // 
            this.cmbSelectedColumn.AllowSpinLoop = false;
            this.cmbSelectedColumn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmbSelectedColumn.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.cmbSelectedColumn.GapHeight = 0;
            this.cmbSelectedColumn.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cmbSelectedColumn.ItemsDisplayMember = "";
            this.cmbSelectedColumn.ItemsValueMember = "";
            this.cmbSelectedColumn.Location = new System.Drawing.Point(150, 75);
            this.cmbSelectedColumn.Name = "cmbSelectedColumn";
            this.cmbSelectedColumn.Size = new System.Drawing.Size(136, 18);
            this.cmbSelectedColumn.Style.DropDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.cmbSelectedColumn.Style.DropDownBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.cmbSelectedColumn.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectedColumn.TabIndex = 3;
            this.cmbSelectedColumn.Tag = null;
            this.cmbSelectedColumn.TextDetached = true;
            this.c1ThemeController1.SetTheme(this.cmbSelectedColumn, "(default)");
            this.cmbSelectedColumn.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.cmbSelectedColumn.SelectedIndexChanged += new System.EventHandler(this.cmbSelectedColumn_SelectedIndexChanged);
            // 
            // c1Label1
            // 
            this.c1Label1.AutoSize = true;
            this.c1Label1.BackColor = System.Drawing.Color.Transparent;
            this.c1Label1.BorderColor = System.Drawing.Color.Transparent;
            this.c1Label1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.c1Label1.Location = new System.Drawing.Point(63, 77);
            this.c1Label1.Name = "c1Label1";
            this.c1Label1.Size = new System.Drawing.Size(81, 13);
            this.c1Label1.TabIndex = 2;
            this.c1Label1.Tag = null;
            this.c1Label1.Text = "Current column:";
            this.c1Label1.TextDetached = true;
            this.c1ThemeController1.SetTheme(this.c1Label1, "(default)");
            // 
            // btnAddNewColumn
            // 
            this.btnAddNewColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewColumn.Location = new System.Drawing.Point(13, 19);
            this.btnAddNewColumn.Name = "btnAddNewColumn";
            this.btnAddNewColumn.Size = new System.Drawing.Size(115, 46);
            this.btnAddNewColumn.TabIndex = 1;
            this.btnAddNewColumn.Text = "Add column";
            this.c1ThemeController1.SetTheme(this.btnAddNewColumn, "(default)");
            this.btnAddNewColumn.UseVisualStyleBackColor = true;
            this.btnAddNewColumn.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.btnAddNewColumn.Click += new System.EventHandler(this.btnAddNewColumn_Click);
            // 
            // btnRemoveColumn
            // 
            this.btnRemoveColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveColumn.Location = new System.Drawing.Point(150, 19);
            this.btnRemoveColumn.Name = "btnRemoveColumn";
            this.btnRemoveColumn.Size = new System.Drawing.Size(115, 46);
            this.btnRemoveColumn.TabIndex = 0;
            this.btnRemoveColumn.Text = "Remove column";
            this.c1ThemeController1.SetTheme(this.btnRemoveColumn, "(default)");
            this.btnRemoveColumn.UseVisualStyleBackColor = true;
            this.btnRemoveColumn.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.btnRemoveColumn.Click += new System.EventHandler(this.btnRemoveColumn_Click);
            // 
            // c1DockingTabPage3
            // 
            this.c1DockingTabPage3.Controls.Add(this.pgNode);
            this.c1DockingTabPage3.Location = new System.Drawing.Point(1, 24);
            this.c1DockingTabPage3.Name = "c1DockingTabPage3";
            this.c1DockingTabPage3.Size = new System.Drawing.Size(310, 434);
            this.c1DockingTabPage3.TabIndex = 2;
            this.c1DockingTabPage3.Text = "Nodes";
            // 
            // pgNode
            // 
            this.pgNode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgNode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(137)))), ((int)(((byte)(91)))));
            this.pgNode.CategoryForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pgNode.CommandsActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.pgNode.CommandsBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(137)))), ((int)(((byte)(91)))));
            this.pgNode.CommandsDisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.pgNode.CommandsForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pgNode.CommandsLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.pgNode.HelpBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(137)))), ((int)(((byte)(91)))));
            this.pgNode.HelpForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pgNode.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(137)))), ((int)(((byte)(91)))));
            this.pgNode.Location = new System.Drawing.Point(13, 13);
            this.pgNode.Name = "pgNode";
            this.pgNode.Size = new System.Drawing.Size(286, 408);
            this.pgNode.TabIndex = 0;
            this.c1ThemeController1.SetTheme(this.pgNode, "(default)");
            this.pgNode.ViewBackColor = System.Drawing.Color.DarkSeaGreen;
            this.pgNode.ViewForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(137)))), ((int)(((byte)(91)))));
            this.panel2.Controls.Add(this.c1TreeView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(527, 459);
            this.panel2.TabIndex = 2;
            this.c1ThemeController1.SetTheme(this.panel2, "(default)");
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(137)))), ((int)(((byte)(91)))));
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(843, 459);
            this.splitContainer1.SplitterDistance = 527;
            this.splitContainer1.TabIndex = 1;
            this.c1ThemeController1.SetTheme(this.splitContainer1, "(default)");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 459);
            this.Controls.Add(this.splitContainer1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Name = "Form1";
            this.Text = "BoundModeWithBindingList";
            this.c1ThemeController1.SetTheme(this, "(default)");
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).EndInit();
            this.c1DockingTab1.ResumeLayout(false);
            this.c1DockingTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1TreeView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnResetData)).EndInit();
            this.c1DockingTabPage2.ResumeLayout(false);
            this.c1DockingTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSelectedColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddNewColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoveColumn)).EndInit();
            this.c1DockingTabPage3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private C1.Win.C1Themes.C1ThemeController c1ThemeController1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private C1.Win.C1Command.C1DockingTab c1DockingTab1;
        private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage1;
        private System.Windows.Forms.PropertyGrid pgTreeView;
        private C1.Win.C1Input.C1Button btnResetData;
        private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage2;
        private System.Windows.Forms.PropertyGrid pgColumn;
        private C1.Win.C1Input.C1ComboBox cmbSelectedColumn;
        private C1.Win.C1Input.C1Label c1Label1;
        private C1.Win.C1Input.C1Button btnAddNewColumn;
        private C1.Win.C1Input.C1Button btnRemoveColumn;
        private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage3;
        private System.Windows.Forms.PropertyGrid pgNode;
        private C1.Win.TreeView.C1TreeView c1TreeView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ImageList imageList1;
    }
}


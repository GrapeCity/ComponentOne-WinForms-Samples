namespace UnboundMode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));

            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            C1.Win.TreeView.C1TreeColumn c1TreeColumn1 = new C1.Win.TreeView.C1TreeColumn();
            this.c1ThemeController1 = new C1.Win.Themes.C1ThemeController();
            this.panel1 = new System.Windows.Forms.Panel();
            this.c1DockingTab1 = new C1.Win.Command.C1DockingTab();
            this.c1DockingTabPage1 = new C1.Win.Command.C1DockingTabPage();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.c1TreeView1 = new C1.Win.TreeView.C1TreeView();
            this.label4 = new System.Windows.Forms.Label();
            this.nudLevelsCount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudRootNodesCount = new System.Windows.Forms.NumericUpDown();
            this.nudNodesCount = new System.Windows.Forms.NumericUpDown();
            this.nudColumnsCount = new System.Windows.Forms.NumericUpDown();
            this.btnClearTree = new C1.Win.C1Input.C1Button();
            this.btnGenereteTree = new C1.Win.C1Input.C1Button();
            this.c1DockingTabPage2 = new C1.Win.Command.C1DockingTabPage();
            this.pgColumn = new System.Windows.Forms.PropertyGrid();
            this.cmbSelectedColumn = new C1.Win.C1Input.C1ComboBox();
            this.c1Label1 = new C1.Win.C1Input.C1Label();
            this.btnAddNewColumn = new C1.Win.C1Input.C1Button();
            this.btnRemoveColumn = new C1.Win.C1Input.C1Button();
            this.c1DockingTabPage3 = new C1.Win.Command.C1DockingTabPage();
            this.pgNode = new System.Windows.Forms.PropertyGrid();
            this.btnRemoveSelectedNodes = new C1.Win.C1Input.C1Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).BeginInit();
            this.c1DockingTab1.SuspendLayout();
            this.c1DockingTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1TreeView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevelsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRootNodesCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNodesCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumnsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClearTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGenereteTree)).BeginInit();
            this.c1DockingTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSelectedColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddNewColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoveColumn)).BeginInit();
            this.c1DockingTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoveSelectedNodes)).BeginInit();
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
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.c1DockingTab1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 883);
            this.panel1.TabIndex = 1;
            this.c1ThemeController1.SetTheme(this.panel1, "(default)");
            // 
            // c1DockingTab1
            // 
            this.c1DockingTab1.BackColor = System.Drawing.Color.White;
            this.c1DockingTab1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c1DockingTab1.Controls.Add(this.c1DockingTabPage1);
            this.c1DockingTab1.Controls.Add(this.c1DockingTabPage2);
            this.c1DockingTab1.Controls.Add(this.c1DockingTabPage3);
            this.c1DockingTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1DockingTab1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.c1DockingTab1.HotTrack = true;
            this.c1DockingTab1.Location = new System.Drawing.Point(0, 0);
            this.c1DockingTab1.Margin = new System.Windows.Forms.Padding(6);
            this.c1DockingTab1.Name = "c1DockingTab1";
            this.c1DockingTab1.Size = new System.Drawing.Size(592, 883);
            this.c1DockingTab1.TabIndex = 0;
            this.c1DockingTab1.TabSizeMode = C1.Win.Command.TabSizeModeEnum.Fit;
            this.c1DockingTab1.TabsShowFocusCues = false;
            this.c1DockingTab1.TabsSpacing = 2;
            this.c1DockingTab1.TabStyle = C1.Win.Command.TabStyleEnum.Office2007;
            this.c1ThemeController1.SetTheme(this.c1DockingTab1, "(default)");
            // 
            // c1DockingTabPage1
            // 
            this.c1DockingTabPage1.CaptionText = "TreeView";
            this.c1DockingTabPage1.Controls.Add(this.propertyGrid1);
            this.c1DockingTabPage1.Controls.Add(this.label4);
            this.c1DockingTabPage1.Controls.Add(this.nudLevelsCount);
            this.c1DockingTabPage1.Controls.Add(this.label3);
            this.c1DockingTabPage1.Controls.Add(this.label2);
            this.c1DockingTabPage1.Controls.Add(this.label1);
            this.c1DockingTabPage1.Controls.Add(this.nudRootNodesCount);
            this.c1DockingTabPage1.Controls.Add(this.nudNodesCount);
            this.c1DockingTabPage1.Controls.Add(this.nudColumnsCount);
            this.c1DockingTabPage1.Controls.Add(this.btnClearTree);
            this.c1DockingTabPage1.Controls.Add(this.btnGenereteTree);
            this.c1DockingTabPage1.Location = new System.Drawing.Point(5, 37);
            this.c1DockingTabPage1.Name = "c1DockingTabPage1";
            this.c1DockingTabPage1.Size = new System.Drawing.Size(582, 841);
            this.c1DockingTabPage1.TabIndex = 0;
            this.c1DockingTabPage1.Text = "Edit TreeView";
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.propertyGrid1.CategoryForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.propertyGrid1.CommandsActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(40)))), ((int)(((byte)(128)))));
            this.propertyGrid1.CommandsBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.propertyGrid1.CommandsDisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.propertyGrid1.CommandsForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.propertyGrid1.CommandsLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(184)))));
            this.propertyGrid1.DisabledItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.propertyGrid1.HelpBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.propertyGrid1.HelpForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.propertyGrid1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.propertyGrid1.Location = new System.Drawing.Point(0, 342);
            this.propertyGrid1.Margin = new System.Windows.Forms.Padding(6);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.SelectedObject = this.c1TreeView1;
            this.propertyGrid1.Size = new System.Drawing.Size(574, 460);
            this.propertyGrid1.TabIndex = 18;
            this.c1ThemeController1.SetTheme(this.propertyGrid1, "(default)");
            this.propertyGrid1.ViewBackColor = System.Drawing.Color.White;
            this.propertyGrid1.ViewForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            // 
            // c1TreeView1
            // 
            this.c1TreeView1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.c1TreeView1.ButtonImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.c1TreeView1.ButtonImageList.ImageSize = new System.Drawing.Size(16, 16);
            // 
            // 
            // 
            this.c1TreeView1.CheckImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.c1TreeView1.CheckImageList.ImageSize = new System.Drawing.Size(16, 16);
            c1TreeColumn1.HeaderText = "Column1";
            c1TreeColumn1.Name = "Column1";
            this.c1TreeView1.Columns.Add(c1TreeColumn1);
            this.c1TreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1TreeView1.Location = new System.Drawing.Point(0, 0);
            this.c1TreeView1.Name = "c1TreeView1";
            this.c1TreeView1.Size = new System.Drawing.Size(492, 883);
            this.c1TreeView1.TabIndex = 0;
            this.c1ThemeController1.SetTheme(this.c1TreeView1, "(default)");
            this.c1TreeView1.SelectionChanged += new C1.Win.TreeView.C1TreeViewEventHandler(this.c1TreeView1_SelectionChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.label4.Location = new System.Drawing.Point(95, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "Count of levels:";
            this.c1ThemeController1.SetTheme(this.label4, "(default)");
            // 
            // nudLevelsCount
            // 
            this.nudLevelsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.nudLevelsCount.Location = new System.Drawing.Point(253, 181);
            this.nudLevelsCount.Margin = new System.Windows.Forms.Padding(6);
            this.nudLevelsCount.Name = "nudLevelsCount";
            this.nudLevelsCount.Size = new System.Drawing.Size(148, 29);
            this.nudLevelsCount.TabIndex = 16;
            this.c1ThemeController1.SetTheme(this.nudLevelsCount, "(default)");
            this.nudLevelsCount.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.label3.Location = new System.Drawing.Point(88, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Count of Nodes:";
            this.c1ThemeController1.SetTheme(this.label3, "(default)");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.label2.Location = new System.Drawing.Point(46, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Count of RootNodes:";
            this.c1ThemeController1.SetTheme(this.label2, "(default)");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.label1.Location = new System.Drawing.Point(73, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Count of columns:";
            this.c1ThemeController1.SetTheme(this.label1, "(default)");
            // 
            // nudRootNodesCount
            // 
            this.nudRootNodesCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.nudRootNodesCount.Location = new System.Drawing.Point(253, 81);
            this.nudRootNodesCount.Margin = new System.Windows.Forms.Padding(6);
            this.nudRootNodesCount.Name = "nudRootNodesCount";
            this.nudRootNodesCount.Size = new System.Drawing.Size(148, 29);
            this.nudRootNodesCount.TabIndex = 12;
            this.c1ThemeController1.SetTheme(this.nudRootNodesCount, "(default)");
            this.nudRootNodesCount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // nudNodesCount
            // 
            this.nudNodesCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.nudNodesCount.Location = new System.Drawing.Point(253, 131);
            this.nudNodesCount.Margin = new System.Windows.Forms.Padding(6);
            this.nudNodesCount.Name = "nudNodesCount";
            this.nudNodesCount.Size = new System.Drawing.Size(148, 29);
            this.nudNodesCount.TabIndex = 11;
            this.c1ThemeController1.SetTheme(this.nudNodesCount, "(default)");
            this.nudNodesCount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // nudColumnsCount
            // 
            this.nudColumnsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.nudColumnsCount.Location = new System.Drawing.Point(253, 31);
            this.nudColumnsCount.Margin = new System.Windows.Forms.Padding(6);
            this.nudColumnsCount.Name = "nudColumnsCount";
            this.nudColumnsCount.Size = new System.Drawing.Size(148, 29);
            this.nudColumnsCount.TabIndex = 10;
            this.c1ThemeController1.SetTheme(this.nudColumnsCount, "(default)");
            this.nudColumnsCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // btnClearTree
            // 
            this.btnClearTree.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnClearTree.Location = new System.Drawing.Point(277, 244);
            this.btnClearTree.Margin = new System.Windows.Forms.Padding(6);
            this.btnClearTree.Name = "btnClearTree";
            this.btnClearTree.Size = new System.Drawing.Size(222, 67);
            this.btnClearTree.TabIndex = 4;
            this.btnClearTree.Text = "Clear Tree";
            this.c1ThemeController1.SetTheme(this.btnClearTree, "(default)");
            this.btnClearTree.UseVisualStyleBackColor = true;
            this.btnClearTree.UseVisualStyleForeColor = true;
            this.btnClearTree.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.btnClearTree.Click += new System.EventHandler(this.btnClearTree_Click);
            // 
            // btnGenereteTree
            // 
            this.btnGenereteTree.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnGenereteTree.Location = new System.Drawing.Point(21, 244);
            this.btnGenereteTree.Margin = new System.Windows.Forms.Padding(6);
            this.btnGenereteTree.Name = "btnGenereteTree";
            this.btnGenereteTree.Size = new System.Drawing.Size(227, 67);
            this.btnGenereteTree.TabIndex = 3;
            this.btnGenereteTree.Text = "Generate Tree";
            this.c1ThemeController1.SetTheme(this.btnGenereteTree, "(default)");
            this.btnGenereteTree.UseVisualStyleBackColor = true;
            this.btnGenereteTree.UseVisualStyleForeColor = true;
            this.btnGenereteTree.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.btnGenereteTree.Click += new System.EventHandler(this.btnGenerateTree_Click);
            // 
            // c1DockingTabPage2
            // 
            this.c1DockingTabPage2.Controls.Add(this.pgColumn);
            this.c1DockingTabPage2.Controls.Add(this.cmbSelectedColumn);
            this.c1DockingTabPage2.Controls.Add(this.c1Label1);
            this.c1DockingTabPage2.Controls.Add(this.btnAddNewColumn);
            this.c1DockingTabPage2.Controls.Add(this.btnRemoveColumn);
            this.c1DockingTabPage2.Location = new System.Drawing.Point(5, 37);
            this.c1DockingTabPage2.Name = "c1DockingTabPage2";
            this.c1DockingTabPage2.Size = new System.Drawing.Size(582, 841);
            this.c1DockingTabPage2.TabIndex = 1;
            this.c1DockingTabPage2.Text = "Columns";
            // 
            // pgColumn
            // 
            this.pgColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgColumn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pgColumn.CategoryForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pgColumn.CommandsActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(40)))), ((int)(((byte)(128)))));
            this.pgColumn.CommandsBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pgColumn.CommandsDisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.pgColumn.CommandsForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.pgColumn.CommandsLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(184)))));
            this.pgColumn.DisabledItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.pgColumn.HelpBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pgColumn.HelpForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.pgColumn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pgColumn.Location = new System.Drawing.Point(24, 190);
            this.pgColumn.Margin = new System.Windows.Forms.Padding(6);
            this.pgColumn.Name = "pgColumn";
            this.pgColumn.Size = new System.Drawing.Size(528, 590);
            this.pgColumn.TabIndex = 4;
            this.c1ThemeController1.SetTheme(this.pgColumn, "(default)");
            this.pgColumn.ViewBackColor = System.Drawing.Color.White;
            this.pgColumn.ViewForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            // 
            // cmbSelectedColumn
            // 
            this.cmbSelectedColumn.AllowSpinLoop = false;
            this.cmbSelectedColumn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmbSelectedColumn.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cmbSelectedColumn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbSelectedColumn.GapHeight = 0;
            this.cmbSelectedColumn.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cmbSelectedColumn.Location = new System.Drawing.Point(275, 144);
            this.cmbSelectedColumn.Margin = new System.Windows.Forms.Padding(6);
            this.cmbSelectedColumn.Name = "cmbSelectedColumn";
            this.cmbSelectedColumn.Size = new System.Drawing.Size(249, 29);
            this.cmbSelectedColumn.Style.DropDownCorners = new C1.Framework.Corners(0, 0, 4, 4);
            this.cmbSelectedColumn.Style.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbSelectedColumn.Style.SelectionView = C1.Win.C1Input.SelectionView.LeftBorderLine;
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
            this.c1Label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.c1Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.c1Label1.Location = new System.Drawing.Point(116, 148);
            this.c1Label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.c1Label1.Name = "c1Label1";
            this.c1Label1.Padding = new System.Windows.Forms.Padding(2);
            this.c1Label1.Size = new System.Drawing.Size(126, 25);
            this.c1Label1.TabIndex = 2;
            this.c1Label1.Tag = null;
            this.c1Label1.Text = "Current column:";
            this.c1Label1.TextDetached = true;
            this.c1ThemeController1.SetTheme(this.c1Label1, "(default)");
            this.c1Label1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // btnAddNewColumn
            // 
            this.btnAddNewColumn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAddNewColumn.Location = new System.Drawing.Point(59, 37);
            this.btnAddNewColumn.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddNewColumn.Name = "btnAddNewColumn";
            this.btnAddNewColumn.Size = new System.Drawing.Size(211, 88);
            this.btnAddNewColumn.TabIndex = 1;
            this.btnAddNewColumn.Text = "Add column";
            this.c1ThemeController1.SetTheme(this.btnAddNewColumn, "(default)");
            this.btnAddNewColumn.UseVisualStyleBackColor = true;
            this.btnAddNewColumn.UseVisualStyleForeColor = true;
            this.btnAddNewColumn.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.btnAddNewColumn.Click += new System.EventHandler(this.btnAddNewColumn_Click);
            // 
            // btnRemoveColumn
            // 
            this.btnRemoveColumn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnRemoveColumn.Location = new System.Drawing.Point(313, 37);
            this.btnRemoveColumn.Margin = new System.Windows.Forms.Padding(6);
            this.btnRemoveColumn.Name = "btnRemoveColumn";
            this.btnRemoveColumn.Size = new System.Drawing.Size(211, 88);
            this.btnRemoveColumn.TabIndex = 0;
            this.btnRemoveColumn.Text = "Remove column";
            this.c1ThemeController1.SetTheme(this.btnRemoveColumn, "(default)");
            this.btnRemoveColumn.UseVisualStyleBackColor = true;
            this.btnRemoveColumn.UseVisualStyleForeColor = true;
            this.btnRemoveColumn.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.btnRemoveColumn.Click += new System.EventHandler(this.btnRemoveColumn_Click);
            // 
            // c1DockingTabPage3
            // 
            this.c1DockingTabPage3.Controls.Add(this.pgNode);
            this.c1DockingTabPage3.Controls.Add(this.btnRemoveSelectedNodes);
            this.c1DockingTabPage3.Location = new System.Drawing.Point(5, 37);
            this.c1DockingTabPage3.Name = "c1DockingTabPage3";
            this.c1DockingTabPage3.Size = new System.Drawing.Size(582, 841);
            this.c1DockingTabPage3.TabIndex = 2;
            this.c1DockingTabPage3.Text = "Nodes";
            // 
            // pgNode
            // 
            this.pgNode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgNode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pgNode.CategoryForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pgNode.CommandsActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(40)))), ((int)(((byte)(128)))));
            this.pgNode.CommandsBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pgNode.CommandsDisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.pgNode.CommandsForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.pgNode.CommandsLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(184)))));
            this.pgNode.DisabledItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.pgNode.HelpBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pgNode.HelpForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.pgNode.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pgNode.Location = new System.Drawing.Point(0, 158);
            this.pgNode.Margin = new System.Windows.Forms.Padding(6);
            this.pgNode.Name = "pgNode";
            this.pgNode.Size = new System.Drawing.Size(574, 644);
            this.pgNode.TabIndex = 0;
            this.c1ThemeController1.SetTheme(this.pgNode, "(default)");
            this.pgNode.ViewBackColor = System.Drawing.Color.White;
            this.pgNode.ViewForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            // 
            // btnRemoveSelectedNodes
            // 
            this.btnRemoveSelectedNodes.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnRemoveSelectedNodes.Location = new System.Drawing.Point(117, 38);
            this.btnRemoveSelectedNodes.Margin = new System.Windows.Forms.Padding(6);
            this.btnRemoveSelectedNodes.Name = "btnRemoveSelectedNodes";
            this.btnRemoveSelectedNodes.Size = new System.Drawing.Size(328, 90);
            this.btnRemoveSelectedNodes.TabIndex = 1;
            this.btnRemoveSelectedNodes.Text = "Remove selected nodes";
            this.c1ThemeController1.SetTheme(this.btnRemoveSelectedNodes, "(default)");
            this.btnRemoveSelectedNodes.UseVisualStyleBackColor = true;
            this.btnRemoveSelectedNodes.UseVisualStyleForeColor = true;
            this.btnRemoveSelectedNodes.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.btnRemoveSelectedNodes.Click += new System.EventHandler(this.btnRemoveSelectedNodes_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel2.Controls.Add(this.c1TreeView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(492, 883);
            this.panel2.TabIndex = 2;
            this.c1ThemeController1.SetTheme(this.panel2, "(default)");
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.splitContainer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(6);
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
            this.splitContainer1.Size = new System.Drawing.Size(1091, 883);
            this.splitContainer1.SplitterDistance = 492;
            this.splitContainer1.SplitterWidth = 7;
            this.splitContainer1.TabIndex = 1;
            this.c1ThemeController1.SetTheme(this.splitContainer1, "(default)");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 883);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(239)))));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "UnboundMode";
            this.c1ThemeController1.SetTheme(this, "(default)");
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).EndInit();
            this.c1DockingTab1.ResumeLayout(false);
            this.c1DockingTabPage1.ResumeLayout(false);
            this.c1DockingTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1TreeView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevelsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRootNodesCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNodesCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumnsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClearTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGenereteTree)).EndInit();
            this.c1DockingTabPage2.ResumeLayout(false);
            this.c1DockingTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSelectedColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddNewColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoveColumn)).EndInit();
            this.c1DockingTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoveSelectedNodes)).EndInit();
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private C1.Win.Themes.C1ThemeController c1ThemeController1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private C1.Win.Command.C1DockingTab c1DockingTab1;
        private C1.Win.Command.C1DockingTabPage c1DockingTabPage1;
        private C1.Win.Command.C1DockingTabPage c1DockingTabPage2;
        private System.Windows.Forms.PropertyGrid pgColumn;
        private C1.Win.C1Input.C1ComboBox cmbSelectedColumn;
        private C1.Win.C1Input.C1Label c1Label1;
        private C1.Win.C1Input.C1Button btnAddNewColumn;
        private C1.Win.C1Input.C1Button btnRemoveColumn;
        private C1.Win.Command.C1DockingTabPage c1DockingTabPage3;
        private System.Windows.Forms.PropertyGrid pgNode;
        private C1.Win.TreeView.C1TreeView c1TreeView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudRootNodesCount;
        private System.Windows.Forms.NumericUpDown nudNodesCount;
        private System.Windows.Forms.NumericUpDown nudColumnsCount;
        private C1.Win.C1Input.C1Button btnClearTree;
        private C1.Win.C1Input.C1Button btnGenereteTree;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudLevelsCount;
        private C1.Win.C1Input.C1Button btnRemoveSelectedNodes;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
    }
}


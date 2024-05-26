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
            C1.Win.TreeView.C1TreeColumn c1TreeColumn1 = new C1.Win.TreeView.C1TreeColumn();
            this.c1ThemeController1 = new C1.Win.C1Themes.C1ThemeController();
            this.panel1 = new System.Windows.Forms.Panel();
            this.c1DockingTab1 = new C1.Win.C1Command.C1DockingTab();
            this.c1DockingTabPage1 = new C1.Win.C1Command.C1DockingTabPage();
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
            this.c1DockingTabPage2 = new C1.Win.C1Command.C1DockingTabPage();
            this.pgColumn = new System.Windows.Forms.PropertyGrid();
            this.cmbSelectedColumn = new C1.Win.C1Input.C1ComboBox();
            this.c1Label1 = new C1.Win.C1Input.C1Label();
            this.btnAddNewColumn = new C1.Win.C1Input.C1Button();
            this.btnRemoveColumn = new C1.Win.C1Input.C1Button();
            this.c1DockingTabPage3 = new C1.Win.C1Command.C1DockingTabPage();
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
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.c1DockingTab1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(169)))), ((int)(((byte)(23)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 459);
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
            this.c1DockingTab1.HotTrack = true;
            this.c1DockingTab1.Location = new System.Drawing.Point(0, 0);
            this.c1DockingTab1.Name = "c1DockingTab1";
            this.c1DockingTab1.Size = new System.Drawing.Size(312, 459);
            this.c1DockingTab1.TabIndex = 0;
            this.c1DockingTab1.TabSizeMode = C1.Win.C1Command.TabSizeModeEnum.Fit;
            this.c1DockingTab1.TabsSpacing = 2;
            this.c1DockingTab1.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2007;
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
            this.c1DockingTabPage1.Location = new System.Drawing.Point(1, 24);
            this.c1DockingTabPage1.Name = "c1DockingTabPage1";
            this.c1DockingTabPage1.Size = new System.Drawing.Size(310, 434);
            this.c1DockingTabPage1.TabIndex = 0;
            this.c1DockingTabPage1.Text = "Edit TreeView";
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid1.BackColor = System.Drawing.Color.White;
            this.propertyGrid1.CategoryForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(169)))), ((int)(((byte)(23)))));
            this.propertyGrid1.CommandsActiveLinkColor = System.Drawing.Color.IndianRed;
            this.propertyGrid1.CommandsBackColor = System.Drawing.Color.White;
            this.propertyGrid1.CommandsDisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.propertyGrid1.CommandsForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(169)))), ((int)(((byte)(23)))));
            this.propertyGrid1.CommandsLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(159)))));
            this.propertyGrid1.HelpBackColor = System.Drawing.Color.White;
            this.propertyGrid1.HelpForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(169)))), ((int)(((byte)(23)))));
            this.propertyGrid1.LineColor = System.Drawing.Color.White;
            this.propertyGrid1.Location = new System.Drawing.Point(0, 178);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.SelectedObject = this.c1TreeView1;
            this.propertyGrid1.Size = new System.Drawing.Size(310, 256);
            this.propertyGrid1.TabIndex = 18;
            this.c1ThemeController1.SetTheme(this.propertyGrid1, "(default)");
            this.propertyGrid1.ViewBackColor = System.Drawing.Color.White;
            this.propertyGrid1.ViewForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            // 
            // c1TreeView1
            // 
            this.c1TreeView1.AutoSizeElement = C1.Framework.AutoSizeElement.Both;
            this.c1TreeView1.BackColor = System.Drawing.Color.White;
            c1TreeColumn1.DisplayFieldName = null;
            c1TreeColumn1.HeaderText = "Column1";
            c1TreeColumn1.Name = "Column1";
            this.c1TreeView1.Columns.Add(c1TreeColumn1);
            this.c1TreeView1.BindingInfo.DataMember = null;
            this.c1TreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1TreeView1.BindingInfo.KeyField = null;
            this.c1TreeView1.Location = new System.Drawing.Point(0, 0);
            this.c1TreeView1.Name = "c1TreeView1";
            this.c1TreeView1.BindingInfo.ParentKeyField = null;
            this.c1TreeView1.Size = new System.Drawing.Size(527, 459);
            this.c1TreeView1.TabIndex = 0;
            this.c1ThemeController1.SetTheme(this.c1TreeView1, "(default)");
            this.c1TreeView1.SelectionChanged += new C1.Win.TreeView.C1TreeViewEventHandler(this.c1TreeView1_SelectionChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(169)))), ((int)(((byte)(23)))));
            this.label4.Location = new System.Drawing.Point(52, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Count of levels:";
            this.c1ThemeController1.SetTheme(this.label4, "(default)");
            // 
            // nudLevelsCount
            // 
            this.nudLevelsCount.BackColor = System.Drawing.Color.White;
            this.nudLevelsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.nudLevelsCount.Location = new System.Drawing.Point(138, 94);
            this.nudLevelsCount.Name = "nudLevelsCount";
            this.nudLevelsCount.Size = new System.Drawing.Size(81, 20);
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
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(169)))), ((int)(((byte)(23)))));
            this.label3.Location = new System.Drawing.Point(48, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Count of Nodes:";
            this.c1ThemeController1.SetTheme(this.label3, "(default)");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(169)))), ((int)(((byte)(23)))));
            this.label2.Location = new System.Drawing.Point(25, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Count of RootNodes:";
            this.c1ThemeController1.SetTheme(this.label2, "(default)");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(169)))), ((int)(((byte)(23)))));
            this.label1.Location = new System.Drawing.Point(40, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Count of columns:";
            this.c1ThemeController1.SetTheme(this.label1, "(default)");
            // 
            // nudRootNodesCount
            // 
            this.nudRootNodesCount.BackColor = System.Drawing.Color.White;
            this.nudRootNodesCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.nudRootNodesCount.Location = new System.Drawing.Point(138, 42);
            this.nudRootNodesCount.Name = "nudRootNodesCount";
            this.nudRootNodesCount.Size = new System.Drawing.Size(81, 20);
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
            this.nudNodesCount.BackColor = System.Drawing.Color.White;
            this.nudNodesCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.nudNodesCount.Location = new System.Drawing.Point(138, 68);
            this.nudNodesCount.Name = "nudNodesCount";
            this.nudNodesCount.Size = new System.Drawing.Size(81, 20);
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
            this.nudColumnsCount.BackColor = System.Drawing.Color.White;
            this.nudColumnsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.nudColumnsCount.Location = new System.Drawing.Point(138, 16);
            this.nudColumnsCount.Name = "nudColumnsCount";
            this.nudColumnsCount.Size = new System.Drawing.Size(81, 20);
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
            this.btnClearTree.Location = new System.Drawing.Point(169, 127);
            this.btnClearTree.Name = "btnClearTree";
            this.btnClearTree.Size = new System.Drawing.Size(121, 35);
            this.btnClearTree.TabIndex = 4;
            this.btnClearTree.Text = "Clear Tree";
            this.c1ThemeController1.SetTheme(this.btnClearTree, "(default)");
            this.btnClearTree.UseVisualStyleBackColor = true;
            this.btnClearTree.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.btnClearTree.Click += new System.EventHandler(this.btnClearTree_Click);
            // 
            // btnGenereteTree
            // 
            this.btnGenereteTree.Location = new System.Drawing.Point(28, 127);
            this.btnGenereteTree.Name = "btnGenereteTree";
            this.btnGenereteTree.Size = new System.Drawing.Size(124, 35);
            this.btnGenereteTree.TabIndex = 3;
            this.btnGenereteTree.Text = "Generate Tree";
            this.c1ThemeController1.SetTheme(this.btnGenereteTree, "(default)");
            this.btnGenereteTree.UseVisualStyleBackColor = true;
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
            this.pgColumn.BackColor = System.Drawing.Color.White;
            this.pgColumn.CategoryForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(169)))), ((int)(((byte)(23)))));
            this.pgColumn.CommandsActiveLinkColor = System.Drawing.Color.IndianRed;
            this.pgColumn.CommandsBackColor = System.Drawing.Color.White;
            this.pgColumn.CommandsDisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.pgColumn.CommandsForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(169)))), ((int)(((byte)(23)))));
            this.pgColumn.CommandsLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(159)))));
            this.pgColumn.HelpBackColor = System.Drawing.Color.White;
            this.pgColumn.HelpForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(169)))), ((int)(((byte)(23)))));
            this.pgColumn.LineColor = System.Drawing.Color.White;
            this.pgColumn.Location = new System.Drawing.Point(13, 99);
            this.pgColumn.Name = "pgColumn";
            this.pgColumn.Size = new System.Drawing.Size(285, 324);
            this.pgColumn.TabIndex = 4;
            this.c1ThemeController1.SetTheme(this.pgColumn, "(default)");
            this.pgColumn.ViewBackColor = System.Drawing.Color.White;
            this.pgColumn.ViewForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            // 
            // cmbSelectedColumn
            // 
            this.cmbSelectedColumn.AllowSpinLoop = false;
            this.cmbSelectedColumn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.cmbSelectedColumn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmbSelectedColumn.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.cmbSelectedColumn.GapHeight = 0;
            this.cmbSelectedColumn.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cmbSelectedColumn.ItemsDisplayMember = "";
            this.cmbSelectedColumn.ItemsValueMember = "";
            this.cmbSelectedColumn.Location = new System.Drawing.Point(150, 75);
            this.cmbSelectedColumn.Name = "cmbSelectedColumn";
            this.cmbSelectedColumn.Size = new System.Drawing.Size(136, 18);
            this.cmbSelectedColumn.Style.DropDownBackColor = System.Drawing.Color.White;
            this.cmbSelectedColumn.Style.DropDownBorderColor = System.Drawing.Color.Gainsboro;
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
            this.c1Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
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
            this.c1DockingTabPage3.Controls.Add(this.btnRemoveSelectedNodes);
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
            this.pgNode.BackColor = System.Drawing.Color.White;
            this.pgNode.CategoryForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(169)))), ((int)(((byte)(23)))));
            this.pgNode.CommandsActiveLinkColor = System.Drawing.Color.IndianRed;
            this.pgNode.CommandsBackColor = System.Drawing.Color.White;
            this.pgNode.CommandsDisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.pgNode.CommandsForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(169)))), ((int)(((byte)(23)))));
            this.pgNode.CommandsLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(159)))));
            this.pgNode.HelpBackColor = System.Drawing.Color.White;
            this.pgNode.HelpForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(169)))), ((int)(((byte)(23)))));
            this.pgNode.LineColor = System.Drawing.Color.White;
            this.pgNode.Location = new System.Drawing.Point(0, 82);
            this.pgNode.Name = "pgNode";
            this.pgNode.Size = new System.Drawing.Size(310, 352);
            this.pgNode.TabIndex = 0;
            this.c1ThemeController1.SetTheme(this.pgNode, "(default)");
            this.pgNode.ViewBackColor = System.Drawing.Color.White;
            this.pgNode.ViewForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            // 
            // btnRemoveSelectedNodes
            // 
            this.btnRemoveSelectedNodes.Location = new System.Drawing.Point(64, 20);
            this.btnRemoveSelectedNodes.Name = "btnRemoveSelectedNodes";
            this.btnRemoveSelectedNodes.Size = new System.Drawing.Size(179, 47);
            this.btnRemoveSelectedNodes.TabIndex = 1;
            this.btnRemoveSelectedNodes.Text = "Remove selected nodes";
            this.c1ThemeController1.SetTheme(this.btnRemoveSelectedNodes, "(default)");
            this.btnRemoveSelectedNodes.UseVisualStyleBackColor = true;
            this.btnRemoveSelectedNodes.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.btnRemoveSelectedNodes.Click += new System.EventHandler(this.btnRemoveSelectedNodes_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.c1TreeView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(169)))), ((int)(((byte)(23)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(527, 459);
            this.panel2.TabIndex = 2;
            this.c1ThemeController1.SetTheme(this.panel2, "(default)");
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(169)))), ((int)(((byte)(23)))));
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
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(239)))));
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
        private C1.Win.C1Themes.C1ThemeController c1ThemeController1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private C1.Win.C1Command.C1DockingTab c1DockingTab1;
        private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage1;
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


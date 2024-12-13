namespace TreeViewExplorer.Samples
{
    partial class UnboundMode
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
            c1ThemeController1 = new C1.Win.Themes.C1ThemeController();
            panel1 = new System.Windows.Forms.Panel();
            c1DockingTab1 = new C1.Win.Command.C1DockingTab();
            c1DockingTabPage1 = new C1.Win.Command.C1DockingTabPage();
            propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            c1TreeView1 = new C1.Win.TreeView.C1TreeView();
            panel3 = new System.Windows.Forms.Panel();
            nudRootNodesCount = new System.Windows.Forms.NumericUpDown();
            label4 = new System.Windows.Forms.Label();
            btnGenereteTree = new C1.Win.Input.C1Button();
            nudLevelsCount = new System.Windows.Forms.NumericUpDown();
            btnClearTree = new C1.Win.Input.C1Button();
            label3 = new System.Windows.Forms.Label();
            nudColumnsCount = new System.Windows.Forms.NumericUpDown();
            label2 = new System.Windows.Forms.Label();
            nudNodesCount = new System.Windows.Forms.NumericUpDown();
            label1 = new System.Windows.Forms.Label();
            c1DockingTabPage2 = new C1.Win.Command.C1DockingTabPage();
            pgColumn = new System.Windows.Forms.PropertyGrid();
            panel4 = new System.Windows.Forms.Panel();
            btnAddNewColumn = new C1.Win.Input.C1Button();
            cmbSelectedColumn = new C1.Win.Input.C1ComboBox();
            btnRemoveColumn = new C1.Win.Input.C1Button();
            c1Label1 = new C1.Win.Input.C1Label();
            c1DockingTabPage3 = new C1.Win.Command.C1DockingTabPage();
            pgNode = new System.Windows.Forms.PropertyGrid();
            panel5 = new System.Windows.Forms.Panel();
            btnRemoveSelectedNodes = new C1.Win.Input.C1Button();
            panel2 = new System.Windows.Forms.Panel();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)c1ThemeController1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)c1DockingTab1).BeginInit();
            c1DockingTab1.SuspendLayout();
            c1DockingTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)c1TreeView1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudRootNodesCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnGenereteTree).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudLevelsCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClearTree).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudColumnsCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNodesCount).BeginInit();
            c1DockingTabPage2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnAddNewColumn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbSelectedColumn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRemoveColumn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1Label1).BeginInit();
            c1DockingTabPage3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnRemoveSelectedNodes).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // c1ThemeController1
            // 
            c1ThemeController1.Theme = "Office365White";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            panel1.Controls.Add(c1DockingTab1);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Font = new System.Drawing.Font("Segoe UI", 14F);
            panel1.ForeColor = System.Drawing.Color.FromArgb(32, 32, 32);
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(780, 1341);
            panel1.TabIndex = 1;
            c1ThemeController1.SetTheme(panel1, "(default)");
            // 
            // c1DockingTab1
            // 
            c1DockingTab1.BackColor = System.Drawing.Color.White;
            c1DockingTab1.Controls.Add(c1DockingTabPage1);
            c1DockingTab1.Controls.Add(c1DockingTabPage2);
            c1DockingTab1.Controls.Add(c1DockingTabPage3);
            c1DockingTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            c1DockingTab1.Font = new System.Drawing.Font("Segoe UI", 12F);
            c1DockingTab1.HotTrack = true;
            c1DockingTab1.Location = new System.Drawing.Point(0, 0);
            c1DockingTab1.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            c1DockingTab1.Name = "c1DockingTab1";
            c1DockingTab1.Size = new System.Drawing.Size(780, 1341);
            c1DockingTab1.TabIndex = 0;
            c1DockingTab1.TabShape = C1.Win.Command.TabShape.Rounded;
            c1DockingTab1.TabSizeMode = C1.Win.Command.TabSizeModeEnum.Fit;
            c1DockingTab1.TabsSpacing = 2;
            c1ThemeController1.SetTheme(c1DockingTab1, "(default)");
            // 
            // c1DockingTabPage1
            // 
            c1DockingTabPage1.CaptionText = "TreeView";
            c1DockingTabPage1.Controls.Add(propertyGrid1);
            c1DockingTabPage1.Controls.Add(panel3);
            c1DockingTabPage1.Location = new System.Drawing.Point(5, 49);
            c1DockingTabPage1.Name = "c1DockingTabPage1";
            c1DockingTabPage1.Size = new System.Drawing.Size(770, 1287);
            c1DockingTabPage1.TabIndex = 0;
            c1DockingTabPage1.Text = "Edit TreeView";
            // 
            // propertyGrid1
            // 
            propertyGrid1.BackColor = System.Drawing.SystemColors.ButtonFace;
            propertyGrid1.CategoryForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            propertyGrid1.CommandsActiveLinkColor = System.Drawing.Color.FromArgb(128, 40, 128);
            propertyGrid1.CommandsBackColor = System.Drawing.SystemColors.ButtonFace;
            propertyGrid1.CommandsDisabledLinkColor = System.Drawing.Color.FromArgb(175, 175, 175);
            propertyGrid1.CommandsForeColor = System.Drawing.Color.FromArgb(32, 32, 32);
            propertyGrid1.CommandsLinkColor = System.Drawing.Color.FromArgb(0, 95, 184);
            propertyGrid1.DisabledItemForeColor = System.Drawing.Color.FromArgb(127, 32, 32, 32);
            propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            propertyGrid1.HelpBackColor = System.Drawing.SystemColors.ButtonFace;
            propertyGrid1.HelpForeColor = System.Drawing.Color.FromArgb(32, 32, 32);
            propertyGrid1.LineColor = System.Drawing.SystemColors.ButtonFace;
            propertyGrid1.Location = new System.Drawing.Point(0, 440);
            propertyGrid1.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            propertyGrid1.Name = "propertyGrid1";
            propertyGrid1.SelectedObject = c1TreeView1;
            propertyGrid1.Size = new System.Drawing.Size(770, 847);
            propertyGrid1.TabIndex = 18;
            c1ThemeController1.SetTheme(propertyGrid1, "(default)");
            propertyGrid1.ViewBackColor = System.Drawing.Color.White;
            propertyGrid1.ViewForeColor = System.Drawing.Color.FromArgb(32, 32, 32);
            // 
            // c1TreeView1
            // 
            c1TreeView1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            c1TreeView1.ButtonImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            c1TreeView1.ButtonImageList.ImageSize = new System.Drawing.Size(16, 16);
            // 
            // 
            // 
            c1TreeView1.CheckImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            c1TreeView1.CheckImageList.ImageSize = new System.Drawing.Size(16, 16);
            c1TreeColumn1.HeaderText = "Column1";
            c1TreeColumn1.Name = "Column1";
            c1TreeView1.Columns.Add(c1TreeColumn1);
            c1TreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            c1TreeView1.Location = new System.Drawing.Point(0, 0);
            c1TreeView1.Name = "c1TreeView1";
            c1TreeView1.Size = new System.Drawing.Size(1315, 1341);
            c1TreeView1.TabIndex = 0;
            c1ThemeController1.SetTheme(c1TreeView1, "(default)");
            c1TreeView1.SelectionChanged += c1TreeView1_SelectionChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(nudRootNodesCount);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(btnGenereteTree);
            panel3.Controls.Add(nudLevelsCount);
            panel3.Controls.Add(btnClearTree);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(nudColumnsCount);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(nudNodesCount);
            panel3.Controls.Add(label1);
            panel3.Dock = System.Windows.Forms.DockStyle.Top;
            panel3.Location = new System.Drawing.Point(0, 0);
            panel3.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(770, 440);
            panel3.TabIndex = 1;
            // 
            // nudRootNodesCount
            // 
            nudRootNodesCount.ForeColor = System.Drawing.Color.FromArgb(32, 32, 32);
            nudRootNodesCount.Location = new System.Drawing.Point(285, 103);
            nudRootNodesCount.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            nudRootNodesCount.Name = "nudRootNodesCount";
            nudRootNodesCount.Size = new System.Drawing.Size(201, 39);
            nudRootNodesCount.TabIndex = 12;
            c1ThemeController1.SetTheme(nudRootNodesCount, "(default)");
            nudRootNodesCount.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.ForeColor = System.Drawing.Color.FromArgb(32, 32, 32);
            label4.Location = new System.Drawing.Point(71, 262);
            label4.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(180, 32);
            label4.TabIndex = 17;
            label4.Text = "Count of levels:";
            c1ThemeController1.SetTheme(label4, "(default)");
            // 
            // btnGenereteTree
            // 
            btnGenereteTree.Location = new System.Drawing.Point(19, 351);
            btnGenereteTree.Name = "btnGenereteTree";
            btnGenereteTree.Size = new System.Drawing.Size(259, 60);
            btnGenereteTree.TabIndex = 3;
            btnGenereteTree.Text = "Generate Tree";
            c1ThemeController1.SetTheme(btnGenereteTree, "(default)");
            btnGenereteTree.Click += btnGenerateTree_Click;
            // 
            // nudLevelsCount
            // 
            nudLevelsCount.ForeColor = System.Drawing.Color.FromArgb(32, 32, 32);
            nudLevelsCount.Location = new System.Drawing.Point(285, 255);
            nudLevelsCount.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            nudLevelsCount.Name = "nudLevelsCount";
            nudLevelsCount.Size = new System.Drawing.Size(201, 39);
            nudLevelsCount.TabIndex = 16;
            c1ThemeController1.SetTheme(nudLevelsCount, "(default)");
            nudLevelsCount.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // btnClearTree
            // 
            btnClearTree.Location = new System.Drawing.Point(302, 351);
            btnClearTree.Name = "btnClearTree";
            btnClearTree.Size = new System.Drawing.Size(184, 60);
            btnClearTree.TabIndex = 4;
            btnClearTree.Text = "Clear Tree";
            c1ThemeController1.SetTheme(btnClearTree, "(default)");
            btnClearTree.Click += btnClearTree_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.ForeColor = System.Drawing.Color.FromArgb(32, 32, 32);
            label3.Location = new System.Drawing.Point(60, 186);
            label3.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(189, 32);
            label3.TabIndex = 15;
            label3.Text = "Count of Nodes:";
            c1ThemeController1.SetTheme(label3, "(default)");
            // 
            // nudColumnsCount
            // 
            nudColumnsCount.ForeColor = System.Drawing.Color.FromArgb(32, 32, 32);
            nudColumnsCount.Location = new System.Drawing.Point(285, 27);
            nudColumnsCount.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            nudColumnsCount.Name = "nudColumnsCount";
            nudColumnsCount.Size = new System.Drawing.Size(201, 39);
            nudColumnsCount.TabIndex = 10;
            c1ThemeController1.SetTheme(nudColumnsCount, "(default)");
            nudColumnsCount.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.ForeColor = System.Drawing.Color.FromArgb(32, 32, 32);
            label2.Location = new System.Drawing.Point(2, 110);
            label2.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(238, 32);
            label2.TabIndex = 14;
            label2.Text = "Count of RootNodes:";
            c1ThemeController1.SetTheme(label2, "(default)");
            // 
            // nudNodesCount
            // 
            nudNodesCount.ForeColor = System.Drawing.Color.FromArgb(32, 32, 32);
            nudNodesCount.Location = new System.Drawing.Point(285, 179);
            nudNodesCount.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            nudNodesCount.Name = "nudNodesCount";
            nudNodesCount.Size = new System.Drawing.Size(201, 39);
            nudNodesCount.TabIndex = 11;
            c1ThemeController1.SetTheme(nudNodesCount, "(default)");
            nudNodesCount.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.ForeColor = System.Drawing.Color.FromArgb(32, 32, 32);
            label1.Location = new System.Drawing.Point(41, 34);
            label1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(210, 32);
            label1.TabIndex = 13;
            label1.Text = "Count of columns:";
            c1ThemeController1.SetTheme(label1, "(default)");
            // 
            // c1DockingTabPage2
            // 
            c1DockingTabPage2.Controls.Add(pgColumn);
            c1DockingTabPage2.Controls.Add(panel4);
            c1DockingTabPage2.Location = new System.Drawing.Point(5, 49);
            c1DockingTabPage2.Name = "c1DockingTabPage2";
            c1DockingTabPage2.Size = new System.Drawing.Size(770, 1287);
            c1DockingTabPage2.TabIndex = 1;
            c1DockingTabPage2.Text = "Columns";
            // 
            // pgColumn
            // 
            pgColumn.BackColor = System.Drawing.SystemColors.ButtonFace;
            pgColumn.CategoryForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            pgColumn.CommandsActiveLinkColor = System.Drawing.Color.FromArgb(128, 40, 128);
            pgColumn.CommandsBackColor = System.Drawing.SystemColors.ButtonFace;
            pgColumn.CommandsDisabledLinkColor = System.Drawing.Color.FromArgb(175, 175, 175);
            pgColumn.CommandsForeColor = System.Drawing.Color.FromArgb(32, 32, 32);
            pgColumn.CommandsLinkColor = System.Drawing.Color.FromArgb(0, 95, 184);
            pgColumn.DisabledItemForeColor = System.Drawing.Color.FromArgb(127, 32, 32, 32);
            pgColumn.Dock = System.Windows.Forms.DockStyle.Fill;
            pgColumn.HelpBackColor = System.Drawing.SystemColors.ButtonFace;
            pgColumn.HelpForeColor = System.Drawing.Color.FromArgb(32, 32, 32);
            pgColumn.LineColor = System.Drawing.SystemColors.ButtonFace;
            pgColumn.Location = new System.Drawing.Point(0, 212);
            pgColumn.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            pgColumn.Name = "pgColumn";
            pgColumn.Size = new System.Drawing.Size(770, 1075);
            pgColumn.TabIndex = 4;
            c1ThemeController1.SetTheme(pgColumn, "(default)");
            pgColumn.ViewBackColor = System.Drawing.Color.White;
            pgColumn.ViewForeColor = System.Drawing.Color.FromArgb(32, 32, 32);
            // 
            // panel4
            // 
            panel4.Controls.Add(btnAddNewColumn);
            panel4.Controls.Add(cmbSelectedColumn);
            panel4.Controls.Add(btnRemoveColumn);
            panel4.Controls.Add(c1Label1);
            panel4.Dock = System.Windows.Forms.DockStyle.Top;
            panel4.Location = new System.Drawing.Point(0, 0);
            panel4.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(770, 212);
            panel4.TabIndex = 1;
            // 
            // btnAddNewColumn
            // 
            btnAddNewColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            btnAddNewColumn.Location = new System.Drawing.Point(19, 36);
            btnAddNewColumn.Name = "btnAddNewColumn";
            btnAddNewColumn.Size = new System.Drawing.Size(229, 56);
            btnAddNewColumn.TabIndex = 1;
            btnAddNewColumn.Text = "Add column";
            c1ThemeController1.SetTheme(btnAddNewColumn, "(default)");
            btnAddNewColumn.Click += btnAddNewColumn_Click;
            // 
            // cmbSelectedColumn
            // 
            cmbSelectedColumn.Location = new System.Drawing.Point(261, 125);
            cmbSelectedColumn.Name = "cmbSelectedColumn";
            cmbSelectedColumn.Size = new System.Drawing.Size(287, 42);
            cmbSelectedColumn.TabIndex = 3;
            c1ThemeController1.SetTheme(cmbSelectedColumn, "(default)");
            cmbSelectedColumn.SelectedIndexChanged += cmbSelectedColumn_SelectedIndexChanged;
            // 
            // btnRemoveColumn
            // 
            btnRemoveColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            btnRemoveColumn.Location = new System.Drawing.Point(261, 36);
            btnRemoveColumn.Name = "btnRemoveColumn";
            btnRemoveColumn.Size = new System.Drawing.Size(287, 56);
            btnRemoveColumn.TabIndex = 0;
            btnRemoveColumn.Text = "Remove column";
            c1ThemeController1.SetTheme(btnRemoveColumn, "(default)");
            btnRemoveColumn.Click += btnRemoveColumn_Click;
            // 
            // c1Label1
            // 
            c1Label1.AutoSize = true;
            c1Label1.Location = new System.Drawing.Point(19, 125);
            c1Label1.Name = "c1Label1";
            c1Label1.Size = new System.Drawing.Size(192, 38);
            c1Label1.Styles.Default.ForeColor = System.Drawing.Color.FromArgb(68, 68, 68);
            c1Label1.TabIndex = 2;
            c1Label1.Text = "Current column:";
            c1ThemeController1.SetTheme(c1Label1, "(default)");
            // 
            // c1DockingTabPage3
            // 
            c1DockingTabPage3.Controls.Add(pgNode);
            c1DockingTabPage3.Controls.Add(panel5);
            c1DockingTabPage3.Location = new System.Drawing.Point(5, 49);
            c1DockingTabPage3.Name = "c1DockingTabPage3";
            c1DockingTabPage3.Size = new System.Drawing.Size(770, 1287);
            c1DockingTabPage3.TabIndex = 2;
            c1DockingTabPage3.Text = "Nodes";
            // 
            // pgNode
            // 
            pgNode.BackColor = System.Drawing.SystemColors.ButtonFace;
            pgNode.CategoryForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            pgNode.CommandsActiveLinkColor = System.Drawing.Color.FromArgb(128, 40, 128);
            pgNode.CommandsBackColor = System.Drawing.SystemColors.ButtonFace;
            pgNode.CommandsDisabledLinkColor = System.Drawing.Color.FromArgb(175, 175, 175);
            pgNode.CommandsForeColor = System.Drawing.Color.FromArgb(32, 32, 32);
            pgNode.CommandsLinkColor = System.Drawing.Color.FromArgb(0, 95, 184);
            pgNode.DisabledItemForeColor = System.Drawing.Color.FromArgb(127, 32, 32, 32);
            pgNode.Dock = System.Windows.Forms.DockStyle.Fill;
            pgNode.HelpBackColor = System.Drawing.SystemColors.ButtonFace;
            pgNode.HelpForeColor = System.Drawing.Color.FromArgb(32, 32, 32);
            pgNode.LineColor = System.Drawing.SystemColors.ButtonFace;
            pgNode.Location = new System.Drawing.Point(0, 121);
            pgNode.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            pgNode.Name = "pgNode";
            pgNode.Size = new System.Drawing.Size(770, 1166);
            pgNode.TabIndex = 0;
            c1ThemeController1.SetTheme(pgNode, "(default)");
            pgNode.ViewBackColor = System.Drawing.Color.White;
            pgNode.ViewForeColor = System.Drawing.Color.FromArgb(32, 32, 32);
            // 
            // panel5
            // 
            panel5.Controls.Add(btnRemoveSelectedNodes);
            panel5.Dock = System.Windows.Forms.DockStyle.Top;
            panel5.Location = new System.Drawing.Point(0, 0);
            panel5.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(770, 121);
            panel5.TabIndex = 1;
            // 
            // btnRemoveSelectedNodes
            // 
            btnRemoveSelectedNodes.Location = new System.Drawing.Point(28, 31);
            btnRemoveSelectedNodes.Name = "btnRemoveSelectedNodes";
            btnRemoveSelectedNodes.Size = new System.Drawing.Size(345, 65);
            btnRemoveSelectedNodes.Styles.Padding = new C1.Framework.Thickness(0, 0, 0, 0);
            btnRemoveSelectedNodes.TabIndex = 1;
            btnRemoveSelectedNodes.Text = "Remove selected nodes";
            c1ThemeController1.SetTheme(btnRemoveSelectedNodes, "(default)");
            btnRemoveSelectedNodes.Click += btnRemoveSelectedNodes_Click;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            panel2.Controls.Add(c1TreeView1);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Font = new System.Drawing.Font("Segoe UI", 14F);
            panel2.ForeColor = System.Drawing.Color.FromArgb(32, 32, 32);
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1315, 1341);
            panel2.TabIndex = 2;
            c1ThemeController1.SetTheme(panel2, "(default)");
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = System.Drawing.SystemColors.ButtonFace;
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Font = new System.Drawing.Font("Segoe UI", 14F);
            splitContainer1.ForeColor = System.Drawing.Color.FromArgb(32, 32, 32);
            splitContainer1.Location = new System.Drawing.Point(0, 0);
            splitContainer1.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel2);
            splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            splitContainer1.Size = new System.Drawing.Size(2106, 1341);
            splitContainer1.SplitterDistance = 1315;
            splitContainer1.SplitterWidth = 11;
            splitContainer1.TabIndex = 1;
            c1ThemeController1.SetTheme(splitContainer1, "(default)");
            // 
            // UnboundMode
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(15F, 38F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Font = new System.Drawing.Font("Segoe UI", 14F);
            ForeColor = System.Drawing.Color.FromArgb(0, 80, 239);
            Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            Name = "UnboundMode";
            Size = new System.Drawing.Size(2106, 1341);
            c1ThemeController1.SetTheme(this, "(default)");
            ((System.ComponentModel.ISupportInitialize)c1ThemeController1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)c1DockingTab1).EndInit();
            c1DockingTab1.ResumeLayout(false);
            c1DockingTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)c1TreeView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudRootNodesCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnGenereteTree).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudLevelsCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClearTree).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudColumnsCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNodesCount).EndInit();
            c1DockingTabPage2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnAddNewColumn).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbSelectedColumn).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRemoveColumn).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1Label1).EndInit();
            c1DockingTabPage3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnRemoveSelectedNodes).EndInit();
            panel2.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private C1.Win.Themes.C1ThemeController c1ThemeController1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private C1.Win.Command.C1DockingTab c1DockingTab1;
        private C1.Win.Command.C1DockingTabPage c1DockingTabPage1;
        private C1.Win.Command.C1DockingTabPage c1DockingTabPage2;
        private System.Windows.Forms.PropertyGrid pgColumn;
        private C1.Win.Input.C1ComboBox cmbSelectedColumn;
        private C1.Win.Input.C1Label c1Label1;
        private C1.Win.Input.C1Button btnAddNewColumn;
        private C1.Win.Input.C1Button btnRemoveColumn;
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
        private C1.Win.Input.C1Button btnClearTree;
        private C1.Win.Input.C1Button btnGenereteTree;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudLevelsCount;
        private C1.Win.Input.C1Button btnRemoveSelectedNodes;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}


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
            this.c1ThemeController1 = new C1.Win.Themes.C1ThemeController();
            this.panel1 = new System.Windows.Forms.Panel();
            this.c1DockingTab1 = new C1.Win.Command.C1DockingTab();
            this.c1DockingTabPage1 = new C1.Win.Command.C1DockingTabPage();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.c1TreeView1 = new C1.Win.TreeView.C1TreeView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nudRootNodesCount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGenereteTree = new C1.Win.Input.C1Button();
            this.nudLevelsCount = new System.Windows.Forms.NumericUpDown();
            this.btnClearTree = new C1.Win.Input.C1Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nudColumnsCount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudNodesCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.c1DockingTabPage2 = new C1.Win.Command.C1DockingTabPage();
            this.pgColumn = new System.Windows.Forms.PropertyGrid();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAddNewColumn = new C1.Win.Input.C1Button();
            this.cmbSelectedColumn = new C1.Win.Input.C1ComboBox();
            this.btnRemoveColumn = new C1.Win.Input.C1Button();
            this.c1Label1 = new C1.Win.Input.C1Label();
            this.c1DockingTabPage3 = new C1.Win.Command.C1DockingTabPage();
            this.pgNode = new System.Windows.Forms.PropertyGrid();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnRemoveSelectedNodes = new C1.Win.Input.C1Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).BeginInit();
            this.c1DockingTab1.SuspendLayout();
            this.c1DockingTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1TreeView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRootNodesCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevelsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumnsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNodesCount)).BeginInit();
            this.c1DockingTabPage2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSelectedColumn)).BeginInit();
            this.c1DockingTabPage3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // c1ThemeController1
            // 
            this.c1ThemeController1.Theme = "GreenHouse";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.c1DockingTab1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 600);
            this.panel1.TabIndex = 1;
            this.c1ThemeController1.SetTheme(this.panel1, "(default)");
            // 
            // c1DockingTab1
            // 
            this.c1DockingTab1.Controls.Add(this.c1DockingTabPage1);
            this.c1DockingTab1.Controls.Add(this.c1DockingTabPage2);
            this.c1DockingTab1.Controls.Add(this.c1DockingTabPage3);
            this.c1DockingTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1DockingTab1.HotTrack = true;
            this.c1DockingTab1.Location = new System.Drawing.Point(0, 0);
            this.c1DockingTab1.Margin = new System.Windows.Forms.Padding(4);
            this.c1DockingTab1.Name = "c1DockingTab1";
            this.c1DockingTab1.Size = new System.Drawing.Size(364, 600);
            this.c1DockingTab1.TabIndex = 0;
            this.c1DockingTab1.TabSizeMode = C1.Win.Command.TabSizeModeEnum.Fit;
            this.c1DockingTab1.TabsSpacing = 2;
            this.c1ThemeController1.SetTheme(this.c1DockingTab1, "(default)");
            // 
            // c1DockingTabPage1
            // 
            this.c1DockingTabPage1.CaptionText = "TreeView";
            this.c1DockingTabPage1.Controls.Add(this.propertyGrid1);
            this.c1DockingTabPage1.Controls.Add(this.panel3);
            this.c1DockingTabPage1.Location = new System.Drawing.Point(1, 29);
            this.c1DockingTabPage1.Name = "c1DockingTabPage1";
            this.c1DockingTabPage1.Size = new System.Drawing.Size(362, 570);
            this.c1DockingTabPage1.TabIndex = 0;
            this.c1DockingTabPage1.Text = "Edit TreeView";
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.Location = new System.Drawing.Point(0, 197);
            this.propertyGrid1.Margin = new System.Windows.Forms.Padding(4);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.SelectedObject = this.c1TreeView1;
            this.propertyGrid1.Size = new System.Drawing.Size(362, 373);
            this.propertyGrid1.TabIndex = 18;
            this.c1ThemeController1.SetTheme(this.propertyGrid1, "(default)");
            // 
            // c1TreeView1
            // 
            this.c1TreeView1.BackColor = System.Drawing.SystemColors.Control;
            this.c1TreeView1.BindingInfo.DataMember = null;
            this.c1TreeView1.BindingInfo.KeyField = null;
            this.c1TreeView1.BindingInfo.ParentKeyField = null;
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
            c1TreeColumn1.DisplayFieldName = null;
            c1TreeColumn1.HeaderText = "Column1";
            c1TreeColumn1.Name = "Column1";
            this.c1TreeView1.Columns.Add(c1TreeColumn1);
            this.c1TreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1TreeView1.Location = new System.Drawing.Point(0, 0);
            this.c1TreeView1.Name = "c1TreeView1";
            this.c1TreeView1.Size = new System.Drawing.Size(614, 600);
            this.c1TreeView1.TabIndex = 0;
            this.c1ThemeController1.SetTheme(this.c1TreeView1, "(default)");
            this.c1TreeView1.SelectionChanged += new C1.Win.TreeView.C1TreeViewEventHandler(this.c1TreeView1_SelectionChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.nudRootNodesCount);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btnGenereteTree);
            this.panel3.Controls.Add(this.nudLevelsCount);
            this.panel3.Controls.Add(this.btnClearTree);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.nudColumnsCount);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.nudNodesCount);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(362, 197);
            this.panel3.TabIndex = 1;
            // 
            // nudRootNodesCount
            // 
            this.nudRootNodesCount.Location = new System.Drawing.Point(133, 46);
            this.nudRootNodesCount.Margin = new System.Windows.Forms.Padding(4);
            this.nudRootNodesCount.Name = "nudRootNodesCount";
            this.nudRootNodesCount.Size = new System.Drawing.Size(94, 25);
            this.nudRootNodesCount.TabIndex = 12;
            this.c1ThemeController1.SetTheme(this.nudRootNodesCount, "(default)");
            this.nudRootNodesCount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Count of levels:";
            this.c1ThemeController1.SetTheme(this.label4, "(default)");
            // 
            // btnGenereteTree
            // 
            this.btnGenereteTree.Location = new System.Drawing.Point(9, 157);
            this.btnGenereteTree.Name = "btnGenereteTree";
            this.btnGenereteTree.Size = new System.Drawing.Size(121, 27);
            this.btnGenereteTree.TabIndex = 3;
            this.btnGenereteTree.Text = "Generate Tree";
            this.c1ThemeController1.SetTheme(this.btnGenereteTree, "(default)");
            this.btnGenereteTree.Click += new System.EventHandler(this.btnGenerateTree_Click);
            // 
            // nudLevelsCount
            // 
            this.nudLevelsCount.Location = new System.Drawing.Point(133, 114);
            this.nudLevelsCount.Margin = new System.Windows.Forms.Padding(4);
            this.nudLevelsCount.Name = "nudLevelsCount";
            this.nudLevelsCount.Size = new System.Drawing.Size(94, 25);
            this.nudLevelsCount.TabIndex = 16;
            this.c1ThemeController1.SetTheme(this.nudLevelsCount, "(default)");
            this.nudLevelsCount.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // btnClearTree
            // 
            this.btnClearTree.Location = new System.Drawing.Point(141, 157);
            this.btnClearTree.Name = "btnClearTree";
            this.btnClearTree.Size = new System.Drawing.Size(86, 27);
            this.btnClearTree.TabIndex = 4;
            this.btnClearTree.Text = "Clear Tree";
            this.c1ThemeController1.SetTheme(this.btnClearTree, "(default)");
            this.btnClearTree.Click += new System.EventHandler(this.btnClearTree_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Count of Nodes:";
            this.c1ThemeController1.SetTheme(this.label3, "(default)");
            // 
            // nudColumnsCount
            // 
            this.nudColumnsCount.Location = new System.Drawing.Point(133, 12);
            this.nudColumnsCount.Margin = new System.Windows.Forms.Padding(4);
            this.nudColumnsCount.Name = "nudColumnsCount";
            this.nudColumnsCount.Size = new System.Drawing.Size(94, 25);
            this.nudColumnsCount.TabIndex = 10;
            this.c1ThemeController1.SetTheme(this.nudColumnsCount, "(default)");
            this.nudColumnsCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Count of RootNodes:";
            this.c1ThemeController1.SetTheme(this.label2, "(default)");
            // 
            // nudNodesCount
            // 
            this.nudNodesCount.Location = new System.Drawing.Point(133, 80);
            this.nudNodesCount.Margin = new System.Windows.Forms.Padding(4);
            this.nudNodesCount.Name = "nudNodesCount";
            this.nudNodesCount.Size = new System.Drawing.Size(94, 25);
            this.nudNodesCount.TabIndex = 11;
            this.c1ThemeController1.SetTheme(this.nudNodesCount, "(default)");
            this.nudNodesCount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Count of columns:";
            this.c1ThemeController1.SetTheme(this.label1, "(default)");
            // 
            // c1DockingTabPage2
            // 
            this.c1DockingTabPage2.Controls.Add(this.pgColumn);
            this.c1DockingTabPage2.Controls.Add(this.panel4);
            this.c1DockingTabPage2.Location = new System.Drawing.Point(1, 29);
            this.c1DockingTabPage2.Name = "c1DockingTabPage2";
            this.c1DockingTabPage2.Size = new System.Drawing.Size(362, 570);
            this.c1DockingTabPage2.TabIndex = 1;
            this.c1DockingTabPage2.Text = "Columns";
            // 
            // pgColumn
            // 
            this.pgColumn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgColumn.Location = new System.Drawing.Point(0, 95);
            this.pgColumn.Margin = new System.Windows.Forms.Padding(4);
            this.pgColumn.Name = "pgColumn";
            this.pgColumn.Size = new System.Drawing.Size(362, 475);
            this.pgColumn.TabIndex = 4;
            this.c1ThemeController1.SetTheme(this.pgColumn, "(default)");
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnAddNewColumn);
            this.panel4.Controls.Add(this.cmbSelectedColumn);
            this.panel4.Controls.Add(this.btnRemoveColumn);
            this.panel4.Controls.Add(this.c1Label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(362, 95);
            this.panel4.TabIndex = 1;
            // 
            // btnAddNewColumn
            // 
            this.btnAddNewColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddNewColumn.Location = new System.Drawing.Point(9, 16);
            this.btnAddNewColumn.Name = "btnAddNewColumn";
            this.btnAddNewColumn.Size = new System.Drawing.Size(107, 25);
            this.btnAddNewColumn.TabIndex = 1;
            this.btnAddNewColumn.Text = "Add column";
            this.c1ThemeController1.SetTheme(this.btnAddNewColumn, "(default)");
            this.btnAddNewColumn.Click += new System.EventHandler(this.btnAddNewColumn_Click);
            // 
            // cmbSelectedColumn
            // 
            this.cmbSelectedColumn.Location = new System.Drawing.Point(122, 56);
            this.cmbSelectedColumn.Name = "cmbSelectedColumn";
            this.cmbSelectedColumn.Size = new System.Drawing.Size(134, 24);
            this.cmbSelectedColumn.TabIndex = 3;
            this.c1ThemeController1.SetTheme(this.cmbSelectedColumn, "(default)");
            this.cmbSelectedColumn.SelectedIndexChanged += new System.EventHandler(this.cmbSelectedColumn_SelectedIndexChanged);
            // 
            // btnRemoveColumn
            // 
            this.btnRemoveColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveColumn.Location = new System.Drawing.Point(122, 16);
            this.btnRemoveColumn.Name = "btnRemoveColumn";
            this.btnRemoveColumn.Size = new System.Drawing.Size(134, 25);
            this.btnRemoveColumn.TabIndex = 0;
            this.btnRemoveColumn.Text = "Remove column";
            this.c1ThemeController1.SetTheme(this.btnRemoveColumn, "(default)");
            this.btnRemoveColumn.Click += new System.EventHandler(this.btnRemoveColumn_Click);
            // 
            // c1Label1
            // 
            this.c1Label1.AutoSize = true;
            this.c1Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.c1Label1.Location = new System.Drawing.Point(9, 56);
            this.c1Label1.Name = "c1Label1";
            this.c1Label1.Size = new System.Drawing.Size(107, 23);
            this.c1Label1.TabIndex = 2;
            this.c1Label1.Text = "Current column:";
            this.c1ThemeController1.SetTheme(this.c1Label1, "(default)");
            // 
            // c1DockingTabPage3
            // 
            this.c1DockingTabPage3.Controls.Add(this.pgNode);
            this.c1DockingTabPage3.Controls.Add(this.panel5);
            this.c1DockingTabPage3.Location = new System.Drawing.Point(1, 29);
            this.c1DockingTabPage3.Name = "c1DockingTabPage3";
            this.c1DockingTabPage3.Size = new System.Drawing.Size(362, 570);
            this.c1DockingTabPage3.TabIndex = 2;
            this.c1DockingTabPage3.Text = "Nodes";
            // 
            // pgNode
            // 
            this.pgNode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgNode.Location = new System.Drawing.Point(0, 54);
            this.pgNode.Margin = new System.Windows.Forms.Padding(4);
            this.pgNode.Name = "pgNode";
            this.pgNode.Size = new System.Drawing.Size(362, 516);
            this.pgNode.TabIndex = 0;
            this.c1ThemeController1.SetTheme(this.pgNode, "(default)");
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnRemoveSelectedNodes);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(362, 54);
            this.panel5.TabIndex = 1;
            // 
            // btnRemoveSelectedNodes
            // 
            this.btnRemoveSelectedNodes.Location = new System.Drawing.Point(13, 14);
            this.btnRemoveSelectedNodes.Name = "btnRemoveSelectedNodes";
            this.btnRemoveSelectedNodes.Size = new System.Drawing.Size(161, 29);
            this.btnRemoveSelectedNodes.TabIndex = 1;
            this.btnRemoveSelectedNodes.Text = "Remove selected nodes";
            this.c1ThemeController1.SetTheme(this.btnRemoveSelectedNodes, "(default)");
            this.btnRemoveSelectedNodes.Click += new System.EventHandler(this.btnRemoveSelectedNodes_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.c1TreeView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(614, 600);
            this.panel2.TabIndex = 2;
            this.c1ThemeController1.SetTheme(this.panel2, "(default)");
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
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
            this.splitContainer1.Size = new System.Drawing.Size(983, 600);
            this.splitContainer1.SplitterDistance = 614;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            this.c1ThemeController1.SetTheme(this.splitContainer1, "(default)");
            // 
            // UnboundMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(239)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UnboundMode";
            this.Size = new System.Drawing.Size(983, 600);
            this.c1ThemeController1.SetTheme(this, "(default)");
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).EndInit();
            this.c1DockingTab1.ResumeLayout(false);
            this.c1DockingTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1TreeView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRootNodesCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevelsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumnsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNodesCount)).EndInit();
            this.c1DockingTabPage2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSelectedColumn)).EndInit();
            this.c1DockingTabPage3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
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

